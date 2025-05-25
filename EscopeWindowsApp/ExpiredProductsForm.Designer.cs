namespace EscopeWindowsApp
{
    partial class ExpiredProductsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.supplierSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.expiredBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.expiredProductsDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.expiredRefreshBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.exFirstBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.exPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.exNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.exLastBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.exCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.expiredProductsDataGridView)).BeginInit();
            this.expBtnPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplierSearchText
            // 
            this.supplierSearchText.BorderColor = System.Drawing.Color.Gray;
            this.supplierSearchText.BorderRadius = 8;
            this.supplierSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplierSearchText.DefaultText = "";
            this.supplierSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supplierSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supplierSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierSearchText.ForeColor = System.Drawing.Color.Gray;
            this.supplierSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.supplierSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.supplierSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.supplierSearchText.Location = new System.Drawing.Point(12, 41);
            this.supplierSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supplierSearchText.Name = "supplierSearchText";
            this.supplierSearchText.PasswordChar = '\0';
            this.supplierSearchText.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.supplierSearchText.PlaceholderText = "Search";
            this.supplierSearchText.SelectedText = "";
            this.supplierSearchText.Size = new System.Drawing.Size(380, 42);
            this.supplierSearchText.TabIndex = 46;
            this.supplierSearchText.TextChanged += new System.EventHandler(this.supplierSearchText_TextChanged);
            // 
            // expiredBorderlessForm
            // 
            this.expiredBorderlessForm.BorderRadius = 12;
            this.expiredBorderlessForm.ContainerControl = this;
            this.expiredBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.expiredBorderlessForm.TransparentWhileDrag = true;
            // 
            // expiredProductsDataGridView
            // 
            this.expiredProductsDataGridView.AllowUserToAddRows = false;
            this.expiredProductsDataGridView.AllowUserToDeleteRows = false;
            this.expiredProductsDataGridView.AllowUserToResizeColumns = false;
            this.expiredProductsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.expiredProductsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.expiredProductsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expiredProductsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.expiredProductsDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expiredProductsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.expiredProductsDataGridView.GridColor = System.Drawing.Color.White;
            this.expiredProductsDataGridView.Location = new System.Drawing.Point(12, 94);
            this.expiredProductsDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.expiredProductsDataGridView.Name = "expiredProductsDataGridView";
            this.expiredProductsDataGridView.ReadOnly = true;
            this.expiredProductsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expiredProductsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.expiredProductsDataGridView.RowHeadersVisible = false;
            this.expiredProductsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.expiredProductsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.expiredProductsDataGridView.RowTemplate.Height = 35;
            this.expiredProductsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.expiredProductsDataGridView.Size = new System.Drawing.Size(918, 314);
            this.expiredProductsDataGridView.TabIndex = 49;
            this.expiredProductsDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.expiredProductsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.expiredProductsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredProductsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.expiredProductsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.expiredProductsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.expiredProductsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.expiredProductsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.expiredProductsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.expiredProductsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.expiredProductsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredProductsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.expiredProductsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.expiredProductsDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.expiredProductsDataGridView.ThemeStyle.ReadOnly = true;
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.expiredProductsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.expiredProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expiredProductsDataGridView_CellContentClick);
            // 
            // expiredRefreshBtn
            // 
            this.expiredRefreshBtn.Animated = true;
            this.expiredRefreshBtn.BorderRadius = 8;
            this.expiredRefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expiredRefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expiredRefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expiredRefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expiredRefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.expiredRefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expiredRefreshBtn.ForeColor = System.Drawing.Color.White;
            this.expiredRefreshBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.expiredRefreshBtn.Image = global::EscopeWindowsApp.Properties.Resources.refresh1;
            this.expiredRefreshBtn.Location = new System.Drawing.Point(420, 44);
            this.expiredRefreshBtn.Name = "expiredRefreshBtn";
            this.expiredRefreshBtn.Size = new System.Drawing.Size(42, 42);
            this.expiredRefreshBtn.TabIndex = 50;
            this.expiredRefreshBtn.Click += new System.EventHandler(this.expiredRefreshBtn_Click);
            // 
            // expBtnPanel
            // 
            this.expBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expBtnPanel.BackColor = System.Drawing.Color.Transparent;
            this.expBtnPanel.BorderRadius = 8;
            this.expBtnPanel.Controls.Add(this.exFirstBtn);
            this.expBtnPanel.Controls.Add(this.exPrevBtn);
            this.expBtnPanel.Controls.Add(this.exNextBtn);
            this.expBtnPanel.Controls.Add(this.exLastBtn);
            this.expBtnPanel.Location = new System.Drawing.Point(776, 422);
            this.expBtnPanel.Name = "expBtnPanel";
            this.expBtnPanel.Size = new System.Drawing.Size(154, 37);
            this.expBtnPanel.TabIndex = 51;
            // 
            // exFirstBtn
            // 
            this.exFirstBtn.BorderRadius = 6;
            this.exFirstBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exFirstBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exFirstBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exFirstBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exFirstBtn.FillColor = System.Drawing.SystemColors.Control;
            this.exFirstBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exFirstBtn.ForeColor = System.Drawing.Color.White;
            this.exFirstBtn.Image = global::EscopeWindowsApp.Properties.Resources.firstBtn1;
            this.exFirstBtn.Location = new System.Drawing.Point(3, 8);
            this.exFirstBtn.Name = "exFirstBtn";
            this.exFirstBtn.Size = new System.Drawing.Size(26, 26);
            this.exFirstBtn.TabIndex = 11;
            this.exFirstBtn.Click += new System.EventHandler(this.exFirstBtn_Click);
            // 
            // exPrevBtn
            // 
            this.exPrevBtn.BorderRadius = 6;
            this.exPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.exPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exPrevBtn.ForeColor = System.Drawing.Color.White;
            this.exPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.exPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.exPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.exPrevBtn.Name = "exPrevBtn";
            this.exPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.exPrevBtn.TabIndex = 11;
            this.exPrevBtn.Click += new System.EventHandler(this.exPrevBtn_Click);
            // 
            // exNextBtn
            // 
            this.exNextBtn.BorderRadius = 6;
            this.exNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.exNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exNextBtn.ForeColor = System.Drawing.Color.White;
            this.exNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.exNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.exNextBtn.Location = new System.Drawing.Point(87, 8);
            this.exNextBtn.Name = "exNextBtn";
            this.exNextBtn.Size = new System.Drawing.Size(26, 26);
            this.exNextBtn.TabIndex = 9;
            this.exNextBtn.Click += new System.EventHandler(this.exNextBtn_Click);
            // 
            // exLastBtn
            // 
            this.exLastBtn.BorderRadius = 6;
            this.exLastBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exLastBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exLastBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exLastBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exLastBtn.FillColor = System.Drawing.SystemColors.Control;
            this.exLastBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exLastBtn.ForeColor = System.Drawing.Color.White;
            this.exLastBtn.Image = global::EscopeWindowsApp.Properties.Resources.lastoBtn1;
            this.exLastBtn.Location = new System.Drawing.Point(130, 8);
            this.exLastBtn.Name = "exLastBtn";
            this.exLastBtn.Size = new System.Drawing.Size(26, 26);
            this.exLastBtn.TabIndex = 8;
            this.exLastBtn.Click += new System.EventHandler(this.exLastBtn_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(939, 34);
            this.headerPanel.TabIndex = 81;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(891, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(48, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(10, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 26);
            this.closeBtn.TabIndex = 0;
            // 
            // exCancelBtn
            // 
            this.exCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exCancelBtn.Animated = true;
            this.exCancelBtn.BorderRadius = 8;
            this.exCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exCancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.exCancelBtn.ForeColor = System.Drawing.Color.White;
            this.exCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.exCancelBtn.Location = new System.Drawing.Point(832, 474);
            this.exCancelBtn.Name = "exCancelBtn";
            this.exCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.exCancelBtn.TabIndex = 83;
            this.exCancelBtn.Text = "Cancel";
            this.exCancelBtn.Click += new System.EventHandler(this.exCancelBtn_Click);
            // 
            // ExpiredProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 531);
            this.Controls.Add(this.exCancelBtn);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.expBtnPanel);
            this.Controls.Add(this.expiredRefreshBtn);
            this.Controls.Add(this.expiredProductsDataGridView);
            this.Controls.Add(this.supplierSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpiredProductsForm";
            this.Text = "ExpiredProductsForm";
            this.Load += new System.EventHandler(this.ExpiredProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expiredProductsDataGridView)).EndInit();
            this.expBtnPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox supplierSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm expiredBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView expiredProductsDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneButton expiredRefreshBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel expBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton exFirstBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton exPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton exNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton exLastBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton exCancelBtn;
    }
}