namespace EscopeWindowsApp
{
    partial class sideBarForm
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
            this.sideBarlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.sideBarSubPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.sideBarMinimizeBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sideBarAdminBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sideBarAdminUserLabel = new System.Windows.Forms.Label();
            this.sideBarUserNameLabel = new System.Windows.Forms.Label();
            this.sideBarProfile = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.sideBarNotifyBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sideBarSearchPanel = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.morningLabel = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.masterContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.customerBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supplierBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.inventoryBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.masterTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.userBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.masterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.productBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.sideBarSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideBarProfile)).BeginInit();
            this.sidebar.SuspendLayout();
            this.masterContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarlessForm
            // 
            this.sideBarlessForm.ContainerControl = this;
            this.sideBarlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.sideBarlessForm.TransparentWhileDrag = true;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1386, 34);
            this.headerPanel.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.minimumBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.Location = new System.Drawing.Point(1302, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(81, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // minimumBtn
            // 
            this.minimumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumBtn.BorderRadius = 8;
            this.minimumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimumBtn.FillColor = System.Drawing.Color.Green;
            this.minimumBtn.IconColor = System.Drawing.Color.White;
            this.minimumBtn.Location = new System.Drawing.Point(4, 2);
            this.minimumBtn.Name = "minimumBtn";
            this.minimumBtn.Size = new System.Drawing.Size(33, 25);
            this.minimumBtn.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.FillColor = System.Drawing.Color.Firebrick;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(44, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(33, 25);
            this.closeBtn.TabIndex = 0;
            // 
            // sideBarSubPanel
            // 
            this.sideBarSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.sideBarSubPanel.Controls.Add(this.sideBarMinimizeBtn);
            this.sideBarSubPanel.Controls.Add(this.sideBarAdminBtn);
            this.sideBarSubPanel.Controls.Add(this.sideBarAdminUserLabel);
            this.sideBarSubPanel.Controls.Add(this.sideBarUserNameLabel);
            this.sideBarSubPanel.Controls.Add(this.sideBarProfile);
            this.sideBarSubPanel.Controls.Add(this.sideBarNotifyBtn);
            this.sideBarSubPanel.Controls.Add(this.sideBarSearchPanel);
            this.sideBarSubPanel.Controls.Add(this.label1);
            this.sideBarSubPanel.Controls.Add(this.morningLabel);
            this.sideBarSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideBarSubPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.sideBarSubPanel.Location = new System.Drawing.Point(0, 34);
            this.sideBarSubPanel.Name = "sideBarSubPanel";
            this.sideBarSubPanel.Size = new System.Drawing.Size(1386, 71);
            this.sideBarSubPanel.TabIndex = 2;
            // 
            // sideBarMinimizeBtn
            // 
            this.sideBarMinimizeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sideBarMinimizeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sideBarMinimizeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sideBarMinimizeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sideBarMinimizeBtn.FillColor = System.Drawing.Color.Transparent;
            this.sideBarMinimizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sideBarMinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.sideBarMinimizeBtn.Image = global::EscopeWindowsApp.Properties.Resources.My_new_logo_b_05;
            this.sideBarMinimizeBtn.ImageSize = new System.Drawing.Size(165, 50);
            this.sideBarMinimizeBtn.Location = new System.Drawing.Point(12, 9);
            this.sideBarMinimizeBtn.Name = "sideBarMinimizeBtn";
            this.sideBarMinimizeBtn.Size = new System.Drawing.Size(180, 45);
            this.sideBarMinimizeBtn.TabIndex = 8;
            this.sideBarMinimizeBtn.Click += new System.EventHandler(this.sideBarMinimizeBtn_Click);
            // 
            // sideBarAdminBtn
            // 
            this.sideBarAdminBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sideBarAdminBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sideBarAdminBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sideBarAdminBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sideBarAdminBtn.FillColor = System.Drawing.Color.Transparent;
            this.sideBarAdminBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sideBarAdminBtn.ForeColor = System.Drawing.Color.White;
            this.sideBarAdminBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_forward_50__3_;
            this.sideBarAdminBtn.Location = new System.Drawing.Point(1320, 19);
            this.sideBarAdminBtn.Name = "sideBarAdminBtn";
            this.sideBarAdminBtn.Size = new System.Drawing.Size(39, 33);
            this.sideBarAdminBtn.TabIndex = 5;
            // 
            // sideBarAdminUserLabel
            // 
            this.sideBarAdminUserLabel.AutoSize = true;
            this.sideBarAdminUserLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.sideBarAdminUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideBarAdminUserLabel.Location = new System.Drawing.Point(1252, 37);
            this.sideBarAdminUserLabel.Name = "sideBarAdminUserLabel";
            this.sideBarAdminUserLabel.Size = new System.Drawing.Size(61, 13);
            this.sideBarAdminUserLabel.TabIndex = 6;
            this.sideBarAdminUserLabel.Text = "Admin User";
            // 
            // sideBarUserNameLabel
            // 
            this.sideBarUserNameLabel.AutoSize = true;
            this.sideBarUserNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.sideBarUserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideBarUserNameLabel.Location = new System.Drawing.Point(1250, 17);
            this.sideBarUserNameLabel.Name = "sideBarUserNameLabel";
            this.sideBarUserNameLabel.Size = new System.Drawing.Size(69, 20);
            this.sideBarUserNameLabel.TabIndex = 5;
            this.sideBarUserNameLabel.Text = "Dilshan";
            // 
            // sideBarProfile
            // 
            this.sideBarProfile.FillColor = System.Drawing.Color.Transparent;
            this.sideBarProfile.Image = global::EscopeWindowsApp.Properties.Resources.userIcon;
            this.sideBarProfile.ImageRotate = 0F;
            this.sideBarProfile.Location = new System.Drawing.Point(1208, 16);
            this.sideBarProfile.Name = "sideBarProfile";
            this.sideBarProfile.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.sideBarProfile.Size = new System.Drawing.Size(36, 36);
            this.sideBarProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sideBarProfile.TabIndex = 4;
            this.sideBarProfile.TabStop = false;
            // 
            // sideBarNotifyBtn
            // 
            this.sideBarNotifyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sideBarNotifyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sideBarNotifyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sideBarNotifyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sideBarNotifyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.sideBarNotifyBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sideBarNotifyBtn.ForeColor = System.Drawing.Color.White;
            this.sideBarNotifyBtn.Image = global::EscopeWindowsApp.Properties.Resources.bell;
            this.sideBarNotifyBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.sideBarNotifyBtn.Location = new System.Drawing.Point(1153, 17);
            this.sideBarNotifyBtn.Name = "sideBarNotifyBtn";
            this.sideBarNotifyBtn.Size = new System.Drawing.Size(36, 36);
            this.sideBarNotifyBtn.TabIndex = 3;
            // 
            // sideBarSearchPanel
            // 
            this.sideBarSearchPanel.BorderRadius = 8;
            this.sideBarSearchPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sideBarSearchPanel.DefaultText = "";
            this.sideBarSearchPanel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sideBarSearchPanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sideBarSearchPanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sideBarSearchPanel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sideBarSearchPanel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sideBarSearchPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideBarSearchPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sideBarSearchPanel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sideBarSearchPanel.IconLeft = global::EscopeWindowsApp.Properties.Resources.icons8_search_50;
            this.sideBarSearchPanel.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.sideBarSearchPanel.Location = new System.Drawing.Point(856, 17);
            this.sideBarSearchPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sideBarSearchPanel.Name = "sideBarSearchPanel";
            this.sideBarSearchPanel.PasswordChar = '\0';
            this.sideBarSearchPanel.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.sideBarSearchPanel.PlaceholderText = "Search";
            this.sideBarSearchPanel.SelectedText = "";
            this.sideBarSearchPanel.Size = new System.Drawing.Size(275, 35);
            this.sideBarSearchPanel.TabIndex = 2;
            this.sideBarSearchPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // morningLabel
            // 
            this.morningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.morningLabel.AutoSize = true;
            this.morningLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.morningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.morningLabel.Location = new System.Drawing.Point(242, 13);
            this.morningLabel.Name = "morningLabel";
            this.morningLabel.Size = new System.Drawing.Size(284, 20);
            this.morningLabel.TabIndex = 0;
            this.morningLabel.Text = "Good Morning!  |   09 : 18 : 25 AM ";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sidebar.Controls.Add(this.dashboardBtn);
            this.sidebar.Controls.Add(this.masterContainer);
            this.sidebar.Controls.Add(this.siticoneButton1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 105);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(233, 683);
            this.sidebar.TabIndex = 3;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.dashboardBtn.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(94)))));
            this.dashboardBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardBtn.FillColor = System.Drawing.Color.White;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dashboardBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_dashboard_48;
            this.dashboardBtn.ImageOffset = new System.Drawing.Point(-15, 0);
            this.dashboardBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.dashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(233, 48);
            this.dashboardBtn.TabIndex = 5;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // masterContainer
            // 
            this.masterContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.masterContainer.Controls.Add(this.masterBtn);
            this.masterContainer.Controls.Add(this.productBtn);
            this.masterContainer.Controls.Add(this.userBtn);
            this.masterContainer.Controls.Add(this.customerBtn);
            this.masterContainer.Controls.Add(this.supplierBtn);
            this.masterContainer.Controls.Add(this.inventoryBtn);
            this.masterContainer.Location = new System.Drawing.Point(0, 48);
            this.masterContainer.Margin = new System.Windows.Forms.Padding(0);
            this.masterContainer.Name = "masterContainer";
            this.masterContainer.Size = new System.Drawing.Size(233, 48);
            this.masterContainer.TabIndex = 4;
            this.masterContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.masterLayoutPanel_Paint);
            // 
            // customerBtn
            // 
            this.customerBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.customerBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(94)))));
            this.customerBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.customerBtn.CheckedState.Image = global::EscopeWindowsApp.Properties.Resources.icons8_group_48__1_;
            this.customerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerBtn.FillColor = System.Drawing.Color.White;
            this.customerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.customerBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_group_48;
            this.customerBtn.ImageOffset = new System.Drawing.Point(-13, 0);
            this.customerBtn.Location = new System.Drawing.Point(0, 144);
            this.customerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(233, 48);
            this.customerBtn.TabIndex = 6;
            this.customerBtn.Text = "Customer";
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // supplierBtn
            // 
            this.supplierBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.supplierBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(94)))));
            this.supplierBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.supplierBtn.CheckedState.Image = global::EscopeWindowsApp.Properties.Resources.icons8_supplier_50__1_;
            this.supplierBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supplierBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supplierBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supplierBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supplierBtn.FillColor = System.Drawing.Color.White;
            this.supplierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.supplierBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_supplier_50;
            this.supplierBtn.ImageOffset = new System.Drawing.Point(-15, 0);
            this.supplierBtn.Location = new System.Drawing.Point(0, 192);
            this.supplierBtn.Margin = new System.Windows.Forms.Padding(0);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(233, 48);
            this.supplierBtn.TabIndex = 7;
            this.supplierBtn.Text = "Supplier";
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.inventoryBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(94)))));
            this.inventoryBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.inventoryBtn.CheckedState.Image = global::EscopeWindowsApp.Properties.Resources.icons8_inventory_50__1_;
            this.inventoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.inventoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.inventoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.inventoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.inventoryBtn.FillColor = System.Drawing.Color.White;
            this.inventoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.inventoryBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_inventory_50;
            this.inventoryBtn.ImageOffset = new System.Drawing.Point(-15, 0);
            this.inventoryBtn.Location = new System.Drawing.Point(0, 240);
            this.inventoryBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(233, 48);
            this.inventoryBtn.TabIndex = 7;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(0, 96);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(233, 48);
            this.siticoneButton1.TabIndex = 6;
            this.siticoneButton1.Text = "Dashboard";
            // 
            // masterTransition
            // 
            this.masterTransition.Interval = 50;
            this.masterTransition.Tick += new System.EventHandler(this.masterTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // userBtn
            // 
            this.userBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.userBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(94)))));
            this.userBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.userBtn.CheckedState.Image = global::EscopeWindowsApp.Properties.Resources.icons8_user_48__1_;
            this.userBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userBtn.FillColor = System.Drawing.Color.White;
            this.userBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.userBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.userBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_user_48;
            this.userBtn.ImageOffset = new System.Drawing.Point(-22, 0);
            this.userBtn.Location = new System.Drawing.Point(0, 96);
            this.userBtn.Margin = new System.Windows.Forms.Padding(0);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(233, 48);
            this.userBtn.TabIndex = 6;
            this.userBtn.Text = "User";
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // masterBtn
            // 
            this.masterBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.masterBtn.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.masterBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.masterBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(94)))));
            this.masterBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.masterBtn.CheckedState.Image = global::EscopeWindowsApp.Properties.Resources.icons8_shop_50__1_;
            this.masterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.masterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.masterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.masterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.masterBtn.FillColor = System.Drawing.Color.White;
            this.masterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.masterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.masterBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_shop_50;
            this.masterBtn.ImageOffset = new System.Drawing.Point(-23, 0);
            this.masterBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.masterBtn.Location = new System.Drawing.Point(0, 0);
            this.masterBtn.Margin = new System.Windows.Forms.Padding(0);
            this.masterBtn.Name = "masterBtn";
            this.masterBtn.Size = new System.Drawing.Size(233, 48);
            this.masterBtn.TabIndex = 5;
            this.masterBtn.Text = "Master";
            this.masterBtn.Click += new System.EventHandler(this.masterBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.productBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(94)))));
            this.productBtn.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.productBtn.CheckedState.Image = global::EscopeWindowsApp.Properties.Resources.icons8_product_48__1_;
            this.productBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productBtn.FillColor = System.Drawing.Color.White;
            this.productBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.productBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.productBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_product_48;
            this.productBtn.ImageOffset = new System.Drawing.Point(-17, 0);
            this.productBtn.Location = new System.Drawing.Point(0, 48);
            this.productBtn.Margin = new System.Windows.Forms.Padding(0);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(233, 48);
            this.productBtn.TabIndex = 9;
            this.productBtn.Text = "Product";
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // sideBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.sideBarSubPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "sideBarForm";
            this.Text = "Side Bar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sideBarForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.sideBarSubPanel.ResumeLayout(false);
            this.sideBarSubPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideBarProfile)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.masterContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm sideBarlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel sideBarSubPanel;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.FlowLayoutPanel masterContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton masterBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton customerBtn;
        private System.Windows.Forms.Timer masterTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Siticone.Desktop.UI.WinForms.SiticoneButton dashboardBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supplierBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton inventoryBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Label morningLabel;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox sideBarSearchPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sideBarNotifyBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox sideBarProfile;
        private System.Windows.Forms.Label sideBarUserNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sideBarAdminBtn;
        private System.Windows.Forms.Label sideBarAdminUserLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sideBarMinimizeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton productBtn;
    }
}

