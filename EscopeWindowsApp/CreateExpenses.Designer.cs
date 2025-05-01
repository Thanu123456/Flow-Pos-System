namespace EscopeWindowsApp
{
    partial class CreateExpenses
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
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.creExpLabel = new System.Windows.Forms.Label();
            this.creExpPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.creExpCatComboBox = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.creExpWarehouseComboBox = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.creExpDateTimePicker = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.creExpDetailsext = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.creExpDetailsLabel = new System.Windows.Forms.Label();
            this.creExpAmountText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.creExpAmountLabel = new System.Windows.Forms.Label();
            this.creExpCatLabel = new System.Windows.Forms.Label();
            this.creExpWarehouseLabel = new System.Windows.Forms.Label();
            this.creExpTitleLabel = new System.Windows.Forms.Label();
            this.creExpDateLabel = new System.Windows.Forms.Label();
            this.creExpTitleText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.creExpCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.creExpSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.creExpBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.creExpPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.headerPanel.TabIndex = 29;
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
            // creExpLabel
            // 
            this.creExpLabel.AutoSize = true;
            this.creExpLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creExpLabel.Location = new System.Drawing.Point(18, 50);
            this.creExpLabel.Name = "creExpLabel";
            this.creExpLabel.Size = new System.Drawing.Size(177, 29);
            this.creExpLabel.TabIndex = 31;
            this.creExpLabel.Text = "Create Expenses";
            // 
            // creExpPanel
            // 
            this.creExpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creExpPanel.BorderRadius = 8;
            this.creExpPanel.Controls.Add(this.creExpCatComboBox);
            this.creExpPanel.Controls.Add(this.creExpWarehouseComboBox);
            this.creExpPanel.Controls.Add(this.creExpDateTimePicker);
            this.creExpPanel.Controls.Add(this.creExpDetailsext);
            this.creExpPanel.Controls.Add(this.creExpDetailsLabel);
            this.creExpPanel.Controls.Add(this.creExpAmountText);
            this.creExpPanel.Controls.Add(this.creExpAmountLabel);
            this.creExpPanel.Controls.Add(this.creExpCatLabel);
            this.creExpPanel.Controls.Add(this.creExpWarehouseLabel);
            this.creExpPanel.Controls.Add(this.creExpTitleLabel);
            this.creExpPanel.Controls.Add(this.creExpDateLabel);
            this.creExpPanel.Controls.Add(this.creExpTitleText);
            this.creExpPanel.FillColor = System.Drawing.Color.White;
            this.creExpPanel.Location = new System.Drawing.Point(23, 96);
            this.creExpPanel.Name = "creExpPanel";
            this.creExpPanel.Size = new System.Drawing.Size(956, 309);
            this.creExpPanel.TabIndex = 32;
            // 
            // creExpCatComboBox
            // 
            this.creExpCatComboBox.BackColor = System.Drawing.Color.Transparent;
            this.creExpCatComboBox.BorderRadius = 8;
            this.creExpCatComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.creExpCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creExpCatComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.creExpCatComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.creExpCatComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creExpCatComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.creExpCatComboBox.ItemHeight = 36;
            this.creExpCatComboBox.Items.AddRange(new object[] {
            "Choose Category",
            "Supplier 1",
            "Supplier 2"});
            this.creExpCatComboBox.Location = new System.Drawing.Point(494, 142);
            this.creExpCatComboBox.Name = "creExpCatComboBox";
            this.creExpCatComboBox.Size = new System.Drawing.Size(443, 42);
            this.creExpCatComboBox.StartIndex = 0;
            this.creExpCatComboBox.TabIndex = 52;
            this.creExpCatComboBox.SelectedIndexChanged += new System.EventHandler(this.creExpCatComboBox_SelectedIndexChanged);
            // 
            // creExpWarehouseComboBox
            // 
            this.creExpWarehouseComboBox.BackColor = System.Drawing.Color.Transparent;
            this.creExpWarehouseComboBox.BorderRadius = 8;
            this.creExpWarehouseComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.creExpWarehouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creExpWarehouseComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.creExpWarehouseComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.creExpWarehouseComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creExpWarehouseComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.creExpWarehouseComboBox.ItemHeight = 36;
            this.creExpWarehouseComboBox.Items.AddRange(new object[] {
            "Choose Warehouse",
            "Supplier 1",
            "Supplier 2"});
            this.creExpWarehouseComboBox.Location = new System.Drawing.Point(21, 142);
            this.creExpWarehouseComboBox.Name = "creExpWarehouseComboBox";
            this.creExpWarehouseComboBox.Size = new System.Drawing.Size(443, 42);
            this.creExpWarehouseComboBox.StartIndex = 0;
            this.creExpWarehouseComboBox.TabIndex = 51;
            this.creExpWarehouseComboBox.SelectedIndexChanged += new System.EventHandler(this.creExpWarehouseComboBox_SelectedIndexChanged);
            // 
            // creExpDateTimePicker
            // 
            this.creExpDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.creExpDateTimePicker.BorderRadius = 8;
            this.creExpDateTimePicker.Checked = true;
            this.creExpDateTimePicker.FillColor = System.Drawing.Color.White;
            this.creExpDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creExpDateTimePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.creExpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.creExpDateTimePicker.Location = new System.Drawing.Point(21, 52);
            this.creExpDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.creExpDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.creExpDateTimePicker.Name = "creExpDateTimePicker";
            this.creExpDateTimePicker.Size = new System.Drawing.Size(443, 42);
            this.creExpDateTimePicker.TabIndex = 29;
            this.creExpDateTimePicker.Value = new System.DateTime(2025, 4, 3, 12, 15, 33, 945);
            this.creExpDateTimePicker.ValueChanged += new System.EventHandler(this.creExpDateTimePicker_ValueChanged);
            // 
            // creExpDetailsext
            // 
            this.creExpDetailsext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creExpDetailsext.BackColor = System.Drawing.Color.Transparent;
            this.creExpDetailsext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.creExpDetailsext.BorderRadius = 8;
            this.creExpDetailsext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.creExpDetailsext.DefaultText = "";
            this.creExpDetailsext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.creExpDetailsext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.creExpDetailsext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.creExpDetailsext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.creExpDetailsext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.creExpDetailsext.Font = new System.Drawing.Font("Calibri", 12F);
            this.creExpDetailsext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.creExpDetailsext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.creExpDetailsext.Location = new System.Drawing.Point(494, 231);
            this.creExpDetailsext.Margin = new System.Windows.Forms.Padding(4);
            this.creExpDetailsext.Name = "creExpDetailsext";
            this.creExpDetailsext.PasswordChar = '\0';
            this.creExpDetailsext.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.creExpDetailsext.PlaceholderText = "Enter Note About The Expense";
            this.creExpDetailsext.SelectedText = "";
            this.creExpDetailsext.Size = new System.Drawing.Size(443, 42);
            this.creExpDetailsext.TabIndex = 28;
            this.creExpDetailsext.TextChanged += new System.EventHandler(this.creExpDetailsext_TextChanged);
            // 
            // creExpDetailsLabel
            // 
            this.creExpDetailsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creExpDetailsLabel.AutoSize = true;
            this.creExpDetailsLabel.BackColor = System.Drawing.Color.White;
            this.creExpDetailsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creExpDetailsLabel.Location = new System.Drawing.Point(491, 200);
            this.creExpDetailsLabel.Name = "creExpDetailsLabel";
            this.creExpDetailsLabel.Size = new System.Drawing.Size(67, 23);
            this.creExpDetailsLabel.TabIndex = 27;
            this.creExpDetailsLabel.Text = "Details:";
            // 
            // creExpAmountText
            // 
            this.creExpAmountText.BackColor = System.Drawing.Color.Transparent;
            this.creExpAmountText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.creExpAmountText.BorderRadius = 8;
            this.creExpAmountText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.creExpAmountText.DefaultText = "";
            this.creExpAmountText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.creExpAmountText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.creExpAmountText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.creExpAmountText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.creExpAmountText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.creExpAmountText.Font = new System.Drawing.Font("Calibri", 12F);
            this.creExpAmountText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.creExpAmountText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.creExpAmountText.Location = new System.Drawing.Point(21, 231);
            this.creExpAmountText.Margin = new System.Windows.Forms.Padding(4);
            this.creExpAmountText.Name = "creExpAmountText";
            this.creExpAmountText.PasswordChar = '\0';
            this.creExpAmountText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.creExpAmountText.PlaceholderText = "Enter Warehouse Address";
            this.creExpAmountText.SelectedText = "";
            this.creExpAmountText.Size = new System.Drawing.Size(441, 42);
            this.creExpAmountText.TabIndex = 26;
            this.creExpAmountText.TextChanged += new System.EventHandler(this.creExpAmountText_TextChanged);
            // 
            // creExpAmountLabel
            // 
            this.creExpAmountLabel.AutoSize = true;
            this.creExpAmountLabel.BackColor = System.Drawing.Color.White;
            this.creExpAmountLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creExpAmountLabel.Location = new System.Drawing.Point(15, 200);
            this.creExpAmountLabel.Name = "creExpAmountLabel";
            this.creExpAmountLabel.Size = new System.Drawing.Size(77, 23);
            this.creExpAmountLabel.TabIndex = 25;
            this.creExpAmountLabel.Text = "Amount:";
            // 
            // creExpCatLabel
            // 
            this.creExpCatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creExpCatLabel.AutoSize = true;
            this.creExpCatLabel.BackColor = System.Drawing.Color.White;
            this.creExpCatLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creExpCatLabel.Location = new System.Drawing.Point(490, 111);
            this.creExpCatLabel.Name = "creExpCatLabel";
            this.creExpCatLabel.Size = new System.Drawing.Size(159, 23);
            this.creExpCatLabel.TabIndex = 23;
            this.creExpCatLabel.Text = "Expenses Category:";
            // 
            // creExpWarehouseLabel
            // 
            this.creExpWarehouseLabel.AutoSize = true;
            this.creExpWarehouseLabel.BackColor = System.Drawing.Color.White;
            this.creExpWarehouseLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creExpWarehouseLabel.Location = new System.Drawing.Point(17, 111);
            this.creExpWarehouseLabel.Name = "creExpWarehouseLabel";
            this.creExpWarehouseLabel.Size = new System.Drawing.Size(103, 23);
            this.creExpWarehouseLabel.TabIndex = 22;
            this.creExpWarehouseLabel.Text = "Warehouse:";
            // 
            // creExpTitleLabel
            // 
            this.creExpTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creExpTitleLabel.AutoSize = true;
            this.creExpTitleLabel.BackColor = System.Drawing.Color.White;
            this.creExpTitleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creExpTitleLabel.Location = new System.Drawing.Point(491, 21);
            this.creExpTitleLabel.Name = "creExpTitleLabel";
            this.creExpTitleLabel.Size = new System.Drawing.Size(122, 23);
            this.creExpTitleLabel.TabIndex = 21;
            this.creExpTitleLabel.Text = "Expenses Title:";
            // 
            // creExpDateLabel
            // 
            this.creExpDateLabel.AutoSize = true;
            this.creExpDateLabel.BackColor = System.Drawing.Color.White;
            this.creExpDateLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creExpDateLabel.Location = new System.Drawing.Point(15, 21);
            this.creExpDateLabel.Name = "creExpDateLabel";
            this.creExpDateLabel.Size = new System.Drawing.Size(51, 23);
            this.creExpDateLabel.TabIndex = 19;
            this.creExpDateLabel.Text = "Date:";
            // 
            // creExpTitleText
            // 
            this.creExpTitleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creExpTitleText.BackColor = System.Drawing.Color.Transparent;
            this.creExpTitleText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.creExpTitleText.BorderRadius = 8;
            this.creExpTitleText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.creExpTitleText.DefaultText = "";
            this.creExpTitleText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.creExpTitleText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.creExpTitleText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.creExpTitleText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.creExpTitleText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.creExpTitleText.Font = new System.Drawing.Font("Calibri", 12F);
            this.creExpTitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.creExpTitleText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.creExpTitleText.Location = new System.Drawing.Point(494, 52);
            this.creExpTitleText.Margin = new System.Windows.Forms.Padding(4);
            this.creExpTitleText.Name = "creExpTitleText";
            this.creExpTitleText.PasswordChar = '\0';
            this.creExpTitleText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.creExpTitleText.PlaceholderText = "Enter Expenses Title";
            this.creExpTitleText.SelectedText = "";
            this.creExpTitleText.Size = new System.Drawing.Size(443, 42);
            this.creExpTitleText.TabIndex = 5;
            this.creExpTitleText.TextChanged += new System.EventHandler(this.creExpTitleText_TextChanged);
            // 
            // creExpCancelBtn
            // 
            this.creExpCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creExpCancelBtn.Animated = true;
            this.creExpCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.creExpCancelBtn.BorderRadius = 8;
            this.creExpCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.creExpCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.creExpCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.creExpCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.creExpCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.creExpCancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creExpCancelBtn.ForeColor = System.Drawing.Color.White;
            this.creExpCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.creExpCancelBtn.Location = new System.Drawing.Point(884, 429);
            this.creExpCancelBtn.Name = "creExpCancelBtn";
            this.creExpCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.creExpCancelBtn.TabIndex = 34;
            this.creExpCancelBtn.Text = "Cancel";
            this.creExpCancelBtn.Click += new System.EventHandler(this.creExpCancelBtn_Click);
            // 
            // creExpSaveBtn
            // 
            this.creExpSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creExpSaveBtn.Animated = true;
            this.creExpSaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.creExpSaveBtn.BorderRadius = 8;
            this.creExpSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.creExpSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.creExpSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.creExpSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.creExpSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.creExpSaveBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creExpSaveBtn.ForeColor = System.Drawing.Color.White;
            this.creExpSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.creExpSaveBtn.Location = new System.Drawing.Point(779, 429);
            this.creExpSaveBtn.Name = "creExpSaveBtn";
            this.creExpSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.creExpSaveBtn.TabIndex = 33;
            this.creExpSaveBtn.Text = "Save";
            this.creExpSaveBtn.Click += new System.EventHandler(this.creExpSaveBtn_Click);
            // 
            // creExpBorderlessForm
            // 
            this.creExpBorderlessForm.BorderRadius = 25;
            this.creExpBorderlessForm.ContainerControl = this;
            this.creExpBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.creExpBorderlessForm.TransparentWhileDrag = true;
            // 
            // CreateExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.creExpSaveBtn);
            this.Controls.Add(this.creExpCancelBtn);
            this.Controls.Add(this.creExpPanel);
            this.Controls.Add(this.creExpLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "CreateExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateExpenses";
            this.Load += new System.EventHandler(this.CreateExpenses_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.creExpPanel.ResumeLayout(false);
            this.creExpPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private System.Windows.Forms.Label creExpLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel creExpPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox creExpDetailsext;
        private System.Windows.Forms.Label creExpDetailsLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox creExpAmountText;
        private System.Windows.Forms.Label creExpAmountLabel;
        private System.Windows.Forms.Label creExpCatLabel;
        private System.Windows.Forms.Label creExpWarehouseLabel;
        private System.Windows.Forms.Label creExpTitleLabel;
        private System.Windows.Forms.Label creExpDateLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox creExpTitleText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creExpCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creExpSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm creExpBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker creExpDateTimePicker;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox creExpWarehouseComboBox;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox creExpCatComboBox;
    }
}