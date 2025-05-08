namespace EscopeWindowsApp
{
    partial class ExpensesForm
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
            this.createExpBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.expBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.expFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.expDataGridView)).BeginInit();
            this.expBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createExpBtn
            // 
            this.createExpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createExpBtn.Animated = true;
            this.createExpBtn.BorderRadius = 8;
            this.createExpBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createExpBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createExpBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createExpBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createExpBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createExpBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createExpBtn.ForeColor = System.Drawing.Color.White;
            this.createExpBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createExpBtn.Location = new System.Drawing.Point(1158, 30);
            this.createExpBtn.Name = "createExpBtn";
            this.createExpBtn.Size = new System.Drawing.Size(209, 42);
            this.createExpBtn.TabIndex = 43;
            this.createExpBtn.Text = "Craete Expenses";
            this.createExpBtn.Click += new System.EventHandler(this.createExpBtn_Click);
            // 
            // expDataGridView
            // 
            this.expDataGridView.AllowUserToAddRows = false;
            this.expDataGridView.AllowUserToDeleteRows = false;
            this.expDataGridView.AllowUserToResizeColumns = false;
            this.expDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.expDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.expDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.expDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.expDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.expDataGridView.GridColor = System.Drawing.Color.White;
            this.expDataGridView.Location = new System.Drawing.Point(17, 100);
            this.expDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.expDataGridView.Name = "expDataGridView";
            this.expDataGridView.ReadOnly = true;
            this.expDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.expDataGridView.RowHeadersVisible = false;
            this.expDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.expDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.expDataGridView.RowTemplate.Height = 35;
            this.expDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.expDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.expDataGridView.TabIndex = 44;
            this.expDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.expDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.expDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.expDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.expDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.expDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.expDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.expDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.expDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.expDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.expDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.expDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.expDataGridView.ThemeStyle.ReadOnly = true;
            this.expDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.expDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.expDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.expDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.expDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.expDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.expDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expDataGridView_CellContentClick);
            // 
            // expBtnPanel
            // 
            this.expBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expBtnPanel.BackColor = System.Drawing.Color.Transparent;
            this.expBtnPanel.BorderRadius = 8;
            this.expBtnPanel.Controls.Add(this.expFirstBtn);
            this.expBtnPanel.Controls.Add(this.expPrevBtn);
            this.expBtnPanel.Controls.Add(this.expNextBtn);
            this.expBtnPanel.Controls.Add(this.expLastBtn);
            this.expBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.expBtnPanel.Name = "expBtnPanel";
            this.expBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.expBtnPanel.TabIndex = 45;
            // 
            // expFirstBtn
            // 
            this.expFirstBtn.BorderRadius = 6;
            this.expFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.expFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expFirstBtn.ForeColor = System.Drawing.Color.White;
            this.expFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.expFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.expFirstBtn.Name = "expFirstBtn";
            this.expFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.expFirstBtn.TabIndex = 11;
            this.expFirstBtn.Click += new System.EventHandler(this.expFirstBtn_Click);
            // 
            // expPrevBtn
            // 
            this.expPrevBtn.BorderRadius = 6;
            this.expPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.expPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expPrevBtn.ForeColor = System.Drawing.Color.White;
            this.expPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.expPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.expPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.expPrevBtn.Name = "expPrevBtn";
            this.expPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.expPrevBtn.TabIndex = 11;
            this.expPrevBtn.Click += new System.EventHandler(this.expPrevBtn_Click);
            // 
            // expNextBtn
            // 
            this.expNextBtn.BorderRadius = 6;
            this.expNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.expNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expNextBtn.ForeColor = System.Drawing.Color.White;
            this.expNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.expNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.expNextBtn.Location = new System.Drawing.Point(87, 8);
            this.expNextBtn.Name = "expNextBtn";
            this.expNextBtn.Size = new System.Drawing.Size(26, 26);
            this.expNextBtn.TabIndex = 9;
            this.expNextBtn.Click += new System.EventHandler(this.expNextBtn_Click);
            // 
            // expLastBtn
            // 
            this.expLastBtn.BorderRadius = 6;
            this.expLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.expLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expLastBtn.ForeColor = System.Drawing.Color.White;
            this.expLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.expLastBtn.Location = new System.Drawing.Point(130, 8);
            this.expLastBtn.Name = "expLastBtn";
            this.expLastBtn.Size = new System.Drawing.Size(26, 26);
            this.expLastBtn.TabIndex = 8;
            this.expLastBtn.Click += new System.EventHandler(this.expLastBtn_Click);
            // 
            // expRefreshBtn
            // 
            this.expRefreshBtn.Animated = true;
            this.expRefreshBtn.BorderRadius = 8;
            this.expRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.expRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.expRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.expRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.expRefreshBtn.Location = new System.Drawing.Point(427, 30);
            this.expRefreshBtn.Name = "expRefreshBtn";
            this.expRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.expRefreshBtn.TabIndex = 42;
            this.expRefreshBtn.Click += new System.EventHandler(this.expRefreshBtn_Click);
            // 
            // expSearchText
            // 
            this.expSearchText.BorderColor = System.Drawing.Color.Gray;
            this.expSearchText.BorderRadius = 8;
            this.expSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expSearchText.DefaultText = "";
            this.expSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expSearchText.ForeColor = System.Drawing.Color.Gray;
            this.expSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.expSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.expSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.expSearchText.Location = new System.Drawing.Point(17, 30);
            this.expSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expSearchText.Name = "expSearchText";
            this.expSearchText.PasswordChar = '\0';
            this.expSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.expSearchText.PlaceholderText = "Search";
            this.expSearchText.SelectedText = "";
            this.expSearchText.Size = new System.Drawing.Size(400, 42);
            this.expSearchText.TabIndex = 41;
            this.expSearchText.TextChanged += new System.EventHandler(this.expSearchText_TextChanged);
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.expBtnPanel);
            this.Controls.Add(this.expDataGridView);
            this.Controls.Add(this.createExpBtn);
            this.Controls.Add(this.expRefreshBtn);
            this.Controls.Add(this.expSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "ExpensesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpensesForm";
            this.Load += new System.EventHandler(this.ExpensesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expDataGridView)).EndInit();
            this.expBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton expRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox expSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createExpBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView expDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticonePanel expBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expLastBtn;
    }
}