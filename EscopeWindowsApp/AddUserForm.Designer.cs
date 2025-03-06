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
            this.addUserBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.userAnimateWindow = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.createUserLabel = new System.Windows.Forms.Label();
            this.createUserFirstLabel = new System.Windows.Forms.Label();
            this.createUserFirstText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createUserLastLabel = new System.Windows.Forms.Label();
            this.createUserEmailLabel = new System.Windows.Forms.Label();
            this.createUserPhoneLabel = new System.Windows.Forms.Label();
            this.createUserPasLabel = new System.Windows.Forms.Label();
            this.createUserCpassLabel = new System.Windows.Forms.Label();
            this.createUserRoleLabel = new System.Windows.Forms.Label();
            this.createUserPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.CreateUserRoleCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.createUserCpassText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createUserPassText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createUserEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createUserPhoneText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createUserLastText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.createSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.createUserPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.userAnimateWindow.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.userAnimateWindow.Interval = 50;
            this.userAnimateWindow.TargetForm = this;
            // 
            // createUserLabel
            // 
            this.createUserLabel.AutoSize = true;
            this.createUserLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserLabel.Location = new System.Drawing.Point(18, 50);
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
            this.createUserFirstLabel.Location = new System.Drawing.Point(15, 21);
            this.createUserFirstLabel.Name = "createUserFirstLabel";
            this.createUserFirstLabel.Size = new System.Drawing.Size(98, 23);
            this.createUserFirstLabel.TabIndex = 18;
            this.createUserFirstLabel.Text = "First Name:";
            // 
            // createUserFirstText
            // 
            this.createUserFirstText.BackColor = System.Drawing.Color.Transparent;
            this.createUserFirstText.BorderColor = System.Drawing.Color.Gray;
            this.createUserFirstText.BorderRadius = 8;
            this.createUserFirstText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createUserFirstText.DefaultText = "";
            this.createUserFirstText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createUserFirstText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createUserFirstText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserFirstText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserFirstText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserFirstText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createUserFirstText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createUserFirstText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserFirstText.Location = new System.Drawing.Point(19, 52);
            this.createUserFirstText.Name = "createUserFirstText";
            this.createUserFirstText.PasswordChar = '\0';
            this.createUserFirstText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createUserFirstText.PlaceholderText = "Enter First Name";
            this.createUserFirstText.SelectedText = "";
            this.createUserFirstText.Size = new System.Drawing.Size(443, 42);
            this.createUserFirstText.TabIndex = 1;
            this.createUserFirstText.TextChanged += new System.EventHandler(this.addUserNameText_TextChanged);
            // 
            // createUserLastLabel
            // 
            this.createUserLastLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createUserLastLabel.AutoSize = true;
            this.createUserLastLabel.BackColor = System.Drawing.Color.White;
            this.createUserLastLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserLastLabel.Location = new System.Drawing.Point(490, 21);
            this.createUserLastLabel.Name = "createUserLastLabel";
            this.createUserLastLabel.Size = new System.Drawing.Size(95, 23);
            this.createUserLastLabel.TabIndex = 19;
            this.createUserLastLabel.Text = "Last Name:";
            // 
            // createUserEmailLabel
            // 
            this.createUserEmailLabel.AutoSize = true;
            this.createUserEmailLabel.BackColor = System.Drawing.Color.White;
            this.createUserEmailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserEmailLabel.Location = new System.Drawing.Point(16, 115);
            this.createUserEmailLabel.Name = "createUserEmailLabel";
            this.createUserEmailLabel.Size = new System.Drawing.Size(56, 23);
            this.createUserEmailLabel.TabIndex = 20;
            this.createUserEmailLabel.Text = "Email:";
            // 
            // createUserPhoneLabel
            // 
            this.createUserPhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createUserPhoneLabel.AutoSize = true;
            this.createUserPhoneLabel.BackColor = System.Drawing.Color.White;
            this.createUserPhoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserPhoneLabel.Location = new System.Drawing.Point(490, 115);
            this.createUserPhoneLabel.Name = "createUserPhoneLabel";
            this.createUserPhoneLabel.Size = new System.Drawing.Size(131, 23);
            this.createUserPhoneLabel.TabIndex = 21;
            this.createUserPhoneLabel.Text = "Phone Number:";
            // 
            // createUserPasLabel
            // 
            this.createUserPasLabel.AutoSize = true;
            this.createUserPasLabel.BackColor = System.Drawing.Color.White;
            this.createUserPasLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserPasLabel.Location = new System.Drawing.Point(15, 215);
            this.createUserPasLabel.Name = "createUserPasLabel";
            this.createUserPasLabel.Size = new System.Drawing.Size(91, 23);
            this.createUserPasLabel.TabIndex = 22;
            this.createUserPasLabel.Text = "Password:";
            // 
            // createUserCpassLabel
            // 
            this.createUserCpassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createUserCpassLabel.AutoSize = true;
            this.createUserCpassLabel.BackColor = System.Drawing.Color.White;
            this.createUserCpassLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserCpassLabel.Location = new System.Drawing.Point(490, 215);
            this.createUserCpassLabel.Name = "createUserCpassLabel";
            this.createUserCpassLabel.Size = new System.Drawing.Size(157, 23);
            this.createUserCpassLabel.TabIndex = 23;
            this.createUserCpassLabel.Text = "Confirm Password:";
            // 
            // createUserRoleLabel
            // 
            this.createUserRoleLabel.AutoSize = true;
            this.createUserRoleLabel.BackColor = System.Drawing.Color.White;
            this.createUserRoleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserRoleLabel.Location = new System.Drawing.Point(15, 311);
            this.createUserRoleLabel.Name = "createUserRoleLabel";
            this.createUserRoleLabel.Size = new System.Drawing.Size(48, 23);
            this.createUserRoleLabel.TabIndex = 24;
            this.createUserRoleLabel.Text = "Role:";
            // 
            // createUserPanel
            // 
            this.createUserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createUserPanel.BorderRadius = 8;
            this.createUserPanel.Controls.Add(this.CreateUserRoleCombo);
            this.createUserPanel.Controls.Add(this.createUserCpassText);
            this.createUserPanel.Controls.Add(this.createUserPassText);
            this.createUserPanel.Controls.Add(this.createUserEmailText);
            this.createUserPanel.Controls.Add(this.createUserPhoneText);
            this.createUserPanel.Controls.Add(this.createUserLastText);
            this.createUserPanel.Controls.Add(this.createUserRoleLabel);
            this.createUserPanel.Controls.Add(this.createUserCpassLabel);
            this.createUserPanel.Controls.Add(this.createUserPasLabel);
            this.createUserPanel.Controls.Add(this.createUserPhoneLabel);
            this.createUserPanel.Controls.Add(this.createUserEmailLabel);
            this.createUserPanel.Controls.Add(this.createUserLastLabel);
            this.createUserPanel.Controls.Add(this.createUserFirstText);
            this.createUserPanel.Controls.Add(this.createUserFirstLabel);
            this.createUserPanel.FillColor = System.Drawing.Color.White;
            this.createUserPanel.Location = new System.Drawing.Point(23, 96);
            this.createUserPanel.Name = "createUserPanel";
            this.createUserPanel.Size = new System.Drawing.Size(956, 415);
            this.createUserPanel.TabIndex = 19;
            // 
            // CreateUserRoleCombo
            // 
            this.CreateUserRoleCombo.BackColor = System.Drawing.Color.Transparent;
            this.CreateUserRoleCombo.BorderColor = System.Drawing.Color.Gray;
            this.CreateUserRoleCombo.BorderRadius = 8;
            this.CreateUserRoleCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CreateUserRoleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreateUserRoleCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreateUserRoleCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreateUserRoleCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CreateUserRoleCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateUserRoleCombo.ItemHeight = 30;
            this.CreateUserRoleCombo.Items.AddRange(new object[] {
            "Select your Role",
            "Cashier",
            "Owner",
            "Manger"});
            this.CreateUserRoleCombo.Location = new System.Drawing.Point(19, 346);
            this.CreateUserRoleCombo.Name = "CreateUserRoleCombo";
            this.CreateUserRoleCombo.Size = new System.Drawing.Size(443, 36);
            this.CreateUserRoleCombo.StartIndex = 0;
            this.CreateUserRoleCombo.TabIndex = 30;
            this.CreateUserRoleCombo.SelectedIndexChanged += new System.EventHandler(this.CreateUserRoleCombo_SelectedIndexChanged);
            // 
            // createUserCpassText
            // 
            this.createUserCpassText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createUserCpassText.BackColor = System.Drawing.Color.Transparent;
            this.createUserCpassText.BorderColor = System.Drawing.Color.Gray;
            this.createUserCpassText.BorderRadius = 8;
            this.createUserCpassText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createUserCpassText.DefaultText = "";
            this.createUserCpassText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createUserCpassText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createUserCpassText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserCpassText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserCpassText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserCpassText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createUserCpassText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createUserCpassText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserCpassText.Location = new System.Drawing.Point(494, 250);
            this.createUserCpassText.Name = "createUserCpassText";
            this.createUserCpassText.PasswordChar = '\0';
            this.createUserCpassText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createUserCpassText.PlaceholderText = "Confirm Your Password";
            this.createUserCpassText.SelectedText = "";
            this.createUserCpassText.Size = new System.Drawing.Size(443, 42);
            this.createUserCpassText.TabIndex = 29;
            this.createUserCpassText.TextChanged += new System.EventHandler(this.createUserCpassText_TextChanged);
            // 
            // createUserPassText
            // 
            this.createUserPassText.BackColor = System.Drawing.Color.Transparent;
            this.createUserPassText.BorderColor = System.Drawing.Color.Gray;
            this.createUserPassText.BorderRadius = 8;
            this.createUserPassText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createUserPassText.DefaultText = "";
            this.createUserPassText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createUserPassText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createUserPassText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserPassText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserPassText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserPassText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createUserPassText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createUserPassText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserPassText.Location = new System.Drawing.Point(21, 250);
            this.createUserPassText.Name = "createUserPassText";
            this.createUserPassText.PasswordChar = '\0';
            this.createUserPassText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createUserPassText.PlaceholderText = "Enter Password";
            this.createUserPassText.SelectedText = "";
            this.createUserPassText.Size = new System.Drawing.Size(441, 42);
            this.createUserPassText.TabIndex = 28;
            this.createUserPassText.TextChanged += new System.EventHandler(this.createUserPassText_TextChanged);
            // 
            // createUserEmailText
            // 
            this.createUserEmailText.BackColor = System.Drawing.Color.Transparent;
            this.createUserEmailText.BorderColor = System.Drawing.Color.Gray;
            this.createUserEmailText.BorderRadius = 8;
            this.createUserEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createUserEmailText.DefaultText = "";
            this.createUserEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createUserEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createUserEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserEmailText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createUserEmailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createUserEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserEmailText.Location = new System.Drawing.Point(21, 149);
            this.createUserEmailText.Name = "createUserEmailText";
            this.createUserEmailText.PasswordChar = '\0';
            this.createUserEmailText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createUserEmailText.PlaceholderText = "Enter Email";
            this.createUserEmailText.SelectedText = "";
            this.createUserEmailText.Size = new System.Drawing.Size(441, 42);
            this.createUserEmailText.TabIndex = 27;
            this.createUserEmailText.TextChanged += new System.EventHandler(this.createUserEmailText_TextChanged);
            // 
            // createUserPhoneText
            // 
            this.createUserPhoneText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createUserPhoneText.BackColor = System.Drawing.Color.Transparent;
            this.createUserPhoneText.BorderColor = System.Drawing.Color.Gray;
            this.createUserPhoneText.BorderRadius = 8;
            this.createUserPhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createUserPhoneText.DefaultText = "";
            this.createUserPhoneText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createUserPhoneText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createUserPhoneText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserPhoneText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserPhoneText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserPhoneText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createUserPhoneText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createUserPhoneText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserPhoneText.Location = new System.Drawing.Point(494, 149);
            this.createUserPhoneText.Name = "createUserPhoneText";
            this.createUserPhoneText.PasswordChar = '\0';
            this.createUserPhoneText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createUserPhoneText.PlaceholderText = "Enter Phone Number";
            this.createUserPhoneText.SelectedText = "";
            this.createUserPhoneText.Size = new System.Drawing.Size(443, 42);
            this.createUserPhoneText.TabIndex = 26;
            this.createUserPhoneText.TextChanged += new System.EventHandler(this.createUserPhoneText_TextChanged);
            // 
            // createUserLastText
            // 
            this.createUserLastText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createUserLastText.BackColor = System.Drawing.Color.Transparent;
            this.createUserLastText.BorderColor = System.Drawing.Color.Gray;
            this.createUserLastText.BorderRadius = 8;
            this.createUserLastText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createUserLastText.DefaultText = "";
            this.createUserLastText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createUserLastText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createUserLastText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserLastText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createUserLastText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserLastText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createUserLastText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createUserLastText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createUserLastText.Location = new System.Drawing.Point(494, 52);
            this.createUserLastText.Name = "createUserLastText";
            this.createUserLastText.PasswordChar = '\0';
            this.createUserLastText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createUserLastText.PlaceholderText = "Enter Last Name";
            this.createUserLastText.SelectedText = "";
            this.createUserLastText.Size = new System.Drawing.Size(443, 42);
            this.createUserLastText.TabIndex = 25;
            this.createUserLastText.TextChanged += new System.EventHandler(this.createUserLastText_TextChanged);
            // 
            // createCancelBtn
            // 
            this.createCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createCancelBtn.Animated = true;
            this.createCancelBtn.BorderRadius = 8;
            this.createCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.createCancelBtn.ForeColor = System.Drawing.Color.White;
            this.createCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.createCancelBtn.Location = new System.Drawing.Point(884, 532);
            this.createCancelBtn.Name = "createCancelBtn";
            this.createCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.createCancelBtn.TabIndex = 32;
            this.createCancelBtn.Text = "Cancel";
            this.createCancelBtn.Click += new System.EventHandler(this.createCancelBtn_Click);
            // 
            // createSaveBtn
            // 
            this.createSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createSaveBtn.Animated = true;
            this.createSaveBtn.BorderRadius = 8;
            this.createSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSaveBtn.ForeColor = System.Drawing.Color.White;
            this.createSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createSaveBtn.Location = new System.Drawing.Point(779, 532);
            this.createSaveBtn.Name = "createSaveBtn";
            this.createSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.createSaveBtn.TabIndex = 31;
            this.createSaveBtn.Text = "Save";
            this.createSaveBtn.Click += new System.EventHandler(this.createSaveBtn_Click);
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
            this.headerPanel.TabIndex = 33;
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
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.createCancelBtn);
            this.Controls.Add(this.createSaveBtn);
            this.Controls.Add(this.createUserPanel);
            this.Controls.Add(this.createUserLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.createUserPanel.ResumeLayout(false);
            this.createUserPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm addUserBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow userAnimateWindow;
        private System.Windows.Forms.Label createUserLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel createUserPanel;
        private System.Windows.Forms.Label createUserRoleLabel;
        private System.Windows.Forms.Label createUserCpassLabel;
        private System.Windows.Forms.Label createUserPasLabel;
        private System.Windows.Forms.Label createUserPhoneLabel;
        private System.Windows.Forms.Label createUserEmailLabel;
        private System.Windows.Forms.Label createUserLastLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createUserFirstText;
        private System.Windows.Forms.Label createUserFirstLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createUserCpassText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createUserPassText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createUserEmailText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createUserPhoneText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createUserLastText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox CreateUserRoleCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
    }
}