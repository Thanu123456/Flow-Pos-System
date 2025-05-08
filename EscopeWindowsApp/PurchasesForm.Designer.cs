namespace EscopeWindowsApp
{
    partial class PurchasesForm
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
            this.filterPurDateCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.purRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.purDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.purSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.saleBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.purFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.purPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.purNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.purLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.purDataGridView)).BeginInit();
            this.saleBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPurDateCombo
            // 
            this.filterPurDateCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterPurDateCombo.BackColor = System.Drawing.Color.Transparent;
            this.filterPurDateCombo.BorderRadius = 8;
            this.filterPurDateCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterPurDateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterPurDateCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterPurDateCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterPurDateCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.filterPurDateCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filterPurDateCombo.ItemHeight = 36;
            this.filterPurDateCombo.Location = new System.Drawing.Point(1219, 30);
            this.filterPurDateCombo.Name = "filterPurDateCombo";
            this.filterPurDateCombo.Size = new System.Drawing.Size(150, 42);
            this.filterPurDateCombo.TabIndex = 90;
            this.filterPurDateCombo.SelectedIndexChanged += new System.EventHandler(this.filterPurDateCombo_SelectedIndexChanged);
            // 
            // purRefreshBtn
            // 
            this.purRefreshBtn.Animated = true;
            this.purRefreshBtn.BorderRadius = 8;
            this.purRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.purRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.purRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.purRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.purRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.purRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.purRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.purRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.purRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.purRefreshBtn.Location = new System.Drawing.Point(427, 30);
            this.purRefreshBtn.Name = "purRefreshBtn";
            this.purRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.purRefreshBtn.TabIndex = 89;
            this.purRefreshBtn.Click += new System.EventHandler(this.purRefreshBtn_Click);
            // 
            // purDataGridView
            // 
            this.purDataGridView.AllowUserToAddRows = false;
            this.purDataGridView.AllowUserToDeleteRows = false;
            this.purDataGridView.AllowUserToResizeColumns = false;
            this.purDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.purDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.purDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.purDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.purDataGridView.ColumnHeadersHeight = 45;
            this.purDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.purDataGridView.GridColor = System.Drawing.Color.White;
            this.purDataGridView.Location = new System.Drawing.Point(17, 100);
            this.purDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.purDataGridView.Name = "purDataGridView";
            this.purDataGridView.ReadOnly = true;
            this.purDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.purDataGridView.RowHeadersVisible = false;
            this.purDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.purDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.purDataGridView.RowTemplate.Height = 35;
            this.purDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.purDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.purDataGridView.TabIndex = 88;
            this.purDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.purDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.purDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.purDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.purDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.purDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.purDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.purDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.purDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.purDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.purDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.purDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.purDataGridView.ThemeStyle.ReadOnly = true;
            this.purDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.purDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.purDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.purDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.purDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.purDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.purDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purDataGridView_CellContentClick);
            // 
            // purSearchText
            // 
            this.purSearchText.Animated = true;
            this.purSearchText.BorderColor = System.Drawing.Color.Gray;
            this.purSearchText.BorderRadius = 8;
            this.purSearchText.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.purSearchText.DefaultText = "";
            this.purSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.purSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.purSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.purSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.purSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.purSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.purSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.purSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.purSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.purSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.purSearchText.Location = new System.Drawing.Point(17, 30);
            this.purSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purSearchText.Name = "purSearchText";
            this.purSearchText.PasswordChar = '\0';
            this.purSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.purSearchText.PlaceholderText = "Search";
            this.purSearchText.SelectedText = "";
            this.purSearchText.Size = new System.Drawing.Size(400, 42);
            this.purSearchText.TabIndex = 87;
            this.purSearchText.TextChanged += new System.EventHandler(this.purSearchText_TextChanged);
            // 
            // saleBtnPanel
            // 
            this.saleBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saleBtnPanel.BorderRadius = 8;
            this.saleBtnPanel.Controls.Add(this.purFirstBtn);
            this.saleBtnPanel.Controls.Add(this.purPrevBtn);
            this.saleBtnPanel.Controls.Add(this.purNextBtn);
            this.saleBtnPanel.Controls.Add(this.purLastBtn);
            this.saleBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.saleBtnPanel.Name = "saleBtnPanel";
            this.saleBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.saleBtnPanel.TabIndex = 91;
            this.saleBtnPanel.UseWaitCursor = true;
            // 
            // purFirstBtn
            // 
            this.purFirstBtn.BorderRadius = 6;
            this.purFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.purFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.purFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.purFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.purFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.purFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.purFirstBtn.ForeColor = System.Drawing.Color.White;
            this.purFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.purFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.purFirstBtn.Name = "purFirstBtn";
            this.purFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.purFirstBtn.TabIndex = 11;
            this.purFirstBtn.UseWaitCursor = true;
            this.purFirstBtn.Click += new System.EventHandler(this.purFirstBtn_Click);
            // 
            // purPrevBtn
            // 
            this.purPrevBtn.BorderRadius = 6;
            this.purPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.purPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.purPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.purPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.purPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.purPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.purPrevBtn.ForeColor = System.Drawing.Color.White;
            this.purPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.purPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.purPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.purPrevBtn.Name = "purPrevBtn";
            this.purPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.purPrevBtn.TabIndex = 11;
            this.purPrevBtn.UseWaitCursor = true;
            this.purPrevBtn.Click += new System.EventHandler(this.purPrevBtn_Click);
            // 
            // purNextBtn
            // 
            this.purNextBtn.BorderRadius = 6;
            this.purNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.purNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.purNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.purNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.purNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.purNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.purNextBtn.ForeColor = System.Drawing.Color.White;
            this.purNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.purNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.purNextBtn.Location = new System.Drawing.Point(87, 8);
            this.purNextBtn.Name = "purNextBtn";
            this.purNextBtn.Size = new System.Drawing.Size(26, 26);
            this.purNextBtn.TabIndex = 9;
            this.purNextBtn.UseWaitCursor = true;
            this.purNextBtn.Click += new System.EventHandler(this.purNextBtn_Click);
            // 
            // purLastBtn
            // 
            this.purLastBtn.BorderRadius = 6;
            this.purLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.purLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.purLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.purLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.purLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.purLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.purLastBtn.ForeColor = System.Drawing.Color.White;
            this.purLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.purLastBtn.Location = new System.Drawing.Point(130, 8);
            this.purLastBtn.Name = "purLastBtn";
            this.purLastBtn.Size = new System.Drawing.Size(26, 26);
            this.purLastBtn.TabIndex = 8;
            this.purLastBtn.UseWaitCursor = true;
            this.purLastBtn.Click += new System.EventHandler(this.purLastBtn_Click);
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.saleBtnPanel);
            this.Controls.Add(this.filterPurDateCombo);
            this.Controls.Add(this.purRefreshBtn);
            this.Controls.Add(this.purDataGridView);
            this.Controls.Add(this.purSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "PurchasesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchasesForm";
            this.Load += new System.EventHandler(this.PurchasesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purDataGridView)).EndInit();
            this.saleBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneComboBox filterPurDateCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton purRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView purDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox purSearchText;
        private Siticone.Desktop.UI.WinForms.SiticonePanel saleBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton purFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton purPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton purNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton purLastBtn;
    }
}