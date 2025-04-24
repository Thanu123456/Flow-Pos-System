namespace EscopeWindowsApp
{
    partial class SalesForm
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
            this.saleBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.saleFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.salePrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.saleDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.salesRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.filterSaleDateCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.saleBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saleBtnPanel
            // 
            this.saleBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saleBtnPanel.BorderRadius = 8;
            this.saleBtnPanel.Controls.Add(this.saleFirstBtn);
            this.saleBtnPanel.Controls.Add(this.salePrevBtn);
            this.saleBtnPanel.Controls.Add(this.saleNextBtn);
            this.saleBtnPanel.Controls.Add(this.saleLastBtn);
            this.saleBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.saleBtnPanel.Name = "saleBtnPanel";
            this.saleBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.saleBtnPanel.TabIndex = 26;
            // 
            // saleFirstBtn
            // 
            this.saleFirstBtn.BorderRadius = 6;
            this.saleFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.saleFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleFirstBtn.ForeColor = System.Drawing.Color.White;
            this.saleFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.saleFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.saleFirstBtn.Name = "saleFirstBtn";
            this.saleFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.saleFirstBtn.TabIndex = 11;
            this.saleFirstBtn.Click += new System.EventHandler(this.saleFirstBtn_Click);
            // 
            // salePrevBtn
            // 
            this.salePrevBtn.BorderRadius = 6;
            this.salePrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salePrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salePrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salePrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salePrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.salePrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.salePrevBtn.ForeColor = System.Drawing.Color.White;
            this.salePrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.salePrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.salePrevBtn.Location = new System.Drawing.Point(45, 8);
            this.salePrevBtn.Name = "salePrevBtn";
            this.salePrevBtn.Size = new System.Drawing.Size(26, 26);
            this.salePrevBtn.TabIndex = 11;
            this.salePrevBtn.Click += new System.EventHandler(this.salePrevBtn_Click);
            // 
            // saleNextBtn
            // 
            this.saleNextBtn.BorderRadius = 6;
            this.saleNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.saleNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleNextBtn.ForeColor = System.Drawing.Color.White;
            this.saleNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.saleNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.saleNextBtn.Location = new System.Drawing.Point(87, 8);
            this.saleNextBtn.Name = "saleNextBtn";
            this.saleNextBtn.Size = new System.Drawing.Size(26, 26);
            this.saleNextBtn.TabIndex = 9;
            this.saleNextBtn.Click += new System.EventHandler(this.saleNextBtn_Click);
            // 
            // saleLastBtn
            // 
            this.saleLastBtn.BorderRadius = 6;
            this.saleLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.saleLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleLastBtn.ForeColor = System.Drawing.Color.White;
            this.saleLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.saleLastBtn.Location = new System.Drawing.Point(130, 8);
            this.saleLastBtn.Name = "saleLastBtn";
            this.saleLastBtn.Size = new System.Drawing.Size(26, 26);
            this.saleLastBtn.TabIndex = 8;
            this.saleLastBtn.Click += new System.EventHandler(this.saleLastBtn_Click);
            // 
            // saleSearchText
            // 
            this.saleSearchText.BorderColor = System.Drawing.Color.Gray;
            this.saleSearchText.BorderRadius = 8;
            this.saleSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.saleSearchText.DefaultText = "";
            this.saleSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.saleSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.saleSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.saleSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.saleSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saleSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saleSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saleSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.saleSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.saleSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.saleSearchText.Location = new System.Drawing.Point(17, 30);
            this.saleSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saleSearchText.Name = "saleSearchText";
            this.saleSearchText.PasswordChar = '\0';
            this.saleSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.saleSearchText.PlaceholderText = "Search";
            this.saleSearchText.SelectedText = "";
            this.saleSearchText.Size = new System.Drawing.Size(400, 42);
            this.saleSearchText.TabIndex = 27;
            this.saleSearchText.TextChanged += new System.EventHandler(this.saleSearchText_TextChanged);
            // 
            // saleDataGridView
            // 
            this.saleDataGridView.AllowUserToAddRows = false;
            this.saleDataGridView.AllowUserToDeleteRows = false;
            this.saleDataGridView.AllowUserToResizeColumns = false;
            this.saleDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.saleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.saleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.saleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.saleDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.saleDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.saleDataGridView.GridColor = System.Drawing.Color.White;
            this.saleDataGridView.Location = new System.Drawing.Point(17, 100);
            this.saleDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.saleDataGridView.Name = "saleDataGridView";
            this.saleDataGridView.ReadOnly = true;
            this.saleDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.saleDataGridView.RowHeadersVisible = false;
            this.saleDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.saleDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.saleDataGridView.RowTemplate.Height = 35;
            this.saleDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.saleDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.saleDataGridView.TabIndex = 39;
            this.saleDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.saleDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saleDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saleDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.saleDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.saleDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.saleDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.saleDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.saleDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.saleDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.saleDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.saleDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.saleDataGridView.ThemeStyle.ReadOnly = true;
            this.saleDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.saleDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.saleDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.saleDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.saleDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.saleDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // salesRefreshBtn
            // 
            this.salesRefreshBtn.BorderRadius = 8;
            this.salesRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salesRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salesRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salesRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salesRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.salesRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.salesRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.salesRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.salesRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.salesRefreshBtn.Location = new System.Drawing.Point(448, 30);
            this.salesRefreshBtn.Name = "salesRefreshBtn";
            this.salesRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.salesRefreshBtn.TabIndex = 85;
            this.salesRefreshBtn.Click += new System.EventHandler(this.salesRefreshBtn_Click);
            // 
            // filterSaleDateCombo
            // 
            this.filterSaleDateCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterSaleDateCombo.BackColor = System.Drawing.Color.Transparent;
            this.filterSaleDateCombo.BorderRadius = 8;
            this.filterSaleDateCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterSaleDateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterSaleDateCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterSaleDateCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterSaleDateCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.filterSaleDateCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filterSaleDateCombo.ItemHeight = 36;
            this.filterSaleDateCombo.Location = new System.Drawing.Point(1219, 30);
            this.filterSaleDateCombo.Name = "filterSaleDateCombo";
            this.filterSaleDateCombo.Size = new System.Drawing.Size(150, 42);
            this.filterSaleDateCombo.TabIndex = 86;
            this.filterSaleDateCombo.SelectedIndexChanged += new System.EventHandler(this.filterSaleDateCombo_SelectedIndexChanged);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.filterSaleDateCombo);
            this.Controls.Add(this.salesRefreshBtn);
            this.Controls.Add(this.saleDataGridView);
            this.Controls.Add(this.saleSearchText);
            this.Controls.Add(this.saleBtnPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "SalesForm";
            this.ShowInTaskbar = false;
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.saleBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel saleBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton salePrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox saleSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView saleDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneButton salesRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox filterSaleDateCombo;
    }
}