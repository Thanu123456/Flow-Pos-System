namespace EscopeWindowsApp
{
    partial class BaseUnit
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
            this.baseUnitsBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.baseUnitsBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.baseUnitsFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.baseUnitsPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.baseUnitsNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.baseUnitsLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.baseUnitFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.baseUnitSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.baseUnitDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.baseUnitsBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseUnitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // baseUnitsBtn
            // 
            this.baseUnitsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseUnitsBtn.Animated = true;
            this.baseUnitsBtn.BorderRadius = 8;
            this.baseUnitsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baseUnitsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baseUnitsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baseUnitsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baseUnitsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.baseUnitsBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseUnitsBtn.ForeColor = System.Drawing.Color.White;
            this.baseUnitsBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.baseUnitsBtn.Location = new System.Drawing.Point(1158, 30);
            this.baseUnitsBtn.Name = "baseUnitsBtn";
            this.baseUnitsBtn.Size = new System.Drawing.Size(209, 41);
            this.baseUnitsBtn.TabIndex = 30;
            this.baseUnitsBtn.Text = "Create Base Unit";
            this.baseUnitsBtn.Click += new System.EventHandler(this.baseUnitsBtn_Click);
            // 
            // baseUnitsBtnPanel
            // 
            this.baseUnitsBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.baseUnitsBtnPanel.BorderRadius = 8;
            this.baseUnitsBtnPanel.Controls.Add(this.baseUnitsFirstBtn);
            this.baseUnitsBtnPanel.Controls.Add(this.baseUnitsPrevBtn);
            this.baseUnitsBtnPanel.Controls.Add(this.baseUnitsNextBtn);
            this.baseUnitsBtnPanel.Controls.Add(this.baseUnitsLastBtn);
            this.baseUnitsBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.baseUnitsBtnPanel.Name = "baseUnitsBtnPanel";
            this.baseUnitsBtnPanel.Size = new System.Drawing.Size(154, 42);
            this.baseUnitsBtnPanel.TabIndex = 46;
            // 
            // baseUnitsFirstBtn
            // 
            this.baseUnitsFirstBtn.BorderRadius = 6;
            this.baseUnitsFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baseUnitsFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baseUnitsFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baseUnitsFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baseUnitsFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.baseUnitsFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baseUnitsFirstBtn.ForeColor = System.Drawing.Color.White;
            this.baseUnitsFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.baseUnitsFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.baseUnitsFirstBtn.Name = "baseUnitsFirstBtn";
            this.baseUnitsFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.baseUnitsFirstBtn.TabIndex = 11;
            this.baseUnitsFirstBtn.Click += new System.EventHandler(this.baseUnitsFirstBtn_Click);
            // 
            // baseUnitsPrevBtn
            // 
            this.baseUnitsPrevBtn.BorderRadius = 6;
            this.baseUnitsPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baseUnitsPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baseUnitsPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baseUnitsPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baseUnitsPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.baseUnitsPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baseUnitsPrevBtn.ForeColor = System.Drawing.Color.White;
            this.baseUnitsPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.baseUnitsPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.baseUnitsPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.baseUnitsPrevBtn.Name = "baseUnitsPrevBtn";
            this.baseUnitsPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.baseUnitsPrevBtn.TabIndex = 11;
            this.baseUnitsPrevBtn.Click += new System.EventHandler(this.baseUnitsPrevBtn_Click);
            // 
            // baseUnitsNextBtn
            // 
            this.baseUnitsNextBtn.BorderRadius = 6;
            this.baseUnitsNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baseUnitsNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baseUnitsNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baseUnitsNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baseUnitsNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.baseUnitsNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baseUnitsNextBtn.ForeColor = System.Drawing.Color.White;
            this.baseUnitsNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.baseUnitsNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.baseUnitsNextBtn.Location = new System.Drawing.Point(87, 8);
            this.baseUnitsNextBtn.Name = "baseUnitsNextBtn";
            this.baseUnitsNextBtn.Size = new System.Drawing.Size(26, 26);
            this.baseUnitsNextBtn.TabIndex = 9;
            this.baseUnitsNextBtn.Click += new System.EventHandler(this.baseUnitsNextBtn_Click);
            // 
            // baseUnitsLastBtn
            // 
            this.baseUnitsLastBtn.BorderRadius = 6;
            this.baseUnitsLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baseUnitsLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baseUnitsLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baseUnitsLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baseUnitsLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.baseUnitsLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baseUnitsLastBtn.ForeColor = System.Drawing.Color.White;
            this.baseUnitsLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.baseUnitsLastBtn.Location = new System.Drawing.Point(130, 8);
            this.baseUnitsLastBtn.Name = "baseUnitsLastBtn";
            this.baseUnitsLastBtn.Size = new System.Drawing.Size(26, 26);
            this.baseUnitsLastBtn.TabIndex = 8;
            this.baseUnitsLastBtn.Click += new System.EventHandler(this.baseUnitsLastBtn_Click);
            // 
            // baseUnitFilterBtn
            // 
            this.baseUnitFilterBtn.Animated = true;
            this.baseUnitFilterBtn.BorderRadius = 8;
            this.baseUnitFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baseUnitFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baseUnitFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baseUnitFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baseUnitFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.baseUnitFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baseUnitFilterBtn.ForeColor = System.Drawing.Color.White;
            this.baseUnitFilterBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.baseUnitFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.baseUnitFilterBtn.Location = new System.Drawing.Point(427, 30);
            this.baseUnitFilterBtn.Name = "baseUnitFilterBtn";
            this.baseUnitFilterBtn.Size = new System.Drawing.Size(43, 42);
            this.baseUnitFilterBtn.TabIndex = 29;
            this.baseUnitFilterBtn.Click += new System.EventHandler(this.baseUnitFilterBtn_Click);
            // 
            // baseUnitSearchText
            // 
            this.baseUnitSearchText.BorderColor = System.Drawing.Color.Gray;
            this.baseUnitSearchText.BorderRadius = 8;
            this.baseUnitSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.baseUnitSearchText.DefaultText = "";
            this.baseUnitSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.baseUnitSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.baseUnitSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.baseUnitSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.baseUnitSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.baseUnitSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseUnitSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baseUnitSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.baseUnitSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.baseUnitSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.baseUnitSearchText.Location = new System.Drawing.Point(17, 30);
            this.baseUnitSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.baseUnitSearchText.Name = "baseUnitSearchText";
            this.baseUnitSearchText.PasswordChar = '\0';
            this.baseUnitSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.baseUnitSearchText.PlaceholderText = "Search";
            this.baseUnitSearchText.SelectedText = "";
            this.baseUnitSearchText.Size = new System.Drawing.Size(400, 42);
            this.baseUnitSearchText.TabIndex = 28;
            this.baseUnitSearchText.TextChanged += new System.EventHandler(this.baseUnitSearchText_TextChanged);
            // 
            // baseUnitDataGridView
            // 
            this.baseUnitDataGridView.AllowUserToAddRows = false;
            this.baseUnitDataGridView.AllowUserToDeleteRows = false;
            this.baseUnitDataGridView.AllowUserToResizeColumns = false;
            this.baseUnitDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.baseUnitDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.baseUnitDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.baseUnitDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.baseUnitDataGridView.ColumnHeadersHeight = 45;
            this.baseUnitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.baseUnitDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.baseUnitDataGridView.GridColor = System.Drawing.Color.White;
            this.baseUnitDataGridView.Location = new System.Drawing.Point(17, 100);
            this.baseUnitDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.baseUnitDataGridView.Name = "baseUnitDataGridView";
            this.baseUnitDataGridView.ReadOnly = true;
            this.baseUnitDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.baseUnitDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.baseUnitDataGridView.RowHeadersVisible = false;
            this.baseUnitDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.baseUnitDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.baseUnitDataGridView.RowTemplate.Height = 35;
            this.baseUnitDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.baseUnitDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.baseUnitDataGridView.TabIndex = 52;
            this.baseUnitDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.baseUnitDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.baseUnitDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseUnitDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.baseUnitDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.baseUnitDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.baseUnitDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.baseUnitDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.baseUnitDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.baseUnitDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.baseUnitDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseUnitDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.baseUnitDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.baseUnitDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.baseUnitDataGridView.ThemeStyle.ReadOnly = true;
            this.baseUnitDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.baseUnitDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.baseUnitDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseUnitDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.baseUnitDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.baseUnitDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.baseUnitDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // BaseUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.baseUnitDataGridView);
            this.Controls.Add(this.baseUnitsBtnPanel);
            this.Controls.Add(this.baseUnitsBtn);
            this.Controls.Add(this.baseUnitFilterBtn);
            this.Controls.Add(this.baseUnitSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "BaseUnit";
            this.ShowInTaskbar = false;
            this.Text = "BaseUnit";
            this.Load += new System.EventHandler(this.BaseUnit_Load);
            this.baseUnitsBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseUnitDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton baseUnitsBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton baseUnitFilterBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox baseUnitSearchText;
        private Siticone.Desktop.UI.WinForms.SiticonePanel baseUnitsBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton baseUnitsFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton baseUnitsPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton baseUnitsNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton baseUnitsLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView baseUnitDataGridView;
    }
}