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
            this.variationsDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.variationsCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variationTypes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variationsAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createVariationsBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.variationsRecordsPerLabel = new System.Windows.Forms.Label();
            this.variationsAllPgLabel = new System.Windows.Forms.Label();
            this.variationsOfLabel = new System.Windows.Forms.Label();
            this.variationsPgRangeLabel = new System.Windows.Forms.Label();
            this.variationsBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.variationsFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.variationsSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.variationsDataGridView)).BeginInit();
            this.variationsBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // variationsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.variationsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.variationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.variationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.variationsDataGridView.ColumnHeadersHeight = 25;
            this.variationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.variationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.variationsCategory,
            this.variationTypes,
            this.variationsAction});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.variationsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.variationsDataGridView.GridColor = System.Drawing.Color.White;
            this.variationsDataGridView.Location = new System.Drawing.Point(17, 100);
            this.variationsDataGridView.Name = "variationsDataGridView";
            this.variationsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.variationsDataGridView.RowHeadersVisible = false;
            this.variationsDataGridView.Size = new System.Drawing.Size(1352, 614);
            this.variationsDataGridView.TabIndex = 19;
            this.variationsDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.variationsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.variationsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.variationsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.variationsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.variationsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.variationsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.variationsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.variationsDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.variationsDataGridView.ThemeStyle.ReadOnly = false;
            this.variationsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.variationsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.variationsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.variationsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.variationsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.variationsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.variationsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.variationsDataGridView_CellContentClick);
            // 
            // variationsCategory
            // 
            this.variationsCategory.HeaderText = "Variations Name";
            this.variationsCategory.Name = "variationsCategory";
            // 
            // variationTypes
            // 
            this.variationTypes.HeaderText = "Variations Types";
            this.variationTypes.Name = "variationTypes";
            // 
            // variationsAction
            // 
            this.variationsAction.HeaderText = "Action";
            this.variationsAction.Name = "variationsAction";
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
            this.createVariationsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createVariationsBtn.ForeColor = System.Drawing.Color.White;
            this.createVariationsBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createVariationsBtn.Location = new System.Drawing.Point(1158, 30);
            this.createVariationsBtn.Name = "createVariationsBtn";
            this.createVariationsBtn.Size = new System.Drawing.Size(209, 41);
            this.createVariationsBtn.TabIndex = 18;
            this.createVariationsBtn.Text = "Create Variations";
            this.createVariationsBtn.Click += new System.EventHandler(this.createVariationsBtn_Click);
            // 
            // variationsPageCombo
            // 
            this.variationsPageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.variationsPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.variationsPageCombo.BorderColor = System.Drawing.Color.Black;
            this.variationsPageCombo.BorderRadius = 8;
            this.variationsPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.variationsPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.variationsPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.variationsPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.variationsPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.variationsPageCombo.ForeColor = System.Drawing.Color.Black;
            this.variationsPageCombo.ItemHeight = 30;
            this.variationsPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.variationsPageCombo.Location = new System.Drawing.Point(141, 734);
            this.variationsPageCombo.Name = "variationsPageCombo";
            this.variationsPageCombo.Size = new System.Drawing.Size(85, 36);
            this.variationsPageCombo.StartIndex = 0;
            this.variationsPageCombo.TabIndex = 33;
            // 
            // variationsRecordsPerLabel
            // 
            this.variationsRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.variationsRecordsPerLabel.AutoSize = true;
            this.variationsRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.variationsRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.variationsRecordsPerLabel.Name = "variationsRecordsPerLabel";
            this.variationsRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.variationsRecordsPerLabel.TabIndex = 32;
            this.variationsRecordsPerLabel.Text = "Records per page";
            // 
            // variationsAllPgLabel
            // 
            this.variationsAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.variationsAllPgLabel.AutoSize = true;
            this.variationsAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.variationsAllPgLabel.Location = new System.Drawing.Point(295, 742);
            this.variationsAllPgLabel.Name = "variationsAllPgLabel";
            this.variationsAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.variationsAllPgLabel.TabIndex = 31;
            this.variationsAllPgLabel.Text = "500";
            // 
            // variationsOfLabel
            // 
            this.variationsOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.variationsOfLabel.AutoSize = true;
            this.variationsOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.variationsOfLabel.Location = new System.Drawing.Point(274, 742);
            this.variationsOfLabel.Name = "variationsOfLabel";
            this.variationsOfLabel.Size = new System.Drawing.Size(22, 19);
            this.variationsOfLabel.TabIndex = 30;
            this.variationsOfLabel.Text = "of";
            // 
            // variationsPgRangeLabel
            // 
            this.variationsPgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.variationsPgRangeLabel.AutoSize = true;
            this.variationsPgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variationsPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.variationsPgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.variationsPgRangeLabel.Name = "variationsPgRangeLabel";
            this.variationsPgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.variationsPgRangeLabel.TabIndex = 29;
            this.variationsPgRangeLabel.Text = "0-50";
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
            // variationsFilterBtn
            // 
            this.variationsFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.variationsFilterBtn.BorderRadius = 8;
            this.variationsFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.variationsFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.variationsFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.variationsFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.variationsFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.variationsFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.variationsFilterBtn.ForeColor = System.Drawing.Color.White;
            this.variationsFilterBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.variationsFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.whitefilter;
            this.variationsFilterBtn.Location = new System.Drawing.Point(1098, 30);
            this.variationsFilterBtn.Name = "variationsFilterBtn";
            this.variationsFilterBtn.Size = new System.Drawing.Size(43, 42);
            this.variationsFilterBtn.TabIndex = 17;
            this.variationsFilterBtn.Click += new System.EventHandler(this.variationsFilterBtn_Click);
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
            // Variations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.variationsPageCombo);
            this.Controls.Add(this.variationsRecordsPerLabel);
            this.Controls.Add(this.variationsAllPgLabel);
            this.Controls.Add(this.variationsOfLabel);
            this.Controls.Add(this.variationsPgRangeLabel);
            this.Controls.Add(this.variationsBtnPanel);
            this.Controls.Add(this.variationsDataGridView);
            this.Controls.Add(this.createVariationsBtn);
            this.Controls.Add(this.variationsFilterBtn);
            this.Controls.Add(this.variationsSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Variations";
            this.Text = "Variations";
            this.Load += new System.EventHandler(this.Variations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.variationsDataGridView)).EndInit();
            this.variationsBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView variationsDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createVariationsBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsFilterBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox variationsSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox variationsPageCombo;
        private System.Windows.Forms.Label variationsRecordsPerLabel;
        private System.Windows.Forms.Label variationsAllPgLabel;
        private System.Windows.Forms.Label variationsOfLabel;
        private System.Windows.Forms.Label variationsPgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel variationsBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton variationsLastBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variationsCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn variationTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn variationsAction;
    }
}