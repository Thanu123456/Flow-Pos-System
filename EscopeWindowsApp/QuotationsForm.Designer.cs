namespace EscopeWindowsApp
{
    partial class Quotations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.createQuotaBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.quotaDataComboBox1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.quotaDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.quotAllPgLabel = new System.Windows.Forms.Label();
            this.quotaOfLabel = new System.Windows.Forms.Label();
            this.quotaPgRangeLabel = new System.Windows.Forms.Label();
            this.quotaPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.quotaRecordsPerLabel = new System.Windows.Forms.Label();
            this.quotaBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.quotaFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.quotaPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.quotaNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.quotaLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.quotaFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.quotaSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.quoReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoCusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quotaDataGridView)).BeginInit();
            this.quotaBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createQuotaBtn
            // 
            this.createQuotaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createQuotaBtn.Animated = true;
            this.createQuotaBtn.BackColor = System.Drawing.Color.Transparent;
            this.createQuotaBtn.BorderRadius = 8;
            this.createQuotaBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createQuotaBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createQuotaBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createQuotaBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createQuotaBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createQuotaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.createQuotaBtn.ForeColor = System.Drawing.Color.White;
            this.createQuotaBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createQuotaBtn.Location = new System.Drawing.Point(1158, 30);
            this.createQuotaBtn.Name = "createQuotaBtn";
            this.createQuotaBtn.Size = new System.Drawing.Size(209, 42);
            this.createQuotaBtn.TabIndex = 3;
            this.createQuotaBtn.Text = "Create Quotation";
            this.createQuotaBtn.Click += new System.EventHandler(this.createQuotaBtn_Click);
            // 
            // quotaDataComboBox1
            // 
            this.quotaDataComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quotaDataComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.quotaDataComboBox1.BorderRadius = 8;
            this.quotaDataComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.quotaDataComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quotaDataComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quotaDataComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quotaDataComboBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.quotaDataComboBox1.ForeColor = System.Drawing.Color.Gray;
            this.quotaDataComboBox1.ItemHeight = 30;
            this.quotaDataComboBox1.Items.AddRange(new object[] {
            "Select Date",
            "Today",
            "This Week",
            "Last Week",
            "This Month",
            "Last Month"});
            this.quotaDataComboBox1.Location = new System.Drawing.Point(840, 36);
            this.quotaDataComboBox1.Name = "quotaDataComboBox1";
            this.quotaDataComboBox1.Size = new System.Drawing.Size(240, 36);
            this.quotaDataComboBox1.StartIndex = 0;
            this.quotaDataComboBox1.TabIndex = 4;
            // 
            // quotaDataGridView
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quotaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.quotaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.quotaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.quotaDataGridView.ColumnHeadersHeight = 25;
            this.quotaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.quotaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quoReference,
            this.quoCusName,
            this.quoWarehouse,
            this.quoStatus,
            this.quoGrandTotal,
            this.createdAt,
            this.action});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.quotaDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.quotaDataGridView.GridColor = System.Drawing.Color.White;
            this.quotaDataGridView.Location = new System.Drawing.Point(17, 100);
            this.quotaDataGridView.Name = "quotaDataGridView";
            this.quotaDataGridView.RowHeadersVisible = false;
            this.quotaDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.quotaDataGridView.TabIndex = 8;
            this.quotaDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.quotaDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quotaDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.quotaDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.quotaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.quotaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.quotaDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.quotaDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.quotaDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.quotaDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.quotaDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.quotaDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.quotaDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.quotaDataGridView.ThemeStyle.ReadOnly = false;
            this.quotaDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.quotaDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.quotaDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.quotaDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.quotaDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.quotaDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // quotAllPgLabel
            // 
            this.quotAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quotAllPgLabel.AutoSize = true;
            this.quotAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.quotAllPgLabel.Location = new System.Drawing.Point(295, 742);
            this.quotAllPgLabel.Name = "quotAllPgLabel";
            this.quotAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.quotAllPgLabel.TabIndex = 20;
            this.quotAllPgLabel.Text = "500";
            // 
            // quotaOfLabel
            // 
            this.quotaOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quotaOfLabel.AutoSize = true;
            this.quotaOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.quotaOfLabel.Location = new System.Drawing.Point(274, 742);
            this.quotaOfLabel.Name = "quotaOfLabel";
            this.quotaOfLabel.Size = new System.Drawing.Size(22, 19);
            this.quotaOfLabel.TabIndex = 19;
            this.quotaOfLabel.Text = "of";
            // 
            // quotaPgRangeLabel
            // 
            this.quotaPgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quotaPgRangeLabel.AutoSize = true;
            this.quotaPgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.quotaPgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.quotaPgRangeLabel.Name = "quotaPgRangeLabel";
            this.quotaPgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.quotaPgRangeLabel.TabIndex = 18;
            this.quotaPgRangeLabel.Text = "0-50";
            // 
            // quotaPageCombo
            // 
            this.quotaPageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quotaPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.quotaPageCombo.BorderColor = System.Drawing.Color.Black;
            this.quotaPageCombo.BorderRadius = 8;
            this.quotaPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.quotaPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quotaPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quotaPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quotaPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaPageCombo.ForeColor = System.Drawing.Color.Black;
            this.quotaPageCombo.ItemHeight = 30;
            this.quotaPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.quotaPageCombo.Location = new System.Drawing.Point(141, 734);
            this.quotaPageCombo.Name = "quotaPageCombo";
            this.quotaPageCombo.Size = new System.Drawing.Size(85, 36);
            this.quotaPageCombo.StartIndex = 0;
            this.quotaPageCombo.TabIndex = 17;
            // 
            // quotaRecordsPerLabel
            // 
            this.quotaRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quotaRecordsPerLabel.AutoSize = true;
            this.quotaRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.quotaRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.quotaRecordsPerLabel.Name = "quotaRecordsPerLabel";
            this.quotaRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.quotaRecordsPerLabel.TabIndex = 16;
            this.quotaRecordsPerLabel.Text = "Records per page";
            // 
            // quotaBtnPanel
            // 
            this.quotaBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quotaBtnPanel.BackColor = System.Drawing.Color.Transparent;
            this.quotaBtnPanel.BorderRadius = 8;
            this.quotaBtnPanel.Controls.Add(this.quotaFirstBtn);
            this.quotaBtnPanel.Controls.Add(this.quotaPrevBtn);
            this.quotaBtnPanel.Controls.Add(this.quotaNextBtn);
            this.quotaBtnPanel.Controls.Add(this.quotaLastBtn);
            this.quotaBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.quotaBtnPanel.Name = "quotaBtnPanel";
            this.quotaBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.quotaBtnPanel.TabIndex = 21;
            // 
            // quotaFirstBtn
            // 
            this.quotaFirstBtn.BorderRadius = 6;
            this.quotaFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quotaFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quotaFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quotaFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quotaFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.quotaFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quotaFirstBtn.ForeColor = System.Drawing.Color.White;
            this.quotaFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.quotaFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.quotaFirstBtn.Name = "quotaFirstBtn";
            this.quotaFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.quotaFirstBtn.TabIndex = 11;
            // 
            // quotaPrevBtn
            // 
            this.quotaPrevBtn.BorderRadius = 6;
            this.quotaPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quotaPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quotaPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quotaPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quotaPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.quotaPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quotaPrevBtn.ForeColor = System.Drawing.Color.White;
            this.quotaPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.quotaPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.quotaPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.quotaPrevBtn.Name = "quotaPrevBtn";
            this.quotaPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.quotaPrevBtn.TabIndex = 11;
            // 
            // quotaNextBtn
            // 
            this.quotaNextBtn.BorderRadius = 6;
            this.quotaNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quotaNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quotaNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quotaNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quotaNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.quotaNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quotaNextBtn.ForeColor = System.Drawing.Color.White;
            this.quotaNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.quotaNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.quotaNextBtn.Location = new System.Drawing.Point(87, 8);
            this.quotaNextBtn.Name = "quotaNextBtn";
            this.quotaNextBtn.Size = new System.Drawing.Size(26, 26);
            this.quotaNextBtn.TabIndex = 9;
            // 
            // quotaLastBtn
            // 
            this.quotaLastBtn.BorderRadius = 6;
            this.quotaLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quotaLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quotaLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quotaLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quotaLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.quotaLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quotaLastBtn.ForeColor = System.Drawing.Color.White;
            this.quotaLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.quotaLastBtn.Location = new System.Drawing.Point(130, 8);
            this.quotaLastBtn.Name = "quotaLastBtn";
            this.quotaLastBtn.Size = new System.Drawing.Size(26, 26);
            this.quotaLastBtn.TabIndex = 8;
            // 
            // quotaFilterBtn
            // 
            this.quotaFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quotaFilterBtn.Animated = true;
            this.quotaFilterBtn.BackColor = System.Drawing.Color.Transparent;
            this.quotaFilterBtn.BorderRadius = 8;
            this.quotaFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quotaFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quotaFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quotaFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quotaFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.quotaFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quotaFilterBtn.ForeColor = System.Drawing.Color.White;
            this.quotaFilterBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.quotaFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.whitefilter;
            this.quotaFilterBtn.Location = new System.Drawing.Point(1098, 30);
            this.quotaFilterBtn.Name = "quotaFilterBtn";
            this.quotaFilterBtn.Size = new System.Drawing.Size(43, 43);
            this.quotaFilterBtn.TabIndex = 2;
            this.quotaFilterBtn.Click += new System.EventHandler(this.quotaFilterBtn_Click);
            // 
            // quotaSearchText
            // 
            this.quotaSearchText.BorderRadius = 8;
            this.quotaSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quotaSearchText.DefaultText = "";
            this.quotaSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quotaSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quotaSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quotaSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quotaSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quotaSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quotaSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.quotaSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.quotaSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.quotaSearchText.Location = new System.Drawing.Point(17, 30);
            this.quotaSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quotaSearchText.Name = "quotaSearchText";
            this.quotaSearchText.PasswordChar = '\0';
            this.quotaSearchText.PlaceholderText = "Search";
            this.quotaSearchText.SelectedText = "";
            this.quotaSearchText.Size = new System.Drawing.Size(400, 42);
            this.quotaSearchText.TabIndex = 1;
            // 
            // quoReference
            // 
            this.quoReference.HeaderText = "Reference";
            this.quoReference.Name = "quoReference";
            // 
            // quoCusName
            // 
            this.quoCusName.HeaderText = "Customer";
            this.quoCusName.Name = "quoCusName";
            // 
            // quoWarehouse
            // 
            this.quoWarehouse.HeaderText = "WareHouse";
            this.quoWarehouse.Name = "quoWarehouse";
            // 
            // quoStatus
            // 
            this.quoStatus.HeaderText = "Status";
            this.quoStatus.Name = "quoStatus";
            // 
            // quoGrandTotal
            // 
            this.quoGrandTotal.HeaderText = "Grand Total";
            this.quoGrandTotal.Name = "quoGrandTotal";
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
            // Quotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.quotaBtnPanel);
            this.Controls.Add(this.quotAllPgLabel);
            this.Controls.Add(this.quotaOfLabel);
            this.Controls.Add(this.quotaPgRangeLabel);
            this.Controls.Add(this.quotaPageCombo);
            this.Controls.Add(this.quotaRecordsPerLabel);
            this.Controls.Add(this.quotaDataGridView);
            this.Controls.Add(this.quotaDataComboBox1);
            this.Controls.Add(this.createQuotaBtn);
            this.Controls.Add(this.quotaFilterBtn);
            this.Controls.Add(this.quotaSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Quotations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quotations";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Quotations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quotaDataGridView)).EndInit();
            this.quotaBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox quotaSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton quotaFilterBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createQuotaBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox quotaDataComboBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView quotaDataGridView;
        private System.Windows.Forms.Label quotAllPgLabel;
        private System.Windows.Forms.Label quotaOfLabel;
        private System.Windows.Forms.Label quotaPgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox quotaPageCombo;
        private System.Windows.Forms.Label quotaRecordsPerLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel quotaBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton quotaFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton quotaPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton quotaNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton quotaLastBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoCusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoGrandTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
    }
}