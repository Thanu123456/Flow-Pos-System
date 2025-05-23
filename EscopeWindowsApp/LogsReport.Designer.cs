﻿namespace EscopeWindowsApp
{
    partial class LogsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsReport));
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.logsSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.logsReportDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.selectLogDateTime = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.logsReportFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.logsRepBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logsReportDataGrid)).BeginInit();
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
            this.headerPanel.Size = new System.Drawing.Size(1049, 34);
            this.headerPanel.TabIndex = 32;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(957, 2);
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
            // logsSearchText
            // 
            this.logsSearchText.BorderColor = System.Drawing.Color.Silver;
            this.logsSearchText.BorderRadius = 8;
            this.logsSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logsSearchText.DefaultText = "";
            this.logsSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.logsSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.logsSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logsSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logsSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logsSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsSearchText.ForeColor = System.Drawing.Color.Gray;
            this.logsSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logsSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.logsSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.logsSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.logsSearchText.Location = new System.Drawing.Point(12, 51);
            this.logsSearchText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.logsSearchText.Name = "logsSearchText";
            this.logsSearchText.PasswordChar = '\0';
            this.logsSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.logsSearchText.PlaceholderText = "Search Username";
            this.logsSearchText.SelectedText = "";
            this.logsSearchText.Size = new System.Drawing.Size(310, 42);
            this.logsSearchText.TabIndex = 34;
            this.logsSearchText.TextChanged += new System.EventHandler(this.logsSearchText_TextChanged);
            // 
            // logsReportDataGrid
            // 
            this.logsReportDataGrid.AllowUserToAddRows = false;
            this.logsReportDataGrid.AllowUserToDeleteRows = false;
            this.logsReportDataGrid.AllowUserToResizeColumns = false;
            this.logsReportDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.logsReportDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.logsReportDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.logsReportDataGrid.ColumnHeadersHeight = 45;
            this.logsReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logsReportDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.logsReportDataGrid.GridColor = System.Drawing.Color.White;
            this.logsReportDataGrid.Location = new System.Drawing.Point(12, 114);
            this.logsReportDataGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.logsReportDataGrid.Name = "logsReportDataGrid";
            this.logsReportDataGrid.ReadOnly = true;
            this.logsReportDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsReportDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.logsReportDataGrid.RowHeadersVisible = false;
            this.logsReportDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.logsReportDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.logsReportDataGrid.RowTemplate.Height = 35;
            this.logsReportDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logsReportDataGrid.Size = new System.Drawing.Size(1022, 313);
            this.logsReportDataGrid.TabIndex = 45;
            this.logsReportDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.logsReportDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logsReportDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsReportDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logsReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.logsReportDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.logsReportDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.logsReportDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.logsReportDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.logsReportDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.logsReportDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsReportDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.logsReportDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.logsReportDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.logsReportDataGrid.ThemeStyle.ReadOnly = true;
            this.logsReportDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.logsReportDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.logsReportDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsReportDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.logsReportDataGrid.ThemeStyle.RowsStyle.Height = 35;
            this.logsReportDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.logsReportDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.logsReportDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.logsReportDataGrid_CellContentClick);
            // 
            // selectLogDateTime
            // 
            this.selectLogDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectLogDateTime.BackColor = System.Drawing.Color.Transparent;
            this.selectLogDateTime.BorderColor = System.Drawing.Color.Gray;
            this.selectLogDateTime.BorderRadius = 8;
            this.selectLogDateTime.BorderThickness = 1;
            this.selectLogDateTime.Checked = true;
            this.selectLogDateTime.FillColor = System.Drawing.Color.White;
            this.selectLogDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLogDateTime.ForeColor = System.Drawing.Color.Black;
            this.selectLogDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.selectLogDateTime.Location = new System.Drawing.Point(766, 51);
            this.selectLogDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.selectLogDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.selectLogDateTime.Name = "selectLogDateTime";
            this.selectLogDateTime.Size = new System.Drawing.Size(268, 42);
            this.selectLogDateTime.TabIndex = 47;
            this.selectLogDateTime.UseTransparentBackground = true;
            this.selectLogDateTime.Value = new System.DateTime(2025, 2, 28, 12, 17, 13, 576);
            this.selectLogDateTime.ValueChanged += new System.EventHandler(this.selectLogDateTime_ValueChanged);
            // 
            // logsReportFilterBtn
            // 
            this.logsReportFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logsReportFilterBtn.Animated = true;
            this.logsReportFilterBtn.BorderRadius = 8;
            this.logsReportFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logsReportFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logsReportFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logsReportFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logsReportFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.logsReportFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logsReportFilterBtn.ForeColor = System.Drawing.Color.White;
            this.logsReportFilterBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.logsReportFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.whitefilter;
            this.logsReportFilterBtn.Location = new System.Drawing.Point(710, 51);
            this.logsReportFilterBtn.Name = "logsReportFilterBtn";
            this.logsReportFilterBtn.Size = new System.Drawing.Size(42, 42);
            this.logsReportFilterBtn.TabIndex = 46;
            this.logsReportFilterBtn.Click += new System.EventHandler(this.logsReportFilterBtn_Click);
            // 
            // logsRepBorderlessForm
            // 
            this.logsRepBorderlessForm.BorderRadius = 25;
            this.logsRepBorderlessForm.ContainerControl = this;
            this.logsRepBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.logsRepBorderlessForm.TransparentWhileDrag = true;
            // 
            // LogsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 450);
            this.Controls.Add(this.selectLogDateTime);
            this.Controls.Add(this.logsReportFilterBtn);
            this.Controls.Add(this.logsReportDataGrid);
            this.Controls.Add(this.logsSearchText);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1049, 450);
            this.MinimumSize = new System.Drawing.Size(1049, 450);
            this.Name = "LogsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs Reports";
            this.Load += new System.EventHandler(this.LogsReport_Load_1);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logsReportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox logsSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView logsReportDataGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker selectLogDateTime;
        private Siticone.Desktop.UI.WinForms.SiticoneButton logsReportFilterBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm logsRepBorderlessForm;
    }
}