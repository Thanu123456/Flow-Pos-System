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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.createExpBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.expBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.expAllPgLabel = new System.Windows.Forms.Label();
            this.expOfLabel = new System.Windows.Forms.Label();
            this.expPgRangeLabel = new System.Windows.Forms.Label();
            this.expPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.expRecordsPerLabel = new System.Windows.Forms.Label();
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
            this.createExpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.expDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.expDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.expDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.expDataGridView.GridColor = System.Drawing.Color.White;
            this.expDataGridView.Location = new System.Drawing.Point(17, 100);
            this.expDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.expDataGridView.Name = "expDataGridView";
            this.expDataGridView.ReadOnly = true;
            this.expDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            // expAllPgLabel
            // 
            this.expAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expAllPgLabel.AutoSize = true;
            this.expAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.expAllPgLabel.Location = new System.Drawing.Point(295, 742);
            this.expAllPgLabel.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.expAllPgLabel.Name = "expAllPgLabel";
            this.expAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.expAllPgLabel.TabIndex = 53;
            this.expAllPgLabel.Text = "500";
            // 
            // expOfLabel
            // 
            this.expOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expOfLabel.AutoSize = true;
            this.expOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.expOfLabel.Location = new System.Drawing.Point(274, 742);
            this.expOfLabel.Name = "expOfLabel";
            this.expOfLabel.Size = new System.Drawing.Size(22, 19);
            this.expOfLabel.TabIndex = 52;
            this.expOfLabel.Text = "of";
            // 
            // expPgRangeLabel
            // 
            this.expPgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expPgRangeLabel.AutoSize = true;
            this.expPgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.expPgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.expPgRangeLabel.Name = "expPgRangeLabel";
            this.expPgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.expPgRangeLabel.TabIndex = 51;
            this.expPgRangeLabel.Text = "0-50";
            // 
            // expPageCombo
            // 
            this.expPageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.expPageCombo.BorderColor = System.Drawing.Color.Black;
            this.expPageCombo.BorderRadius = 8;
            this.expPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.expPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expPageCombo.ForeColor = System.Drawing.Color.Black;
            this.expPageCombo.ItemHeight = 30;
            this.expPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.expPageCombo.Location = new System.Drawing.Point(141, 734);
            this.expPageCombo.Name = "expPageCombo";
            this.expPageCombo.Size = new System.Drawing.Size(85, 36);
            this.expPageCombo.StartIndex = 0;
            this.expPageCombo.TabIndex = 50;
            // 
            // expRecordsPerLabel
            // 
            this.expRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expRecordsPerLabel.AutoSize = true;
            this.expRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.expRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.expRecordsPerLabel.Name = "expRecordsPerLabel";
            this.expRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.expRecordsPerLabel.TabIndex = 49;
            this.expRecordsPerLabel.Text = "Records per page";
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
            this.expSearchText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expSearchText.ForeColor = System.Drawing.Color.Gray;
            this.expSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.expSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.expSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.expSearchText.Location = new System.Drawing.Point(17, 30);
            this.expSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expSearchText.Name = "expSearchText";
            this.expSearchText.PasswordChar = '\0';
            this.expSearchText.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.expSearchText.PlaceholderText = "Search";
            this.expSearchText.SelectedText = "";
            this.expSearchText.Size = new System.Drawing.Size(400, 42);
            this.expSearchText.TabIndex = 41;
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.expAllPgLabel);
            this.Controls.Add(this.expOfLabel);
            this.Controls.Add(this.expPgRangeLabel);
            this.Controls.Add(this.expPageCombo);
            this.Controls.Add(this.expRecordsPerLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.expDataGridView)).EndInit();
            this.expBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label expAllPgLabel;
        private System.Windows.Forms.Label expOfLabel;
        private System.Windows.Forms.Label expPgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox expPageCombo;
        private System.Windows.Forms.Label expRecordsPerLabel;
    }
}