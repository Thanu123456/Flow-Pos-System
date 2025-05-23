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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleReturnForm));
            this.saleReFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleReSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.saleReDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.saleReBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.saleReFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleRePrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleReNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleReLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.selectSaleReDateTime = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.saleReturnRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.filterResonsRefundCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
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
            this.saleReDataGridView.AllowUserToAddRows = false;
            this.saleReDataGridView.AllowUserToDeleteRows = false;
            this.saleReDataGridView.AllowUserToResizeColumns = false;
            this.saleReDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.saleReDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.saleReDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleReDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.saleReDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.saleReDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.saleReDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.saleReDataGridView.Enabled = false;
            this.saleReDataGridView.GridColor = System.Drawing.Color.White;
            this.saleReDataGridView.Location = new System.Drawing.Point(17, 100);
            this.saleReDataGridView.Name = "saleReDataGridView";
            this.saleReDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleReDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.saleReDataGridView.RowHeadersVisible = false;
            this.saleReDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.saleReDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.saleReDataGridView.RowTemplate.Height = 35;
            this.saleReDataGridView.ShowEditingIcon = false;
            this.saleReDataGridView.ShowRowErrors = false;
            this.saleReDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.saleReDataGridView.TabIndex = 29;
            this.saleReDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.saleReDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saleReDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saleReDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.saleReDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.saleReDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.saleReDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.saleReDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.saleReDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.saleReDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.saleReDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.saleReDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.saleReDataGridView.ThemeStyle.ReadOnly = false;
            this.saleReDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.saleReDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.saleReDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.saleReDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.saleReDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.saleReDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.saleReDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleReDataGridView_CellContentClick);
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
            this.selectSaleReDateTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.saleReturnRefreshBtn.Location = new System.Drawing.Point(427, 30);
            this.saleReturnRefreshBtn.Name = "saleReturnRefreshBtn";
            this.saleReturnRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.saleReturnRefreshBtn.TabIndex = 39;
            this.saleReturnRefreshBtn.Click += new System.EventHandler(this.saleReturnRefreshBtn_Click);
            // 
            // filterResonsRefundCombo
            // 
            this.filterResonsRefundCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterResonsRefundCombo.BackColor = System.Drawing.Color.Transparent;
            this.filterResonsRefundCombo.BorderColor = System.Drawing.Color.Gray;
            this.filterResonsRefundCombo.BorderRadius = 8;
            this.filterResonsRefundCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterResonsRefundCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterResonsRefundCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterResonsRefundCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterResonsRefundCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.filterResonsRefundCombo.ForeColor = System.Drawing.Color.DimGray;
            this.filterResonsRefundCombo.ItemHeight = 36;
            this.filterResonsRefundCombo.Location = new System.Drawing.Point(762, 30);
            this.filterResonsRefundCombo.Name = "filterResonsRefundCombo";
            this.filterResonsRefundCombo.Size = new System.Drawing.Size(268, 42);
            this.filterResonsRefundCombo.TabIndex = 103;
            this.filterResonsRefundCombo.SelectedIndexChanged += new System.EventHandler(this.filterResonsRefundCombo_SelectedIndexChanged);
            // 
            // SaleReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.filterResonsRefundCombo);
            this.Controls.Add(this.saleReturnRefreshBtn);
            this.Controls.Add(this.selectSaleReDateTime);
            this.Controls.Add(this.saleReBtnPanel);
            this.Controls.Add(this.saleReDataGridView);
            this.Controls.Add(this.saleReSearchText);
            this.Controls.Add(this.saleReFilterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "SaleReturnForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Returns";
            this.Load += new System.EventHandler(this.SaleReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleReDataGridView)).EndInit();
            this.saleReBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleReFilterBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox saleReSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView saleReDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticonePanel saleReBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleReFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleRePrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleReNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleReLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker selectSaleReDateTime;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleReturnRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridViewStyler siticoneDataGridViewStyler1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox filterResonsRefundCombo;
    }
}