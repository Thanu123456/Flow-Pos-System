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
            this.createUserRoleCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.createUserEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.cretaeUserPhoneText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createUserLastText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createUserFirstText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createUserCpassText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createUserPasText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addUserBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.userAnimateWindow = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.createUserLabel = new System.Windows.Forms.Label();
            this.createUserFirstLabel = new System.Windows.Forms.Label();
            this.createUserPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.userCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.createUserRoleLabel = new System.Windows.Forms.Label();
            this.createUserCpassLabel = new System.Windows.Forms.Label();
            this.createUserPasLabel = new System.Windows.Forms.Label();
            this.createUserPhoneLabel = new System.Windows.Forms.Label();
            this.createUserEmailLabel = new System.Windows.Forms.Label();
            this.createUserLastLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.createUserPanel.SuspendLayout();
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
            this.headerPanel.TabIndex = 1;
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
            // createUserRoleCombo
            // 
            this.createUserRoleCombo.BackColor = System.Drawing.Color.Transparent;
            this.createUserRoleCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createUserRoleCombo.BorderRadius = 8;
            this.createUserRoleCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.createUserRoleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createUserRoleCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserRoleCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserRoleCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createUserRoleCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.createUserRoleCombo.ItemHeight = 30;
            this.createUserRoleCombo.Items.AddRange(new object[] {
            "Add Role",
            "Owner",
            "Cashier"});
            this.createUserRoleCombo.Location = new System.Drawing.Point(24, 393);
            this.createUserRoleCombo.Name = "createUserRoleCombo";
            this.createUserRoleCombo.Size = new System.Drawing.Size(400, 36);
            this.createUserRoleCombo.StartIndex = 0;
            this.createUserRoleCombo.TabIndex = 7;
            this.createUserRoleCombo.SelectedIndexChanged += new System.EventHandler(this.siticoneComboBox1_SelectedIndexChanged);
            // 
            // createUserEmailText
            // 
            this.createUserEmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createUserEmailText.BorderRadius = 8;
            this.createUserEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createUserEmailText.DefaultText = "";
            this.createUserEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createUserEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createUserEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserEmailText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createUserEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserEmailText.Location = new System.Drawing.Point(24, 175);
            this.createUserEmailText.Name = "createUserEmailText";
            this.createUserEmailText.PasswordChar = '\0';
            this.createUserEmailText.PlaceholderText = "Enter User Email";
            this.createUserEmailText.SelectedText = "";
            this.createUserEmailText.Size = new System.Drawing.Size(400, 42);
            this.createUserEmailText.TabIndex = 4;
            this.createUserEmailText.TextChanged += new System.EventHandler(this.addUserEmailText_TextChanged);
            // 
            // cretaeUserPhoneText
            // 
            this.cretaeUserPhoneText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cretaeUserPhoneText.BorderRadius = 8;
            this.cretaeUserPhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cretaeUserPhoneText.DefaultText = "";
            this.cretaeUserPhoneText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cretaeUserPhoneText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cretaeUserPhoneText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cretaeUserPhoneText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cretaeUserPhoneText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cretaeUserPhoneText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cretaeUserPhoneText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cretaeUserPhoneText.Location = new System.Drawing.Point(507, 175);
            this.cretaeUserPhoneText.Name = "cretaeUserPhoneText";
            this.cretaeUserPhoneText.PasswordChar = '\0';
            this.cretaeUserPhoneText.PlaceholderText = "Enter User Phone";
            this.cretaeUserPhoneText.SelectedText = "";
            this.cretaeUserPhoneText.Size = new System.Drawing.Size(400, 42);
            this.cretaeUserPhoneText.TabIndex = 3;
            this.cretaeUserPhoneText.TextChanged += new System.EventHandler(this.addUserMobileText_TextChanged);
            // 
            // createUserLastText
            // 
            this.createUserLastText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createUserLastText.BorderRadius = 8;
            this.createUserLastText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createUserLastText.DefaultText = "";
            this.createUserLastText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createUserLastText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createUserLastText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserLastText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserLastText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserLastText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createUserLastText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserLastText.Location = new System.Drawing.Point(507, 64);
            this.createUserLastText.Name = "createUserLastText";
            this.createUserLastText.PasswordChar = '\0';
            this.createUserLastText.PlaceholderText = "Enter Last Name";
            this.createUserLastText.SelectedText = "";
            this.createUserLastText.Size = new System.Drawing.Size(400, 42);
            this.createUserLastText.TabIndex = 2;
            this.createUserLastText.TextChanged += new System.EventHandler(this.addUserCodeText_TextChanged);
            // 
            // createUserFirstText
            // 
            this.createUserFirstText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createUserFirstText.BorderRadius = 8;
            this.createUserFirstText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createUserFirstText.DefaultText = "";
            this.createUserFirstText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createUserFirstText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createUserFirstText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserFirstText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserFirstText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserFirstText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createUserFirstText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserFirstText.Location = new System.Drawing.Point(24, 64);
            this.createUserFirstText.Name = "createUserFirstText";
            this.createUserFirstText.PasswordChar = '\0';
            this.createUserFirstText.PlaceholderText = "Enter First Name";
            this.createUserFirstText.SelectedText = "";
            this.createUserFirstText.Size = new System.Drawing.Size(400, 42);
            this.createUserFirstText.TabIndex = 1;
            this.createUserFirstText.TextChanged += new System.EventHandler(this.addUserNameText_TextChanged);
            // 
            // createUserCpassText
            // 
            this.createUserCpassText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createUserCpassText.BorderRadius = 8;
            this.createUserCpassText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createUserCpassText.DefaultText = "";
            this.createUserCpassText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createUserCpassText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createUserCpassText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserCpassText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserCpassText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserCpassText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createUserCpassText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserCpassText.Location = new System.Drawing.Point(507, 285);
            this.createUserCpassText.Name = "createUserCpassText";
            this.createUserCpassText.PasswordChar = '\0';
            this.createUserCpassText.PlaceholderText = "Confirm User Password";
            this.createUserCpassText.SelectedText = "";
            this.createUserCpassText.Size = new System.Drawing.Size(400, 42);
            this.createUserCpassText.TabIndex = 2;
            this.createUserCpassText.TextChanged += new System.EventHandler(this.addUserCityText_TextChanged);
            // 
            // createUserPasText
            // 
            this.createUserPasText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createUserPasText.BorderRadius = 8;
            this.createUserPasText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createUserPasText.DefaultText = "";
            this.createUserPasText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createUserPasText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createUserPasText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserPasText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserPasText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserPasText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createUserPasText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserPasText.Location = new System.Drawing.Point(24, 285);
            this.createUserPasText.Name = "createUserPasText";
            this.createUserPasText.PasswordChar = '\0';
            this.createUserPasText.PlaceholderText = "Enter User Password";
            this.createUserPasText.SelectedText = "";
            this.createUserPasText.Size = new System.Drawing.Size(400, 42);
            this.createUserPasText.TabIndex = 1;
            this.createUserPasText.TextChanged += new System.EventHandler(this.addUserStreetText_TextChanged);
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
            // createUserLabel
            // 
            this.createUserLabel.AutoSize = true;
            this.createUserLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserLabel.Location = new System.Drawing.Point(29, 53);
            this.createUserLabel.Name = "createUserLabel";
            this.createUserLabel.Size = new System.Drawing.Size(153, 28);
            this.createUserLabel.TabIndex = 17;
            this.createUserLabel.Text = "Create User";
            // 
            // createUserFirstLabel
            // 
            this.createUserFirstLabel.AutoSize = true;
            this.createUserFirstLabel.BackColor = System.Drawing.Color.White;
            this.createUserFirstLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserFirstLabel.Location = new System.Drawing.Point(20, 28);
            this.createUserFirstLabel.Name = "createUserFirstLabel";
            this.createUserFirstLabel.Size = new System.Drawing.Size(98, 23);
            this.createUserFirstLabel.TabIndex = 18;
            this.createUserFirstLabel.Text = "First Name:";
            // 
            // createUserPanel
            // 
            this.createUserPanel.BorderRadius = 8;
            this.createUserPanel.Controls.Add(this.userCancelBtn);
            this.createUserPanel.Controls.Add(this.userSaveBtn);
            this.createUserPanel.Controls.Add(this.createUserRoleLabel);
            this.createUserPanel.Controls.Add(this.createUserCpassLabel);
            this.createUserPanel.Controls.Add(this.createUserPasLabel);
            this.createUserPanel.Controls.Add(this.createUserPhoneLabel);
            this.createUserPanel.Controls.Add(this.createUserCpassText);
            this.createUserPanel.Controls.Add(this.createUserEmailLabel);
            this.createUserPanel.Controls.Add(this.createUserPasText);
            this.createUserPanel.Controls.Add(this.createUserRoleCombo);
            this.createUserPanel.Controls.Add(this.createUserLastLabel);
            this.createUserPanel.Controls.Add(this.createUserFirstText);
            this.createUserPanel.Controls.Add(this.createUserFirstLabel);
            this.createUserPanel.Controls.Add(this.createUserLastText);
            this.createUserPanel.Controls.Add(this.cretaeUserPhoneText);
            this.createUserPanel.Controls.Add(this.createUserEmailText);
            this.createUserPanel.FillColor = System.Drawing.Color.White;
            this.createUserPanel.Location = new System.Drawing.Point(34, 108);
            this.createUserPanel.Name = "createUserPanel";
            this.createUserPanel.Size = new System.Drawing.Size(928, 562);
            this.createUserPanel.TabIndex = 19;
            // 
            // userCancelBtn
            // 
            this.userCancelBtn.BorderRadius = 8;
            this.userCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userCancelBtn.FillColor = System.Drawing.Color.DarkGray;
            this.userCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.userCancelBtn.ForeColor = System.Drawing.Color.White;
            this.userCancelBtn.Location = new System.Drawing.Point(811, 493);
            this.userCancelBtn.Name = "userCancelBtn";
            this.userCancelBtn.Size = new System.Drawing.Size(93, 47);
            this.userCancelBtn.TabIndex = 28;
            this.userCancelBtn.Text = "Cancel";
            // 
            // userSaveBtn
            // 
            this.userSaveBtn.BorderRadius = 8;
            this.userSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.userSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSaveBtn.ForeColor = System.Drawing.Color.White;
            this.userSaveBtn.Location = new System.Drawing.Point(695, 493);
            this.userSaveBtn.Name = "userSaveBtn";
            this.userSaveBtn.Size = new System.Drawing.Size(93, 47);
            this.userSaveBtn.TabIndex = 27;
            this.userSaveBtn.Text = "Save";
            // 
            // createUserRoleLabel
            // 
            this.createUserRoleLabel.AutoSize = true;
            this.createUserRoleLabel.BackColor = System.Drawing.Color.White;
            this.createUserRoleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserRoleLabel.Location = new System.Drawing.Point(20, 355);
            this.createUserRoleLabel.Name = "createUserRoleLabel";
            this.createUserRoleLabel.Size = new System.Drawing.Size(48, 23);
            this.createUserRoleLabel.TabIndex = 24;
            this.createUserRoleLabel.Text = "Role:";
            // 
            // createUserCpassLabel
            // 
            this.createUserCpassLabel.AutoSize = true;
            this.createUserCpassLabel.BackColor = System.Drawing.Color.White;
            this.createUserCpassLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserCpassLabel.Location = new System.Drawing.Point(503, 248);
            this.createUserCpassLabel.Name = "createUserCpassLabel";
            this.createUserCpassLabel.Size = new System.Drawing.Size(157, 23);
            this.createUserCpassLabel.TabIndex = 23;
            this.createUserCpassLabel.Text = "Confirm Password:";
            // 
            // createUserPasLabel
            // 
            this.createUserPasLabel.AutoSize = true;
            this.createUserPasLabel.BackColor = System.Drawing.Color.White;
            this.createUserPasLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserPasLabel.Location = new System.Drawing.Point(20, 248);
            this.createUserPasLabel.Name = "createUserPasLabel";
            this.createUserPasLabel.Size = new System.Drawing.Size(91, 23);
            this.createUserPasLabel.TabIndex = 22;
            this.createUserPasLabel.Text = "Password:";
            // 
            // createUserPhoneLabel
            // 
            this.createUserPhoneLabel.AutoSize = true;
            this.createUserPhoneLabel.BackColor = System.Drawing.Color.White;
            this.createUserPhoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserPhoneLabel.Location = new System.Drawing.Point(503, 138);
            this.createUserPhoneLabel.Name = "createUserPhoneLabel";
            this.createUserPhoneLabel.Size = new System.Drawing.Size(131, 23);
            this.createUserPhoneLabel.TabIndex = 21;
            this.createUserPhoneLabel.Text = "Phone Number:";
            // 
            // createUserEmailLabel
            // 
            this.createUserEmailLabel.AutoSize = true;
            this.createUserEmailLabel.BackColor = System.Drawing.Color.White;
            this.createUserEmailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserEmailLabel.Location = new System.Drawing.Point(20, 138);
            this.createUserEmailLabel.Name = "createUserEmailLabel";
            this.createUserEmailLabel.Size = new System.Drawing.Size(56, 23);
            this.createUserEmailLabel.TabIndex = 20;
            this.createUserEmailLabel.Text = "Email:";
            // 
            // createUserLastLabel
            // 
            this.createUserLastLabel.AutoSize = true;
            this.createUserLastLabel.BackColor = System.Drawing.Color.White;
            this.createUserLastLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserLastLabel.Location = new System.Drawing.Point(503, 28);
            this.createUserLastLabel.Name = "createUserLastLabel";
            this.createUserLastLabel.Size = new System.Drawing.Size(95, 23);
            this.createUserLastLabel.TabIndex = 19;
            this.createUserLastLabel.Text = "Last Name:";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1000, 809);
            this.Controls.Add(this.createUserPanel);
            this.Controls.Add(this.createUserLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.createUserPanel.ResumeLayout(false);
            this.createUserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox maximumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createUserFirstText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox cretaeUserPhoneText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createUserLastText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createUserEmailText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox createUserRoleCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createUserCpassText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createUserPasText;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm addUserBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow userAnimateWindow;
        private System.Windows.Forms.Label createUserLabel;
        private System.Windows.Forms.Label createUserFirstLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel createUserPanel;
        private System.Windows.Forms.Label createUserLastLabel;
        private System.Windows.Forms.Label createUserPhoneLabel;
        private System.Windows.Forms.Label createUserEmailLabel;
        private System.Windows.Forms.Label createUserPasLabel;
        private System.Windows.Forms.Label createUserRoleLabel;
        private System.Windows.Forms.Label createUserCpassLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userSaveBtn;
    }
}