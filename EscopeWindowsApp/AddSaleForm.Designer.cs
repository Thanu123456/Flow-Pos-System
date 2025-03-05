namespace EscopeWindowsApp
{
    partial class AddSaleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.createSalePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.createSalePySLabel = new System.Windows.Forms.Label();
            this.createSalePaySCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.saleCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.createSaleNoteLabel = new System.Windows.Forms.Label();
            this.createSaleNoteText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSaleStatusCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.createSaleStatusLabel = new System.Windows.Forms.Label();
            this.createSaleShipText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSaleShiLabel = new System.Windows.Forms.Label();
            this.createSaleDisText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSaleDisLabel = new System.Windows.Forms.Label();
            this.createSaleOderTaxText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSaleOdTaxLabel = new System.Windows.Forms.Label();
            this.saleOrderDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createSaleItemLabel = new System.Windows.Forms.Label();
            this.createSaleSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSaleProdtLabel = new System.Windows.Forms.Label();
            this.createSaleText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSaleCusLabel = new System.Windows.Forms.Label();
            this.createSaleWareCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.CreateSaleWarehouseLabel = new System.Windows.Forms.Label();
            this.createSaleDateTime = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.createSaleDateLabel = new System.Windows.Forms.Label();
            this.createSaleLabel = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.createSalePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // createSalePanel
            // 
            this.createSalePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createSalePanel.BorderRadius = 8;
            this.createSalePanel.Controls.Add(this.totalAmountLabel);
            this.createSalePanel.Controls.Add(this.createSalePySLabel);
            this.createSalePanel.Controls.Add(this.createSalePaySCombo);
            this.createSalePanel.Controls.Add(this.saleCancelBtn);
            this.createSalePanel.Controls.Add(this.saleSaveBtn);
            this.createSalePanel.Controls.Add(this.createSaleNoteLabel);
            this.createSalePanel.Controls.Add(this.createSaleNoteText);
            this.createSalePanel.Controls.Add(this.createSaleStatusCombo);
            this.createSalePanel.Controls.Add(this.createSaleStatusLabel);
            this.createSalePanel.Controls.Add(this.createSaleShipText);
            this.createSalePanel.Controls.Add(this.createSaleShiLabel);
            this.createSalePanel.Controls.Add(this.createSaleDisText);
            this.createSalePanel.Controls.Add(this.createSaleDisLabel);
            this.createSalePanel.Controls.Add(this.createSaleOderTaxText);
            this.createSalePanel.Controls.Add(this.createSaleOdTaxLabel);
            this.createSalePanel.Controls.Add(this.saleOrderDataGrid);
            this.createSalePanel.Controls.Add(this.createSaleItemLabel);
            this.createSalePanel.Controls.Add(this.createSaleSearchText);
            this.createSalePanel.Controls.Add(this.createSaleProdtLabel);
            this.createSalePanel.Controls.Add(this.createSaleText);
            this.createSalePanel.Controls.Add(this.createSaleCusLabel);
            this.createSalePanel.Controls.Add(this.createSaleWareCombo);
            this.createSalePanel.Controls.Add(this.CreateSaleWarehouseLabel);
            this.createSalePanel.Controls.Add(this.createSaleDateTime);
            this.createSalePanel.Controls.Add(this.createSaleDateLabel);
            this.createSalePanel.FillColor = System.Drawing.Color.White;
            this.createSalePanel.Location = new System.Drawing.Point(33, 68);
            this.createSalePanel.Name = "createSalePanel";
            this.createSalePanel.Size = new System.Drawing.Size(933, 1122);
            this.createSalePanel.TabIndex = 18;
            this.createSalePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createSalePanel_Paint);
            // 
            // createSalePySLabel
            // 
            this.createSalePySLabel.AutoSize = true;
            this.createSalePySLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSalePySLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSalePySLabel.Location = new System.Drawing.Point(12, 780);
            this.createSalePySLabel.Name = "createSalePySLabel";
            this.createSalePySLabel.Size = new System.Drawing.Size(135, 23);
            this.createSalePySLabel.TabIndex = 29;
            this.createSalePySLabel.Text = "Payment Status:";
            // 
            // createSalePaySCombo
            // 
            this.createSalePaySCombo.BackColor = System.Drawing.Color.Transparent;
            this.createSalePaySCombo.BorderColor = System.Drawing.Color.Gray;
            this.createSalePaySCombo.BorderRadius = 8;
            this.createSalePaySCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.createSalePaySCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createSalePaySCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSalePaySCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSalePaySCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.createSalePaySCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSalePaySCombo.ItemHeight = 30;
            this.createSalePaySCombo.Items.AddRange(new object[] {
            "Select Payment Status",
            "Paid",
            "Unpaid"});
            this.createSalePaySCombo.Location = new System.Drawing.Point(15, 811);
            this.createSalePaySCombo.Name = "createSalePaySCombo";
            this.createSalePaySCombo.Size = new System.Drawing.Size(400, 36);
            this.createSalePaySCombo.StartIndex = 0;
            this.createSalePaySCombo.TabIndex = 28;
            this.createSalePaySCombo.SelectedIndexChanged += new System.EventHandler(this.createSalePaySCombo_SelectedIndexChanged);
            // 
            // saleCancelBtn
            // 
            this.saleCancelBtn.BorderRadius = 8;
            this.saleCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleCancelBtn.FillColor = System.Drawing.Color.DarkGray;
            this.saleCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.saleCancelBtn.ForeColor = System.Drawing.Color.White;
            this.saleCancelBtn.Location = new System.Drawing.Point(822, 1048);
            this.saleCancelBtn.Name = "saleCancelBtn";
            this.saleCancelBtn.Size = new System.Drawing.Size(93, 47);
            this.saleCancelBtn.TabIndex = 26;
            this.saleCancelBtn.Text = "Cancel";
            this.saleCancelBtn.Click += new System.EventHandler(this.saleCancelBtn_Click);
            // 
            // saleSaveBtn
            // 
            this.saleSaveBtn.BorderRadius = 8;
            this.saleSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.saleSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleSaveBtn.ForeColor = System.Drawing.Color.White;
            this.saleSaveBtn.Location = new System.Drawing.Point(706, 1048);
            this.saleSaveBtn.Name = "saleSaveBtn";
            this.saleSaveBtn.Size = new System.Drawing.Size(93, 47);
            this.saleSaveBtn.TabIndex = 25;
            this.saleSaveBtn.Text = "Save";
            this.saleSaveBtn.Click += new System.EventHandler(this.saleSaveBtn_Click);
            // 
            // createSaleNoteLabel
            // 
            this.createSaleNoteLabel.AutoSize = true;
            this.createSaleNoteLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSaleNoteLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleNoteLabel.Location = new System.Drawing.Point(11, 888);
            this.createSaleNoteLabel.Name = "createSaleNoteLabel";
            this.createSaleNoteLabel.Size = new System.Drawing.Size(52, 23);
            this.createSaleNoteLabel.TabIndex = 24;
            this.createSaleNoteLabel.Text = "Note:";
            // 
            // createSaleNoteText
            // 
            this.createSaleNoteText.BorderColor = System.Drawing.Color.Gray;
            this.createSaleNoteText.BorderRadius = 8;
            this.createSaleNoteText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSaleNoteText.DefaultText = "";
            this.createSaleNoteText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSaleNoteText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSaleNoteText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleNoteText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleNoteText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleNoteText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createSaleNoteText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleNoteText.Location = new System.Drawing.Point(15, 924);
            this.createSaleNoteText.Name = "createSaleNoteText";
            this.createSaleNoteText.PasswordChar = '\0';
            this.createSaleNoteText.PlaceholderText = "";
            this.createSaleNoteText.SelectedText = "";
            this.createSaleNoteText.Size = new System.Drawing.Size(900, 75);
            this.createSaleNoteText.TabIndex = 23;
            this.createSaleNoteText.TextChanged += new System.EventHandler(this.createSaleNoteText_TextChanged);
            // 
            // createSaleStatusCombo
            // 
            this.createSaleStatusCombo.BackColor = System.Drawing.Color.Transparent;
            this.createSaleStatusCombo.BorderColor = System.Drawing.Color.Gray;
            this.createSaleStatusCombo.BorderRadius = 8;
            this.createSaleStatusCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.createSaleStatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createSaleStatusCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleStatusCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleStatusCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.createSaleStatusCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSaleStatusCombo.ItemHeight = 30;
            this.createSaleStatusCombo.Items.AddRange(new object[] {
            "Sent",
            "Pending"});
            this.createSaleStatusCombo.Location = new System.Drawing.Point(516, 704);
            this.createSaleStatusCombo.Name = "createSaleStatusCombo";
            this.createSaleStatusCombo.Size = new System.Drawing.Size(400, 36);
            this.createSaleStatusCombo.StartIndex = 0;
            this.createSaleStatusCombo.TabIndex = 22;
            this.createSaleStatusCombo.SelectedIndexChanged += new System.EventHandler(this.createSaleStatusCombo_SelectedIndexChanged);
            // 
            // createSaleStatusLabel
            // 
            this.createSaleStatusLabel.AutoSize = true;
            this.createSaleStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSaleStatusLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleStatusLabel.Location = new System.Drawing.Point(512, 669);
            this.createSaleStatusLabel.Name = "createSaleStatusLabel";
            this.createSaleStatusLabel.Size = new System.Drawing.Size(63, 23);
            this.createSaleStatusLabel.TabIndex = 21;
            this.createSaleStatusLabel.Text = "Status:";
            // 
            // createSaleShipText
            // 
            this.createSaleShipText.BorderColor = System.Drawing.Color.Gray;
            this.createSaleShipText.BorderRadius = 8;
            this.createSaleShipText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSaleShipText.DefaultText = "";
            this.createSaleShipText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSaleShipText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSaleShipText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleShipText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleShipText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleShipText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createSaleShipText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleShipText.Location = new System.Drawing.Point(16, 704);
            this.createSaleShipText.Name = "createSaleShipText";
            this.createSaleShipText.PasswordChar = '\0';
            this.createSaleShipText.PlaceholderText = "";
            this.createSaleShipText.SelectedText = "";
            this.createSaleShipText.Size = new System.Drawing.Size(400, 42);
            this.createSaleShipText.TabIndex = 20;
            this.createSaleShipText.TextChanged += new System.EventHandler(this.createSaleShipText_TextChanged);
            // 
            // createSaleShiLabel
            // 
            this.createSaleShiLabel.AutoSize = true;
            this.createSaleShiLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSaleShiLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleShiLabel.Location = new System.Drawing.Point(12, 669);
            this.createSaleShiLabel.Name = "createSaleShiLabel";
            this.createSaleShiLabel.Size = new System.Drawing.Size(81, 23);
            this.createSaleShiLabel.TabIndex = 19;
            this.createSaleShiLabel.Text = "Shipping:";
            // 
            // createSaleDisText
            // 
            this.createSaleDisText.BorderColor = System.Drawing.Color.Gray;
            this.createSaleDisText.BorderRadius = 8;
            this.createSaleDisText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSaleDisText.DefaultText = "";
            this.createSaleDisText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSaleDisText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSaleDisText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleDisText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleDisText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleDisText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createSaleDisText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleDisText.Location = new System.Drawing.Point(516, 589);
            this.createSaleDisText.Name = "createSaleDisText";
            this.createSaleDisText.PasswordChar = '\0';
            this.createSaleDisText.PlaceholderText = "";
            this.createSaleDisText.SelectedText = "";
            this.createSaleDisText.Size = new System.Drawing.Size(400, 42);
            this.createSaleDisText.TabIndex = 18;
            this.createSaleDisText.TextChanged += new System.EventHandler(this.createSaleDisText_TextChanged);
            // 
            // createSaleDisLabel
            // 
            this.createSaleDisLabel.AutoSize = true;
            this.createSaleDisLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSaleDisLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleDisLabel.Location = new System.Drawing.Point(511, 553);
            this.createSaleDisLabel.Name = "createSaleDisLabel";
            this.createSaleDisLabel.Size = new System.Drawing.Size(83, 23);
            this.createSaleDisLabel.TabIndex = 17;
            this.createSaleDisLabel.Text = "Discount:";
            // 
            // createSaleOderTaxText
            // 
            this.createSaleOderTaxText.BorderColor = System.Drawing.Color.Gray;
            this.createSaleOderTaxText.BorderRadius = 8;
            this.createSaleOderTaxText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSaleOderTaxText.DefaultText = "";
            this.createSaleOderTaxText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSaleOderTaxText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSaleOderTaxText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleOderTaxText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleOderTaxText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleOderTaxText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createSaleOderTaxText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleOderTaxText.Location = new System.Drawing.Point(16, 589);
            this.createSaleOderTaxText.Name = "createSaleOderTaxText";
            this.createSaleOderTaxText.PasswordChar = '\0';
            this.createSaleOderTaxText.PlaceholderText = "";
            this.createSaleOderTaxText.SelectedText = "";
            this.createSaleOderTaxText.Size = new System.Drawing.Size(400, 42);
            this.createSaleOderTaxText.TabIndex = 16;
            this.createSaleOderTaxText.TextChanged += new System.EventHandler(this.createSaleOderTaxText_TextChanged);
            // 
            // createSaleOdTaxLabel
            // 
            this.createSaleOdTaxLabel.AutoSize = true;
            this.createSaleOdTaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSaleOdTaxLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleOdTaxLabel.Location = new System.Drawing.Point(12, 553);
            this.createSaleOdTaxLabel.Name = "createSaleOdTaxLabel";
            this.createSaleOdTaxLabel.Size = new System.Drawing.Size(90, 23);
            this.createSaleOdTaxLabel.TabIndex = 15;
            this.createSaleOdTaxLabel.Text = "Order Tax:";
            // 
            // saleOrderDataGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saleOrderDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleOrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.saleOrderDataGrid.ColumnHeadersHeight = 25;
            this.saleOrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.saleOrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierID,
            this.supName,
            this.supDesc,
            this.supEmail,
            this.supPhone,
            this.createdAt,
            this.action});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.saleOrderDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.saleOrderDataGrid.GridColor = System.Drawing.Color.White;
            this.saleOrderDataGrid.Location = new System.Drawing.Point(16, 315);
            this.saleOrderDataGrid.Name = "saleOrderDataGrid";
            this.saleOrderDataGrid.RowHeadersVisible = false;
            this.saleOrderDataGrid.Size = new System.Drawing.Size(899, 208);
            this.saleOrderDataGrid.TabIndex = 14;
            this.saleOrderDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.saleOrderDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saleOrderDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.saleOrderDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.saleOrderDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.saleOrderDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.saleOrderDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.saleOrderDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.saleOrderDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.saleOrderDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.saleOrderDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleOrderDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.saleOrderDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.saleOrderDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.saleOrderDataGrid.ThemeStyle.ReadOnly = false;
            this.saleOrderDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.saleOrderDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.saleOrderDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleOrderDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.saleOrderDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.saleOrderDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.saleOrderDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.saleOrderDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleOrderDataGrid_CellContentClick);
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
            // createSaleItemLabel
            // 
            this.createSaleItemLabel.AutoSize = true;
            this.createSaleItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSaleItemLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleItemLabel.Location = new System.Drawing.Point(12, 277);
            this.createSaleItemLabel.Name = "createSaleItemLabel";
            this.createSaleItemLabel.Size = new System.Drawing.Size(109, 23);
            this.createSaleItemLabel.TabIndex = 13;
            this.createSaleItemLabel.Text = "Order Items:";
            // 
            // createSaleSearchText
            // 
            this.createSaleSearchText.BorderColor = System.Drawing.Color.Gray;
            this.createSaleSearchText.BorderRadius = 8;
            this.createSaleSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSaleSearchText.DefaultText = "";
            this.createSaleSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSaleSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSaleSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleSearchText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createSaleSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.createSaleSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.createSaleSearchText.Location = new System.Drawing.Point(516, 192);
            this.createSaleSearchText.Name = "createSaleSearchText";
            this.createSaleSearchText.PasswordChar = '\0';
            this.createSaleSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSaleSearchText.PlaceholderText = "Search Product By Code Name";
            this.createSaleSearchText.SelectedText = "";
            this.createSaleSearchText.Size = new System.Drawing.Size(400, 42);
            this.createSaleSearchText.TabIndex = 12;
            this.createSaleSearchText.TextChanged += new System.EventHandler(this.createSaleSearchText_TextChanged);
            // 
            // createSaleProdtLabel
            // 
            this.createSaleProdtLabel.AutoSize = true;
            this.createSaleProdtLabel.BackColor = System.Drawing.Color.White;
            this.createSaleProdtLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleProdtLabel.Location = new System.Drawing.Point(512, 151);
            this.createSaleProdtLabel.Name = "createSaleProdtLabel";
            this.createSaleProdtLabel.Size = new System.Drawing.Size(76, 23);
            this.createSaleProdtLabel.TabIndex = 11;
            this.createSaleProdtLabel.Text = "Product:";
            // 
            // createSaleText
            // 
            this.createSaleText.BorderColor = System.Drawing.Color.Gray;
            this.createSaleText.BorderRadius = 8;
            this.createSaleText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSaleText.DefaultText = "";
            this.createSaleText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSaleText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSaleText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createSaleText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleText.Location = new System.Drawing.Point(16, 192);
            this.createSaleText.Name = "createSaleText";
            this.createSaleText.PasswordChar = '\0';
            this.createSaleText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSaleText.PlaceholderText = "Enter Customer Name";
            this.createSaleText.SelectedText = "";
            this.createSaleText.Size = new System.Drawing.Size(400, 42);
            this.createSaleText.TabIndex = 10;
            this.createSaleText.TextChanged += new System.EventHandler(this.createSaleText_TextChanged);
            // 
            // createSaleCusLabel
            // 
            this.createSaleCusLabel.AutoSize = true;
            this.createSaleCusLabel.BackColor = System.Drawing.Color.White;
            this.createSaleCusLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleCusLabel.Location = new System.Drawing.Point(12, 151);
            this.createSaleCusLabel.Name = "createSaleCusLabel";
            this.createSaleCusLabel.Size = new System.Drawing.Size(90, 23);
            this.createSaleCusLabel.TabIndex = 9;
            this.createSaleCusLabel.Text = "Customer:";
            // 
            // createSaleWareCombo
            // 
            this.createSaleWareCombo.BackColor = System.Drawing.Color.Transparent;
            this.createSaleWareCombo.BorderColor = System.Drawing.Color.Gray;
            this.createSaleWareCombo.BorderRadius = 8;
            this.createSaleWareCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.createSaleWareCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createSaleWareCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleWareCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleWareCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createSaleWareCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.createSaleWareCombo.ItemHeight = 30;
            this.createSaleWareCombo.Items.AddRange(new object[] {
            "Choose Warehouse",
            "Warehouse 1",
            "Warehouse 2"});
            this.createSaleWareCombo.Location = new System.Drawing.Point(515, 67);
            this.createSaleWareCombo.Name = "createSaleWareCombo";
            this.createSaleWareCombo.Size = new System.Drawing.Size(400, 36);
            this.createSaleWareCombo.StartIndex = 0;
            this.createSaleWareCombo.TabIndex = 8;
            this.createSaleWareCombo.SelectedIndexChanged += new System.EventHandler(this.createSaleWareCombo_SelectedIndexChanged);
            // 
            // CreateSaleWarehouseLabel
            // 
            this.CreateSaleWarehouseLabel.AutoSize = true;
            this.CreateSaleWarehouseLabel.BackColor = System.Drawing.Color.White;
            this.CreateSaleWarehouseLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateSaleWarehouseLabel.Location = new System.Drawing.Point(512, 34);
            this.CreateSaleWarehouseLabel.Name = "CreateSaleWarehouseLabel";
            this.CreateSaleWarehouseLabel.Size = new System.Drawing.Size(103, 23);
            this.CreateSaleWarehouseLabel.TabIndex = 7;
            this.CreateSaleWarehouseLabel.Text = "Warehouse:";
            // 
            // createSaleDateTime
            // 
            this.createSaleDateTime.BorderRadius = 8;
            this.createSaleDateTime.Checked = true;
            this.createSaleDateTime.FillColor = System.Drawing.Color.LightGreen;
            this.createSaleDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createSaleDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.createSaleDateTime.Location = new System.Drawing.Point(16, 67);
            this.createSaleDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.createSaleDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.createSaleDateTime.Name = "createSaleDateTime";
            this.createSaleDateTime.Size = new System.Drawing.Size(400, 42);
            this.createSaleDateTime.TabIndex = 6;
            this.createSaleDateTime.Value = new System.DateTime(2025, 2, 28, 12, 17, 13, 576);
            this.createSaleDateTime.ValueChanged += new System.EventHandler(this.createSaleDateTime_ValueChanged);
            // 
            // createSaleDateLabel
            // 
            this.createSaleDateLabel.AutoSize = true;
            this.createSaleDateLabel.BackColor = System.Drawing.Color.White;
            this.createSaleDateLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleDateLabel.Location = new System.Drawing.Point(12, 30);
            this.createSaleDateLabel.Name = "createSaleDateLabel";
            this.createSaleDateLabel.Size = new System.Drawing.Size(51, 23);
            this.createSaleDateLabel.TabIndex = 5;
            this.createSaleDateLabel.Text = "Date:";
            // 
            // createSaleLabel
            // 
            this.createSaleLabel.AutoSize = true;
            this.createSaleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleLabel.Location = new System.Drawing.Point(28, 9);
            this.createSaleLabel.Name = "createSaleLabel";
            this.createSaleLabel.Size = new System.Drawing.Size(148, 28);
            this.createSaleLabel.TabIndex = 19;
            this.createSaleLabel.Text = "Create Sale";
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Location = new System.Drawing.Point(612, 839);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(76, 13);
            this.totalAmountLabel.TabIndex = 30;
            this.totalAmountLabel.Text = "Totale Amount";
            // 
            // AddSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1202);
            this.Controls.Add(this.createSaleLabel);
            this.Controls.Add(this.createSalePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSaleForm";
            this.Text = "AddSaleForm";
            this.Load += new System.EventHandler(this.AddSaleForm_Load);
            this.createSalePanel.ResumeLayout(false);
            this.createSalePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel createSalePanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleSaveBtn;
        private System.Windows.Forms.Label createSaleNoteLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createSaleNoteText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox createSaleStatusCombo;
        private System.Windows.Forms.Label createSaleStatusLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createSaleShipText;
        private System.Windows.Forms.Label createSaleShiLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createSaleDisText;
        private System.Windows.Forms.Label createSaleDisLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createSaleOderTaxText;
        private System.Windows.Forms.Label createSaleOdTaxLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView saleOrderDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn supEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn supPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.Label createSaleItemLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createSaleSearchText;
        private System.Windows.Forms.Label createSaleProdtLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createSaleText;
        private System.Windows.Forms.Label createSaleCusLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox createSaleWareCombo;
        private System.Windows.Forms.Label CreateSaleWarehouseLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker createSaleDateTime;
        private System.Windows.Forms.Label createSaleDateLabel;
        private System.Windows.Forms.Label createSaleLabel;
        private System.Windows.Forms.Label createSalePySLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox createSalePaySCombo;
        private System.Windows.Forms.Label totalAmountLabel;
    }
}