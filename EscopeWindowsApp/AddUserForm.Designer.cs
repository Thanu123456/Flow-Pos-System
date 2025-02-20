namespace EscopeWindowsApp
{
    partial class AddUserForm
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
            this.addUserLabel = new System.Windows.Forms.Label();
            this.userGinfoPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.addUserGenderCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.addUserRoleCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.addUserDOBText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addUserEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addUserMobileText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addUserCodeText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addUserNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.generalinfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userAddressPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.addUserPostalText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addUserCityText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addUserStreetText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userAdditionalPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.addUserStatusCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.addUserEPFText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addUserDateText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userResetBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.addUserBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.userAnimateWindow = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.userGinfoPanel.SuspendLayout();
            this.userAddressPanel.SuspendLayout();
            this.userAdditionalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(838, 34);
            this.headerPanel.TabIndex = 1;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlPanel.Controls.Add(this.minimumBtn);
            this.controlPanel.Controls.Add(this.maximumBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.SystemColors.Control;
            this.controlPanel.Location = new System.Drawing.Point(693, 1);
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
            // addUserLabel
            // 
            this.addUserLabel.AutoSize = true;
            this.addUserLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserLabel.Location = new System.Drawing.Point(12, 47);
            this.addUserLabel.Name = "addUserLabel";
            this.addUserLabel.Size = new System.Drawing.Size(133, 17);
            this.addUserLabel.TabIndex = 2;
            this.addUserLabel.Text = "Create New User";
            // 
            // userGinfoPanel
            // 
            this.userGinfoPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userGinfoPanel.BorderRadius = 8;
            this.userGinfoPanel.BorderThickness = 1;
            this.userGinfoPanel.Controls.Add(this.addUserGenderCombo);
            this.userGinfoPanel.Controls.Add(this.addUserRoleCombo);
            this.userGinfoPanel.Controls.Add(this.addUserDOBText);
            this.userGinfoPanel.Controls.Add(this.addUserEmailText);
            this.userGinfoPanel.Controls.Add(this.addUserMobileText);
            this.userGinfoPanel.Controls.Add(this.addUserCodeText);
            this.userGinfoPanel.Controls.Add(this.addUserNameText);
            this.userGinfoPanel.Location = new System.Drawing.Point(15, 87);
            this.userGinfoPanel.Name = "userGinfoPanel";
            this.userGinfoPanel.Size = new System.Drawing.Size(810, 208);
            this.userGinfoPanel.TabIndex = 3;
            this.userGinfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userGinfoPanel_Paint);
            // 
            // addUserGenderCombo
            // 
            this.addUserGenderCombo.BackColor = System.Drawing.Color.Transparent;
            this.addUserGenderCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserGenderCombo.BorderRadius = 8;
            this.addUserGenderCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.addUserGenderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addUserGenderCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserGenderCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserGenderCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserGenderCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.addUserGenderCombo.ItemHeight = 30;
            this.addUserGenderCombo.Items.AddRange(new object[] {
            "Add Gender",
            "Male",
            "Female"});
            this.addUserGenderCombo.Location = new System.Drawing.Point(550, 91);
            this.addUserGenderCombo.Name = "addUserGenderCombo";
            this.addUserGenderCombo.Size = new System.Drawing.Size(247, 36);
            this.addUserGenderCombo.StartIndex = 0;
            this.addUserGenderCombo.TabIndex = 8;
            this.addUserGenderCombo.SelectedIndexChanged += new System.EventHandler(this.addUserGenderCombo_SelectedIndexChanged);
            // 
            // addUserRoleCombo
            // 
            this.addUserRoleCombo.BackColor = System.Drawing.Color.Transparent;
            this.addUserRoleCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserRoleCombo.BorderRadius = 8;
            this.addUserRoleCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.addUserRoleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addUserRoleCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserRoleCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserRoleCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserRoleCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.addUserRoleCombo.ItemHeight = 30;
            this.addUserRoleCombo.Items.AddRange(new object[] {
            "Add Role",
            "Owner",
            "Cashier"});
            this.addUserRoleCombo.Location = new System.Drawing.Point(281, 91);
            this.addUserRoleCombo.Name = "addUserRoleCombo";
            this.addUserRoleCombo.Size = new System.Drawing.Size(247, 36);
            this.addUserRoleCombo.StartIndex = 0;
            this.addUserRoleCombo.TabIndex = 7;
            this.addUserRoleCombo.SelectedIndexChanged += new System.EventHandler(this.siticoneComboBox1_SelectedIndexChanged);
            // 
            // addUserDOBText
            // 
            this.addUserDOBText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserDOBText.BorderRadius = 8;
            this.addUserDOBText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUserDOBText.DefaultText = "";
            this.addUserDOBText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUserDOBText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUserDOBText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserDOBText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserDOBText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserDOBText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserDOBText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserDOBText.Location = new System.Drawing.Point(12, 160);
            this.addUserDOBText.Name = "addUserDOBText";
            this.addUserDOBText.PasswordChar = '\0';
            this.addUserDOBText.PlaceholderText = "Enter User DOB";
            this.addUserDOBText.SelectedText = "";
            this.addUserDOBText.Size = new System.Drawing.Size(247, 36);
            this.addUserDOBText.TabIndex = 5;
            this.addUserDOBText.TextChanged += new System.EventHandler(this.addUserDOBText_TextChanged);
            // 
            // addUserEmailText
            // 
            this.addUserEmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserEmailText.BorderRadius = 8;
            this.addUserEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUserEmailText.DefaultText = "";
            this.addUserEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUserEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUserEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserEmailText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserEmailText.Location = new System.Drawing.Point(12, 91);
            this.addUserEmailText.Name = "addUserEmailText";
            this.addUserEmailText.PasswordChar = '\0';
            this.addUserEmailText.PlaceholderText = "Enter User Email";
            this.addUserEmailText.SelectedText = "";
            this.addUserEmailText.Size = new System.Drawing.Size(247, 36);
            this.addUserEmailText.TabIndex = 4;
            this.addUserEmailText.TextChanged += new System.EventHandler(this.addUserEmailText_TextChanged);
            // 
            // addUserMobileText
            // 
            this.addUserMobileText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserMobileText.BorderRadius = 8;
            this.addUserMobileText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUserMobileText.DefaultText = "";
            this.addUserMobileText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUserMobileText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUserMobileText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserMobileText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserMobileText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserMobileText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserMobileText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserMobileText.Location = new System.Drawing.Point(550, 22);
            this.addUserMobileText.Name = "addUserMobileText";
            this.addUserMobileText.PasswordChar = '\0';
            this.addUserMobileText.PlaceholderText = "Enter User Phone";
            this.addUserMobileText.SelectedText = "";
            this.addUserMobileText.Size = new System.Drawing.Size(247, 36);
            this.addUserMobileText.TabIndex = 3;
            this.addUserMobileText.TextChanged += new System.EventHandler(this.addUserMobileText_TextChanged);
            // 
            // addUserCodeText
            // 
            this.addUserCodeText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserCodeText.BorderRadius = 8;
            this.addUserCodeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUserCodeText.DefaultText = "";
            this.addUserCodeText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUserCodeText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUserCodeText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserCodeText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserCodeText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserCodeText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserCodeText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserCodeText.Location = new System.Drawing.Point(281, 22);
            this.addUserCodeText.Name = "addUserCodeText";
            this.addUserCodeText.PasswordChar = '\0';
            this.addUserCodeText.PlaceholderText = "Enter User Code";
            this.addUserCodeText.SelectedText = "";
            this.addUserCodeText.Size = new System.Drawing.Size(247, 36);
            this.addUserCodeText.TabIndex = 2;
            this.addUserCodeText.TextChanged += new System.EventHandler(this.addUserCodeText_TextChanged);
            // 
            // addUserNameText
            // 
            this.addUserNameText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserNameText.BorderRadius = 8;
            this.addUserNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUserNameText.DefaultText = "";
            this.addUserNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUserNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUserNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserNameText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserNameText.Location = new System.Drawing.Point(12, 22);
            this.addUserNameText.Name = "addUserNameText";
            this.addUserNameText.PasswordChar = '\0';
            this.addUserNameText.PlaceholderText = "Enter User Name";
            this.addUserNameText.SelectedText = "";
            this.addUserNameText.Size = new System.Drawing.Size(247, 36);
            this.addUserNameText.TabIndex = 1;
            this.addUserNameText.TextChanged += new System.EventHandler(this.addUserNameText_TextChanged);
            // 
            // generalinfoLabel
            // 
            this.generalinfoLabel.AutoSize = true;
            this.generalinfoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalinfoLabel.Location = new System.Drawing.Point(40, 81);
            this.generalinfoLabel.Name = "generalinfoLabel";
            this.generalinfoLabel.Size = new System.Drawing.Size(122, 14);
            this.generalinfoLabel.TabIndex = 4;
            this.generalinfoLabel.Text = "General Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Address";
            // 
            // userAddressPanel
            // 
            this.userAddressPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userAddressPanel.BorderRadius = 8;
            this.userAddressPanel.BorderThickness = 1;
            this.userAddressPanel.Controls.Add(this.addUserPostalText);
            this.userAddressPanel.Controls.Add(this.addUserCityText);
            this.userAddressPanel.Controls.Add(this.addUserStreetText);
            this.userAddressPanel.Location = new System.Drawing.Point(15, 321);
            this.userAddressPanel.Name = "userAddressPanel";
            this.userAddressPanel.Size = new System.Drawing.Size(810, 81);
            this.userAddressPanel.TabIndex = 5;
            // 
            // addUserPostalText
            // 
            this.addUserPostalText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserPostalText.BorderRadius = 8;
            this.addUserPostalText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUserPostalText.DefaultText = "";
            this.addUserPostalText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUserPostalText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUserPostalText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserPostalText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserPostalText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserPostalText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserPostalText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserPostalText.Location = new System.Drawing.Point(550, 22);
            this.addUserPostalText.Name = "addUserPostalText";
            this.addUserPostalText.PasswordChar = '\0';
            this.addUserPostalText.PlaceholderText = "Enter User Postal Code";
            this.addUserPostalText.SelectedText = "";
            this.addUserPostalText.Size = new System.Drawing.Size(247, 36);
            this.addUserPostalText.TabIndex = 3;
            this.addUserPostalText.TextChanged += new System.EventHandler(this.addUserPostalText_TextChanged);
            // 
            // addUserCityText
            // 
            this.addUserCityText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserCityText.BorderRadius = 8;
            this.addUserCityText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUserCityText.DefaultText = "";
            this.addUserCityText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUserCityText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUserCityText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserCityText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserCityText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserCityText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserCityText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserCityText.Location = new System.Drawing.Point(281, 22);
            this.addUserCityText.Name = "addUserCityText";
            this.addUserCityText.PasswordChar = '\0';
            this.addUserCityText.PlaceholderText = "Enter User City";
            this.addUserCityText.SelectedText = "";
            this.addUserCityText.Size = new System.Drawing.Size(247, 36);
            this.addUserCityText.TabIndex = 2;
            this.addUserCityText.TextChanged += new System.EventHandler(this.addUserCityText_TextChanged);
            // 
            // addUserStreetText
            // 
            this.addUserStreetText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserStreetText.BorderRadius = 8;
            this.addUserStreetText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUserStreetText.DefaultText = "";
            this.addUserStreetText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUserStreetText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUserStreetText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserStreetText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserStreetText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserStreetText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserStreetText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserStreetText.Location = new System.Drawing.Point(12, 22);
            this.addUserStreetText.Name = "addUserStreetText";
            this.addUserStreetText.PasswordChar = '\0';
            this.addUserStreetText.PlaceholderText = "Enter User Street";
            this.addUserStreetText.SelectedText = "";
            this.addUserStreetText.Size = new System.Drawing.Size(247, 36);
            this.addUserStreetText.TabIndex = 1;
            this.addUserStreetText.TextChanged += new System.EventHandler(this.addUserStreetText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Additional Details";
            // 
            // userAdditionalPanel
            // 
            this.userAdditionalPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userAdditionalPanel.BorderRadius = 8;
            this.userAdditionalPanel.BorderThickness = 1;
            this.userAdditionalPanel.Controls.Add(this.addUserStatusCombo);
            this.userAdditionalPanel.Controls.Add(this.addUserEPFText);
            this.userAdditionalPanel.Controls.Add(this.addUserDateText);
            this.userAdditionalPanel.Location = new System.Drawing.Point(15, 433);
            this.userAdditionalPanel.Name = "userAdditionalPanel";
            this.userAdditionalPanel.Size = new System.Drawing.Size(810, 81);
            this.userAdditionalPanel.TabIndex = 7;
            // 
            // addUserStatusCombo
            // 
            this.addUserStatusCombo.BackColor = System.Drawing.Color.Transparent;
            this.addUserStatusCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserStatusCombo.BorderRadius = 8;
            this.addUserStatusCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.addUserStatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addUserStatusCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserStatusCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserStatusCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserStatusCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.addUserStatusCombo.ItemHeight = 30;
            this.addUserStatusCombo.Items.AddRange(new object[] {
            "Select Status",
            "Owner",
            "Cashier"});
            this.addUserStatusCombo.Location = new System.Drawing.Point(282, 22);
            this.addUserStatusCombo.Name = "addUserStatusCombo";
            this.addUserStatusCombo.Size = new System.Drawing.Size(247, 36);
            this.addUserStatusCombo.StartIndex = 0;
            this.addUserStatusCombo.TabIndex = 8;
            this.addUserStatusCombo.SelectedIndexChanged += new System.EventHandler(this.addUserStatusCombo_SelectedIndexChanged);
            // 
            // addUserEPFText
            // 
            this.addUserEPFText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserEPFText.BorderRadius = 8;
            this.addUserEPFText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUserEPFText.DefaultText = "";
            this.addUserEPFText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUserEPFText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUserEPFText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserEPFText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserEPFText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserEPFText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserEPFText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserEPFText.Location = new System.Drawing.Point(550, 22);
            this.addUserEPFText.Name = "addUserEPFText";
            this.addUserEPFText.PasswordChar = '\0';
            this.addUserEPFText.PlaceholderText = "Enter User EPF Number";
            this.addUserEPFText.SelectedText = "";
            this.addUserEPFText.Size = new System.Drawing.Size(247, 36);
            this.addUserEPFText.TabIndex = 3;
            this.addUserEPFText.TextChanged += new System.EventHandler(this.addUserEPFText_TextChanged);
            // 
            // addUserDateText
            // 
            this.addUserDateText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addUserDateText.BorderRadius = 8;
            this.addUserDateText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addUserDateText.DefaultText = "";
            this.addUserDateText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addUserDateText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addUserDateText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserDateText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addUserDateText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserDateText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addUserDateText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addUserDateText.Location = new System.Drawing.Point(12, 22);
            this.addUserDateText.Name = "addUserDateText";
            this.addUserDateText.PasswordChar = '\0';
            this.addUserDateText.PlaceholderText = "Enter Date Of Joining";
            this.addUserDateText.SelectedText = "";
            this.addUserDateText.Size = new System.Drawing.Size(247, 36);
            this.addUserDateText.TabIndex = 1;
            this.addUserDateText.TextChanged += new System.EventHandler(this.addUserDateText_TextChanged);
            // 
            // userSaveBtn
            // 
            this.userSaveBtn.BorderRadius = 8;
            this.userSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.userSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.userSaveBtn.ForeColor = System.Drawing.Color.White;
            this.userSaveBtn.Location = new System.Drawing.Point(584, 541);
            this.userSaveBtn.Name = "userSaveBtn";
            this.userSaveBtn.Size = new System.Drawing.Size(106, 45);
            this.userSaveBtn.TabIndex = 9;
            this.userSaveBtn.Text = "Save";
            this.userSaveBtn.Click += new System.EventHandler(this.userSaveBtn_Click);
            // 
            // userResetBtn
            // 
            this.userResetBtn.BorderRadius = 8;
            this.userResetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userResetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userResetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userResetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userResetBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userResetBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.userResetBtn.ForeColor = System.Drawing.Color.White;
            this.userResetBtn.Location = new System.Drawing.Point(719, 541);
            this.userResetBtn.Name = "userResetBtn";
            this.userResetBtn.Size = new System.Drawing.Size(106, 45);
            this.userResetBtn.TabIndex = 10;
            this.userResetBtn.Text = "Reset";
            this.userResetBtn.Click += new System.EventHandler(this.userResetBtn_Click);
            // 
            // addUserBorderlessForm
            // 
            this.addUserBorderlessForm.BorderRadius = 25;
            this.addUserBorderlessForm.ContainerControl = this;
            this.addUserBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.addUserBorderlessForm.TransparentWhileDrag = true;
            // 
            // userAnimateWindow
            // 
            this.userAnimateWindow.TargetForm = this;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 598);
            this.Controls.Add(this.userResetBtn);
            this.Controls.Add(this.userSaveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userAdditionalPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userAddressPanel);
            this.Controls.Add(this.generalinfoLabel);
            this.Controls.Add(this.userGinfoPanel);
            this.Controls.Add(this.addUserLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.userGinfoPanel.ResumeLayout(false);
            this.userAddressPanel.ResumeLayout(false);
            this.userAdditionalPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox maximumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private System.Windows.Forms.Label addUserLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel userGinfoPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addUserNameText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addUserMobileText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addUserCodeText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addUserDOBText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addUserEmailText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox addUserRoleCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox addUserGenderCombo;
        private System.Windows.Forms.Label generalinfoLabel;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel userAddressPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addUserPostalText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addUserCityText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addUserStreetText;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel userAdditionalPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addUserEPFText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addUserDateText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox addUserStatusCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userResetBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm addUserBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow userAnimateWindow;
    }
}