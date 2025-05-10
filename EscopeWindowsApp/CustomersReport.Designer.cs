namespace EscopeWindowsApp
{
    partial class CustomersReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersReport));
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.dateFilterCusCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.customersReportDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.generateCustomersExcelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.generateCustomersPdfBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.customerSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.cusReportBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersReportDataGrid)).BeginInit();
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
            // dateFilterCusCombo
            // 
            this.dateFilterCusCombo.BackColor = System.Drawing.Color.Transparent;
            this.dateFilterCusCombo.BorderRadius = 8;
            this.dateFilterCusCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateFilterCusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateFilterCusCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterCusCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterCusCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilterCusCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dateFilterCusCombo.ItemHeight = 36;
            this.dateFilterCusCombo.Location = new System.Drawing.Point(658, 53);
            this.dateFilterCusCombo.Name = "dateFilterCusCombo";
            this.dateFilterCusCombo.Size = new System.Drawing.Size(238, 42);
            this.dateFilterCusCombo.TabIndex = 43;
            this.dateFilterCusCombo.SelectedIndexChanged += new System.EventHandler(this.dateFilterCusCombo_SelectedIndexChanged);
            // 
            // customersReportDataGrid
            // 
            this.customersReportDataGrid.AllowUserToAddRows = false;
            this.customersReportDataGrid.AllowUserToDeleteRows = false;
            this.customersReportDataGrid.AllowUserToResizeColumns = false;
            this.customersReportDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.customersReportDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customersReportDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customersReportDataGrid.ColumnHeadersHeight = 45;
            this.customersReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersReportDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.customersReportDataGrid.GridColor = System.Drawing.Color.White;
            this.customersReportDataGrid.Location = new System.Drawing.Point(12, 109);
            this.customersReportDataGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.customersReportDataGrid.Name = "customersReportDataGrid";
            this.customersReportDataGrid.ReadOnly = true;
            this.customersReportDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersReportDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.customersReportDataGrid.RowHeadersVisible = false;
            this.customersReportDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customersReportDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.customersReportDataGrid.RowTemplate.Height = 35;
            this.customersReportDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customersReportDataGrid.Size = new System.Drawing.Size(882, 254);
            this.customersReportDataGrid.TabIndex = 44;
            this.customersReportDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.customersReportDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customersReportDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersReportDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customersReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.customersReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.customersReportDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.customersReportDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.customersReportDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.customersReportDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customersReportDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersReportDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.customersReportDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.customersReportDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.customersReportDataGrid.ThemeStyle.ReadOnly = true;
            this.customersReportDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.customersReportDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customersReportDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersReportDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.customersReportDataGrid.ThemeStyle.RowsStyle.Height = 35;
            this.customersReportDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.customersReportDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.customersReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersReportDataGrid_CellContentClick);
            // 
            // generateCustomersExcelBtn
            // 
            this.generateCustomersExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateCustomersExcelBtn.Animated = true;
            this.generateCustomersExcelBtn.BorderRadius = 8;
            this.generateCustomersExcelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateCustomersExcelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateCustomersExcelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateCustomersExcelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateCustomersExcelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateCustomersExcelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateCustomersExcelBtn.ForeColor = System.Drawing.Color.White;
            this.generateCustomersExcelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.generateCustomersExcelBtn.Location = new System.Drawing.Point(771, 384);
            this.generateCustomersExcelBtn.Name = "generateCustomersExcelBtn";
            this.generateCustomersExcelBtn.Size = new System.Drawing.Size(123, 45);
            this.generateCustomersExcelBtn.TabIndex = 49;
            this.generateCustomersExcelBtn.Text = "EXCEL";
            this.generateCustomersExcelBtn.Click += new System.EventHandler(this.generateCustomersExcelBtn_Click);
            // 
            // generateCustomersPdfBtn
            // 
            this.generateCustomersPdfBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateCustomersPdfBtn.Animated = true;
            this.generateCustomersPdfBtn.BorderRadius = 8;
            this.generateCustomersPdfBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateCustomersPdfBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateCustomersPdfBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateCustomersPdfBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateCustomersPdfBtn.FillColor = System.Drawing.Color.Green;
            this.generateCustomersPdfBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateCustomersPdfBtn.ForeColor = System.Drawing.Color.White;
            this.generateCustomersPdfBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.generateCustomersPdfBtn.Location = new System.Drawing.Point(640, 384);
            this.generateCustomersPdfBtn.Name = "generateCustomersPdfBtn";
            this.generateCustomersPdfBtn.Size = new System.Drawing.Size(123, 45);
            this.generateCustomersPdfBtn.TabIndex = 50;
            this.generateCustomersPdfBtn.Text = "PDF";
            this.generateCustomersPdfBtn.Click += new System.EventHandler(this.generateCustomersPdfBtn_Click);
            // 
            // customerSearchText
            // 
            this.customerSearchText.BorderColor = System.Drawing.Color.Silver;
            this.customerSearchText.BorderRadius = 8;
            this.customerSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerSearchText.DefaultText = "";
            this.customerSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSearchText.ForeColor = System.Drawing.Color.Gray;
            this.customerSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.customerSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.customerSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.customerSearchText.Location = new System.Drawing.Point(12, 53);
            this.customerSearchText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.customerSearchText.Name = "customerSearchText";
            this.customerSearchText.PasswordChar = '\0';
            this.customerSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.customerSearchText.PlaceholderText = "Search Customers";
            this.customerSearchText.SelectedText = "";
            this.customerSearchText.Size = new System.Drawing.Size(310, 42);
            this.customerSearchText.TabIndex = 33;
            this.customerSearchText.TextChanged += new System.EventHandler(this.customerSearchText_TextChanged);
            // 
            // cusReportBorderlessForm
            // 
            this.cusReportBorderlessForm.BorderRadius = 25;
            this.cusReportBorderlessForm.ContainerControl = this;
            this.cusReportBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.cusReportBorderlessForm.TransparentWhileDrag = true;
            // 
            // CustomersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 449);
            this.Controls.Add(this.generateCustomersPdfBtn);
            this.Controls.Add(this.generateCustomersExcelBtn);
            this.Controls.Add(this.customersReportDataGrid);
            this.Controls.Add(this.dateFilterCusCombo);
            this.Controls.Add(this.customerSearchText);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(908, 449);
            this.MinimumSize = new System.Drawing.Size(908, 449);
            this.Name = "CustomersReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Reports";
            this.Load += new System.EventHandler(this.CustomersReport_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersReportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox customerSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox dateFilterCusCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView customersReportDataGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateCustomersPdfBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateCustomersExcelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm cusReportBorderlessForm;
    }
}