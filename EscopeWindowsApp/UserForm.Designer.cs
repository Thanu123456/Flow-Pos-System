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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.userSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createUserBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.userFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.userBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
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
            this.createUserBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserBtn.ForeColor = System.Drawing.Color.White;
            this.createUserBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createUserBtn.Location = new System.Drawing.Point(1158, 30);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(209, 42);
            this.createUserBtn.TabIndex = 4;
            this.createUserBtn.Text = "Craete User";
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
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
            // userRefreshBtn
            // 
            this.userRefreshBtn.Animated = true;
            this.userRefreshBtn.BorderRadius = 8;
            this.userRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.userRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.userRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.userRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.userRefreshBtn.Location = new System.Drawing.Point(427, 30);
            this.userRefreshBtn.Name = "userRefreshBtn";
            this.userRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.userRefreshBtn.TabIndex = 28;
            this.userRefreshBtn.Click += new System.EventHandler(this.userFilterBtn_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.AllowUserToResizeColumns = false;
            this.userDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.userDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.userDataGridView.GridColor = System.Drawing.Color.White;
            this.userDataGridView.Location = new System.Drawing.Point(17, 100);
            this.userDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userDataGridView.RowHeadersVisible = false;
            this.userDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.userDataGridView.RowTemplate.Height = 35;
            this.userDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.userDataGridView.TabIndex = 15;
            this.userDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.userDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.userDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.userDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.userDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.userDataGridView.ThemeStyle.ReadOnly = true;
            this.userDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.userDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.userDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.userDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.userDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.userRefreshBtn);
            this.Controls.Add(this.userBtnPanel);
            this.Controls.Add(this.createUserBtn);
            this.Controls.Add(this.userSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.userBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox userSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createUserBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel userBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView userDataGridView;
    }
}