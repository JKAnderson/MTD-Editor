using Octokit;
using Semver;
using SoulsFormats;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace MTD_Editor
{
    public partial class FormMain : Form
    {
        private const string UPDATE_URL = "https://www.nexusmods.com/darksouls/mods/1455?tab=files";
        private static Properties.Settings settings = Properties.Settings.Default;

        private string mtdPath;
        private IBinder mtdBnd;
        private MTD mtd;

        public FormMain()
        {
            InitializeComponent();
            dgvTextures.AutoGenerateColumns = false;
            dgvParams.AutoGenerateColumns = false;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            Text = "MTD Editor " + System.Windows.Forms.Application.ProductVersion;
            Location = settings.WindowLocation;
            Size = settings.WindowSize;
            if (settings.WindowMaximized)
                WindowState = FormWindowState.Maximized;

            splitContainer1.SplitterDistance = settings.SplitterDistance1;
            mtdPath = settings.MTDPath;
            LoadFile(mtdPath, true);

            GitHubClient gitHubClient = new GitHubClient(new ProductHeaderValue("MTD-Editor"));
            try
            {
                Release release = await gitHubClient.Repository.Release.GetLatest("JKAnderson", "MTD-Editor");
                if (SemVersion.Parse(release.TagName) > System.Windows.Forms.Application.ProductVersion)
                {
                    updateToolStripMenuItem.Visible = true;
                }
            }
            catch { }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.WindowMaximized = WindowState == FormWindowState.Maximized;
            if (WindowState == FormWindowState.Normal)
            {
                settings.WindowLocation = Location;
                settings.WindowSize = Size;
            }
            else
            {
                settings.WindowLocation = RestoreBounds.Location;
                settings.WindowSize = RestoreBounds.Size;
            }

            settings.SplitterDistance1 = splitContainer1.SplitterDistance;
            settings.MTDPath = mtdPath;
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                mtdPath = files[0];
                LoadFile(mtdPath);
            }
        }

        private void LoadFile(string path, bool silent = false)
        {
            statusStripMTDPath.Text = "";
            if (!File.Exists(path))
            {
                ShowError($"File not found:\r\n{path}", silent);
                return;
            }

            string filename = Path.GetFileName(path);
            string extension = SFUtil.GetRealExtension(filename);

            cmbMTD.Enabled = false;
            cmbMTD.Items.Clear();

            mtdBnd = null;
            mtd = null;

            var mtdItems = new List<MTDWrapper>();

            try
            {
                if (MTD.Is(path))
                {
                    mtdItems.Add(new MTDWrapper(MTD.Read(path), filename));
                }
                else if (BND3.Is(path))
                {
                    mtdBnd = BND3.Read(path);
                    foreach (BinderFile file in mtdBnd.Files)
                    {
                        if (MTD.Is(file.Bytes))
                            mtdItems.Add(new MTDWrapper(MTD.Read(file.Bytes), file.Name));
                    }
                }
                else if (BND4.Is(path))
                {
                    mtdBnd = BND4.Read(path);
                    foreach (BinderFile file in mtdBnd.Files)
                    {
                        if (MTD.Is(file.Bytes))
                            mtdItems.Add(new MTDWrapper(MTD.Read(file.Bytes), file.Name));
                    }
                }
                else
                {
                    ShowError($"Unrecognized file type:\r\n{path}", silent);
                    return;
                }
            }
            catch (Exception ex)
            {
                ShowError($"Failed to load file:\r\n{path}\r\n{ex}", silent);
                return;
            }

            statusStripMTDPath.Text = path;
            mtdItems.Sort((i1, i2) => i1.Name.CompareTo(i2.Name));
            cmbMTD.Items.AddRange(mtdItems.ToArray());
            cmbMTD.SelectedIndex = 0;

            if (mtdItems.Count > 1)
                cmbMTD.Enabled = true;
        }

        private void CmbMTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvParams.DataSource = null;
            dgvTextures.DataSource = null;
            MTDWrapper item = cmbMTD.SelectedItem as MTDWrapper;
            mtd = item.MTD;
            LoadMTD(mtd);
        }

        private void LoadMTD(MTD mtd)
        {
            txtDescription.DataBindings.Clear();
            txtDescription.DataBindings.Add("Text", mtd, "Description");
            txtDescriptionTranslated.Text = MTDTranslations.GetTranslation(mtd.Description);

            txtShader.DataBindings.Clear();
            txtShader.DataBindings.Add("Text", mtd, "ShaderPath");

            dgvTextures.DataSource = mtd.Textures;
            bool extended = mtd.Textures.Any(t => t.Extended);
            dgvTexturesFloatsCol.Visible = extended;
            dgvTexturesPathCol.Visible = extended;

            dgvParams.DataSource = mtd.Params;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ofdOpenMTD.InitialDirectory = Path.GetDirectoryName(Path.GetFullPath(mtdPath));
            }
            catch (ArgumentException) { }

            if (ofdOpenMTD.ShowDialog() == DialogResult.OK)
            {
                mtdPath = ofdOpenMTD.FileName;
                LoadFile(mtdPath);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(mtdPath + ".bak"))
                File.Copy(mtdPath, mtdPath + ".bak");

            if (mtdBnd != null)
            {
                foreach (BinderFile entry in mtdBnd.Files)
                {
                    foreach (MTDWrapper item in cmbMTD.Items)
                    {
                        if (entry.Name == item.Name)
                        {
                            entry.Bytes = item.MTD.Write();
                        }
                    }
                }

                if (mtdBnd is BND3 bnd3)
                    bnd3.Write(mtdPath);
                else if (mtdBnd is BND4 bnd4)
                    bnd4.Write(mtdPath);
            }
            else
            {
                mtd.Write(mtdPath);
            }

            SystemSounds.Asterisk.Play();
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(mtdPath + ".bak"))
            {
                File.Delete(mtdPath);
                File.Move(mtdPath + ".bak", mtdPath);
                LoadFile(mtdPath);
            }

            SystemSounds.Asterisk.Play();
        }

        private void ExploreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Path.GetDirectoryName(Path.GetFullPath(mtdPath)));
            }
            catch
            {
                SystemSounds.Hand.Play();
            }
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(UPDATE_URL);
        }

        #region dgvTextures
        private void DgvTextures_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is List<float> floats)
            {
                e.Value = string.Join(", ", floats.Select(f => f.ToString("0.0##")));
                e.FormattingApplied = true;
            }
        }

        private void DgvTextures_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvTextures.Columns[e.ColumnIndex].ValueType == typeof(List<float>))
                e.Cancel = !TryParseFloats((string)e.FormattedValue, 2, out _);

            if (e.Cancel)
                SystemSounds.Hand.Play();
        }

        private void DgvTextures_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.DesiredType == typeof(List<float>))
            {
                TryParseFloats((string)e.Value, 2, out float[] floats);
                e.Value = new List<float>(floats);
                e.ParsingApplied = true;
            }
        }
        #endregion

        #region dgvParams
        private void DgvParams_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvParams.Rows)
            {
                var param = (MTD.Param)row.DataBoundItem;
                if (param.Type == MTD.ParamType.Bool)
                {
                    row.Cells[2] = new DataGridViewCheckBoxCell();
                }
                else if (param.Name == "g_BlendMode")
                {
                    var cell = new DataGridViewComboBoxCell();
                    cell.DataSource = EnumWrapper.Wrap(typeof(MTD.BlendMode));
                    cell.DisplayMember = "Name";
                    cell.ValueMember = "Value";
                    row.Cells[2] = cell;
                }
                else if (param.Name == "g_LightingType")
                {
                    var cell = new DataGridViewComboBoxCell();
                    cell.DataSource = EnumWrapper.Wrap(typeof(MTD.LightingType));
                    cell.DisplayMember = "Name";
                    cell.ValueMember = "Value";
                    row.Cells[2] = cell;
                }
                else
                {
                    row.Cells[2].ValueType = param.Value.GetType();
                }
            }
        }

        private void DgvParams_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != 2)
                return;

            DataGridViewRow row = dgvParams.Rows[e.RowIndex];
            var param = (MTD.Param)row.DataBoundItem;
            if (e.Value is int[] ints)
            {
                e.Value = string.Join(", ", ints.Select(i => i.ToString()));
                e.FormattingApplied = true;
            }
            else if (e.Value is float[] floats)
            {
                e.Value = string.Join(", ", floats.Select(f => f.ToString("0.0##")));
                e.FormattingApplied = true;
            }
        }

        private void DgvParams_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex != 2)
                return;

            DataGridViewRow row = dgvParams.Rows[e.RowIndex];
            var param = (MTD.Param)row.DataBoundItem;
            if (param.Type == MTD.ParamType.Int2)
                e.Cancel = !TryParseInts((string)e.FormattedValue, 2, out _);
            else if (param.Type == MTD.ParamType.Float2)
                e.Cancel = !TryParseFloats((string)e.FormattedValue, 2, out _);
            else if (param.Type == MTD.ParamType.Float3)
                e.Cancel = !TryParseFloats((string)e.FormattedValue, 3, out _);
            else if (param.Type == MTD.ParamType.Float4)
                e.Cancel = !TryParseFloats((string)e.FormattedValue, 4, out _);

            if (e.Cancel)
                SystemSounds.Hand.Play();
        }

        private void DgvParams_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex != 2)
                return;

            DataGridViewRow row = dgvParams.Rows[e.RowIndex];
            var param = (MTD.Param)row.DataBoundItem;
            if (param.Type == MTD.ParamType.Int2)
            {
                TryParseInts((string)e.Value, 2, out int[] ints);
                e.Value = ints;
                e.ParsingApplied = true;
            }
            else if (param.Type == MTD.ParamType.Float2)
            {
                TryParseFloats((string)e.Value, 2, out float[] floats);
                e.Value = floats;
                e.ParsingApplied = true;
            }
            else if (param.Type == MTD.ParamType.Float3)
            {
                TryParseFloats((string)e.Value, 3, out float[] floats);
                e.Value = floats;
                e.ParsingApplied = true;
            }
            else if (param.Type == MTD.ParamType.Float4)
            {
                TryParseFloats((string)e.Value, 4, out float[] floats);
                e.Value = floats;
                e.ParsingApplied = true;
            }
        }
        #endregion

        private bool TryParseInts(string text, int count, out int[] ints)
        {
            try
            {
                ints = text.Split(',').Select(s => int.Parse(s)).ToArray();
                return ints.Length == count;
            }
            catch
            {
                ints = null;
                return false;
            }
        }

        private bool TryParseFloats(string text, int count, out float[] floats)
        {
            try
            {
                floats = text.Split(',').Select(s => float.Parse(s)).ToArray();
                return floats.Length == count;
            }
            catch
            {
                floats = null;
                return false;
            }
        }

        private void ShowError(string message, bool silent = false)
        {
            if (!silent)
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
