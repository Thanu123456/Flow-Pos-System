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
            this.userSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createUserBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.userFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userAllPgLabel = new System.Windows.Forms.Label();
            this.userOfLabel = new System.Windows.Forms.Label();
            this.userPgRangeLabel = new System.Windows.Forms.Label();
            this.userPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.userRecordsPerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.userBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userSearchText
            // 
            this.userSearchText.BorderRadius = 8;
            this.userSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userSearchText.DefaultText = "";
            this.userSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.userSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.userSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.userSearchText.Location = new System.Drawing.Point(44, 13);
            this.userSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userSearchText.Name = "userSearchText";
            this.userSearchText.PasswordChar = '\0';
            this.userSearchText.PlaceholderText = "Search";
            this.userSearchText.SelectedText = "";
            this.userSearchText.Size = new System.Drawing.Size(400, 42);
            this.userSearchText.TabIndex = 2;
            // 
            // createUserBtn
            // 
            this.createUserBtn.BorderRadius = 8;
            this.createUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createUserBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.createUserBtn.ForeColor = System.Drawing.Color.White;
            this.createUserBtn.Location = new System.Drawing.Point(568, 37);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(209, 42);
            this.createUserBtn.TabIndex = 4;
            this.createUserBtn.Text = "Craete User";
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
            // 
            // userDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userDataGridView.ColumnHeadersHeight = 25;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.userDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.userDataGridView.GridColor = System.Drawing.Color.White;
            this.userDataGridView.Location = new System.Drawing.Point(12, 96);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersVisible = false;
            this.userDataGridView.Size = new System.Drawing.Size(1299, 775);
            this.userDataGridView.TabIndex = 9;
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
            this.userDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // userBtnPanel
            // 
            this.userBtnPanel.BorderRadius = 8;
            this.userBtnPanel.Controls.Add(this.userFirstBtn);
            this.userBtnPanel.Controls.Add(this.userPrevBtn);
            this.userBtnPanel.Controls.Add(this.userNextBtn);
            this.userBtnPanel.Controls.Add(this.userLastBtn);
            this.userBtnPanel.Location = new System.Drawing.Point(334, 186);
            this.userBtnPanel.Name = "userBtnPanel";
            this.userBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.userBtnPanel.TabIndex = 22;
            // 
            // userFirstBtn
            // 
            this.userFirstBtn.BorderRadius = 6;
            this.userFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.userFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userFirstBtn.ForeColor = System.Drawing.Color.White;
            this.userFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.userFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.userFirstBtn.Name = "userFirstBtn";
            this.userFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.userFirstBtn.TabIndex = 11;
            // 
            // userPrevBtn
            // 
            this.userPrevBtn.BorderRadius = 6;
            this.userPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.userPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userPrevBtn.ForeColor = System.Drawing.Color.White;
            this.userPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.userPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.userPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.userPrevBtn.Name = "userPrevBtn";
            this.userPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.userPrevBtn.TabIndex = 11;
            // 
            // userNextBtn
            // 
            this.userNextBtn.BorderRadius = 6;
            this.userNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.userNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userNextBtn.ForeColor = System.Drawing.Color.White;
            this.userNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.userNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.userNextBtn.Location = new System.Drawing.Point(87, 8);
            this.userNextBtn.Name = "userNextBtn";
            this.userNextBtn.Size = new System.Drawing.Size(26, 26);
            this.userNextBtn.TabIndex = 9;
            // 
            // userLastBtn
            // 
            this.userLastBtn.BorderRadius = 6;
            this.userLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.userLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userLastBtn.ForeColor = System.Drawing.Color.White;
            this.userLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.userLastBtn.Location = new System.Drawing.Point(130, 8);
            this.userLastBtn.Name = "userLastBtn";
            this.userLastBtn.Size = new System.Drawing.Size(26, 26);
            this.userLastBtn.TabIndex = 8;
            // 
            // userAllPgLabel
            // 
            this.userAllPgLabel.AutoSize = true;
            this.userAllPgLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userAllPgLabel.Location = new System.Drawing.Point(439, 250);
            this.userAllPgLabel.Name = "userAllPgLabel";
            this.userAllPgLabel.Size = new System.Drawing.Size(40, 23);
            this.userAllPgLabel.TabIndex = 27;
            this.userAllPgLabel.Text = "500";
            // 
            // userOfLabel
            // 
            this.userOfLabel.AutoSize = true;
            this.userOfLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userOfLabel.Location = new System.Drawing.Point(414, 250);
            this.userOfLabel.Name = "userOfLabel";
            this.userOfLabel.Size = new System.Drawing.Size(26, 23);
            this.userOfLabel.TabIndex = 26;
            this.userOfLabel.Text = "of";
            // 
            // userPgRangeLabel
            // 
            this.userPgRangeLabel.AutoSize = true;
            this.userPgRangeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userPgRangeLabel.Location = new System.Drawing.Point(372, 250);
            this.userPgRangeLabel.Name = "userPgRangeLabel";
            this.userPgRangeLabel.Size = new System.Drawing.Size(46, 23);
            this.userPgRangeLabel.TabIndex = 25;
            this.userPgRangeLabel.Text = "0-50";
            // 
            // userPageCombo
            // 
            this.userPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.userPageCombo.BorderColor = System.Drawing.Color.Black;
            this.userPageCombo.BorderRadius = 8;
            this.userPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.userPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPageCombo.ForeColor = System.Drawing.Color.Black;
            this.userPageCombo.ItemHeight = 30;
            this.userPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.userPageCombo.Location = new System.Drawing.Point(258, 242);
            this.userPageCombo.Name = "userPageCombo";
            this.userPageCombo.Size = new System.Drawing.Size(85, 36);
            this.userPageCombo.StartIndex = 0;
            this.userPageCombo.TabIndex = 24;
            // 
            // userRecordsPerLabel
            // 
            this.userRecordsPerLabel.AutoSize = true;
            this.userRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userRecordsPerLabel.Location = new System.Drawing.Point(107, 250);
            this.userRecordsPerLabel.Name = "userRecordsPerLabel";
            this.userRecordsPerLabel.Size = new System.Drawing.Size(143, 23);
            this.userRecordsPerLabel.TabIndex = 23;
            this.userRecordsPerLabel.Text = "Records per page";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.userAllPgLabel);
            this.Controls.Add(this.userOfLabel);
            this.Controls.Add(this.userPgRangeLabel);
            this.Controls.Add(this.userPageCombo);
            this.Controls.Add(this.userRecordsPerLabel);
            this.Controls.Add(this.userBtnPanel);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.createUserBtn);
            this.Controls.Add(this.userSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.userBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createUserBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn supEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn supPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private Siticone.Desktop.UI.WinForms.SiticonePanel userBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userLastBtn;
        private System.Windows.Forms.Label userAllPgLabel;
        private System.Windows.Forms.Label userOfLabel;
        private System.Windows.Forms.Label userPgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox userPageCombo;
        private System.Windows.Forms.Label userRecordsPerLabel;
    }
}