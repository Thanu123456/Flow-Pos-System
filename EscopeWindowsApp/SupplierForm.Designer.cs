﻿namespace EscopeWindowsApp
{
    partial class SupplierForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.createSupBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.supAllPgLabel = new System.Windows.Forms.Label();
            this.supOfLabel = new System.Windows.Forms.Label();
            this.supPgRangeLabel = new System.Windows.Forms.Label();
            this.supPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.supRecordsPerLabel = new System.Windows.Forms.Label();
            this.supFilterPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.selectSupDateTime = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.supDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.supRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.supBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createSupBtn
            // 
            this.createSupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createSupBtn.Animated = true;
            this.createSupBtn.BorderRadius = 8;
            this.createSupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createSupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createSupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createSupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createSupBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createSupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.createSupBtn.ForeColor = System.Drawing.Color.White;
            this.createSupBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createSupBtn.Location = new System.Drawing.Point(1158, 30);
            this.createSupBtn.Name = "createSupBtn";
            this.createSupBtn.Size = new System.Drawing.Size(209, 42);
            this.createSupBtn.TabIndex = 8;
            this.createSupBtn.Text = "Craete Supplier";
            this.createSupBtn.Click += new System.EventHandler(this.createSupBtn_Click);
            // 
            // supBtnPanel
            // 
            this.supBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.supBtnPanel.BorderRadius = 8;
            this.supBtnPanel.Controls.Add(this.supFirstBtn);
            this.supBtnPanel.Controls.Add(this.supPrevBtn);
            this.supBtnPanel.Controls.Add(this.supNextBtn);
            this.supBtnPanel.Controls.Add(this.supLastBtn);
            this.supBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.supBtnPanel.Name = "supBtnPanel";
            this.supBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.supBtnPanel.TabIndex = 23;
            // 
            // supAllPgLabel
            // 
            this.supAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.supAllPgLabel.AutoSize = true;
            this.supAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.supAllPgLabel.Location = new System.Drawing.Point(295, 742);
            this.supAllPgLabel.Name = "supAllPgLabel";
            this.supAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.supAllPgLabel.TabIndex = 32;
            this.supAllPgLabel.Text = "500";
            // 
            // supOfLabel
            // 
            this.supOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.supOfLabel.AutoSize = true;
            this.supOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.supOfLabel.Location = new System.Drawing.Point(274, 742);
            this.supOfLabel.Name = "supOfLabel";
            this.supOfLabel.Size = new System.Drawing.Size(22, 19);
            this.supOfLabel.TabIndex = 31;
            this.supOfLabel.Text = "of";
            // 
            // supPgRangeLabel
            // 
            this.supPgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.supPgRangeLabel.AutoSize = true;
            this.supPgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.supPgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.supPgRangeLabel.Name = "supPgRangeLabel";
            this.supPgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.supPgRangeLabel.TabIndex = 30;
            this.supPgRangeLabel.Text = "0-50";
            // 
            // supPageCombo
            // 
            this.supPageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.supPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.supPageCombo.BorderColor = System.Drawing.Color.Black;
            this.supPageCombo.BorderRadius = 8;
            this.supPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.supPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supPageCombo.ForeColor = System.Drawing.Color.Black;
            this.supPageCombo.ItemHeight = 30;
            this.supPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.supPageCombo.Location = new System.Drawing.Point(141, 734);
            this.supPageCombo.Name = "supPageCombo";
            this.supPageCombo.Size = new System.Drawing.Size(85, 36);
            this.supPageCombo.StartIndex = 0;
            this.supPageCombo.TabIndex = 29;
            // 
            // supRecordsPerLabel
            // 
            this.supRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.supRecordsPerLabel.AutoSize = true;
            this.supRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.supRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.supRecordsPerLabel.Name = "supRecordsPerLabel";
            this.supRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.supRecordsPerLabel.TabIndex = 28;
            this.supRecordsPerLabel.Text = "Records per page";
            // 
            // supFilterPanel
            // 
            this.supFilterPanel.BorderRadius = 8;
            this.supFilterPanel.Location = new System.Drawing.Point(798, 12);
            this.supFilterPanel.Name = "supFilterPanel";
            this.supFilterPanel.Size = new System.Drawing.Size(338, 72);
            this.supFilterPanel.TabIndex = 37;
            // 
            // selectSupDateTime
            // 
            this.selectSupDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectSupDateTime.BackColor = System.Drawing.Color.Transparent;
            this.selectSupDateTime.BorderColor = System.Drawing.Color.Gray;
            this.selectSupDateTime.BorderRadius = 8;
            this.selectSupDateTime.BorderThickness = 1;
            this.selectSupDateTime.Checked = true;
            this.selectSupDateTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectSupDateTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.selectSupDateTime.ForeColor = System.Drawing.Color.Black;
            this.selectSupDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.selectSupDateTime.Location = new System.Drawing.Point(827, 30);
            this.selectSupDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.selectSupDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.selectSupDateTime.Name = "selectSupDateTime";
            this.selectSupDateTime.Size = new System.Drawing.Size(268, 42);
            this.selectSupDateTime.TabIndex = 37;
            this.selectSupDateTime.UseTransparentBackground = true;
            this.selectSupDateTime.Value = new System.DateTime(2025, 2, 28, 12, 17, 13, 576);
            this.selectSupDateTime.ValueChanged += new System.EventHandler(this.selectSupDateTime_ValueChanged);
            // 
            // supDataGridView
            // 
            this.supDataGridView.AllowUserToAddRows = false;
            this.supDataGridView.AllowUserToDeleteRows = false;
            this.supDataGridView.AllowUserToResizeColumns = false;
            this.supDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.supDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.supDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.supDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.supDataGridView.GridColor = System.Drawing.Color.White;
            this.supDataGridView.Location = new System.Drawing.Point(17, 100);
            this.supDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.supDataGridView.Name = "supDataGridView";
            this.supDataGridView.ReadOnly = true;
            this.supDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.supDataGridView.RowHeadersVisible = false;
            this.supDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.supDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.supDataGridView.RowTemplate.Height = 35;
            this.supDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.supDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.supDataGridView.TabIndex = 39;
            this.supDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.supDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.supDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.supDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.supDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.supDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.supDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.supDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.supDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.supDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.supDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.supDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.supDataGridView.ThemeStyle.ReadOnly = true;
            this.supDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.supDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.supDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.supDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.supDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.supDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.supDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supDataGridView_CellContentClick_1);
            // 
            // supRefreshBtn
            // 
            this.supRefreshBtn.Animated = true;
            this.supRefreshBtn.BorderRadius = 8;
            this.supRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.supRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.supRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.supRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.supRefreshBtn.Location = new System.Drawing.Point(427, 30);
            this.supRefreshBtn.Name = "supRefreshBtn";
            this.supRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.supRefreshBtn.TabIndex = 38;
            this.supRefreshBtn.Click += new System.EventHandler(this.supRefreshBtn_Click);
            // 
            // supFilterBtn
            // 
            this.supFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supFilterBtn.Animated = true;
            this.supFilterBtn.BorderRadius = 8;
            this.supFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.supFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supFilterBtn.ForeColor = System.Drawing.Color.White;
            this.supFilterBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.supFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.whitefilter;
            this.supFilterBtn.Location = new System.Drawing.Point(1106, 29);
            this.supFilterBtn.Name = "supFilterBtn";
            this.supFilterBtn.Size = new System.Drawing.Size(42, 42);
            this.supFilterBtn.TabIndex = 33;
            this.supFilterBtn.Click += new System.EventHandler(this.supFilterBtn_Click);
            // 
            // supFirstBtn
            // 
            this.supFirstBtn.BorderRadius = 6;
            this.supFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.supFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supFirstBtn.ForeColor = System.Drawing.Color.White;
            this.supFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.supFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.supFirstBtn.Name = "supFirstBtn";
            this.supFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.supFirstBtn.TabIndex = 11;
            this.supFirstBtn.Click += new System.EventHandler(this.supFirstBtn_Click);
            // 
            // supPrevBtn
            // 
            this.supPrevBtn.BorderRadius = 6;
            this.supPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.supPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supPrevBtn.ForeColor = System.Drawing.Color.White;
            this.supPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.supPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.supPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.supPrevBtn.Name = "supPrevBtn";
            this.supPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.supPrevBtn.TabIndex = 11;
            this.supPrevBtn.Click += new System.EventHandler(this.supPrevBtn_Click);
            // 
            // supNextBtn
            // 
            this.supNextBtn.BorderRadius = 6;
            this.supNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.supNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supNextBtn.ForeColor = System.Drawing.Color.White;
            this.supNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.supNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.supNextBtn.Location = new System.Drawing.Point(87, 8);
            this.supNextBtn.Name = "supNextBtn";
            this.supNextBtn.Size = new System.Drawing.Size(26, 26);
            this.supNextBtn.TabIndex = 9;
            this.supNextBtn.Click += new System.EventHandler(this.supNextBtn_Click);
            // 
            // supLastBtn
            // 
            this.supLastBtn.BorderRadius = 6;
            this.supLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.supLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supLastBtn.ForeColor = System.Drawing.Color.White;
            this.supLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.supLastBtn.Location = new System.Drawing.Point(130, 8);
            this.supLastBtn.Name = "supLastBtn";
            this.supLastBtn.Size = new System.Drawing.Size(26, 26);
            this.supLastBtn.TabIndex = 8;
            this.supLastBtn.Click += new System.EventHandler(this.supLastBtn_Click);
            // 
            // supSearchText
            // 
            this.supSearchText.BorderColor = System.Drawing.Color.Gray;
            this.supSearchText.BorderRadius = 8;
            this.supSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supSearchText.DefaultText = "";
            this.supSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supSearchText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Bold);
            this.supSearchText.ForeColor = System.Drawing.Color.Gray;
            this.supSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.supSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.supSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.supSearchText.Location = new System.Drawing.Point(17, 30);
            this.supSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supSearchText.Name = "supSearchText";
            this.supSearchText.PasswordChar = '\0';
            this.supSearchText.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.supSearchText.PlaceholderText = "Search";
            this.supSearchText.SelectedText = "";
            this.supSearchText.Size = new System.Drawing.Size(400, 42);
            this.supSearchText.TabIndex = 7;
            this.supSearchText.TextChanged += new System.EventHandler(this.supSearchText_TextChanged);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.supDataGridView);
            this.Controls.Add(this.selectSupDateTime);
            this.Controls.Add(this.supRefreshBtn);
            this.Controls.Add(this.supFilterBtn);
            this.Controls.Add(this.supAllPgLabel);
            this.Controls.Add(this.supOfLabel);
            this.Controls.Add(this.supPgRangeLabel);
            this.Controls.Add(this.supPageCombo);
            this.Controls.Add(this.supRecordsPerLabel);
            this.Controls.Add(this.supBtnPanel);
            this.Controls.Add(this.createSupBtn);
            this.Controls.Add(this.supSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "SupplierForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.supBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox supSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createSupBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel supBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supLastBtn;
        private System.Windows.Forms.Label supAllPgLabel;
        private System.Windows.Forms.Label supOfLabel;
        private System.Windows.Forms.Label supPgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox supPageCombo;
        private System.Windows.Forms.Label supRecordsPerLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supFilterBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel supFilterPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker selectSupDateTime;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView supDataGridView;
    }
}