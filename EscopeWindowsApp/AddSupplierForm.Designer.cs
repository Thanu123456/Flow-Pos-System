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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplierForm));
            this.createSupEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSupPhoneText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSupNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addSupBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.supAnimateWindow = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.createSupLabel = new System.Windows.Forms.Label();
            this.createSupPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.createSupItemText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.craeteSupItemLabel = new System.Windows.Forms.Label();
            this.createSupAddressText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSupAddressLabel = new System.Windows.Forms.Label();
            this.createSupCityText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSupCityLabel = new System.Windows.Forms.Label();
            this.createSupPhoneLabel = new System.Windows.Forms.Label();
            this.createSupEmailLabel = new System.Windows.Forms.Label();
            this.createSupNameLabel = new System.Windows.Forms.Label();
            this.supCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.createSupPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createSupEmailText
            // 
            this.createSupEmailText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createSupEmailText.BackColor = System.Drawing.Color.Transparent;
            this.createSupEmailText.BorderColor = System.Drawing.Color.Gray;
            this.createSupEmailText.BorderRadius = 8;
            this.createSupEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSupEmailText.DefaultText = "";
            this.createSupEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSupEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSupEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupEmailText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupEmailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSupEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupEmailText.Location = new System.Drawing.Point(494, 52);
            this.createSupEmailText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createSupEmailText.Name = "createSupEmailText";
            this.createSupEmailText.PasswordChar = '\0';
            this.createSupEmailText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSupEmailText.PlaceholderText = "Enter Supplier Email";
            this.createSupEmailText.SelectedText = "";
            this.createSupEmailText.Size = new System.Drawing.Size(443, 42);
            this.createSupEmailText.TabIndex = 5;
            this.createSupEmailText.TextChanged += new System.EventHandler(this.createSupEmailText_TextChanged);
            // 
            // createSupPhoneText
            // 
            this.createSupPhoneText.BackColor = System.Drawing.Color.Transparent;
            this.createSupPhoneText.BorderColor = System.Drawing.Color.Gray;
            this.createSupPhoneText.BorderRadius = 8;
            this.createSupPhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSupPhoneText.DefaultText = "";
            this.createSupPhoneText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSupPhoneText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSupPhoneText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupPhoneText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupPhoneText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupPhoneText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupPhoneText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSupPhoneText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupPhoneText.Location = new System.Drawing.Point(21, 149);
            this.createSupPhoneText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createSupPhoneText.Name = "createSupPhoneText";
            this.createSupPhoneText.PasswordChar = '\0';
            this.createSupPhoneText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSupPhoneText.PlaceholderText = "Enter Supplier Phone";
            this.createSupPhoneText.SelectedText = "";
            this.createSupPhoneText.Size = new System.Drawing.Size(441, 42);
            this.createSupPhoneText.TabIndex = 4;
            this.createSupPhoneText.TextChanged += new System.EventHandler(this.createSupPhoneText_TextChanged);
            // 
            // createSupNameText
            // 
            this.createSupNameText.BackColor = System.Drawing.Color.Transparent;
            this.createSupNameText.BorderColor = System.Drawing.Color.Gray;
            this.createSupNameText.BorderRadius = 8;
            this.createSupNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSupNameText.DefaultText = "";
            this.createSupNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSupNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSupNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSupNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupNameText.Location = new System.Drawing.Point(19, 52);
            this.createSupNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createSupNameText.Name = "createSupNameText";
            this.createSupNameText.PasswordChar = '\0';
            this.createSupNameText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSupNameText.PlaceholderText = "Enter Supplier Name";
            this.createSupNameText.SelectedText = "";
            this.createSupNameText.Size = new System.Drawing.Size(443, 42);
            this.createSupNameText.TabIndex = 2;
            this.createSupNameText.TextChanged += new System.EventHandler(this.createSupNameText_TextChanged);
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
            this.supAnimateWindow.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.supAnimateWindow.Interval = 50;
            this.supAnimateWindow.TargetForm = this;
            // 
            // createSupLabel
            // 
            this.createSupLabel.AutoSize = true;
            this.createSupLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupLabel.Location = new System.Drawing.Point(18, 50);
            this.createSupLabel.Name = "createSupLabel";
            this.createSupLabel.Size = new System.Drawing.Size(167, 29);
            this.createSupLabel.TabIndex = 18;
            this.createSupLabel.Text = "Create Supplier";
            // 
            // createSupPanel
            // 
            this.createSupPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createSupPanel.BorderRadius = 8;
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
            this.createSupPanel.Location = new System.Drawing.Point(23, 96);
            this.createSupPanel.Name = "createSupPanel";
            this.createSupPanel.Size = new System.Drawing.Size(956, 322);
            this.createSupPanel.TabIndex = 19;
            // 
            // createSupItemText
            // 
            this.createSupItemText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createSupItemText.BackColor = System.Drawing.Color.Transparent;
            this.createSupItemText.BorderColor = System.Drawing.Color.Gray;
            this.createSupItemText.BorderRadius = 8;
            this.createSupItemText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSupItemText.DefaultText = "";
            this.createSupItemText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSupItemText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSupItemText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupItemText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupItemText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupItemText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupItemText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSupItemText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupItemText.Location = new System.Drawing.Point(494, 250);
            this.createSupItemText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createSupItemText.Name = "createSupItemText";
            this.createSupItemText.PasswordChar = '\0';
            this.createSupItemText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSupItemText.PlaceholderText = "Enter Supplier Item";
            this.createSupItemText.SelectedText = "";
            this.createSupItemText.Size = new System.Drawing.Size(443, 42);
            this.createSupItemText.TabIndex = 28;
            this.createSupItemText.TextChanged += new System.EventHandler(this.createSupItemText_TextChanged);
            // 
            // craeteSupItemLabel
            // 
            this.craeteSupItemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.craeteSupItemLabel.AutoSize = true;
            this.craeteSupItemLabel.BackColor = System.Drawing.Color.White;
            this.craeteSupItemLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.craeteSupItemLabel.Location = new System.Drawing.Point(491, 215);
            this.craeteSupItemLabel.Name = "craeteSupItemLabel";
            this.craeteSupItemLabel.Size = new System.Drawing.Size(100, 23);
            this.craeteSupItemLabel.TabIndex = 27;
            this.craeteSupItemLabel.Text = "Item Name:";
            this.craeteSupItemLabel.Click += new System.EventHandler(this.craeteSupItemLabel_Click);
            // 
            // createSupAddressText
            // 
            this.createSupAddressText.BackColor = System.Drawing.Color.Transparent;
            this.createSupAddressText.BorderColor = System.Drawing.Color.Gray;
            this.createSupAddressText.BorderRadius = 8;
            this.createSupAddressText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSupAddressText.DefaultText = "";
            this.createSupAddressText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSupAddressText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSupAddressText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupAddressText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupAddressText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupAddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupAddressText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSupAddressText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupAddressText.Location = new System.Drawing.Point(21, 250);
            this.createSupAddressText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createSupAddressText.Name = "createSupAddressText";
            this.createSupAddressText.PasswordChar = '\0';
            this.createSupAddressText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSupAddressText.PlaceholderText = "Enter Supplier Address";
            this.createSupAddressText.SelectedText = "";
            this.createSupAddressText.Size = new System.Drawing.Size(441, 42);
            this.createSupAddressText.TabIndex = 26;
            this.createSupAddressText.TextChanged += new System.EventHandler(this.createSupAddressText_TextChanged);
            // 
            // createSupAddressLabel
            // 
            this.createSupAddressLabel.AutoSize = true;
            this.createSupAddressLabel.BackColor = System.Drawing.Color.White;
            this.createSupAddressLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupAddressLabel.Location = new System.Drawing.Point(15, 215);
            this.createSupAddressLabel.Name = "createSupAddressLabel";
            this.createSupAddressLabel.Size = new System.Drawing.Size(78, 23);
            this.createSupAddressLabel.TabIndex = 25;
            this.createSupAddressLabel.Text = "Address:";
            // 
            // createSupCityText
            // 
            this.createSupCityText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createSupCityText.BackColor = System.Drawing.Color.Transparent;
            this.createSupCityText.BorderColor = System.Drawing.Color.Gray;
            this.createSupCityText.BorderRadius = 8;
            this.createSupCityText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createSupCityText.DefaultText = "";
            this.createSupCityText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createSupCityText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createSupCityText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupCityText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createSupCityText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupCityText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupCityText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSupCityText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createSupCityText.Location = new System.Drawing.Point(494, 149);
            this.createSupCityText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createSupCityText.Name = "createSupCityText";
            this.createSupCityText.PasswordChar = '\0';
            this.createSupCityText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createSupCityText.PlaceholderText = "Enter Supplier City";
            this.createSupCityText.SelectedText = "";
            this.createSupCityText.Size = new System.Drawing.Size(443, 42);
            this.createSupCityText.TabIndex = 24;
            this.createSupCityText.TextChanged += new System.EventHandler(this.createSupCityText_TextChanged);
            // 
            // createSupCityLabel
            // 
            this.createSupCityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createSupCityLabel.AutoSize = true;
            this.createSupCityLabel.BackColor = System.Drawing.Color.White;
            this.createSupCityLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupCityLabel.Location = new System.Drawing.Point(490, 115);
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
            this.createSupPhoneLabel.Location = new System.Drawing.Point(17, 115);
            this.createSupPhoneLabel.Name = "createSupPhoneLabel";
            this.createSupPhoneLabel.Size = new System.Drawing.Size(131, 23);
            this.createSupPhoneLabel.TabIndex = 22;
            this.createSupPhoneLabel.Text = "Phone Number:";
            // 
            // createSupEmailLabel
            // 
            this.createSupEmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createSupEmailLabel.AutoSize = true;
            this.createSupEmailLabel.BackColor = System.Drawing.Color.White;
            this.createSupEmailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupEmailLabel.Location = new System.Drawing.Point(491, 21);
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
            this.createSupNameLabel.Location = new System.Drawing.Point(15, 21);
            this.createSupNameLabel.Name = "createSupNameLabel";
            this.createSupNameLabel.Size = new System.Drawing.Size(60, 23);
            this.createSupNameLabel.TabIndex = 19;
            this.createSupNameLabel.Text = "Name:";
            // 
            // supCancelBtn
            // 
            this.supCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.supCancelBtn.Animated = true;
            this.supCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.supCancelBtn.BorderRadius = 8;
            this.supCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.supCancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supCancelBtn.ForeColor = System.Drawing.Color.White;
            this.supCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.supCancelBtn.Location = new System.Drawing.Point(884, 429);
            this.supCancelBtn.Name = "supCancelBtn";
            this.supCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.supCancelBtn.TabIndex = 30;
            this.supCancelBtn.Text = "Cancel";
            this.supCancelBtn.Click += new System.EventHandler(this.supCancelBtn_Click);
            // 
            // supSaveBtn
            // 
            this.supSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.supSaveBtn.Animated = true;
            this.supSaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.supSaveBtn.BorderRadius = 8;
            this.supSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.supSaveBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supSaveBtn.ForeColor = System.Drawing.Color.White;
            this.supSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.supSaveBtn.Location = new System.Drawing.Point(779, 429);
            this.supSaveBtn.Name = "supSaveBtn";
            this.supSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.supSaveBtn.TabIndex = 29;
            this.supSaveBtn.Text = "Save";
            this.supSaveBtn.Click += new System.EventHandler(this.supSaveBtn_Click);
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
            this.headerPanel.TabIndex = 27;
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
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.supCancelBtn);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.supSaveBtn);
            this.Controls.Add(this.createSupPanel);
            this.Controls.Add(this.createSupLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "AddSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Suppliers";
            this.Load += new System.EventHandler(this.AddSupplierForm_Load);
            this.createSupPanel.ResumeLayout(false);
            this.createSupPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
    }
}