using DSFormats;
using Octokit;
using Semver;
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

        private bool dcx;
        private BND mtdbnd;
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
            loadFile(txtMTDPath.Text);

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
                loadFile(txtMTDPath.Text);
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
                loadFile(path);
            }
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
                loadFile(txtMTDPath.Text);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadFile(txtMTDPath.Text);
        }

        private void loadFile(string path)
        {
            if (File.Exists(path))
            {
                string filename = Path.GetFileName(path);
                string extension = Path.GetExtension(filename);
                byte[] bytes = File.ReadAllBytes(path);
                if (extension == ".dcx")
                {
                    dcx = true;
                    bytes = DCX.Decompress(bytes);
                    filename = Path.GetFileNameWithoutExtension(filename);
                    extension = Path.GetExtension(filename);
                }

                cmbMTD.Enabled = false;
                cmbMTD.Items.Clear();
                mtdbnd = null;
                mtd = null;

                if (extension == ".mtdbnd")
                {
                    mtdbnd = BND.Unpack(bytes);
                    List<MTDItem> items = new List<MTDItem>();
                    foreach (BNDEntry entry in mtdbnd.Files)
                        items.Add(new MTDItem(MTD.Read(entry.Bytes), entry.Filename));
                    items.Sort((i1, i2) => i1.Name.CompareTo(i2.Name));
                    cmbMTD.Items.AddRange(items.ToArray());
                    cmbMTD.Enabled = true;
                    cmbMTD.SelectedIndex = 0;
                }
                else if (extension == ".mtd")
                {
                    cmbMTD.Items.Add(new MTDItem(MTD.Read(bytes), filename));
                    cmbMTD.Enabled = false;
                    cmbMTD.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Invalid file type:\n" + path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File not found:\n" + path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = txtMTDPath.Text;
            if (!File.Exists(path + ".bak"))
                File.Copy(path, path + ".bak");

            byte[] bytes;
            if (mtdbnd != null)
            {
                foreach (BNDEntry entry in mtdbnd.Files)
                {
                    foreach (MTDItem item in cmbMTD.Items)
                    {
                        if (entry.Filename == item.Name)
                        {
                            entry.Bytes = item.MTD.Write();
                        }
                    }
                }
                bytes = mtdbnd.Repack();
            }
            else
            {
                bytes = mtd.Write();
            }

            if (dcx)
                bytes = DCX.Compress(bytes);
            File.WriteAllBytes(path, bytes);
        }

        private void cmbMTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMTD.Rows.Clear();
            MTDItem item = cmbMTD.SelectedItem as MTDItem;
            mtd = item.MTD;
            loadMTD(mtd);
        }

        private void loadMTD(MTD mtd)
        {
            txtDescription.Text = mtd.Description;
            txtDescriptionTranslated.Text = MTDTranslations.GetTranslation(mtd.Description);
            txtSPXPath.Text = mtd.SpxPath;

            foreach (MTD.InternalEntry inter in mtd.Internal)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells[0].Value = inter.Name;
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells[1].Value = inter.Type;

                if (inter.Type == MTD.InternalType.Int)
                {
                    if (inter.Name == "g_BlendMode")
                    {
                        DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                        foreach (MTD.BlendMode blendMode in Enum.GetValues(typeof(MTD.BlendMode)))
                            cell.Items.Add(blendMode.ToString());
                        cell.Value = Enum.GetName(typeof(MTD.BlendMode), (int)inter.Value);
                        row.Cells.Add(cell);
                    }
                    else if (inter.Name == "g_LightingType")
                    {
                        DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
                        foreach (MTD.LightingType lightingType in Enum.GetValues(typeof(MTD.LightingType)))
                            cell.Items.Add(lightingType.ToString());
                        cell.Value = Enum.GetName(typeof(MTD.LightingType), (int)inter.Value);
                        row.Cells.Add(cell);
                    }
                    else
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells[2].Value = ((int)inter.Value).ToString();
                    }
                }
                else if (inter.Type == MTD.InternalType.Int2)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    List<string> ints = new List<string>();
                    foreach (int i in (int[])inter.Value)
                        ints.Add(i.ToString());
                    row.Cells[2].Value = string.Join(", ", ints);
                }
                else if (inter.Type == MTD.InternalType.Bool)
                {
                    row.Cells.Add(new DataGridViewCheckBoxCell());
                    row.Cells[2].Value = (bool)inter.Value;
                }
                else if (inter.Type == MTD.InternalType.Float)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells[2].Value = ((float)inter.Value).ToString("0.0##");
                }
                else if (inter.Type == MTD.InternalType.Float2
                    || inter.Type == MTD.InternalType.Float3
                    || inter.Type == MTD.InternalType.Float4)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    List<string> floats = new List<string>();
                    foreach (float f in (float[])inter.Value)
                        floats.Add(f.ToString("0.0##"));
                    row.Cells[2].Value = string.Join(", ", floats);
                }

                dgvMTD.Rows.Add(row);
            }
        }

        private void dgvMTD_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvMTD.Columns[e.ColumnIndex].HeaderText == "Value" && mtd != null)
            {
                object value = e.FormattedValue;
                string valueName = (string)dgvMTD.Rows[e.RowIndex].Cells[0].Value;
                foreach (MTD.InternalEntry entry in mtd.Internal)
                {
                    if (entry.Name == valueName)
                    {
                        if (entry.Type == MTD.InternalType.Int)
                        {
                            if (valueName != "g_BlendMode" && valueName != "g_LightingType")
                                e.Cancel = !Int32.TryParse((string)value, out _);
                        }
                        else if (entry.Type == MTD.InternalType.Int2)
                            e.Cancel = validateInts((string)value, 2);
                        else if (entry.Type == MTD.InternalType.Float)
                            e.Cancel = !Single.TryParse((string)value, out _);
                        else if (entry.Type == MTD.InternalType.Float2)
                            e.Cancel = validateFloats((string)value, 2);
                        else if (entry.Type == MTD.InternalType.Float3)
                            e.Cancel = validateFloats((string)value, 3);
                        else if (entry.Type == MTD.InternalType.Float4)
                            e.Cancel = validateFloats((string)value, 4);
                        break;
                    }
                }
            }
        }

        private bool validateInts(string value, int count)
        {
            string[] values = Regex.Split(value, @"\s*,\s*");
            if (values.Length != count)
                return true;

            foreach (string i in values)
                if (!Int32.TryParse(i, out _))
                    return true;

            return false;
        }

        private bool validateFloats(string value, int count)
        {
            string[] values = Regex.Split(value, @"\s*,\s*");
            if (values.Length != count)
                return true;

            foreach (string f in values)
                if (!Single.TryParse(f, out _))
                    return true;

            return false;
        }

        private void dgvMTD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvMTD.Rows[e.RowIndex];
            object value = row.Cells[e.ColumnIndex].Value;
            string valueName = (string)row.Cells[0].Value;
            foreach (MTD.InternalEntry entry in mtd.Internal)
            {
                if (entry.Name == valueName)
                {
                    if (entry.Type == MTD.InternalType.Int)
                    {
                        if (valueName == "g_BlendMode")
                            entry.Value = (int)Enum.Parse(typeof(MTD.BlendMode), (string)value);
                        else if (valueName == "g_LightingType")
                            entry.Value = (int)Enum.Parse(typeof(MTD.LightingType), (string)value);
                        else
                            entry.Value = Int32.Parse((string)value);
                    }
                    else if (entry.Type == MTD.InternalType.Int2)
                    {
                        string[] values = Regex.Split((string)value, @"\s*,\s*");
                        int[] result = new int[values.Length];
                        for (int i = 0; i < values.Length; i++)
                            result[i] = Int32.Parse(values[i]);
                        entry.Value = result;
                    }
                    else if (entry.Type == MTD.InternalType.Bool)
                        entry.Value = (bool)value;
                    else if (entry.Type == MTD.InternalType.Float)
                        entry.Value = Single.Parse((string)value);
                    else if (entry.Type == MTD.InternalType.Float2
                        || entry.Type == MTD.InternalType.Float3
                        || entry.Type == MTD.InternalType.Float4)
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
