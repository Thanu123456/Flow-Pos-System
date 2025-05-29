namespace EscopeWindowsApp
{
    partial class ExpiredProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpiredProductsForm));
            this.supplierSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.expiredBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.expiredProductsDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.expiredRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.exCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expiredLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expiredProductsDataGridView)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplierSearchText
            // 
            this.supplierSearchText.BorderColor = System.Drawing.Color.Gray;
            this.supplierSearchText.BorderRadius = 8;
            this.supplierSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplierSearchText.DefaultText = "";
            this.supplierSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supplierSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supplierSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierSearchText.ForeColor = System.Drawing.Color.Gray;
            this.supplierSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.supplierSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.supplierSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.supplierSearchText.Location = new System.Drawing.Point(17, 82);
            this.supplierSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supplierSearchText.Name = "supplierSearchText";
            this.supplierSearchText.PasswordChar = '\0';
            this.supplierSearchText.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.supplierSearchText.PlaceholderText = "Search";
            this.supplierSearchText.SelectedText = "";
            this.supplierSearchText.Size = new System.Drawing.Size(380, 42);
            this.supplierSearchText.TabIndex = 46;
            this.supplierSearchText.TextChanged += new System.EventHandler(this.supplierSearchText_TextChanged);
            // 
            // expiredBorderlessForm
            // 
            this.expiredBorderlessForm.BorderRadius = 12;
            this.expiredBorderlessForm.ContainerControl = this;
            this.expiredBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.expiredBorderlessForm.TransparentWhileDrag = true;
            // 
            // expiredProductsDataGridView
            // 
            this.expiredProductsDataGridView.AllowUserToAddRows = false;
            this.expiredProductsDataGridView.AllowUserToDeleteRows = false;
            this.expiredProductsDataGridView.AllowUserToResizeColumns = false;
            this.expiredProductsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.expiredProductsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.expiredProductsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expiredProductsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.expiredProductsDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expiredProductsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.expiredProductsDataGridView.GridColor = System.Drawing.Color.White;
            this.expiredProductsDataGridView.Location = new System.Drawing.Point(12, 141);
            this.expiredProductsDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.expiredProductsDataGridView.Name = "expiredProductsDataGridView";
            this.expiredProductsDataGridView.ReadOnly = true;
            this.expiredProductsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expiredProductsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.expiredProductsDataGridView.RowHeadersVisible = false;
            this.expiredProductsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.expiredProductsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.expiredProductsDataGridView.RowTemplate.Height = 35;
            this.expiredProductsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.expiredProductsDataGridView.Size = new System.Drawing.Size(906, 265);
            this.expiredProductsDataGridView.TabIndex = 49;
            this.expiredProductsDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.expiredProductsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.expiredProductsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredProductsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.expiredProductsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.expiredProductsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.expiredProductsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.expiredProductsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.expiredProductsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.expiredProductsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.expiredProductsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredProductsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.expiredProductsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.expiredProductsDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.expiredProductsDataGridView.ThemeStyle.ReadOnly = true;
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.expiredProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expiredProductsDataGridView_CellContentClick);
            // 
            // expiredRefreshBtn
            // 
            this.expiredRefreshBtn.Animated = true;
            this.expiredRefreshBtn.BorderRadius = 8;
            this.expiredRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expiredRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expiredRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expiredRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expiredRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.expiredRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expiredRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.expiredRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.expiredRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.expiredRefreshBtn.Location = new System.Drawing.Point(409, 82);
            this.expiredRefreshBtn.Name = "expiredRefreshBtn";
            this.expiredRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.expiredRefreshBtn.TabIndex = 50;
            this.expiredRefreshBtn.Click += new System.EventHandler(this.expiredRefreshBtn_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(939, 34);
            this.headerPanel.TabIndex = 81;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.minimumBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(846, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(93, 30);
            this.controlPanel.TabIndex = 2;
            // 
            // minimumBtn
            // 
            this.minimumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumBtn.BorderRadius = 8;
            this.minimumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimumBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minimumBtn.IconColor = System.Drawing.Color.White;
            this.minimumBtn.Location = new System.Drawing.Point(15, 2);
            this.minimumBtn.Name = "minimumBtn";
            this.minimumBtn.Size = new System.Drawing.Size(26, 26);
            this.minimumBtn.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(46, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 26);
            this.closeBtn.TabIndex = 0;
            // 
            // exCancelBtn
            // 
            this.exCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exCancelBtn.Animated = true;
            this.exCancelBtn.BorderRadius = 8;
            this.exCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exCancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.exCancelBtn.ForeColor = System.Drawing.Color.White;
            this.exCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.exCancelBtn.Location = new System.Drawing.Point(823, 422);
            this.exCancelBtn.Name = "exCancelBtn";
            this.exCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.exCancelBtn.TabIndex = 83;
            this.exCancelBtn.Text = "Cancel";
            this.exCancelBtn.Click += new System.EventHandler(this.exCancelBtn_Click);
            // 
            // expiredLabel
            // 
            this.expiredLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expiredLabel.AutoSize = true;
            this.expiredLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.expiredLabel.Location = new System.Drawing.Point(12, 41);
            this.expiredLabel.Name = "expiredLabel";
            this.expiredLabel.Size = new System.Drawing.Size(183, 29);
            this.expiredLabel.TabIndex = 84;
            this.expiredLabel.Text = "Expired Products";
            // 
            // ExpiredProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 489);
            this.Controls.Add(this.expiredLabel);
            this.Controls.Add(this.exCancelBtn);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.expiredRefreshBtn);
            this.Controls.Add(this.expiredProductsDataGridView);
            this.Controls.Add(this.supplierSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(939, 489);
            this.MinimumSize = new System.Drawing.Size(939, 489);
            this.Name = "ExpiredProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expired Products";
            this.Load += new System.EventHandler(this.ExpiredProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expiredProductsDataGridView)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox supplierSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm expiredBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView expiredProductsDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expiredRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton exCancelBtn;
        private System.Windows.Forms.Label expiredLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
    }
}