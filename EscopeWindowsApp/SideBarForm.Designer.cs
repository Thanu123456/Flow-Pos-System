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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.sidebarBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.manuLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.manuBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton6 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.manuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.dashboardBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sideBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.siticonePanel1.SuspendLayout();
            this.manuLayoutPanel.SuspendLayout();
            this.sideBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(639, 30);
            this.siticonePanel1.TabIndex = 0;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 8;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Firebrick;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(594, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 2;
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
            // manuLayoutPanel
            // 
            this.manuLayoutPanel.BackColor = System.Drawing.Color.Silver;
            this.manuLayoutPanel.Controls.Add(this.manuBtn);
            this.manuLayoutPanel.Controls.Add(this.siticoneButton6);
            this.manuLayoutPanel.Controls.Add(this.siticoneButton3);
            this.manuLayoutPanel.Controls.Add(this.siticoneButton4);
            this.manuLayoutPanel.Location = new System.Drawing.Point(0, 45);
            this.manuLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.manuLayoutPanel.Name = "manuLayoutPanel";
            this.manuLayoutPanel.Size = new System.Drawing.Size(218, 45);
            this.manuLayoutPanel.TabIndex = 2;
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
            // siticoneButton6
            // 
            this.siticoneButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton6.ForeColor = System.Drawing.Color.White;
            this.siticoneButton6.Location = new System.Drawing.Point(0, 45);
            this.siticoneButton6.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneButton6.Name = "siticoneButton6";
            this.siticoneButton6.Size = new System.Drawing.Size(218, 45);
            this.siticoneButton6.TabIndex = 5;
            this.siticoneButton6.Text = "Settings";
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
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.Silver;
            this.sideBarPanel.Controls.Add(this.sidebarBtn);
            this.sideBarPanel.Controls.Add(this.manuLayoutPanel);
            this.sideBarPanel.Controls.Add(this.dashboardBtn);
            this.sideBarPanel.Controls.Add(this.siticoneButton2);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 30);
            this.sideBarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(218, 420);
            this.sideBarPanel.TabIndex = 4;
            // 
            // SideBarForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.sideBarPanel);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "SideBarForm";
            this.Text = "SideBarForm";
            this.Load += new System.EventHandler(this.SideBarForm_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.manuLayoutPanel.ResumeLayout(false);
            this.sideBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sidebarBtn;
        private System.Windows.Forms.FlowLayoutPanel manuLayoutPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton manuBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton6;
        private System.Windows.Forms.Timer manuTransition;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Timer sidebarTransition;
        private Siticone.Desktop.UI.WinForms.SiticoneButton dashboardBtn;
        private System.Windows.Forms.FlowLayoutPanel sideBarPanel;
    }
}