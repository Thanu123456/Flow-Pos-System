﻿namespace EscopeWindowsApp
{
    partial class Brands
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.createBrandsBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.brandsPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.brandsRecordsPerLabel = new System.Windows.Forms.Label();
            this.brandsAllPgLabel = new System.Windows.Forms.Label();
            this.brandsOfLabel = new System.Windows.Forms.Label();
            this.brandsPgRangeLabel = new System.Windows.Forms.Label();
            this.brandsBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.brandsFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.brandsPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.brandsNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.brandsLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.brandsRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.brandsSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.brandsDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.brandsBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createBrandsBtn
            // 
            this.createBrandsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createBrandsBtn.Animated = true;
            this.createBrandsBtn.BorderRadius = 8;
            this.createBrandsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createBrandsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createBrandsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createBrandsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createBrandsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createBrandsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBrandsBtn.ForeColor = System.Drawing.Color.White;
            this.createBrandsBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createBrandsBtn.Location = new System.Drawing.Point(1158, 30);
            this.createBrandsBtn.Name = "createBrandsBtn";
            this.createBrandsBtn.Size = new System.Drawing.Size(209, 41);
            this.createBrandsBtn.TabIndex = 22;
            this.createBrandsBtn.Text = "Create Brand";
            this.createBrandsBtn.Click += new System.EventHandler(this.createBrandsBtn_Click);
            // 
            // brandsPageCombo
            // 
            this.brandsPageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brandsPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.brandsPageCombo.BorderColor = System.Drawing.Color.Black;
            this.brandsPageCombo.BorderRadius = 8;
            this.brandsPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.brandsPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandsPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brandsPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brandsPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.brandsPageCombo.ForeColor = System.Drawing.Color.Black;
            this.brandsPageCombo.ItemHeight = 30;
            this.brandsPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.brandsPageCombo.Location = new System.Drawing.Point(141, 734);
            this.brandsPageCombo.Name = "brandsPageCombo";
            this.brandsPageCombo.Size = new System.Drawing.Size(85, 36);
            this.brandsPageCombo.StartIndex = 0;
            this.brandsPageCombo.TabIndex = 39;
            // 
            // brandsRecordsPerLabel
            // 
            this.brandsRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brandsRecordsPerLabel.AutoSize = true;
            this.brandsRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandsRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.brandsRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.brandsRecordsPerLabel.Name = "brandsRecordsPerLabel";
            this.brandsRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.brandsRecordsPerLabel.TabIndex = 38;
            this.brandsRecordsPerLabel.Text = "Records per page";
            this.brandsRecordsPerLabel.Click += new System.EventHandler(this.brandsRecordsPerLabel_Click);
            // 
            // brandsAllPgLabel
            // 
            this.brandsAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brandsAllPgLabel.AutoSize = true;
            this.brandsAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandsAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.brandsAllPgLabel.Location = new System.Drawing.Point(297, 742);
            this.brandsAllPgLabel.Name = "brandsAllPgLabel";
            this.brandsAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.brandsAllPgLabel.TabIndex = 37;
            this.brandsAllPgLabel.Text = "500";
            // 
            // brandsOfLabel
            // 
            this.brandsOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brandsOfLabel.AutoSize = true;
            this.brandsOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandsOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.brandsOfLabel.Location = new System.Drawing.Point(276, 742);
            this.brandsOfLabel.Name = "brandsOfLabel";
            this.brandsOfLabel.Size = new System.Drawing.Size(22, 19);
            this.brandsOfLabel.TabIndex = 36;
            this.brandsOfLabel.Text = "of";
            // 
            // brandsPgRangeLabel
            // 
            this.brandsPgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brandsPgRangeLabel.AutoSize = true;
            this.brandsPgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandsPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.brandsPgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.brandsPgRangeLabel.Name = "brandsPgRangeLabel";
            this.brandsPgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.brandsPgRangeLabel.TabIndex = 35;
            this.brandsPgRangeLabel.Text = "0-50";
            // 
            // brandsBtnPanel
            // 
            this.brandsBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.brandsBtnPanel.BorderRadius = 8;
            this.brandsBtnPanel.Controls.Add(this.brandsFirstBtn);
            this.brandsBtnPanel.Controls.Add(this.brandsPrevBtn);
            this.brandsBtnPanel.Controls.Add(this.brandsNextBtn);
            this.brandsBtnPanel.Controls.Add(this.brandsLastBtn);
            this.brandsBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.brandsBtnPanel.Name = "brandsBtnPanel";
            this.brandsBtnPanel.Size = new System.Drawing.Size(154, 42);
            this.brandsBtnPanel.TabIndex = 34;
            // 
            // brandsFirstBtn
            // 
            this.brandsFirstBtn.BorderRadius = 6;
            this.brandsFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.brandsFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.brandsFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.brandsFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.brandsFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.brandsFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brandsFirstBtn.ForeColor = System.Drawing.Color.White;
            this.brandsFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.brandsFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.brandsFirstBtn.Name = "brandsFirstBtn";
            this.brandsFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.brandsFirstBtn.TabIndex = 11;
            this.brandsFirstBtn.Click += new System.EventHandler(this.brandsFirstBtn_Click);
            // 
            // brandsPrevBtn
            // 
            this.brandsPrevBtn.BorderRadius = 6;
            this.brandsPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.brandsPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.brandsPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.brandsPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.brandsPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.brandsPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brandsPrevBtn.ForeColor = System.Drawing.Color.White;
            this.brandsPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.brandsPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.brandsPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.brandsPrevBtn.Name = "brandsPrevBtn";
            this.brandsPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.brandsPrevBtn.TabIndex = 11;
            this.brandsPrevBtn.Click += new System.EventHandler(this.brandsPrevBtn_Click);
            // 
            // brandsNextBtn
            // 
            this.brandsNextBtn.BorderRadius = 6;
            this.brandsNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.brandsNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.brandsNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.brandsNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.brandsNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.brandsNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brandsNextBtn.ForeColor = System.Drawing.Color.White;
            this.brandsNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.brandsNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.brandsNextBtn.Location = new System.Drawing.Point(87, 8);
            this.brandsNextBtn.Name = "brandsNextBtn";
            this.brandsNextBtn.Size = new System.Drawing.Size(26, 26);
            this.brandsNextBtn.TabIndex = 9;
            this.brandsNextBtn.Click += new System.EventHandler(this.brandsNextBtn_Click);
            // 
            // brandsLastBtn
            // 
            this.brandsLastBtn.BorderRadius = 6;
            this.brandsLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.brandsLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.brandsLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.brandsLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.brandsLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.brandsLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brandsLastBtn.ForeColor = System.Drawing.Color.White;
            this.brandsLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.brandsLastBtn.Location = new System.Drawing.Point(130, 8);
            this.brandsLastBtn.Name = "brandsLastBtn";
            this.brandsLastBtn.Size = new System.Drawing.Size(26, 26);
            this.brandsLastBtn.TabIndex = 8;
            this.brandsLastBtn.Click += new System.EventHandler(this.brandsLastBtn_Click);
            // 
            // brandsRefreshBtn
            // 
            this.brandsRefreshBtn.Animated = true;
            this.brandsRefreshBtn.BorderRadius = 8;
            this.brandsRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.brandsRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.brandsRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.brandsRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.brandsRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.brandsRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brandsRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.brandsRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.brandsRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.brandsRefreshBtn.Location = new System.Drawing.Point(427, 30);
            this.brandsRefreshBtn.Name = "brandsRefreshBtn";
            this.brandsRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.brandsRefreshBtn.TabIndex = 21;
            this.brandsRefreshBtn.Click += new System.EventHandler(this.brandsFilterBtn_Click);
            // 
            // brandsSearchText
            // 
            this.brandsSearchText.BorderColor = System.Drawing.Color.Gray;
            this.brandsSearchText.BorderRadius = 8;
            this.brandsSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brandsSearchText.DefaultText = "";
            this.brandsSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.brandsSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.brandsSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.brandsSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.brandsSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brandsSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.brandsSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brandsSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brandsSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.brandsSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.brandsSearchText.Location = new System.Drawing.Point(17, 30);
            this.brandsSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brandsSearchText.Name = "brandsSearchText";
            this.brandsSearchText.PasswordChar = '\0';
            this.brandsSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.brandsSearchText.PlaceholderText = "Search";
            this.brandsSearchText.SelectedText = "";
            this.brandsSearchText.Size = new System.Drawing.Size(400, 42);
            this.brandsSearchText.TabIndex = 20;
            this.brandsSearchText.TextChanged += new System.EventHandler(this.brandsSearchText_TextChanged);
            // 
            // brandsDataGridView
            // 
            this.brandsDataGridView.AllowUserToAddRows = false;
            this.brandsDataGridView.AllowUserToDeleteRows = false;
            this.brandsDataGridView.AllowUserToResizeColumns = false;
            this.brandsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.brandsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.brandsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brandsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.brandsDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.brandsDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.brandsDataGridView.GridColor = System.Drawing.Color.White;
            this.brandsDataGridView.Location = new System.Drawing.Point(17, 100);
            this.brandsDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.brandsDataGridView.Name = "brandsDataGridView";
            this.brandsDataGridView.ReadOnly = true;
            this.brandsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brandsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.brandsDataGridView.RowHeadersVisible = false;
            this.brandsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.brandsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.brandsDataGridView.RowTemplate.Height = 35;
            this.brandsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.brandsDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.brandsDataGridView.TabIndex = 40;
            this.brandsDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.brandsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.brandsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.brandsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.brandsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.brandsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.brandsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.brandsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.brandsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.brandsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.brandsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.brandsDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.brandsDataGridView.ThemeStyle.ReadOnly = true;
            this.brandsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.brandsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.brandsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.brandsDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.brandsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.brandsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.brandsDataGridView);
            this.Controls.Add(this.brandsPageCombo);
            this.Controls.Add(this.brandsRecordsPerLabel);
            this.Controls.Add(this.brandsAllPgLabel);
            this.Controls.Add(this.brandsOfLabel);
            this.Controls.Add(this.brandsPgRangeLabel);
            this.Controls.Add(this.brandsBtnPanel);
            this.Controls.Add(this.createBrandsBtn);
            this.Controls.Add(this.brandsRefreshBtn);
            this.Controls.Add(this.brandsSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "Brands";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brands";
            this.Load += new System.EventHandler(this.Brands_Load_1);
            this.brandsBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton createBrandsBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton brandsRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox brandsSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox brandsPageCombo;
        private System.Windows.Forms.Label brandsRecordsPerLabel;
        private System.Windows.Forms.Label brandsAllPgLabel;
        private System.Windows.Forms.Label brandsOfLabel;
        private System.Windows.Forms.Label brandsPgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel brandsBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton brandsFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton brandsPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton brandsNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton brandsLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView brandsDataGridView;
    }
}