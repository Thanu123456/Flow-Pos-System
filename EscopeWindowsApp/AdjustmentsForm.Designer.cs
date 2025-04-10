﻿namespace EscopeWindowsApp
{
    partial class AdjustmentsForm
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
            this.createAdjBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.adjustDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.adjFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.adjPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.adjNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.adjLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.adjRecordsPerLabel = new System.Windows.Forms.Label();
            this.adjPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.adjPgRangeLabel = new System.Windows.Forms.Label();
            this.adjOfLabel = new System.Windows.Forms.Label();
            this.adjAllPgLabel = new System.Windows.Forms.Label();
            this.adjustFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.adjustSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.adjustDataGridView)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createAdjBtn
            // 
            this.createAdjBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createAdjBtn.Animated = true;
            this.createAdjBtn.BorderRadius = 8;
            this.createAdjBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createAdjBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createAdjBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createAdjBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createAdjBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createAdjBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.createAdjBtn.ForeColor = System.Drawing.Color.White;
            this.createAdjBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createAdjBtn.Location = new System.Drawing.Point(1158, 30);
            this.createAdjBtn.Name = "createAdjBtn";
            this.createAdjBtn.Size = new System.Drawing.Size(209, 42);
            this.createAdjBtn.TabIndex = 2;
            this.createAdjBtn.Text = "Create Adjustments";
            this.createAdjBtn.Click += new System.EventHandler(this.createAdjBtn_Click);
            // 
            // adjustDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adjustDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.adjustDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adjustDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.adjustDataGridView.ColumnHeadersHeight = 25;
            this.adjustDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.adjustDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierID,
            this.supName,
            this.supDesc,
            this.supEmail,
            this.supPhone,
            this.createdAt,
            this.action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adjustDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.adjustDataGridView.GridColor = System.Drawing.Color.White;
            this.adjustDataGridView.Location = new System.Drawing.Point(17, 100);
            this.adjustDataGridView.Name = "adjustDataGridView";
            this.adjustDataGridView.RowHeadersVisible = false;
            this.adjustDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.adjustDataGridView.TabIndex = 7;
            this.adjustDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.adjustDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adjustDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.adjustDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.adjustDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.adjustDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.adjustDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.adjustDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.adjustDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.adjustDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.adjustDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.adjustDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.adjustDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.adjustDataGridView.ThemeStyle.ReadOnly = false;
            this.adjustDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.adjustDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.adjustDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.adjustDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.adjustDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.adjustDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // supplierID
            // 
            this.supplierID.HeaderText = "Supplier ID";
            this.supplierID.Name = "supplierID";
            // 
            // supName
            // 
            this.supName.HeaderText = "Name";
            this.supName.Name = "supName";
            // 
            // supDesc
            // 
            this.supDesc.HeaderText = "Description";
            this.supDesc.Name = "supDesc";
            // 
            // supEmail
            // 
            this.supEmail.HeaderText = "Email";
            this.supEmail.Name = "supEmail";
            // 
            // supPhone
            // 
            this.supPhone.HeaderText = "Phone";
            this.supPhone.Name = "supPhone";
            // 
            // createdAt
            // 
            this.createdAt.HeaderText = "Create At";
            this.createdAt.Name = "createdAt";
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            // 
            // btnPanel
            // 
            this.btnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanel.BorderRadius = 8;
            this.btnPanel.Controls.Add(this.adjFirstBtn);
            this.btnPanel.Controls.Add(this.adjPrevBtn);
            this.btnPanel.Controls.Add(this.adjNextBtn);
            this.btnPanel.Controls.Add(this.adjLastBtn);
            this.btnPanel.Location = new System.Drawing.Point(1213, 734);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(154, 37);
            this.btnPanel.TabIndex = 10;
            // 
            // adjFirstBtn
            // 
            this.adjFirstBtn.BorderRadius = 6;
            this.adjFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.adjFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adjFirstBtn.ForeColor = System.Drawing.Color.White;
            this.adjFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.adjFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.adjFirstBtn.Name = "adjFirstBtn";
            this.adjFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.adjFirstBtn.TabIndex = 11;
            // 
            // adjPrevBtn
            // 
            this.adjPrevBtn.BorderRadius = 6;
            this.adjPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.adjPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adjPrevBtn.ForeColor = System.Drawing.Color.White;
            this.adjPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.adjPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.adjPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.adjPrevBtn.Name = "adjPrevBtn";
            this.adjPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.adjPrevBtn.TabIndex = 11;
            // 
            // adjNextBtn
            // 
            this.adjNextBtn.BorderRadius = 6;
            this.adjNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.adjNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adjNextBtn.ForeColor = System.Drawing.Color.White;
            this.adjNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.adjNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.adjNextBtn.Location = new System.Drawing.Point(87, 8);
            this.adjNextBtn.Name = "adjNextBtn";
            this.adjNextBtn.Size = new System.Drawing.Size(26, 26);
            this.adjNextBtn.TabIndex = 9;
            // 
            // adjLastBtn
            // 
            this.adjLastBtn.BorderRadius = 6;
            this.adjLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.adjLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adjLastBtn.ForeColor = System.Drawing.Color.White;
            this.adjLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.adjLastBtn.Location = new System.Drawing.Point(130, 8);
            this.adjLastBtn.Name = "adjLastBtn";
            this.adjLastBtn.Size = new System.Drawing.Size(26, 26);
            this.adjLastBtn.TabIndex = 8;
            // 
            // adjRecordsPerLabel
            // 
            this.adjRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.adjRecordsPerLabel.AutoSize = true;
            this.adjRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adjRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.adjRecordsPerLabel.Name = "adjRecordsPerLabel";
            this.adjRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.adjRecordsPerLabel.TabIndex = 11;
            this.adjRecordsPerLabel.Text = "Records per page";
            // 
            // adjPageCombo
            // 
            this.adjPageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.adjPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.adjPageCombo.BorderColor = System.Drawing.Color.Black;
            this.adjPageCombo.BorderRadius = 8;
            this.adjPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.adjPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adjPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adjPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adjPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjPageCombo.ForeColor = System.Drawing.Color.Black;
            this.adjPageCombo.ItemHeight = 30;
            this.adjPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.adjPageCombo.Location = new System.Drawing.Point(141, 734);
            this.adjPageCombo.Name = "adjPageCombo";
            this.adjPageCombo.Size = new System.Drawing.Size(85, 36);
            this.adjPageCombo.StartIndex = 0;
            this.adjPageCombo.TabIndex = 12;
            // 
            // adjPgRangeLabel
            // 
            this.adjPgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.adjPgRangeLabel.AutoSize = true;
            this.adjPgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adjPgRangeLabel.Location = new System.Drawing.Point(239, 742);
            this.adjPgRangeLabel.Name = "adjPgRangeLabel";
            this.adjPgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.adjPgRangeLabel.TabIndex = 13;
            this.adjPgRangeLabel.Text = "0-50";
            // 
            // adjOfLabel
            // 
            this.adjOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.adjOfLabel.AutoSize = true;
            this.adjOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adjOfLabel.Location = new System.Drawing.Point(276, 742);
            this.adjOfLabel.Name = "adjOfLabel";
            this.adjOfLabel.Size = new System.Drawing.Size(22, 19);
            this.adjOfLabel.TabIndex = 14;
            this.adjOfLabel.Text = "of";
            // 
            // adjAllPgLabel
            // 
            this.adjAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.adjAllPgLabel.AutoSize = true;
            this.adjAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adjAllPgLabel.Location = new System.Drawing.Point(297, 742);
            this.adjAllPgLabel.Name = "adjAllPgLabel";
            this.adjAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.adjAllPgLabel.TabIndex = 15;
            this.adjAllPgLabel.Text = "500";
            // 
            // adjustFilterBtn
            // 
            this.adjustFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adjustFilterBtn.Animated = true;
            this.adjustFilterBtn.BorderRadius = 8;
            this.adjustFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjustFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjustFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjustFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjustFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.adjustFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adjustFilterBtn.ForeColor = System.Drawing.Color.White;
            this.adjustFilterBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.adjustFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.whitefilter;
            this.adjustFilterBtn.Location = new System.Drawing.Point(1098, 30);
            this.adjustFilterBtn.Name = "adjustFilterBtn";
            this.adjustFilterBtn.Size = new System.Drawing.Size(43, 43);
            this.adjustFilterBtn.TabIndex = 1;
            // 
            // adjustSearchText
            // 
            this.adjustSearchText.BorderColor = System.Drawing.Color.Gray;
            this.adjustSearchText.BorderRadius = 8;
            this.adjustSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adjustSearchText.DefaultText = "";
            this.adjustSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adjustSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adjustSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adjustSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adjustSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adjustSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adjustSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adjustSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.adjustSearchText.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.adjustSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.adjustSearchText.Location = new System.Drawing.Point(17, 30);
            this.adjustSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adjustSearchText.Name = "adjustSearchText";
            this.adjustSearchText.PasswordChar = '\0';
            this.adjustSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.adjustSearchText.PlaceholderText = "Search";
            this.adjustSearchText.SelectedText = "";
            this.adjustSearchText.Size = new System.Drawing.Size(400, 42);
            this.adjustSearchText.TabIndex = 0;
            // 
            // AdjustmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.adjAllPgLabel);
            this.Controls.Add(this.adjOfLabel);
            this.Controls.Add(this.adjPgRangeLabel);
            this.Controls.Add(this.adjPageCombo);
            this.Controls.Add(this.adjRecordsPerLabel);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.adjustDataGridView);
            this.Controls.Add(this.createAdjBtn);
            this.Controls.Add(this.adjustFilterBtn);
            this.Controls.Add(this.adjustSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "AdjustmentsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Adjustments";
            ((System.ComponentModel.ISupportInitialize)(this.adjustDataGridView)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox adjustSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton adjustFilterBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createAdjBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView adjustDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn supEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn supPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private Siticone.Desktop.UI.WinForms.SiticoneButton adjLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton adjNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel btnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton adjPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton adjFirstBtn;
        private System.Windows.Forms.Label adjRecordsPerLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox adjPageCombo;
        private System.Windows.Forms.Label adjPgRangeLabel;
        private System.Windows.Forms.Label adjOfLabel;
        private System.Windows.Forms.Label adjAllPgLabel;
    }
}