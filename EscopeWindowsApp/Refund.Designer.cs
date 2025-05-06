namespace EscopeWindowsApp
{
    partial class Refund
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.refundBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.billProductDataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.billSearchTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.refClientNumLabel = new System.Windows.Forms.Label();
            this.refNumberLabel = new System.Windows.Forms.Label();
            this.refClientNameLabel = new System.Windows.Forms.Label();
            this.refNameLabel = new System.Windows.Forms.Label();
            this.refItemPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.addtoListBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.refQTYLabel = new System.Windows.Forms.Label();
            this.refQTYText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.refVarTypeLabel = new System.Windows.Forms.Label();
            this.refVarTypeText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.refUnitLabel = new System.Windows.Forms.Label();
            this.refUnitText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.proNameLabel = new System.Windows.Forms.Label();
            this.refProNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.itemCodeLabel = new System.Windows.Forms.Label();
            this.proIDText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.refItemDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingPricePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.refBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.refPriceCountLabel = new System.Windows.Forms.Label();
            this.cashCountLabel = new System.Windows.Forms.Label();
            this.refTotQtyLabel = new System.Windows.Forms.Label();
            this.refPriceLabael = new System.Windows.Forms.Label();
            this.PayMethLabel = new System.Windows.Forms.Label();
            this.refTotQtyCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refundBluToggleBtn = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.refundUSBScanToggleBtn = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.refuntWebcamScanBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billProductDataGrid)).BeginInit();
            this.refItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refItemDataGridView)).BeginInit();
            this.billingPricePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // refundBorderlessForm
            // 
            this.refundBorderlessForm.BorderRadius = 25;
            this.refundBorderlessForm.ContainerControl = this;
            this.refundBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.refundBorderlessForm.TransparentWhileDrag = true;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1200, 34);
            this.headerPanel.TabIndex = 32;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(1108, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(92, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(52, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 26);
            this.closeBtn.TabIndex = 0;
            // 
            // billProductDataGrid
            // 
            this.billProductDataGrid.AllowUserToAddRows = false;
            this.billProductDataGrid.AllowUserToDeleteRows = false;
            this.billProductDataGrid.AllowUserToResizeColumns = false;
            this.billProductDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.billProductDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.billProductDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.billProductDataGrid.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billProductDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.billProductDataGrid.ColumnHeadersHeight = 45;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billProductDataGrid.DefaultCellStyle = dataGridViewCellStyle23;
            this.billProductDataGrid.GridColor = System.Drawing.Color.White;
            this.billProductDataGrid.Location = new System.Drawing.Point(118, 117);
            this.billProductDataGrid.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.billProductDataGrid.Name = "billProductDataGrid";
            this.billProductDataGrid.ReadOnly = true;
            this.billProductDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billProductDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.billProductDataGrid.RowHeadersVisible = false;
            this.billProductDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.billProductDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.billProductDataGrid.RowTemplate.Height = 35;
            this.billProductDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.billProductDataGrid.Size = new System.Drawing.Size(465, 513);
            this.billProductDataGrid.TabIndex = 85;
            this.billProductDataGrid.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.billProductDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.billProductDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billProductDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.billProductDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.billProductDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.billProductDataGrid.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.billProductDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.billProductDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.billProductDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.billProductDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billProductDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.billProductDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.billProductDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.billProductDataGrid.ThemeStyle.ReadOnly = true;
            this.billProductDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.billProductDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.billProductDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billProductDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.billProductDataGrid.ThemeStyle.RowsStyle.Height = 35;
            this.billProductDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.billProductDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.billProductDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billProductDataGrid_CellContentClick);
            // 
            // billSearchTextBox
            // 
            this.billSearchTextBox.BorderColor = System.Drawing.Color.Silver;
            this.billSearchTextBox.BorderRadius = 8;
            this.billSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.billSearchTextBox.DefaultText = "";
            this.billSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.billSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.billSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.billSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.billSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.billSearchTextBox.ForeColor = System.Drawing.Color.Gray;
            this.billSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billSearchTextBox.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.billSearchTextBox.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.billSearchTextBox.IconRightOffset = new System.Drawing.Point(10, 0);
            this.billSearchTextBox.Location = new System.Drawing.Point(17, 53);
            this.billSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.billSearchTextBox.Name = "billSearchTextBox";
            this.billSearchTextBox.PasswordChar = '\0';
            this.billSearchTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.billSearchTextBox.PlaceholderText = "Search Bill Number";
            this.billSearchTextBox.SelectedText = "";
            this.billSearchTextBox.Size = new System.Drawing.Size(345, 42);
            this.billSearchTextBox.TabIndex = 86;
            this.billSearchTextBox.TextChanged += new System.EventHandler(this.billSearchTextBox_TextChanged);
            // 
            // refClientNumLabel
            // 
            this.refClientNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refClientNumLabel.AutoSize = true;
            this.refClientNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.refClientNumLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refClientNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.refClientNumLabel.Location = new System.Drawing.Point(473, 78);
            this.refClientNumLabel.Name = "refClientNumLabel";
            this.refClientNumLabel.Size = new System.Drawing.Size(40, 23);
            this.refClientNumLabel.TabIndex = 90;
            this.refClientNumLabel.Text = "Null";
            this.refClientNumLabel.Click += new System.EventHandler(this.refClientNumLabel_Click);
            // 
            // refNumberLabel
            // 
            this.refNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refNumberLabel.AutoSize = true;
            this.refNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.refNumberLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.refNumberLabel.Location = new System.Drawing.Point(389, 78);
            this.refNumberLabel.Name = "refNumberLabel";
            this.refNumberLabel.Size = new System.Drawing.Size(78, 23);
            this.refNumberLabel.TabIndex = 89;
            this.refNumberLabel.Text = "Number:";
            // 
            // refClientNameLabel
            // 
            this.refClientNameLabel.AutoSize = true;
            this.refClientNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.refClientNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refClientNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.refClientNameLabel.Location = new System.Drawing.Point(454, 53);
            this.refClientNameLabel.Name = "refClientNameLabel";
            this.refClientNameLabel.Size = new System.Drawing.Size(40, 23);
            this.refClientNameLabel.TabIndex = 88;
            this.refClientNameLabel.Text = "Null";
            this.refClientNameLabel.Click += new System.EventHandler(this.refClientNameLabel_Click);
            // 
            // refNameLabel
            // 
            this.refNameLabel.AutoSize = true;
            this.refNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.refNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.refNameLabel.Location = new System.Drawing.Point(389, 53);
            this.refNameLabel.Name = "refNameLabel";
            this.refNameLabel.Size = new System.Drawing.Size(60, 23);
            this.refNameLabel.TabIndex = 87;
            this.refNameLabel.Text = "Name:";
            // 
            // refItemPanel
            // 
            this.refItemPanel.BorderRadius = 8;
            this.refItemPanel.Controls.Add(this.addtoListBtn);
            this.refItemPanel.Controls.Add(this.refQTYLabel);
            this.refItemPanel.Controls.Add(this.refQTYText);
            this.refItemPanel.Controls.Add(this.refVarTypeLabel);
            this.refItemPanel.Controls.Add(this.refVarTypeText);
            this.refItemPanel.Controls.Add(this.refUnitLabel);
            this.refItemPanel.Controls.Add(this.refUnitText);
            this.refItemPanel.Controls.Add(this.proNameLabel);
            this.refItemPanel.Controls.Add(this.refProNameText);
            this.refItemPanel.Controls.Add(this.itemCodeLabel);
            this.refItemPanel.Controls.Add(this.proIDText);
            this.refItemPanel.FillColor = System.Drawing.Color.White;
            this.refItemPanel.Location = new System.Drawing.Point(599, 62);
            this.refItemPanel.Name = "refItemPanel";
            this.refItemPanel.Size = new System.Drawing.Size(587, 219);
            this.refItemPanel.TabIndex = 91;
            // 
            // addtoListBtn
            // 
            this.addtoListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addtoListBtn.Animated = true;
            this.addtoListBtn.BackColor = System.Drawing.Color.Transparent;
            this.addtoListBtn.BorderRadius = 8;
            this.addtoListBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addtoListBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addtoListBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addtoListBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addtoListBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.addtoListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.addtoListBtn.ForeColor = System.Drawing.Color.White;
            this.addtoListBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addtoListBtn.Location = new System.Drawing.Point(13, 168);
            this.addtoListBtn.Name = "addtoListBtn";
            this.addtoListBtn.Size = new System.Drawing.Size(553, 42);
            this.addtoListBtn.TabIndex = 92;
            this.addtoListBtn.Text = "Add To List";
            this.addtoListBtn.Click += new System.EventHandler(this.addtoListBtn_Click);
            // 
            // refQTYLabel
            // 
            this.refQTYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refQTYLabel.AutoSize = true;
            this.refQTYLabel.BackColor = System.Drawing.Color.Transparent;
            this.refQTYLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refQTYLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.refQTYLabel.Location = new System.Drawing.Point(404, 87);
            this.refQTYLabel.Name = "refQTYLabel";
            this.refQTYLabel.Size = new System.Drawing.Size(83, 23);
            this.refQTYLabel.TabIndex = 88;
            this.refQTYLabel.Text = "Quantity:";
            // 
            // refQTYText
            // 
            this.refQTYText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refQTYText.BackColor = System.Drawing.Color.Transparent;
            this.refQTYText.BorderColor = System.Drawing.Color.Silver;
            this.refQTYText.BorderRadius = 8;
            this.refQTYText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.refQTYText.DefaultText = "";
            this.refQTYText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.refQTYText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.refQTYText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.refQTYText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.refQTYText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.refQTYText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refQTYText.ForeColor = System.Drawing.Color.Gray;
            this.refQTYText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.refQTYText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.refQTYText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.refQTYText.Location = new System.Drawing.Point(408, 115);
            this.refQTYText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.refQTYText.Name = "refQTYText";
            this.refQTYText.PasswordChar = '\0';
            this.refQTYText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.refQTYText.PlaceholderText = "Quantity";
            this.refQTYText.SelectedText = "";
            this.refQTYText.Size = new System.Drawing.Size(158, 37);
            this.refQTYText.TabIndex = 89;
            this.refQTYText.TextChanged += new System.EventHandler(this.refQTYText_TextChanged);
            // 
            // refVarTypeLabel
            // 
            this.refVarTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refVarTypeLabel.AutoSize = true;
            this.refVarTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.refVarTypeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refVarTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.refVarTypeLabel.Location = new System.Drawing.Point(9, 87);
            this.refVarTypeLabel.Name = "refVarTypeLabel";
            this.refVarTypeLabel.Size = new System.Drawing.Size(85, 23);
            this.refVarTypeLabel.TabIndex = 86;
            this.refVarTypeLabel.Text = "Variation:";
            // 
            // refVarTypeText
            // 
            this.refVarTypeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refVarTypeText.BackColor = System.Drawing.Color.Transparent;
            this.refVarTypeText.BorderColor = System.Drawing.Color.Silver;
            this.refVarTypeText.BorderRadius = 8;
            this.refVarTypeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.refVarTypeText.DefaultText = "";
            this.refVarTypeText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.refVarTypeText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.refVarTypeText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.refVarTypeText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.refVarTypeText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.refVarTypeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refVarTypeText.ForeColor = System.Drawing.Color.Gray;
            this.refVarTypeText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.refVarTypeText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.refVarTypeText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.refVarTypeText.Location = new System.Drawing.Point(13, 115);
            this.refVarTypeText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.refVarTypeText.Name = "refVarTypeText";
            this.refVarTypeText.PasswordChar = '\0';
            this.refVarTypeText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.refVarTypeText.PlaceholderText = "Variation";
            this.refVarTypeText.SelectedText = "";
            this.refVarTypeText.Size = new System.Drawing.Size(171, 37);
            this.refVarTypeText.TabIndex = 87;
            this.refVarTypeText.TextChanged += new System.EventHandler(this.refVarTypeText_TextChanged);
            // 
            // refUnitLabel
            // 
            this.refUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refUnitLabel.AutoSize = true;
            this.refUnitLabel.BackColor = System.Drawing.Color.Transparent;
            this.refUnitLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refUnitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.refUnitLabel.Location = new System.Drawing.Point(209, 87);
            this.refUnitLabel.Name = "refUnitLabel";
            this.refUnitLabel.Size = new System.Drawing.Size(47, 23);
            this.refUnitLabel.TabIndex = 84;
            this.refUnitLabel.Text = "Unit:";
            // 
            // refUnitText
            // 
            this.refUnitText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refUnitText.BackColor = System.Drawing.Color.Transparent;
            this.refUnitText.BorderColor = System.Drawing.Color.Silver;
            this.refUnitText.BorderRadius = 8;
            this.refUnitText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.refUnitText.DefaultText = "";
            this.refUnitText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.refUnitText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.refUnitText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.refUnitText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.refUnitText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.refUnitText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refUnitText.ForeColor = System.Drawing.Color.Gray;
            this.refUnitText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.refUnitText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.refUnitText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.refUnitText.Location = new System.Drawing.Point(213, 115);
            this.refUnitText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.refUnitText.Name = "refUnitText";
            this.refUnitText.PasswordChar = '\0';
            this.refUnitText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.refUnitText.PlaceholderText = "Unit";
            this.refUnitText.SelectedText = "";
            this.refUnitText.Size = new System.Drawing.Size(171, 37);
            this.refUnitText.TabIndex = 85;
            this.refUnitText.TextChanged += new System.EventHandler(this.refUnitText_TextChanged);
            // 
            // proNameLabel
            // 
            this.proNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.proNameLabel.AutoSize = true;
            this.proNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.proNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.proNameLabel.Location = new System.Drawing.Point(178, 14);
            this.proNameLabel.Name = "proNameLabel";
            this.proNameLabel.Size = new System.Drawing.Size(125, 23);
            this.proNameLabel.TabIndex = 82;
            this.proNameLabel.Text = "Product Name:";
            // 
            // refProNameText
            // 
            this.refProNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refProNameText.BackColor = System.Drawing.Color.Transparent;
            this.refProNameText.BorderColor = System.Drawing.Color.Silver;
            this.refProNameText.BorderRadius = 8;
            this.refProNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.refProNameText.DefaultText = "";
            this.refProNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.refProNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.refProNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.refProNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.refProNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.refProNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refProNameText.ForeColor = System.Drawing.Color.Gray;
            this.refProNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.refProNameText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.refProNameText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.refProNameText.Location = new System.Drawing.Point(182, 42);
            this.refProNameText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.refProNameText.Name = "refProNameText";
            this.refProNameText.PasswordChar = '\0';
            this.refProNameText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.refProNameText.PlaceholderText = "Product Name";
            this.refProNameText.SelectedText = "";
            this.refProNameText.Size = new System.Drawing.Size(384, 37);
            this.refProNameText.TabIndex = 83;
            this.refProNameText.TextChanged += new System.EventHandler(this.refProNameText_TextChanged);
            // 
            // itemCodeLabel
            // 
            this.itemCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.itemCodeLabel.AutoSize = true;
            this.itemCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.itemCodeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.itemCodeLabel.Location = new System.Drawing.Point(9, 14);
            this.itemCodeLabel.Name = "itemCodeLabel";
            this.itemCodeLabel.Size = new System.Drawing.Size(98, 23);
            this.itemCodeLabel.TabIndex = 80;
            this.itemCodeLabel.Text = "Product ID:";
            // 
            // proIDText
            // 
            this.proIDText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.proIDText.BackColor = System.Drawing.Color.Transparent;
            this.proIDText.BorderColor = System.Drawing.Color.Silver;
            this.proIDText.BorderRadius = 8;
            this.proIDText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.proIDText.DefaultText = "";
            this.proIDText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.proIDText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.proIDText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.proIDText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.proIDText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.proIDText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proIDText.ForeColor = System.Drawing.Color.Gray;
            this.proIDText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.proIDText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.proIDText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.proIDText.Location = new System.Drawing.Point(13, 42);
            this.proIDText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.proIDText.Name = "proIDText";
            this.proIDText.PasswordChar = '\0';
            this.proIDText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.proIDText.PlaceholderText = "Product ID";
            this.proIDText.SelectedText = "";
            this.proIDText.Size = new System.Drawing.Size(157, 37);
            this.proIDText.TabIndex = 81;
            this.proIDText.TextChanged += new System.EventHandler(this.proIDText_TextChanged);
            // 
            // refItemDataGridView
            // 
            this.refItemDataGridView.AllowUserToAddRows = false;
            this.refItemDataGridView.AllowUserToDeleteRows = false;
            this.refItemDataGridView.AllowUserToResizeColumns = false;
            this.refItemDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.refItemDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.refItemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.refItemDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.refItemDataGridView.ColumnHeadersHeight = 45;
            this.refItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.refItemDataGridView.DefaultCellStyle = dataGridViewCellStyle19;
            this.refItemDataGridView.GridColor = System.Drawing.Color.White;
            this.refItemDataGridView.Location = new System.Drawing.Point(599, 298);
            this.refItemDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.refItemDataGridView.Name = "refItemDataGridView";
            this.refItemDataGridView.ReadOnly = true;
            this.refItemDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.refItemDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.refItemDataGridView.RowHeadersVisible = false;
            this.refItemDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.refItemDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.refItemDataGridView.RowTemplate.Height = 35;
            this.refItemDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.refItemDataGridView.Size = new System.Drawing.Size(587, 205);
            this.refItemDataGridView.TabIndex = 92;
            this.refItemDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.refItemDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.refItemDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refItemDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.refItemDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.refItemDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.refItemDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.refItemDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.refItemDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.refItemDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.refItemDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refItemDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.refItemDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.refItemDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.refItemDataGridView.ThemeStyle.ReadOnly = true;
            this.refItemDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.refItemDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.refItemDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refItemDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.refItemDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.refItemDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.refItemDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.refItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.refItemDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "No";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Type";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Price";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Del";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // billingPricePanel
            // 
            this.billingPricePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.billingPricePanel.BorderColor = System.Drawing.Color.Navy;
            this.billingPricePanel.BorderRadius = 8;
            this.billingPricePanel.BorderThickness = 1;
            this.billingPricePanel.Controls.Add(this.refBtn);
            this.billingPricePanel.Controls.Add(this.refPriceCountLabel);
            this.billingPricePanel.Controls.Add(this.cashCountLabel);
            this.billingPricePanel.Controls.Add(this.refTotQtyLabel);
            this.billingPricePanel.Controls.Add(this.refPriceLabael);
            this.billingPricePanel.Controls.Add(this.PayMethLabel);
            this.billingPricePanel.Controls.Add(this.refTotQtyCountLabel);
            this.billingPricePanel.Location = new System.Drawing.Point(599, 519);
            this.billingPricePanel.Name = "billingPricePanel";
            this.billingPricePanel.Size = new System.Drawing.Size(587, 111);
            this.billingPricePanel.TabIndex = 93;
            // 
            // refBtn
            // 
            this.refBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refBtn.Animated = true;
            this.refBtn.BorderRadius = 8;
            this.refBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refBtn.FillColor = System.Drawing.Color.Maroon;
            this.refBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refBtn.ForeColor = System.Drawing.Color.White;
            this.refBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refBtn.Location = new System.Drawing.Point(353, 12);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(221, 88);
            this.refBtn.TabIndex = 93;
            this.refBtn.Text = "Refund";
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // refPriceCountLabel
            // 
            this.refPriceCountLabel.AutoSize = true;
            this.refPriceCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.refPriceCountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refPriceCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refPriceCountLabel.Location = new System.Drawing.Point(109, 76);
            this.refPriceCountLabel.Name = "refPriceCountLabel";
            this.refPriceCountLabel.Size = new System.Drawing.Size(72, 25);
            this.refPriceCountLabel.TabIndex = 77;
            this.refPriceCountLabel.Text = "000.00";
            this.refPriceCountLabel.Click += new System.EventHandler(this.refPriceCountLabel_Click);
            // 
            // cashCountLabel
            // 
            this.cashCountLabel.AutoSize = true;
            this.cashCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.cashCountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashCountLabel.ForeColor = System.Drawing.Color.Green;
            this.cashCountLabel.Location = new System.Drawing.Point(151, 15);
            this.cashCountLabel.Name = "cashCountLabel";
            this.cashCountLabel.Size = new System.Drawing.Size(44, 21);
            this.cashCountLabel.TabIndex = 75;
            this.cashCountLabel.Text = "Cash";
            // 
            // refTotQtyLabel
            // 
            this.refTotQtyLabel.AutoSize = true;
            this.refTotQtyLabel.BackColor = System.Drawing.Color.Transparent;
            this.refTotQtyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refTotQtyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.refTotQtyLabel.Location = new System.Drawing.Point(13, 43);
            this.refTotQtyLabel.Name = "refTotQtyLabel";
            this.refTotQtyLabel.Size = new System.Drawing.Size(94, 25);
            this.refTotQtyLabel.TabIndex = 68;
            this.refTotQtyLabel.Text = "Total Qty:";
            // 
            // refPriceLabael
            // 
            this.refPriceLabael.AutoSize = true;
            this.refPriceLabael.BackColor = System.Drawing.Color.Transparent;
            this.refPriceLabael.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refPriceLabael.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refPriceLabael.Location = new System.Drawing.Point(13, 76);
            this.refPriceLabael.Name = "refPriceLabael";
            this.refPriceLabael.Size = new System.Drawing.Size(78, 25);
            this.refPriceLabael.TabIndex = 76;
            this.refPriceLabael.Text = "Refund:";
            // 
            // PayMethLabel
            // 
            this.PayMethLabel.AutoSize = true;
            this.PayMethLabel.BackColor = System.Drawing.Color.Transparent;
            this.PayMethLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayMethLabel.ForeColor = System.Drawing.Color.Green;
            this.PayMethLabel.Location = new System.Drawing.Point(14, 15);
            this.PayMethLabel.Name = "PayMethLabel";
            this.PayMethLabel.Size = new System.Drawing.Size(140, 21);
            this.PayMethLabel.TabIndex = 74;
            this.PayMethLabel.Text = "Payment Method:";
            // 
            // refTotQtyCountLabel
            // 
            this.refTotQtyCountLabel.AutoSize = true;
            this.refTotQtyCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.refTotQtyCountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refTotQtyCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.refTotQtyCountLabel.Location = new System.Drawing.Point(109, 43);
            this.refTotQtyCountLabel.Name = "refTotQtyCountLabel";
            this.refTotQtyCountLabel.Size = new System.Drawing.Size(72, 25);
            this.refTotQtyCountLabel.TabIndex = 69;
            this.refTotQtyCountLabel.Text = "000.00";
            this.refTotQtyCountLabel.Click += new System.EventHandler(this.refTotQtyCountLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 98;
            this.label2.Text = "Bluetooth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 97;
            this.label1.Text = "USB Scanner";
            // 
            // refundBluToggleBtn
            // 
            this.refundBluToggleBtn.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.refundBluToggleBtn.CheckedState.FillColor = System.Drawing.Color.Green;
            this.refundBluToggleBtn.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.refundBluToggleBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.refundBluToggleBtn.Location = new System.Drawing.Point(5, 318);
            this.refundBluToggleBtn.Name = "refundBluToggleBtn";
            this.refundBluToggleBtn.Size = new System.Drawing.Size(38, 24);
            this.refundBluToggleBtn.TabIndex = 96;
            this.refundBluToggleBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.refundBluToggleBtn.UncheckedState.BorderRadius = 8;
            this.refundBluToggleBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.refundBluToggleBtn.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.refundBluToggleBtn.UncheckedState.InnerBorderRadius = 8;
            this.refundBluToggleBtn.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.refundBluToggleBtn.CheckedChanged += new System.EventHandler(this.refundBluToggleBtn_CheckedChanged);
            // 
            // refundUSBScanToggleBtn
            // 
            this.refundUSBScanToggleBtn.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.refundUSBScanToggleBtn.CheckedState.FillColor = System.Drawing.Color.Green;
            this.refundUSBScanToggleBtn.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.refundUSBScanToggleBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.refundUSBScanToggleBtn.Location = new System.Drawing.Point(5, 244);
            this.refundUSBScanToggleBtn.Name = "refundUSBScanToggleBtn";
            this.refundUSBScanToggleBtn.Size = new System.Drawing.Size(38, 24);
            this.refundUSBScanToggleBtn.TabIndex = 95;
            this.refundUSBScanToggleBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.refundUSBScanToggleBtn.UncheckedState.BorderRadius = 8;
            this.refundUSBScanToggleBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.refundUSBScanToggleBtn.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.refundUSBScanToggleBtn.UncheckedState.InnerBorderRadius = 8;
            this.refundUSBScanToggleBtn.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.refundUSBScanToggleBtn.CheckedChanged += new System.EventHandler(this.refundUSBScanToggleBtn_CheckedChanged);
            // 
            // refuntWebcamScanBtn
            // 
            this.refuntWebcamScanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refuntWebcamScanBtn.Animated = true;
            this.refuntWebcamScanBtn.BackColor = System.Drawing.Color.Transparent;
            this.refuntWebcamScanBtn.BorderRadius = 8;
            this.refuntWebcamScanBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refuntWebcamScanBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refuntWebcamScanBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refuntWebcamScanBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refuntWebcamScanBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.refuntWebcamScanBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.refuntWebcamScanBtn.ForeColor = System.Drawing.Color.White;
            this.refuntWebcamScanBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.refuntWebcamScanBtn.Location = new System.Drawing.Point(5, 193);
            this.refuntWebcamScanBtn.Name = "refuntWebcamScanBtn";
            this.refuntWebcamScanBtn.Size = new System.Drawing.Size(98, 45);
            this.refuntWebcamScanBtn.TabIndex = 94;
            this.refuntWebcamScanBtn.Text = "Scan web cam";
            this.refuntWebcamScanBtn.Click += new System.EventHandler(this.refuntWebcamScanBtn_Click);
            // 
            // Refund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refundBluToggleBtn);
            this.Controls.Add(this.refundUSBScanToggleBtn);
            this.Controls.Add(this.refuntWebcamScanBtn);
            this.Controls.Add(this.billingPricePanel);
            this.Controls.Add(this.refItemDataGridView);
            this.Controls.Add(this.refItemPanel);
            this.Controls.Add(this.refClientNumLabel);
            this.Controls.Add(this.refNumberLabel);
            this.Controls.Add(this.refClientNameLabel);
            this.Controls.Add(this.refNameLabel);
            this.Controls.Add(this.billProductDataGrid);
            this.Controls.Add(this.billSearchTextBox);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "Refund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refund";
            this.Load += new System.EventHandler(this.Refund_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billProductDataGrid)).EndInit();
            this.refItemPanel.ResumeLayout(false);
            this.refItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refItemDataGridView)).EndInit();
            this.billingPricePanel.ResumeLayout(false);
            this.billingPricePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm refundBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView billProductDataGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox billSearchTextBox;
        private System.Windows.Forms.Label refClientNumLabel;
        private System.Windows.Forms.Label refNumberLabel;
        private System.Windows.Forms.Label refClientNameLabel;
        private System.Windows.Forms.Label refNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel refItemPanel;
        private System.Windows.Forms.Label itemCodeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox proIDText;
        private System.Windows.Forms.Label proNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox refProNameText;
        private System.Windows.Forms.Label refQTYLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox refQTYText;
        private System.Windows.Forms.Label refVarTypeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox refVarTypeText;
        private System.Windows.Forms.Label refUnitLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox refUnitText;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView refItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addtoListBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel billingPricePanel;
        private System.Windows.Forms.Label refPriceCountLabel;
        private System.Windows.Forms.Label cashCountLabel;
        private System.Windows.Forms.Label refTotQtyLabel;
        private System.Windows.Forms.Label refPriceLabael;
        private System.Windows.Forms.Label PayMethLabel;
        private System.Windows.Forms.Label refTotQtyCountLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton refBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch refundBluToggleBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch refundUSBScanToggleBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton refuntWebcamScanBtn;
    }
}