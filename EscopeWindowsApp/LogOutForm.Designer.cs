namespace EscopeWindowsApp
{
    partial class LogOutForm
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
            this.logOutBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.createBrandsCloseBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.userCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.UserLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.currentUserPasswordText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.newUserPasswordText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.reNewUserPasswordText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmPasswordBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.logOutBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutBorderlessForm
            // 
            this.logOutBorderlessForm.BorderRadius = 25;
            this.logOutBorderlessForm.ContainerControl = this;
            this.logOutBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.logOutBorderlessForm.TransparentWhileDrag = true;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(400, 34);
            this.headerPanel.TabIndex = 69;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.createBrandsCloseBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(335, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(65, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // createBrandsCloseBtn
            // 
            this.createBrandsCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createBrandsCloseBtn.BorderRadius = 8;
            this.createBrandsCloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createBrandsCloseBtn.IconColor = System.Drawing.Color.White;
            this.createBrandsCloseBtn.Location = new System.Drawing.Point(16, 2);
            this.createBrandsCloseBtn.Name = "createBrandsCloseBtn";
            this.createBrandsCloseBtn.Size = new System.Drawing.Size(28, 26);
            this.createBrandsCloseBtn.TabIndex = 0;
            // 
            // userCirclePictureBox1
            // 
            this.userCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.userCirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.userCirclePictureBox1.Image = global::EscopeWindowsApp.Properties.Resources.avatar2;
            this.userCirclePictureBox1.ImageRotate = 0F;
            this.userCirclePictureBox1.Location = new System.Drawing.Point(12, 53);
            this.userCirclePictureBox1.Name = "userCirclePictureBox1";
            this.userCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.userCirclePictureBox1.Size = new System.Drawing.Size(108, 103);
            this.userCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userCirclePictureBox1.TabIndex = 70;
            this.userCirclePictureBox1.TabStop = false;
            this.userCirclePictureBox1.UseTransparentBackground = true;
            // 
            // UserLabel
            // 
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(140, 53);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(239, 31);
            this.UserLabel.TabIndex = 71;
            this.UserLabel.Text = "Welcome To Flow POS !";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.userNameLabel.Location = new System.Drawing.Point(136, 101);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(60, 23);
            this.userNameLabel.TabIndex = 72;
            this.userNameLabel.Text = "Name:";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.userEmailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.userEmailLabel.Location = new System.Drawing.Point(136, 133);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(56, 23);
            this.userEmailLabel.TabIndex = 73;
            this.userEmailLabel.Text = "Email:";
            this.userEmailLabel.Click += new System.EventHandler(this.userEmailLabel_Click);
            // 
            // currentUserPasswordText
            // 
            this.currentUserPasswordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentUserPasswordText.BackColor = System.Drawing.Color.Transparent;
            this.currentUserPasswordText.BorderColor = System.Drawing.Color.Gray;
            this.currentUserPasswordText.BorderRadius = 8;
            this.currentUserPasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentUserPasswordText.DefaultText = "";
            this.currentUserPasswordText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentUserPasswordText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentUserPasswordText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentUserPasswordText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentUserPasswordText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentUserPasswordText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserPasswordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentUserPasswordText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentUserPasswordText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.currentUserPasswordText.Location = new System.Drawing.Point(26, 211);
            this.currentUserPasswordText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentUserPasswordText.Name = "currentUserPasswordText";
            this.currentUserPasswordText.PasswordChar = '\0';
            this.currentUserPasswordText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.currentUserPasswordText.PlaceholderText = "Enter Your Current Password";
            this.currentUserPasswordText.SelectedText = "";
            this.currentUserPasswordText.Size = new System.Drawing.Size(348, 42);
            this.currentUserPasswordText.TabIndex = 74;
            this.currentUserPasswordText.TextChanged += new System.EventHandler(this.currentUserPasswordText_TextChanged);
            // 
            // newUserPasswordText
            // 
            this.newUserPasswordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newUserPasswordText.BackColor = System.Drawing.Color.Transparent;
            this.newUserPasswordText.BorderColor = System.Drawing.Color.Gray;
            this.newUserPasswordText.BorderRadius = 8;
            this.newUserPasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newUserPasswordText.DefaultText = "";
            this.newUserPasswordText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newUserPasswordText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newUserPasswordText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newUserPasswordText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newUserPasswordText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newUserPasswordText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserPasswordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newUserPasswordText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newUserPasswordText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.newUserPasswordText.Location = new System.Drawing.Point(26, 306);
            this.newUserPasswordText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newUserPasswordText.Name = "newUserPasswordText";
            this.newUserPasswordText.PasswordChar = '\0';
            this.newUserPasswordText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.newUserPasswordText.PlaceholderText = "Enter Your New Password";
            this.newUserPasswordText.SelectedText = "";
            this.newUserPasswordText.Size = new System.Drawing.Size(348, 42);
            this.newUserPasswordText.TabIndex = 75;
            this.newUserPasswordText.TextChanged += new System.EventHandler(this.newUserPasswordText_TextChanged);
            // 
            // reNewUserPasswordText
            // 
            this.reNewUserPasswordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reNewUserPasswordText.BackColor = System.Drawing.Color.Transparent;
            this.reNewUserPasswordText.BorderColor = System.Drawing.Color.Gray;
            this.reNewUserPasswordText.BorderRadius = 8;
            this.reNewUserPasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reNewUserPasswordText.DefaultText = "";
            this.reNewUserPasswordText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.reNewUserPasswordText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reNewUserPasswordText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reNewUserPasswordText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reNewUserPasswordText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reNewUserPasswordText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reNewUserPasswordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reNewUserPasswordText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reNewUserPasswordText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.reNewUserPasswordText.Location = new System.Drawing.Point(26, 400);
            this.reNewUserPasswordText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reNewUserPasswordText.Name = "reNewUserPasswordText";
            this.reNewUserPasswordText.PasswordChar = '\0';
            this.reNewUserPasswordText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.reNewUserPasswordText.PlaceholderText = "Re-Enter Your New Password";
            this.reNewUserPasswordText.SelectedText = "";
            this.reNewUserPasswordText.Size = new System.Drawing.Size(348, 42);
            this.reNewUserPasswordText.TabIndex = 76;
            this.reNewUserPasswordText.TextChanged += new System.EventHandler(this.reNewUserPasswordText_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(22, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 77;
            this.label2.Text = "Current Password:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(22, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 78;
            this.label3.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(22, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 79;
            this.label4.Text = "Confirm Password:";
            // 
            // confirmPasswordBtn
            // 
            this.confirmPasswordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPasswordBtn.Animated = true;
            this.confirmPasswordBtn.BorderRadius = 8;
            this.confirmPasswordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmPasswordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmPasswordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmPasswordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmPasswordBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.confirmPasswordBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.confirmPasswordBtn.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.confirmPasswordBtn.Location = new System.Drawing.Point(171, 470);
            this.confirmPasswordBtn.Name = "confirmPasswordBtn";
            this.confirmPasswordBtn.Size = new System.Drawing.Size(95, 45);
            this.confirmPasswordBtn.TabIndex = 81;
            this.confirmPasswordBtn.Text = "Confirm";
            this.confirmPasswordBtn.Click += new System.EventHandler(this.confirmPasswordBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBtn.Animated = true;
            this.logOutBtn.BorderRadius = 8;
            this.logOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logOutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logOutBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.logOutBtn.Location = new System.Drawing.Point(279, 470);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(95, 45);
            this.logOutBtn.TabIndex = 80;
            this.logOutBtn.Text = "LogOut";
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // LogOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 538);
            this.Controls.Add(this.confirmPasswordBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reNewUserPasswordText);
            this.Controls.Add(this.newUserPasswordText);
            this.Controls.Add(this.currentUserPasswordText);
            this.Controls.Add(this.userEmailLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.userCirclePictureBox1);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 538);
            this.MinimumSize = new System.Drawing.Size(400, 538);
            this.Name = "LogOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogOutForm";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm logOutBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox createBrandsCloseBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox userCirclePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel UserLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userEmailLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox reNewUserPasswordText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox newUserPasswordText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox currentUserPasswordText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton confirmPasswordBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton logOutBtn;
    }
}