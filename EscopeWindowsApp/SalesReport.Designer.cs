namespace EscopeWindowsApp
{
    partial class SalesReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.salesSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.dateFilterSaleCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.salesReportDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.salesTotAmontLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.totalExpLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.generateSalesPdfBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.generateSalesExcelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportDataGrid)).BeginInit();
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
            this.headerPanel.TabIndex = 30;
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
            // salesSearchText
            // 
            this.salesSearchText.BorderColor = System.Drawing.Color.Silver;
            this.salesSearchText.BorderRadius = 8;
            this.salesSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salesSearchText.DefaultText = "";
            this.salesSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.salesSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.salesSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salesSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salesSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salesSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.salesSearchText.ForeColor = System.Drawing.Color.Gray;
            this.salesSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salesSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.salesSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.salesSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.salesSearchText.Location = new System.Drawing.Point(12, 42);
            this.salesSearchText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.salesSearchText.Name = "salesSearchText";
            this.salesSearchText.PasswordChar = '\0';
            this.salesSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.salesSearchText.PlaceholderText = "Search Sales";
            this.salesSearchText.SelectedText = "";
            this.salesSearchText.Size = new System.Drawing.Size(310, 36);
            this.salesSearchText.TabIndex = 32;
            this.salesSearchText.TextChanged += new System.EventHandler(this.salesSearchText_TextChanged);
            // 
            // dateFilterSaleCombo
            // 
            this.dateFilterSaleCombo.BackColor = System.Drawing.Color.Transparent;
            this.dateFilterSaleCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateFilterSaleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateFilterSaleCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterSaleCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterSaleCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateFilterSaleCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dateFilterSaleCombo.ItemHeight = 30;
            this.dateFilterSaleCombo.Location = new System.Drawing.Point(689, 42);
            this.dateFilterSaleCombo.Name = "dateFilterSaleCombo";
            this.dateFilterSaleCombo.Size = new System.Drawing.Size(207, 36);
            this.dateFilterSaleCombo.TabIndex = 33;
            this.dateFilterSaleCombo.SelectedIndexChanged += new System.EventHandler(this.dateFilterSaleCombo_SelectedIndexChanged);
            // 
            // salesReportDataGrid
            // 
            this.salesReportDataGrid.AllowUserToAddRows = false;
            this.salesReportDataGrid.AllowUserToDeleteRows = false;
            this.salesReportDataGrid.AllowUserToResizeColumns = false;
            this.salesReportDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.salesReportDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.salesReportDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.salesReportDataGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesReportDataGrid.DefaultCellStyle = dataGridViewCellStyle15;
            this.salesReportDataGrid.GridColor = System.Drawing.Color.White;
            this.salesReportDataGrid.Location = new System.Drawing.Point(12, 109);
            this.salesReportDataGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.salesReportDataGrid.Name = "salesReportDataGrid";
            this.salesReportDataGrid.ReadOnly = true;
            this.salesReportDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesReportDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.salesReportDataGrid.RowHeadersVisible = false;
            this.salesReportDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.salesReportDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.salesReportDataGrid.RowTemplate.Height = 35;
            this.salesReportDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salesReportDataGrid.Size = new System.Drawing.Size(882, 257);
            this.salesReportDataGrid.TabIndex = 43;
            this.salesReportDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.salesReportDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.salesReportDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesReportDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salesReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.salesReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.salesReportDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.salesReportDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.salesReportDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.salesReportDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salesReportDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesReportDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.salesReportDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.salesReportDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.salesReportDataGrid.ThemeStyle.ReadOnly = true;
            this.salesReportDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.salesReportDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salesReportDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesReportDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.salesReportDataGrid.ThemeStyle.RowsStyle.Height = 35;
            this.salesReportDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.salesReportDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.salesReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesReportDataGrid_CellContentClick);
            // 
            // salesTotAmontLabel
            // 
            this.salesTotAmontLabel.BackColor = System.Drawing.Color.Transparent;
            this.salesTotAmontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTotAmontLabel.Location = new System.Drawing.Point(771, 377);
            this.salesTotAmontLabel.Name = "salesTotAmontLabel";
            this.salesTotAmontLabel.Size = new System.Drawing.Size(38, 22);
            this.salesTotAmontLabel.TabIndex = 50;
            this.salesTotAmontLabel.Text = "0.00";
            this.salesTotAmontLabel.Click += new System.EventHandler(this.salesTotAmontLabel_Click);
            // 
            // totalExpLabel
            // 
            this.totalExpLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpLabel.Location = new System.Drawing.Point(688, 377);
            this.totalExpLabel.Name = "totalExpLabel";
            this.totalExpLabel.Size = new System.Drawing.Size(63, 22);
            this.totalExpLabel.TabIndex = 49;
            this.totalExpLabel.Text = "TOTAL:";
            // 
            // generateSalesPdfBtn
            // 
            this.generateSalesPdfBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateSalesPdfBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateSalesPdfBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateSalesPdfBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateSalesPdfBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.generateSalesPdfBtn.ForeColor = System.Drawing.Color.White;
            this.generateSalesPdfBtn.Location = new System.Drawing.Point(642, 431);
            this.generateSalesPdfBtn.Name = "generateSalesPdfBtn";
            this.generateSalesPdfBtn.Size = new System.Drawing.Size(123, 45);
            this.generateSalesPdfBtn.TabIndex = 48;
            this.generateSalesPdfBtn.Text = "Pdf";
            this.generateSalesPdfBtn.Click += new System.EventHandler(this.generateSalesPdfBtn_Click);
            // 
            // generateSalesExcelBtn
            // 
            this.generateSalesExcelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateSalesExcelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateSalesExcelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateSalesExcelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateSalesExcelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.generateSalesExcelBtn.ForeColor = System.Drawing.Color.White;
            this.generateSalesExcelBtn.Location = new System.Drawing.Point(771, 431);
            this.generateSalesExcelBtn.Name = "generateSalesExcelBtn";
            this.generateSalesExcelBtn.Size = new System.Drawing.Size(123, 45);
            this.generateSalesExcelBtn.TabIndex = 47;
            this.generateSalesExcelBtn.Text = "Excel";
            this.generateSalesExcelBtn.Click += new System.EventHandler(this.generateSalesExcelBtn_Click);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 488);
            this.Controls.Add(this.salesTotAmontLabel);
            this.Controls.Add(this.totalExpLabel);
            this.Controls.Add(this.generateSalesPdfBtn);
            this.Controls.Add(this.generateSalesExcelBtn);
            this.Controls.Add(this.salesReportDataGrid);
            this.Controls.Add(this.dateFilterSaleCombo);
            this.Controls.Add(this.salesSearchText);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox salesSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox dateFilterSaleCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView salesReportDataGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel salesTotAmontLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel totalExpLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateSalesPdfBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateSalesExcelBtn;
    }
}