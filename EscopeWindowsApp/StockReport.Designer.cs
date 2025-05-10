namespace EscopeWindowsApp
{
    partial class StockReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockReport));
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.stockSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.stockReportDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.generateStockPdfBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.generateStockExcelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.checkZeroStocks = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.caterotyFilterCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.stockRepBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(908, 34);
            this.headerPanel.TabIndex = 31;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(816, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(92, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(52, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 26);
            this.closeBtn.TabIndex = 0;
            // 
            // stockSearchText
            // 
            this.stockSearchText.BorderColor = System.Drawing.Color.Silver;
            this.stockSearchText.BorderRadius = 8;
            this.stockSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stockSearchText.DefaultText = "";
            this.stockSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stockSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stockSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stockSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stockSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stockSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stockSearchText.ForeColor = System.Drawing.Color.Gray;
            this.stockSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stockSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.stockSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.stockSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.stockSearchText.Location = new System.Drawing.Point(12, 53);
            this.stockSearchText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.stockSearchText.Name = "stockSearchText";
            this.stockSearchText.PasswordChar = '\0';
            this.stockSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.stockSearchText.PlaceholderText = "Search Stock";
            this.stockSearchText.SelectedText = "";
            this.stockSearchText.Size = new System.Drawing.Size(310, 42);
            this.stockSearchText.TabIndex = 33;
            this.stockSearchText.TextChanged += new System.EventHandler(this.stockSearchText_TextChanged);
            // 
            // stockReportDataGrid
            // 
            this.stockReportDataGrid.AllowUserToAddRows = false;
            this.stockReportDataGrid.AllowUserToDeleteRows = false;
            this.stockReportDataGrid.AllowUserToResizeColumns = false;
            this.stockReportDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.stockReportDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.stockReportDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stockReportDataGrid.ColumnHeadersHeight = 45;
            this.stockReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockReportDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.stockReportDataGrid.GridColor = System.Drawing.Color.White;
            this.stockReportDataGrid.Location = new System.Drawing.Point(12, 109);
            this.stockReportDataGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.stockReportDataGrid.Name = "stockReportDataGrid";
            this.stockReportDataGrid.ReadOnly = true;
            this.stockReportDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockReportDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.stockReportDataGrid.RowHeadersVisible = false;
            this.stockReportDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stockReportDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stockReportDataGrid.RowTemplate.Height = 35;
            this.stockReportDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stockReportDataGrid.Size = new System.Drawing.Size(882, 253);
            this.stockReportDataGrid.TabIndex = 44;
            this.stockReportDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.stockReportDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stockReportDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockReportDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stockReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.stockReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.stockReportDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.stockReportDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.stockReportDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.stockReportDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stockReportDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockReportDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.stockReportDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.stockReportDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.stockReportDataGrid.ThemeStyle.ReadOnly = true;
            this.stockReportDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.stockReportDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.stockReportDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockReportDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.stockReportDataGrid.ThemeStyle.RowsStyle.Height = 35;
            this.stockReportDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.stockReportDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.stockReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockReportDataGrid_CellContentClick);
            // 
            // generateStockPdfBtn
            // 
            this.generateStockPdfBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateStockPdfBtn.Animated = true;
            this.generateStockPdfBtn.BorderRadius = 8;
            this.generateStockPdfBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateStockPdfBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateStockPdfBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateStockPdfBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateStockPdfBtn.FillColor = System.Drawing.Color.Green;
            this.generateStockPdfBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateStockPdfBtn.ForeColor = System.Drawing.Color.White;
            this.generateStockPdfBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.generateStockPdfBtn.Location = new System.Drawing.Point(640, 384);
            this.generateStockPdfBtn.Name = "generateStockPdfBtn";
            this.generateStockPdfBtn.Size = new System.Drawing.Size(123, 45);
            this.generateStockPdfBtn.TabIndex = 52;
            this.generateStockPdfBtn.Text = "PDF";
            this.generateStockPdfBtn.Click += new System.EventHandler(this.generateStockPdfBtn_Click);
            // 
            // generateStockExcelBtn
            // 
            this.generateStockExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateStockExcelBtn.Animated = true;
            this.generateStockExcelBtn.BorderRadius = 8;
            this.generateStockExcelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateStockExcelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateStockExcelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateStockExcelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateStockExcelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateStockExcelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateStockExcelBtn.ForeColor = System.Drawing.Color.White;
            this.generateStockExcelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.generateStockExcelBtn.Location = new System.Drawing.Point(771, 384);
            this.generateStockExcelBtn.Name = "generateStockExcelBtn";
            this.generateStockExcelBtn.Size = new System.Drawing.Size(123, 45);
            this.generateStockExcelBtn.TabIndex = 51;
            this.generateStockExcelBtn.Text = "Excel";
            this.generateStockExcelBtn.Click += new System.EventHandler(this.generateStockExcelBtn_Click);
            // 
            // checkZeroStocks
            // 
            this.checkZeroStocks.Animated = true;
            this.checkZeroStocks.AutoSize = true;
            this.checkZeroStocks.BackColor = System.Drawing.Color.Transparent;
            this.checkZeroStocks.CheckedState.BorderColor = System.Drawing.Color.White;
            this.checkZeroStocks.CheckedState.BorderRadius = 5;
            this.checkZeroStocks.CheckedState.BorderThickness = 1;
            this.checkZeroStocks.CheckedState.FillColor = System.Drawing.Color.ForestGreen;
            this.checkZeroStocks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkZeroStocks.Location = new System.Drawing.Point(530, 70);
            this.checkZeroStocks.Name = "checkZeroStocks";
            this.checkZeroStocks.Size = new System.Drawing.Size(115, 25);
            this.checkZeroStocks.TabIndex = 83;
            this.checkZeroStocks.Text = "Zero Stocks";
            this.checkZeroStocks.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkZeroStocks.UncheckedState.BorderRadius = 5;
            this.checkZeroStocks.UncheckedState.BorderThickness = 1;
            this.checkZeroStocks.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkZeroStocks.UseVisualStyleBackColor = false;
            this.checkZeroStocks.CheckedChanged += new System.EventHandler(this.checkZeroStocks_CheckedChanged);
            // 
            // caterotyFilterCombo
            // 
            this.caterotyFilterCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.caterotyFilterCombo.BackColor = System.Drawing.Color.Transparent;
            this.caterotyFilterCombo.BorderRadius = 8;
            this.caterotyFilterCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.caterotyFilterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caterotyFilterCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.caterotyFilterCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.caterotyFilterCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.caterotyFilterCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.caterotyFilterCombo.ItemHeight = 36;
            this.caterotyFilterCombo.Location = new System.Drawing.Point(657, 53);
            this.caterotyFilterCombo.Name = "caterotyFilterCombo";
            this.caterotyFilterCombo.Size = new System.Drawing.Size(238, 42);
            this.caterotyFilterCombo.TabIndex = 84;
            this.caterotyFilterCombo.SelectedIndexChanged += new System.EventHandler(this.caterotyFilterCombo_SelectedIndexChanged);
            // 
            // stockRepBorderlessForm
            // 
            this.stockRepBorderlessForm.BorderRadius = 25;
            this.stockRepBorderlessForm.ContainerControl = this;
            this.stockRepBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.stockRepBorderlessForm.TransparentWhileDrag = true;
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 449);
            this.Controls.Add(this.caterotyFilterCombo);
            this.Controls.Add(this.checkZeroStocks);
            this.Controls.Add(this.generateStockPdfBtn);
            this.Controls.Add(this.generateStockExcelBtn);
            this.Controls.Add(this.stockReportDataGrid);
            this.Controls.Add(this.stockSearchText);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(908, 449);
            this.MinimumSize = new System.Drawing.Size(908, 449);
            this.Name = "StockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Reports";
            this.Load += new System.EventHandler(this.StockReport_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox stockSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView stockReportDataGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateStockPdfBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateStockExcelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox checkZeroStocks;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox caterotyFilterCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm stockRepBorderlessForm;
    }
}