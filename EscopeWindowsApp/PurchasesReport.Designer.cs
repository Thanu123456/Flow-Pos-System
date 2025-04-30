namespace EscopeWindowsApp
{
    partial class PurchasesReport
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
            this.purSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.dateFilterPurCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.purReportDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.purTotAmontLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.totalExpLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.generatePurchasesPdfBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.generatePurchasesExcelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purReportDataGrid)).BeginInit();
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
            // purSearchText
            // 
            this.purSearchText.BorderColor = System.Drawing.Color.Silver;
            this.purSearchText.BorderRadius = 8;
            this.purSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purSearchText.DefaultText = "";
            this.purSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.purSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.purSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.purSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.purSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.purSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.purSearchText.ForeColor = System.Drawing.Color.Gray;
            this.purSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.purSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.purSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.purSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.purSearchText.Location = new System.Drawing.Point(12, 42);
            this.purSearchText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.purSearchText.Name = "purSearchText";
            this.purSearchText.PasswordChar = '\0';
            this.purSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.purSearchText.PlaceholderText = "Search Purchases";
            this.purSearchText.SelectedText = "";
            this.purSearchText.Size = new System.Drawing.Size(310, 42);
            this.purSearchText.TabIndex = 33;
            this.purSearchText.TextChanged += new System.EventHandler(this.purSearchText_TextChanged);
            // 
            // dateFilterPurCombo
            // 
            this.dateFilterPurCombo.BackColor = System.Drawing.Color.Transparent;
            this.dateFilterPurCombo.BorderRadius = 8;
            this.dateFilterPurCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateFilterPurCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateFilterPurCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterPurCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterPurCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilterPurCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dateFilterPurCombo.ItemHeight = 36;
            this.dateFilterPurCombo.Location = new System.Drawing.Point(656, 42);
            this.dateFilterPurCombo.Name = "dateFilterPurCombo";
            this.dateFilterPurCombo.Size = new System.Drawing.Size(238, 42);
            this.dateFilterPurCombo.TabIndex = 43;
            this.dateFilterPurCombo.SelectedIndexChanged += new System.EventHandler(this.dateFilterPurCombo_SelectedIndexChanged);
            // 
            // purReportDataGrid
            // 
            this.purReportDataGrid.AllowUserToAddRows = false;
            this.purReportDataGrid.AllowUserToDeleteRows = false;
            this.purReportDataGrid.AllowUserToResizeColumns = false;
            this.purReportDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.purReportDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.purReportDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.purReportDataGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purReportDataGrid.DefaultCellStyle = dataGridViewCellStyle15;
            this.purReportDataGrid.GridColor = System.Drawing.Color.White;
            this.purReportDataGrid.Location = new System.Drawing.Point(12, 107);
            this.purReportDataGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.purReportDataGrid.Name = "purReportDataGrid";
            this.purReportDataGrid.ReadOnly = true;
            this.purReportDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purReportDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.purReportDataGrid.RowHeadersVisible = false;
            this.purReportDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.purReportDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.purReportDataGrid.RowTemplate.Height = 35;
            this.purReportDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.purReportDataGrid.Size = new System.Drawing.Size(882, 212);
            this.purReportDataGrid.TabIndex = 44;
            this.purReportDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.purReportDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.purReportDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purReportDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.purReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.purReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.purReportDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.purReportDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.purReportDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.purReportDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.purReportDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purReportDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.purReportDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.purReportDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.purReportDataGrid.ThemeStyle.ReadOnly = true;
            this.purReportDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.purReportDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.purReportDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purReportDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.purReportDataGrid.ThemeStyle.RowsStyle.Height = 35;
            this.purReportDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.purReportDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.purReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purReportDataGrid_CellContentClick);
            // 
            // purTotAmontLabel
            // 
            this.purTotAmontLabel.BackColor = System.Drawing.Color.Transparent;
            this.purTotAmontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purTotAmontLabel.Location = new System.Drawing.Point(771, 342);
            this.purTotAmontLabel.Name = "purTotAmontLabel";
            this.purTotAmontLabel.Size = new System.Drawing.Size(38, 22);
            this.purTotAmontLabel.TabIndex = 54;
            this.purTotAmontLabel.Text = "0.00";
            this.purTotAmontLabel.Click += new System.EventHandler(this.purTotAmontLabel_Click);
            // 
            // totalExpLabel
            // 
            this.totalExpLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpLabel.Location = new System.Drawing.Point(688, 342);
            this.totalExpLabel.Name = "totalExpLabel";
            this.totalExpLabel.Size = new System.Drawing.Size(63, 22);
            this.totalExpLabel.TabIndex = 53;
            this.totalExpLabel.Text = "TOTAL:";
            // 
            // generatePurchasesPdfBtn
            // 
            this.generatePurchasesPdfBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generatePurchasesPdfBtn.Animated = true;
            this.generatePurchasesPdfBtn.BorderRadius = 8;
            this.generatePurchasesPdfBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generatePurchasesPdfBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generatePurchasesPdfBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generatePurchasesPdfBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generatePurchasesPdfBtn.FillColor = System.Drawing.Color.Green;
            this.generatePurchasesPdfBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePurchasesPdfBtn.ForeColor = System.Drawing.Color.White;
            this.generatePurchasesPdfBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.generatePurchasesPdfBtn.Location = new System.Drawing.Point(640, 392);
            this.generatePurchasesPdfBtn.Name = "generatePurchasesPdfBtn";
            this.generatePurchasesPdfBtn.Size = new System.Drawing.Size(123, 45);
            this.generatePurchasesPdfBtn.TabIndex = 52;
            this.generatePurchasesPdfBtn.Text = "PDF";
            this.generatePurchasesPdfBtn.Click += new System.EventHandler(this.generatePurchasesPdfBtn_Click);
            // 
            // generatePurchasesExcelBtn
            // 
            this.generatePurchasesExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generatePurchasesExcelBtn.Animated = true;
            this.generatePurchasesExcelBtn.BorderRadius = 8;
            this.generatePurchasesExcelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generatePurchasesExcelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generatePurchasesExcelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generatePurchasesExcelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generatePurchasesExcelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generatePurchasesExcelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePurchasesExcelBtn.ForeColor = System.Drawing.Color.White;
            this.generatePurchasesExcelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.generatePurchasesExcelBtn.Location = new System.Drawing.Point(771, 392);
            this.generatePurchasesExcelBtn.Name = "generatePurchasesExcelBtn";
            this.generatePurchasesExcelBtn.Size = new System.Drawing.Size(123, 45);
            this.generatePurchasesExcelBtn.TabIndex = 51;
            this.generatePurchasesExcelBtn.Text = "EXCEL";
            this.generatePurchasesExcelBtn.Click += new System.EventHandler(this.generatePurchasesExcelBtn_Click);
            // 
            // PurchasesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 449);
            this.Controls.Add(this.purTotAmontLabel);
            this.Controls.Add(this.totalExpLabel);
            this.Controls.Add(this.generatePurchasesPdfBtn);
            this.Controls.Add(this.generatePurchasesExcelBtn);
            this.Controls.Add(this.purReportDataGrid);
            this.Controls.Add(this.dateFilterPurCombo);
            this.Controls.Add(this.purSearchText);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchasesReport";
            this.Text = "PurchasesReport";
            this.Load += new System.EventHandler(this.PurchasesReport_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox purSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox dateFilterPurCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView purReportDataGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel purTotAmontLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel totalExpLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generatePurchasesPdfBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generatePurchasesExcelBtn;
    }
}