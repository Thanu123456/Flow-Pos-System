namespace EscopeWindowsApp
{
    partial class SupplierForm
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
            this.supSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createSupBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.supFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supAllPgLabel = new System.Windows.Forms.Label();
            this.supOfLabel = new System.Windows.Forms.Label();
            this.supPgRangeLabel = new System.Windows.Forms.Label();
            this.supPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.supRecordsPerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supDataGridView)).BeginInit();
            this.supBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // supSearchText
            // 
            this.supSearchText.BorderRadius = 8;
            this.supSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supSearchText.DefaultText = "";
            this.supSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.supSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.supSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.supSearchText.Location = new System.Drawing.Point(40, 13);
            this.supSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supSearchText.Name = "supSearchText";
            this.supSearchText.PasswordChar = '\0';
            this.supSearchText.PlaceholderText = "Search";
            this.supSearchText.SelectedText = "";
            this.supSearchText.Size = new System.Drawing.Size(400, 42);
            this.supSearchText.TabIndex = 7;
            // 
            // createSupBtn
            // 
            this.createSupBtn.BorderRadius = 8;
            this.createSupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createSupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createSupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createSupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createSupBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createSupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.createSupBtn.ForeColor = System.Drawing.Color.White;
            this.createSupBtn.Location = new System.Drawing.Point(521, 49);
            this.createSupBtn.Name = "createSupBtn";
            this.createSupBtn.Size = new System.Drawing.Size(209, 42);
            this.createSupBtn.TabIndex = 8;
            this.createSupBtn.Text = "Craete Supplier";
            this.createSupBtn.Click += new System.EventHandler(this.createSupBtn_Click);
            // 
            // supDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.supDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.supDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.supDataGridView.ColumnHeadersHeight = 25;
            this.supDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.supDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.supDataGridView.GridColor = System.Drawing.Color.White;
            this.supDataGridView.Location = new System.Drawing.Point(40, 97);
            this.supDataGridView.Name = "supDataGridView";
            this.supDataGridView.RowHeadersVisible = false;
            this.supDataGridView.Size = new System.Drawing.Size(1837, 775);
            this.supDataGridView.TabIndex = 10;
            this.supDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.supDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.supDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.supDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.supDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.supDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.supDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.supDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.supDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.supDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.supDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.supDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.supDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.supDataGridView.ThemeStyle.ReadOnly = false;
            this.supDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.supDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.supDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.supDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.supDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.supDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Supplier ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Create At";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Action";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // supBtnPanel
            // 
            this.supBtnPanel.BorderRadius = 8;
            this.supBtnPanel.Controls.Add(this.supFirstBtn);
            this.supBtnPanel.Controls.Add(this.supPrevBtn);
            this.supBtnPanel.Controls.Add(this.supNextBtn);
            this.supBtnPanel.Controls.Add(this.supLastBtn);
            this.supBtnPanel.Location = new System.Drawing.Point(459, 188);
            this.supBtnPanel.Name = "supBtnPanel";
            this.supBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.supBtnPanel.TabIndex = 23;
            // 
            // supFirstBtn
            // 
            this.supFirstBtn.BorderRadius = 6;
            this.supFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.supFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supFirstBtn.ForeColor = System.Drawing.Color.White;
            this.supFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.supFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.supFirstBtn.Name = "supFirstBtn";
            this.supFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.supFirstBtn.TabIndex = 11;
            // 
            // supPrevBtn
            // 
            this.supPrevBtn.BorderRadius = 6;
            this.supPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.supPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supPrevBtn.ForeColor = System.Drawing.Color.White;
            this.supPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.supPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.supPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.supPrevBtn.Name = "supPrevBtn";
            this.supPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.supPrevBtn.TabIndex = 11;
            // 
            // supNextBtn
            // 
            this.supNextBtn.BorderRadius = 6;
            this.supNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.supNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supNextBtn.ForeColor = System.Drawing.Color.White;
            this.supNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.supNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.supNextBtn.Location = new System.Drawing.Point(87, 8);
            this.supNextBtn.Name = "supNextBtn";
            this.supNextBtn.Size = new System.Drawing.Size(26, 26);
            this.supNextBtn.TabIndex = 9;
            // 
            // supLastBtn
            // 
            this.supLastBtn.BorderRadius = 6;
            this.supLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.supLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supLastBtn.ForeColor = System.Drawing.Color.White;
            this.supLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.supLastBtn.Location = new System.Drawing.Point(130, 8);
            this.supLastBtn.Name = "supLastBtn";
            this.supLastBtn.Size = new System.Drawing.Size(26, 26);
            this.supLastBtn.TabIndex = 8;
            // 
            // supAllPgLabel
            // 
            this.supAllPgLabel.AutoSize = true;
            this.supAllPgLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.supAllPgLabel.Location = new System.Drawing.Point(409, 156);
            this.supAllPgLabel.Name = "supAllPgLabel";
            this.supAllPgLabel.Size = new System.Drawing.Size(40, 23);
            this.supAllPgLabel.TabIndex = 32;
            this.supAllPgLabel.Text = "500";
            // 
            // supOfLabel
            // 
            this.supOfLabel.AutoSize = true;
            this.supOfLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.supOfLabel.Location = new System.Drawing.Point(384, 156);
            this.supOfLabel.Name = "supOfLabel";
            this.supOfLabel.Size = new System.Drawing.Size(26, 23);
            this.supOfLabel.TabIndex = 31;
            this.supOfLabel.Text = "of";
            // 
            // supPgRangeLabel
            // 
            this.supPgRangeLabel.AutoSize = true;
            this.supPgRangeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.supPgRangeLabel.Location = new System.Drawing.Point(342, 156);
            this.supPgRangeLabel.Name = "supPgRangeLabel";
            this.supPgRangeLabel.Size = new System.Drawing.Size(46, 23);
            this.supPgRangeLabel.TabIndex = 30;
            this.supPgRangeLabel.Text = "0-50";
            // 
            // supPageCombo
            // 
            this.supPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.supPageCombo.BorderColor = System.Drawing.Color.Black;
            this.supPageCombo.BorderRadius = 8;
            this.supPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.supPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supPageCombo.ForeColor = System.Drawing.Color.Black;
            this.supPageCombo.ItemHeight = 30;
            this.supPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.supPageCombo.Location = new System.Drawing.Point(228, 148);
            this.supPageCombo.Name = "supPageCombo";
            this.supPageCombo.Size = new System.Drawing.Size(85, 36);
            this.supPageCombo.StartIndex = 0;
            this.supPageCombo.TabIndex = 29;
            // 
            // supRecordsPerLabel
            // 
            this.supRecordsPerLabel.AutoSize = true;
            this.supRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.supRecordsPerLabel.Location = new System.Drawing.Point(77, 156);
            this.supRecordsPerLabel.Name = "supRecordsPerLabel";
            this.supRecordsPerLabel.Size = new System.Drawing.Size(143, 23);
            this.supRecordsPerLabel.TabIndex = 28;
            this.supRecordsPerLabel.Text = "Records per page";
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.supAllPgLabel);
            this.Controls.Add(this.supOfLabel);
            this.Controls.Add(this.supPgRangeLabel);
            this.Controls.Add(this.supPageCombo);
            this.Controls.Add(this.supRecordsPerLabel);
            this.Controls.Add(this.supBtnPanel);
            this.Controls.Add(this.supDataGridView);
            this.Controls.Add(this.createSupBtn);
            this.Controls.Add(this.supSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)(this.supDataGridView)).EndInit();
            this.supBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox supSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createSupBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView supDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Siticone.Desktop.UI.WinForms.SiticonePanel supBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supLastBtn;
        private System.Windows.Forms.Label supAllPgLabel;
        private System.Windows.Forms.Label supOfLabel;
        private System.Windows.Forms.Label supPgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox supPageCombo;
        private System.Windows.Forms.Label supRecordsPerLabel;
    }
}