namespace EscopeWindowsApp
{
    partial class CreaditReport
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
            this.dateFilterSupCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.supCreaditsReportDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.generateSupCreaditPdfBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.generateSupCreaditExcelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supCreaditsReportDataGrid)).BeginInit();
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
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
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
            this.supplierSearchText.PlaceholderText = "Search Suppliers";
            this.supplierSearchText.SelectedText = "";
            this.supplierSearchText.Size = new System.Drawing.Size(310, 42);
            this.supplierSearchText.TabIndex = 34;
            this.supplierSearchText.TextChanged += new System.EventHandler(this.supplierSearchText_TextChanged);
            // 
            // dateFilterSupCombo
            // 
            this.dateFilterSupCombo.BackColor = System.Drawing.Color.Transparent;
            this.dateFilterSupCombo.BorderRadius = 8;
            this.dateFilterSupCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateFilterSupCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateFilterSupCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterSupCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterSupCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilterSupCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dateFilterSupCombo.ItemHeight = 36;
            this.dateFilterSupCombo.Location = new System.Drawing.Point(658, 42);
            this.dateFilterSupCombo.Name = "dateFilterSupCombo";
            this.dateFilterSupCombo.Size = new System.Drawing.Size(238, 42);
            this.dateFilterSupCombo.TabIndex = 44;
            this.dateFilterSupCombo.SelectedIndexChanged += new System.EventHandler(this.dateFilterSupCombo_SelectedIndexChanged);
            // 
            // supCreaditsReportDataGrid
            // 
            this.supCreaditsReportDataGrid.AllowUserToAddRows = false;
            this.supCreaditsReportDataGrid.AllowUserToDeleteRows = false;
            this.supCreaditsReportDataGrid.AllowUserToResizeColumns = false;
            this.supCreaditsReportDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.supCreaditsReportDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.supCreaditsReportDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supCreaditsReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.supCreaditsReportDataGrid.ColumnHeadersHeight = 45;
            this.supCreaditsReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supCreaditsReportDataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.supCreaditsReportDataGrid.GridColor = System.Drawing.Color.White;
            this.supCreaditsReportDataGrid.Location = new System.Drawing.Point(13, 97);
            this.supCreaditsReportDataGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.supCreaditsReportDataGrid.Name = "supCreaditsReportDataGrid";
            this.supCreaditsReportDataGrid.ReadOnly = true;
            this.supCreaditsReportDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supCreaditsReportDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.supCreaditsReportDataGrid.RowHeadersVisible = false;
            this.supCreaditsReportDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.supCreaditsReportDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.supCreaditsReportDataGrid.RowTemplate.Height = 35;
            this.supCreaditsReportDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.supCreaditsReportDataGrid.Size = new System.Drawing.Size(882, 254);
            this.supCreaditsReportDataGrid.TabIndex = 45;
            this.supCreaditsReportDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.supCreaditsReportDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.supCreaditsReportDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supCreaditsReportDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.supCreaditsReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.supCreaditsReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.supCreaditsReportDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.supCreaditsReportDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.supCreaditsReportDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.supCreaditsReportDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.supCreaditsReportDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supCreaditsReportDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.supCreaditsReportDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.supCreaditsReportDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.supCreaditsReportDataGrid.ThemeStyle.ReadOnly = true;
            this.supCreaditsReportDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.supCreaditsReportDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.supCreaditsReportDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supCreaditsReportDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.supCreaditsReportDataGrid.ThemeStyle.RowsStyle.Height = 35;
            this.supCreaditsReportDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.supCreaditsReportDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.supCreaditsReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supCreaditsReportDataGrid_CellContentClick);
            // 
            // generateSupCreaditPdfBtn
            // 
            this.generateSupCreaditPdfBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateSupCreaditPdfBtn.Animated = true;
            this.generateSupCreaditPdfBtn.BorderRadius = 8;
            this.generateSupCreaditPdfBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateSupCreaditPdfBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateSupCreaditPdfBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateSupCreaditPdfBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateSupCreaditPdfBtn.FillColor = System.Drawing.Color.Green;
            this.generateSupCreaditPdfBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSupCreaditPdfBtn.ForeColor = System.Drawing.Color.White;
            this.generateSupCreaditPdfBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.generateSupCreaditPdfBtn.Location = new System.Drawing.Point(642, 392);
            this.generateSupCreaditPdfBtn.Name = "generateSupCreaditPdfBtn";
            this.generateSupCreaditPdfBtn.Size = new System.Drawing.Size(123, 45);
            this.generateSupCreaditPdfBtn.TabIndex = 52;
            this.generateSupCreaditPdfBtn.Text = "PDF";
            this.generateSupCreaditPdfBtn.Click += new System.EventHandler(this.generateSupCreaditPdfBtn_Click);
            // 
            // generateSupCreaditExcelBtn
            // 
            this.generateSupCreaditExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateSupCreaditExcelBtn.Animated = true;
            this.generateSupCreaditExcelBtn.BorderRadius = 8;
            this.generateSupCreaditExcelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateSupCreaditExcelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateSupCreaditExcelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateSupCreaditExcelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateSupCreaditExcelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateSupCreaditExcelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSupCreaditExcelBtn.ForeColor = System.Drawing.Color.White;
            this.generateSupCreaditExcelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.generateSupCreaditExcelBtn.Location = new System.Drawing.Point(773, 392);
            this.generateSupCreaditExcelBtn.Name = "generateSupCreaditExcelBtn";
            this.generateSupCreaditExcelBtn.Size = new System.Drawing.Size(123, 45);
            this.generateSupCreaditExcelBtn.TabIndex = 51;
            this.generateSupCreaditExcelBtn.Text = "EXCEL";
            this.generateSupCreaditExcelBtn.Click += new System.EventHandler(this.generateSupCreaditExcelBtn_Click);
            // 
            // CreaditReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 449);
            this.Controls.Add(this.generateSupCreaditPdfBtn);
            this.Controls.Add(this.generateSupCreaditExcelBtn);
            this.Controls.Add(this.supCreaditsReportDataGrid);
            this.Controls.Add(this.dateFilterSupCombo);
            this.Controls.Add(this.supplierSearchText);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(908, 449);
            this.MinimumSize = new System.Drawing.Size(908, 449);
            this.Name = "CreaditReport";
            this.Text = "CreaditReport";
            this.Load += new System.EventHandler(this.CreaditReport_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supCreaditsReportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox supplierSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox dateFilterSupCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView supCreaditsReportDataGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateSupCreaditPdfBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateSupCreaditExcelBtn;
    }
}