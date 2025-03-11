namespace EscopeWindowsApp
{
    partial class WarehouseForm
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
            this.wareSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createWareBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.wareDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wareBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.wareFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.warePrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.wareNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.wareLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.wareAllPgLabel = new System.Windows.Forms.Label();
            this.wareOfLabel = new System.Windows.Forms.Label();
            this.warePgRangeLabel = new System.Windows.Forms.Label();
            this.warePageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.wareRecordsPerLabel = new System.Windows.Forms.Label();
            this.wareFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.wareDataGridView)).BeginInit();
            this.wareBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // wareSearchText
            // 
            this.wareSearchText.BorderColor = System.Drawing.Color.Gray;
            this.wareSearchText.BorderRadius = 8;
            this.wareSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wareSearchText.DefaultText = "";
            this.wareSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.wareSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.wareSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.wareSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.wareSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.wareSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.wareSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wareSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.wareSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.wareSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.wareSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.wareSearchText.Location = new System.Drawing.Point(17, 30);
            this.wareSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wareSearchText.Name = "wareSearchText";
            this.wareSearchText.PasswordChar = '\0';
            this.wareSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.wareSearchText.PlaceholderText = "Search";
            this.wareSearchText.SelectedText = "";
            this.wareSearchText.Size = new System.Drawing.Size(400, 42);
            this.wareSearchText.TabIndex = 3;
            // 
            // createWareBtn
            // 
            this.createWareBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createWareBtn.Animated = true;
            this.createWareBtn.BorderRadius = 8;
            this.createWareBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createWareBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createWareBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createWareBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createWareBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createWareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.createWareBtn.ForeColor = System.Drawing.Color.White;
            this.createWareBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createWareBtn.Location = new System.Drawing.Point(1158, 30);
            this.createWareBtn.Name = "createWareBtn";
            this.createWareBtn.Size = new System.Drawing.Size(209, 42);
            this.createWareBtn.TabIndex = 5;
            this.createWareBtn.Text = "Craete Warehouse";
            this.createWareBtn.Click += new System.EventHandler(this.createWareBtn_Click);
            // 
            // wareDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.wareDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.wareDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.wareDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.wareDataGridView.ColumnHeadersHeight = 25;
            this.wareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.wareDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.wareDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.wareDataGridView.GridColor = System.Drawing.Color.White;
            this.wareDataGridView.Location = new System.Drawing.Point(17, 100);
            this.wareDataGridView.Name = "wareDataGridView";
            this.wareDataGridView.RowHeadersVisible = false;
            this.wareDataGridView.Size = new System.Drawing.Size(1352, 614);
            this.wareDataGridView.TabIndex = 10;
            this.wareDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.wareDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.wareDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.wareDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.wareDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.wareDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.wareDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.wareDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.wareDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.wareDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.wareDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wareDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.wareDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.wareDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.wareDataGridView.ThemeStyle.ReadOnly = false;
            this.wareDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.wareDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.wareDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wareDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.wareDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.wareDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.wareDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            // wareBtnPanel
            // 
            this.wareBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wareBtnPanel.BorderRadius = 8;
            this.wareBtnPanel.Controls.Add(this.wareFirstBtn);
            this.wareBtnPanel.Controls.Add(this.warePrevBtn);
            this.wareBtnPanel.Controls.Add(this.wareNextBtn);
            this.wareBtnPanel.Controls.Add(this.wareLastBtn);
            this.wareBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.wareBtnPanel.Name = "wareBtnPanel";
            this.wareBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.wareBtnPanel.TabIndex = 23;
            // 
            // wareFirstBtn
            // 
            this.wareFirstBtn.BorderRadius = 6;
            this.wareFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.wareFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.wareFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.wareFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.wareFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.wareFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.wareFirstBtn.ForeColor = System.Drawing.Color.White;
            this.wareFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.wareFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.wareFirstBtn.Name = "wareFirstBtn";
            this.wareFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.wareFirstBtn.TabIndex = 11;
            // 
            // warePrevBtn
            // 
            this.warePrevBtn.BorderRadius = 6;
            this.warePrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.warePrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.warePrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.warePrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.warePrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.warePrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.warePrevBtn.ForeColor = System.Drawing.Color.White;
            this.warePrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.warePrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.warePrevBtn.Location = new System.Drawing.Point(45, 8);
            this.warePrevBtn.Name = "warePrevBtn";
            this.warePrevBtn.Size = new System.Drawing.Size(26, 26);
            this.warePrevBtn.TabIndex = 11;
            // 
            // wareNextBtn
            // 
            this.wareNextBtn.BorderRadius = 6;
            this.wareNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.wareNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.wareNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.wareNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.wareNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.wareNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.wareNextBtn.ForeColor = System.Drawing.Color.White;
            this.wareNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.wareNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.wareNextBtn.Location = new System.Drawing.Point(87, 8);
            this.wareNextBtn.Name = "wareNextBtn";
            this.wareNextBtn.Size = new System.Drawing.Size(26, 26);
            this.wareNextBtn.TabIndex = 9;
            // 
            // wareLastBtn
            // 
            this.wareLastBtn.BorderRadius = 6;
            this.wareLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.wareLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.wareLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.wareLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.wareLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.wareLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.wareLastBtn.ForeColor = System.Drawing.Color.White;
            this.wareLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.wareLastBtn.Location = new System.Drawing.Point(130, 8);
            this.wareLastBtn.Name = "wareLastBtn";
            this.wareLastBtn.Size = new System.Drawing.Size(26, 26);
            this.wareLastBtn.TabIndex = 8;
            // 
            // wareAllPgLabel
            // 
            this.wareAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wareAllPgLabel.AutoSize = true;
            this.wareAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wareAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wareAllPgLabel.Location = new System.Drawing.Point(295, 742);
            this.wareAllPgLabel.Name = "wareAllPgLabel";
            this.wareAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.wareAllPgLabel.TabIndex = 32;
            this.wareAllPgLabel.Text = "500";
            // 
            // wareOfLabel
            // 
            this.wareOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wareOfLabel.AutoSize = true;
            this.wareOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wareOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wareOfLabel.Location = new System.Drawing.Point(274, 742);
            this.wareOfLabel.Name = "wareOfLabel";
            this.wareOfLabel.Size = new System.Drawing.Size(22, 19);
            this.wareOfLabel.TabIndex = 31;
            this.wareOfLabel.Text = "of";
            // 
            // warePgRangeLabel
            // 
            this.warePgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.warePgRangeLabel.AutoSize = true;
            this.warePgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warePgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.warePgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.warePgRangeLabel.Name = "warePgRangeLabel";
            this.warePgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.warePgRangeLabel.TabIndex = 30;
            this.warePgRangeLabel.Text = "0-50";
            // 
            // warePageCombo
            // 
            this.warePageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.warePageCombo.BackColor = System.Drawing.Color.Transparent;
            this.warePageCombo.BorderColor = System.Drawing.Color.Black;
            this.warePageCombo.BorderRadius = 8;
            this.warePageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.warePageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.warePageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.warePageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.warePageCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warePageCombo.ForeColor = System.Drawing.Color.Black;
            this.warePageCombo.ItemHeight = 30;
            this.warePageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.warePageCombo.Location = new System.Drawing.Point(141, 734);
            this.warePageCombo.Name = "warePageCombo";
            this.warePageCombo.Size = new System.Drawing.Size(85, 36);
            this.warePageCombo.StartIndex = 0;
            this.warePageCombo.TabIndex = 29;
            // 
            // wareRecordsPerLabel
            // 
            this.wareRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wareRecordsPerLabel.AutoSize = true;
            this.wareRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wareRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wareRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.wareRecordsPerLabel.Name = "wareRecordsPerLabel";
            this.wareRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.wareRecordsPerLabel.TabIndex = 28;
            this.wareRecordsPerLabel.Text = "Records per page";
            // 
            // wareFilterBtn
            // 
            this.wareFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wareFilterBtn.Animated = true;
            this.wareFilterBtn.BorderRadius = 8;
            this.wareFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.wareFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.wareFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.wareFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.wareFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.wareFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.wareFilterBtn.ForeColor = System.Drawing.Color.White;
            this.wareFilterBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.wareFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.whitefilter;
            this.wareFilterBtn.Location = new System.Drawing.Point(1098, 30);
            this.wareFilterBtn.Name = "wareFilterBtn";
            this.wareFilterBtn.Size = new System.Drawing.Size(43, 42);
            this.wareFilterBtn.TabIndex = 33;
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.wareFilterBtn);
            this.Controls.Add(this.wareAllPgLabel);
            this.Controls.Add(this.wareOfLabel);
            this.Controls.Add(this.warePgRangeLabel);
            this.Controls.Add(this.warePageCombo);
            this.Controls.Add(this.wareRecordsPerLabel);
            this.Controls.Add(this.wareBtnPanel);
            this.Controls.Add(this.wareDataGridView);
            this.Controls.Add(this.createWareBtn);
            this.Controls.Add(this.wareSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseForm";
            this.Text = "WarehouseForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wareDataGridView)).EndInit();
            this.wareBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox wareSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createWareBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView wareDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn supEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn supPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private Siticone.Desktop.UI.WinForms.SiticonePanel wareBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton wareFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton warePrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton wareNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton wareLastBtn;
        private System.Windows.Forms.Label wareAllPgLabel;
        private System.Windows.Forms.Label wareOfLabel;
        private System.Windows.Forms.Label warePgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox warePageCombo;
        private System.Windows.Forms.Label wareRecordsPerLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton wareFilterBtn;
    }
}