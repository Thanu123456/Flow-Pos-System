namespace EscopeWindowsApp
{
    partial class ExpensesCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.expCatDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.expCatRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expCatSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createExpCatBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expCatBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.expCatFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expCatPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expCatNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expCatLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expCatAllPgLabel = new System.Windows.Forms.Label();
            this.expCatOfLabel = new System.Windows.Forms.Label();
            this.expCatPgRangeLabel = new System.Windows.Forms.Label();
            this.expCatPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.expCatRecordsPerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expCatDataGridView)).BeginInit();
            this.expCatBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // expCatDataGridView
            // 
            this.expCatDataGridView.AllowUserToAddRows = false;
            this.expCatDataGridView.AllowUserToDeleteRows = false;
            this.expCatDataGridView.AllowUserToResizeColumns = false;
            this.expCatDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.expCatDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.expCatDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expCatDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.expCatDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expCatDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.expCatDataGridView.GridColor = System.Drawing.Color.White;
            this.expCatDataGridView.Location = new System.Drawing.Point(17, 100);
            this.expCatDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.expCatDataGridView.Name = "expCatDataGridView";
            this.expCatDataGridView.ReadOnly = true;
            this.expCatDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expCatDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.expCatDataGridView.RowHeadersVisible = false;
            this.expCatDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.expCatDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.expCatDataGridView.RowTemplate.Height = 35;
            this.expCatDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.expCatDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.expCatDataGridView.TabIndex = 41;
            this.expCatDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.expCatDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.expCatDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.expCatDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.expCatDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.expCatDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.expCatDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.expCatDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.expCatDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.expCatDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.expCatDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.expCatDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.expCatDataGridView.ThemeStyle.ReadOnly = true;
            this.expCatDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.expCatDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.expCatDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.expCatDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.expCatDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.expCatDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // expCatRefreshBtn
            // 
            this.expCatRefreshBtn.Animated = true;
            this.expCatRefreshBtn.BorderRadius = 8;
            this.expCatRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expCatRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expCatRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expCatRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expCatRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.expCatRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expCatRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.expCatRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.expCatRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.expCatRefreshBtn.Location = new System.Drawing.Point(427, 30);
            this.expCatRefreshBtn.Name = "expCatRefreshBtn";
            this.expCatRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.expCatRefreshBtn.TabIndex = 40;
            // 
            // expCatSearchText
            // 
            this.expCatSearchText.BorderColor = System.Drawing.Color.Gray;
            this.expCatSearchText.BorderRadius = 8;
            this.expCatSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expCatSearchText.DefaultText = "";
            this.expCatSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expCatSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expCatSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expCatSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expCatSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expCatSearchText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatSearchText.ForeColor = System.Drawing.Color.Gray;
            this.expCatSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expCatSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.expCatSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.expCatSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.expCatSearchText.Location = new System.Drawing.Point(17, 30);
            this.expCatSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expCatSearchText.Name = "expCatSearchText";
            this.expCatSearchText.PasswordChar = '\0';
            this.expCatSearchText.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.expCatSearchText.PlaceholderText = "Search";
            this.expCatSearchText.SelectedText = "";
            this.expCatSearchText.Size = new System.Drawing.Size(400, 42);
            this.expCatSearchText.TabIndex = 39;
            // 
            // createExpCatBtn
            // 
            this.createExpCatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createExpCatBtn.Animated = true;
            this.createExpCatBtn.BorderRadius = 8;
            this.createExpCatBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createExpCatBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createExpCatBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createExpCatBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createExpCatBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createExpCatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.createExpCatBtn.ForeColor = System.Drawing.Color.White;
            this.createExpCatBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createExpCatBtn.Location = new System.Drawing.Point(1129, 30);
            this.createExpCatBtn.Name = "createExpCatBtn";
            this.createExpCatBtn.Size = new System.Drawing.Size(238, 42);
            this.createExpCatBtn.TabIndex = 42;
            this.createExpCatBtn.Text = "Craete Expenses Category";
            this.createExpCatBtn.Click += new System.EventHandler(this.createExpCatBtn_Click);
            // 
            // expCatBtnPanel
            // 
            this.expCatBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expCatBtnPanel.BackColor = System.Drawing.Color.Transparent;
            this.expCatBtnPanel.BorderRadius = 8;
            this.expCatBtnPanel.Controls.Add(this.expCatFirstBtn);
            this.expCatBtnPanel.Controls.Add(this.expCatPrevBtn);
            this.expCatBtnPanel.Controls.Add(this.expCatNextBtn);
            this.expCatBtnPanel.Controls.Add(this.expCatLastBtn);
            this.expCatBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.expCatBtnPanel.Name = "expCatBtnPanel";
            this.expCatBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.expCatBtnPanel.TabIndex = 43;
            // 
            // expCatFirstBtn
            // 
            this.expCatFirstBtn.BorderRadius = 6;
            this.expCatFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expCatFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expCatFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expCatFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expCatFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.expCatFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expCatFirstBtn.ForeColor = System.Drawing.Color.White;
            this.expCatFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.expCatFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.expCatFirstBtn.Name = "expCatFirstBtn";
            this.expCatFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.expCatFirstBtn.TabIndex = 11;
            // 
            // expCatPrevBtn
            // 
            this.expCatPrevBtn.BorderRadius = 6;
            this.expCatPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expCatPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expCatPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expCatPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expCatPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.expCatPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expCatPrevBtn.ForeColor = System.Drawing.Color.White;
            this.expCatPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.expCatPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.expCatPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.expCatPrevBtn.Name = "expCatPrevBtn";
            this.expCatPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.expCatPrevBtn.TabIndex = 11;
            // 
            // expCatNextBtn
            // 
            this.expCatNextBtn.BorderRadius = 6;
            this.expCatNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expCatNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expCatNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expCatNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expCatNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.expCatNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expCatNextBtn.ForeColor = System.Drawing.Color.White;
            this.expCatNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.expCatNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.expCatNextBtn.Location = new System.Drawing.Point(87, 8);
            this.expCatNextBtn.Name = "expCatNextBtn";
            this.expCatNextBtn.Size = new System.Drawing.Size(26, 26);
            this.expCatNextBtn.TabIndex = 9;
            // 
            // expCatLastBtn
            // 
            this.expCatLastBtn.BorderRadius = 6;
            this.expCatLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expCatLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expCatLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expCatLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expCatLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.expCatLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expCatLastBtn.ForeColor = System.Drawing.Color.White;
            this.expCatLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.expCatLastBtn.Location = new System.Drawing.Point(130, 8);
            this.expCatLastBtn.Name = "expCatLastBtn";
            this.expCatLastBtn.Size = new System.Drawing.Size(26, 26);
            this.expCatLastBtn.TabIndex = 8;
            // 
            // expCatAllPgLabel
            // 
            this.expCatAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expCatAllPgLabel.AutoSize = true;
            this.expCatAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.expCatAllPgLabel.Location = new System.Drawing.Point(295, 742);
            this.expCatAllPgLabel.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.expCatAllPgLabel.Name = "expCatAllPgLabel";
            this.expCatAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.expCatAllPgLabel.TabIndex = 48;
            this.expCatAllPgLabel.Text = "500";
            // 
            // expCatOfLabel
            // 
            this.expCatOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expCatOfLabel.AutoSize = true;
            this.expCatOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.expCatOfLabel.Location = new System.Drawing.Point(274, 742);
            this.expCatOfLabel.Name = "expCatOfLabel";
            this.expCatOfLabel.Size = new System.Drawing.Size(22, 19);
            this.expCatOfLabel.TabIndex = 47;
            this.expCatOfLabel.Text = "of";
            // 
            // expCatPgRangeLabel
            // 
            this.expCatPgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expCatPgRangeLabel.AutoSize = true;
            this.expCatPgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.expCatPgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.expCatPgRangeLabel.Name = "expCatPgRangeLabel";
            this.expCatPgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.expCatPgRangeLabel.TabIndex = 46;
            this.expCatPgRangeLabel.Text = "0-50";
            // 
            // expCatPageCombo
            // 
            this.expCatPageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expCatPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.expCatPageCombo.BorderColor = System.Drawing.Color.Black;
            this.expCatPageCombo.BorderRadius = 8;
            this.expCatPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.expCatPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expCatPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expCatPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expCatPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatPageCombo.ForeColor = System.Drawing.Color.Black;
            this.expCatPageCombo.ItemHeight = 30;
            this.expCatPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.expCatPageCombo.Location = new System.Drawing.Point(141, 734);
            this.expCatPageCombo.Name = "expCatPageCombo";
            this.expCatPageCombo.Size = new System.Drawing.Size(85, 36);
            this.expCatPageCombo.StartIndex = 0;
            this.expCatPageCombo.TabIndex = 45;
            // 
            // expCatRecordsPerLabel
            // 
            this.expCatRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expCatRecordsPerLabel.AutoSize = true;
            this.expCatRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.expCatRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.expCatRecordsPerLabel.Name = "expCatRecordsPerLabel";
            this.expCatRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.expCatRecordsPerLabel.TabIndex = 44;
            this.expCatRecordsPerLabel.Text = "Records per page";
            // 
            // ExpensesCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.expCatAllPgLabel);
            this.Controls.Add(this.expCatOfLabel);
            this.Controls.Add(this.expCatPgRangeLabel);
            this.Controls.Add(this.expCatPageCombo);
            this.Controls.Add(this.expCatRecordsPerLabel);
            this.Controls.Add(this.expCatBtnPanel);
            this.Controls.Add(this.createExpCatBtn);
            this.Controls.Add(this.expCatDataGridView);
            this.Controls.Add(this.expCatRefreshBtn);
            this.Controls.Add(this.expCatSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "ExpensesCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpensesCategory";
            ((System.ComponentModel.ISupportInitialize)(this.expCatDataGridView)).EndInit();
            this.expCatBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView expCatDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expCatRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox expCatSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createExpCatBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel expCatBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expCatFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expCatPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expCatNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expCatLastBtn;
        private System.Windows.Forms.Label expCatAllPgLabel;
        private System.Windows.Forms.Label expCatOfLabel;
        private System.Windows.Forms.Label expCatPgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox expCatPageCombo;
        private System.Windows.Forms.Label expCatRecordsPerLabel;
    }
}