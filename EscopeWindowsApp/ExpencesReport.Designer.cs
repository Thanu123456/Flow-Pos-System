namespace EscopeWindowsApp
{
    partial class ExpencesReport
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
            this.dateFilterCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.expencesSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.expencesReportDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.generateExcel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.generatePdfBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expReportBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.totalExpLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.expTotAmontLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expencesReportDataGrid)).BeginInit();
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
            this.headerPanel.TabIndex = 29;
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
            // dateFilterCombo
            // 
            this.dateFilterCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFilterCombo.BackColor = System.Drawing.Color.Transparent;
            this.dateFilterCombo.BorderRadius = 8;
            this.dateFilterCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateFilterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateFilterCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilterCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilterCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dateFilterCombo.ItemHeight = 36;
            this.dateFilterCombo.Location = new System.Drawing.Point(657, 53);
            this.dateFilterCombo.Name = "dateFilterCombo";
            this.dateFilterCombo.Size = new System.Drawing.Size(238, 42);
            this.dateFilterCombo.TabIndex = 42;
            this.dateFilterCombo.SelectedIndexChanged += new System.EventHandler(this.dateFilterCombo_SelectedIndexChanged);
            // 
            // expencesSearchText
            // 
            this.expencesSearchText.BorderColor = System.Drawing.Color.Silver;
            this.expencesSearchText.BorderRadius = 8;
            this.expencesSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expencesSearchText.DefaultText = "";
            this.expencesSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expencesSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expencesSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expencesSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expencesSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expencesSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.expencesSearchText.ForeColor = System.Drawing.Color.Gray;
            this.expencesSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expencesSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.expencesSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.expencesSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.expencesSearchText.Location = new System.Drawing.Point(12, 53);
            this.expencesSearchText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.expencesSearchText.Name = "expencesSearchText";
            this.expencesSearchText.PasswordChar = '\0';
            this.expencesSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.expencesSearchText.PlaceholderText = "Search Expences";
            this.expencesSearchText.SelectedText = "";
            this.expencesSearchText.Size = new System.Drawing.Size(310, 42);
            this.expencesSearchText.TabIndex = 31;
            this.expencesSearchText.TextChanged += new System.EventHandler(this.expencesSearchText_TextChanged);
            // 
            // expencesReportDataGrid
            // 
            this.expencesReportDataGrid.AllowUserToAddRows = false;
            this.expencesReportDataGrid.AllowUserToDeleteRows = false;
            this.expencesReportDataGrid.AllowUserToResizeColumns = false;
            this.expencesReportDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.expencesReportDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.expencesReportDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expencesReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.expencesReportDataGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expencesReportDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.expencesReportDataGrid.GridColor = System.Drawing.Color.White;
            this.expencesReportDataGrid.Location = new System.Drawing.Point(12, 109);
            this.expencesReportDataGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.expencesReportDataGrid.Name = "expencesReportDataGrid";
            this.expencesReportDataGrid.ReadOnly = true;
            this.expencesReportDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expencesReportDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.expencesReportDataGrid.RowHeadersVisible = false;
            this.expencesReportDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.expencesReportDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.expencesReportDataGrid.RowTemplate.Height = 35;
            this.expencesReportDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.expencesReportDataGrid.Size = new System.Drawing.Size(882, 209);
            this.expencesReportDataGrid.TabIndex = 42;
            this.expencesReportDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.expencesReportDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.expencesReportDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expencesReportDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.expencesReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.expencesReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.expencesReportDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.expencesReportDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.expencesReportDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.expencesReportDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.expencesReportDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expencesReportDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.expencesReportDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.expencesReportDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.expencesReportDataGrid.ThemeStyle.ReadOnly = true;
            this.expencesReportDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.expencesReportDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.expencesReportDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expencesReportDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.expencesReportDataGrid.ThemeStyle.RowsStyle.Height = 35;
            this.expencesReportDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.expencesReportDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.expencesReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expencesReportDataGrid_CellContentClick);
            // 
            // generateExcel
            // 
            this.generateExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateExcel.Animated = true;
            this.generateExcel.BorderRadius = 8;
            this.generateExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.generateExcel.ForeColor = System.Drawing.Color.White;
            this.generateExcel.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.generateExcel.Location = new System.Drawing.Point(771, 384);
            this.generateExcel.Name = "generateExcel";
            this.generateExcel.Size = new System.Drawing.Size(123, 45);
            this.generateExcel.TabIndex = 43;
            this.generateExcel.Text = "Excel";
            this.generateExcel.Click += new System.EventHandler(this.generateExcel_Click);
            // 
            // generatePdfBtn
            // 
            this.generatePdfBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generatePdfBtn.Animated = true;
            this.generatePdfBtn.BorderRadius = 8;
            this.generatePdfBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generatePdfBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generatePdfBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generatePdfBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generatePdfBtn.FillColor = System.Drawing.Color.Green;
            this.generatePdfBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.generatePdfBtn.ForeColor = System.Drawing.Color.White;
            this.generatePdfBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.generatePdfBtn.Location = new System.Drawing.Point(640, 384);
            this.generatePdfBtn.Name = "generatePdfBtn";
            this.generatePdfBtn.Size = new System.Drawing.Size(123, 45);
            this.generatePdfBtn.TabIndex = 44;
            this.generatePdfBtn.Text = "Pdf";
            this.generatePdfBtn.Click += new System.EventHandler(this.generatePdfBtn_Click);
            // 
            // expReportBorderlessForm
            // 
            this.expReportBorderlessForm.BorderRadius = 25;
            this.expReportBorderlessForm.ContainerControl = this;
            this.expReportBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.expReportBorderlessForm.TransparentWhileDrag = true;
            // 
            // totalExpLabel
            // 
            this.totalExpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalExpLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpLabel.Location = new System.Drawing.Point(688, 334);
            this.totalExpLabel.Name = "totalExpLabel";
            this.totalExpLabel.Size = new System.Drawing.Size(63, 22);
            this.totalExpLabel.TabIndex = 45;
            this.totalExpLabel.Text = "TOTAL:";
            // 
            // expTotAmontLabel
            // 
            this.expTotAmontLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expTotAmontLabel.BackColor = System.Drawing.Color.Transparent;
            this.expTotAmontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expTotAmontLabel.Location = new System.Drawing.Point(771, 334);
            this.expTotAmontLabel.Name = "expTotAmontLabel";
            this.expTotAmontLabel.Size = new System.Drawing.Size(38, 22);
            this.expTotAmontLabel.TabIndex = 46;
            this.expTotAmontLabel.Text = "0.00";
            this.expTotAmontLabel.Click += new System.EventHandler(this.expTotAmontLabel_Click);
            // 
            // ExpencesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 449);
            this.Controls.Add(this.expTotAmontLabel);
            this.Controls.Add(this.totalExpLabel);
            this.Controls.Add(this.generatePdfBtn);
            this.Controls.Add(this.generateExcel);
            this.Controls.Add(this.expencesReportDataGrid);
            this.Controls.Add(this.expencesSearchText);
            this.Controls.Add(this.dateFilterCombo);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(908, 449);
            this.MinimumSize = new System.Drawing.Size(908, 449);
            this.Name = "ExpencesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpencesReport";
            this.Load += new System.EventHandler(this.ExpencesReport_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expencesReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox dateFilterCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox expencesSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView expencesReportDataGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateExcel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generatePdfBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm expReportBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel expTotAmontLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel totalExpLabel;
    }
}