namespace EscopeWindowsApp
{
    partial class Category
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
            this.categoryDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createCategoryBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.categoryPageCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.categorytRecordsPerLabel = new System.Windows.Forms.Label();
            this.categoryAllPgLabel = new System.Windows.Forms.Label();
            this.categoryOfLabel = new System.Windows.Forms.Label();
            this.categoryPgRangeLabel = new System.Windows.Forms.Label();
            this.categoryBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.categoryFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.categoryPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.categoryNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.categoryLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.categoryFilterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.categorySearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            this.categoryBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.categoryDataGridView.ColumnHeadersHeight = 25;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCategory,
            this.productCount,
            this.categoryAction});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.categoryDataGridView.GridColor = System.Drawing.Color.White;
            this.categoryDataGridView.Location = new System.Drawing.Point(17, 100);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryDataGridView.RowHeadersVisible = false;
            this.categoryDataGridView.Size = new System.Drawing.Size(1352, 614);
            this.categoryDataGridView.TabIndex = 15;
            this.categoryDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.categoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.categoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.categoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.categoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.categoryDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.categoryDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.categoryDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.categoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.categoryDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.categoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.categoryDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.categoryDataGridView.ThemeStyle.ReadOnly = false;
            this.categoryDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.categoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.categoryDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.categoryDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.categoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.categoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // productCategory
            // 
            this.productCategory.HeaderText = "Product Category";
            this.productCategory.Name = "productCategory";
            // 
            // productCount
            // 
            this.productCount.HeaderText = "Product Count";
            this.productCount.Name = "productCount";
            // 
            // categoryAction
            // 
            this.categoryAction.HeaderText = "Action";
            this.categoryAction.Name = "categoryAction";
            // 
            // createCategoryBtn
            // 
            this.createCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createCategoryBtn.Animated = true;
            this.createCategoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.createCategoryBtn.BorderRadius = 8;
            this.createCategoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createCategoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createCategoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createCategoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createCategoryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createCategoryBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.createCategoryBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createCategoryBtn.Location = new System.Drawing.Point(1158, 30);
            this.createCategoryBtn.Name = "createCategoryBtn";
            this.createCategoryBtn.Size = new System.Drawing.Size(209, 41);
            this.createCategoryBtn.TabIndex = 14;
            this.createCategoryBtn.Text = "Create Category";
            this.createCategoryBtn.Click += new System.EventHandler(this.createCategoryBtn_Click);
            // 
            // categoryPageCombo
            // 
            this.categoryPageCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryPageCombo.BackColor = System.Drawing.Color.Transparent;
            this.categoryPageCombo.BorderColor = System.Drawing.Color.Black;
            this.categoryPageCombo.BorderRadius = 8;
            this.categoryPageCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryPageCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryPageCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryPageCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.categoryPageCombo.ForeColor = System.Drawing.Color.Black;
            this.categoryPageCombo.ItemHeight = 30;
            this.categoryPageCombo.Items.AddRange(new object[] {
            "0-10",
            "0-15",
            "0-50",
            "0-80"});
            this.categoryPageCombo.Location = new System.Drawing.Point(141, 734);
            this.categoryPageCombo.Name = "categoryPageCombo";
            this.categoryPageCombo.Size = new System.Drawing.Size(85, 36);
            this.categoryPageCombo.StartIndex = 0;
            this.categoryPageCombo.TabIndex = 27;
            // 
            // categorytRecordsPerLabel
            // 
            this.categorytRecordsPerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.categorytRecordsPerLabel.AutoSize = true;
            this.categorytRecordsPerLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorytRecordsPerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.categorytRecordsPerLabel.Location = new System.Drawing.Point(13, 742);
            this.categorytRecordsPerLabel.Name = "categorytRecordsPerLabel";
            this.categorytRecordsPerLabel.Size = new System.Drawing.Size(122, 19);
            this.categorytRecordsPerLabel.TabIndex = 26;
            this.categorytRecordsPerLabel.Text = "Records per page";
            // 
            // categoryAllPgLabel
            // 
            this.categoryAllPgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryAllPgLabel.AutoSize = true;
            this.categoryAllPgLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryAllPgLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.categoryAllPgLabel.Location = new System.Drawing.Point(297, 742);
            this.categoryAllPgLabel.Name = "categoryAllPgLabel";
            this.categoryAllPgLabel.Size = new System.Drawing.Size(33, 19);
            this.categoryAllPgLabel.TabIndex = 25;
            this.categoryAllPgLabel.Text = "500";
            // 
            // categoryOfLabel
            // 
            this.categoryOfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryOfLabel.AutoSize = true;
            this.categoryOfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.categoryOfLabel.Location = new System.Drawing.Point(276, 742);
            this.categoryOfLabel.Name = "categoryOfLabel";
            this.categoryOfLabel.Size = new System.Drawing.Size(22, 19);
            this.categoryOfLabel.TabIndex = 24;
            this.categoryOfLabel.Text = "of";
            // 
            // categoryPgRangeLabel
            // 
            this.categoryPgRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryPgRangeLabel.AutoSize = true;
            this.categoryPgRangeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryPgRangeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.categoryPgRangeLabel.Location = new System.Drawing.Point(237, 742);
            this.categoryPgRangeLabel.Name = "categoryPgRangeLabel";
            this.categoryPgRangeLabel.Size = new System.Drawing.Size(38, 19);
            this.categoryPgRangeLabel.TabIndex = 23;
            this.categoryPgRangeLabel.Text = "0-50";
            // 
            // categoryBtnPanel
            // 
            this.categoryBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryBtnPanel.BorderRadius = 8;
            this.categoryBtnPanel.Controls.Add(this.categoryFirstBtn);
            this.categoryBtnPanel.Controls.Add(this.categoryPrevBtn);
            this.categoryBtnPanel.Controls.Add(this.categoryNextBtn);
            this.categoryBtnPanel.Controls.Add(this.categoryLastBtn);
            this.categoryBtnPanel.Location = new System.Drawing.Point(1213, 734);
            this.categoryBtnPanel.Name = "categoryBtnPanel";
            this.categoryBtnPanel.Size = new System.Drawing.Size(154, 42);
            this.categoryBtnPanel.TabIndex = 22;
            // 
            // categoryFirstBtn
            // 
            this.categoryFirstBtn.BorderRadius = 6;
            this.categoryFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.categoryFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryFirstBtn.ForeColor = System.Drawing.Color.White;
            this.categoryFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.categoryFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.categoryFirstBtn.Name = "categoryFirstBtn";
            this.categoryFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.categoryFirstBtn.TabIndex = 11;
            // 
            // categoryPrevBtn
            // 
            this.categoryPrevBtn.BorderRadius = 6;
            this.categoryPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.categoryPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryPrevBtn.ForeColor = System.Drawing.Color.White;
            this.categoryPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.categoryPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.categoryPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.categoryPrevBtn.Name = "categoryPrevBtn";
            this.categoryPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.categoryPrevBtn.TabIndex = 11;
            // 
            // categoryNextBtn
            // 
            this.categoryNextBtn.BorderRadius = 6;
            this.categoryNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.categoryNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryNextBtn.ForeColor = System.Drawing.Color.White;
            this.categoryNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.categoryNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.categoryNextBtn.Location = new System.Drawing.Point(87, 8);
            this.categoryNextBtn.Name = "categoryNextBtn";
            this.categoryNextBtn.Size = new System.Drawing.Size(26, 26);
            this.categoryNextBtn.TabIndex = 9;
            // 
            // categoryLastBtn
            // 
            this.categoryLastBtn.BorderRadius = 6;
            this.categoryLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.categoryLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryLastBtn.ForeColor = System.Drawing.Color.White;
            this.categoryLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.categoryLastBtn.Location = new System.Drawing.Point(130, 8);
            this.categoryLastBtn.Name = "categoryLastBtn";
            this.categoryLastBtn.Size = new System.Drawing.Size(26, 26);
            this.categoryLastBtn.TabIndex = 8;
            // 
            // categoryFilterBtn
            // 
            this.categoryFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryFilterBtn.Animated = true;
            this.categoryFilterBtn.BackColor = System.Drawing.Color.Transparent;
            this.categoryFilterBtn.BorderRadius = 8;
            this.categoryFilterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryFilterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryFilterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryFilterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryFilterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.categoryFilterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryFilterBtn.ForeColor = System.Drawing.Color.White;
            this.categoryFilterBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.categoryFilterBtn.Image = global::EscopeWindowsApp.Properties.Resources.whitefilter;
            this.categoryFilterBtn.Location = new System.Drawing.Point(1098, 30);
            this.categoryFilterBtn.Name = "categoryFilterBtn";
            this.categoryFilterBtn.Size = new System.Drawing.Size(43, 42);
            this.categoryFilterBtn.TabIndex = 13;
            // 
            // categorySearchText
            // 
            this.categorySearchText.AutoSize = true;
            this.categorySearchText.BorderColor = System.Drawing.Color.Gray;
            this.categorySearchText.BorderRadius = 8;
            this.categorySearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categorySearchText.DefaultText = "";
            this.categorySearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categorySearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categorySearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categorySearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categorySearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorySearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.categorySearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categorySearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorySearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.categorySearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.categorySearchText.Location = new System.Drawing.Point(17, 30);
            this.categorySearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categorySearchText.Name = "categorySearchText";
            this.categorySearchText.PasswordChar = '\0';
            this.categorySearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.categorySearchText.PlaceholderText = "Search";
            this.categorySearchText.SelectedText = "";
            this.categorySearchText.Size = new System.Drawing.Size(400, 41);
            this.categorySearchText.TabIndex = 12;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.categoryPageCombo);
            this.Controls.Add(this.categorytRecordsPerLabel);
            this.Controls.Add(this.categoryAllPgLabel);
            this.Controls.Add(this.categoryOfLabel);
            this.Controls.Add(this.categoryPgRangeLabel);
            this.Controls.Add(this.categoryBtnPanel);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.createCategoryBtn);
            this.Controls.Add(this.categoryFilterBtn);
            this.Controls.Add(this.categorySearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Category";
            this.Text = "Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.categoryBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView categoryDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createCategoryBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton categoryFilterBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox categorySearchText;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryAction;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox categoryPageCombo;
        private System.Windows.Forms.Label categorytRecordsPerLabel;
        private System.Windows.Forms.Label categoryAllPgLabel;
        private System.Windows.Forms.Label categoryOfLabel;
        private System.Windows.Forms.Label categoryPgRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton categoryFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel categoryBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton categoryPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton categoryNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton categoryLastBtn;
    }
}