namespace EscopeWindowsApp
{
    partial class CreatePurchasesReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.retNoteBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.grnProSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.preReGRNDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.grnProductDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.purReNoteText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.grnCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.grnSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.createPurRetLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preReGRNDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grnProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // retNoteBorderlessForm
            // 
            this.retNoteBorderlessForm.BorderRadius = 25;
            this.retNoteBorderlessForm.ContainerControl = this;
            this.retNoteBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.retNoteBorderlessForm.TransparentWhileDrag = true;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1100, 34);
            this.headerPanel.TabIndex = 26;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.minimumBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(1007, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(93, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // minimumBtn
            // 
            this.minimumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumBtn.BorderRadius = 8;
            this.minimumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimumBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minimumBtn.IconColor = System.Drawing.Color.White;
            this.minimumBtn.Location = new System.Drawing.Point(15, 2);
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
            this.closeBtn.Location = new System.Drawing.Point(46, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 26);
            this.closeBtn.TabIndex = 0;
            // 
            // grnProSearchText
            // 
            this.grnProSearchText.BorderColor = System.Drawing.Color.Gray;
            this.grnProSearchText.BorderRadius = 8;
            this.grnProSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.grnProSearchText.DefaultText = "";
            this.grnProSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.grnProSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.grnProSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.grnProSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.grnProSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grnProSearchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnProSearchText.ForeColor = System.Drawing.Color.Gray;
            this.grnProSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grnProSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.grnProSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.grnProSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.grnProSearchText.Location = new System.Drawing.Point(679, 53);
            this.grnProSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grnProSearchText.Name = "grnProSearchText";
            this.grnProSearchText.PasswordChar = '\0';
            this.grnProSearchText.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.grnProSearchText.PlaceholderText = "Search Products";
            this.grnProSearchText.SelectedText = "";
            this.grnProSearchText.Size = new System.Drawing.Size(400, 42);
            this.grnProSearchText.TabIndex = 32;
            this.grnProSearchText.TextChanged += new System.EventHandler(this.grnProSearchText_TextChanged);
            // 
            // preReGRNDataGridView
            // 
            this.preReGRNDataGridView.AllowUserToAddRows = false;
            this.preReGRNDataGridView.AllowUserToDeleteRows = false;
            this.preReGRNDataGridView.AllowUserToResizeColumns = false;
            this.preReGRNDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.preReGRNDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.preReGRNDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.preReGRNDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.preReGRNDataGridView.ColumnHeadersHeight = 25;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.preReGRNDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.preReGRNDataGridView.GridColor = System.Drawing.Color.White;
            this.preReGRNDataGridView.Location = new System.Drawing.Point(22, 112);
            this.preReGRNDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.preReGRNDataGridView.Name = "preReGRNDataGridView";
            this.preReGRNDataGridView.ReadOnly = true;
            this.preReGRNDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.preReGRNDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.preReGRNDataGridView.RowHeadersVisible = false;
            this.preReGRNDataGridView.RowHeadersWidth = 22;
            this.preReGRNDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.preReGRNDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.preReGRNDataGridView.RowTemplate.Height = 35;
            this.preReGRNDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.preReGRNDataGridView.Size = new System.Drawing.Size(1057, 225);
            this.preReGRNDataGridView.TabIndex = 80;
            this.preReGRNDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.preReGRNDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preReGRNDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preReGRNDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.preReGRNDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.preReGRNDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.preReGRNDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.preReGRNDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.preReGRNDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.preReGRNDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.preReGRNDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preReGRNDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.preReGRNDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.preReGRNDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.preReGRNDataGridView.ThemeStyle.ReadOnly = true;
            this.preReGRNDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.preReGRNDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.preReGRNDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preReGRNDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.preReGRNDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.preReGRNDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.preReGRNDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.preReGRNDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.preReGRNDataGridView_CellContentClick);
            // 
            // grnProductDataGridView
            // 
            this.grnProductDataGridView.AllowUserToAddRows = false;
            this.grnProductDataGridView.AllowUserToDeleteRows = false;
            this.grnProductDataGridView.AllowUserToResizeColumns = false;
            this.grnProductDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grnProductDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grnProductDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.grnProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grnProductDataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grnProductDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.grnProductDataGridView.GridColor = System.Drawing.Color.White;
            this.grnProductDataGridView.Location = new System.Drawing.Point(22, 351);
            this.grnProductDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.grnProductDataGridView.Name = "grnProductDataGridView";
            this.grnProductDataGridView.ReadOnly = true;
            this.grnProductDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grnProductDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grnProductDataGridView.RowHeadersVisible = false;
            this.grnProductDataGridView.RowHeadersWidth = 22;
            this.grnProductDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grnProductDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grnProductDataGridView.RowTemplate.Height = 35;
            this.grnProductDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grnProductDataGridView.Size = new System.Drawing.Size(1057, 211);
            this.grnProductDataGridView.TabIndex = 81;
            this.grnProductDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.grnProductDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grnProductDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnProductDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grnProductDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.grnProductDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grnProductDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grnProductDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.grnProductDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.grnProductDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grnProductDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnProductDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grnProductDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grnProductDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.grnProductDataGridView.ThemeStyle.ReadOnly = true;
            this.grnProductDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.grnProductDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grnProductDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnProductDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grnProductDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.grnProductDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.grnProductDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grnProductDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grnProductDataGridView_CellContentClick);
            // 
            // purReNoteText
            // 
            this.purReNoteText.BorderColor = System.Drawing.Color.Gray;
            this.purReNoteText.BorderRadius = 8;
            this.purReNoteText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purReNoteText.DefaultText = "";
            this.purReNoteText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.purReNoteText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.purReNoteText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.purReNoteText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.purReNoteText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.purReNoteText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.purReNoteText.ForeColor = System.Drawing.Color.Gray;
            this.purReNoteText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.purReNoteText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.purReNoteText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.purReNoteText.Location = new System.Drawing.Point(22, 579);
            this.purReNoteText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purReNoteText.Name = "purReNoteText";
            this.purReNoteText.PasswordChar = '\0';
            this.purReNoteText.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.purReNoteText.PlaceholderText = "Note";
            this.purReNoteText.SelectedText = "";
            this.purReNoteText.Size = new System.Drawing.Size(1057, 42);
            this.purReNoteText.TabIndex = 82;
            this.purReNoteText.TextChanged += new System.EventHandler(this.purReNoteText_TextChanged);
            // 
            // grnCancelBtn
            // 
            this.grnCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grnCancelBtn.Animated = true;
            this.grnCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.grnCancelBtn.BorderRadius = 8;
            this.grnCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.grnCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.grnCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.grnCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.grnCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grnCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.grnCancelBtn.ForeColor = System.Drawing.Color.White;
            this.grnCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.grnCancelBtn.Location = new System.Drawing.Point(984, 639);
            this.grnCancelBtn.Name = "grnCancelBtn";
            this.grnCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.grnCancelBtn.TabIndex = 84;
            this.grnCancelBtn.Text = "Cancel";
            this.grnCancelBtn.Click += new System.EventHandler(this.grnCancelBtn_Click);
            // 
            // grnSaveBtn
            // 
            this.grnSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grnSaveBtn.Animated = true;
            this.grnSaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.grnSaveBtn.BorderRadius = 8;
            this.grnSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.grnSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.grnSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.grnSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.grnSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.grnSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grnSaveBtn.ForeColor = System.Drawing.Color.White;
            this.grnSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.grnSaveBtn.Location = new System.Drawing.Point(879, 639);
            this.grnSaveBtn.Name = "grnSaveBtn";
            this.grnSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.grnSaveBtn.TabIndex = 83;
            this.grnSaveBtn.Text = "Save";
            this.grnSaveBtn.Click += new System.EventHandler(this.grnSaveBtn_Click);
            // 
            // createPurRetLabel
            // 
            this.createPurRetLabel.AutoSize = true;
            this.createPurRetLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPurRetLabel.Location = new System.Drawing.Point(18, 50);
            this.createPurRetLabel.Name = "createPurRetLabel";
            this.createPurRetLabel.Size = new System.Drawing.Size(202, 32);
            this.createPurRetLabel.TabIndex = 85;
            this.createPurRetLabel.Text = "Purchases Return";
            // 
            // CreatePurchasesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 710);
            this.Controls.Add(this.createPurRetLabel);
            this.Controls.Add(this.grnCancelBtn);
            this.Controls.Add(this.grnSaveBtn);
            this.Controls.Add(this.purReNoteText);
            this.Controls.Add(this.grnProductDataGridView);
            this.Controls.Add(this.preReGRNDataGridView);
            this.Controls.Add(this.grnProSearchText);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1100, 710);
            this.MinimumSize = new System.Drawing.Size(1100, 710);
            this.Name = "CreatePurchasesReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePurchasesReturn";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preReGRNDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grnProductDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm retNoteBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox grnProSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView preReGRNDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox purReNoteText;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView grnProductDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneButton grnCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton grnSaveBtn;
        private System.Windows.Forms.Label createPurRetLabel;
    }
}