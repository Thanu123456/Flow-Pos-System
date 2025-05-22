namespace EscopeWindowsApp
{
    partial class Variations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Variations));
            this.createVariationsBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.variationsFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.variationsDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.variationsBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createVariationsBtn
            // 
            this.createVariationsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createVariationsBtn.BorderRadius = 8;
            this.createVariationsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createVariationsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createVariationsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createVariationsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createVariationsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createVariationsBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createVariationsBtn.ForeColor = System.Drawing.Color.White;
            this.createVariationsBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createVariationsBtn.Location = new System.Drawing.Point(1158, 30);
            this.createVariationsBtn.Name = "createVariationsBtn";
            this.createVariationsBtn.Size = new System.Drawing.Size(209, 41);
            this.createVariationsBtn.TabIndex = 18;
            this.createVariationsBtn.Text = "Create Variations";
            this.createVariationsBtn.Click += new System.EventHandler(this.createVariationsBtn_Click);
            // 
            // variationsBtnPanel
            // 
            this.variationsBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.variationsBtnPanel.BorderRadius = 8;
            this.variationsBtnPanel.Controls.Add(this.variationsFirstBtn);
            this.variationsBtnPanel.Controls.Add(this.variationsPrevBtn);
            this.variationsBtnPanel.Controls.Add(this.variationsNextBtn);
            this.variationsBtnPanel.Controls.Add(this.variationsLastBtn);
            this.variationsBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.variationsBtnPanel.Name = "variationsBtnPanel";
            this.variationsBtnPanel.Size = new System.Drawing.Size(154, 42);
            this.variationsBtnPanel.TabIndex = 28;
            // 
            // variationsFirstBtn
            // 
            this.variationsFirstBtn.BorderRadius = 6;
            this.variationsFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.variationsFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.variationsFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.variationsFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.variationsFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.variationsFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.variationsFirstBtn.ForeColor = System.Drawing.Color.White;
            this.variationsFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.variationsFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.variationsFirstBtn.Name = "variationsFirstBtn";
            this.variationsFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.variationsFirstBtn.TabIndex = 11;
            this.variationsFirstBtn.Click += new System.EventHandler(this.variationsFirstBtn_Click);
            // 
            // variationsPrevBtn
            // 
            this.variationsPrevBtn.BorderRadius = 6;
            this.variationsPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.variationsPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.variationsPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.variationsPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.variationsPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.variationsPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.variationsPrevBtn.ForeColor = System.Drawing.Color.White;
            this.variationsPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.variationsPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.variationsPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.variationsPrevBtn.Name = "variationsPrevBtn";
            this.variationsPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.variationsPrevBtn.TabIndex = 11;
            this.variationsPrevBtn.Click += new System.EventHandler(this.variationsPrevBtn_Click);
            // 
            // variationsNextBtn
            // 
            this.variationsNextBtn.BorderRadius = 6;
            this.variationsNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.variationsNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.variationsNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.variationsNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.variationsNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.variationsNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.variationsNextBtn.ForeColor = System.Drawing.Color.White;
            this.variationsNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.variationsNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.variationsNextBtn.Location = new System.Drawing.Point(87, 8);
            this.variationsNextBtn.Name = "variationsNextBtn";
            this.variationsNextBtn.Size = new System.Drawing.Size(26, 26);
            this.variationsNextBtn.TabIndex = 9;
            this.variationsNextBtn.Click += new System.EventHandler(this.variationsNextBtn_Click);
            // 
            // variationsLastBtn
            // 
            this.variationsLastBtn.BorderRadius = 6;
            this.variationsLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.variationsLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.variationsLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.variationsLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.variationsLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.variationsLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.variationsLastBtn.ForeColor = System.Drawing.Color.White;
            this.variationsLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.variationsLastBtn.Location = new System.Drawing.Point(130, 8);
            this.variationsLastBtn.Name = "variationsLastBtn";
            this.variationsLastBtn.Size = new System.Drawing.Size(26, 26);
            this.variationsLastBtn.TabIndex = 8;
            this.variationsLastBtn.Click += new System.EventHandler(this.variationsLastBtn_Click);
            // 
            // variationsRefreshBtn
            // 
            this.variationsRefreshBtn.BorderRadius = 8;
            this.variationsRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.variationsRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.variationsRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.variationsRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.variationsRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.variationsRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.variationsRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.variationsRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.variationsRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.variationsRefreshBtn.Location = new System.Drawing.Point(427, 29);
            this.variationsRefreshBtn.Name = "variationsRefreshBtn";
            this.variationsRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.variationsRefreshBtn.TabIndex = 17;
            this.variationsRefreshBtn.Click += new System.EventHandler(this.variationsFilterBtn_Click);
            // 
            // variationsSearchText
            // 
            this.variationsSearchText.BorderColor = System.Drawing.Color.Gray;
            this.variationsSearchText.BorderRadius = 8;
            this.variationsSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.variationsSearchText.DefaultText = "";
            this.variationsSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.variationsSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.variationsSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.variationsSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.variationsSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.variationsSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.variationsSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.variationsSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.variationsSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.variationsSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.variationsSearchText.Location = new System.Drawing.Point(17, 30);
            this.variationsSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.variationsSearchText.Name = "variationsSearchText";
            this.variationsSearchText.PasswordChar = '\0';
            this.variationsSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.variationsSearchText.PlaceholderText = "Search";
            this.variationsSearchText.SelectedText = "";
            this.variationsSearchText.Size = new System.Drawing.Size(400, 42);
            this.variationsSearchText.TabIndex = 16;
            this.variationsSearchText.TextChanged += new System.EventHandler(this.variationsSearchText_TextChanged);
            // 
            // variationsDataGridView
            // 
            this.variationsDataGridView.AllowUserToAddRows = false;
            this.variationsDataGridView.AllowUserToDeleteRows = false;
            this.variationsDataGridView.AllowUserToResizeColumns = false;
            this.variationsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.variationsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.variationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.variationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.variationsDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.variationsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.variationsDataGridView.GridColor = System.Drawing.Color.White;
            this.variationsDataGridView.Location = new System.Drawing.Point(17, 100);
            this.variationsDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.variationsDataGridView.Name = "variationsDataGridView";
            this.variationsDataGridView.ReadOnly = true;
            this.variationsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.variationsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.variationsDataGridView.RowHeadersVisible = false;
            this.variationsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.variationsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.variationsDataGridView.RowTemplate.Height = 35;
            this.variationsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.variationsDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.variationsDataGridView.TabIndex = 34;
            this.variationsDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.variationsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.variationsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.variationsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.variationsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.variationsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.variationsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.variationsDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.variationsDataGridView.ThemeStyle.ReadOnly = true;
            this.variationsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.variationsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.variationsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.variationsDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.variationsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.variationsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Variations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.variationsDataGridView);
            this.Controls.Add(this.variationsBtnPanel);
            this.Controls.Add(this.createVariationsBtn);
            this.Controls.Add(this.variationsRefreshBtn);
            this.Controls.Add(this.variationsSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "Variations";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variations";
            this.Load += new System.EventHandler(this.Variations_Load);
            this.variationsBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.variationsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton createVariationsBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox variationsSearchText;
        private Siticone.Desktop.UI.WinForms.SiticonePanel variationsBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView variationsDataGridView;
    }
}