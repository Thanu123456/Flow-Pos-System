namespace EscopeWindowsApp
{
    partial class PurchasesReturnReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.retNoSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.resonsFilterPurRetCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.dateFilterPurRetCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.purRetReportDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.purRetTotAmontLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.totalExpLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.generatePurRetPdfBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.generatePurRetExcelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purRetReportDataGrid)).BeginInit();
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
            // retNoSearchText
            // 
            this.retNoSearchText.BorderColor = System.Drawing.Color.Silver;
            this.retNoSearchText.BorderRadius = 8;
            this.retNoSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.retNoSearchText.DefaultText = "";
            this.retNoSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.retNoSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.retNoSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.retNoSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.retNoSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.retNoSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.retNoSearchText.ForeColor = System.Drawing.Color.Gray;
            this.retNoSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.retNoSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.retNoSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.retNoSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.retNoSearchText.Location = new System.Drawing.Point(12, 54);
            this.retNoSearchText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.retNoSearchText.Name = "retNoSearchText";
            this.retNoSearchText.PasswordChar = '\0';
            this.retNoSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.retNoSearchText.PlaceholderText = "Search Return Number";
            this.retNoSearchText.SelectedText = "";
            this.retNoSearchText.Size = new System.Drawing.Size(310, 42);
            this.retNoSearchText.TabIndex = 34;
            this.retNoSearchText.TextChanged += new System.EventHandler(this.retNoSearchText_TextChanged);
            // 
            // resonsFilterPurRetCombo
            // 
            this.resonsFilterPurRetCombo.BackColor = System.Drawing.Color.Transparent;
            this.resonsFilterPurRetCombo.BorderRadius = 8;
            this.resonsFilterPurRetCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.resonsFilterPurRetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resonsFilterPurRetCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resonsFilterPurRetCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resonsFilterPurRetCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resonsFilterPurRetCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.resonsFilterPurRetCombo.ItemHeight = 36;
            this.resonsFilterPurRetCombo.Location = new System.Drawing.Point(445, 54);
            this.resonsFilterPurRetCombo.Name = "resonsFilterPurRetCombo";
            this.resonsFilterPurRetCombo.Size = new System.Drawing.Size(238, 42);
            this.resonsFilterPurRetCombo.TabIndex = 44;
            this.resonsFilterPurRetCombo.SelectedIndexChanged += new System.EventHandler(this.resonsFilterPurRetCombo_SelectedIndexChanged);
            // 
            // dateFilterPurRetCombo
            // 
            this.dateFilterPurRetCombo.BackColor = System.Drawing.Color.Transparent;
            this.dateFilterPurRetCombo.BorderRadius = 8;
            this.dateFilterPurRetCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateFilterPurRetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateFilterPurRetCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterPurRetCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterPurRetCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilterPurRetCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dateFilterPurRetCombo.ItemHeight = 36;
            this.dateFilterPurRetCombo.Location = new System.Drawing.Point(703, 54);
            this.dateFilterPurRetCombo.Name = "dateFilterPurRetCombo";
            this.dateFilterPurRetCombo.Size = new System.Drawing.Size(193, 42);
            this.dateFilterPurRetCombo.TabIndex = 45;
            this.dateFilterPurRetCombo.SelectedIndexChanged += new System.EventHandler(this.dateFilterPurRetCombo_SelectedIndexChanged);
            // 
            // purRetReportDataGrid
            // 
            this.purRetReportDataGrid.AllowUserToAddRows = false;
            this.purRetReportDataGrid.AllowUserToDeleteRows = false;
            this.purRetReportDataGrid.AllowUserToResizeColumns = false;
            this.purRetReportDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.purRetReportDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.purRetReportDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purRetReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.purRetReportDataGrid.ColumnHeadersHeight = 45;
            this.purRetReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purRetReportDataGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.purRetReportDataGrid.GridColor = System.Drawing.Color.White;
            this.purRetReportDataGrid.Location = new System.Drawing.Point(13, 120);
            this.purRetReportDataGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.purRetReportDataGrid.Name = "purRetReportDataGrid";
            this.purRetReportDataGrid.ReadOnly = true;
            this.purRetReportDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purRetReportDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.purRetReportDataGrid.RowHeadersVisible = false;
            this.purRetReportDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.purRetReportDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.purRetReportDataGrid.RowTemplate.Height = 35;
            this.purRetReportDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.purRetReportDataGrid.Size = new System.Drawing.Size(882, 209);
            this.purRetReportDataGrid.TabIndex = 46;
            this.purRetReportDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.purRetReportDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.purRetReportDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purRetReportDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.purRetReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.purRetReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.purRetReportDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.purRetReportDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.purRetReportDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.purRetReportDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.purRetReportDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purRetReportDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.purRetReportDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.purRetReportDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.purRetReportDataGrid.ThemeStyle.ReadOnly = true;
            this.purRetReportDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.purRetReportDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.purRetReportDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purRetReportDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.purRetReportDataGrid.ThemeStyle.RowsStyle.Height = 35;
            this.purRetReportDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.purRetReportDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.purRetReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purRetReportDataGrid_CellContentClick);
            // 
            // purRetTotAmontLabel
            // 
            this.purRetTotAmontLabel.BackColor = System.Drawing.Color.Transparent;
            this.purRetTotAmontLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purRetTotAmontLabel.Location = new System.Drawing.Point(707, 348);
            this.purRetTotAmontLabel.Name = "purRetTotAmontLabel";
            this.purRetTotAmontLabel.Size = new System.Drawing.Size(34, 23);
            this.purRetTotAmontLabel.TabIndex = 54;
            this.purRetTotAmontLabel.Text = "0.00";
            this.purRetTotAmontLabel.Click += new System.EventHandler(this.purRetTotAmontLabel_Click);
            // 
            // totalExpLabel
            // 
            this.totalExpLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalExpLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpLabel.Location = new System.Drawing.Point(641, 348);
            this.totalExpLabel.Name = "totalExpLabel";
            this.totalExpLabel.Size = new System.Drawing.Size(56, 23);
            this.totalExpLabel.TabIndex = 53;
            this.totalExpLabel.Text = "TOTAL:";
            // 
            // generatePurRetPdfBtn
            // 
            this.generatePurRetPdfBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generatePurRetPdfBtn.Animated = true;
            this.generatePurRetPdfBtn.BorderRadius = 8;
            this.generatePurRetPdfBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generatePurRetPdfBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generatePurRetPdfBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generatePurRetPdfBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generatePurRetPdfBtn.FillColor = System.Drawing.Color.Green;
            this.generatePurRetPdfBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePurRetPdfBtn.ForeColor = System.Drawing.Color.White;
            this.generatePurRetPdfBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.generatePurRetPdfBtn.Location = new System.Drawing.Point(641, 387);
            this.generatePurRetPdfBtn.Name = "generatePurRetPdfBtn";
            this.generatePurRetPdfBtn.Size = new System.Drawing.Size(123, 45);
            this.generatePurRetPdfBtn.TabIndex = 56;
            this.generatePurRetPdfBtn.Text = "PDF";
            this.generatePurRetPdfBtn.Click += new System.EventHandler(this.generatePurRetPdfBtn_Click);
            // 
            // generatePurRetExcelBtn
            // 
            this.generatePurRetExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generatePurRetExcelBtn.Animated = true;
            this.generatePurRetExcelBtn.BorderRadius = 8;
            this.generatePurRetExcelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generatePurRetExcelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generatePurRetExcelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generatePurRetExcelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generatePurRetExcelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generatePurRetExcelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePurRetExcelBtn.ForeColor = System.Drawing.Color.White;
            this.generatePurRetExcelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.generatePurRetExcelBtn.Location = new System.Drawing.Point(772, 387);
            this.generatePurRetExcelBtn.Name = "generatePurRetExcelBtn";
            this.generatePurRetExcelBtn.Size = new System.Drawing.Size(123, 45);
            this.generatePurRetExcelBtn.TabIndex = 55;
            this.generatePurRetExcelBtn.Text = "EXCEL";
            this.generatePurRetExcelBtn.Click += new System.EventHandler(this.generatePurRetExcelBtn_Click);
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.BorderRadius = 25;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // PurchasesReturnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 449);
            this.Controls.Add(this.generatePurRetPdfBtn);
            this.Controls.Add(this.generatePurRetExcelBtn);
            this.Controls.Add(this.purRetTotAmontLabel);
            this.Controls.Add(this.totalExpLabel);
            this.Controls.Add(this.purRetReportDataGrid);
            this.Controls.Add(this.dateFilterPurRetCombo);
            this.Controls.Add(this.resonsFilterPurRetCombo);
            this.Controls.Add(this.retNoSearchText);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(908, 449);
            this.MinimumSize = new System.Drawing.Size(908, 449);
            this.Name = "PurchasesReturnReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchasesReturnReport";
            this.Load += new System.EventHandler(this.PurchasesReturnReport_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purRetReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox retNoSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox resonsFilterPurRetCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox dateFilterPurRetCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView purRetReportDataGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel purRetTotAmontLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel totalExpLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generatePurRetPdfBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generatePurRetExcelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
    }
}