namespace EscopeWindowsApp
{
    partial class AddAdjustments
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addAdjBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.warehouseLabel = new System.Windows.Forms.Label();
            this.createAdjWareCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.createAdjDate = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.productLabel = new System.Windows.Forms.Label();
            this.orderItemLabel = new System.Windows.Forms.Label();
            this.adjOrderDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adjSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.adjCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.addAdjustLabel = new System.Windows.Forms.Label();
            this.createAdjPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.adProductSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.adjAnimateWindow = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adjOrderDataGrid)).BeginInit();
            this.createAdjPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addAdjBorderlessForm
            // 
            this.addAdjBorderlessForm.BorderRadius = 25;
            this.addAdjBorderlessForm.ContainerControl = this;
            this.addAdjBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.addAdjBorderlessForm.TransparentWhileDrag = true;
            // 
            // warehouseLabel
            // 
            this.warehouseLabel.AutoSize = true;
            this.warehouseLabel.BackColor = System.Drawing.Color.White;
            this.warehouseLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseLabel.Location = new System.Drawing.Point(15, 27);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(103, 23);
            this.warehouseLabel.TabIndex = 4;
            this.warehouseLabel.Text = "Warehouse:";
            // 
            // createAdjWareCombo
            // 
            this.createAdjWareCombo.BackColor = System.Drawing.Color.Transparent;
            this.createAdjWareCombo.BorderColor = System.Drawing.Color.Silver;
            this.createAdjWareCombo.BorderRadius = 8;
            this.createAdjWareCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.createAdjWareCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createAdjWareCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createAdjWareCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createAdjWareCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createAdjWareCombo.ForeColor = System.Drawing.Color.Gray;
            this.createAdjWareCombo.ItemHeight = 30;
            this.createAdjWareCombo.Items.AddRange(new object[] {
            "Choose Warehouse",
            "Warehouse 1",
            "Warehouse 2"});
            this.createAdjWareCombo.Location = new System.Drawing.Point(19, 58);
            this.createAdjWareCombo.Name = "createAdjWareCombo";
            this.createAdjWareCombo.Size = new System.Drawing.Size(443, 36);
            this.createAdjWareCombo.StartIndex = 0;
            this.createAdjWareCombo.TabIndex = 6;
            this.createAdjWareCombo.TextOffset = new System.Drawing.Point(3, 0);
            this.createAdjWareCombo.SelectedIndexChanged += new System.EventHandler(this.createAdjWareCombo_SelectedIndexChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(490, 27);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(51, 23);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Date:";
            // 
            // createAdjDate
            // 
            this.createAdjDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createAdjDate.BackColor = System.Drawing.Color.Transparent;
            this.createAdjDate.BorderColor = System.Drawing.Color.Gray;
            this.createAdjDate.BorderRadius = 8;
            this.createAdjDate.Checked = true;
            this.createAdjDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.createAdjDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createAdjDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.createAdjDate.Location = new System.Drawing.Point(494, 58);
            this.createAdjDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.createAdjDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.createAdjDate.Name = "createAdjDate";
            this.createAdjDate.Size = new System.Drawing.Size(443, 36);
            this.createAdjDate.TabIndex = 8;
            this.createAdjDate.Value = new System.DateTime(2025, 2, 26, 20, 24, 46, 676);
            this.createAdjDate.ValueChanged += new System.EventHandler(this.createAdjDate_ValueChanged);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.BackColor = System.Drawing.Color.Transparent;
            this.productLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(15, 114);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(76, 23);
            this.productLabel.TabIndex = 9;
            this.productLabel.Text = "Product:";
            // 
            // orderItemLabel
            // 
            this.orderItemLabel.AutoSize = true;
            this.orderItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderItemLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItemLabel.Location = new System.Drawing.Point(15, 218);
            this.orderItemLabel.Name = "orderItemLabel";
            this.orderItemLabel.Size = new System.Drawing.Size(109, 23);
            this.orderItemLabel.TabIndex = 11;
            this.orderItemLabel.Text = "Order Items:";
            // 
            // adjOrderDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adjOrderDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.adjOrderDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adjOrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.adjOrderDataGrid.ColumnHeadersHeight = 25;
            this.adjOrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.adjOrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.adjOrderDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.adjOrderDataGrid.GridColor = System.Drawing.Color.White;
            this.adjOrderDataGrid.Location = new System.Drawing.Point(19, 254);
            this.adjOrderDataGrid.Name = "adjOrderDataGrid";
            this.adjOrderDataGrid.RowHeadersVisible = false;
            this.adjOrderDataGrid.Size = new System.Drawing.Size(918, 266);
            this.adjOrderDataGrid.TabIndex = 12;
            this.adjOrderDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.adjOrderDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adjOrderDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.adjOrderDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.adjOrderDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.adjOrderDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.adjOrderDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.adjOrderDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.adjOrderDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.adjOrderDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.adjOrderDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjOrderDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.adjOrderDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.adjOrderDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.adjOrderDataGrid.ThemeStyle.ReadOnly = false;
            this.adjOrderDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.adjOrderDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.adjOrderDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjOrderDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.adjOrderDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.adjOrderDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.adjOrderDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.adjOrderDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adjOrderDataGrid_CellContentClick);
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
            // adjSaveBtn
            // 
            this.adjSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adjSaveBtn.Animated = true;
            this.adjSaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.adjSaveBtn.BorderRadius = 8;
            this.adjSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.adjSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjSaveBtn.ForeColor = System.Drawing.Color.White;
            this.adjSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.adjSaveBtn.Location = new System.Drawing.Point(778, 655);
            this.adjSaveBtn.Name = "adjSaveBtn";
            this.adjSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.adjSaveBtn.TabIndex = 13;
            this.adjSaveBtn.Text = "Save";
            this.adjSaveBtn.Click += new System.EventHandler(this.adjSaveBtn_Click);
            // 
            // adjCancelBtn
            // 
            this.adjCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adjCancelBtn.Animated = true;
            this.adjCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.adjCancelBtn.BorderRadius = 8;
            this.adjCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adjCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.adjCancelBtn.ForeColor = System.Drawing.Color.White;
            this.adjCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.adjCancelBtn.Location = new System.Drawing.Point(884, 655);
            this.adjCancelBtn.Name = "adjCancelBtn";
            this.adjCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.adjCancelBtn.TabIndex = 14;
            this.adjCancelBtn.Text = "Cancel";
            this.adjCancelBtn.Click += new System.EventHandler(this.adjCancelBtn_Click);
            // 
            // addAdjustLabel
            // 
            this.addAdjustLabel.AutoSize = true;
            this.addAdjustLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdjustLabel.Location = new System.Drawing.Point(18, 50);
            this.addAdjustLabel.Name = "addAdjustLabel";
            this.addAdjustLabel.Size = new System.Drawing.Size(228, 28);
            this.addAdjustLabel.TabIndex = 15;
            this.addAdjustLabel.Text = "Create Adjustment";
            // 
            // createAdjPanel
            // 
            this.createAdjPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createAdjPanel.BorderRadius = 8;
            this.createAdjPanel.Controls.Add(this.createAdjWareCombo);
            this.createAdjPanel.Controls.Add(this.warehouseLabel);
            this.createAdjPanel.Controls.Add(this.dateLabel);
            this.createAdjPanel.Controls.Add(this.createAdjDate);
            this.createAdjPanel.Controls.Add(this.adjOrderDataGrid);
            this.createAdjPanel.Controls.Add(this.productLabel);
            this.createAdjPanel.Controls.Add(this.orderItemLabel);
            this.createAdjPanel.Controls.Add(this.adProductSearchText);
            this.createAdjPanel.FillColor = System.Drawing.Color.White;
            this.createAdjPanel.Location = new System.Drawing.Point(23, 96);
            this.createAdjPanel.Name = "createAdjPanel";
            this.createAdjPanel.Size = new System.Drawing.Size(956, 542);
            this.createAdjPanel.TabIndex = 16;
            this.createAdjPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // adProductSearchText
            // 
            this.adProductSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adProductSearchText.BackColor = System.Drawing.Color.Transparent;
            this.adProductSearchText.BorderColor = System.Drawing.Color.Silver;
            this.adProductSearchText.BorderRadius = 8;
            this.adProductSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adProductSearchText.DefaultText = "";
            this.adProductSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adProductSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adProductSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adProductSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adProductSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adProductSearchText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.adProductSearchText.ForeColor = System.Drawing.Color.Gray;
            this.adProductSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adProductSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.adProductSearchText.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.adProductSearchText.Location = new System.Drawing.Point(19, 150);
            this.adProductSearchText.Name = "adProductSearchText";
            this.adProductSearchText.PasswordChar = '\0';
            this.adProductSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.adProductSearchText.PlaceholderText = "Search Product by Code Name";
            this.adProductSearchText.SelectedText = "";
            this.adProductSearchText.Size = new System.Drawing.Size(918, 42);
            this.adProductSearchText.TabIndex = 10;
            this.adProductSearchText.TextOffset = new System.Drawing.Point(10, 0);
            this.adProductSearchText.TextChanged += new System.EventHandler(this.adProductSearchText_TextChanged);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1000, 34);
            this.headerPanel.TabIndex = 25;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.minimumBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(908, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(92, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // minimumBtn
            // 
            this.minimumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumBtn.BorderRadius = 8;
            this.minimumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimumBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minimumBtn.IconColor = System.Drawing.Color.White;
            this.minimumBtn.Location = new System.Drawing.Point(13, 2);
            this.minimumBtn.Name = "minimumBtn";
            this.minimumBtn.Size = new System.Drawing.Size(26, 26);
            this.minimumBtn.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(45, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 26);
            this.closeBtn.TabIndex = 0;
            // 
            // adjAnimateWindow
            // 
            this.adjAnimateWindow.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.adjAnimateWindow.Interval = 50;
            this.adjAnimateWindow.TargetForm = this;
            // 
            // AddAdjustments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.createAdjPanel);
            this.Controls.Add(this.addAdjustLabel);
            this.Controls.Add(this.adjCancelBtn);
            this.Controls.Add(this.adjSaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 15);
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 710);
            this.Name = "AddAdjustments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAdjustments";
            this.Load += new System.EventHandler(this.AddAdjustments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adjOrderDataGrid)).EndInit();
            this.createAdjPanel.ResumeLayout(false);
            this.createAdjPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm addAdjBorderlessForm;
        private System.Windows.Forms.Label warehouseLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox createAdjWareCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker createAdjDate;
        private System.Windows.Forms.Label dateLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox adProductSearchText;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label orderItemLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton adjSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView adjOrderDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn supEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn supPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private Siticone.Desktop.UI.WinForms.SiticoneButton adjCancelBtn;
        private System.Windows.Forms.Label addAdjustLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel createAdjPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow adjAnimateWindow;
    }
}