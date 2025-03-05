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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.maximumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.addAdjBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.warehouseLabel = new System.Windows.Forms.Label();
            this.createAdjWareCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.createAdjDate = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.productLabel = new System.Windows.Forms.Label();
            this.adProductSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
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
            this.adjAnimateWindow = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.createAdjPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjOrderDataGrid)).BeginInit();
            this.createAdjPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1000, 34);
            this.headerPanel.TabIndex = 3;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlPanel.Controls.Add(this.minimumBtn);
            this.controlPanel.Controls.Add(this.maximumBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.SystemColors.Control;
            this.controlPanel.Location = new System.Drawing.Point(855, 1);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(142, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // minimumBtn
            // 
            this.minimumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumBtn.BorderRadius = 8;
            this.minimumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimumBtn.FillColor = System.Drawing.Color.Silver;
            this.minimumBtn.IconColor = System.Drawing.Color.White;
            this.minimumBtn.Location = new System.Drawing.Point(4, 3);
            this.minimumBtn.Name = "minimumBtn";
            this.minimumBtn.Size = new System.Drawing.Size(41, 25);
            this.minimumBtn.TabIndex = 2;
            // 
            // maximumBtn
            // 
            this.maximumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximumBtn.BorderRadius = 8;
            this.maximumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maximumBtn.FillColor = System.Drawing.Color.Silver;
            this.maximumBtn.IconColor = System.Drawing.Color.White;
            this.maximumBtn.Location = new System.Drawing.Point(51, 2);
            this.maximumBtn.Name = "maximumBtn";
            this.maximumBtn.Size = new System.Drawing.Size(41, 26);
            this.maximumBtn.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.FillColor = System.Drawing.Color.Silver;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(98, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(41, 26);
            this.closeBtn.TabIndex = 0;
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
            this.warehouseLabel.Location = new System.Drawing.Point(10, 31);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(103, 23);
            this.warehouseLabel.TabIndex = 4;
            this.warehouseLabel.Text = "Warehouse:";
            // 
            // createAdjWareCombo
            // 
            this.createAdjWareCombo.BackColor = System.Drawing.Color.Transparent;
            this.createAdjWareCombo.BorderColor = System.Drawing.Color.Gray;
            this.createAdjWareCombo.BorderRadius = 8;
            this.createAdjWareCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.createAdjWareCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createAdjWareCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createAdjWareCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createAdjWareCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createAdjWareCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.createAdjWareCombo.ItemHeight = 30;
            this.createAdjWareCombo.Items.AddRange(new object[] {
            "Choose Warehouse",
            "Warehouse 1",
            "Warehouse 2"});
            this.createAdjWareCombo.Location = new System.Drawing.Point(13, 64);
            this.createAdjWareCombo.Name = "createAdjWareCombo";
            this.createAdjWareCombo.Size = new System.Drawing.Size(400, 36);
            this.createAdjWareCombo.StartIndex = 0;
            this.createAdjWareCombo.TabIndex = 6;
            this.createAdjWareCombo.SelectedIndexChanged += new System.EventHandler(this.createAdjWareCombo_SelectedIndexChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(516, 27);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(51, 23);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Date:";
            // 
            // createAdjDate
            // 
            this.createAdjDate.BorderColor = System.Drawing.Color.Gray;
            this.createAdjDate.BorderRadius = 8;
            this.createAdjDate.Checked = true;
            this.createAdjDate.FillColor = System.Drawing.Color.PaleGreen;
            this.createAdjDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createAdjDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.createAdjDate.Location = new System.Drawing.Point(520, 64);
            this.createAdjDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.createAdjDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.createAdjDate.Name = "createAdjDate";
            this.createAdjDate.Size = new System.Drawing.Size(400, 42);
            this.createAdjDate.TabIndex = 8;
            this.createAdjDate.Value = new System.DateTime(2025, 2, 26, 20, 24, 46, 676);
            this.createAdjDate.ValueChanged += new System.EventHandler(this.createAdjDate_ValueChanged);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.BackColor = System.Drawing.Color.Transparent;
            this.productLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(9, 132);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(76, 23);
            this.productLabel.TabIndex = 9;
            this.productLabel.Text = "Product:";
            // 
            // adProductSearchText
            // 
            this.adProductSearchText.BorderColor = System.Drawing.Color.Gray;
            this.adProductSearchText.BorderRadius = 8;
            this.adProductSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adProductSearchText.DefaultText = "";
            this.adProductSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adProductSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adProductSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adProductSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adProductSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adProductSearchText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.adProductSearchText.ForeColor = System.Drawing.Color.DimGray;
            this.adProductSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adProductSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.adProductSearchText.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.adProductSearchText.Location = new System.Drawing.Point(12, 168);
            this.adProductSearchText.Name = "adProductSearchText";
            this.adProductSearchText.PasswordChar = '\0';
            this.adProductSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.adProductSearchText.PlaceholderText = "Search Product by Code Name";
            this.adProductSearchText.SelectedText = "";
            this.adProductSearchText.Size = new System.Drawing.Size(830, 42);
            this.adProductSearchText.TabIndex = 10;
            this.adProductSearchText.TextChanged += new System.EventHandler(this.adProductSearchText_TextChanged);
            // 
            // orderItemLabel
            // 
            this.orderItemLabel.AutoSize = true;
            this.orderItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderItemLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItemLabel.Location = new System.Drawing.Point(9, 238);
            this.orderItemLabel.Name = "orderItemLabel";
            this.orderItemLabel.Size = new System.Drawing.Size(109, 23);
            this.orderItemLabel.TabIndex = 11;
            this.orderItemLabel.Text = "Order Items:";
            // 
            // adjOrderDataGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adjOrderDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adjOrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adjOrderDataGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.adjOrderDataGrid.GridColor = System.Drawing.Color.White;
            this.adjOrderDataGrid.Location = new System.Drawing.Point(13, 275);
            this.adjOrderDataGrid.Name = "adjOrderDataGrid";
            this.adjOrderDataGrid.RowHeadersVisible = false;
            this.adjOrderDataGrid.Size = new System.Drawing.Size(915, 273);
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
            this.adjSaveBtn.BorderRadius = 8;
            this.adjSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.adjSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjSaveBtn.ForeColor = System.Drawing.Color.White;
            this.adjSaveBtn.Location = new System.Drawing.Point(758, 760);
            this.adjSaveBtn.Name = "adjSaveBtn";
            this.adjSaveBtn.Size = new System.Drawing.Size(93, 47);
            this.adjSaveBtn.TabIndex = 13;
            this.adjSaveBtn.Text = "Save";
            this.adjSaveBtn.Click += new System.EventHandler(this.adjSaveBtn_Click);
            // 
            // adjCancelBtn
            // 
            this.adjCancelBtn.BorderRadius = 8;
            this.adjCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjCancelBtn.FillColor = System.Drawing.Color.DarkGray;
            this.adjCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.adjCancelBtn.ForeColor = System.Drawing.Color.White;
            this.adjCancelBtn.Location = new System.Drawing.Point(874, 760);
            this.adjCancelBtn.Name = "adjCancelBtn";
            this.adjCancelBtn.Size = new System.Drawing.Size(93, 47);
            this.adjCancelBtn.TabIndex = 14;
            this.adjCancelBtn.Text = "Cancel";
            this.adjCancelBtn.Click += new System.EventHandler(this.adjCancelBtn_Click);
            // 
            // adjAnimateWindow
            // 
            this.adjAnimateWindow.TargetForm = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Create Adjustment";
            // 
            // createAdjPanel
            // 
            this.createAdjPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.createAdjPanel.Location = new System.Drawing.Point(32, 96);
            this.createAdjPanel.Name = "createAdjPanel";
            this.createAdjPanel.Size = new System.Drawing.Size(935, 625);
            this.createAdjPanel.TabIndex = 16;
            this.createAdjPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // AddAdjustments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 840);
            this.Controls.Add(this.createAdjPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adjCancelBtn);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.adjSaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAdjustments";
            this.Text = "AddAdjustments";
            this.Load += new System.EventHandler(this.AddAdjustments_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adjOrderDataGrid)).EndInit();
            this.createAdjPanel.ResumeLayout(false);
            this.createAdjPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox maximumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
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
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow adjAnimateWindow;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel createAdjPanel;
    }
}