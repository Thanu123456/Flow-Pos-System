namespace EscopeWindowsApp
{
    partial class Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.createCategoryBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.categoryBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.categoryFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.categoryPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.categoryNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.categoryLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.categoryRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.categorySearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.categoryDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.categoryBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createCategoryBtn
            // 
            this.createCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createCategoryBtn.Animated = true;
            this.createCategoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.createCategoryBtn.BorderRadius = 8;
            this.createCategoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createCategoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createCategoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createCategoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createCategoryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createCategoryBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.createCategoryBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createCategoryBtn.Location = new System.Drawing.Point(1158, 30);
            this.createCategoryBtn.Name = "createCategoryBtn";
            this.createCategoryBtn.Size = new System.Drawing.Size(209, 41);
            this.createCategoryBtn.TabIndex = 14;
            this.createCategoryBtn.Text = "Create Category";
            this.createCategoryBtn.Click += new System.EventHandler(this.createCategoryBtn_Click);
            // 
            // categoryBtnPanel
            // 
            this.categoryBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryBtnPanel.BorderRadius = 8;
            this.categoryBtnPanel.Controls.Add(this.categoryFirstBtn);
            this.categoryBtnPanel.Controls.Add(this.categoryPrevBtn);
            this.categoryBtnPanel.Controls.Add(this.categoryNextBtn);
            this.categoryBtnPanel.Controls.Add(this.categoryLastBtn);
            this.categoryBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.categoryBtnPanel.Name = "categoryBtnPanel";
            this.categoryBtnPanel.Size = new System.Drawing.Size(154, 42);
            this.categoryBtnPanel.TabIndex = 22;
            // 
            // categoryFirstBtn
            // 
            this.categoryFirstBtn.BorderRadius = 6;
            this.categoryFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.categoryFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryFirstBtn.ForeColor = System.Drawing.Color.White;
            this.categoryFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.categoryFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.categoryFirstBtn.Name = "categoryFirstBtn";
            this.categoryFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.categoryFirstBtn.TabIndex = 11;
            this.categoryFirstBtn.Click += new System.EventHandler(this.categoryFirstBtn_Click);
            // 
            // categoryPrevBtn
            // 
            this.categoryPrevBtn.BorderRadius = 6;
            this.categoryPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.categoryPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryPrevBtn.ForeColor = System.Drawing.Color.White;
            this.categoryPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.categoryPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.categoryPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.categoryPrevBtn.Name = "categoryPrevBtn";
            this.categoryPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.categoryPrevBtn.TabIndex = 11;
            this.categoryPrevBtn.Click += new System.EventHandler(this.categoryPrevBtn_Click);
            // 
            // categoryNextBtn
            // 
            this.categoryNextBtn.BorderRadius = 6;
            this.categoryNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.categoryNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryNextBtn.ForeColor = System.Drawing.Color.White;
            this.categoryNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.categoryNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.categoryNextBtn.Location = new System.Drawing.Point(87, 8);
            this.categoryNextBtn.Name = "categoryNextBtn";
            this.categoryNextBtn.Size = new System.Drawing.Size(26, 26);
            this.categoryNextBtn.TabIndex = 9;
            this.categoryNextBtn.Click += new System.EventHandler(this.categoryNextBtn_Click);
            // 
            // categoryLastBtn
            // 
            this.categoryLastBtn.BorderRadius = 6;
            this.categoryLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.categoryLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryLastBtn.ForeColor = System.Drawing.Color.White;
            this.categoryLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.categoryLastBtn.Location = new System.Drawing.Point(130, 8);
            this.categoryLastBtn.Name = "categoryLastBtn";
            this.categoryLastBtn.Size = new System.Drawing.Size(26, 26);
            this.categoryLastBtn.TabIndex = 8;
            this.categoryLastBtn.Click += new System.EventHandler(this.categoryLastBtn_Click);
            // 
            // categoryRefreshBtn
            // 
            this.categoryRefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryRefreshBtn.Animated = true;
            this.categoryRefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.categoryRefreshBtn.BorderRadius = 8;
            this.categoryRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.categoryRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.categoryRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.categoryRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.categoryRefreshBtn.Location = new System.Drawing.Point(427, 30);
            this.categoryRefreshBtn.Name = "categoryRefreshBtn";
            this.categoryRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.categoryRefreshBtn.TabIndex = 13;
            this.categoryRefreshBtn.Click += new System.EventHandler(this.categoryRefreshBtn_Click);
            // 
            // categorySearchText
            // 
            this.categorySearchText.AutoSize = true;
            this.categorySearchText.BorderColor = System.Drawing.Color.Gray;
            this.categorySearchText.BorderRadius = 8;
            this.categorySearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categorySearchText.DefaultText = "";
            this.categorySearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categorySearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categorySearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categorySearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categorySearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorySearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categorySearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorySearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.categorySearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.categorySearchText.Location = new System.Drawing.Point(17, 30);
            this.categorySearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categorySearchText.Name = "categorySearchText";
            this.categorySearchText.PasswordChar = '\0';
            this.categorySearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.categorySearchText.PlaceholderText = "Search";
            this.categorySearchText.SelectedText = "";
            this.categorySearchText.Size = new System.Drawing.Size(400, 42);
            this.categorySearchText.TabIndex = 12;
            this.categorySearchText.TextChanged += new System.EventHandler(this.categorySearchText_TextChanged);
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AllowUserToDeleteRows = false;
            this.categoryDataGridView.AllowUserToResizeColumns = false;
            this.categoryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.categoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.categoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.categoryDataGridView.ColumnHeadersHeight = 45;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.categoryDataGridView.GridColor = System.Drawing.Color.White;
            this.categoryDataGridView.Location = new System.Drawing.Point(17, 100);
            this.categoryDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.ReadOnly = true;
            this.categoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.categoryDataGridView.RowHeadersVisible = false;
            this.categoryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.categoryDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.categoryDataGridView.RowTemplate.Height = 35;
            this.categoryDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.categoryDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.categoryDataGridView.TabIndex = 28;
            this.categoryDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.categoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.categoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.categoryDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.categoryDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.categoryDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.categoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.categoryDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.categoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.categoryDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.categoryDataGridView.ThemeStyle.ReadOnly = true;
            this.categoryDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.categoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.categoryDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.categoryDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.categoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.categoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.categoryBtnPanel);
            this.Controls.Add(this.createCategoryBtn);
            this.Controls.Add(this.categoryRefreshBtn);
            this.Controls.Add(this.categorySearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "Category";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.categoryBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton createCategoryBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton categoryRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox categorySearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton categoryFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel categoryBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton categoryPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton categoryNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton categoryLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView categoryDataGridView;
    }
}