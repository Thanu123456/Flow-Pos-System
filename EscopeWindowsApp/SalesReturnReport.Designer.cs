namespace EscopeWindowsApp
{
    partial class SalesReturnReport
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
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.billNoSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.resonsFilterSaleRetCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.dateFilterSaleRetCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.salesRetReportDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.salesRetTotAmontLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.totalExpLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.generateSalesRetPdfBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.generateSalesRetExcelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.salesRetBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesRetReportDataGrid)).BeginInit();
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
            // billNoSearchText
            // 
            this.billNoSearchText.BorderColor = System.Drawing.Color.Silver;
            this.billNoSearchText.BorderRadius = 8;
            this.billNoSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.billNoSearchText.DefaultText = "";
            this.billNoSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.billNoSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.billNoSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.billNoSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.billNoSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billNoSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.billNoSearchText.ForeColor = System.Drawing.Color.Gray;
            this.billNoSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billNoSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.billNoSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.billNoSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.billNoSearchText.Location = new System.Drawing.Point(12, 51);
            this.billNoSearchText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.billNoSearchText.Name = "billNoSearchText";
            this.billNoSearchText.PasswordChar = '\0';
            this.billNoSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.billNoSearchText.PlaceholderText = "Search Bill Number";
            this.billNoSearchText.SelectedText = "";
            this.billNoSearchText.Size = new System.Drawing.Size(310, 42);
            this.billNoSearchText.TabIndex = 33;
            this.billNoSearchText.TextChanged += new System.EventHandler(this.billNoSearchText_TextChanged);
            // 
            // resonsFilterSaleRetCombo
            // 
            this.resonsFilterSaleRetCombo.BackColor = System.Drawing.Color.Transparent;
            this.resonsFilterSaleRetCombo.BorderRadius = 8;
            this.resonsFilterSaleRetCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.resonsFilterSaleRetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resonsFilterSaleRetCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resonsFilterSaleRetCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resonsFilterSaleRetCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resonsFilterSaleRetCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.resonsFilterSaleRetCombo.ItemHeight = 36;
            this.resonsFilterSaleRetCombo.Location = new System.Drawing.Point(449, 51);
            this.resonsFilterSaleRetCombo.Name = "resonsFilterSaleRetCombo";
            this.resonsFilterSaleRetCombo.Size = new System.Drawing.Size(238, 42);
            this.resonsFilterSaleRetCombo.TabIndex = 43;
            this.resonsFilterSaleRetCombo.SelectedIndexChanged += new System.EventHandler(this.resonsFilterSaleRetCombo_SelectedIndexChanged);
            // 
            // dateFilterSaleRetCombo
            // 
            this.dateFilterSaleRetCombo.BackColor = System.Drawing.Color.Transparent;
            this.dateFilterSaleRetCombo.BorderRadius = 8;
            this.dateFilterSaleRetCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateFilterSaleRetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateFilterSaleRetCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterSaleRetCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterSaleRetCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilterSaleRetCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dateFilterSaleRetCombo.ItemHeight = 36;
            this.dateFilterSaleRetCombo.Location = new System.Drawing.Point(703, 51);
            this.dateFilterSaleRetCombo.Name = "dateFilterSaleRetCombo";
            this.dateFilterSaleRetCombo.Size = new System.Drawing.Size(193, 42);
            this.dateFilterSaleRetCombo.TabIndex = 44;
            this.dateFilterSaleRetCombo.SelectedIndexChanged += new System.EventHandler(this.dateFilterSaleRetCombo_SelectedIndexChanged);
            // 
            // salesRetReportDataGrid
            // 
            this.salesRetReportDataGrid.AllowUserToAddRows = false;
            this.salesRetReportDataGrid.AllowUserToDeleteRows = false;
            this.salesRetReportDataGrid.AllowUserToResizeColumns = false;
            this.salesRetReportDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.salesRetReportDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.salesRetReportDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesRetReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.salesRetReportDataGrid.ColumnHeadersHeight = 45;
            this.salesRetReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesRetReportDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.salesRetReportDataGrid.GridColor = System.Drawing.Color.White;
            this.salesRetReportDataGrid.Location = new System.Drawing.Point(13, 120);
            this.salesRetReportDataGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.salesRetReportDataGrid.Name = "salesRetReportDataGrid";
            this.salesRetReportDataGrid.ReadOnly = true;
            this.salesRetReportDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesRetReportDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.salesRetReportDataGrid.RowHeadersVisible = false;
            this.salesRetReportDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.salesRetReportDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.salesRetReportDataGrid.RowTemplate.Height = 35;
            this.salesRetReportDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salesRetReportDataGrid.Size = new System.Drawing.Size(882, 209);
            this.salesRetReportDataGrid.TabIndex = 45;
            this.salesRetReportDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.salesRetReportDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.salesRetReportDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesRetReportDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salesRetReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.salesRetReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.salesRetReportDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.salesRetReportDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.salesRetReportDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.salesRetReportDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salesRetReportDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesRetReportDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.salesRetReportDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.salesRetReportDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.salesRetReportDataGrid.ThemeStyle.ReadOnly = true;
            this.salesRetReportDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.salesRetReportDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salesRetReportDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesRetReportDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.salesRetReportDataGrid.ThemeStyle.RowsStyle.Height = 35;
            this.salesRetReportDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.salesRetReportDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.salesRetReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesRetReportDataGrid_CellContentClick);
            // 
            // salesRetTotAmontLabel
            // 
            this.salesRetTotAmontLabel.BackColor = System.Drawing.Color.Transparent;
            this.salesRetTotAmontLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesRetTotAmontLabel.Location = new System.Drawing.Point(816, 351);
            this.salesRetTotAmontLabel.Name = "salesRetTotAmontLabel";
            this.salesRetTotAmontLabel.Size = new System.Drawing.Size(34, 23);
            this.salesRetTotAmontLabel.TabIndex = 52;
            this.salesRetTotAmontLabel.Text = "0.00";
            this.salesRetTotAmontLabel.Click += new System.EventHandler(this.salesRetTotAmontLabel_Click);
            // 
            // totalExpLabel
            // 
            this.totalExpLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalExpLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpLabel.Location = new System.Drawing.Point(750, 351);
            this.totalExpLabel.Name = "totalExpLabel";
            this.totalExpLabel.Size = new System.Drawing.Size(56, 23);
            this.totalExpLabel.TabIndex = 51;
            this.totalExpLabel.Text = "TOTAL:";
            // 
            // generateSalesRetPdfBtn
            // 
            this.generateSalesRetPdfBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateSalesRetPdfBtn.Animated = true;
            this.generateSalesRetPdfBtn.BorderRadius = 8;
            this.generateSalesRetPdfBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateSalesRetPdfBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateSalesRetPdfBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateSalesRetPdfBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateSalesRetPdfBtn.FillColor = System.Drawing.Color.Green;
            this.generateSalesRetPdfBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSalesRetPdfBtn.ForeColor = System.Drawing.Color.White;
            this.generateSalesRetPdfBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.generateSalesRetPdfBtn.Location = new System.Drawing.Point(640, 392);
            this.generateSalesRetPdfBtn.Name = "generateSalesRetPdfBtn";
            this.generateSalesRetPdfBtn.Size = new System.Drawing.Size(123, 45);
            this.generateSalesRetPdfBtn.TabIndex = 54;
            this.generateSalesRetPdfBtn.Text = "PDF";
            this.generateSalesRetPdfBtn.Click += new System.EventHandler(this.generateSalesRetPdfBtn_Click);
            // 
            // generateSalesRetExcelBtn
            // 
            this.generateSalesRetExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateSalesRetExcelBtn.Animated = true;
            this.generateSalesRetExcelBtn.BorderRadius = 8;
            this.generateSalesRetExcelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateSalesRetExcelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateSalesRetExcelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateSalesRetExcelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateSalesRetExcelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateSalesRetExcelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSalesRetExcelBtn.ForeColor = System.Drawing.Color.White;
            this.generateSalesRetExcelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.generateSalesRetExcelBtn.Location = new System.Drawing.Point(771, 392);
            this.generateSalesRetExcelBtn.Name = "generateSalesRetExcelBtn";
            this.generateSalesRetExcelBtn.Size = new System.Drawing.Size(123, 45);
            this.generateSalesRetExcelBtn.TabIndex = 53;
            this.generateSalesRetExcelBtn.Text = "EXCEL";
            this.generateSalesRetExcelBtn.Click += new System.EventHandler(this.generateSalesRetExcelBtn_Click);
            // 
            // salesRetBorderlessForm
            // 
            this.salesRetBorderlessForm.BorderRadius = 25;
            this.salesRetBorderlessForm.ContainerControl = this;
            this.salesRetBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.salesRetBorderlessForm.TransparentWhileDrag = true;
            // 
            // SalesReturnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 449);
            this.Controls.Add(this.generateSalesRetPdfBtn);
            this.Controls.Add(this.generateSalesRetExcelBtn);
            this.Controls.Add(this.salesRetTotAmontLabel);
            this.Controls.Add(this.totalExpLabel);
            this.Controls.Add(this.salesRetReportDataGrid);
            this.Controls.Add(this.dateFilterSaleRetCombo);
            this.Controls.Add(this.resonsFilterSaleRetCombo);
            this.Controls.Add(this.billNoSearchText);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(908, 449);
            this.MinimumSize = new System.Drawing.Size(908, 449);
            this.Name = "SalesReturnReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReturnReport";
            this.Load += new System.EventHandler(this.SalesReturnReport_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesRetReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox billNoSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox resonsFilterSaleRetCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox dateFilterSaleRetCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView salesRetReportDataGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel salesRetTotAmontLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel totalExpLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateSalesRetPdfBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateSalesRetExcelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm salesRetBorderlessForm;
    }
}