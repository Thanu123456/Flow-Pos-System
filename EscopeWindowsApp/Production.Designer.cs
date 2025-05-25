namespace EscopeWindowsApp
{
    partial class Production
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Production));
            this.createProductBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.productBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.productFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.productPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.productNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.productLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.proRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.productionSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ProductDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.expireBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.productBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createProductBtn
            // 
            this.createProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createProductBtn.BorderRadius = 8;
            this.createProductBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createProductBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createProductBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createProductBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createProductBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createProductBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProductBtn.ForeColor = System.Drawing.Color.White;
            this.createProductBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createProductBtn.Location = new System.Drawing.Point(1164, 30);
            this.createProductBtn.Name = "createProductBtn";
            this.createProductBtn.Size = new System.Drawing.Size(209, 42);
            this.createProductBtn.TabIndex = 10;
            this.createProductBtn.Text = "Create Product";
            this.createProductBtn.Click += new System.EventHandler(this.createProductBtn_Click);
            // 
            // productBtnPanel
            // 
            this.productBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productBtnPanel.BorderRadius = 8;
            this.productBtnPanel.Controls.Add(this.productFirstBtn);
            this.productBtnPanel.Controls.Add(this.productPrevBtn);
            this.productBtnPanel.Controls.Add(this.productNextBtn);
            this.productBtnPanel.Controls.Add(this.productLastBtn);
            this.productBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.productBtnPanel.Name = "productBtnPanel";
            this.productBtnPanel.Size = new System.Drawing.Size(154, 42);
            this.productBtnPanel.TabIndex = 16;
            // 
            // productFirstBtn
            // 
            this.productFirstBtn.BorderRadius = 6;
            this.productFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.productFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productFirstBtn.ForeColor = System.Drawing.Color.White;
            this.productFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.productFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.productFirstBtn.Name = "productFirstBtn";
            this.productFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.productFirstBtn.TabIndex = 11;
            this.productFirstBtn.Click += new System.EventHandler(this.productFirstBtn_Click);
            // 
            // productPrevBtn
            // 
            this.productPrevBtn.BorderRadius = 6;
            this.productPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.productPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productPrevBtn.ForeColor = System.Drawing.Color.White;
            this.productPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.productPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.productPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.productPrevBtn.Name = "productPrevBtn";
            this.productPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.productPrevBtn.TabIndex = 11;
            this.productPrevBtn.Click += new System.EventHandler(this.productPrevBtn_Click);
            // 
            // productNextBtn
            // 
            this.productNextBtn.BorderRadius = 6;
            this.productNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.productNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productNextBtn.ForeColor = System.Drawing.Color.White;
            this.productNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.productNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.productNextBtn.Location = new System.Drawing.Point(87, 8);
            this.productNextBtn.Name = "productNextBtn";
            this.productNextBtn.Size = new System.Drawing.Size(26, 26);
            this.productNextBtn.TabIndex = 9;
            this.productNextBtn.Click += new System.EventHandler(this.productNextBtn_Click);
            // 
            // productLastBtn
            // 
            this.productLastBtn.BorderRadius = 6;
            this.productLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.productLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productLastBtn.ForeColor = System.Drawing.Color.White;
            this.productLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.productLastBtn.Location = new System.Drawing.Point(130, 8);
            this.productLastBtn.Name = "productLastBtn";
            this.productLastBtn.Size = new System.Drawing.Size(26, 26);
            this.productLastBtn.TabIndex = 8;
            this.productLastBtn.Click += new System.EventHandler(this.productLastBtn_Click);
            // 
            // proRefreshBtn
            // 
            this.proRefreshBtn.BorderRadius = 8;
            this.proRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.proRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.proRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.proRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.proRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.proRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.proRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.proRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.proRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.proRefreshBtn.Location = new System.Drawing.Point(427, 30);
            this.proRefreshBtn.Name = "proRefreshBtn";
            this.proRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.proRefreshBtn.TabIndex = 22;
            this.proRefreshBtn.Click += new System.EventHandler(this.proRefreshBtn_Click);
            // 
            // productionSearchText
            // 
            this.productionSearchText.BorderColor = System.Drawing.Color.Gray;
            this.productionSearchText.BorderRadius = 8;
            this.productionSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productionSearchText.DefaultText = "";
            this.productionSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productionSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productionSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productionSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productionSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productionSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productionSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productionSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.productionSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.productionSearchText.Location = new System.Drawing.Point(17, 30);
            this.productionSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productionSearchText.Name = "productionSearchText";
            this.productionSearchText.PasswordChar = '\0';
            this.productionSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.productionSearchText.PlaceholderText = "Search";
            this.productionSearchText.SelectedText = "";
            this.productionSearchText.Size = new System.Drawing.Size(400, 42);
            this.productionSearchText.TabIndex = 8;
            this.productionSearchText.TextChanged += new System.EventHandler(this.productionSearchText_TextChanged);
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.AllowUserToResizeColumns = false;
            this.ProductDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductDataGridView.GridColor = System.Drawing.Color.White;
            this.ProductDataGridView.Location = new System.Drawing.Point(17, 100);
            this.ProductDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductDataGridView.RowHeadersVisible = false;
            this.ProductDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductDataGridView.RowTemplate.Height = 35;
            this.ProductDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.ProductDataGridView.TabIndex = 40;
            this.ProductDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.ProductDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.ProductDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.ProductDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ProductDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.ProductDataGridView.ThemeStyle.ReadOnly = true;
            this.ProductDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.ProductDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ProductDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.ProductDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.ProductDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGridView_CellContentClick_1);
            // 
            // expireBtn
            // 
            this.expireBtn.BorderRadius = 8;
            this.expireBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expireBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expireBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expireBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expireBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.expireBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expireBtn.ForeColor = System.Drawing.Color.White;
            this.expireBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.expireBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.expireBtn.Location = new System.Drawing.Point(637, 30);
            this.expireBtn.Name = "expireBtn";
            this.expireBtn.Size = new System.Drawing.Size(42, 42);
            this.expireBtn.TabIndex = 41;
            this.expireBtn.Click += new System.EventHandler(this.expireBtn_Click);
            // 
            // Production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.expireBtn);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.proRefreshBtn);
            this.Controls.Add(this.productBtnPanel);
            this.Controls.Add(this.createProductBtn);
            this.Controls.Add(this.productionSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "Production";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producs";
            this.Load += new System.EventHandler(this.Production_Load_1);
            this.productBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton createProductBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox productionSearchText;
        private Siticone.Desktop.UI.WinForms.SiticonePanel productBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton productFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton productPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton productNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton productLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton proRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView ProductDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expireBtn;
    }
}