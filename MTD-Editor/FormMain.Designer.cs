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
            System.Windows.Forms.Label lblDescription;
            System.Windows.Forms.Label lblShader;
            System.Windows.Forms.Label lblDescriptionTranslated;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dgvParams = new System.Windows.Forms.DataGridView();
            this.cmbMTD = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtShader = new System.Windows.Forms.TextBox();
            this.txtDescriptionTranslated = new System.Windows.Forms.TextBox();
            this.ofdOpenMTD = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvTextures = new System.Windows.Forms.DataGridView();
            this.dgvTexturesTextureCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTexturesPathCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTexturesUVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTexturesShaderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTexturesFloatsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripMTDPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exploreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MTDInternalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTDInternalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTDInternalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblDescription = new System.Windows.Forms.Label();
            lblShader = new System.Windows.Forms.Label();
            lblDescriptionTranslated = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTextures)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(3, 27);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(60, 13);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description";
            // 
            // lblShader
            // 
            lblShader.AutoSize = true;
            lblShader.Location = new System.Drawing.Point(3, 189);
            lblShader.Name = "lblShader";
            lblShader.Size = new System.Drawing.Size(41, 13);
            lblShader.TabIndex = 11;
            lblShader.Text = "Shader";
            // 
            // lblDescriptionTranslated
            // 
            lblDescriptionTranslated.AutoSize = true;
            lblDescriptionTranslated.Location = new System.Drawing.Point(3, 108);
            lblDescriptionTranslated.Name = "lblDescriptionTranslated";
            lblDescriptionTranslated.Size = new System.Drawing.Size(157, 13);
            lblDescriptionTranslated.TabIndex = 15;
            lblDescriptionTranslated.Text = "Machine Translated Description";
            // 
            // dgvParams
            // 
            this.dgvParams.AllowUserToAddRows = false;
            this.dgvParams.AllowUserToDeleteRows = false;
            this.dgvParams.AllowUserToResizeColumns = false;
            this.dgvParams.AllowUserToResizeRows = false;
            this.dgvParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MTDInternalType,
            this.MTDInternalName,
            this.MTDInternalValue});
            this.dgvParams.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvParams.Location = new System.Drawing.Point(3, 3);
            this.dgvParams.Name = "dgvParams";
            this.dgvParams.RowHeadersVisible = false;
            this.dgvParams.Size = new System.Drawing.Size(358, 535);
            this.dgvParams.TabIndex = 4;
            this.dgvParams.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvParams_CellFormatting);
            this.dgvParams.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DgvParams_CellParsing);
            this.dgvParams.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvParams_CellValidating);
            this.dgvParams.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvParams_DataBindingComplete);
            // 
            // cmbMTD
            // 
            this.cmbMTD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMTD.Enabled = false;
            this.cmbMTD.FormattingEnabled = true;
            this.cmbMTD.Location = new System.Drawing.Point(3, 3);
            this.cmbMTD.Name = "cmbMTD";
            this.cmbMTD.Size = new System.Drawing.Size(672, 21);
            this.cmbMTD.TabIndex = 7;
            this.cmbMTD.SelectedIndexChanged += new System.EventHandler(this.CmbMTD_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(3, 43);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(672, 62);
            this.txtDescription.TabIndex = 10;
            // 
            // txtShader
            // 
            this.txtShader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShader.Location = new System.Drawing.Point(3, 205);
            this.txtShader.Name = "txtShader";
            this.txtShader.Size = new System.Drawing.Size(672, 20);
            this.txtShader.TabIndex = 12;
            // 
            // txtDescriptionTranslated
            // 
            this.txtDescriptionTranslated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescriptionTranslated.Location = new System.Drawing.Point(3, 124);
            this.txtDescriptionTranslated.Multiline = true;
            this.txtDescriptionTranslated.Name = "txtDescriptionTranslated";
            this.txtDescriptionTranslated.ReadOnly = true;
            this.txtDescriptionTranslated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionTranslated.Size = new System.Drawing.Size(672, 62);
            this.txtDescriptionTranslated.TabIndex = 16;
            // 
            // ofdOpenMTD
            // 
            this.ofdOpenMTD.FileName = "Mtd.mtdbnd.dcx";
            this.ofdOpenMTD.Filter = "MTD|*.mtd;*.mtd.dcx;*.*bnd;*.*bnd.dcx";
            this.ofdOpenMTD.Title = "Select an .mtd or .mtdbnd to open";
            // 
            // dgvTextures
            // 
            this.dgvTextures.AllowUserToAddRows = false;
            this.dgvTextures.AllowUserToDeleteRows = false;
            this.dgvTextures.AllowUserToResizeColumns = false;
            this.dgvTextures.AllowUserToResizeRows = false;
            this.dgvTextures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTextures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTextures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTextures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTextures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTexturesTextureCol,
            this.dgvTexturesPathCol,
            this.dgvTexturesUVCol,
            this.dgvTexturesShaderCol,
            this.dgvTexturesFloatsCol});
            this.dgvTextures.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTextures.Location = new System.Drawing.Point(3, 244);
            this.dgvTextures.Name = "dgvTextures";
            this.dgvTextures.RowHeadersVisible = false;
            this.dgvTextures.ShowEditingIcon = false;
            this.dgvTextures.Size = new System.Drawing.Size(672, 294);
            this.dgvTextures.TabIndex = 22;
            this.dgvTextures.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvTextures_CellFormatting);
            this.dgvTextures.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DgvTextures_CellParsing);
            this.dgvTextures.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvTextures_CellValidating);
            // 
            // dgvTexturesTextureCol
            // 
            this.dgvTexturesTextureCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTexturesTextureCol.DataPropertyName = "Type";
            this.dgvTexturesTextureCol.HeaderText = "Texture";
            this.dgvTexturesTextureCol.Name = "dgvTexturesTextureCol";
            this.dgvTexturesTextureCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTexturesPathCol
            // 
            this.dgvTexturesPathCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTexturesPathCol.DataPropertyName = "Path";
            this.dgvTexturesPathCol.HeaderText = "Path";
            this.dgvTexturesPathCol.Name = "dgvTexturesPathCol";
            // 
            // dgvTexturesUVCol
            // 
            this.dgvTexturesUVCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTexturesUVCol.DataPropertyName = "UVNumber";
            this.dgvTexturesUVCol.HeaderText = "UV Number";
            this.dgvTexturesUVCol.Name = "dgvTexturesUVCol";
            this.dgvTexturesUVCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvTexturesUVCol.Width = 68;
            // 
            // dgvTexturesShaderCol
            // 
            this.dgvTexturesShaderCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTexturesShaderCol.DataPropertyName = "ShaderDataIndex";
            this.dgvTexturesShaderCol.HeaderText = "Shader Data Index";
            this.dgvTexturesShaderCol.Name = "dgvTexturesShaderCol";
            this.dgvTexturesShaderCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvTexturesShaderCol.Width = 102;
            // 
            // dgvTexturesFloatsCol
            // 
            this.dgvTexturesFloatsCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTexturesFloatsCol.DataPropertyName = "UnkFloats";
            this.dgvTexturesFloatsCol.HeaderText = "Unknown Floats";
            this.dgvTexturesFloatsCol.Name = "dgvTexturesFloatsCol";
            this.dgvTexturesFloatsCol.Width = 109;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripMTDPath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1046, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripMTDPath
            // 
            this.statusStripMTDPath.Name = "statusStripMTDPath";
            this.statusStripMTDPath.Size = new System.Drawing.Size(76, 17);
            this.statusStripMTDPath.Text = "<MTD path>";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.exploreToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.restoreToolStripMenuItem.Text = "&Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.RestoreToolStripMenuItem_Click);
            // 
            // exploreToolStripMenuItem
            // 
            this.exploreToolStripMenuItem.Name = "exploreToolStripMenuItem";
            this.exploreToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exploreToolStripMenuItem.Text = "Explore";
            this.exploreToolStripMenuItem.Click += new System.EventHandler(this.ExploreToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.updateToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.ToolTipText = "An update is available! Click to download it.";
            this.updateToolStripMenuItem.Visible = false;
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmbMTD);
            this.splitContainer1.Panel1.Controls.Add(lblDescription);
            this.splitContainer1.Panel1.Controls.Add(this.dgvTextures);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescription);
            this.splitContainer1.Panel1.Controls.Add(lblShader);
            this.splitContainer1.Panel1.Controls.Add(this.txtShader);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescriptionTranslated);
            this.splitContainer1.Panel1.Controls.Add(lblDescriptionTranslated);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvParams);
            this.splitContainer1.Size = new System.Drawing.Size(1046, 541);
            this.splitContainer1.SplitterDistance = 678;
            this.splitContainer1.TabIndex = 25;
            // 
            // MTDInternalType
            // 
            this.MTDInternalType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MTDInternalType.DataPropertyName = "Type";
            this.MTDInternalType.HeaderText = "Type";
            this.MTDInternalType.Name = "MTDInternalType";
            this.MTDInternalType.ReadOnly = true;
            this.MTDInternalType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MTDInternalType.Width = 37;
            // 
            // MTDInternalName
            // 
            this.MTDInternalName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MTDInternalName.DataPropertyName = "Name";
            this.MTDInternalName.HeaderText = "Param";
            this.MTDInternalName.Name = "MTDInternalName";
            this.MTDInternalName.ReadOnly = true;
            this.MTDInternalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MTDInternalValue
            // 
            this.MTDInternalValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MTDInternalValue.DataPropertyName = "Value";
            this.MTDInternalValue.HeaderText = "Value";
            this.MTDInternalValue.MinimumWidth = 110;
            this.MTDInternalValue.Name = "MTDInternalValue";
            this.MTDInternalValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MTDInternalValue.Width = 110;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 587);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(365, 540);
            this.Name = "FormMain";
            this.Text = "MTD Editor <version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTextures)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvParams;
        private System.Windows.Forms.ComboBox cmbMTD;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtShader;
        private System.Windows.Forms.TextBox txtDescriptionTranslated;
        private System.Windows.Forms.OpenFileDialog ofdOpenMTD;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvTextures;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripMTDPath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exploreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTexturesTextureCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTexturesPathCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTexturesUVCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTexturesShaderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTexturesFloatsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTDInternalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTDInternalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTDInternalValue;
    }
}

