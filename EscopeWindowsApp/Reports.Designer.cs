namespace EscopeWindowsApp
{
    partial class Reports
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
            this.expReportBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleReportBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.stockReportBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // expReportBtn
            // 
            this.expReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expReportBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expReportBtn.ForeColor = System.Drawing.Color.White;
            this.expReportBtn.Location = new System.Drawing.Point(29, 32);
            this.expReportBtn.Name = "expReportBtn";
            this.expReportBtn.Size = new System.Drawing.Size(259, 129);
            this.expReportBtn.TabIndex = 0;
            this.expReportBtn.Text = "Expences Report";
            this.expReportBtn.Click += new System.EventHandler(this.expReportBtn_Click);
            // 
            // saleReportBtn
            // 
            this.saleReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleReportBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saleReportBtn.ForeColor = System.Drawing.Color.White;
            this.saleReportBtn.Location = new System.Drawing.Point(333, 32);
            this.saleReportBtn.Name = "saleReportBtn";
            this.saleReportBtn.Size = new System.Drawing.Size(259, 129);
            this.saleReportBtn.TabIndex = 1;
            this.saleReportBtn.Text = "Sales Report";
            this.saleReportBtn.Click += new System.EventHandler(this.saleReportBtn_Click);
            // 
            // stockReportBtn
            // 
            this.stockReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stockReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stockReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stockReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stockReportBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stockReportBtn.ForeColor = System.Drawing.Color.White;
            this.stockReportBtn.Location = new System.Drawing.Point(333, 208);
            this.stockReportBtn.Name = "stockReportBtn";
            this.stockReportBtn.Size = new System.Drawing.Size(259, 129);
            this.stockReportBtn.TabIndex = 2;
            this.stockReportBtn.Text = "Stock Report";
            this.stockReportBtn.Click += new System.EventHandler(this.stockReportBtn_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stockReportBtn);
            this.Controls.Add(this.saleReportBtn);
            this.Controls.Add(this.expReportBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton expReportBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleReportBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton stockReportBtn;
    }
}