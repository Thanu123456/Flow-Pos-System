namespace EscopeWindowsApp
{
    partial class Quotations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quotations));
            this.createQuotaBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.quotaBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.quotaFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.quotaPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.quotaNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.quotaLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.quotaSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.quotaDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.quotaBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quotaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createQuotaBtn
            // 
            this.createQuotaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createQuotaBtn.Animated = true;
            this.createQuotaBtn.BackColor = System.Drawing.Color.Transparent;
            this.createQuotaBtn.BorderRadius = 8;
            this.createQuotaBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createQuotaBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createQuotaBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createQuotaBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createQuotaBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createQuotaBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuotaBtn.ForeColor = System.Drawing.Color.White;
            this.createQuotaBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createQuotaBtn.Location = new System.Drawing.Point(1158, 30);
            this.createQuotaBtn.Name = "createQuotaBtn";
            this.createQuotaBtn.Size = new System.Drawing.Size(209, 42);
            this.createQuotaBtn.TabIndex = 3;
            this.createQuotaBtn.Text = "Create Quotation";
            this.createQuotaBtn.Click += new System.EventHandler(this.createQuotaBtn_Click);
            // 
            // quotaBtnPanel
            // 
            this.quotaBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quotaBtnPanel.BackColor = System.Drawing.Color.Transparent;
            this.quotaBtnPanel.BorderRadius = 8;
            this.quotaBtnPanel.Controls.Add(this.quotaFirstBtn);
            this.quotaBtnPanel.Controls.Add(this.quotaPrevBtn);
            this.quotaBtnPanel.Controls.Add(this.quotaNextBtn);
            this.quotaBtnPanel.Controls.Add(this.quotaLastBtn);
            this.quotaBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.quotaBtnPanel.Name = "quotaBtnPanel";
            this.quotaBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.quotaBtnPanel.TabIndex = 21;
            this.quotaBtnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.quotaBtnPanel_Paint);
            // 
            // quotaFirstBtn
            // 
            this.quotaFirstBtn.BorderRadius = 6;
            this.quotaFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quotaFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quotaFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quotaFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quotaFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.quotaFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quotaFirstBtn.ForeColor = System.Drawing.Color.White;
            this.quotaFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.quotaFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.quotaFirstBtn.Name = "quotaFirstBtn";
            this.quotaFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.quotaFirstBtn.TabIndex = 11;
            this.quotaFirstBtn.Click += new System.EventHandler(this.quotaFirstBtn_Click);
            // 
            // quotaPrevBtn
            // 
            this.quotaPrevBtn.BorderRadius = 6;
            this.quotaPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quotaPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quotaPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quotaPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quotaPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.quotaPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quotaPrevBtn.ForeColor = System.Drawing.Color.White;
            this.quotaPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.quotaPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.quotaPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.quotaPrevBtn.Name = "quotaPrevBtn";
            this.quotaPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.quotaPrevBtn.TabIndex = 11;
            this.quotaPrevBtn.Click += new System.EventHandler(this.quotaPrevBtn_Click);
            // 
            // quotaNextBtn
            // 
            this.quotaNextBtn.BorderRadius = 6;
            this.quotaNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quotaNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quotaNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quotaNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quotaNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.quotaNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quotaNextBtn.ForeColor = System.Drawing.Color.White;
            this.quotaNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.quotaNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.quotaNextBtn.Location = new System.Drawing.Point(87, 8);
            this.quotaNextBtn.Name = "quotaNextBtn";
            this.quotaNextBtn.Size = new System.Drawing.Size(26, 26);
            this.quotaNextBtn.TabIndex = 9;
            this.quotaNextBtn.Click += new System.EventHandler(this.quotaNextBtn_Click);
            // 
            // quotaLastBtn
            // 
            this.quotaLastBtn.BorderRadius = 6;
            this.quotaLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quotaLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quotaLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quotaLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quotaLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.quotaLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quotaLastBtn.ForeColor = System.Drawing.Color.White;
            this.quotaLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.quotaLastBtn.Location = new System.Drawing.Point(130, 8);
            this.quotaLastBtn.Name = "quotaLastBtn";
            this.quotaLastBtn.Size = new System.Drawing.Size(26, 26);
            this.quotaLastBtn.TabIndex = 8;
            this.quotaLastBtn.Click += new System.EventHandler(this.quotaLastBtn_Click);
            // 
            // quotaSearchText
            // 
            this.quotaSearchText.BorderRadius = 8;
            this.quotaSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quotaSearchText.DefaultText = "";
            this.quotaSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quotaSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quotaSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quotaSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quotaSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quotaSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.quotaSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quotaSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.quotaSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.quotaSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.quotaSearchText.Location = new System.Drawing.Point(17, 30);
            this.quotaSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quotaSearchText.Name = "quotaSearchText";
            this.quotaSearchText.PasswordChar = '\0';
            this.quotaSearchText.PlaceholderText = "Search";
            this.quotaSearchText.SelectedText = "";
            this.quotaSearchText.Size = new System.Drawing.Size(400, 42);
            this.quotaSearchText.TabIndex = 1;
            this.quotaSearchText.TextChanged += new System.EventHandler(this.quotaSearchText_TextChanged);
            // 
            // quotaDataGridView
            // 
            this.quotaDataGridView.AllowUserToAddRows = false;
            this.quotaDataGridView.AllowUserToDeleteRows = false;
            this.quotaDataGridView.AllowUserToResizeColumns = false;
            this.quotaDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.quotaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.quotaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.quotaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.quotaDataGridView.ColumnHeadersHeight = 45;
            this.quotaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.quotaDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.quotaDataGridView.GridColor = System.Drawing.Color.White;
            this.quotaDataGridView.Location = new System.Drawing.Point(17, 100);
            this.quotaDataGridView.Name = "quotaDataGridView";
            this.quotaDataGridView.ReadOnly = true;
            this.quotaDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.quotaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.quotaDataGridView.RowHeadersVisible = false;
            this.quotaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.quotaDataGridView.RowTemplate.Height = 35;
            this.quotaDataGridView.ShowEditingIcon = false;
            this.quotaDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.quotaDataGridView.TabIndex = 30;
            this.quotaDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.quotaDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quotaDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.quotaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.quotaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.quotaDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.quotaDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.quotaDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.quotaDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.quotaDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.quotaDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.quotaDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.quotaDataGridView.ThemeStyle.ReadOnly = true;
            this.quotaDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.quotaDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.quotaDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotaDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.quotaDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.quotaDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.quotaDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Quotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.quotaDataGridView);
            this.Controls.Add(this.quotaBtnPanel);
            this.Controls.Add(this.createQuotaBtn);
            this.Controls.Add(this.quotaSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "Quotations";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quotations";
            this.Load += new System.EventHandler(this.Quotations_Load);
            this.quotaBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quotaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox quotaSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createQuotaBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel quotaBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton quotaFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton quotaPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton quotaNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton quotaLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView quotaDataGridView;
    }
}