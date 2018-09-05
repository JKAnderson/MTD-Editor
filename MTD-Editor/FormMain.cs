using Octokit;
using Semver;
using SoulsFormats;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MTD_Editor
{
    public partial class FormMain : Form
    {
        private static Properties.Settings settings = Properties.Settings.Default;

        private BND3 mtdBND3;
        private BND4 mtdBND4;
        private MTD mtd;

        public FormMain()
        {
            InitializeComponent();
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            Text = "MTD Editor " + System.Windows.Forms.Application.ProductVersion;
            Location = settings.WindowLocation;
            Size = settings.WindowSize;
            if (settings.WindowMaximized)
                WindowState = FormWindowState.Maximized;

            txtMTDPath.Text = settings.MTDPath;
            LoadFile(txtMTDPath.Text, true);

            GitHubClient gitHubClient = new GitHubClient(new ProductHeaderValue("MTD-Editor"));
            try
            {
                Release release = await gitHubClient.Repository.Release.GetLatest("JKAnderson", "MTD-Editor");
                if (SemVersion.Parse(release.TagName) > System.Windows.Forms.Application.ProductVersion)
                {
                    lblUpdate.Visible = false;
                    LinkLabel.Link link = new LinkLabel.Link();
                    link.LinkData = release.HtmlUrl;
                    llbUpdate.Links.Add(link);
                    llbUpdate.Visible = true;
                }
                else
                {
                    lblUpdate.Text = "App up to date";
                }
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is ApiException || ex is ArgumentException)
            {
                lblUpdate.Text = "Update status unknown";
            }
        }

        private void llbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
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

            settings.MTDPath = txtMTDPath.Text;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                ofdOpenMTD.InitialDirectory = Path.GetDirectoryName(Path.GetFullPath(txtMTDPath.Text));
            }
            catch (ArgumentException) { }

            if (ofdOpenMTD.ShowDialog() == DialogResult.OK)
            {
                txtMTDPath.Text = ofdOpenMTD.FileName;
                LoadFile(txtMTDPath.Text);
            }
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Path.GetDirectoryName(Path.GetFullPath(txtMTDPath.Text)));
            }
            catch (ArgumentException)
            {
                SystemSounds.Hand.Play();
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string path = txtMTDPath.Text;
            if (File.Exists(path + ".bak"))
            {
                File.Delete(path);
                File.Move(path + ".bak", path);
                LoadFile(path);
            }

            SystemSounds.Asterisk.Play();
        }

        private void txtMTDPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtMTDPath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtMTDPath.Text = files[0];
                LoadFile(txtMTDPath.Text);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFile(txtMTDPath.Text);
        }

        private void LoadFile(string path, bool silent = false)
        {
            if (!File.Exists(path))
            {
                ShowError($"File not found:\r\n{path}", silent);
                return;
            }

            string filename = Path.GetFileName(path);
            string extension = Util.GetRealExtension(filename);

            cmbMTD.Enabled = false;
            cmbMTD.Items.Clear();

            mtdBND3 = null;
            mtdBND4 = null;
            mtd = null;

            var mtdItems = new List<MTDItem>();

            try
            {
                if (MTD.Is(path))
                {
                    mtdItems.Add(new MTDItem(MTD.Read(path), filename));
                }
                else if (BND3.Is(path))
                {
                    mtdBND3 = BND3.Read(path);
                    foreach (BND3.File file in mtdBND3.Files)
                    {
                        if (MTD.Is(file.Bytes))
                            mtdItems.Add(new MTDItem(MTD.Read(file.Bytes), file.Name));
                    }
                }
                else if (BND4.Is(path))
                {
                    mtdBND4 = BND4.Read(path);
                    foreach (BND4.File file in mtdBND4.Files)
                    {
                        if (MTD.Is(file.Bytes))
                            mtdItems.Add(new MTDItem(MTD.Read(file.Bytes), file.Name));
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

            mtdItems.Sort((i1, i2) => i1.Name.CompareTo(i2.Name));
            cmbMTD.Items.AddRange(mtdItems.ToArray());
            cmbMTD.SelectedIndex = 0;

            if (mtdItems.Count > 1)
                cmbMTD.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = txtMTDPath.Text;
            if (!File.Exists(path + ".bak"))
                File.Copy(path, path + ".bak");

            if (mtdBND3 != null)
            {
                foreach (BND3.File entry in mtdBND3.Files)
                {
                    foreach (MTDItem item in cmbMTD.Items)
                    {
                        if (entry.Name == item.Name)
                        {
                            entry.Bytes = item.MTD.Write();
                        }
                    }
                }
                mtdBND3.Write(path);
            }
            else if (mtdBND4 != null)
            {
                foreach (BND4.File entry in mtdBND4.Files)
                {
                    foreach (MTDItem item in cmbMTD.Items)
                    {
                        if (entry.Name == item.Name)
                        {
                            entry.Bytes = item.MTD.Write();
                        }
                    }
                }
                mtdBND4.Write(path);
            }
            else
            {
                mtd.Write(path);
            }

            SystemSounds.Asterisk.Play();
        }

        private void cmbMTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvParams.Rows.Clear();
            MTDItem item = cmbMTD.SelectedItem as MTDItem;
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

            foreach (MTD.Param param in mtd.Params)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells[0].Value = param.Name;
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells[1].Value = param.Type;

                if (param.Type == MTD.ParamType.Int)
                {
                    if (param.Name == "g_BlendMode")
                    {
                        DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                        foreach (MTD.BlendMode blendMode in Enum.GetValues(typeof(MTD.BlendMode)))
                            cell.Items.Add(blendMode.ToString());
                        cell.Value = Enum.GetName(typeof(MTD.BlendMode), (int)param.Value);
                        row.Cells.Add(cell);
                    }
                    else if (param.Name == "g_LightingType")
                    {
                        DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                        foreach (MTD.LightingType lightingType in Enum.GetValues(typeof(MTD.LightingType)))
                            cell.Items.Add(lightingType.ToString());
                        cell.Value = Enum.GetName(typeof(MTD.LightingType), (int)param.Value);
                        row.Cells.Add(cell);
                    }
                    else
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells[2].Value = ((int)param.Value).ToString();
                    }
                }
                else if (param.Type == MTD.ParamType.Int2)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    List<string> ints = new List<string>();
                    foreach (int i in (int[])param.Value)
                        ints.Add(i.ToString());
                    row.Cells[2].Value = string.Join(", ", ints);
                }
                else if (param.Type == MTD.ParamType.Bool)
                {
                    row.Cells.Add(new DataGridViewCheckBoxCell());
                    row.Cells[2].Value = (bool)param.Value;
                }
                else if (param.Type == MTD.ParamType.Float)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells[2].Value = ((float)param.Value).ToString("0.0##");
                }
                else if (param.Type == MTD.ParamType.Float2
                    || param.Type == MTD.ParamType.Float3
                    || param.Type == MTD.ParamType.Float4)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    List<string> floats = new List<string>();
                    foreach (float f in (float[])param.Value)
                        floats.Add(f.ToString("0.0##"));
                    row.Cells[2].Value = string.Join(", ", floats);
                }

                dgvParams.Rows.Add(row);
            }
        }

        private void dgvMTD_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvParams.Columns[e.ColumnIndex].HeaderText == "Value" && mtd != null)
            {
                object value = e.FormattedValue;
                string valueName = (string)dgvParams.Rows[e.RowIndex].Cells[0].Value;
                foreach (MTD.Param entry in mtd.Params)
                {
                    if (entry.Name == valueName)
                    {
                        if (entry.Type == MTD.ParamType.Int)
                        {
                            if (valueName != "g_BlendMode" && valueName != "g_LightingType")
                                e.Cancel = !int.TryParse((string)value, out _);
                        }
                        else if (entry.Type == MTD.ParamType.Int2)
                            e.Cancel = ValidateInts((string)value, 2);
                        else if (entry.Type == MTD.ParamType.Float)
                            e.Cancel = !float.TryParse((string)value, out _);
                        else if (entry.Type == MTD.ParamType.Float2)
                            e.Cancel = ValidateFloats((string)value, 2);
                        else if (entry.Type == MTD.ParamType.Float3)
                            e.Cancel = ValidateFloats((string)value, 3);
                        else if (entry.Type == MTD.ParamType.Float4)
                            e.Cancel = ValidateFloats((string)value, 4);
                        break;
                    }
                }
            }
        }

        private bool ValidateInts(string value, int count)
        {
            string[] values = Regex.Split(value, @"\s*,\s*");
            if (values.Length != count)
                return true;

            foreach (string i in values)
                if (!int.TryParse(i, out _))
                    return true;

            return false;
        }

        private bool ValidateFloats(string value, int count)
        {
            string[] values = Regex.Split(value, @"\s*,\s*");
            if (values.Length != count)
                return true;

            foreach (string f in values)
                if (!float.TryParse(f, out _))
                    return true;

            return false;
        }

        private void dgvMTD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvParams.Rows[e.RowIndex];
            object value = row.Cells[e.ColumnIndex].Value;
            string valueName = (string)row.Cells[0].Value;
            foreach (MTD.Param entry in mtd.Params)
            {
                if (entry.Name == valueName)
                {
                    if (entry.Type == MTD.ParamType.Int)
                    {
                        if (valueName == "g_BlendMode")
                            entry.Value = (int)Enum.Parse(typeof(MTD.BlendMode), (string)value);
                        else if (valueName == "g_LightingType")
                            entry.Value = (int)Enum.Parse(typeof(MTD.LightingType), (string)value);
                        else
                            entry.Value = Int32.Parse((string)value);
                    }
                    else if (entry.Type == MTD.ParamType.Int2)
                    {
                        string[] values = Regex.Split((string)value, @"\s*,\s*");
                        int[] result = new int[values.Length];
                        for (int i = 0; i < values.Length; i++)
                            result[i] = Int32.Parse(values[i]);
                        entry.Value = result;
                    }
                    else if (entry.Type == MTD.ParamType.Bool)
                        entry.Value = (bool)value;
                    else if (entry.Type == MTD.ParamType.Float)
                        entry.Value = Single.Parse((string)value);
                    else if (entry.Type == MTD.ParamType.Float2
                        || entry.Type == MTD.ParamType.Float3
                        || entry.Type == MTD.ParamType.Float4)
                    {
                        string[] values = Regex.Split((string)value, @"\s*,\s*");
                        float[] result = new float[values.Length];
                        for (int i = 0; i < values.Length; i++)
                            result[i] = Single.Parse(values[i]);
                        entry.Value = result;
                    }
                }
            }
        }

        private void ShowError(string message, bool silent = false)
        {
            if (!silent)
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private class MTDItem
        {
            public MTD MTD;
            public string Name;

            public MTDItem(MTD mtd, string name)
            {
                MTD = mtd;
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}
