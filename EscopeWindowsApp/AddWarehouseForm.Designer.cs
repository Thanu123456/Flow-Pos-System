namespace EscopeWindowsApp
{
    partial class AddWarehouseForm
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
            this.addWareHouseBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.addWarehousePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.addWarehouseZipCodeText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addWarehouseZipCodeLabel = new System.Windows.Forms.Label();
            this.addWarehouseAddressText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addWarehouseAddressLabel = new System.Windows.Forms.Label();
            this.addWarehouseCityText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addWarehouseCityLabel = new System.Windows.Forms.Label();
            this.addWarehousePhoneLabel = new System.Windows.Forms.Label();
            this.addWarehouseEmailLabel = new System.Windows.Forms.Label();
            this.addWarehouseNameLabel = new System.Windows.Forms.Label();
            this.addWarehousePhoneText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addWarehouseNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addWarehouseEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addWarehouseLabel = new System.Windows.Forms.Label();
            this.addWarehouseCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.addWarehouseSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.addWarehousePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addWareHouseBorderlessForm
            // 
            this.addWareHouseBorderlessForm.BorderRadius = 25;
            this.addWareHouseBorderlessForm.ContainerControl = this;
            this.addWareHouseBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.addWareHouseBorderlessForm.TransparentWhileDrag = true;
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
            this.headerPanel.TabIndex = 28;
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
            // addWarehousePanel
            // 
            this.addWarehousePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addWarehousePanel.BorderRadius = 8;
            this.addWarehousePanel.Controls.Add(this.addWarehouseZipCodeText);
            this.addWarehousePanel.Controls.Add(this.addWarehouseZipCodeLabel);
            this.addWarehousePanel.Controls.Add(this.addWarehouseAddressText);
            this.addWarehousePanel.Controls.Add(this.addWarehouseAddressLabel);
            this.addWarehousePanel.Controls.Add(this.addWarehouseCityText);
            this.addWarehousePanel.Controls.Add(this.addWarehouseCityLabel);
            this.addWarehousePanel.Controls.Add(this.addWarehousePhoneLabel);
            this.addWarehousePanel.Controls.Add(this.addWarehouseEmailLabel);
            this.addWarehousePanel.Controls.Add(this.addWarehouseNameLabel);
            this.addWarehousePanel.Controls.Add(this.addWarehousePhoneText);
            this.addWarehousePanel.Controls.Add(this.addWarehouseNameText);
            this.addWarehousePanel.Controls.Add(this.addWarehouseEmailText);
            this.addWarehousePanel.FillColor = System.Drawing.Color.White;
            this.addWarehousePanel.Location = new System.Drawing.Point(23, 96);
            this.addWarehousePanel.Name = "addWarehousePanel";
            this.addWarehousePanel.Size = new System.Drawing.Size(956, 322);
            this.addWarehousePanel.TabIndex = 29;
            // 
            // addWarehouseZipCodeText
            // 
            this.addWarehouseZipCodeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addWarehouseZipCodeText.BackColor = System.Drawing.Color.Transparent;
            this.addWarehouseZipCodeText.BorderColor = System.Drawing.Color.Gray;
            this.addWarehouseZipCodeText.BorderRadius = 8;
            this.addWarehouseZipCodeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWarehouseZipCodeText.DefaultText = "";
            this.addWarehouseZipCodeText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addWarehouseZipCodeText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addWarehouseZipCodeText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addWarehouseZipCodeText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addWarehouseZipCodeText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addWarehouseZipCodeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseZipCodeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addWarehouseZipCodeText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addWarehouseZipCodeText.Location = new System.Drawing.Point(494, 245);
            this.addWarehouseZipCodeText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addWarehouseZipCodeText.Name = "addWarehouseZipCodeText";
            this.addWarehouseZipCodeText.PasswordChar = '\0';
            this.addWarehouseZipCodeText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.addWarehouseZipCodeText.PlaceholderText = "Enter Zip Code";
            this.addWarehouseZipCodeText.SelectedText = "";
            this.addWarehouseZipCodeText.Size = new System.Drawing.Size(443, 42);
            this.addWarehouseZipCodeText.TabIndex = 28;
            this.addWarehouseZipCodeText.TextChanged += new System.EventHandler(this.addWarehouseZipCodeText_TextChanged);
            // 
            // addWarehouseZipCodeLabel
            // 
            this.addWarehouseZipCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addWarehouseZipCodeLabel.AutoSize = true;
            this.addWarehouseZipCodeLabel.BackColor = System.Drawing.Color.White;
            this.addWarehouseZipCodeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseZipCodeLabel.Location = new System.Drawing.Point(491, 215);
            this.addWarehouseZipCodeLabel.Name = "addWarehouseZipCodeLabel";
            this.addWarehouseZipCodeLabel.Size = new System.Drawing.Size(81, 23);
            this.addWarehouseZipCodeLabel.TabIndex = 27;
            this.addWarehouseZipCodeLabel.Text = "Zip Code:";
            // 
            // addWarehouseAddressText
            // 
            this.addWarehouseAddressText.BackColor = System.Drawing.Color.Transparent;
            this.addWarehouseAddressText.BorderColor = System.Drawing.Color.Gray;
            this.addWarehouseAddressText.BorderRadius = 8;
            this.addWarehouseAddressText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWarehouseAddressText.DefaultText = "";
            this.addWarehouseAddressText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addWarehouseAddressText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addWarehouseAddressText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addWarehouseAddressText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addWarehouseAddressText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addWarehouseAddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseAddressText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addWarehouseAddressText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addWarehouseAddressText.Location = new System.Drawing.Point(21, 245);
            this.addWarehouseAddressText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addWarehouseAddressText.Name = "addWarehouseAddressText";
            this.addWarehouseAddressText.PasswordChar = '\0';
            this.addWarehouseAddressText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.addWarehouseAddressText.PlaceholderText = "Enter Warehouse Address";
            this.addWarehouseAddressText.SelectedText = "";
            this.addWarehouseAddressText.Size = new System.Drawing.Size(441, 42);
            this.addWarehouseAddressText.TabIndex = 26;
            this.addWarehouseAddressText.TextChanged += new System.EventHandler(this.addWarehouseAddressText_TextChanged);
            // 
            // addWarehouseAddressLabel
            // 
            this.addWarehouseAddressLabel.AutoSize = true;
            this.addWarehouseAddressLabel.BackColor = System.Drawing.Color.White;
            this.addWarehouseAddressLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseAddressLabel.Location = new System.Drawing.Point(15, 215);
            this.addWarehouseAddressLabel.Name = "addWarehouseAddressLabel";
            this.addWarehouseAddressLabel.Size = new System.Drawing.Size(78, 23);
            this.addWarehouseAddressLabel.TabIndex = 25;
            this.addWarehouseAddressLabel.Text = "Address:";
            // 
            // addWarehouseCityText
            // 
            this.addWarehouseCityText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addWarehouseCityText.BackColor = System.Drawing.Color.Transparent;
            this.addWarehouseCityText.BorderColor = System.Drawing.Color.Gray;
            this.addWarehouseCityText.BorderRadius = 8;
            this.addWarehouseCityText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWarehouseCityText.DefaultText = "";
            this.addWarehouseCityText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addWarehouseCityText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addWarehouseCityText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addWarehouseCityText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addWarehouseCityText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addWarehouseCityText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseCityText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addWarehouseCityText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addWarehouseCityText.Location = new System.Drawing.Point(494, 144);
            this.addWarehouseCityText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addWarehouseCityText.Name = "addWarehouseCityText";
            this.addWarehouseCityText.PasswordChar = '\0';
            this.addWarehouseCityText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.addWarehouseCityText.PlaceholderText = "Enter Warehouse City";
            this.addWarehouseCityText.SelectedText = "";
            this.addWarehouseCityText.Size = new System.Drawing.Size(443, 42);
            this.addWarehouseCityText.TabIndex = 24;
            this.addWarehouseCityText.TextChanged += new System.EventHandler(this.addWarehouseCityText_TextChanged);
            // 
            // addWarehouseCityLabel
            // 
            this.addWarehouseCityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addWarehouseCityLabel.AutoSize = true;
            this.addWarehouseCityLabel.BackColor = System.Drawing.Color.White;
            this.addWarehouseCityLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseCityLabel.Location = new System.Drawing.Point(490, 115);
            this.addWarehouseCityLabel.Name = "addWarehouseCityLabel";
            this.addWarehouseCityLabel.Size = new System.Drawing.Size(44, 23);
            this.addWarehouseCityLabel.TabIndex = 23;
            this.addWarehouseCityLabel.Text = "City:";
            // 
            // addWarehousePhoneLabel
            // 
            this.addWarehousePhoneLabel.AutoSize = true;
            this.addWarehousePhoneLabel.BackColor = System.Drawing.Color.White;
            this.addWarehousePhoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehousePhoneLabel.Location = new System.Drawing.Point(17, 115);
            this.addWarehousePhoneLabel.Name = "addWarehousePhoneLabel";
            this.addWarehousePhoneLabel.Size = new System.Drawing.Size(131, 23);
            this.addWarehousePhoneLabel.TabIndex = 22;
            this.addWarehousePhoneLabel.Text = "Phone Number:";
            // 
            // addWarehouseEmailLabel
            // 
            this.addWarehouseEmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addWarehouseEmailLabel.AutoSize = true;
            this.addWarehouseEmailLabel.BackColor = System.Drawing.Color.White;
            this.addWarehouseEmailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseEmailLabel.Location = new System.Drawing.Point(491, 21);
            this.addWarehouseEmailLabel.Name = "addWarehouseEmailLabel";
            this.addWarehouseEmailLabel.Size = new System.Drawing.Size(56, 23);
            this.addWarehouseEmailLabel.TabIndex = 21;
            this.addWarehouseEmailLabel.Text = "Email:";
            // 
            // addWarehouseNameLabel
            // 
            this.addWarehouseNameLabel.AutoSize = true;
            this.addWarehouseNameLabel.BackColor = System.Drawing.Color.White;
            this.addWarehouseNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseNameLabel.Location = new System.Drawing.Point(15, 21);
            this.addWarehouseNameLabel.Name = "addWarehouseNameLabel";
            this.addWarehouseNameLabel.Size = new System.Drawing.Size(60, 23);
            this.addWarehouseNameLabel.TabIndex = 19;
            this.addWarehouseNameLabel.Text = "Name:";
            // 
            // addWarehousePhoneText
            // 
            this.addWarehousePhoneText.BackColor = System.Drawing.Color.Transparent;
            this.addWarehousePhoneText.BorderColor = System.Drawing.Color.Gray;
            this.addWarehousePhoneText.BorderRadius = 8;
            this.addWarehousePhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWarehousePhoneText.DefaultText = "";
            this.addWarehousePhoneText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addWarehousePhoneText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addWarehousePhoneText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addWarehousePhoneText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addWarehousePhoneText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addWarehousePhoneText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehousePhoneText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addWarehousePhoneText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addWarehousePhoneText.Location = new System.Drawing.Point(21, 144);
            this.addWarehousePhoneText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addWarehousePhoneText.Name = "addWarehousePhoneText";
            this.addWarehousePhoneText.PasswordChar = '\0';
            this.addWarehousePhoneText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.addWarehousePhoneText.PlaceholderText = "Enter Warehouse Phone";
            this.addWarehousePhoneText.SelectedText = "";
            this.addWarehousePhoneText.Size = new System.Drawing.Size(441, 42);
            this.addWarehousePhoneText.TabIndex = 4;
            this.addWarehousePhoneText.TextChanged += new System.EventHandler(this.addWarehousePhoneText_TextChanged);
            // 
            // addWarehouseNameText
            // 
            this.addWarehouseNameText.BackColor = System.Drawing.Color.Transparent;
            this.addWarehouseNameText.BorderColor = System.Drawing.Color.Gray;
            this.addWarehouseNameText.BorderRadius = 8;
            this.addWarehouseNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWarehouseNameText.DefaultText = "";
            this.addWarehouseNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addWarehouseNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addWarehouseNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addWarehouseNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addWarehouseNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addWarehouseNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addWarehouseNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addWarehouseNameText.Location = new System.Drawing.Point(19, 47);
            this.addWarehouseNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addWarehouseNameText.Name = "addWarehouseNameText";
            this.addWarehouseNameText.PasswordChar = '\0';
            this.addWarehouseNameText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.addWarehouseNameText.PlaceholderText = "Enter Warehouse Name";
            this.addWarehouseNameText.SelectedText = "";
            this.addWarehouseNameText.Size = new System.Drawing.Size(443, 42);
            this.addWarehouseNameText.TabIndex = 2;
            this.addWarehouseNameText.TextChanged += new System.EventHandler(this.addWarehouseNameText_TextChanged);
            // 
            // addWarehouseEmailText
            // 
            this.addWarehouseEmailText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addWarehouseEmailText.BackColor = System.Drawing.Color.Transparent;
            this.addWarehouseEmailText.BorderColor = System.Drawing.Color.Gray;
            this.addWarehouseEmailText.BorderRadius = 8;
            this.addWarehouseEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWarehouseEmailText.DefaultText = "";
            this.addWarehouseEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addWarehouseEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addWarehouseEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addWarehouseEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addWarehouseEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addWarehouseEmailText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseEmailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addWarehouseEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addWarehouseEmailText.Location = new System.Drawing.Point(494, 47);
            this.addWarehouseEmailText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addWarehouseEmailText.Name = "addWarehouseEmailText";
            this.addWarehouseEmailText.PasswordChar = '\0';
            this.addWarehouseEmailText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.addWarehouseEmailText.PlaceholderText = "Enter Manager\'s Email";
            this.addWarehouseEmailText.SelectedText = "";
            this.addWarehouseEmailText.Size = new System.Drawing.Size(443, 42);
            this.addWarehouseEmailText.TabIndex = 5;
            this.addWarehouseEmailText.TextChanged += new System.EventHandler(this.addWarehouseEmailText_TextChanged);
            // 
            // addWarehouseLabel
            // 
            this.addWarehouseLabel.AutoSize = true;
            this.addWarehouseLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseLabel.Location = new System.Drawing.Point(18, 50);
            this.addWarehouseLabel.Name = "addWarehouseLabel";
            this.addWarehouseLabel.Size = new System.Drawing.Size(199, 29);
            this.addWarehouseLabel.TabIndex = 30;
            this.addWarehouseLabel.Text = "Create Warehouse";
            // 
            // addWarehouseCancelBtn
            // 
            this.addWarehouseCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addWarehouseCancelBtn.Animated = true;
            this.addWarehouseCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.addWarehouseCancelBtn.BorderRadius = 8;
            this.addWarehouseCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addWarehouseCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addWarehouseCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addWarehouseCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addWarehouseCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addWarehouseCancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseCancelBtn.ForeColor = System.Drawing.Color.White;
            this.addWarehouseCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.addWarehouseCancelBtn.Location = new System.Drawing.Point(884, 429);
            this.addWarehouseCancelBtn.Name = "addWarehouseCancelBtn";
            this.addWarehouseCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.addWarehouseCancelBtn.TabIndex = 32;
            this.addWarehouseCancelBtn.Text = "Cancel";
            this.addWarehouseCancelBtn.Click += new System.EventHandler(this.addWarehouseCancelBtn_Click);
            // 
            // addWarehouseSaveBtn
            // 
            this.addWarehouseSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addWarehouseSaveBtn.Animated = true;
            this.addWarehouseSaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.addWarehouseSaveBtn.BorderRadius = 8;
            this.addWarehouseSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addWarehouseSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addWarehouseSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addWarehouseSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addWarehouseSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.addWarehouseSaveBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWarehouseSaveBtn.ForeColor = System.Drawing.Color.White;
            this.addWarehouseSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.addWarehouseSaveBtn.Location = new System.Drawing.Point(779, 429);
            this.addWarehouseSaveBtn.Name = "addWarehouseSaveBtn";
            this.addWarehouseSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.addWarehouseSaveBtn.TabIndex = 31;
            this.addWarehouseSaveBtn.Text = "Save";
            this.addWarehouseSaveBtn.Click += new System.EventHandler(this.addWarehouseSaveBtn_Click);
            // 
            // AddWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.addWarehouseCancelBtn);
            this.Controls.Add(this.addWarehouseSaveBtn);
            this.Controls.Add(this.addWarehouseLabel);
            this.Controls.Add(this.addWarehousePanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "AddWarehouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWarehouseForm";
            this.Load += new System.EventHandler(this.AddWarehouseForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.addWarehousePanel.ResumeLayout(false);
            this.addWarehousePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm addWareHouseBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel addWarehousePanel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addWarehouseZipCodeText;
        private System.Windows.Forms.Label addWarehouseZipCodeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addWarehouseAddressText;
        private System.Windows.Forms.Label addWarehouseAddressLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addWarehouseCityText;
        private System.Windows.Forms.Label addWarehouseCityLabel;
        private System.Windows.Forms.Label addWarehousePhoneLabel;
        private System.Windows.Forms.Label addWarehouseEmailLabel;
        private System.Windows.Forms.Label addWarehouseNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addWarehousePhoneText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addWarehouseNameText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addWarehouseEmailText;
        private System.Windows.Forms.Label addWarehouseLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addWarehouseCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addWarehouseSaveBtn;
    }
}