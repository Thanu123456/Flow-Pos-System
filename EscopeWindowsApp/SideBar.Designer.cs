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
            this.maximumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.sideBarSubPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.logoBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.dashboardBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.masterContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.masterBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.customerBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supplierBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.inventoryBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.productBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.masterTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
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
            this.headerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1920, 34);
            this.headerPanel.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.minimumBtn);
            this.controlPanel.Controls.Add(this.maximumBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.Location = new System.Drawing.Point(655, 1);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(142, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // minimumBtn
            // 
            this.minimumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumBtn.BorderRadius = 8;
            this.minimumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimumBtn.FillColor = System.Drawing.Color.Silver;
            this.minimumBtn.IconColor = System.Drawing.Color.White;
            this.minimumBtn.Location = new System.Drawing.Point(4, 3);
            this.minimumBtn.Name = "minimumBtn";
            this.minimumBtn.Size = new System.Drawing.Size(41, 25);
            this.minimumBtn.TabIndex = 2;
            // 
            // maximumBtn
            // 
            this.maximumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximumBtn.BorderRadius = 8;
            this.maximumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maximumBtn.FillColor = System.Drawing.Color.Silver;
            this.maximumBtn.IconColor = System.Drawing.Color.White;
            this.maximumBtn.Location = new System.Drawing.Point(51, 2);
            this.maximumBtn.Name = "maximumBtn";
            this.maximumBtn.Size = new System.Drawing.Size(41, 26);
            this.maximumBtn.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.FillColor = System.Drawing.Color.Silver;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(98, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(41, 26);
            this.closeBtn.TabIndex = 0;
            // 
            // sideBarSubPanel
            // 
            this.sideBarSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideBarSubPanel.FillColor = System.Drawing.Color.LightGray;
            this.sideBarSubPanel.Location = new System.Drawing.Point(0, 34);
            this.sideBarSubPanel.Name = "sideBarSubPanel";
            this.sideBarSubPanel.Size = new System.Drawing.Size(1920, 63);
            this.sideBarSubPanel.TabIndex = 2;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sidebar.Controls.Add(this.logoBtn);
            this.sidebar.Controls.Add(this.dashboardBtn);
            this.sidebar.Controls.Add(this.masterContainer);
            this.sidebar.Controls.Add(this.siticoneButton1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 97);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(211, 983);
            this.sidebar.TabIndex = 3;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // logoBtn
            // 
            this.logoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoBtn.ForeColor = System.Drawing.Color.White;
            this.logoBtn.Location = new System.Drawing.Point(0, 0);
            this.logoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.logoBtn.Name = "logoBtn";
            this.logoBtn.Size = new System.Drawing.Size(211, 48);
            this.logoBtn.TabIndex = 4;
            this.logoBtn.Text = "LOGO";
            this.logoBtn.Click += new System.EventHandler(this.logoBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.dashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 48);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(211, 48);
            this.dashboardBtn.TabIndex = 5;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // masterContainer
            // 
            this.masterContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.masterContainer.Controls.Add(this.masterBtn);
            this.masterContainer.Controls.Add(this.userBtn);
            this.masterContainer.Controls.Add(this.customerBtn);
            this.masterContainer.Controls.Add(this.supplierBtn);
            this.masterContainer.Controls.Add(this.inventoryBtn);
            this.masterContainer.Controls.Add(this.productBtn);
            this.masterContainer.Location = new System.Drawing.Point(0, 96);
            this.masterContainer.Margin = new System.Windows.Forms.Padding(0);
            this.masterContainer.Name = "masterContainer";
            this.masterContainer.Size = new System.Drawing.Size(211, 48);
            this.masterContainer.TabIndex = 4;
            this.masterContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.masterLayoutPanel_Paint);
            // 
            // masterBtn
            // 
            this.masterBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.masterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.masterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.masterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.masterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.masterBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.masterBtn.ForeColor = System.Drawing.Color.White;
            this.masterBtn.Location = new System.Drawing.Point(0, 0);
            this.masterBtn.Margin = new System.Windows.Forms.Padding(0);
            this.masterBtn.Name = "masterBtn";
            this.masterBtn.Size = new System.Drawing.Size(211, 48);
            this.masterBtn.TabIndex = 5;
            this.masterBtn.Text = "Master";
            this.masterBtn.Click += new System.EventHandler(this.masterBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.userBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.userBtn.ForeColor = System.Drawing.Color.White;
            this.userBtn.Location = new System.Drawing.Point(0, 48);
            this.userBtn.Margin = new System.Windows.Forms.Padding(0);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(211, 48);
            this.userBtn.TabIndex = 6;
            this.userBtn.Text = "User";
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.customerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.customerBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.customerBtn.ForeColor = System.Drawing.Color.White;
            this.customerBtn.Location = new System.Drawing.Point(0, 96);
            this.customerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(211, 48);
            this.customerBtn.TabIndex = 6;
            this.customerBtn.Text = "Customer";
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // supplierBtn
            // 
            this.supplierBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.supplierBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supplierBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supplierBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supplierBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supplierBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.supplierBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.supplierBtn.ForeColor = System.Drawing.Color.White;
            this.supplierBtn.Location = new System.Drawing.Point(0, 144);
            this.supplierBtn.Margin = new System.Windows.Forms.Padding(0);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(211, 48);
            this.supplierBtn.TabIndex = 7;
            this.supplierBtn.Text = "Supplier";
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.inventoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.inventoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.inventoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.inventoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.inventoryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inventoryBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.inventoryBtn.ForeColor = System.Drawing.Color.White;
            this.inventoryBtn.Location = new System.Drawing.Point(0, 192);
            this.inventoryBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(211, 48);
            this.inventoryBtn.TabIndex = 7;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.productBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.productBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.productBtn.ForeColor = System.Drawing.Color.White;
            this.productBtn.Location = new System.Drawing.Point(0, 240);
            this.productBtn.Margin = new System.Windows.Forms.Padding(0);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(211, 48);
            this.productBtn.TabIndex = 8;
            this.productBtn.Text = "Products";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(0, 144);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(211, 48);
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
            // sideBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.sideBarSubPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "sideBarForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sideBarForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.masterContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm sideBarlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox maximumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel sideBarSubPanel;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton logoBtn;
        private System.Windows.Forms.FlowLayoutPanel masterContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton masterBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton customerBtn;
        private System.Windows.Forms.Timer masterTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Siticone.Desktop.UI.WinForms.SiticoneButton dashboardBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supplierBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton productBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton inventoryBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
    }
}

