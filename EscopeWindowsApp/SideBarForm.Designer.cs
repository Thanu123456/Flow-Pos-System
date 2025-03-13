namespace EscopeWindowsApp
{
    partial class SideBarForm
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
            this.manuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.dashboardBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.manuLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.unitsBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.manuBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sidebarBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sideBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.manuLayoutPanel.SuspendLayout();
            this.sideBarPanel.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // manuTransition
            // 
            this.manuTransition.Interval = 10;
            this.manuTransition.Tick += new System.EventHandler(this.manuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(0, 135);
            this.siticoneButton2.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(218, 45);
            this.siticoneButton2.TabIndex = 2;
            this.siticoneButton2.Text = "Settings";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 90);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(218, 45);
            this.dashboardBtn.TabIndex = 3;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // manuLayoutPanel
            // 
            this.manuLayoutPanel.BackColor = System.Drawing.Color.Silver;
            this.manuLayoutPanel.Controls.Add(this.manuBtn);
            this.manuLayoutPanel.Controls.Add(this.unitsBtn);
            this.manuLayoutPanel.Controls.Add(this.siticoneButton3);
            this.manuLayoutPanel.Controls.Add(this.siticoneButton4);
            this.manuLayoutPanel.Location = new System.Drawing.Point(0, 45);
            this.manuLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.manuLayoutPanel.Name = "manuLayoutPanel";
            this.manuLayoutPanel.Size = new System.Drawing.Size(218, 45);
            this.manuLayoutPanel.TabIndex = 2;
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.Location = new System.Drawing.Point(0, 135);
            this.siticoneButton4.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.Size = new System.Drawing.Size(218, 45);
            this.siticoneButton4.TabIndex = 4;
            this.siticoneButton4.Text = "Settings";
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.Location = new System.Drawing.Point(0, 90);
            this.siticoneButton3.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.Size = new System.Drawing.Size(218, 45);
            this.siticoneButton3.TabIndex = 3;
            this.siticoneButton3.Text = "Settings";
            // 
            // unitsBtn
            // 
            this.unitsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.unitsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.unitsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.unitsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.unitsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsBtn.ForeColor = System.Drawing.Color.White;
            this.unitsBtn.Location = new System.Drawing.Point(0, 45);
            this.unitsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.unitsBtn.Name = "unitsBtn";
            this.unitsBtn.Size = new System.Drawing.Size(218, 45);
            this.unitsBtn.TabIndex = 5;
            this.unitsBtn.Text = "Settings";
            this.unitsBtn.Click += new System.EventHandler(this.siticoneButton6_Click);
            // 
            // manuBtn
            // 
            this.manuBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manuBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manuBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manuBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manuBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.manuBtn.ForeColor = System.Drawing.Color.White;
            this.manuBtn.Location = new System.Drawing.Point(0, 0);
            this.manuBtn.Margin = new System.Windows.Forms.Padding(0);
            this.manuBtn.Name = "manuBtn";
            this.manuBtn.Size = new System.Drawing.Size(218, 45);
            this.manuBtn.TabIndex = 5;
            this.manuBtn.Text = "Manu";
            this.manuBtn.Click += new System.EventHandler(this.manuBtn_Click);
            // 
            // sidebarBtn
            // 
            this.sidebarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sidebarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sidebarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sidebarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sidebarBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.sidebarBtn.ForeColor = System.Drawing.Color.White;
            this.sidebarBtn.Location = new System.Drawing.Point(0, 0);
            this.sidebarBtn.Margin = new System.Windows.Forms.Padding(0);
            this.sidebarBtn.Name = "sidebarBtn";
            this.sidebarBtn.Size = new System.Drawing.Size(218, 45);
            this.sidebarBtn.TabIndex = 0;
            this.sidebarBtn.Text = "Side Button";
            this.sidebarBtn.Click += new System.EventHandler(this.sidebarBtn_Click);
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.Silver;
            this.sideBarPanel.Controls.Add(this.sidebarBtn);
            this.sideBarPanel.Controls.Add(this.manuLayoutPanel);
            this.sideBarPanel.Controls.Add(this.dashboardBtn);
            this.sideBarPanel.Controls.Add(this.siticoneButton2);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 34);
            this.sideBarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(218, 754);
            this.sideBarPanel.TabIndex = 4;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 8;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Firebrick;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1348, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(26, 26);
            this.siticoneControlBox1.TabIndex = 2;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.Controls.Add(this.siticoneControlBox3);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox2);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.FillColor = System.Drawing.Color.White;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(1386, 34);
            this.siticonePanel1.TabIndex = 0;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 8;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Gold;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(1316, 4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(26, 26);
            this.siticoneControlBox2.TabIndex = 3;
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.BorderRadius = 8;
            this.siticoneControlBox3.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siticoneControlBox3.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox3.Location = new System.Drawing.Point(1284, 4);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.Size = new System.Drawing.Size(26, 26);
            this.siticoneControlBox3.TabIndex = 4;
            // 
            // SideBarForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.sideBarPanel);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "SideBarForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SideBarForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SideBarForm_Load);
            this.manuLayoutPanel.ResumeLayout(false);
            this.sideBarPanel.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer manuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton dashboardBtn;
        private System.Windows.Forms.FlowLayoutPanel manuLayoutPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton manuBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton unitsBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sidebarBtn;
        private System.Windows.Forms.FlowLayoutPanel sideBarPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
    }
}