﻿namespace EscopeWindowsApp
{
    partial class Units
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
            this.createUnitsBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.unitsPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.unitsRecordsPerLabel = new System.Windows.Forms.Label();
            this.unitsAllPgLabel = new System.Windows.Forms.Label();
            this.unitsOfLabel = new System.Windows.Forms.Label();
            this.unitsPgRangeLabel = new System.Windows.Forms.Label();
            this.unitsBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.unitsFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.unitsPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.unitsNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.unitsLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.unitsFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.unitsSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.unitsDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.unitsBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createUnitsBtn
            // 
            this.createUnitsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createUnitsBtn.BorderRadius = 8;
            this.createUnitsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createUnitsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createUnitsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createUnitsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createUnitsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createUnitsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUnitsBtn.ForeColor = System.Drawing.Color.White;
            this.createUnitsBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createUnitsBtn.Location = new System.Drawing.Point(1158, 30);
            this.createUnitsBtn.Name = "createUnitsBtn";
            this.createUnitsBtn.Size = new System.Drawing.Size(209, 42);
            this.createUnitsBtn.TabIndex = 26;
            this.createUnitsBtn.Text = "Create Unit";
            this.createUnitsBtn.Click += new System.EventHandler(this.createUnitsBtn_Click);
            // 
            // unitsPageCombo
            // 
            this.unitsPageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.unitsPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.unitsPageCombo.BorderColor = System.Drawing.Color.Black;
            this.unitsPageCombo.BorderRadius = 8;
            this.unitsPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.unitsPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitsPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unitsPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unitsPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.unitsPageCombo.ForeColor = System.Drawing.Color.Black;
            this.unitsPageCombo.ItemHeight = 30;
            this.unitsPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.unitsPageCombo.Location = new System.Drawing.Point(141, 734);
            this.unitsPageCombo.Name = "unitsPageCombo";
            this.unitsPageCombo.Size = new System.Drawing.Size(85, 36);
            this.unitsPageCombo.StartIndex = 0;
            this.unitsPageCombo.TabIndex = 45;
            // 
            // unitsRecordsPerLabel
            // 
            this.unitsRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.unitsRecordsPerLabel.AutoSize = true;
            this.unitsRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.unitsRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.unitsRecordsPerLabel.Name = "unitsRecordsPerLabel";
            this.unitsRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.unitsRecordsPerLabel.TabIndex = 44;
            this.unitsRecordsPerLabel.Text = "Records per page";
            // 
            // unitsAllPgLabel
            // 
            this.unitsAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.unitsAllPgLabel.AutoSize = true;
            this.unitsAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.unitsAllPgLabel.Location = new System.Drawing.Point(295, 742);
            this.unitsAllPgLabel.Name = "unitsAllPgLabel";
            this.unitsAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.unitsAllPgLabel.TabIndex = 43;
            this.unitsAllPgLabel.Text = "500";
            // 
            // unitsOfLabel
            // 
            this.unitsOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.unitsOfLabel.AutoSize = true;
            this.unitsOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.unitsOfLabel.Location = new System.Drawing.Point(274, 742);
            this.unitsOfLabel.Name = "unitsOfLabel";
            this.unitsOfLabel.Size = new System.Drawing.Size(22, 19);
            this.unitsOfLabel.TabIndex = 42;
            this.unitsOfLabel.Text = "of";
            // 
            // unitsPgRangeLabel
            // 
            this.unitsPgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.unitsPgRangeLabel.AutoSize = true;
            this.unitsPgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.unitsPgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.unitsPgRangeLabel.Name = "unitsPgRangeLabel";
            this.unitsPgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.unitsPgRangeLabel.TabIndex = 41;
            this.unitsPgRangeLabel.Text = "0-50";
            // 
            // unitsBtnPanel
            // 
            this.unitsBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unitsBtnPanel.BorderRadius = 8;
            this.unitsBtnPanel.Controls.Add(this.unitsFirstBtn);
            this.unitsBtnPanel.Controls.Add(this.unitsPrevBtn);
            this.unitsBtnPanel.Controls.Add(this.unitsNextBtn);
            this.unitsBtnPanel.Controls.Add(this.unitsLastBtn);
            this.unitsBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.unitsBtnPanel.Name = "unitsBtnPanel";
            this.unitsBtnPanel.Size = new System.Drawing.Size(154, 42);
            this.unitsBtnPanel.TabIndex = 40;
            // 
            // unitsFirstBtn
            // 
            this.unitsFirstBtn.BorderRadius = 6;
            this.unitsFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.unitsFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.unitsFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.unitsFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.unitsFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.unitsFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.unitsFirstBtn.ForeColor = System.Drawing.Color.White;
            this.unitsFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.unitsFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.unitsFirstBtn.Name = "unitsFirstBtn";
            this.unitsFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.unitsFirstBtn.TabIndex = 11;
            this.unitsFirstBtn.Click += new System.EventHandler(this.unitsFirstBtn_Click);
            // 
            // unitsPrevBtn
            // 
            this.unitsPrevBtn.BorderRadius = 6;
            this.unitsPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.unitsPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.unitsPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.unitsPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.unitsPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.unitsPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.unitsPrevBtn.ForeColor = System.Drawing.Color.White;
            this.unitsPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.unitsPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.unitsPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.unitsPrevBtn.Name = "unitsPrevBtn";
            this.unitsPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.unitsPrevBtn.TabIndex = 11;
            this.unitsPrevBtn.Click += new System.EventHandler(this.unitsPrevBtn_Click);
            // 
            // unitsNextBtn
            // 
            this.unitsNextBtn.BorderRadius = 6;
            this.unitsNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.unitsNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.unitsNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.unitsNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.unitsNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.unitsNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.unitsNextBtn.ForeColor = System.Drawing.Color.White;
            this.unitsNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.unitsNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.unitsNextBtn.Location = new System.Drawing.Point(87, 8);
            this.unitsNextBtn.Name = "unitsNextBtn";
            this.unitsNextBtn.Size = new System.Drawing.Size(26, 26);
            this.unitsNextBtn.TabIndex = 9;
            this.unitsNextBtn.Click += new System.EventHandler(this.unitsNextBtn_Click);
            // 
            // unitsLastBtn
            // 
            this.unitsLastBtn.BorderRadius = 6;
            this.unitsLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.unitsLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.unitsLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.unitsLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.unitsLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.unitsLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.unitsLastBtn.ForeColor = System.Drawing.Color.White;
            this.unitsLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.unitsLastBtn.Location = new System.Drawing.Point(130, 8);
            this.unitsLastBtn.Name = "unitsLastBtn";
            this.unitsLastBtn.Size = new System.Drawing.Size(26, 26);
            this.unitsLastBtn.TabIndex = 8;
            this.unitsLastBtn.Click += new System.EventHandler(this.unitsLastBtn_Click);
            // 
            // unitsFilterBtn
            // 
            this.unitsFilterBtn.BorderRadius = 8;
            this.unitsFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.unitsFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.unitsFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.unitsFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.unitsFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.unitsFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.unitsFilterBtn.ForeColor = System.Drawing.Color.White;
            this.unitsFilterBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.unitsFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.unitsFilterBtn.Location = new System.Drawing.Point(427, 30);
            this.unitsFilterBtn.Name = "unitsFilterBtn";
            this.unitsFilterBtn.Size = new System.Drawing.Size(42, 42);
            this.unitsFilterBtn.TabIndex = 25;
            this.unitsFilterBtn.Click += new System.EventHandler(this.unitsFilterBtn_Click);
            // 
            // unitsSearchText
            // 
            this.unitsSearchText.BorderColor = System.Drawing.Color.Gray;
            this.unitsSearchText.BorderRadius = 8;
            this.unitsSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unitsSearchText.DefaultText = "";
            this.unitsSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.unitsSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.unitsSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unitsSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unitsSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unitsSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.unitsSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.unitsSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unitsSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.unitsSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.unitsSearchText.Location = new System.Drawing.Point(17, 30);
            this.unitsSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unitsSearchText.Name = "unitsSearchText";
            this.unitsSearchText.PasswordChar = '\0';
            this.unitsSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.unitsSearchText.PlaceholderText = "Search";
            this.unitsSearchText.SelectedText = "";
            this.unitsSearchText.Size = new System.Drawing.Size(400, 42);
            this.unitsSearchText.TabIndex = 24;
            this.unitsSearchText.TextChanged += new System.EventHandler(this.unitsSearchText_TextChanged);
            // 
            // unitsDataGridView
            // 
            this.unitsDataGridView.AllowUserToAddRows = false;
            this.unitsDataGridView.AllowUserToDeleteRows = false;
            this.unitsDataGridView.AllowUserToResizeColumns = false;
            this.unitsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.unitsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.unitsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.unitsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.unitsDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.unitsDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.unitsDataGridView.GridColor = System.Drawing.Color.White;
            this.unitsDataGridView.Location = new System.Drawing.Point(17, 100);
            this.unitsDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.unitsDataGridView.Name = "unitsDataGridView";
            this.unitsDataGridView.ReadOnly = true;
            this.unitsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unitsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.unitsDataGridView.RowHeadersVisible = false;
            this.unitsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.unitsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unitsDataGridView.RowTemplate.Height = 35;
            this.unitsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unitsDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.unitsDataGridView.TabIndex = 46;
            this.unitsDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.unitsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.unitsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unitsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.unitsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.unitsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.unitsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.unitsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.unitsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.unitsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.unitsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.unitsDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.unitsDataGridView.ThemeStyle.ReadOnly = true;
            this.unitsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.unitsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.unitsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.unitsDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.unitsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.unitsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.unitsDataGridView);
            this.Controls.Add(this.unitsPageCombo);
            this.Controls.Add(this.unitsRecordsPerLabel);
            this.Controls.Add(this.unitsAllPgLabel);
            this.Controls.Add(this.unitsOfLabel);
            this.Controls.Add(this.unitsPgRangeLabel);
            this.Controls.Add(this.unitsBtnPanel);
            this.Controls.Add(this.createUnitsBtn);
            this.Controls.Add(this.unitsFilterBtn);
            this.Controls.Add(this.unitsSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "Units";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Units";
            this.Load += new System.EventHandler(this.Units_Load);
            this.unitsBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton createUnitsBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton unitsFilterBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox unitsSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox unitsPageCombo;
        private System.Windows.Forms.Label unitsRecordsPerLabel;
        private System.Windows.Forms.Label unitsAllPgLabel;
        private System.Windows.Forms.Label unitsOfLabel;
        private System.Windows.Forms.Label unitsPgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel unitsBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton unitsFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton unitsPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton unitsNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton unitsLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView unitsDataGridView;
    }
}