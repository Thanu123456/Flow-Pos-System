namespace EscopeWindowsApp
{
    partial class CustomerForm
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
            this.cusSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createCusBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.cusFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.cusDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.cusBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cusDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cusSearchText
            // 
            this.cusSearchText.BorderColor = System.Drawing.Color.Gray;
            this.cusSearchText.BorderRadius = 8;
            this.cusSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cusSearchText.DefaultText = "";
            this.cusSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cusSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cusSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusSearchText.ForeColor = System.Drawing.Color.Gray;
            this.cusSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.cusSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.cusSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.cusSearchText.Location = new System.Drawing.Point(17, 30);
            this.cusSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cusSearchText.Name = "cusSearchText";
            this.cusSearchText.PasswordChar = '\0';
            this.cusSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.cusSearchText.PlaceholderText = "Search";
            this.cusSearchText.SelectedText = "";
            this.cusSearchText.Size = new System.Drawing.Size(400, 42);
            this.cusSearchText.TabIndex = 3;
            this.cusSearchText.TextChanged += new System.EventHandler(this.cusSearchText_TextChanged);
            // 
            // createCusBtn
            // 
            this.createCusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createCusBtn.Animated = true;
            this.createCusBtn.BorderRadius = 8;
            this.createCusBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createCusBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createCusBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createCusBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createCusBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createCusBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCusBtn.ForeColor = System.Drawing.Color.White;
            this.createCusBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createCusBtn.Location = new System.Drawing.Point(1158, 30);
            this.createCusBtn.Name = "createCusBtn";
            this.createCusBtn.Size = new System.Drawing.Size(209, 42);
            this.createCusBtn.TabIndex = 5;
            this.createCusBtn.Text = "Craete Customer";
            this.createCusBtn.Click += new System.EventHandler(this.createCusBtn_Click);
            // 
            // cusBtnPanel
            // 
            this.cusBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cusBtnPanel.BackColor = System.Drawing.Color.Transparent;
            this.cusBtnPanel.BorderRadius = 8;
            this.cusBtnPanel.Controls.Add(this.cusFirstBtn);
            this.cusBtnPanel.Controls.Add(this.cusPrevBtn);
            this.cusBtnPanel.Controls.Add(this.cusNextBtn);
            this.cusBtnPanel.Controls.Add(this.cusLastBtn);
            this.cusBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.cusBtnPanel.Name = "cusBtnPanel";
            this.cusBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.cusBtnPanel.TabIndex = 33;
            // 
            // cusFirstBtn
            // 
            this.cusFirstBtn.BorderRadius = 6;
            this.cusFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.cusFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cusFirstBtn.ForeColor = System.Drawing.Color.White;
            this.cusFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.cusFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.cusFirstBtn.Name = "cusFirstBtn";
            this.cusFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.cusFirstBtn.TabIndex = 11;
            this.cusFirstBtn.Click += new System.EventHandler(this.cusFirstBtn_Click);
            // 
            // cusPrevBtn
            // 
            this.cusPrevBtn.BorderRadius = 6;
            this.cusPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.cusPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cusPrevBtn.ForeColor = System.Drawing.Color.White;
            this.cusPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.cusPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.cusPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.cusPrevBtn.Name = "cusPrevBtn";
            this.cusPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.cusPrevBtn.TabIndex = 11;
            this.cusPrevBtn.Click += new System.EventHandler(this.cusPrevBtn_Click);
            // 
            // cusNextBtn
            // 
            this.cusNextBtn.BorderRadius = 6;
            this.cusNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.cusNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cusNextBtn.ForeColor = System.Drawing.Color.White;
            this.cusNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.cusNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.cusNextBtn.Location = new System.Drawing.Point(87, 8);
            this.cusNextBtn.Name = "cusNextBtn";
            this.cusNextBtn.Size = new System.Drawing.Size(26, 26);
            this.cusNextBtn.TabIndex = 9;
            this.cusNextBtn.Click += new System.EventHandler(this.cusNextBtn_Click);
            // 
            // cusLastBtn
            // 
            this.cusLastBtn.BorderRadius = 6;
            this.cusLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.cusLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cusLastBtn.ForeColor = System.Drawing.Color.White;
            this.cusLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.cusLastBtn.Location = new System.Drawing.Point(130, 8);
            this.cusLastBtn.Name = "cusLastBtn";
            this.cusLastBtn.Size = new System.Drawing.Size(26, 26);
            this.cusLastBtn.TabIndex = 8;
            this.cusLastBtn.Click += new System.EventHandler(this.cusLastBtn_Click);
            // 
            // cusRefreshBtn
            // 
            this.cusRefreshBtn.Animated = true;
            this.cusRefreshBtn.BorderRadius = 8;
            this.cusRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.cusRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cusRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.cusRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.cusRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.cusRefreshBtn.Location = new System.Drawing.Point(427, 30);
            this.cusRefreshBtn.Name = "cusRefreshBtn";
            this.cusRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.cusRefreshBtn.TabIndex = 35;
            this.cusRefreshBtn.Click += new System.EventHandler(this.cusRefreshBtn_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BorderRadius = 8;
            this.siticonePanel1.Location = new System.Drawing.Point(801, 12);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(338, 72);
            this.siticonePanel1.TabIndex = 36;
            // 
            // cusDataGridView
            // 
            this.cusDataGridView.AllowUserToAddRows = false;
            this.cusDataGridView.AllowUserToDeleteRows = false;
            this.cusDataGridView.AllowUserToResizeColumns = false;
            this.cusDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.cusDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cusDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cusDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cusDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cusDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.cusDataGridView.GridColor = System.Drawing.Color.White;
            this.cusDataGridView.Location = new System.Drawing.Point(17, 100);
            this.cusDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cusDataGridView.Name = "cusDataGridView";
            this.cusDataGridView.ReadOnly = true;
            this.cusDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cusDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.cusDataGridView.RowHeadersVisible = false;
            this.cusDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cusDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cusDataGridView.RowTemplate.Height = 35;
            this.cusDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cusDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.cusDataGridView.TabIndex = 38;
            this.cusDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.cusDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.cusDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.cusDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cusDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cusDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.cusDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cusDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.cusDataGridView.ThemeStyle.ReadOnly = true;
            this.cusDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.cusDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cusDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.cusDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.cusDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.cusDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.cusDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cusDataGridView_CellContentClick);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.cusDataGridView);
            this.Controls.Add(this.cusRefreshBtn);
            this.Controls.Add(this.cusBtnPanel);
            this.Controls.Add(this.createCusBtn);
            this.Controls.Add(this.cusSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.cusBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cusDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox cusSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createCusBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel cusBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView cusDataGridView;
    }
}