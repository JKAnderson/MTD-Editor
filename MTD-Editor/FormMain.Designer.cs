namespace MTD_Editor
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblMTDPath = new System.Windows.Forms.Label();
            this.txtMTDPath = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvMTD = new System.Windows.Forms.DataGridView();
            this.MTDInternalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTDInternalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTDInternalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMTD = new System.Windows.Forms.ComboBox();
            this.lblMTD = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSPXPath = new System.Windows.Forms.TextBox();
            this.lblSPXPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnExplore = new System.Windows.Forms.Button();
            this.lblDescriptionTranslated = new System.Windows.Forms.Label();
            this.txtDescriptionTranslated = new System.Windows.Forms.TextBox();
            this.ofdOpenMTD = new System.Windows.Forms.OpenFileDialog();
            this.btnRestore = new System.Windows.Forms.Button();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMTDPath
            // 
            this.lblMTDPath.AutoSize = true;
            this.lblMTDPath.Location = new System.Drawing.Point(12, 9);
            this.lblMTDPath.Name = "lblMTDPath";
            this.lblMTDPath.Size = new System.Drawing.Size(83, 13);
            this.lblMTDPath.TabIndex = 0;
            this.lblMTDPath.Text = "mtd/mtdbnd File";
            // 
            // txtMTDPath
            // 
            this.txtMTDPath.AllowDrop = true;
            this.txtMTDPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMTDPath.Location = new System.Drawing.Point(12, 25);
            this.txtMTDPath.Name = "txtMTDPath";
            this.txtMTDPath.Size = new System.Drawing.Size(580, 20);
            this.txtMTDPath.TabIndex = 1;
            this.txtMTDPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\DARK SOULS REMASTERED\\mtd\\Mtd.mtdbn" +
    "d.dcx";
            this.txtMTDPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtMTDPath_DragDrop);
            this.txtMTDPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtMTDPath_DragEnter);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(517, 52);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(598, 52);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvMTD
            // 
            this.dgvMTD.AllowUserToAddRows = false;
            this.dgvMTD.AllowUserToDeleteRows = false;
            this.dgvMTD.AllowUserToResizeRows = false;
            this.dgvMTD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMTD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MTDInternalName,
            this.MTDInternalType,
            this.MTDInternalValue});
            this.dgvMTD.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMTD.Location = new System.Drawing.Point(12, 309);
            this.dgvMTD.Name = "dgvMTD";
            this.dgvMTD.RowHeadersVisible = false;
            this.dgvMTD.Size = new System.Drawing.Size(742, 292);
            this.dgvMTD.TabIndex = 4;
            this.dgvMTD.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMTD_CellEndEdit);
            this.dgvMTD.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvMTD_CellValidating);
            // 
            // MTDInternalName
            // 
            this.MTDInternalName.HeaderText = "Name";
            this.MTDInternalName.Name = "MTDInternalName";
            this.MTDInternalName.ReadOnly = true;
            // 
            // MTDInternalType
            // 
            this.MTDInternalType.HeaderText = "Type";
            this.MTDInternalType.Name = "MTDInternalType";
            this.MTDInternalType.ReadOnly = true;
            // 
            // MTDInternalValue
            // 
            this.MTDInternalValue.HeaderText = "Value";
            this.MTDInternalValue.Name = "MTDInternalValue";
            // 
            // cmbMTD
            // 
            this.cmbMTD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMTD.Enabled = false;
            this.cmbMTD.FormattingEnabled = true;
            this.cmbMTD.Location = new System.Drawing.Point(12, 81);
            this.cmbMTD.Name = "cmbMTD";
            this.cmbMTD.Size = new System.Drawing.Size(742, 21);
            this.cmbMTD.TabIndex = 7;
            this.cmbMTD.SelectedIndexChanged += new System.EventHandler(this.cmbMTD_SelectedIndexChanged);
            // 
            // lblMTD
            // 
            this.lblMTD.AutoSize = true;
            this.lblMTD.Location = new System.Drawing.Point(12, 65);
            this.lblMTD.Name = "lblMTD";
            this.lblMTD.Size = new System.Drawing.Size(31, 13);
            this.lblMTD.TabIndex = 8;
            this.lblMTD.Text = "MTD";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 105);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(12, 121);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(742, 62);
            this.txtDescription.TabIndex = 10;
            // 
            // txtSPXPath
            // 
            this.txtSPXPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSPXPath.Location = new System.Drawing.Point(12, 283);
            this.txtSPXPath.Name = "txtSPXPath";
            this.txtSPXPath.ReadOnly = true;
            this.txtSPXPath.Size = new System.Drawing.Size(742, 20);
            this.txtSPXPath.TabIndex = 12;
            // 
            // lblSPXPath
            // 
            this.lblSPXPath.AutoSize = true;
            this.lblSPXPath.Location = new System.Drawing.Point(12, 267);
            this.lblSPXPath.Name = "lblSPXPath";
            this.lblSPXPath.Size = new System.Drawing.Size(53, 13);
            this.lblSPXPath.TabIndex = 11;
            this.lblSPXPath.Text = "SPX Path";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(598, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExplore.Location = new System.Drawing.Point(679, 23);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(75, 23);
            this.btnExplore.TabIndex = 14;
            this.btnExplore.Text = "Explore";
            this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // lblDescriptionTranslated
            // 
            this.lblDescriptionTranslated.AutoSize = true;
            this.lblDescriptionTranslated.Location = new System.Drawing.Point(12, 186);
            this.lblDescriptionTranslated.Name = "lblDescriptionTranslated";
            this.lblDescriptionTranslated.Size = new System.Drawing.Size(157, 13);
            this.lblDescriptionTranslated.TabIndex = 15;
            this.lblDescriptionTranslated.Text = "Machine Translated Description";
            // 
            // txtDescriptionTranslated
            // 
            this.txtDescriptionTranslated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescriptionTranslated.Location = new System.Drawing.Point(12, 202);
            this.txtDescriptionTranslated.Multiline = true;
            this.txtDescriptionTranslated.Name = "txtDescriptionTranslated";
            this.txtDescriptionTranslated.ReadOnly = true;
            this.txtDescriptionTranslated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionTranslated.Size = new System.Drawing.Size(742, 62);
            this.txtDescriptionTranslated.TabIndex = 16;
            // 
            // ofdOpenMTD
            // 
            this.ofdOpenMTD.FileName = "Mtd.mtdbnd.dcx";
            this.ofdOpenMTD.Filter = "MTD|*.mtd;*.mtd.dcx;*.mtdbnd;*.mtdbnd.dcx";
            this.ofdOpenMTD.Title = "Select an .mtd or .mtdbnd to open";
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(679, 52);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 17;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // llbUpdate
            // 
            this.llbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llbUpdate.AutoSize = true;
            this.llbUpdate.Location = new System.Drawing.Point(12, 604);
            this.llbUpdate.Name = "llbUpdate";
            this.llbUpdate.Size = new System.Drawing.Size(114, 13);
            this.llbUpdate.TabIndex = 19;
            this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "New version available!";
            this.llbUpdate.Visible = false;
            this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdate_LinkClicked);
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(12, 604);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(112, 13);
            this.lblUpdate.TabIndex = 18;
            this.lblUpdate.Text = "Checking for update...";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 626);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txtDescriptionTranslated);
            this.Controls.Add(this.lblDescriptionTranslated);
            this.Controls.Add(this.btnExplore);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSPXPath);
            this.Controls.Add(this.lblSPXPath);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblMTD);
            this.Controls.Add(this.cmbMTD);
            this.Controls.Add(this.dgvMTD);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtMTDPath);
            this.Controls.Add(this.lblMTDPath);
            this.Controls.Add(this.llbUpdate);
            this.Controls.Add(this.lblUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(365, 463);
            this.Name = "FormMain";
            this.Text = "MTD Editor <version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMTDPath;
        private System.Windows.Forms.TextBox txtMTDPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvMTD;
        private System.Windows.Forms.ComboBox cmbMTD;
        private System.Windows.Forms.Label lblMTD;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSPXPath;
        private System.Windows.Forms.Label lblSPXPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTDInternalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTDInternalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTDInternalValue;
        private System.Windows.Forms.Label lblDescriptionTranslated;
        private System.Windows.Forms.TextBox txtDescriptionTranslated;
        private System.Windows.Forms.OpenFileDialog ofdOpenMTD;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

