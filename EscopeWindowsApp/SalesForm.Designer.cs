namespace EscopeWindowsApp
{
    partial class SalesForm
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
            this.saleDataComboBox1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.createSaleBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleAllPgLabel = new System.Windows.Forms.Label();
            this.saleOfLabel = new System.Windows.Forms.Label();
            this.salePgRangeLabel = new System.Windows.Forms.Label();
            this.salePageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.saleRecordsPerLabel = new System.Windows.Forms.Label();
            this.saleBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.saleFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.salePrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).BeginInit();
            this.saleBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saleDataComboBox1
            // 
            this.saleDataComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.saleDataComboBox1.BorderRadius = 8;
            this.saleDataComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.saleDataComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saleDataComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleDataComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleDataComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.saleDataComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.saleDataComboBox1.ItemHeight = 30;
            this.saleDataComboBox1.Items.AddRange(new object[] {
            "Select Date",
            "Today",
            "This Week",
            "Last Week",
            "This Month",
            "Last Month"});
            this.saleDataComboBox1.Location = new System.Drawing.Point(152, 49);
            this.saleDataComboBox1.Name = "saleDataComboBox1";
            this.saleDataComboBox1.Size = new System.Drawing.Size(400, 36);
            this.saleDataComboBox1.StartIndex = 0;
            this.saleDataComboBox1.TabIndex = 7;
            // 
            // createSaleBtn
            // 
            this.createSaleBtn.BorderRadius = 8;
            this.createSaleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createSaleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createSaleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createSaleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createSaleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.createSaleBtn.ForeColor = System.Drawing.Color.White;
            this.createSaleBtn.Location = new System.Drawing.Point(710, 42);
            this.createSaleBtn.Name = "createSaleBtn";
            this.createSaleBtn.Size = new System.Drawing.Size(209, 42);
            this.createSaleBtn.TabIndex = 6;
            this.createSaleBtn.Text = "Create Sale";
            this.createSaleBtn.Click += new System.EventHandler(this.createSaleBtn_Click);
            // 
            // saleFilterBtn
            // 
            this.saleFilterBtn.BorderRadius = 8;
            this.saleFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.saleFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleFilterBtn.ForeColor = System.Drawing.Color.White;
            this.saleFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.whitefilter;
            this.saleFilterBtn.Location = new System.Drawing.Point(646, 42);
            this.saleFilterBtn.Name = "saleFilterBtn";
            this.saleFilterBtn.Size = new System.Drawing.Size(43, 43);
            this.saleFilterBtn.TabIndex = 5;
            // 
            // saleDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.saleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.saleDataGridView.ColumnHeadersHeight = 25;
            this.saleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.saleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.saleDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.saleDataGridView.GridColor = System.Drawing.Color.White;
            this.saleDataGridView.Location = new System.Drawing.Point(35, 90);
            this.saleDataGridView.Name = "saleDataGridView";
            this.saleDataGridView.RowHeadersVisible = false;
            this.saleDataGridView.Size = new System.Drawing.Size(1833, 840);
            this.saleDataGridView.TabIndex = 9;
            this.saleDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.saleDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saleDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.saleDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.saleDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.saleDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.saleDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.saleDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.saleDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.saleDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.saleDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.saleDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.saleDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.saleDataGridView.ThemeStyle.ReadOnly = false;
            this.saleDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.saleDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.saleDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.saleDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.saleDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.saleDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            // saleAllPgLabel
            // 
            this.saleAllPgLabel.AutoSize = true;
            this.saleAllPgLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleAllPgLabel.Location = new System.Drawing.Point(389, 211);
            this.saleAllPgLabel.Name = "saleAllPgLabel";
            this.saleAllPgLabel.Size = new System.Drawing.Size(40, 23);
            this.saleAllPgLabel.TabIndex = 25;
            this.saleAllPgLabel.Text = "500";
            // 
            // saleOfLabel
            // 
            this.saleOfLabel.AutoSize = true;
            this.saleOfLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleOfLabel.Location = new System.Drawing.Point(364, 211);
            this.saleOfLabel.Name = "saleOfLabel";
            this.saleOfLabel.Size = new System.Drawing.Size(26, 23);
            this.saleOfLabel.TabIndex = 24;
            this.saleOfLabel.Text = "of";
            // 
            // salePgRangeLabel
            // 
            this.salePgRangeLabel.AutoSize = true;
            this.salePgRangeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salePgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.salePgRangeLabel.Location = new System.Drawing.Point(322, 211);
            this.salePgRangeLabel.Name = "salePgRangeLabel";
            this.salePgRangeLabel.Size = new System.Drawing.Size(46, 23);
            this.salePgRangeLabel.TabIndex = 23;
            this.salePgRangeLabel.Text = "0-50";
            // 
            // salePageCombo
            // 
            this.salePageCombo.BackColor = System.Drawing.Color.Transparent;
            this.salePageCombo.BorderColor = System.Drawing.Color.Black;
            this.salePageCombo.BorderRadius = 8;
            this.salePageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.salePageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salePageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salePageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salePageCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salePageCombo.ForeColor = System.Drawing.Color.Black;
            this.salePageCombo.ItemHeight = 30;
            this.salePageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.salePageCombo.Location = new System.Drawing.Point(208, 203);
            this.salePageCombo.Name = "salePageCombo";
            this.salePageCombo.Size = new System.Drawing.Size(85, 36);
            this.salePageCombo.StartIndex = 0;
            this.salePageCombo.TabIndex = 22;
            // 
            // saleRecordsPerLabel
            // 
            this.saleRecordsPerLabel.AutoSize = true;
            this.saleRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleRecordsPerLabel.Location = new System.Drawing.Point(57, 211);
            this.saleRecordsPerLabel.Name = "saleRecordsPerLabel";
            this.saleRecordsPerLabel.Size = new System.Drawing.Size(143, 23);
            this.saleRecordsPerLabel.TabIndex = 21;
            this.saleRecordsPerLabel.Text = "Records per page";
            // 
            // saleBtnPanel
            // 
            this.saleBtnPanel.BorderRadius = 8;
            this.saleBtnPanel.Controls.Add(this.saleFirstBtn);
            this.saleBtnPanel.Controls.Add(this.salePrevBtn);
            this.saleBtnPanel.Controls.Add(this.saleNextBtn);
            this.saleBtnPanel.Controls.Add(this.saleLastBtn);
            this.saleBtnPanel.Location = new System.Drawing.Point(519, 163);
            this.saleBtnPanel.Name = "saleBtnPanel";
            this.saleBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.saleBtnPanel.TabIndex = 26;
            // 
            // saleFirstBtn
            // 
            this.saleFirstBtn.BorderRadius = 6;
            this.saleFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.saleFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleFirstBtn.ForeColor = System.Drawing.Color.White;
            this.saleFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.saleFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.saleFirstBtn.Name = "saleFirstBtn";
            this.saleFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.saleFirstBtn.TabIndex = 11;
            // 
            // salePrevBtn
            // 
            this.salePrevBtn.BorderRadius = 6;
            this.salePrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salePrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salePrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salePrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salePrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.salePrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.salePrevBtn.ForeColor = System.Drawing.Color.White;
            this.salePrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.salePrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.salePrevBtn.Location = new System.Drawing.Point(45, 8);
            this.salePrevBtn.Name = "salePrevBtn";
            this.salePrevBtn.Size = new System.Drawing.Size(26, 26);
            this.salePrevBtn.TabIndex = 11;
            // 
            // saleNextBtn
            // 
            this.saleNextBtn.BorderRadius = 6;
            this.saleNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.saleNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleNextBtn.ForeColor = System.Drawing.Color.White;
            this.saleNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.saleNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.saleNextBtn.Location = new System.Drawing.Point(87, 8);
            this.saleNextBtn.Name = "saleNextBtn";
            this.saleNextBtn.Size = new System.Drawing.Size(26, 26);
            this.saleNextBtn.TabIndex = 9;
            // 
            // saleLastBtn
            // 
            this.saleLastBtn.BorderRadius = 6;
            this.saleLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.saleLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleLastBtn.ForeColor = System.Drawing.Color.White;
            this.saleLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.saleLastBtn.Location = new System.Drawing.Point(130, 8);
            this.saleLastBtn.Name = "saleLastBtn";
            this.saleLastBtn.Size = new System.Drawing.Size(26, 26);
            this.saleLastBtn.TabIndex = 8;
            // 
            // saleSearchText
            // 
            this.saleSearchText.BorderRadius = 8;
            this.saleSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.saleSearchText.DefaultText = "";
            this.saleSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.saleSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.saleSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.saleSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.saleSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.saleSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.saleSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.saleSearchText.Location = new System.Drawing.Point(35, 12);
            this.saleSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saleSearchText.Name = "saleSearchText";
            this.saleSearchText.PasswordChar = '\0';
            this.saleSearchText.PlaceholderText = "Search";
            this.saleSearchText.SelectedText = "";
            this.saleSearchText.Size = new System.Drawing.Size(400, 42);
            this.saleSearchText.TabIndex = 27;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.saleSearchText);
            this.Controls.Add(this.saleBtnPanel);
            this.Controls.Add(this.saleAllPgLabel);
            this.Controls.Add(this.saleOfLabel);
            this.Controls.Add(this.salePgRangeLabel);
            this.Controls.Add(this.salePageCombo);
            this.Controls.Add(this.saleRecordsPerLabel);
            this.Controls.Add(this.saleDataGridView);
            this.Controls.Add(this.saleDataComboBox1);
            this.Controls.Add(this.createSaleBtn);
            this.Controls.Add(this.saleFilterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).EndInit();
            this.saleBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox saleDataComboBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createSaleBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleFilterBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView saleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn supEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn supPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.Label saleAllPgLabel;
        private System.Windows.Forms.Label saleOfLabel;
        private System.Windows.Forms.Label salePgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox salePageCombo;
        private System.Windows.Forms.Label saleRecordsPerLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel saleBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton salePrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox saleSearchText;
    }
}