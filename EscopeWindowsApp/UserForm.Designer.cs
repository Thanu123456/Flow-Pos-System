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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createUserBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
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
            this.userFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.userBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userSearchText
            // 
            this.userSearchText.BorderColor = System.Drawing.Color.Gray;
            this.userSearchText.BorderRadius = 8;
            this.userSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userSearchText.DefaultText = "";
            this.userSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.userSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.userSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.userSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.userSearchText.Location = new System.Drawing.Point(17, 30);
            this.userSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userSearchText.Name = "userSearchText";
            this.userSearchText.PasswordChar = '\0';
            this.userSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.userSearchText.PlaceholderText = "Search";
            this.userSearchText.SelectedText = "";
            this.userSearchText.Size = new System.Drawing.Size(400, 42);
            this.userSearchText.TabIndex = 2;
            this.userSearchText.TextChanged += new System.EventHandler(this.userSearchText_TextChanged);
            // 
            // createUserBtn
            // 
            this.createUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createUserBtn.Animated = true;
            this.createUserBtn.BorderRadius = 8;
            this.createUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createUserBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.createUserBtn.ForeColor = System.Drawing.Color.White;
            this.createUserBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createUserBtn.Location = new System.Drawing.Point(1158, 30);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(209, 42);
            this.createUserBtn.TabIndex = 4;
            this.createUserBtn.Text = "Craete User";
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.userDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.userDataGridView.ColumnHeadersHeight = 25;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.userDataGridView.GridColor = System.Drawing.Color.White;
            this.userDataGridView.Location = new System.Drawing.Point(17, 100);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowHeadersVisible = false;
            this.userDataGridView.Size = new System.Drawing.Size(1352, 614);
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
            this.userDataGridView.ThemeStyle.ReadOnly = true;
            this.userDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.userDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.userDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.userDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.userDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // userBtnPanel
            // 
            this.userBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userBtnPanel.BorderRadius = 8;
            this.userBtnPanel.Controls.Add(this.userFirstBtn);
            this.userBtnPanel.Controls.Add(this.userPrevBtn);
            this.userBtnPanel.Controls.Add(this.userNextBtn);
            this.userBtnPanel.Controls.Add(this.userLastBtn);
            this.userBtnPanel.Location = new System.Drawing.Point(1213, 734);
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
            this.userFirstBtn.Click += new System.EventHandler(this.userFirstBtn_Click);
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
            this.userPrevBtn.Click += new System.EventHandler(this.userPrevBtn_Click);
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
            this.userNextBtn.Click += new System.EventHandler(this.userNextBtn_Click);
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
            this.userLastBtn.Click += new System.EventHandler(this.userLastBtn_Click);
            // 
            // userAllPgLabel
            // 
            this.userAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userAllPgLabel.AutoSize = true;
            this.userAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userAllPgLabel.Location = new System.Drawing.Point(295, 742);
            this.userAllPgLabel.Name = "userAllPgLabel";
            this.userAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.userAllPgLabel.TabIndex = 27;
            this.userAllPgLabel.Text = "500";
            // 
            // userOfLabel
            // 
            this.userOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userOfLabel.AutoSize = true;
            this.userOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userOfLabel.Location = new System.Drawing.Point(274, 742);
            this.userOfLabel.Name = "userOfLabel";
            this.userOfLabel.Size = new System.Drawing.Size(22, 19);
            this.userOfLabel.TabIndex = 26;
            this.userOfLabel.Text = "of";
            // 
            // userPgRangeLabel
            // 
            this.userPgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userPgRangeLabel.AutoSize = true;
            this.userPgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userPgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.userPgRangeLabel.Name = "userPgRangeLabel";
            this.userPgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.userPgRangeLabel.TabIndex = 25;
            this.userPgRangeLabel.Text = "0-50";
            // 
            // userPageCombo
            // 
            this.userPageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.userPageCombo.Location = new System.Drawing.Point(141, 734);
            this.userPageCombo.Name = "userPageCombo";
            this.userPageCombo.Size = new System.Drawing.Size(85, 36);
            this.userPageCombo.StartIndex = 0;
            this.userPageCombo.TabIndex = 24;
            // 
            // userRecordsPerLabel
            // 
            this.userRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userRecordsPerLabel.AutoSize = true;
            this.userRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.userRecordsPerLabel.Name = "userRecordsPerLabel";
            this.userRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.userRecordsPerLabel.TabIndex = 23;
            this.userRecordsPerLabel.Text = "Records per page";
            // 
            // userFilterBtn
            // 
            this.userFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userFilterBtn.Animated = true;
            this.userFilterBtn.BorderRadius = 8;
            this.userFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.userFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userFilterBtn.ForeColor = System.Drawing.Color.White;
            this.userFilterBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.userFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh;
            this.userFilterBtn.Location = new System.Drawing.Point(1098, 30);
            this.userFilterBtn.Name = "userFilterBtn";
            this.userFilterBtn.Size = new System.Drawing.Size(43, 42);
            this.userFilterBtn.TabIndex = 28;
            this.userFilterBtn.Click += new System.EventHandler(this.userFilterBtn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.userFilterBtn);
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
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Siticone.Desktop.UI.WinForms.SiticoneButton userFilterBtn;
    }
}