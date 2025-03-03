namespace EscopeWindowsApp
{
    partial class AddCustomerForm
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
            this.createCusCityText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createCusAddressText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addCusEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.CreateCusPhoneText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createCusNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addCusBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.cusAnimateWindow = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.createCusLabel = new System.Windows.Forms.Label();
            this.createCusPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.createCusNameLabel = new System.Windows.Forms.Label();
            this.createCusEmailLabel = new System.Windows.Forms.Label();
            this.createCusPhoneLabel = new System.Windows.Forms.Label();
            this.createCusDateTime = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.createCusDOB = new System.Windows.Forms.Label();
            this.createCusCityLabel = new System.Windows.Forms.Label();
            this.createCusAddress = new System.Windows.Forms.Label();
            this.cusCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.createCusPanel.SuspendLayout();
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
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
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
            // createCusCityText
            // 
            this.createCusCityText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createCusCityText.BorderRadius = 8;
            this.createCusCityText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createCusCityText.DefaultText = "";
            this.createCusCityText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createCusCityText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createCusCityText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createCusCityText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createCusCityText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createCusCityText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createCusCityText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createCusCityText.Location = new System.Drawing.Point(23, 282);
            this.createCusCityText.Name = "createCusCityText";
            this.createCusCityText.PasswordChar = '\0';
            this.createCusCityText.PlaceholderText = "Enter Customer City";
            this.createCusCityText.SelectedText = "";
            this.createCusCityText.Size = new System.Drawing.Size(400, 42);
            this.createCusCityText.TabIndex = 8;
            // 
            // createCusAddressText
            // 
            this.createCusAddressText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createCusAddressText.BorderRadius = 8;
            this.createCusAddressText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createCusAddressText.DefaultText = "";
            this.createCusAddressText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createCusAddressText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createCusAddressText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createCusAddressText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createCusAddressText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createCusAddressText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createCusAddressText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createCusAddressText.Location = new System.Drawing.Point(504, 282);
            this.createCusAddressText.Name = "createCusAddressText";
            this.createCusAddressText.PasswordChar = '\0';
            this.createCusAddressText.PlaceholderText = "Enter Customer Address";
            this.createCusAddressText.SelectedText = "";
            this.createCusAddressText.Size = new System.Drawing.Size(400, 42);
            this.createCusAddressText.TabIndex = 6;
            // 
            // addCusEmailText
            // 
            this.addCusEmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addCusEmailText.BorderRadius = 8;
            this.addCusEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCusEmailText.DefaultText = "";
            this.addCusEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addCusEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addCusEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusEmailText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addCusEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusEmailText.Location = new System.Drawing.Point(504, 60);
            this.addCusEmailText.Name = "addCusEmailText";
            this.addCusEmailText.PasswordChar = '\0';
            this.addCusEmailText.PlaceholderText = "Enter Customer Email";
            this.addCusEmailText.SelectedText = "";
            this.addCusEmailText.Size = new System.Drawing.Size(400, 42);
            this.addCusEmailText.TabIndex = 4;
            // 
            // CreateCusPhoneText
            // 
            this.CreateCusPhoneText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateCusPhoneText.BorderRadius = 8;
            this.CreateCusPhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreateCusPhoneText.DefaultText = "";
            this.CreateCusPhoneText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CreateCusPhoneText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CreateCusPhoneText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreateCusPhoneText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreateCusPhoneText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreateCusPhoneText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.CreateCusPhoneText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreateCusPhoneText.Location = new System.Drawing.Point(23, 171);
            this.CreateCusPhoneText.Name = "CreateCusPhoneText";
            this.CreateCusPhoneText.PasswordChar = '\0';
            this.CreateCusPhoneText.PlaceholderText = "Enter Customer Phone";
            this.CreateCusPhoneText.SelectedText = "";
            this.CreateCusPhoneText.Size = new System.Drawing.Size(400, 42);
            this.CreateCusPhoneText.TabIndex = 3;
            // 
            // createCusNameText
            // 
            this.createCusNameText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createCusNameText.BorderRadius = 8;
            this.createCusNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createCusNameText.DefaultText = "";
            this.createCusNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createCusNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createCusNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createCusNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createCusNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createCusNameText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createCusNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createCusNameText.Location = new System.Drawing.Point(23, 60);
            this.createCusNameText.Name = "createCusNameText";
            this.createCusNameText.PasswordChar = '\0';
            this.createCusNameText.PlaceholderText = "Enter Customer Name";
            this.createCusNameText.SelectedText = "";
            this.createCusNameText.Size = new System.Drawing.Size(400, 42);
            this.createCusNameText.TabIndex = 1;
            // 
            // addCusBorderlessForm
            // 
            this.addCusBorderlessForm.BorderRadius = 25;
            this.addCusBorderlessForm.ContainerControl = this;
            this.addCusBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.addCusBorderlessForm.TransparentWhileDrag = true;
            // 
            // cusAnimateWindow
            // 
            this.cusAnimateWindow.TargetForm = this;
            // 
            // createCusLabel
            // 
            this.createCusLabel.AutoSize = true;
            this.createCusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCusLabel.Location = new System.Drawing.Point(26, 53);
            this.createCusLabel.Name = "createCusLabel";
            this.createCusLabel.Size = new System.Drawing.Size(210, 28);
            this.createCusLabel.TabIndex = 18;
            this.createCusLabel.Text = "Create Customer";
            // 
            // createCusPanel
            // 
            this.createCusPanel.BorderRadius = 8;
            this.createCusPanel.Controls.Add(this.cusCancelBtn);
            this.createCusPanel.Controls.Add(this.cusSaveBtn);
            this.createCusPanel.Controls.Add(this.createCusAddress);
            this.createCusPanel.Controls.Add(this.createCusCityLabel);
            this.createCusPanel.Controls.Add(this.createCusDOB);
            this.createCusPanel.Controls.Add(this.createCusDateTime);
            this.createCusPanel.Controls.Add(this.createCusPhoneLabel);
            this.createCusPanel.Controls.Add(this.createCusAddressText);
            this.createCusPanel.Controls.Add(this.createCusEmailLabel);
            this.createCusPanel.Controls.Add(this.createCusCityText);
            this.createCusPanel.Controls.Add(this.createCusNameText);
            this.createCusPanel.Controls.Add(this.createCusNameLabel);
            this.createCusPanel.Controls.Add(this.addCusEmailText);
            this.createCusPanel.Controls.Add(this.CreateCusPhoneText);
            this.createCusPanel.FillColor = System.Drawing.Color.White;
            this.createCusPanel.Location = new System.Drawing.Point(31, 105);
            this.createCusPanel.Name = "createCusPanel";
            this.createCusPanel.Size = new System.Drawing.Size(928, 480);
            this.createCusPanel.TabIndex = 19;
            // 
            // createCusNameLabel
            // 
            this.createCusNameLabel.AutoSize = true;
            this.createCusNameLabel.BackColor = System.Drawing.Color.White;
            this.createCusNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCusNameLabel.Location = new System.Drawing.Point(19, 25);
            this.createCusNameLabel.Name = "createCusNameLabel";
            this.createCusNameLabel.Size = new System.Drawing.Size(60, 23);
            this.createCusNameLabel.TabIndex = 19;
            this.createCusNameLabel.Text = "Name:";
            // 
            // createCusEmailLabel
            // 
            this.createCusEmailLabel.AutoSize = true;
            this.createCusEmailLabel.BackColor = System.Drawing.Color.White;
            this.createCusEmailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCusEmailLabel.Location = new System.Drawing.Point(500, 25);
            this.createCusEmailLabel.Name = "createCusEmailLabel";
            this.createCusEmailLabel.Size = new System.Drawing.Size(56, 23);
            this.createCusEmailLabel.TabIndex = 21;
            this.createCusEmailLabel.Text = "Email:";
            // 
            // createCusPhoneLabel
            // 
            this.createCusPhoneLabel.AutoSize = true;
            this.createCusPhoneLabel.BackColor = System.Drawing.Color.White;
            this.createCusPhoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCusPhoneLabel.Location = new System.Drawing.Point(19, 136);
            this.createCusPhoneLabel.Name = "createCusPhoneLabel";
            this.createCusPhoneLabel.Size = new System.Drawing.Size(131, 23);
            this.createCusPhoneLabel.TabIndex = 22;
            this.createCusPhoneLabel.Text = "Phone Number:";
            // 
            // createCusDateTime
            // 
            this.createCusDateTime.BorderRadius = 8;
            this.createCusDateTime.Checked = true;
            this.createCusDateTime.FillColor = System.Drawing.Color.LightGreen;
            this.createCusDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createCusDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.createCusDateTime.Location = new System.Drawing.Point(504, 171);
            this.createCusDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.createCusDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.createCusDateTime.Name = "createCusDateTime";
            this.createCusDateTime.Size = new System.Drawing.Size(400, 42);
            this.createCusDateTime.TabIndex = 23;
            this.createCusDateTime.Value = new System.DateTime(2025, 2, 28, 12, 17, 13, 576);
            // 
            // createCusDOB
            // 
            this.createCusDOB.AutoSize = true;
            this.createCusDOB.BackColor = System.Drawing.Color.White;
            this.createCusDOB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCusDOB.Location = new System.Drawing.Point(500, 136);
            this.createCusDOB.Name = "createCusDOB";
            this.createCusDOB.Size = new System.Drawing.Size(50, 23);
            this.createCusDOB.TabIndex = 24;
            this.createCusDOB.Text = "DOB:";
            // 
            // createCusCityLabel
            // 
            this.createCusCityLabel.AutoSize = true;
            this.createCusCityLabel.BackColor = System.Drawing.Color.White;
            this.createCusCityLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCusCityLabel.Location = new System.Drawing.Point(19, 246);
            this.createCusCityLabel.Name = "createCusCityLabel";
            this.createCusCityLabel.Size = new System.Drawing.Size(44, 23);
            this.createCusCityLabel.TabIndex = 25;
            this.createCusCityLabel.Text = "City:";
            // 
            // createCusAddress
            // 
            this.createCusAddress.AutoSize = true;
            this.createCusAddress.BackColor = System.Drawing.Color.White;
            this.createCusAddress.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCusAddress.Location = new System.Drawing.Point(500, 246);
            this.createCusAddress.Name = "createCusAddress";
            this.createCusAddress.Size = new System.Drawing.Size(78, 23);
            this.createCusAddress.TabIndex = 26;
            this.createCusAddress.Text = "Address:";
            // 
            // cusCancelBtn
            // 
            this.cusCancelBtn.BorderRadius = 8;
            this.cusCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusCancelBtn.FillColor = System.Drawing.Color.DarkGray;
            this.cusCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cusCancelBtn.ForeColor = System.Drawing.Color.White;
            this.cusCancelBtn.Location = new System.Drawing.Point(802, 389);
            this.cusCancelBtn.Name = "cusCancelBtn";
            this.cusCancelBtn.Size = new System.Drawing.Size(93, 47);
            this.cusCancelBtn.TabIndex = 30;
            this.cusCancelBtn.Text = "Cancel";
            // 
            // cusSaveBtn
            // 
            this.cusSaveBtn.BorderRadius = 8;
            this.cusSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.cusSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusSaveBtn.ForeColor = System.Drawing.Color.White;
            this.cusSaveBtn.Location = new System.Drawing.Point(686, 389);
            this.cusSaveBtn.Name = "cusSaveBtn";
            this.cusSaveBtn.Size = new System.Drawing.Size(93, 47);
            this.cusSaveBtn.TabIndex = 29;
            this.cusSaveBtn.Text = "Save";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.createCusPanel);
            this.Controls.Add(this.createCusLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.createCusPanel.ResumeLayout(false);
            this.createCusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox maximumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addCusEmailText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CreateCusPhoneText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createCusNameText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createCusCityText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createCusAddressText;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm addCusBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow cusAnimateWindow;
        private System.Windows.Forms.Label createCusLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel createCusPanel;
        private System.Windows.Forms.Label createCusNameLabel;
        private System.Windows.Forms.Label createCusEmailLabel;
        private System.Windows.Forms.Label createCusPhoneLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker createCusDateTime;
        private System.Windows.Forms.Label createCusDOB;
        private System.Windows.Forms.Label createCusAddress;
        private System.Windows.Forms.Label createCusCityLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusSaveBtn;
    }
}