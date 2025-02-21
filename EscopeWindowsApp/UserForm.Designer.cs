namespace EscopeWindowsApp
{
    partial class UserForm
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
            this.userSearchPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.userSearchBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userAddBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userStatusText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userRoleText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPagiPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.userNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userCurrentBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.usersListLabel = new System.Windows.Forms.Label();
            this.userSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.userPagiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userSearchPanel
            // 
            this.userSearchPanel.BorderColor = System.Drawing.Color.Black;
            this.userSearchPanel.BorderRadius = 10;
            this.userSearchPanel.BorderThickness = 1;
            this.userSearchPanel.Controls.Add(this.userSearchBtn);
            this.userSearchPanel.Controls.Add(this.userAddBtn);
            this.userSearchPanel.Controls.Add(this.userStatusText);
            this.userSearchPanel.Controls.Add(this.userRoleText);
            this.userSearchPanel.Controls.Add(this.userEmailText);
            this.userSearchPanel.Controls.Add(this.userNameText);
            this.userSearchPanel.Location = new System.Drawing.Point(12, 42);
            this.userSearchPanel.Name = "userSearchPanel";
            this.userSearchPanel.Size = new System.Drawing.Size(810, 148);
            this.userSearchPanel.TabIndex = 0;
            // 
            // userSearchBtn
            // 
            this.userSearchBtn.BorderRadius = 8;
            this.userSearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userSearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userSearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userSearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userSearchBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.userSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userSearchBtn.ForeColor = System.Drawing.Color.White;
            this.userSearchBtn.Location = new System.Drawing.Point(679, 84);
            this.userSearchBtn.Name = "userSearchBtn";
            this.userSearchBtn.Size = new System.Drawing.Size(106, 45);
            this.userSearchBtn.TabIndex = 4;
            this.userSearchBtn.Text = "Search";
            // 
            // userAddBtn
            // 
            this.userAddBtn.BorderRadius = 8;
            this.userAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userAddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.userAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userAddBtn.ForeColor = System.Drawing.Color.White;
            this.userAddBtn.Location = new System.Drawing.Point(550, 84);
            this.userAddBtn.Name = "userAddBtn";
            this.userAddBtn.Size = new System.Drawing.Size(106, 45);
            this.userAddBtn.TabIndex = 0;
            this.userAddBtn.Text = "Add";
            this.userAddBtn.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // userStatusText
            // 
            this.userStatusText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userStatusText.BorderRadius = 8;
            this.userStatusText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userStatusText.DefaultText = "";
            this.userStatusText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userStatusText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userStatusText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userStatusText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userStatusText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.userStatusText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.userStatusText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userStatusText.Location = new System.Drawing.Point(14, 84);
            this.userStatusText.Name = "userStatusText";
            this.userStatusText.PasswordChar = '\0';
            this.userStatusText.PlaceholderText = "Enter Status";
            this.userStatusText.SelectedText = "";
            this.userStatusText.Size = new System.Drawing.Size(247, 40);
            this.userStatusText.TabIndex = 3;
            // 
            // userRoleText
            // 
            this.userRoleText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userRoleText.BorderRadius = 8;
            this.userRoleText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userRoleText.DefaultText = "";
            this.userRoleText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userRoleText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userRoleText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userRoleText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userRoleText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.userRoleText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userRoleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.userRoleText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userRoleText.Location = new System.Drawing.Point(550, 20);
            this.userRoleText.Name = "userRoleText";
            this.userRoleText.PasswordChar = '\0';
            this.userRoleText.PlaceholderText = "Enter Role";
            this.userRoleText.SelectedText = "";
            this.userRoleText.Size = new System.Drawing.Size(247, 40);
            this.userRoleText.TabIndex = 2;
            this.userRoleText.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged_2);
            // 
            // userEmailText
            // 
            this.userEmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userEmailText.BorderRadius = 8;
            this.userEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userEmailText.DefaultText = "";
            this.userEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userEmailText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.userEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.userEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userEmailText.Location = new System.Drawing.Point(282, 20);
            this.userEmailText.Name = "userEmailText";
            this.userEmailText.PasswordChar = '\0';
            this.userEmailText.PlaceholderText = "Enter Email";
            this.userEmailText.SelectedText = "";
            this.userEmailText.Size = new System.Drawing.Size(247, 40);
            this.userEmailText.TabIndex = 1;
            this.userEmailText.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged_1);
            // 
            // userNameText
            // 
            this.userNameText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameText.BorderRadius = 8;
            this.userNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameText.DefaultText = "";
            this.userNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.userNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.userNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameText.Location = new System.Drawing.Point(14, 20);
            this.userNameText.Name = "userNameText";
            this.userNameText.PasswordChar = '\0';
            this.userNameText.PlaceholderText = "Enter Name";
            this.userNameText.SelectedText = "";
            this.userNameText.Size = new System.Drawing.Size(247, 40);
            this.userNameText.TabIndex = 0;
            this.userNameText.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged);
            // 
            // userDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userDataGridView.ColumnHeadersHeight = 25;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.email,
            this.role,
            this.status,
            this.action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.userDataGridView.GridColor = System.Drawing.Color.White;
            this.userDataGridView.Location = new System.Drawing.Point(12, 232);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersVisible = false;
            this.userDataGridView.Size = new System.Drawing.Size(810, 306);
            this.userDataGridView.TabIndex = 1;
            this.userDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.userDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.userDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.userDataGridView.ThemeStyle.ReadOnly = false;
            this.userDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.userDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.userDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.userDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.userDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // username
            // 
            this.username.HeaderText = "User Name";
            this.username.Name = "username";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            // 
            // userPagiPanel
            // 
            this.userPagiPanel.Controls.Add(this.userNextBtn);
            this.userPagiPanel.Controls.Add(this.userCurrentBtn);
            this.userPagiPanel.Controls.Add(this.userPrevBtn);
            this.userPagiPanel.FillColor = System.Drawing.Color.White;
            this.userPagiPanel.Location = new System.Drawing.Point(342, 499);
            this.userPagiPanel.Name = "userPagiPanel";
            this.userPagiPanel.Size = new System.Drawing.Size(183, 39);
            this.userPagiPanel.TabIndex = 2;
            // 
            // userNextBtn
            // 
            this.userNextBtn.BorderRadius = 10;
            this.userNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userNextBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.userNextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.userNextBtn.ForeColor = System.Drawing.Color.White;
            this.userNextBtn.Location = new System.Drawing.Point(125, 3);
            this.userNextBtn.Name = "userNextBtn";
            this.userNextBtn.Size = new System.Drawing.Size(55, 33);
            this.userNextBtn.TabIndex = 4;
            this.userNextBtn.Text = "Next";
            // 
            // userCurrentBtn
            // 
            this.userCurrentBtn.BorderRadius = 10;
            this.userCurrentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userCurrentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userCurrentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userCurrentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userCurrentBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.userCurrentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.userCurrentBtn.ForeColor = System.Drawing.Color.White;
            this.userCurrentBtn.Location = new System.Drawing.Point(64, 3);
            this.userCurrentBtn.Name = "userCurrentBtn";
            this.userCurrentBtn.Size = new System.Drawing.Size(55, 33);
            this.userCurrentBtn.TabIndex = 4;
            this.userCurrentBtn.Text = "1";
            // 
            // userPrevBtn
            // 
            this.userPrevBtn.BorderRadius = 10;
            this.userPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userPrevBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.userPrevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.userPrevBtn.ForeColor = System.Drawing.Color.White;
            this.userPrevBtn.Location = new System.Drawing.Point(3, 3);
            this.userPrevBtn.Name = "userPrevBtn";
            this.userPrevBtn.Size = new System.Drawing.Size(55, 33);
            this.userPrevBtn.TabIndex = 3;
            this.userPrevBtn.Text = "Prev";
            this.userPrevBtn.Click += new System.EventHandler(this.siticoneButton1_Click_1);
            // 
            // usersListLabel
            // 
            this.usersListLabel.AutoSize = true;
            this.usersListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersListLabel.Location = new System.Drawing.Point(12, 9);
            this.usersListLabel.Name = "usersListLabel";
            this.usersListLabel.Size = new System.Drawing.Size(75, 18);
            this.usersListLabel.TabIndex = 3;
            this.usersListLabel.Text = "Users List";
            this.usersListLabel.Click += new System.EventHandler(this.addUserLabel_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.usersListLabel);
            this.Controls.Add(this.userPagiPanel);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.userSearchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.userSearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.userPagiPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel userSearchPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userAddBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userNameText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userEmailText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userRoleText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userStatusText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userSearchBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private Siticone.Desktop.UI.WinForms.SiticonePanel userPagiPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userCurrentBtn;
        private System.Windows.Forms.Label usersListLabel;
    }
}