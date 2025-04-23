namespace EscopeWindowsApp
{
    partial class SaleReturnForm
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
            this.saleReFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleReSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.saleReDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.saleReAllPgLabel = new System.Windows.Forms.Label();
            this.saleReOfLabel = new System.Windows.Forms.Label();
            this.saleRePgRangeLabel = new System.Windows.Forms.Label();
            this.saleRePageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.saleReRecordsPerLabel = new System.Windows.Forms.Label();
            this.saleReBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.saleReFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleRePrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleReNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleReLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.selectSaleReDateTime = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.saleReturnRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.saleReDataGridView)).BeginInit();
            this.saleReBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saleReFilterBtn
            // 
            this.saleReFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saleReFilterBtn.BorderRadius = 8;
            this.saleReFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleReFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleReFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleReFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleReFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.saleReFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleReFilterBtn.ForeColor = System.Drawing.Color.White;
            this.saleReFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.whitefilter;
            this.saleReFilterBtn.Location = new System.Drawing.Point(1044, 30);
            this.saleReFilterBtn.Name = "saleReFilterBtn";
            this.saleReFilterBtn.Size = new System.Drawing.Size(43, 43);
            this.saleReFilterBtn.TabIndex = 8;
            this.saleReFilterBtn.Click += new System.EventHandler(this.saleReFilterBtn_Click);
            // 
            // saleReSearchText
            // 
            this.saleReSearchText.BorderColor = System.Drawing.Color.Gray;
            this.saleReSearchText.BorderRadius = 8;
            this.saleReSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.saleReSearchText.DefaultText = "";
            this.saleReSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.saleReSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.saleReSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.saleReSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.saleReSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleReSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saleReSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saleReSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleReSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.saleReSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.saleReSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.saleReSearchText.Location = new System.Drawing.Point(17, 30);
            this.saleReSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saleReSearchText.Name = "saleReSearchText";
            this.saleReSearchText.PasswordChar = '\0';
            this.saleReSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.saleReSearchText.PlaceholderText = "Search";
            this.saleReSearchText.SelectedText = "";
            this.saleReSearchText.Size = new System.Drawing.Size(400, 42);
            this.saleReSearchText.TabIndex = 28;
            this.saleReSearchText.TextChanged += new System.EventHandler(this.saleReSearchText_TextChanged);
            // 
            // saleReDataGridView
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saleReDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.saleReDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleReDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.saleReDataGridView.ColumnHeadersHeight = 25;
            this.saleReDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.saleReDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.saleReDataGridView.GridColor = System.Drawing.Color.White;
            this.saleReDataGridView.Location = new System.Drawing.Point(17, 100);
            this.saleReDataGridView.Name = "saleReDataGridView";
            this.saleReDataGridView.RowHeadersVisible = false;
            this.saleReDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.saleReDataGridView.TabIndex = 29;
            this.saleReDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.saleReDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saleReDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.saleReDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.saleReDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.saleReDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.saleReDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.saleReDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.saleReDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.saleReDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.saleReDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.saleReDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.saleReDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.saleReDataGridView.ThemeStyle.ReadOnly = false;
            this.saleReDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.saleReDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.saleReDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.saleReDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.saleReDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.saleReDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.saleReDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleReDataGridView_CellContentClick);
            // 
            // saleReAllPgLabel
            // 
            this.saleReAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saleReAllPgLabel.AutoSize = true;
            this.saleReAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleReAllPgLabel.Location = new System.Drawing.Point(295, 742);
            this.saleReAllPgLabel.Name = "saleReAllPgLabel";
            this.saleReAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.saleReAllPgLabel.TabIndex = 34;
            this.saleReAllPgLabel.Text = "500";
            // 
            // saleReOfLabel
            // 
            this.saleReOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saleReOfLabel.AutoSize = true;
            this.saleReOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleReOfLabel.Location = new System.Drawing.Point(274, 742);
            this.saleReOfLabel.Name = "saleReOfLabel";
            this.saleReOfLabel.Size = new System.Drawing.Size(22, 19);
            this.saleReOfLabel.TabIndex = 33;
            this.saleReOfLabel.Text = "of";
            // 
            // saleRePgRangeLabel
            // 
            this.saleRePgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saleRePgRangeLabel.AutoSize = true;
            this.saleRePgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleRePgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleRePgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.saleRePgRangeLabel.Name = "saleRePgRangeLabel";
            this.saleRePgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.saleRePgRangeLabel.TabIndex = 32;
            this.saleRePgRangeLabel.Text = "0-50";
            // 
            // saleRePageCombo
            // 
            this.saleRePageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saleRePageCombo.BackColor = System.Drawing.Color.Transparent;
            this.saleRePageCombo.BorderColor = System.Drawing.Color.Black;
            this.saleRePageCombo.BorderRadius = 8;
            this.saleRePageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.saleRePageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saleRePageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleRePageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleRePageCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleRePageCombo.ForeColor = System.Drawing.Color.Black;
            this.saleRePageCombo.ItemHeight = 30;
            this.saleRePageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.saleRePageCombo.Location = new System.Drawing.Point(141, 734);
            this.saleRePageCombo.Name = "saleRePageCombo";
            this.saleRePageCombo.Size = new System.Drawing.Size(85, 36);
            this.saleRePageCombo.StartIndex = 0;
            this.saleRePageCombo.TabIndex = 31;
            // 
            // saleReRecordsPerLabel
            // 
            this.saleReRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saleReRecordsPerLabel.AutoSize = true;
            this.saleReRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleReRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.saleReRecordsPerLabel.Name = "saleReRecordsPerLabel";
            this.saleReRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.saleReRecordsPerLabel.TabIndex = 30;
            this.saleReRecordsPerLabel.Text = "Records per page";
            // 
            // saleReBtnPanel
            // 
            this.saleReBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saleReBtnPanel.BorderRadius = 8;
            this.saleReBtnPanel.Controls.Add(this.saleReFirstBtn);
            this.saleReBtnPanel.Controls.Add(this.saleRePrevBtn);
            this.saleReBtnPanel.Controls.Add(this.saleReNextBtn);
            this.saleReBtnPanel.Controls.Add(this.saleReLastBtn);
            this.saleReBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.saleReBtnPanel.Name = "saleReBtnPanel";
            this.saleReBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.saleReBtnPanel.TabIndex = 35;
            // 
            // saleReFirstBtn
            // 
            this.saleReFirstBtn.BorderRadius = 6;
            this.saleReFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleReFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleReFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleReFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleReFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.saleReFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleReFirstBtn.ForeColor = System.Drawing.Color.White;
            this.saleReFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.saleReFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.saleReFirstBtn.Name = "saleReFirstBtn";
            this.saleReFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.saleReFirstBtn.TabIndex = 11;
            this.saleReFirstBtn.Click += new System.EventHandler(this.saleReFirstBtn_Click);
            // 
            // saleRePrevBtn
            // 
            this.saleRePrevBtn.BorderRadius = 6;
            this.saleRePrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleRePrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleRePrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleRePrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleRePrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.saleRePrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleRePrevBtn.ForeColor = System.Drawing.Color.White;
            this.saleRePrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.saleRePrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.saleRePrevBtn.Location = new System.Drawing.Point(45, 8);
            this.saleRePrevBtn.Name = "saleRePrevBtn";
            this.saleRePrevBtn.Size = new System.Drawing.Size(26, 26);
            this.saleRePrevBtn.TabIndex = 11;
            this.saleRePrevBtn.Click += new System.EventHandler(this.saleRePrevBtn_Click);
            // 
            // saleReNextBtn
            // 
            this.saleReNextBtn.BorderRadius = 6;
            this.saleReNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleReNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleReNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleReNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleReNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.saleReNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleReNextBtn.ForeColor = System.Drawing.Color.White;
            this.saleReNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.saleReNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.saleReNextBtn.Location = new System.Drawing.Point(87, 8);
            this.saleReNextBtn.Name = "saleReNextBtn";
            this.saleReNextBtn.Size = new System.Drawing.Size(26, 26);
            this.saleReNextBtn.TabIndex = 9;
            this.saleReNextBtn.Click += new System.EventHandler(this.saleReNextBtn_Click);
            // 
            // saleReLastBtn
            // 
            this.saleReLastBtn.BorderRadius = 6;
            this.saleReLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleReLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleReLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleReLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleReLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.saleReLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleReLastBtn.ForeColor = System.Drawing.Color.White;
            this.saleReLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.saleReLastBtn.Location = new System.Drawing.Point(130, 8);
            this.saleReLastBtn.Name = "saleReLastBtn";
            this.saleReLastBtn.Size = new System.Drawing.Size(26, 26);
            this.saleReLastBtn.TabIndex = 8;
            this.saleReLastBtn.Click += new System.EventHandler(this.saleReLastBtn_Click);
            // 
            // selectSaleReDateTime
            // 
            this.selectSaleReDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectSaleReDateTime.BackColor = System.Drawing.Color.Transparent;
            this.selectSaleReDateTime.BorderColor = System.Drawing.Color.Gray;
            this.selectSaleReDateTime.BorderRadius = 8;
            this.selectSaleReDateTime.BorderThickness = 1;
            this.selectSaleReDateTime.Checked = true;
            this.selectSaleReDateTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectSaleReDateTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSaleReDateTime.ForeColor = System.Drawing.Color.Black;
            this.selectSaleReDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.selectSaleReDateTime.Location = new System.Drawing.Point(1101, 30);
            this.selectSaleReDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.selectSaleReDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.selectSaleReDateTime.Name = "selectSaleReDateTime";
            this.selectSaleReDateTime.Size = new System.Drawing.Size(268, 42);
            this.selectSaleReDateTime.TabIndex = 38;
            this.selectSaleReDateTime.Value = new System.DateTime(2025, 2, 28, 12, 17, 13, 576);
            this.selectSaleReDateTime.ValueChanged += new System.EventHandler(this.selectSaleReDateTime_ValueChanged);
            // 
            // saleReturnRefreshBtn
            // 
            this.saleReturnRefreshBtn.Animated = true;
            this.saleReturnRefreshBtn.BorderRadius = 8;
            this.saleReturnRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleReturnRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleReturnRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleReturnRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleReturnRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.saleReturnRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleReturnRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.saleReturnRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.saleReturnRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.saleReturnRefreshBtn.Location = new System.Drawing.Point(443, 30);
            this.saleReturnRefreshBtn.Name = "saleReturnRefreshBtn";
            this.saleReturnRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.saleReturnRefreshBtn.TabIndex = 39;
            this.saleReturnRefreshBtn.Click += new System.EventHandler(this.saleReturnRefreshBtn_Click);
            // 
            // SaleReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.saleReturnRefreshBtn);
            this.Controls.Add(this.selectSaleReDateTime);
            this.Controls.Add(this.saleReBtnPanel);
            this.Controls.Add(this.saleReAllPgLabel);
            this.Controls.Add(this.saleReOfLabel);
            this.Controls.Add(this.saleRePgRangeLabel);
            this.Controls.Add(this.saleRePageCombo);
            this.Controls.Add(this.saleReRecordsPerLabel);
            this.Controls.Add(this.saleReDataGridView);
            this.Controls.Add(this.saleReSearchText);
            this.Controls.Add(this.saleReFilterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "SaleReturnForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleReturnForm";
            this.Load += new System.EventHandler(this.SaleReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleReDataGridView)).EndInit();
            this.saleReBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleReFilterBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox saleReSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView saleReDataGridView;
        private System.Windows.Forms.Label saleReAllPgLabel;
        private System.Windows.Forms.Label saleReOfLabel;
        private System.Windows.Forms.Label saleRePgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox saleRePageCombo;
        private System.Windows.Forms.Label saleReRecordsPerLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel saleReBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleReFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleRePrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleReNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleReLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker selectSaleReDateTime;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleReturnRefreshBtn;
    }
}