namespace EscopeWindowsApp
{
    partial class Adjsments
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.adjGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.adjRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.adjSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.productBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.adjirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.adjPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.adjNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.adjLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.createCusLabel = new System.Windows.Forms.Label();
            this.createAdjBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjGridView)).BeginInit();
            this.productBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.BorderRadius = 25;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1000, 34);
            this.headerPanel.TabIndex = 27;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.minimumBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(908, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(92, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // minimumBtn
            // 
            this.minimumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumBtn.BorderRadius = 8;
            this.minimumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimumBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minimumBtn.IconColor = System.Drawing.Color.White;
            this.minimumBtn.Location = new System.Drawing.Point(13, 2);
            this.minimumBtn.Name = "minimumBtn";
            this.minimumBtn.Size = new System.Drawing.Size(26, 26);
            this.minimumBtn.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(45, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 26);
            this.closeBtn.TabIndex = 0;
            // 
            // adjGridView
            // 
            this.adjGridView.AllowUserToAddRows = false;
            this.adjGridView.AllowUserToDeleteRows = false;
            this.adjGridView.AllowUserToResizeColumns = false;
            this.adjGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.adjGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.adjGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adjGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.adjGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adjGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.adjGridView.GridColor = System.Drawing.Color.White;
            this.adjGridView.Location = new System.Drawing.Point(21, 167);
            this.adjGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.adjGridView.Name = "adjGridView";
            this.adjGridView.ReadOnly = true;
            this.adjGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adjGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.adjGridView.RowHeadersVisible = false;
            this.adjGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.adjGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.adjGridView.RowTemplate.Height = 35;
            this.adjGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.adjGridView.Size = new System.Drawing.Size(958, 264);
            this.adjGridView.TabIndex = 43;
            this.adjGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.adjGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adjGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adjGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.adjGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.adjGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.adjGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.adjGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.adjGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.adjGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.adjGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.adjGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.adjGridView.ThemeStyle.ReadOnly = true;
            this.adjGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.adjGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.adjGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.adjGridView.ThemeStyle.RowsStyle.Height = 35;
            this.adjGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.adjGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.adjGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adjGridView_CellContentClick);
            // 
            // adjRefreshBtn
            // 
            this.adjRefreshBtn.BorderRadius = 8;
            this.adjRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.adjRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adjRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.adjRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.adjRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.adjRefreshBtn.Location = new System.Drawing.Point(431, 97);
            this.adjRefreshBtn.Name = "adjRefreshBtn";
            this.adjRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.adjRefreshBtn.TabIndex = 42;
            this.adjRefreshBtn.Click += new System.EventHandler(this.adjRefreshBtn_Click);
            // 
            // adjSearchText
            // 
            this.adjSearchText.BorderColor = System.Drawing.Color.Gray;
            this.adjSearchText.BorderRadius = 8;
            this.adjSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adjSearchText.DefaultText = "";
            this.adjSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adjSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adjSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adjSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adjSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adjSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adjSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adjSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.adjSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.adjSearchText.Location = new System.Drawing.Point(21, 97);
            this.adjSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adjSearchText.Name = "adjSearchText";
            this.adjSearchText.PasswordChar = '\0';
            this.adjSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.adjSearchText.PlaceholderText = "Search";
            this.adjSearchText.SelectedText = "";
            this.adjSearchText.Size = new System.Drawing.Size(400, 42);
            this.adjSearchText.TabIndex = 41;
            this.adjSearchText.TextChanged += new System.EventHandler(this.adjSearchText_TextChanged);
            // 
            // productBtnPanel
            // 
            this.productBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productBtnPanel.BorderRadius = 8;
            this.productBtnPanel.Controls.Add(this.adjirstBtn);
            this.productBtnPanel.Controls.Add(this.adjPrevBtn);
            this.productBtnPanel.Controls.Add(this.adjNextBtn);
            this.productBtnPanel.Controls.Add(this.adjLastBtn);
            this.productBtnPanel.Location = new System.Drawing.Point(825, 446);
            this.productBtnPanel.Name = "productBtnPanel";
            this.productBtnPanel.Size = new System.Drawing.Size(154, 42);
            this.productBtnPanel.TabIndex = 44;
            // 
            // adjirstBtn
            // 
            this.adjirstBtn.BorderRadius = 6;
            this.adjirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.adjirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adjirstBtn.ForeColor = System.Drawing.Color.White;
            this.adjirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.adjirstBtn.Location = new System.Drawing.Point(3, 8);
            this.adjirstBtn.Name = "adjirstBtn";
            this.adjirstBtn.Size = new System.Drawing.Size(26, 26);
            this.adjirstBtn.TabIndex = 11;
            this.adjirstBtn.Click += new System.EventHandler(this.adjirstBtn_Click);
            // 
            // adjPrevBtn
            // 
            this.adjPrevBtn.BorderRadius = 6;
            this.adjPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.adjPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adjPrevBtn.ForeColor = System.Drawing.Color.White;
            this.adjPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.adjPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.adjPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.adjPrevBtn.Name = "adjPrevBtn";
            this.adjPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.adjPrevBtn.TabIndex = 11;
            this.adjPrevBtn.Click += new System.EventHandler(this.adjPrevBtn_Click);
            // 
            // adjNextBtn
            // 
            this.adjNextBtn.BorderRadius = 6;
            this.adjNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.adjNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adjNextBtn.ForeColor = System.Drawing.Color.White;
            this.adjNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.adjNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.adjNextBtn.Location = new System.Drawing.Point(87, 8);
            this.adjNextBtn.Name = "adjNextBtn";
            this.adjNextBtn.Size = new System.Drawing.Size(26, 26);
            this.adjNextBtn.TabIndex = 9;
            this.adjNextBtn.Click += new System.EventHandler(this.adjNextBtn_Click);
            // 
            // adjLastBtn
            // 
            this.adjLastBtn.BorderRadius = 6;
            this.adjLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adjLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adjLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adjLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adjLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.adjLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adjLastBtn.ForeColor = System.Drawing.Color.White;
            this.adjLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.adjLastBtn.Location = new System.Drawing.Point(130, 8);
            this.adjLastBtn.Name = "adjLastBtn";
            this.adjLastBtn.Size = new System.Drawing.Size(26, 26);
            this.adjLastBtn.TabIndex = 8;
            this.adjLastBtn.Click += new System.EventHandler(this.adjLastBtn_Click);
            // 
            // createCusLabel
            // 
            this.createCusLabel.AutoSize = true;
            this.createCusLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCusLabel.Location = new System.Drawing.Point(16, 48);
            this.createCusLabel.Name = "createCusLabel";
            this.createCusLabel.Size = new System.Drawing.Size(132, 29);
            this.createCusLabel.TabIndex = 45;
            this.createCusLabel.Text = "Adjesments";
            // 
            // createAdjBtn
            // 
            this.createAdjBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createAdjBtn.Animated = true;
            this.createAdjBtn.BorderRadius = 8;
            this.createAdjBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createAdjBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createAdjBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createAdjBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createAdjBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.createAdjBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAdjBtn.ForeColor = System.Drawing.Color.White;
            this.createAdjBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.createAdjBtn.Location = new System.Drawing.Point(770, 97);
            this.createAdjBtn.Name = "createAdjBtn";
            this.createAdjBtn.Size = new System.Drawing.Size(209, 42);
            this.createAdjBtn.TabIndex = 46;
            this.createAdjBtn.Text = "Create Adjesment";
            this.createAdjBtn.Click += new System.EventHandler(this.createAdjBtn_Click);
            // 
            // Adjsments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.createAdjBtn);
            this.Controls.Add(this.createCusLabel);
            this.Controls.Add(this.productBtnPanel);
            this.Controls.Add(this.adjGridView);
            this.Controls.Add(this.adjRefreshBtn);
            this.Controls.Add(this.adjSearchText);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Adjsments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adjsments";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adjGridView)).EndInit();
            this.productBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView adjGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneButton adjRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox adjSearchText;
        private Siticone.Desktop.UI.WinForms.SiticonePanel productBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton adjirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton adjPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton adjNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton adjLastBtn;
        private System.Windows.Forms.Label createCusLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton createAdjBtn;
    }
}