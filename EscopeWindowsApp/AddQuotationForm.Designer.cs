namespace EscopeWindowsApp
{
    partial class AddQuotationForm
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
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.maximumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.createQuotaLabel = new System.Windows.Forms.Label();
            this.createQuotaPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.quotaCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.quotaSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.createQuotaNoteLabel = new System.Windows.Forms.Label();
            this.createQuotaNoteText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createQuotaStatusCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.createQuotaStatusLabel = new System.Windows.Forms.Label();
            this.createQuotaShipText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createQuotaShiLabel = new System.Windows.Forms.Label();
            this.createQuotaDisText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createQuotaDisLabel = new System.Windows.Forms.Label();
            this.createQuoOderTaxText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createQuotaOdTaxLabel = new System.Windows.Forms.Label();
            this.quotaOrderDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemLabel = new System.Windows.Forms.Label();
            this.createQuoSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createQuoProductLabel = new System.Windows.Forms.Label();
            this.createQuoText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createQuoCusLabel = new System.Windows.Forms.Label();
            this.createQuoWareCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.CreateQuowarehouseLabel = new System.Windows.Forms.Label();
            this.createQuotaDateTime = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.createQuotaDateLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.createQuotaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quotaOrderDataGrid)).BeginInit();
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
            this.headerPanel.TabIndex = 4;
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
            // createQuotaLabel
            // 
            this.createQuotaLabel.AutoSize = true;
            this.createQuotaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuotaLabel.Location = new System.Drawing.Point(27, 56);
            this.createQuotaLabel.Name = "createQuotaLabel";
            this.createQuotaLabel.Size = new System.Drawing.Size(209, 28);
            this.createQuotaLabel.TabIndex = 16;
            this.createQuotaLabel.Text = "Create Quotation";
            // 
            // createQuotaPanel
            // 
            this.createQuotaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createQuotaPanel.BorderRadius = 8;
            this.createQuotaPanel.Controls.Add(this.quotaCancelBtn);
            this.createQuotaPanel.Controls.Add(this.quotaSaveBtn);
            this.createQuotaPanel.Controls.Add(this.createQuotaNoteLabel);
            this.createQuotaPanel.Controls.Add(this.createQuotaNoteText);
            this.createQuotaPanel.Controls.Add(this.createQuotaStatusCombo);
            this.createQuotaPanel.Controls.Add(this.createQuotaStatusLabel);
            this.createQuotaPanel.Controls.Add(this.createQuotaShipText);
            this.createQuotaPanel.Controls.Add(this.createQuotaShiLabel);
            this.createQuotaPanel.Controls.Add(this.createQuotaDisText);
            this.createQuotaPanel.Controls.Add(this.createQuotaDisLabel);
            this.createQuotaPanel.Controls.Add(this.createQuoOderTaxText);
            this.createQuotaPanel.Controls.Add(this.createQuotaOdTaxLabel);
            this.createQuotaPanel.Controls.Add(this.quotaOrderDataGrid);
            this.createQuotaPanel.Controls.Add(this.orderItemLabel);
            this.createQuotaPanel.Controls.Add(this.createQuoSearchText);
            this.createQuotaPanel.Controls.Add(this.createQuoProductLabel);
            this.createQuotaPanel.Controls.Add(this.createQuoText);
            this.createQuotaPanel.Controls.Add(this.createQuoCusLabel);
            this.createQuotaPanel.Controls.Add(this.createQuoWareCombo);
            this.createQuotaPanel.Controls.Add(this.CreateQuowarehouseLabel);
            this.createQuotaPanel.Controls.Add(this.createQuotaDateTime);
            this.createQuotaPanel.Controls.Add(this.createQuotaDateLabel);
            this.createQuotaPanel.FillColor = System.Drawing.Color.White;
            this.createQuotaPanel.Location = new System.Drawing.Point(32, 109);
            this.createQuotaPanel.Name = "createQuotaPanel";
            this.createQuotaPanel.Size = new System.Drawing.Size(933, 1038);
            this.createQuotaPanel.TabIndex = 17;
            this.createQuotaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createQuotaPanel_Paint);
            // 
            // quotaCancelBtn
            // 
            this.quotaCancelBtn.BorderRadius = 8;
            this.quotaCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quotaCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quotaCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quotaCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quotaCancelBtn.FillColor = System.Drawing.Color.DarkGray;
            this.quotaCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.quotaCancelBtn.ForeColor = System.Drawing.Color.White;
            this.quotaCancelBtn.Location = new System.Drawing.Point(822, 947);
            this.quotaCancelBtn.Name = "quotaCancelBtn";
            this.quotaCancelBtn.Size = new System.Drawing.Size(93, 47);
            this.quotaCancelBtn.TabIndex = 26;
            this.quotaCancelBtn.Text = "Cancel";
            this.quotaCancelBtn.Click += new System.EventHandler(this.quotaCancelBtn_Click);
            // 
            // quotaSaveBtn
            // 
            this.quotaSaveBtn.BorderRadius = 8;
            this.quotaSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quotaSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quotaSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quotaSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quotaSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.quotaSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaSaveBtn.ForeColor = System.Drawing.Color.White;
            this.quotaSaveBtn.Location = new System.Drawing.Point(706, 947);
            this.quotaSaveBtn.Name = "quotaSaveBtn";
            this.quotaSaveBtn.Size = new System.Drawing.Size(93, 47);
            this.quotaSaveBtn.TabIndex = 25;
            this.quotaSaveBtn.Text = "Save";
            this.quotaSaveBtn.Click += new System.EventHandler(this.quotaSaveBtn_Click);
            // 
            // createQuotaNoteLabel
            // 
            this.createQuotaNoteLabel.AutoSize = true;
            this.createQuotaNoteLabel.BackColor = System.Drawing.Color.Transparent;
            this.createQuotaNoteLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuotaNoteLabel.Location = new System.Drawing.Point(12, 776);
            this.createQuotaNoteLabel.Name = "createQuotaNoteLabel";
            this.createQuotaNoteLabel.Size = new System.Drawing.Size(52, 23);
            this.createQuotaNoteLabel.TabIndex = 24;
            this.createQuotaNoteLabel.Text = "Note:";
            // 
            // createQuotaNoteText
            // 
            this.createQuotaNoteText.BorderColor = System.Drawing.Color.Gray;
            this.createQuotaNoteText.BorderRadius = 8;
            this.createQuotaNoteText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createQuotaNoteText.DefaultText = "";
            this.createQuotaNoteText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createQuotaNoteText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createQuotaNoteText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createQuotaNoteText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createQuotaNoteText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuotaNoteText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createQuotaNoteText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuotaNoteText.Location = new System.Drawing.Point(16, 812);
            this.createQuotaNoteText.Name = "createQuotaNoteText";
            this.createQuotaNoteText.PasswordChar = '\0';
            this.createQuotaNoteText.PlaceholderText = "";
            this.createQuotaNoteText.SelectedText = "";
            this.createQuotaNoteText.Size = new System.Drawing.Size(900, 75);
            this.createQuotaNoteText.TabIndex = 23;
            this.createQuotaNoteText.TextChanged += new System.EventHandler(this.createQuotaNoteText_TextChanged);
            // 
            // createQuotaStatusCombo
            // 
            this.createQuotaStatusCombo.BackColor = System.Drawing.Color.Transparent;
            this.createQuotaStatusCombo.BorderColor = System.Drawing.Color.Gray;
            this.createQuotaStatusCombo.BorderRadius = 8;
            this.createQuotaStatusCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.createQuotaStatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createQuotaStatusCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuotaStatusCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuotaStatusCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.createQuotaStatusCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createQuotaStatusCombo.ItemHeight = 30;
            this.createQuotaStatusCombo.Items.AddRange(new object[] {
            "Sent",
            "Pending"});
            this.createQuotaStatusCombo.Location = new System.Drawing.Point(516, 704);
            this.createQuotaStatusCombo.Name = "createQuotaStatusCombo";
            this.createQuotaStatusCombo.Size = new System.Drawing.Size(400, 36);
            this.createQuotaStatusCombo.StartIndex = 0;
            this.createQuotaStatusCombo.TabIndex = 22;
            this.createQuotaStatusCombo.SelectedIndexChanged += new System.EventHandler(this.createQuotaStatusCombo_SelectedIndexChanged);
            // 
            // createQuotaStatusLabel
            // 
            this.createQuotaStatusLabel.AutoSize = true;
            this.createQuotaStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.createQuotaStatusLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuotaStatusLabel.Location = new System.Drawing.Point(512, 669);
            this.createQuotaStatusLabel.Name = "createQuotaStatusLabel";
            this.createQuotaStatusLabel.Size = new System.Drawing.Size(63, 23);
            this.createQuotaStatusLabel.TabIndex = 21;
            this.createQuotaStatusLabel.Text = "Status:";
            // 
            // createQuotaShipText
            // 
            this.createQuotaShipText.BorderColor = System.Drawing.Color.Gray;
            this.createQuotaShipText.BorderRadius = 8;
            this.createQuotaShipText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createQuotaShipText.DefaultText = "";
            this.createQuotaShipText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createQuotaShipText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createQuotaShipText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createQuotaShipText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createQuotaShipText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuotaShipText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createQuotaShipText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuotaShipText.Location = new System.Drawing.Point(16, 704);
            this.createQuotaShipText.Name = "createQuotaShipText";
            this.createQuotaShipText.PasswordChar = '\0';
            this.createQuotaShipText.PlaceholderText = "";
            this.createQuotaShipText.SelectedText = "";
            this.createQuotaShipText.Size = new System.Drawing.Size(400, 42);
            this.createQuotaShipText.TabIndex = 20;
            this.createQuotaShipText.TextChanged += new System.EventHandler(this.siticoneTextBox4_TextChanged);
            // 
            // createQuotaShiLabel
            // 
            this.createQuotaShiLabel.AutoSize = true;
            this.createQuotaShiLabel.BackColor = System.Drawing.Color.Transparent;
            this.createQuotaShiLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuotaShiLabel.Location = new System.Drawing.Point(12, 669);
            this.createQuotaShiLabel.Name = "createQuotaShiLabel";
            this.createQuotaShiLabel.Size = new System.Drawing.Size(81, 23);
            this.createQuotaShiLabel.TabIndex = 19;
            this.createQuotaShiLabel.Text = "Shipping:";
            // 
            // createQuotaDisText
            // 
            this.createQuotaDisText.BorderColor = System.Drawing.Color.Gray;
            this.createQuotaDisText.BorderRadius = 8;
            this.createQuotaDisText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createQuotaDisText.DefaultText = "";
            this.createQuotaDisText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createQuotaDisText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createQuotaDisText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createQuotaDisText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createQuotaDisText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuotaDisText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createQuotaDisText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuotaDisText.Location = new System.Drawing.Point(516, 589);
            this.createQuotaDisText.Name = "createQuotaDisText";
            this.createQuotaDisText.PasswordChar = '\0';
            this.createQuotaDisText.PlaceholderText = "";
            this.createQuotaDisText.SelectedText = "";
            this.createQuotaDisText.Size = new System.Drawing.Size(400, 42);
            this.createQuotaDisText.TabIndex = 18;
            this.createQuotaDisText.TextChanged += new System.EventHandler(this.createQuotaDisText_TextChanged);
            // 
            // createQuotaDisLabel
            // 
            this.createQuotaDisLabel.AutoSize = true;
            this.createQuotaDisLabel.BackColor = System.Drawing.Color.Transparent;
            this.createQuotaDisLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuotaDisLabel.Location = new System.Drawing.Point(511, 553);
            this.createQuotaDisLabel.Name = "createQuotaDisLabel";
            this.createQuotaDisLabel.Size = new System.Drawing.Size(83, 23);
            this.createQuotaDisLabel.TabIndex = 17;
            this.createQuotaDisLabel.Text = "Discount:";
            // 
            // createQuoOderTaxText
            // 
            this.createQuoOderTaxText.BorderColor = System.Drawing.Color.Gray;
            this.createQuoOderTaxText.BorderRadius = 8;
            this.createQuoOderTaxText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createQuoOderTaxText.DefaultText = "";
            this.createQuoOderTaxText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createQuoOderTaxText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createQuoOderTaxText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createQuoOderTaxText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createQuoOderTaxText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuoOderTaxText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createQuoOderTaxText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuoOderTaxText.Location = new System.Drawing.Point(16, 589);
            this.createQuoOderTaxText.Name = "createQuoOderTaxText";
            this.createQuoOderTaxText.PasswordChar = '\0';
            this.createQuoOderTaxText.PlaceholderText = "";
            this.createQuoOderTaxText.SelectedText = "";
            this.createQuoOderTaxText.Size = new System.Drawing.Size(400, 42);
            this.createQuoOderTaxText.TabIndex = 16;
            this.createQuoOderTaxText.TextChanged += new System.EventHandler(this.createQuoOderTaxText_TextChanged);
            // 
            // createQuotaOdTaxLabel
            // 
            this.createQuotaOdTaxLabel.AutoSize = true;
            this.createQuotaOdTaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.createQuotaOdTaxLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuotaOdTaxLabel.Location = new System.Drawing.Point(12, 553);
            this.createQuotaOdTaxLabel.Name = "createQuotaOdTaxLabel";
            this.createQuotaOdTaxLabel.Size = new System.Drawing.Size(90, 23);
            this.createQuotaOdTaxLabel.TabIndex = 15;
            this.createQuotaOdTaxLabel.Text = "Order Tax:";
            // 
            // quotaOrderDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quotaOrderDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.quotaOrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.quotaOrderDataGrid.ColumnHeadersHeight = 25;
            this.quotaOrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.quotaOrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.quotaOrderDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.quotaOrderDataGrid.GridColor = System.Drawing.Color.White;
            this.quotaOrderDataGrid.Location = new System.Drawing.Point(16, 315);
            this.quotaOrderDataGrid.Name = "quotaOrderDataGrid";
            this.quotaOrderDataGrid.RowHeadersVisible = false;
            this.quotaOrderDataGrid.Size = new System.Drawing.Size(899, 208);
            this.quotaOrderDataGrid.TabIndex = 14;
            this.quotaOrderDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.quotaOrderDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quotaOrderDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.quotaOrderDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.quotaOrderDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.quotaOrderDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.quotaOrderDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.quotaOrderDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.quotaOrderDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.quotaOrderDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.quotaOrderDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaOrderDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.quotaOrderDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.quotaOrderDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.quotaOrderDataGrid.ThemeStyle.ReadOnly = false;
            this.quotaOrderDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.quotaOrderDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.quotaOrderDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaOrderDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.quotaOrderDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.quotaOrderDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.quotaOrderDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.quotaOrderDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.quotaOrderDataGrid_CellContentClick);
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
            // orderItemLabel
            // 
            this.orderItemLabel.AutoSize = true;
            this.orderItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderItemLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItemLabel.Location = new System.Drawing.Point(12, 277);
            this.orderItemLabel.Name = "orderItemLabel";
            this.orderItemLabel.Size = new System.Drawing.Size(109, 23);
            this.orderItemLabel.TabIndex = 13;
            this.orderItemLabel.Text = "Order Items:";
            // 
            // createQuoSearchText
            // 
            this.createQuoSearchText.BorderColor = System.Drawing.Color.Gray;
            this.createQuoSearchText.BorderRadius = 8;
            this.createQuoSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createQuoSearchText.DefaultText = "";
            this.createQuoSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createQuoSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createQuoSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createQuoSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createQuoSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuoSearchText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createQuoSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuoSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.createQuoSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.createQuoSearchText.Location = new System.Drawing.Point(516, 192);
            this.createQuoSearchText.Name = "createQuoSearchText";
            this.createQuoSearchText.PasswordChar = '\0';
            this.createQuoSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createQuoSearchText.PlaceholderText = "Search Product By Code Name";
            this.createQuoSearchText.SelectedText = "";
            this.createQuoSearchText.Size = new System.Drawing.Size(400, 42);
            this.createQuoSearchText.TabIndex = 12;
            this.createQuoSearchText.TextChanged += new System.EventHandler(this.createQuoSearchText_TextChanged);
            // 
            // createQuoProductLabel
            // 
            this.createQuoProductLabel.AutoSize = true;
            this.createQuoProductLabel.BackColor = System.Drawing.Color.White;
            this.createQuoProductLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuoProductLabel.Location = new System.Drawing.Point(512, 151);
            this.createQuoProductLabel.Name = "createQuoProductLabel";
            this.createQuoProductLabel.Size = new System.Drawing.Size(76, 23);
            this.createQuoProductLabel.TabIndex = 11;
            this.createQuoProductLabel.Text = "Product:";
            // 
            // createQuoText
            // 
            this.createQuoText.BorderColor = System.Drawing.Color.Gray;
            this.createQuoText.BorderRadius = 8;
            this.createQuoText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createQuoText.DefaultText = "";
            this.createQuoText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createQuoText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createQuoText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createQuoText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createQuoText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuoText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createQuoText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuoText.Location = new System.Drawing.Point(16, 192);
            this.createQuoText.Name = "createQuoText";
            this.createQuoText.PasswordChar = '\0';
            this.createQuoText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createQuoText.PlaceholderText = "Enter Customer Name";
            this.createQuoText.SelectedText = "";
            this.createQuoText.Size = new System.Drawing.Size(400, 42);
            this.createQuoText.TabIndex = 10;
            this.createQuoText.TextChanged += new System.EventHandler(this.createQuoText_TextChanged);
            // 
            // createQuoCusLabel
            // 
            this.createQuoCusLabel.AutoSize = true;
            this.createQuoCusLabel.BackColor = System.Drawing.Color.White;
            this.createQuoCusLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuoCusLabel.Location = new System.Drawing.Point(12, 151);
            this.createQuoCusLabel.Name = "createQuoCusLabel";
            this.createQuoCusLabel.Size = new System.Drawing.Size(90, 23);
            this.createQuoCusLabel.TabIndex = 9;
            this.createQuoCusLabel.Text = "Customer:";
            // 
            // createQuoWareCombo
            // 
            this.createQuoWareCombo.BackColor = System.Drawing.Color.Transparent;
            this.createQuoWareCombo.BorderColor = System.Drawing.Color.Gray;
            this.createQuoWareCombo.BorderRadius = 8;
            this.createQuoWareCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.createQuoWareCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createQuoWareCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuoWareCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createQuoWareCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createQuoWareCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.createQuoWareCombo.ItemHeight = 30;
            this.createQuoWareCombo.Items.AddRange(new object[] {
            "Choose Warehouse",
            "Warehouse 1",
            "Warehouse 2"});
            this.createQuoWareCombo.Location = new System.Drawing.Point(515, 67);
            this.createQuoWareCombo.Name = "createQuoWareCombo";
            this.createQuoWareCombo.Size = new System.Drawing.Size(400, 36);
            this.createQuoWareCombo.StartIndex = 0;
            this.createQuoWareCombo.TabIndex = 8;
            this.createQuoWareCombo.SelectedIndexChanged += new System.EventHandler(this.createQuoWareCombo_SelectedIndexChanged);
            // 
            // CreateQuowarehouseLabel
            // 
            this.CreateQuowarehouseLabel.AutoSize = true;
            this.CreateQuowarehouseLabel.BackColor = System.Drawing.Color.White;
            this.CreateQuowarehouseLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateQuowarehouseLabel.Location = new System.Drawing.Point(512, 34);
            this.CreateQuowarehouseLabel.Name = "CreateQuowarehouseLabel";
            this.CreateQuowarehouseLabel.Size = new System.Drawing.Size(103, 23);
            this.CreateQuowarehouseLabel.TabIndex = 7;
            this.CreateQuowarehouseLabel.Text = "Warehouse:";
            // 
            // createQuotaDateTime
            // 
            this.createQuotaDateTime.BorderRadius = 8;
            this.createQuotaDateTime.Checked = true;
            this.createQuotaDateTime.FillColor = System.Drawing.Color.LightGreen;
            this.createQuotaDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createQuotaDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.createQuotaDateTime.Location = new System.Drawing.Point(16, 67);
            this.createQuotaDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.createQuotaDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.createQuotaDateTime.Name = "createQuotaDateTime";
            this.createQuotaDateTime.Size = new System.Drawing.Size(400, 42);
            this.createQuotaDateTime.TabIndex = 6;
            this.createQuotaDateTime.Value = new System.DateTime(2025, 2, 28, 12, 17, 13, 576);
            this.createQuotaDateTime.ValueChanged += new System.EventHandler(this.createQuotaDateTime_ValueChanged);
            // 
            // createQuotaDateLabel
            // 
            this.createQuotaDateLabel.AutoSize = true;
            this.createQuotaDateLabel.BackColor = System.Drawing.Color.White;
            this.createQuotaDateLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuotaDateLabel.Location = new System.Drawing.Point(12, 30);
            this.createQuotaDateLabel.Name = "createQuotaDateLabel";
            this.createQuotaDateLabel.Size = new System.Drawing.Size(51, 23);
            this.createQuotaDateLabel.TabIndex = 5;
            this.createQuotaDateLabel.Text = "Date:";
            // 
            // AddQuotationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1000, 1202);
            this.Controls.Add(this.createQuotaPanel);
            this.Controls.Add(this.createQuotaLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddQuotationForm";
            this.Text = "AddQuotation";
            this.Load += new System.EventHandler(this.AddQuotationForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.createQuotaPanel.ResumeLayout(false);
            this.createQuotaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quotaOrderDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox maximumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private System.Windows.Forms.Label createQuotaLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel createQuotaPanel;
        private System.Windows.Forms.Label createQuotaDateLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker createQuotaDateTime;
        private System.Windows.Forms.Label createQuoCusLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox createQuoWareCombo;
        private System.Windows.Forms.Label CreateQuowarehouseLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createQuoText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createQuoSearchText;
        private System.Windows.Forms.Label createQuoProductLabel;
        private System.Windows.Forms.Label orderItemLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView quotaOrderDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn supEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn supPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createQuoOderTaxText;
        private System.Windows.Forms.Label createQuotaOdTaxLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createQuotaShipText;
        private System.Windows.Forms.Label createQuotaShiLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createQuotaDisText;
        private System.Windows.Forms.Label createQuotaDisLabel;
        private System.Windows.Forms.Label createQuotaStatusLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox createQuotaStatusCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createQuotaNoteText;
        private System.Windows.Forms.Label createQuotaNoteLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton quotaCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton quotaSaveBtn;
    }
}