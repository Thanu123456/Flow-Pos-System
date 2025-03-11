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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saleDataComboBox1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.createSaleBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.salesReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesCusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPayStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.saleDataComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saleDataComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.saleDataComboBox1.BorderColor = System.Drawing.Color.Gray;
            this.saleDataComboBox1.BorderRadius = 8;
            this.saleDataComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.saleDataComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saleDataComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleDataComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleDataComboBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDataComboBox1.ForeColor = System.Drawing.Color.Gray;
            this.saleDataComboBox1.ItemHeight = 30;
            this.saleDataComboBox1.Items.AddRange(new object[] {
            "Select Date",
            "Today",
            "This Week",
            "Last Week",
            "This Month",
            "Last Month"});
            this.saleDataComboBox1.Location = new System.Drawing.Point(872, 37);
            this.saleDataComboBox1.Name = "saleDataComboBox1";
            this.saleDataComboBox1.Size = new System.Drawing.Size(209, 36);
            this.saleDataComboBox1.StartIndex = 0;
            this.saleDataComboBox1.TabIndex = 7;
            this.saleDataComboBox1.SelectedIndexChanged += new System.EventHandler(this.saleDataComboBox1_SelectedIndexChanged);
            // 
            // createSaleBtn
            // 
            this.createSaleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createSaleBtn.Animated = true;
            this.createSaleBtn.BorderRadius = 8;
            this.createSaleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createSaleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createSaleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createSaleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createSaleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.createSaleBtn.ForeColor = System.Drawing.Color.White;
            this.createSaleBtn.Location = new System.Drawing.Point(1158, 30);
            this.createSaleBtn.Name = "createSaleBtn";
            this.createSaleBtn.Size = new System.Drawing.Size(209, 42);
            this.createSaleBtn.TabIndex = 6;
            this.createSaleBtn.Text = "Create Sale";
            this.createSaleBtn.Click += new System.EventHandler(this.createSaleBtn_Click);
            // 
            // saleFilterBtn
            // 
            this.saleFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saleFilterBtn.Animated = true;
            this.saleFilterBtn.BorderRadius = 8;
            this.saleFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.saleFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleFilterBtn.ForeColor = System.Drawing.Color.White;
            this.saleFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.whitefilter;
            this.saleFilterBtn.Location = new System.Drawing.Point(1098, 30);
            this.saleFilterBtn.Name = "saleFilterBtn";
            this.saleFilterBtn.Size = new System.Drawing.Size(43, 43);
            this.saleFilterBtn.TabIndex = 5;
            this.saleFilterBtn.Click += new System.EventHandler(this.saleFilterBtn_Click);
            // 
            // saleDataGridView
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.saleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.saleDataGridView.ColumnHeadersHeight = 25;
            this.saleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.saleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesReference,
            this.salesCusName,
            this.salesWarehouse,
            this.salesStatus,
            this.salesGrandTotal,
            this.salesPaid,
            this.salesPayStatus});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.saleDataGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.saleDataGridView.GridColor = System.Drawing.Color.White;
            this.saleDataGridView.Location = new System.Drawing.Point(17, 100);
            this.saleDataGridView.Name = "saleDataGridView";
            this.saleDataGridView.RowHeadersVisible = false;
            this.saleDataGridView.Size = new System.Drawing.Size(1352, 615);
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
            this.saleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleDataGridView_CellContentClick);
            // 
            // salesReference
            // 
            this.salesReference.HeaderText = "Reference";
            this.salesReference.Name = "salesReference";
            // 
            // salesCusName
            // 
            this.salesCusName.HeaderText = "Customer";
            this.salesCusName.Name = "salesCusName";
            // 
            // salesWarehouse
            // 
            this.salesWarehouse.HeaderText = "Warehouse";
            this.salesWarehouse.Name = "salesWarehouse";
            // 
            // salesStatus
            // 
            this.salesStatus.HeaderText = "Status";
            this.salesStatus.Name = "salesStatus";
            // 
            // salesGrandTotal
            // 
            this.salesGrandTotal.HeaderText = "Grand Total";
            this.salesGrandTotal.Name = "salesGrandTotal";
            // 
            // salesPaid
            // 
            this.salesPaid.HeaderText = "Paid";
            this.salesPaid.Name = "salesPaid";
            // 
            // salesPayStatus
            // 
            this.salesPayStatus.HeaderText = "Payment Status";
            this.salesPayStatus.Name = "salesPayStatus";
            // 
            // saleAllPgLabel
            // 
            this.saleAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saleAllPgLabel.AutoSize = true;
            this.saleAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleAllPgLabel.Location = new System.Drawing.Point(295, 742);
            this.saleAllPgLabel.Name = "saleAllPgLabel";
            this.saleAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.saleAllPgLabel.TabIndex = 25;
            this.saleAllPgLabel.Text = "500";
            // 
            // saleOfLabel
            // 
            this.saleOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saleOfLabel.AutoSize = true;
            this.saleOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleOfLabel.Location = new System.Drawing.Point(274, 742);
            this.saleOfLabel.Name = "saleOfLabel";
            this.saleOfLabel.Size = new System.Drawing.Size(22, 19);
            this.saleOfLabel.TabIndex = 24;
            this.saleOfLabel.Text = "of";
            // 
            // salePgRangeLabel
            // 
            this.salePgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.salePgRangeLabel.AutoSize = true;
            this.salePgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salePgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.salePgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.salePgRangeLabel.Name = "salePgRangeLabel";
            this.salePgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.salePgRangeLabel.TabIndex = 23;
            this.salePgRangeLabel.Text = "0-50";
            // 
            // salePageCombo
            // 
            this.salePageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.salePageCombo.Location = new System.Drawing.Point(141, 734);
            this.salePageCombo.Name = "salePageCombo";
            this.salePageCombo.Size = new System.Drawing.Size(85, 36);
            this.salePageCombo.StartIndex = 0;
            this.salePageCombo.TabIndex = 22;
            // 
            // saleRecordsPerLabel
            // 
            this.saleRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saleRecordsPerLabel.AutoSize = true;
            this.saleRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.saleRecordsPerLabel.Name = "saleRecordsPerLabel";
            this.saleRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.saleRecordsPerLabel.TabIndex = 21;
            this.saleRecordsPerLabel.Text = "Records per page";
            // 
            // saleBtnPanel
            // 
            this.saleBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saleBtnPanel.BorderRadius = 8;
            this.saleBtnPanel.Controls.Add(this.saleFirstBtn);
            this.saleBtnPanel.Controls.Add(this.salePrevBtn);
            this.saleBtnPanel.Controls.Add(this.saleNextBtn);
            this.saleBtnPanel.Controls.Add(this.saleLastBtn);
            this.saleBtnPanel.Location = new System.Drawing.Point(1213, 734);
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
            this.saleFirstBtn.Click += new System.EventHandler(this.saleFirstBtn_Click);
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
            this.salePrevBtn.Click += new System.EventHandler(this.salePrevBtn_Click);
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
            this.saleNextBtn.Click += new System.EventHandler(this.saleNextBtn_Click);
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
            this.saleLastBtn.Click += new System.EventHandler(this.saleLastBtn_Click);
            // 
            // saleSearchText
            // 
            this.saleSearchText.BorderColor = System.Drawing.Color.Gray;
            this.saleSearchText.BorderRadius = 8;
            this.saleSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.saleSearchText.DefaultText = "";
            this.saleSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.saleSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.saleSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.saleSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.saleSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saleSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saleSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.saleSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.saleSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.saleSearchText.Location = new System.Drawing.Point(17, 30);
            this.saleSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saleSearchText.Name = "saleSearchText";
            this.saleSearchText.PasswordChar = '\0';
            this.saleSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.saleSearchText.PlaceholderText = "Search";
            this.saleSearchText.SelectedText = "";
            this.saleSearchText.Size = new System.Drawing.Size(400, 42);
            this.saleSearchText.TabIndex = 27;
            this.saleSearchText.TextChanged += new System.EventHandler(this.saleSearchText_TextChanged);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 788);
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
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn salesReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesCusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesGrandTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPayStatus;
    }
}