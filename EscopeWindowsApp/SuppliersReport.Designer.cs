namespace EscopeWindowsApp
{
    partial class SuppliersReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.supplierSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.suppliersReportDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.generateSuppliersPdfBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.generateSuppliersExcelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersReportDataGrid)).BeginInit();
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
            this.headerPanel.TabIndex = 32;
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
            // supplierSearchText
            // 
            this.supplierSearchText.BorderColor = System.Drawing.Color.Silver;
            this.supplierSearchText.BorderRadius = 8;
            this.supplierSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplierSearchText.DefaultText = "";
            this.supplierSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supplierSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supplierSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.supplierSearchText.ForeColor = System.Drawing.Color.Gray;
            this.supplierSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.supplierSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.supplierSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.supplierSearchText.Location = new System.Drawing.Point(12, 42);
            this.supplierSearchText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.supplierSearchText.Name = "supplierSearchText";
            this.supplierSearchText.PasswordChar = '\0';
            this.supplierSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.supplierSearchText.PlaceholderText = "Search Supplier";
            this.supplierSearchText.SelectedText = "";
            this.supplierSearchText.Size = new System.Drawing.Size(310, 42);
            this.supplierSearchText.TabIndex = 34;
            this.supplierSearchText.TextChanged += new System.EventHandler(this.supplierSearchText_TextChanged);
            // 
            // suppliersReportDataGrid
            // 
            this.suppliersReportDataGrid.AllowUserToAddRows = false;
            this.suppliersReportDataGrid.AllowUserToDeleteRows = false;
            this.suppliersReportDataGrid.AllowUserToResizeColumns = false;
            this.suppliersReportDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.suppliersReportDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.suppliersReportDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.suppliersReportDataGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.suppliersReportDataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.suppliersReportDataGrid.GridColor = System.Drawing.Color.White;
            this.suppliersReportDataGrid.Location = new System.Drawing.Point(13, 121);
            this.suppliersReportDataGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.suppliersReportDataGrid.Name = "suppliersReportDataGrid";
            this.suppliersReportDataGrid.ReadOnly = true;
            this.suppliersReportDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersReportDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.suppliersReportDataGrid.RowHeadersVisible = false;
            this.suppliersReportDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.suppliersReportDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.suppliersReportDataGrid.RowTemplate.Height = 35;
            this.suppliersReportDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.suppliersReportDataGrid.Size = new System.Drawing.Size(882, 209);
            this.suppliersReportDataGrid.TabIndex = 45;
            this.suppliersReportDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.suppliersReportDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.suppliersReportDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersReportDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.suppliersReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.suppliersReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.suppliersReportDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.suppliersReportDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.suppliersReportDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.suppliersReportDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.suppliersReportDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersReportDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.suppliersReportDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.suppliersReportDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.suppliersReportDataGrid.ThemeStyle.ReadOnly = true;
            this.suppliersReportDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.suppliersReportDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.suppliersReportDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersReportDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.suppliersReportDataGrid.ThemeStyle.RowsStyle.Height = 35;
            this.suppliersReportDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.suppliersReportDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.suppliersReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersReportDataGrid_CellContentClick);
            // 
            // generateSuppliersPdfBtn
            // 
            this.generateSuppliersPdfBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateSuppliersPdfBtn.Animated = true;
            this.generateSuppliersPdfBtn.BorderRadius = 8;
            this.generateSuppliersPdfBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateSuppliersPdfBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateSuppliersPdfBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateSuppliersPdfBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateSuppliersPdfBtn.FillColor = System.Drawing.Color.Green;
            this.generateSuppliersPdfBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSuppliersPdfBtn.ForeColor = System.Drawing.Color.White;
            this.generateSuppliersPdfBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.generateSuppliersPdfBtn.Location = new System.Drawing.Point(640, 384);
            this.generateSuppliersPdfBtn.Name = "generateSuppliersPdfBtn";
            this.generateSuppliersPdfBtn.Size = new System.Drawing.Size(123, 45);
            this.generateSuppliersPdfBtn.TabIndex = 52;
            this.generateSuppliersPdfBtn.Text = "PDF";
            this.generateSuppliersPdfBtn.Click += new System.EventHandler(this.generateSuppliersPdfBtn_Click);
            // 
            // generateSuppliersExcelBtn
            // 
            this.generateSuppliersExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateSuppliersExcelBtn.Animated = true;
            this.generateSuppliersExcelBtn.BorderRadius = 8;
            this.generateSuppliersExcelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateSuppliersExcelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateSuppliersExcelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateSuppliersExcelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateSuppliersExcelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateSuppliersExcelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSuppliersExcelBtn.ForeColor = System.Drawing.Color.White;
            this.generateSuppliersExcelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.generateSuppliersExcelBtn.Location = new System.Drawing.Point(771, 384);
            this.generateSuppliersExcelBtn.Name = "generateSuppliersExcelBtn";
            this.generateSuppliersExcelBtn.Size = new System.Drawing.Size(123, 45);
            this.generateSuppliersExcelBtn.TabIndex = 51;
            this.generateSuppliersExcelBtn.Text = "EXCEL";
            this.generateSuppliersExcelBtn.Click += new System.EventHandler(this.generateSuppliersExcelBtn_Click);
            // 
            // SuppliersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.generateSuppliersPdfBtn);
            this.Controls.Add(this.generateSuppliersExcelBtn);
            this.Controls.Add(this.suppliersReportDataGrid);
            this.Controls.Add(this.supplierSearchText);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuppliersReport";
            this.Text = "SuppliersReport";
            this.Load += new System.EventHandler(this.SuppliersReport_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersReportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox supplierSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView suppliersReportDataGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateSuppliersPdfBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateSuppliersExcelBtn;
    }
}