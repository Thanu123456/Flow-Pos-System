namespace EscopeWindowsApp
{
    partial class ExpensesCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensesCategory));
            this.expCatDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.expCatRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expCatSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createExpCatBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expCatBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.expCatFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expCatPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expCatNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expCatLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.expCatDataGridView)).BeginInit();
            this.expCatBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // expCatDataGridView
            // 
            this.expCatDataGridView.AllowUserToAddRows = false;
            this.expCatDataGridView.AllowUserToDeleteRows = false;
            this.expCatDataGridView.AllowUserToResizeColumns = false;
            this.expCatDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.expCatDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.expCatDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expCatDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expCatDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.expCatDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expCatDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.expCatDataGridView.GridColor = System.Drawing.Color.White;
            this.expCatDataGridView.Location = new System.Drawing.Point(17, 100);
            this.expCatDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.expCatDataGridView.Name = "expCatDataGridView";
            this.expCatDataGridView.ReadOnly = true;
            this.expCatDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expCatDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.expCatDataGridView.RowHeadersVisible = false;
            this.expCatDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.expCatDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.expCatDataGridView.RowTemplate.Height = 35;
            this.expCatDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.expCatDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.expCatDataGridView.TabIndex = 41;
            this.expCatDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.expCatDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.expCatDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.expCatDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.expCatDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.expCatDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.expCatDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.expCatDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.expCatDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.expCatDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.expCatDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.expCatDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.expCatDataGridView.ThemeStyle.ReadOnly = true;
            this.expCatDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.expCatDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.expCatDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.expCatDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.expCatDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.expCatDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.expCatDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expCatDataGridView_CellContentClick);
            // 
            // expCatRefreshBtn
            // 
            this.expCatRefreshBtn.Animated = true;
            this.expCatRefreshBtn.BorderRadius = 8;
            this.expCatRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expCatRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expCatRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expCatRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expCatRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.expCatRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expCatRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.expCatRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.expCatRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.expCatRefreshBtn.Location = new System.Drawing.Point(427, 30);
            this.expCatRefreshBtn.Name = "expCatRefreshBtn";
            this.expCatRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.expCatRefreshBtn.TabIndex = 40;
            this.expCatRefreshBtn.Click += new System.EventHandler(this.expCatRefreshBtn_Click);
            // 
            // expCatSearchText
            // 
            this.expCatSearchText.BorderColor = System.Drawing.Color.Gray;
            this.expCatSearchText.BorderRadius = 8;
            this.expCatSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expCatSearchText.DefaultText = "";
            this.expCatSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expCatSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expCatSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expCatSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expCatSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expCatSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatSearchText.ForeColor = System.Drawing.Color.Gray;
            this.expCatSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expCatSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.expCatSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.expCatSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.expCatSearchText.Location = new System.Drawing.Point(17, 30);
            this.expCatSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expCatSearchText.Name = "expCatSearchText";
            this.expCatSearchText.PasswordChar = '\0';
            this.expCatSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.expCatSearchText.PlaceholderText = "Search";
            this.expCatSearchText.SelectedText = "";
            this.expCatSearchText.Size = new System.Drawing.Size(400, 42);
            this.expCatSearchText.TabIndex = 39;
            this.expCatSearchText.TextChanged += new System.EventHandler(this.expCatSearchText_TextChanged);
            // 
            // createExpCatBtn
            // 
            this.createExpCatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createExpCatBtn.Animated = true;
            this.createExpCatBtn.BorderRadius = 8;
            this.createExpCatBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createExpCatBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createExpCatBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createExpCatBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createExpCatBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createExpCatBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createExpCatBtn.ForeColor = System.Drawing.Color.White;
            this.createExpCatBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createExpCatBtn.Location = new System.Drawing.Point(1129, 30);
            this.createExpCatBtn.Name = "createExpCatBtn";
            this.createExpCatBtn.Size = new System.Drawing.Size(238, 42);
            this.createExpCatBtn.TabIndex = 42;
            this.createExpCatBtn.Text = "Craete Expenses Category";
            this.createExpCatBtn.Click += new System.EventHandler(this.createExpCatBtn_Click);
            // 
            // expCatBtnPanel
            // 
            this.expCatBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expCatBtnPanel.BackColor = System.Drawing.Color.Transparent;
            this.expCatBtnPanel.BorderRadius = 8;
            this.expCatBtnPanel.Controls.Add(this.expCatFirstBtn);
            this.expCatBtnPanel.Controls.Add(this.expCatPrevBtn);
            this.expCatBtnPanel.Controls.Add(this.expCatNextBtn);
            this.expCatBtnPanel.Controls.Add(this.expCatLastBtn);
            this.expCatBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.expCatBtnPanel.Name = "expCatBtnPanel";
            this.expCatBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.expCatBtnPanel.TabIndex = 43;
            // 
            // expCatFirstBtn
            // 
            this.expCatFirstBtn.BorderRadius = 6;
            this.expCatFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expCatFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expCatFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expCatFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expCatFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.expCatFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expCatFirstBtn.ForeColor = System.Drawing.Color.White;
            this.expCatFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.expCatFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.expCatFirstBtn.Name = "expCatFirstBtn";
            this.expCatFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.expCatFirstBtn.TabIndex = 11;
            this.expCatFirstBtn.Click += new System.EventHandler(this.expCatFirstBtn_Click);
            // 
            // expCatPrevBtn
            // 
            this.expCatPrevBtn.BorderRadius = 6;
            this.expCatPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expCatPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expCatPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expCatPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expCatPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.expCatPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expCatPrevBtn.ForeColor = System.Drawing.Color.White;
            this.expCatPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.expCatPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.expCatPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.expCatPrevBtn.Name = "expCatPrevBtn";
            this.expCatPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.expCatPrevBtn.TabIndex = 11;
            this.expCatPrevBtn.Click += new System.EventHandler(this.expCatPrevBtn_Click);
            // 
            // expCatNextBtn
            // 
            this.expCatNextBtn.BorderRadius = 6;
            this.expCatNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expCatNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expCatNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expCatNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expCatNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.expCatNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expCatNextBtn.ForeColor = System.Drawing.Color.White;
            this.expCatNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.expCatNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.expCatNextBtn.Location = new System.Drawing.Point(87, 8);
            this.expCatNextBtn.Name = "expCatNextBtn";
            this.expCatNextBtn.Size = new System.Drawing.Size(26, 26);
            this.expCatNextBtn.TabIndex = 9;
            this.expCatNextBtn.Click += new System.EventHandler(this.expCatNextBtn_Click);
            // 
            // expCatLastBtn
            // 
            this.expCatLastBtn.BorderRadius = 6;
            this.expCatLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expCatLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expCatLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expCatLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expCatLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.expCatLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expCatLastBtn.ForeColor = System.Drawing.Color.White;
            this.expCatLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.expCatLastBtn.Location = new System.Drawing.Point(130, 8);
            this.expCatLastBtn.Name = "expCatLastBtn";
            this.expCatLastBtn.Size = new System.Drawing.Size(26, 26);
            this.expCatLastBtn.TabIndex = 8;
            this.expCatLastBtn.Click += new System.EventHandler(this.expCatLastBtn_Click);
            // 
            // ExpensesCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.expCatBtnPanel);
            this.Controls.Add(this.createExpCatBtn);
            this.Controls.Add(this.expCatDataGridView);
            this.Controls.Add(this.expCatRefreshBtn);
            this.Controls.Add(this.expCatSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "ExpensesCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses Categories";
            this.Load += new System.EventHandler(this.ExpensesCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expCatDataGridView)).EndInit();
            this.expCatBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView expCatDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expCatRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox expCatSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createExpCatBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel expCatBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expCatFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expCatPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expCatNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expCatLastBtn;
    }
}