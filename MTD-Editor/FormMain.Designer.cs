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
            System.Windows.Forms.Label lblMTDPath;
            System.Windows.Forms.Label lblMTD;
            System.Windows.Forms.Label lblDescription;
            System.Windows.Forms.Label lblShader;
            System.Windows.Forms.Label lblDescriptionTranslated;
            System.Windows.Forms.Label lblParams;
            System.Windows.Forms.Label lblTextures;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtMTDPath = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvParams = new System.Windows.Forms.DataGridView();
            this.MTDInternalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTDInternalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTDInternalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMTD = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtShader = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnExplore = new System.Windows.Forms.Button();
            this.txtDescriptionTranslated = new System.Windows.Forms.TextBox();
            this.ofdOpenMTD = new System.Windows.Forms.OpenFileDialog();
            this.btnRestore = new System.Windows.Forms.Button();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvTextures = new System.Windows.Forms.DataGridView();
            this.dgvTextureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblMTDPath = new System.Windows.Forms.Label();
            lblMTD = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblShader = new System.Windows.Forms.Label();
            lblDescriptionTranslated = new System.Windows.Forms.Label();
            lblParams = new System.Windows.Forms.Label();
            lblTextures = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTextures)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMTDPath
            // 
            lblMTDPath.AutoSize = true;
            lblMTDPath.Location = new System.Drawing.Point(12, 9);
            lblMTDPath.Name = "lblMTDPath";
            lblMTDPath.Size = new System.Drawing.Size(83, 13);
            lblMTDPath.TabIndex = 0;
            lblMTDPath.Text = "mtd/mtdbnd File";
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
            // dgvParams
            // 
            this.dgvParams.AllowUserToAddRows = false;
            this.dgvParams.AllowUserToDeleteRows = false;
            this.dgvParams.AllowUserToResizeRows = false;
            this.dgvParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MTDInternalName,
            this.MTDInternalType,
            this.MTDInternalValue});
            this.dgvParams.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvParams.Location = new System.Drawing.Point(418, 94);
            this.dgvParams.Name = "dgvParams";
            this.dgvParams.RowHeadersVisible = false;
            this.dgvParams.Size = new System.Drawing.Size(336, 494);
            this.dgvParams.TabIndex = 4;
            this.dgvParams.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMTD_CellEndEdit);
            this.dgvParams.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvMTD_CellValidating);
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
            this.cmbMTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMTD.Enabled = false;
            this.cmbMTD.FormattingEnabled = true;
            this.cmbMTD.Location = new System.Drawing.Point(12, 94);
            this.cmbMTD.Name = "cmbMTD";
            this.cmbMTD.Size = new System.Drawing.Size(400, 21);
            this.cmbMTD.TabIndex = 7;
            this.cmbMTD.SelectedIndexChanged += new System.EventHandler(this.cmbMTD_SelectedIndexChanged);
            // 
            // lblMTD
            // 
            lblMTD.AutoSize = true;
            lblMTD.Location = new System.Drawing.Point(12, 78);
            lblMTD.Name = "lblMTD";
            lblMTD.Size = new System.Drawing.Size(31, 13);
            lblMTD.TabIndex = 8;
            lblMTD.Text = "MTD";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(12, 118);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(60, 13);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 134);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(400, 62);
            this.txtDescription.TabIndex = 10;
            // 
            // txtShader
            // 
            this.txtShader.Location = new System.Drawing.Point(12, 296);
            this.txtShader.Name = "txtShader";
            this.txtShader.Size = new System.Drawing.Size(400, 20);
            this.txtShader.TabIndex = 12;
            // 
            // lblShader
            // 
            lblShader.AutoSize = true;
            lblShader.Location = new System.Drawing.Point(12, 280);
            lblShader.Name = "lblShader";
            lblShader.Size = new System.Drawing.Size(41, 13);
            lblShader.TabIndex = 11;
            lblShader.Text = "Shader";
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
            lblDescriptionTranslated.AutoSize = true;
            lblDescriptionTranslated.Location = new System.Drawing.Point(12, 199);
            lblDescriptionTranslated.Name = "lblDescriptionTranslated";
            lblDescriptionTranslated.Size = new System.Drawing.Size(157, 13);
            lblDescriptionTranslated.TabIndex = 15;
            lblDescriptionTranslated.Text = "Machine Translated Description";
            // 
            // txtDescriptionTranslated
            // 
            this.txtDescriptionTranslated.Location = new System.Drawing.Point(12, 215);
            this.txtDescriptionTranslated.Multiline = true;
            this.txtDescriptionTranslated.Name = "txtDescriptionTranslated";
            this.txtDescriptionTranslated.ReadOnly = true;
            this.txtDescriptionTranslated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionTranslated.Size = new System.Drawing.Size(400, 62);
            this.txtDescriptionTranslated.TabIndex = 16;
            // 
            // ofdOpenMTD
            // 
            this.ofdOpenMTD.FileName = "Mtd.mtdbnd.dcx";
            this.ofdOpenMTD.Filter = "MTD|*.mtd;*.mtd.dcx;*.*bnd;*.*bnd.dcx";
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
            this.llbUpdate.Location = new System.Drawing.Point(12, 597);
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
            this.lblUpdate.Location = new System.Drawing.Point(12, 597);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(112, 13);
            this.lblUpdate.TabIndex = 18;
            this.lblUpdate.Text = "Checking for update...";
            // 
            // lblParams
            // 
            lblParams.AutoSize = true;
            lblParams.Location = new System.Drawing.Point(415, 78);
            lblParams.Name = "lblParams";
            lblParams.Size = new System.Drawing.Size(42, 13);
            lblParams.TabIndex = 20;
            lblParams.Text = "Params";
            // 
            // lblTextures
            // 
            lblTextures.AutoSize = true;
            lblTextures.Location = new System.Drawing.Point(12, 319);
            lblTextures.Name = "lblTextures";
            lblTextures.Size = new System.Drawing.Size(48, 13);
            lblTextures.TabIndex = 21;
            lblTextures.Text = "Textures";
            // 
            // dgvTextures
            // 
            this.dgvTextures.AllowUserToAddRows = false;
            this.dgvTextures.AllowUserToDeleteRows = false;
            this.dgvTextures.AllowUserToResizeColumns = false;
            this.dgvTextures.AllowUserToResizeRows = false;
            this.dgvTextures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTextures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTextures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTextures.ColumnHeadersVisible = false;
            this.dgvTextures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTextureColumn});
            this.dgvTextures.Location = new System.Drawing.Point(12, 335);
            this.dgvTextures.Name = "dgvTextures";
            this.dgvTextures.ReadOnly = true;
            this.dgvTextures.RowHeadersVisible = false;
            this.dgvTextures.ShowEditingIcon = false;
            this.dgvTextures.Size = new System.Drawing.Size(400, 253);
            this.dgvTextures.TabIndex = 22;
            // 
            // dgvTextureColumn
            // 
            this.dgvTextureColumn.DataPropertyName = "Name";
            this.dgvTextureColumn.HeaderText = "Texture";
            this.dgvTextureColumn.Name = "dgvTextureColumn";
            this.dgvTextureColumn.ReadOnly = true;
            this.dgvTextureColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 626);
            this.Controls.Add(this.dgvTextures);
            this.Controls.Add(lblTextures);
            this.Controls.Add(lblParams);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txtDescriptionTranslated);
            this.Controls.Add(lblDescriptionTranslated);
            this.Controls.Add(this.btnExplore);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtShader);
            this.Controls.Add(lblShader);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(lblDescription);
            this.Controls.Add(lblMTD);
            this.Controls.Add(this.cmbMTD);
            this.Controls.Add(this.dgvParams);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtMTDPath);
            this.Controls.Add(lblMTDPath);
            this.Controls.Add(this.llbUpdate);
            this.Controls.Add(this.lblUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(365, 540);
            this.Name = "FormMain";
            this.Text = "MTD Editor <version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTextures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMTDPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvParams;
        private System.Windows.Forms.ComboBox cmbMTD;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtShader;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTDInternalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTDInternalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTDInternalValue;
        private System.Windows.Forms.TextBox txtDescriptionTranslated;
        private System.Windows.Forms.OpenFileDialog ofdOpenMTD;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvTextures;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextureColumn;
    }
}

