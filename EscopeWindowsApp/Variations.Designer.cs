﻿namespace EscopeWindowsApp
{
    partial class Variations
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
            this.createVariationsBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.variationsRecordsPerLabel = new System.Windows.Forms.Label();
            this.variationsAllPgLabel = new System.Windows.Forms.Label();
            this.variationsOfLabel = new System.Windows.Forms.Label();
            this.variationsPgRangeLabel = new System.Windows.Forms.Label();
            this.variationsBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.variationsFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.variationsDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.variationsBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createVariationsBtn
            // 
            this.createVariationsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createVariationsBtn.BorderRadius = 8;
            this.createVariationsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createVariationsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createVariationsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createVariationsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createVariationsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createVariationsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createVariationsBtn.ForeColor = System.Drawing.Color.White;
            this.createVariationsBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createVariationsBtn.Location = new System.Drawing.Point(1158, 30);
            this.createVariationsBtn.Name = "createVariationsBtn";
            this.createVariationsBtn.Size = new System.Drawing.Size(209, 41);
            this.createVariationsBtn.TabIndex = 18;
            this.createVariationsBtn.Text = "Create Variations";
            this.createVariationsBtn.Click += new System.EventHandler(this.createVariationsBtn_Click);
            // 
            // variationsPageCombo
            // 
            this.variationsPageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.variationsPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.variationsPageCombo.BorderColor = System.Drawing.Color.Black;
            this.variationsPageCombo.BorderRadius = 8;
            this.variationsPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.variationsPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.variationsPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.variationsPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.variationsPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.variationsPageCombo.ForeColor = System.Drawing.Color.Black;
            this.variationsPageCombo.ItemHeight = 30;
            this.variationsPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.variationsPageCombo.Location = new System.Drawing.Point(141, 734);
            this.variationsPageCombo.Name = "variationsPageCombo";
            this.variationsPageCombo.Size = new System.Drawing.Size(85, 36);
            this.variationsPageCombo.StartIndex = 0;
            this.variationsPageCombo.TabIndex = 33;
            // 
            // variationsRecordsPerLabel
            // 
            this.variationsRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.variationsRecordsPerLabel.AutoSize = true;
            this.variationsRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.variationsRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.variationsRecordsPerLabel.Name = "variationsRecordsPerLabel";
            this.variationsRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.variationsRecordsPerLabel.TabIndex = 32;
            this.variationsRecordsPerLabel.Text = "Records per page";
            // 
            // variationsAllPgLabel
            // 
            this.variationsAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.variationsAllPgLabel.AutoSize = true;
            this.variationsAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.variationsAllPgLabel.Location = new System.Drawing.Point(295, 742);
            this.variationsAllPgLabel.Name = "variationsAllPgLabel";
            this.variationsAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.variationsAllPgLabel.TabIndex = 31;
            this.variationsAllPgLabel.Text = "500";
            // 
            // variationsOfLabel
            // 
            this.variationsOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.variationsOfLabel.AutoSize = true;
            this.variationsOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.variationsOfLabel.Location = new System.Drawing.Point(274, 742);
            this.variationsOfLabel.Name = "variationsOfLabel";
            this.variationsOfLabel.Size = new System.Drawing.Size(22, 19);
            this.variationsOfLabel.TabIndex = 30;
            this.variationsOfLabel.Text = "of";
            // 
            // variationsPgRangeLabel
            // 
            this.variationsPgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.variationsPgRangeLabel.AutoSize = true;
            this.variationsPgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.variationsPgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.variationsPgRangeLabel.Name = "variationsPgRangeLabel";
            this.variationsPgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.variationsPgRangeLabel.TabIndex = 29;
            this.variationsPgRangeLabel.Text = "0-50";
            // 
            // variationsBtnPanel
            // 
            this.variationsBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.variationsBtnPanel.BorderRadius = 8;
            this.variationsBtnPanel.Controls.Add(this.variationsFirstBtn);
            this.variationsBtnPanel.Controls.Add(this.variationsPrevBtn);
            this.variationsBtnPanel.Controls.Add(this.variationsNextBtn);
            this.variationsBtnPanel.Controls.Add(this.variationsLastBtn);
            this.variationsBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.variationsBtnPanel.Name = "variationsBtnPanel";
            this.variationsBtnPanel.Size = new System.Drawing.Size(154, 42);
            this.variationsBtnPanel.TabIndex = 28;
            // 
            // variationsFirstBtn
            // 
            this.variationsFirstBtn.BorderRadius = 6;
            this.variationsFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.variationsFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.variationsFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.variationsFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.variationsFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.variationsFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.variationsFirstBtn.ForeColor = System.Drawing.Color.White;
            this.variationsFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.variationsFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.variationsFirstBtn.Name = "variationsFirstBtn";
            this.variationsFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.variationsFirstBtn.TabIndex = 11;
            this.variationsFirstBtn.Click += new System.EventHandler(this.variationsFirstBtn_Click);
            // 
            // variationsPrevBtn
            // 
            this.variationsPrevBtn.BorderRadius = 6;
            this.variationsPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.variationsPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.variationsPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.variationsPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.variationsPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.variationsPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.variationsPrevBtn.ForeColor = System.Drawing.Color.White;
            this.variationsPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.variationsPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.variationsPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.variationsPrevBtn.Name = "variationsPrevBtn";
            this.variationsPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.variationsPrevBtn.TabIndex = 11;
            this.variationsPrevBtn.Click += new System.EventHandler(this.variationsPrevBtn_Click);
            // 
            // variationsNextBtn
            // 
            this.variationsNextBtn.BorderRadius = 6;
            this.variationsNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.variationsNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.variationsNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.variationsNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.variationsNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.variationsNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.variationsNextBtn.ForeColor = System.Drawing.Color.White;
            this.variationsNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.variationsNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.variationsNextBtn.Location = new System.Drawing.Point(87, 8);
            this.variationsNextBtn.Name = "variationsNextBtn";
            this.variationsNextBtn.Size = new System.Drawing.Size(26, 26);
            this.variationsNextBtn.TabIndex = 9;
            this.variationsNextBtn.Click += new System.EventHandler(this.variationsNextBtn_Click);
            // 
            // variationsLastBtn
            // 
            this.variationsLastBtn.BorderRadius = 6;
            this.variationsLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.variationsLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.variationsLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.variationsLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.variationsLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.variationsLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.variationsLastBtn.ForeColor = System.Drawing.Color.White;
            this.variationsLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.variationsLastBtn.Location = new System.Drawing.Point(130, 8);
            this.variationsLastBtn.Name = "variationsLastBtn";
            this.variationsLastBtn.Size = new System.Drawing.Size(26, 26);
            this.variationsLastBtn.TabIndex = 8;
            this.variationsLastBtn.Click += new System.EventHandler(this.variationsLastBtn_Click);
            // 
            // variationsRefreshBtn
            // 
            this.variationsRefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.variationsRefreshBtn.BorderRadius = 8;
            this.variationsRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.variationsRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.variationsRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.variationsRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.variationsRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.variationsRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.variationsRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.variationsRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.variationsRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.variationsRefreshBtn.Location = new System.Drawing.Point(427, 30);
            this.variationsRefreshBtn.Name = "variationsRefreshBtn";
            this.variationsRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.variationsRefreshBtn.TabIndex = 17;
            this.variationsRefreshBtn.Click += new System.EventHandler(this.variationsFilterBtn_Click);
            // 
            // variationsSearchText
            // 
            this.variationsSearchText.BorderColor = System.Drawing.Color.Gray;
            this.variationsSearchText.BorderRadius = 8;
            this.variationsSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.variationsSearchText.DefaultText = "";
            this.variationsSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.variationsSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.variationsSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.variationsSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.variationsSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.variationsSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.variationsSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.variationsSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.variationsSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.variationsSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.variationsSearchText.Location = new System.Drawing.Point(17, 30);
            this.variationsSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.variationsSearchText.Name = "variationsSearchText";
            this.variationsSearchText.PasswordChar = '\0';
            this.variationsSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.variationsSearchText.PlaceholderText = "Search";
            this.variationsSearchText.SelectedText = "";
            this.variationsSearchText.Size = new System.Drawing.Size(400, 42);
            this.variationsSearchText.TabIndex = 16;
            this.variationsSearchText.TextChanged += new System.EventHandler(this.variationsSearchText_TextChanged);
            // 
            // variationsDataGridView
            // 
            this.variationsDataGridView.AllowUserToAddRows = false;
            this.variationsDataGridView.AllowUserToDeleteRows = false;
            this.variationsDataGridView.AllowUserToResizeColumns = false;
            this.variationsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.variationsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.variationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.variationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.variationsDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.variationsDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.variationsDataGridView.GridColor = System.Drawing.Color.White;
            this.variationsDataGridView.Location = new System.Drawing.Point(17, 100);
            this.variationsDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.variationsDataGridView.Name = "variationsDataGridView";
            this.variationsDataGridView.ReadOnly = true;
            this.variationsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.variationsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.variationsDataGridView.RowHeadersVisible = false;
            this.variationsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.variationsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.variationsDataGridView.RowTemplate.Height = 35;
            this.variationsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.variationsDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.variationsDataGridView.TabIndex = 34;
            this.variationsDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.variationsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.variationsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.variationsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.variationsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.variationsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.variationsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.variationsDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.variationsDataGridView.ThemeStyle.ReadOnly = true;
            this.variationsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.variationsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.variationsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.variationsDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.variationsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.variationsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Variations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.variationsDataGridView);
            this.Controls.Add(this.variationsPageCombo);
            this.Controls.Add(this.variationsRecordsPerLabel);
            this.Controls.Add(this.variationsAllPgLabel);
            this.Controls.Add(this.variationsOfLabel);
            this.Controls.Add(this.variationsPgRangeLabel);
            this.Controls.Add(this.variationsBtnPanel);
            this.Controls.Add(this.createVariationsBtn);
            this.Controls.Add(this.variationsRefreshBtn);
            this.Controls.Add(this.variationsSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "Variations";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variations";
            this.Load += new System.EventHandler(this.Variations_Load);
            this.variationsBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.variationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton createVariationsBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox variationsSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox variationsPageCombo;
        private System.Windows.Forms.Label variationsRecordsPerLabel;
        private System.Windows.Forms.Label variationsAllPgLabel;
        private System.Windows.Forms.Label variationsOfLabel;
        private System.Windows.Forms.Label variationsPgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel variationsBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView variationsDataGridView;
    }
}