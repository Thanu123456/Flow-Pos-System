namespace EscopeWindowsApp
{
    partial class AddSupplierForm
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
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.maximumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.createSupEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSupPhoneText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSupNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addSupBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.supAnimateWindow = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.createSupLabel = new System.Windows.Forms.Label();
            this.createSupPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.supCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.createSupItemText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.craeteSupItemLabel = new System.Windows.Forms.Label();
            this.createSupAddressText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSupAddressLabel = new System.Windows.Forms.Label();
            this.createSupCityText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSupCityLabel = new System.Windows.Forms.Label();
            this.createSupPhoneLabel = new System.Windows.Forms.Label();
            this.createSupEmailLabel = new System.Windows.Forms.Label();
            this.createSupNameLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.createSupPanel.SuspendLayout();
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
            this.headerPanel.TabIndex = 2;
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
            // createSupEmailText
            // 
            this.createSupEmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSupEmailText.BorderRadius = 8;
            this.createSupEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSupEmailText.DefaultText = "";
            this.createSupEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSupEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSupEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupEmailText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createSupEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupEmailText.Location = new System.Drawing.Point(507, 64);
            this.createSupEmailText.Name = "createSupEmailText";
            this.createSupEmailText.PasswordChar = '\0';
            this.createSupEmailText.PlaceholderText = "Enter Supplier Email";
            this.createSupEmailText.SelectedText = "";
            this.createSupEmailText.Size = new System.Drawing.Size(400, 42);
            this.createSupEmailText.TabIndex = 5;
            // 
            // createSupPhoneText
            // 
            this.createSupPhoneText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSupPhoneText.BorderRadius = 8;
            this.createSupPhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSupPhoneText.DefaultText = "";
            this.createSupPhoneText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSupPhoneText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSupPhoneText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupPhoneText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupPhoneText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupPhoneText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createSupPhoneText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupPhoneText.Location = new System.Drawing.Point(21, 200);
            this.createSupPhoneText.Name = "createSupPhoneText";
            this.createSupPhoneText.PasswordChar = '\0';
            this.createSupPhoneText.PlaceholderText = "Enter Supplier Phone";
            this.createSupPhoneText.SelectedText = "";
            this.createSupPhoneText.Size = new System.Drawing.Size(400, 42);
            this.createSupPhoneText.TabIndex = 4;
            // 
            // createSupNameText
            // 
            this.createSupNameText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSupNameText.BorderRadius = 8;
            this.createSupNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSupNameText.DefaultText = "";
            this.createSupNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSupNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSupNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupNameText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createSupNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupNameText.Location = new System.Drawing.Point(21, 64);
            this.createSupNameText.Name = "createSupNameText";
            this.createSupNameText.PasswordChar = '\0';
            this.createSupNameText.PlaceholderText = "Enter Supplier Name";
            this.createSupNameText.SelectedText = "";
            this.createSupNameText.Size = new System.Drawing.Size(400, 42);
            this.createSupNameText.TabIndex = 2;
            // 
            // addSupBorderlessForm
            // 
            this.addSupBorderlessForm.BorderRadius = 25;
            this.addSupBorderlessForm.ContainerControl = this;
            this.addSupBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.addSupBorderlessForm.TransparentWhileDrag = true;
            // 
            // supAnimateWindow
            // 
            this.supAnimateWindow.TargetForm = this;
            // 
            // createSupLabel
            // 
            this.createSupLabel.AutoSize = true;
            this.createSupLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupLabel.Location = new System.Drawing.Point(26, 56);
            this.createSupLabel.Name = "createSupLabel";
            this.createSupLabel.Size = new System.Drawing.Size(196, 28);
            this.createSupLabel.TabIndex = 18;
            this.createSupLabel.Text = "Create Supplier";
            // 
            // createSupPanel
            // 
            this.createSupPanel.BorderRadius = 8;
            this.createSupPanel.Controls.Add(this.supCancelBtn);
            this.createSupPanel.Controls.Add(this.supSaveBtn);
            this.createSupPanel.Controls.Add(this.createSupItemText);
            this.createSupPanel.Controls.Add(this.craeteSupItemLabel);
            this.createSupPanel.Controls.Add(this.createSupAddressText);
            this.createSupPanel.Controls.Add(this.createSupAddressLabel);
            this.createSupPanel.Controls.Add(this.createSupCityText);
            this.createSupPanel.Controls.Add(this.createSupCityLabel);
            this.createSupPanel.Controls.Add(this.createSupPhoneLabel);
            this.createSupPanel.Controls.Add(this.createSupEmailLabel);
            this.createSupPanel.Controls.Add(this.createSupNameLabel);
            this.createSupPanel.Controls.Add(this.createSupPhoneText);
            this.createSupPanel.Controls.Add(this.createSupNameText);
            this.createSupPanel.Controls.Add(this.createSupEmailText);
            this.createSupPanel.FillColor = System.Drawing.Color.White;
            this.createSupPanel.Location = new System.Drawing.Point(31, 103);
            this.createSupPanel.Name = "createSupPanel";
            this.createSupPanel.Size = new System.Drawing.Size(928, 517);
            this.createSupPanel.TabIndex = 19;
            // 
            // supCancelBtn
            // 
            this.supCancelBtn.BorderRadius = 8;
            this.supCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supCancelBtn.FillColor = System.Drawing.Color.DarkGray;
            this.supCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.supCancelBtn.ForeColor = System.Drawing.Color.White;
            this.supCancelBtn.Location = new System.Drawing.Point(814, 448);
            this.supCancelBtn.Name = "supCancelBtn";
            this.supCancelBtn.Size = new System.Drawing.Size(93, 47);
            this.supCancelBtn.TabIndex = 30;
            this.supCancelBtn.Text = "Cancel";
            // 
            // supSaveBtn
            // 
            this.supSaveBtn.BorderRadius = 8;
            this.supSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.supSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supSaveBtn.ForeColor = System.Drawing.Color.White;
            this.supSaveBtn.Location = new System.Drawing.Point(698, 448);
            this.supSaveBtn.Name = "supSaveBtn";
            this.supSaveBtn.Size = new System.Drawing.Size(93, 47);
            this.supSaveBtn.TabIndex = 29;
            this.supSaveBtn.Text = "Save";
            // 
            // createSupItemText
            // 
            this.createSupItemText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSupItemText.BorderRadius = 8;
            this.createSupItemText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSupItemText.DefaultText = "";
            this.createSupItemText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSupItemText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSupItemText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupItemText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupItemText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupItemText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createSupItemText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupItemText.Location = new System.Drawing.Point(507, 327);
            this.createSupItemText.Name = "createSupItemText";
            this.createSupItemText.PasswordChar = '\0';
            this.createSupItemText.PlaceholderText = "Enter Supplier Item";
            this.createSupItemText.SelectedText = "";
            this.createSupItemText.Size = new System.Drawing.Size(400, 42);
            this.createSupItemText.TabIndex = 28;
            // 
            // craeteSupItemLabel
            // 
            this.craeteSupItemLabel.AutoSize = true;
            this.craeteSupItemLabel.BackColor = System.Drawing.Color.White;
            this.craeteSupItemLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.craeteSupItemLabel.Location = new System.Drawing.Point(503, 292);
            this.craeteSupItemLabel.Name = "craeteSupItemLabel";
            this.craeteSupItemLabel.Size = new System.Drawing.Size(100, 23);
            this.craeteSupItemLabel.TabIndex = 27;
            this.craeteSupItemLabel.Text = "Item Name:";
            // 
            // createSupAddressText
            // 
            this.createSupAddressText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSupAddressText.BorderRadius = 8;
            this.createSupAddressText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSupAddressText.DefaultText = "";
            this.createSupAddressText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSupAddressText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSupAddressText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupAddressText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupAddressText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupAddressText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createSupAddressText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupAddressText.Location = new System.Drawing.Point(21, 327);
            this.createSupAddressText.Name = "createSupAddressText";
            this.createSupAddressText.PasswordChar = '\0';
            this.createSupAddressText.PlaceholderText = "Enter Supplier Address";
            this.createSupAddressText.SelectedText = "";
            this.createSupAddressText.Size = new System.Drawing.Size(400, 42);
            this.createSupAddressText.TabIndex = 26;
            // 
            // createSupAddressLabel
            // 
            this.createSupAddressLabel.AutoSize = true;
            this.createSupAddressLabel.BackColor = System.Drawing.Color.White;
            this.createSupAddressLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupAddressLabel.Location = new System.Drawing.Point(17, 292);
            this.createSupAddressLabel.Name = "createSupAddressLabel";
            this.createSupAddressLabel.Size = new System.Drawing.Size(78, 23);
            this.createSupAddressLabel.TabIndex = 25;
            this.createSupAddressLabel.Text = "Address:";
            // 
            // createSupCityText
            // 
            this.createSupCityText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSupCityText.BorderRadius = 8;
            this.createSupCityText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSupCityText.DefaultText = "";
            this.createSupCityText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSupCityText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSupCityText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupCityText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupCityText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupCityText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createSupCityText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupCityText.Location = new System.Drawing.Point(507, 200);
            this.createSupCityText.Name = "createSupCityText";
            this.createSupCityText.PasswordChar = '\0';
            this.createSupCityText.PlaceholderText = "Enter Supplier City";
            this.createSupCityText.SelectedText = "";
            this.createSupCityText.Size = new System.Drawing.Size(400, 42);
            this.createSupCityText.TabIndex = 24;
            // 
            // createSupCityLabel
            // 
            this.createSupCityLabel.AutoSize = true;
            this.createSupCityLabel.BackColor = System.Drawing.Color.White;
            this.createSupCityLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupCityLabel.Location = new System.Drawing.Point(503, 163);
            this.createSupCityLabel.Name = "createSupCityLabel";
            this.createSupCityLabel.Size = new System.Drawing.Size(44, 23);
            this.createSupCityLabel.TabIndex = 23;
            this.createSupCityLabel.Text = "City:";
            // 
            // createSupPhoneLabel
            // 
            this.createSupPhoneLabel.AutoSize = true;
            this.createSupPhoneLabel.BackColor = System.Drawing.Color.White;
            this.createSupPhoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupPhoneLabel.Location = new System.Drawing.Point(17, 163);
            this.createSupPhoneLabel.Name = "createSupPhoneLabel";
            this.createSupPhoneLabel.Size = new System.Drawing.Size(131, 23);
            this.createSupPhoneLabel.TabIndex = 22;
            this.createSupPhoneLabel.Text = "Phone Number:";
            // 
            // createSupEmailLabel
            // 
            this.createSupEmailLabel.AutoSize = true;
            this.createSupEmailLabel.BackColor = System.Drawing.Color.White;
            this.createSupEmailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupEmailLabel.Location = new System.Drawing.Point(503, 25);
            this.createSupEmailLabel.Name = "createSupEmailLabel";
            this.createSupEmailLabel.Size = new System.Drawing.Size(56, 23);
            this.createSupEmailLabel.TabIndex = 21;
            this.createSupEmailLabel.Text = "Email:";
            // 
            // createSupNameLabel
            // 
            this.createSupNameLabel.AutoSize = true;
            this.createSupNameLabel.BackColor = System.Drawing.Color.White;
            this.createSupNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupNameLabel.Location = new System.Drawing.Point(17, 25);
            this.createSupNameLabel.Name = "createSupNameLabel";
            this.createSupNameLabel.Size = new System.Drawing.Size(60, 23);
            this.createSupNameLabel.TabIndex = 19;
            this.createSupNameLabel.Text = "Name:";
            // 
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1000, 648);
            this.Controls.Add(this.createSupPanel);
            this.Controls.Add(this.createSupLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSupplierForm";
            this.Text = "AddSupplierForm";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.createSupPanel.ResumeLayout(false);
            this.createSupPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox maximumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createSupEmailText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createSupPhoneText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createSupNameText;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm addSupBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow supAnimateWindow;
        private System.Windows.Forms.Label createSupLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel createSupPanel;
        private System.Windows.Forms.Label createSupNameLabel;
        private System.Windows.Forms.Label createSupEmailLabel;
        private System.Windows.Forms.Label createSupPhoneLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createSupAddressText;
        private System.Windows.Forms.Label createSupAddressLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createSupCityText;
        private System.Windows.Forms.Label createSupCityLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createSupItemText;
        private System.Windows.Forms.Label craeteSupItemLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supSaveBtn;
    }
}