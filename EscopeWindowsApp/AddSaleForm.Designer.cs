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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.createSalePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.addSaleTotAmoLabel = new System.Windows.Forms.Label();
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
            this.addSaleBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.addSaleTotAmoPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.addSaleShipCalLabel = new System.Windows.Forms.Label();
            this.addSaleOrdTaxCalLabel = new System.Windows.Forms.Label();
            this.addSaleDisCalLabel = new System.Windows.Forms.Label();
            this.addSaleDisCostLabel = new System.Windows.Forms.Label();
            this.addSaleOrdTaxCostLabel = new System.Windows.Forms.Label();
            this.addSaleShipCostLabel = new System.Windows.Forms.Label();
            this.addSaleTotalAmoCostLabel = new System.Windows.Forms.Label();
            this.createSalePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDataGrid)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.addSaleTotAmoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createSalePanel
            // 
            this.createSalePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createSalePanel.BorderRadius = 8;
            this.createSalePanel.Controls.Add(this.addSaleTotAmoPanel);
            this.createSalePanel.Controls.Add(this.createSalePySLabel);
            this.createSalePanel.Controls.Add(this.createSalePaySCombo);
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
            this.createSalePanel.Location = new System.Drawing.Point(23, 94);
            this.createSalePanel.Name = "createSalePanel";
            this.createSalePanel.Size = new System.Drawing.Size(956, 617);
            this.createSalePanel.TabIndex = 18;
            this.createSalePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createSalePanel_Paint);
            // 
            // addSaleTotAmoLabel
            // 
            this.addSaleTotAmoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSaleTotAmoLabel.AutoSize = true;
            this.addSaleTotAmoLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSaleTotAmoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addSaleTotAmoLabel.Location = new System.Drawing.Point(15, 121);
            this.addSaleTotAmoLabel.Name = "addSaleTotAmoLabel";
            this.addSaleTotAmoLabel.Size = new System.Drawing.Size(121, 23);
            this.addSaleTotAmoLabel.TabIndex = 30;
            this.addSaleTotAmoLabel.Text = "Totale Amount";
            this.addSaleTotAmoLabel.Click += new System.EventHandler(this.totalAmountLabel_Click);
            // 
            // createSalePySLabel
            // 
            this.createSalePySLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createSalePySLabel.AutoSize = true;
            this.createSalePySLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSalePySLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSalePySLabel.Location = new System.Drawing.Point(15, 448);
            this.createSalePySLabel.Name = "createSalePySLabel";
            this.createSalePySLabel.Size = new System.Drawing.Size(135, 23);
            this.createSalePySLabel.TabIndex = 29;
            this.createSalePySLabel.Text = "Payment Status:";
            // 
            // createSalePaySCombo
            // 
            this.createSalePaySCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createSalePaySCombo.BackColor = System.Drawing.Color.Transparent;
            this.createSalePaySCombo.BorderColor = System.Drawing.Color.Gray;
            this.createSalePaySCombo.BorderRadius = 8;
            this.createSalePaySCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.createSalePaySCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createSalePaySCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSalePaySCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSalePaySCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSalePaySCombo.ForeColor = System.Drawing.Color.Gray;
            this.createSalePaySCombo.ItemHeight = 30;
            this.createSalePaySCombo.Items.AddRange(new object[] {
            "Select Payment Status",
            "Paid",
            "Unpaid"});
            this.createSalePaySCombo.Location = new System.Drawing.Point(19, 479);
            this.createSalePaySCombo.Name = "createSalePaySCombo";
            this.createSalePaySCombo.Size = new System.Drawing.Size(213, 36);
            this.createSalePaySCombo.StartIndex = 0;
            this.createSalePaySCombo.TabIndex = 28;
            this.createSalePaySCombo.SelectedIndexChanged += new System.EventHandler(this.createSalePaySCombo_SelectedIndexChanged);
            // 
            // saleCancelBtn
            // 
            this.saleCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saleCancelBtn.Animated = true;
            this.saleCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.saleCancelBtn.BorderRadius = 8;
            this.saleCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saleCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.saleCancelBtn.ForeColor = System.Drawing.Color.White;
            this.saleCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.saleCancelBtn.Location = new System.Drawing.Point(884, 725);
            this.saleCancelBtn.Name = "saleCancelBtn";
            this.saleCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.saleCancelBtn.TabIndex = 26;
            this.saleCancelBtn.Text = "Cancel";
            this.saleCancelBtn.Click += new System.EventHandler(this.saleCancelBtn_Click);
            // 
            // saleSaveBtn
            // 
            this.saleSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saleSaveBtn.Animated = true;
            this.saleSaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saleSaveBtn.BorderRadius = 8;
            this.saleSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.saleSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleSaveBtn.ForeColor = System.Drawing.Color.White;
            this.saleSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.saleSaveBtn.Location = new System.Drawing.Point(779, 725);
            this.saleSaveBtn.Name = "saleSaveBtn";
            this.saleSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.saleSaveBtn.TabIndex = 25;
            this.saleSaveBtn.Text = "Save";
            this.saleSaveBtn.Click += new System.EventHandler(this.saleSaveBtn_Click);
            // 
            // createSaleNoteLabel
            // 
            this.createSaleNoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createSaleNoteLabel.AutoSize = true;
            this.createSaleNoteLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSaleNoteLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleNoteLabel.Location = new System.Drawing.Point(248, 530);
            this.createSaleNoteLabel.Name = "createSaleNoteLabel";
            this.createSaleNoteLabel.Size = new System.Drawing.Size(52, 23);
            this.createSaleNoteLabel.TabIndex = 24;
            this.createSaleNoteLabel.Text = "Note:";
            // 
            // createSaleNoteText
            // 
            this.createSaleNoteText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createSaleNoteText.BackColor = System.Drawing.Color.Transparent;
            this.createSaleNoteText.BorderColor = System.Drawing.Color.Gray;
            this.createSaleNoteText.BorderRadius = 8;
            this.createSaleNoteText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSaleNoteText.DefaultText = "";
            this.createSaleNoteText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSaleNoteText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSaleNoteText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleNoteText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleNoteText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleNoteText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.createSaleNoteText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSaleNoteText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleNoteText.Location = new System.Drawing.Point(252, 557);
            this.createSaleNoteText.Name = "createSaleNoteText";
            this.createSaleNoteText.PasswordChar = '\0';
            this.createSaleNoteText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSaleNoteText.PlaceholderText = "Note";
            this.createSaleNoteText.SelectedText = "";
            this.createSaleNoteText.Size = new System.Drawing.Size(683, 42);
            this.createSaleNoteText.TabIndex = 23;
            this.createSaleNoteText.TextChanged += new System.EventHandler(this.createSaleNoteText_TextChanged);
            // 
            // createSaleStatusCombo
            // 
            this.createSaleStatusCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createSaleStatusCombo.BackColor = System.Drawing.Color.Transparent;
            this.createSaleStatusCombo.BorderColor = System.Drawing.Color.Gray;
            this.createSaleStatusCombo.BorderRadius = 8;
            this.createSaleStatusCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.createSaleStatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createSaleStatusCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleStatusCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleStatusCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleStatusCombo.ForeColor = System.Drawing.Color.Gray;
            this.createSaleStatusCombo.ItemHeight = 30;
            this.createSaleStatusCombo.Items.AddRange(new object[] {
            "Sent",
            "Pending"});
            this.createSaleStatusCombo.Location = new System.Drawing.Point(252, 479);
            this.createSaleStatusCombo.Name = "createSaleStatusCombo";
            this.createSaleStatusCombo.Size = new System.Drawing.Size(213, 36);
            this.createSaleStatusCombo.StartIndex = 0;
            this.createSaleStatusCombo.TabIndex = 22;
            this.createSaleStatusCombo.SelectedIndexChanged += new System.EventHandler(this.createSaleStatusCombo_SelectedIndexChanged);
            // 
            // createSaleStatusLabel
            // 
            this.createSaleStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createSaleStatusLabel.AutoSize = true;
            this.createSaleStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSaleStatusLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleStatusLabel.Location = new System.Drawing.Point(248, 448);
            this.createSaleStatusLabel.Name = "createSaleStatusLabel";
            this.createSaleStatusLabel.Size = new System.Drawing.Size(63, 23);
            this.createSaleStatusLabel.TabIndex = 21;
            this.createSaleStatusLabel.Text = "Status:";
            // 
            // createSaleShipText
            // 
            this.createSaleShipText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createSaleShipText.BackColor = System.Drawing.Color.Transparent;
            this.createSaleShipText.BorderColor = System.Drawing.Color.Gray;
            this.createSaleShipText.BorderRadius = 8;
            this.createSaleShipText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSaleShipText.DefaultText = "";
            this.createSaleShipText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSaleShipText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSaleShipText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleShipText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleShipText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleShipText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleShipText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSaleShipText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleShipText.Location = new System.Drawing.Point(19, 392);
            this.createSaleShipText.Name = "createSaleShipText";
            this.createSaleShipText.PasswordChar = '\0';
            this.createSaleShipText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSaleShipText.PlaceholderText = "Shipping Cost";
            this.createSaleShipText.SelectedText = "";
            this.createSaleShipText.Size = new System.Drawing.Size(213, 42);
            this.createSaleShipText.TabIndex = 20;
            this.createSaleShipText.TextChanged += new System.EventHandler(this.createSaleShipText_TextChanged);
            // 
            // createSaleShiLabel
            // 
            this.createSaleShiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createSaleShiLabel.AutoSize = true;
            this.createSaleShiLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSaleShiLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleShiLabel.Location = new System.Drawing.Point(15, 361);
            this.createSaleShiLabel.Name = "createSaleShiLabel";
            this.createSaleShiLabel.Size = new System.Drawing.Size(107, 23);
            this.createSaleShiLabel.TabIndex = 19;
            this.createSaleShiLabel.Text = "Shipping ($):";
            // 
            // createSaleDisText
            // 
            this.createSaleDisText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createSaleDisText.BackColor = System.Drawing.Color.Transparent;
            this.createSaleDisText.BorderColor = System.Drawing.Color.Gray;
            this.createSaleDisText.BorderRadius = 8;
            this.createSaleDisText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSaleDisText.DefaultText = "";
            this.createSaleDisText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSaleDisText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSaleDisText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleDisText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleDisText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleDisText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleDisText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSaleDisText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleDisText.Location = new System.Drawing.Point(19, 557);
            this.createSaleDisText.Name = "createSaleDisText";
            this.createSaleDisText.PasswordChar = '\0';
            this.createSaleDisText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSaleDisText.PlaceholderText = "Discount";
            this.createSaleDisText.SelectedText = "";
            this.createSaleDisText.Size = new System.Drawing.Size(213, 42);
            this.createSaleDisText.TabIndex = 18;
            this.createSaleDisText.TextChanged += new System.EventHandler(this.createSaleDisText_TextChanged);
            // 
            // createSaleDisLabel
            // 
            this.createSaleDisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createSaleDisLabel.AutoSize = true;
            this.createSaleDisLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSaleDisLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleDisLabel.Location = new System.Drawing.Point(15, 530);
            this.createSaleDisLabel.Name = "createSaleDisLabel";
            this.createSaleDisLabel.Size = new System.Drawing.Size(109, 23);
            this.createSaleDisLabel.TabIndex = 17;
            this.createSaleDisLabel.Text = "Discount ($):";
            // 
            // createSaleOderTaxText
            // 
            this.createSaleOderTaxText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createSaleOderTaxText.BackColor = System.Drawing.Color.Transparent;
            this.createSaleOderTaxText.BorderColor = System.Drawing.Color.Gray;
            this.createSaleOderTaxText.BorderRadius = 8;
            this.createSaleOderTaxText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSaleOderTaxText.DefaultText = "";
            this.createSaleOderTaxText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSaleOderTaxText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSaleOderTaxText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleOderTaxText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleOderTaxText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleOderTaxText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleOderTaxText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleOderTaxText.Location = new System.Drawing.Point(252, 392);
            this.createSaleOderTaxText.Name = "createSaleOderTaxText";
            this.createSaleOderTaxText.PasswordChar = '\0';
            this.createSaleOderTaxText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSaleOderTaxText.PlaceholderText = "Tax";
            this.createSaleOderTaxText.SelectedText = "";
            this.createSaleOderTaxText.Size = new System.Drawing.Size(213, 42);
            this.createSaleOderTaxText.TabIndex = 16;
            this.createSaleOderTaxText.TextChanged += new System.EventHandler(this.createSaleOderTaxText_TextChanged);
            // 
            // createSaleOdTaxLabel
            // 
            this.createSaleOdTaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createSaleOdTaxLabel.AutoSize = true;
            this.createSaleOdTaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSaleOdTaxLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleOdTaxLabel.Location = new System.Drawing.Point(248, 361);
            this.createSaleOdTaxLabel.Name = "createSaleOdTaxLabel";
            this.createSaleOdTaxLabel.Size = new System.Drawing.Size(120, 23);
            this.createSaleOdTaxLabel.TabIndex = 15;
            this.createSaleOdTaxLabel.Text = "Order Tax (%):";
            // 
            // saleOrderDataGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saleOrderDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.saleOrderDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.saleOrderDataGrid.Location = new System.Drawing.Point(19, 215);
            this.saleOrderDataGrid.Name = "saleOrderDataGrid";
            this.saleOrderDataGrid.RowHeadersVisible = false;
            this.saleOrderDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.saleOrderDataGrid.Size = new System.Drawing.Size(916, 125);
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
            this.createSaleItemLabel.Location = new System.Drawing.Point(15, 186);
            this.createSaleItemLabel.Name = "createSaleItemLabel";
            this.createSaleItemLabel.Size = new System.Drawing.Size(109, 23);
            this.createSaleItemLabel.TabIndex = 13;
            this.createSaleItemLabel.Text = "Order Items:";
            // 
            // createSaleSearchText
            // 
            this.createSaleSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createSaleSearchText.BackColor = System.Drawing.Color.Transparent;
            this.createSaleSearchText.BorderColor = System.Drawing.Color.Gray;
            this.createSaleSearchText.BorderRadius = 8;
            this.createSaleSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSaleSearchText.DefaultText = "";
            this.createSaleSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSaleSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSaleSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleSearchText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSaleSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.createSaleSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.createSaleSearchText.Location = new System.Drawing.Point(19, 129);
            this.createSaleSearchText.Name = "createSaleSearchText";
            this.createSaleSearchText.PasswordChar = '\0';
            this.createSaleSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSaleSearchText.PlaceholderText = "Search Product By Code Name";
            this.createSaleSearchText.SelectedText = "";
            this.createSaleSearchText.Size = new System.Drawing.Size(916, 42);
            this.createSaleSearchText.TabIndex = 12;
            this.createSaleSearchText.TextChanged += new System.EventHandler(this.createSaleSearchText_TextChanged);
            // 
            // createSaleProdtLabel
            // 
            this.createSaleProdtLabel.AutoSize = true;
            this.createSaleProdtLabel.BackColor = System.Drawing.Color.White;
            this.createSaleProdtLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleProdtLabel.Location = new System.Drawing.Point(15, 100);
            this.createSaleProdtLabel.Name = "createSaleProdtLabel";
            this.createSaleProdtLabel.Size = new System.Drawing.Size(76, 23);
            this.createSaleProdtLabel.TabIndex = 11;
            this.createSaleProdtLabel.Text = "Product:";
            // 
            // createSaleText
            // 
            this.createSaleText.BackColor = System.Drawing.Color.Transparent;
            this.createSaleText.BorderColor = System.Drawing.Color.Gray;
            this.createSaleText.BorderRadius = 8;
            this.createSaleText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSaleText.DefaultText = "";
            this.createSaleText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSaleText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSaleText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSaleText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.createSaleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSaleText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleText.Location = new System.Drawing.Point(333, 43);
            this.createSaleText.Name = "createSaleText";
            this.createSaleText.PasswordChar = '\0';
            this.createSaleText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSaleText.PlaceholderText = "Enter Customer Name";
            this.createSaleText.SelectedText = "";
            this.createSaleText.Size = new System.Drawing.Size(286, 42);
            this.createSaleText.TabIndex = 10;
            this.createSaleText.TextChanged += new System.EventHandler(this.createSaleText_TextChanged);
            // 
            // createSaleCusLabel
            // 
            this.createSaleCusLabel.AutoSize = true;
            this.createSaleCusLabel.BackColor = System.Drawing.Color.White;
            this.createSaleCusLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleCusLabel.Location = new System.Drawing.Point(329, 12);
            this.createSaleCusLabel.Name = "createSaleCusLabel";
            this.createSaleCusLabel.Size = new System.Drawing.Size(90, 23);
            this.createSaleCusLabel.TabIndex = 9;
            this.createSaleCusLabel.Text = "Customer:";
            // 
            // createSaleWareCombo
            // 
            this.createSaleWareCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createSaleWareCombo.BackColor = System.Drawing.Color.Transparent;
            this.createSaleWareCombo.BorderColor = System.Drawing.Color.Gray;
            this.createSaleWareCombo.BorderRadius = 8;
            this.createSaleWareCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.createSaleWareCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createSaleWareCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleWareCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSaleWareCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createSaleWareCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSaleWareCombo.ItemHeight = 30;
            this.createSaleWareCombo.Items.AddRange(new object[] {
            "Choose Warehouse",
            "Warehouse 1",
            "Warehouse 2"});
            this.createSaleWareCombo.Location = new System.Drawing.Point(649, 49);
            this.createSaleWareCombo.Name = "createSaleWareCombo";
            this.createSaleWareCombo.Size = new System.Drawing.Size(286, 36);
            this.createSaleWareCombo.StartIndex = 0;
            this.createSaleWareCombo.TabIndex = 8;
            this.createSaleWareCombo.SelectedIndexChanged += new System.EventHandler(this.createSaleWareCombo_SelectedIndexChanged);
            // 
            // CreateSaleWarehouseLabel
            // 
            this.CreateSaleWarehouseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateSaleWarehouseLabel.AutoSize = true;
            this.CreateSaleWarehouseLabel.BackColor = System.Drawing.Color.White;
            this.CreateSaleWarehouseLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateSaleWarehouseLabel.Location = new System.Drawing.Point(645, 12);
            this.CreateSaleWarehouseLabel.Name = "CreateSaleWarehouseLabel";
            this.CreateSaleWarehouseLabel.Size = new System.Drawing.Size(103, 23);
            this.CreateSaleWarehouseLabel.TabIndex = 7;
            this.CreateSaleWarehouseLabel.Text = "Warehouse:";
            // 
            // createSaleDateTime
            // 
            this.createSaleDateTime.BackColor = System.Drawing.Color.Transparent;
            this.createSaleDateTime.BorderColor = System.Drawing.Color.Gray;
            this.createSaleDateTime.BorderRadius = 8;
            this.createSaleDateTime.Checked = true;
            this.createSaleDateTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.createSaleDateTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleDateTime.ForeColor = System.Drawing.Color.Gray;
            this.createSaleDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.createSaleDateTime.Location = new System.Drawing.Point(19, 43);
            this.createSaleDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.createSaleDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.createSaleDateTime.Name = "createSaleDateTime";
            this.createSaleDateTime.Size = new System.Drawing.Size(286, 42);
            this.createSaleDateTime.TabIndex = 6;
            this.createSaleDateTime.Value = new System.DateTime(2025, 2, 28, 12, 17, 13, 576);
            this.createSaleDateTime.ValueChanged += new System.EventHandler(this.createSaleDateTime_ValueChanged);
            // 
            // createSaleDateLabel
            // 
            this.createSaleDateLabel.AutoSize = true;
            this.createSaleDateLabel.BackColor = System.Drawing.Color.White;
            this.createSaleDateLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleDateLabel.Location = new System.Drawing.Point(15, 12);
            this.createSaleDateLabel.Name = "createSaleDateLabel";
            this.createSaleDateLabel.Size = new System.Drawing.Size(51, 23);
            this.createSaleDateLabel.TabIndex = 5;
            this.createSaleDateLabel.Text = "Date:";
            // 
            // createSaleLabel
            // 
            this.createSaleLabel.AutoSize = true;
            this.createSaleLabel.BackColor = System.Drawing.Color.Transparent;
            this.createSaleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaleLabel.Location = new System.Drawing.Point(18, 50);
            this.createSaleLabel.Name = "createSaleLabel";
            this.createSaleLabel.Size = new System.Drawing.Size(148, 28);
            this.createSaleLabel.TabIndex = 19;
            this.createSaleLabel.Text = "Create Sale";
            // 
            // addSaleBorderlessForm
            // 
            this.addSaleBorderlessForm.BorderRadius = 25;
            this.addSaleBorderlessForm.ContainerControl = this;
            this.addSaleBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.addSaleBorderlessForm.TransparentWhileDrag = true;
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
            this.headerPanel.TabIndex = 29;
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
            // addSaleTotAmoPanel
            // 
            this.addSaleTotAmoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSaleTotAmoPanel.BackColor = System.Drawing.Color.Transparent;
            this.addSaleTotAmoPanel.BorderColor = System.Drawing.Color.Gray;
            this.addSaleTotAmoPanel.BorderRadius = 8;
            this.addSaleTotAmoPanel.BorderThickness = 1;
            this.addSaleTotAmoPanel.Controls.Add(this.addSaleDisCostLabel);
            this.addSaleTotAmoPanel.Controls.Add(this.addSaleOrdTaxCostLabel);
            this.addSaleTotAmoPanel.Controls.Add(this.addSaleShipCostLabel);
            this.addSaleTotAmoPanel.Controls.Add(this.addSaleTotalAmoCostLabel);
            this.addSaleTotAmoPanel.Controls.Add(this.addSaleDisCalLabel);
            this.addSaleTotAmoPanel.Controls.Add(this.addSaleOrdTaxCalLabel);
            this.addSaleTotAmoPanel.Controls.Add(this.addSaleShipCalLabel);
            this.addSaleTotAmoPanel.Controls.Add(this.addSaleTotAmoLabel);
            this.addSaleTotAmoPanel.CustomBorderColor = System.Drawing.Color.Gray;
            this.addSaleTotAmoPanel.FillColor = System.Drawing.Color.Transparent;
            this.addSaleTotAmoPanel.Location = new System.Drawing.Point(513, 361);
            this.addSaleTotAmoPanel.Name = "addSaleTotAmoPanel";
            this.addSaleTotAmoPanel.Size = new System.Drawing.Size(422, 168);
            this.addSaleTotAmoPanel.TabIndex = 31;
            // 
            // addSaleShipCalLabel
            // 
            this.addSaleShipCalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSaleShipCalLabel.AutoSize = true;
            this.addSaleShipCalLabel.BackColor = System.Drawing.Color.Transparent;
            this.addSaleShipCalLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSaleShipCalLabel.Location = new System.Drawing.Point(14, 12);
            this.addSaleShipCalLabel.Name = "addSaleShipCalLabel";
            this.addSaleShipCalLabel.Size = new System.Drawing.Size(80, 23);
            this.addSaleShipCalLabel.TabIndex = 32;
            this.addSaleShipCalLabel.Text = "Shipping ";
            // 
            // addSaleOrdTaxCalLabel
            // 
            this.addSaleOrdTaxCalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSaleOrdTaxCalLabel.AutoSize = true;
            this.addSaleOrdTaxCalLabel.BackColor = System.Drawing.Color.Transparent;
            this.addSaleOrdTaxCalLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSaleOrdTaxCalLabel.Location = new System.Drawing.Point(15, 47);
            this.addSaleOrdTaxCalLabel.Name = "addSaleOrdTaxCalLabel";
            this.addSaleOrdTaxCalLabel.Size = new System.Drawing.Size(85, 23);
            this.addSaleOrdTaxCalLabel.TabIndex = 33;
            this.addSaleOrdTaxCalLabel.Text = "Order Tax";
            // 
            // addSaleDisCalLabel
            // 
            this.addSaleDisCalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSaleDisCalLabel.AutoSize = true;
            this.addSaleDisCalLabel.BackColor = System.Drawing.Color.Transparent;
            this.addSaleDisCalLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSaleDisCalLabel.Location = new System.Drawing.Point(15, 83);
            this.addSaleDisCalLabel.Name = "addSaleDisCalLabel";
            this.addSaleDisCalLabel.Size = new System.Drawing.Size(78, 23);
            this.addSaleDisCalLabel.TabIndex = 34;
            this.addSaleDisCalLabel.Text = "Discount";
            // 
            // addSaleDisCostLabel
            // 
            this.addSaleDisCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSaleDisCostLabel.AutoSize = true;
            this.addSaleDisCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.addSaleDisCostLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSaleDisCostLabel.Location = new System.Drawing.Point(167, 82);
            this.addSaleDisCostLabel.Name = "addSaleDisCostLabel";
            this.addSaleDisCostLabel.Size = new System.Drawing.Size(63, 23);
            this.addSaleDisCostLabel.TabIndex = 38;
            this.addSaleDisCostLabel.Text = "$ 0.00 ";
            // 
            // addSaleOrdTaxCostLabel
            // 
            this.addSaleOrdTaxCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSaleOrdTaxCostLabel.AutoSize = true;
            this.addSaleOrdTaxCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.addSaleOrdTaxCostLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSaleOrdTaxCostLabel.Location = new System.Drawing.Point(167, 46);
            this.addSaleOrdTaxCostLabel.Name = "addSaleOrdTaxCostLabel";
            this.addSaleOrdTaxCostLabel.Size = new System.Drawing.Size(63, 23);
            this.addSaleOrdTaxCostLabel.TabIndex = 37;
            this.addSaleOrdTaxCostLabel.Text = "$ 0.00 ";
            // 
            // addSaleShipCostLabel
            // 
            this.addSaleShipCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSaleShipCostLabel.AutoSize = true;
            this.addSaleShipCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.addSaleShipCostLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSaleShipCostLabel.Location = new System.Drawing.Point(166, 11);
            this.addSaleShipCostLabel.Name = "addSaleShipCostLabel";
            this.addSaleShipCostLabel.Size = new System.Drawing.Size(124, 23);
            this.addSaleShipCostLabel.TabIndex = 36;
            this.addSaleShipCostLabel.Text = "$ 0.00 (0.00%)";
            // 
            // addSaleTotalAmoCostLabel
            // 
            this.addSaleTotalAmoCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSaleTotalAmoCostLabel.AutoSize = true;
            this.addSaleTotalAmoCostLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSaleTotalAmoCostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addSaleTotalAmoCostLabel.Location = new System.Drawing.Point(167, 120);
            this.addSaleTotalAmoCostLabel.Name = "addSaleTotalAmoCostLabel";
            this.addSaleTotalAmoCostLabel.Size = new System.Drawing.Size(63, 23);
            this.addSaleTotalAmoCostLabel.TabIndex = 35;
            this.addSaleTotalAmoCostLabel.Text = "$ 0.00 ";
            // 
            // AddSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 788);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.createSaleLabel);
            this.Controls.Add(this.createSalePanel);
            this.Controls.Add(this.saleCancelBtn);
            this.Controls.Add(this.saleSaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 788);
            this.MinimumSize = new System.Drawing.Size(1000, 718);
            this.Name = "AddSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSaleForm";
            this.Load += new System.EventHandler(this.AddSaleForm_Load);
            this.createSalePanel.ResumeLayout(false);
            this.createSalePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDataGrid)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.addSaleTotAmoPanel.ResumeLayout(false);
            this.addSaleTotAmoPanel.PerformLayout();
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
        private System.Windows.Forms.Label addSaleTotAmoLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm addSaleBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel addSaleTotAmoPanel;
        private System.Windows.Forms.Label addSaleShipCalLabel;
        private System.Windows.Forms.Label addSaleDisCostLabel;
        private System.Windows.Forms.Label addSaleOrdTaxCostLabel;
        private System.Windows.Forms.Label addSaleShipCostLabel;
        private System.Windows.Forms.Label addSaleTotalAmoCostLabel;
        private System.Windows.Forms.Label addSaleDisCalLabel;
        private System.Windows.Forms.Label addSaleOrdTaxCalLabel;
    }
}