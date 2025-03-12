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
            this.cusSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createCusBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAllPgLabel = new System.Windows.Forms.Label();
            this.cusOfLabel = new System.Windows.Forms.Label();
            this.cusPgRangeLabel = new System.Windows.Forms.Label();
            this.cusPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cusRecordsPerLabel = new System.Windows.Forms.Label();
            this.cusBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.cusFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.cusDataGridView)).BeginInit();
            this.cusBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cusSearchText
            // 
            this.cusSearchText.BorderRadius = 8;
            this.cusSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cusSearchText.DefaultText = "";
            this.cusSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cusSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cusSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.cusSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.cusSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.cusSearchText.Location = new System.Drawing.Point(17, 30);
            this.cusSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cusSearchText.Name = "cusSearchText";
            this.cusSearchText.PasswordChar = '\0';
            this.cusSearchText.PlaceholderText = "Search";
            this.cusSearchText.SelectedText = "";
            this.cusSearchText.Size = new System.Drawing.Size(400, 42);
            this.cusSearchText.TabIndex = 3;
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
            this.createCusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.createCusBtn.ForeColor = System.Drawing.Color.White;
            this.createCusBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createCusBtn.Location = new System.Drawing.Point(1158, 30);
            this.createCusBtn.Name = "createCusBtn";
            this.createCusBtn.Size = new System.Drawing.Size(209, 42);
            this.createCusBtn.TabIndex = 5;
            this.createCusBtn.Text = "Craete Customer";
            this.createCusBtn.Click += new System.EventHandler(this.createCusBtn_Click);
            // 
            // cusDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cusDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cusDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cusDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cusDataGridView.ColumnHeadersHeight = 25;
            this.cusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.cusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.cusEmail,
            this.cusPhone,
            this.createdAt,
            this.action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cusDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.cusDataGridView.GridColor = System.Drawing.Color.White;
            this.cusDataGridView.Location = new System.Drawing.Point(17, 100);
            this.cusDataGridView.Name = "cusDataGridView";
            this.cusDataGridView.RowHeadersVisible = false;
            this.cusDataGridView.Size = new System.Drawing.Size(1352, 615);
            this.cusDataGridView.TabIndex = 10;
            this.cusDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.cusDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.cusDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.cusDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cusDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cusDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.cusDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.cusDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.cusDataGridView.ThemeStyle.ReadOnly = false;
            this.cusDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.cusDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cusDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.cusDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.cusDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.cusDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer";
            this.customerName.Name = "customerName";
            // 
            // cusEmail
            // 
            this.cusEmail.HeaderText = "Email";
            this.cusEmail.Name = "cusEmail";
            // 
            // cusPhone
            // 
            this.cusPhone.HeaderText = "Phone";
            this.cusPhone.Name = "cusPhone";
            // 
            // createdAt
            // 
            this.createdAt.HeaderText = "Create At";
            this.createdAt.Name = "createdAt";
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            // 
            // cusAllPgLabel
            // 
            this.cusAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cusAllPgLabel.AutoSize = true;
            this.cusAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cusAllPgLabel.Location = new System.Drawing.Point(295, 742);
            this.cusAllPgLabel.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.cusAllPgLabel.Name = "cusAllPgLabel";
            this.cusAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.cusAllPgLabel.TabIndex = 32;
            this.cusAllPgLabel.Text = "500";
            // 
            // cusOfLabel
            // 
            this.cusOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cusOfLabel.AutoSize = true;
            this.cusOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cusOfLabel.Location = new System.Drawing.Point(274, 742);
            this.cusOfLabel.Name = "cusOfLabel";
            this.cusOfLabel.Size = new System.Drawing.Size(22, 19);
            this.cusOfLabel.TabIndex = 31;
            this.cusOfLabel.Text = "of";
            // 
            // cusPgRangeLabel
            // 
            this.cusPgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cusPgRangeLabel.AutoSize = true;
            this.cusPgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cusPgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.cusPgRangeLabel.Name = "cusPgRangeLabel";
            this.cusPgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.cusPgRangeLabel.TabIndex = 30;
            this.cusPgRangeLabel.Text = "0-50";
            // 
            // cusPageCombo
            // 
            this.cusPageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cusPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.cusPageCombo.BorderColor = System.Drawing.Color.Black;
            this.cusPageCombo.BorderRadius = 8;
            this.cusPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cusPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cusPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPageCombo.ForeColor = System.Drawing.Color.Black;
            this.cusPageCombo.ItemHeight = 30;
            this.cusPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.cusPageCombo.Location = new System.Drawing.Point(141, 734);
            this.cusPageCombo.Name = "cusPageCombo";
            this.cusPageCombo.Size = new System.Drawing.Size(85, 36);
            this.cusPageCombo.StartIndex = 0;
            this.cusPageCombo.TabIndex = 29;
            // 
            // cusRecordsPerLabel
            // 
            this.cusRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cusRecordsPerLabel.AutoSize = true;
            this.cusRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cusRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.cusRecordsPerLabel.Name = "cusRecordsPerLabel";
            this.cusRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.cusRecordsPerLabel.TabIndex = 28;
            this.cusRecordsPerLabel.Text = "Records per page";
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
            // 
            // cusFilterBtn
            // 
            this.cusFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cusFilterBtn.Animated = true;
            this.cusFilterBtn.BorderRadius = 8;
            this.cusFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.cusFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cusFilterBtn.ForeColor = System.Drawing.Color.White;
            this.cusFilterBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.cusFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.whitefilter;
            this.cusFilterBtn.Location = new System.Drawing.Point(1098, 30);
            this.cusFilterBtn.Name = "cusFilterBtn";
            this.cusFilterBtn.Size = new System.Drawing.Size(43, 42);
            this.cusFilterBtn.TabIndex = 34;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.cusFilterBtn);
            this.Controls.Add(this.cusBtnPanel);
            this.Controls.Add(this.cusAllPgLabel);
            this.Controls.Add(this.cusOfLabel);
            this.Controls.Add(this.cusPgRangeLabel);
            this.Controls.Add(this.cusPageCombo);
            this.Controls.Add(this.cusRecordsPerLabel);
            this.Controls.Add(this.cusDataGridView);
            this.Controls.Add(this.createCusBtn);
            this.Controls.Add(this.cusSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cusDataGridView)).EndInit();
            this.cusBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox cusSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createCusBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView cusDataGridView;
        private System.Windows.Forms.Label cusAllPgLabel;
        private System.Windows.Forms.Label cusOfLabel;
        private System.Windows.Forms.Label cusPgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cusPageCombo;
        private System.Windows.Forms.Label cusRecordsPerLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel cusBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusFilterBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
    }
}