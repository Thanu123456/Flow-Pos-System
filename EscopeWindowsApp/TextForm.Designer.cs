namespace EscopeWindowsApp
{
    partial class TextForm
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
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.proPanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.productLabel1 = new System.Windows.Forms.Label();
            this.productPictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.proPanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.productLabel2 = new System.Windows.Forms.Label();
            this.productPictureBox2 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.proPanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.productLabel3 = new System.Windows.Forms.Label();
            this.productPictureBox3 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.productSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.productBtnPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.productPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.productNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.proPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox1)).BeginInit();
            this.proPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox2)).BeginInit();
            this.proPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox3)).BeginInit();
            this.productBtnPanel.SuspendLayout();
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
            this.headerPanel.Size = new System.Drawing.Size(908, 34);
            this.headerPanel.TabIndex = 33;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(816, 2);
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
            // proPanel1
            // 
            this.proPanel1.BorderRadius = 8;
            this.proPanel1.Controls.Add(this.productLabel1);
            this.proPanel1.Controls.Add(this.productPictureBox1);
            this.proPanel1.Location = new System.Drawing.Point(33, 131);
            this.proPanel1.Name = "proPanel1";
            this.proPanel1.Size = new System.Drawing.Size(208, 177);
            this.proPanel1.TabIndex = 34;
            // 
            // productLabel1
            // 
            this.productLabel1.AutoSize = true;
            this.productLabel1.Location = new System.Drawing.Point(79, 138);
            this.productLabel1.Name = "productLabel1";
            this.productLabel1.Size = new System.Drawing.Size(35, 13);
            this.productLabel1.TabIndex = 1;
            this.productLabel1.Text = "label1";
            this.productLabel1.Click += new System.EventHandler(this.productLabel1_Click);
            // 
            // productPictureBox1
            // 
            this.productPictureBox1.ImageRotate = 0F;
            this.productPictureBox1.Location = new System.Drawing.Point(35, 14);
            this.productPictureBox1.Name = "productPictureBox1";
            this.productPictureBox1.Size = new System.Drawing.Size(131, 106);
            this.productPictureBox1.TabIndex = 0;
            this.productPictureBox1.TabStop = false;
            this.productPictureBox1.Click += new System.EventHandler(this.productPictureBox1_Click);
            // 
            // proPanel2
            // 
            this.proPanel2.BorderRadius = 8;
            this.proPanel2.Controls.Add(this.productLabel2);
            this.proPanel2.Controls.Add(this.productPictureBox2);
            this.proPanel2.Location = new System.Drawing.Point(342, 131);
            this.proPanel2.Name = "proPanel2";
            this.proPanel2.Size = new System.Drawing.Size(208, 177);
            this.proPanel2.TabIndex = 35;
            this.proPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.proPanel2_Paint);
            // 
            // productLabel2
            // 
            this.productLabel2.AutoSize = true;
            this.productLabel2.Location = new System.Drawing.Point(79, 138);
            this.productLabel2.Name = "productLabel2";
            this.productLabel2.Size = new System.Drawing.Size(75, 13);
            this.productLabel2.TabIndex = 1;
            this.productLabel2.Text = "productLabel1";
            this.productLabel2.Click += new System.EventHandler(this.productLabel2_Click);
            // 
            // productPictureBox2
            // 
            this.productPictureBox2.ImageRotate = 0F;
            this.productPictureBox2.Location = new System.Drawing.Point(35, 14);
            this.productPictureBox2.Name = "productPictureBox2";
            this.productPictureBox2.Size = new System.Drawing.Size(131, 106);
            this.productPictureBox2.TabIndex = 0;
            this.productPictureBox2.TabStop = false;
            this.productPictureBox2.Click += new System.EventHandler(this.productPictureBox2_Click);
            // 
            // proPanel3
            // 
            this.proPanel3.BorderRadius = 8;
            this.proPanel3.Controls.Add(this.productLabel3);
            this.proPanel3.Controls.Add(this.productPictureBox3);
            this.proPanel3.Location = new System.Drawing.Point(669, 131);
            this.proPanel3.Name = "proPanel3";
            this.proPanel3.Size = new System.Drawing.Size(208, 177);
            this.proPanel3.TabIndex = 36;
            // 
            // productLabel3
            // 
            this.productLabel3.AutoSize = true;
            this.productLabel3.Location = new System.Drawing.Point(79, 138);
            this.productLabel3.Name = "productLabel3";
            this.productLabel3.Size = new System.Drawing.Size(35, 13);
            this.productLabel3.TabIndex = 1;
            this.productLabel3.Text = "label1";
            this.productLabel3.Click += new System.EventHandler(this.productLabel3_Click);
            // 
            // productPictureBox3
            // 
            this.productPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.productPictureBox3.ImageRotate = 0F;
            this.productPictureBox3.Location = new System.Drawing.Point(35, 14);
            this.productPictureBox3.Name = "productPictureBox3";
            this.productPictureBox3.Size = new System.Drawing.Size(131, 106);
            this.productPictureBox3.TabIndex = 0;
            this.productPictureBox3.TabStop = false;
            this.productPictureBox3.UseTransparentBackground = true;
            this.productPictureBox3.Click += new System.EventHandler(this.productPictureBox3_Click);
            // 
            // productSearchText
            // 
            this.productSearchText.BorderColor = System.Drawing.Color.Silver;
            this.productSearchText.BorderRadius = 8;
            this.productSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productSearchText.DefaultText = "";
            this.productSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.productSearchText.ForeColor = System.Drawing.Color.Gray;
            this.productSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.productSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.productSearchText.IconRightOffset = new System.Drawing.Point(10, 0);
            this.productSearchText.Location = new System.Drawing.Point(33, 42);
            this.productSearchText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.productSearchText.Name = "productSearchText";
            this.productSearchText.PasswordChar = '\0';
            this.productSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.productSearchText.PlaceholderText = "Search Return Number";
            this.productSearchText.SelectedText = "";
            this.productSearchText.Size = new System.Drawing.Size(310, 42);
            this.productSearchText.TabIndex = 37;
            this.productSearchText.TextChanged += new System.EventHandler(this.productSearchText_TextChanged);
            // 
            // productBtnPanel
            // 
            this.productBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productBtnPanel.BorderRadius = 8;
            this.productBtnPanel.Controls.Add(this.productPrevBtn);
            this.productBtnPanel.Controls.Add(this.productNextBtn);
            this.productBtnPanel.Location = new System.Drawing.Point(723, 383);
            this.productBtnPanel.Name = "productBtnPanel";
            this.productBtnPanel.Size = new System.Drawing.Size(154, 42);
            this.productBtnPanel.TabIndex = 38;
            // 
            // productPrevBtn
            // 
            this.productPrevBtn.BorderRadius = 6;
            this.productPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productPrevBtn.FillColor = System.Drawing.SystemColors.Control;
            this.productPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productPrevBtn.ForeColor = System.Drawing.Color.White;
            this.productPrevBtn.Image = global::EscopeWindowsApp.Properties.Resources.backBtn;
            this.productPrevBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.productPrevBtn.Location = new System.Drawing.Point(45, 8);
            this.productPrevBtn.Name = "productPrevBtn";
            this.productPrevBtn.Size = new System.Drawing.Size(26, 26);
            this.productPrevBtn.TabIndex = 11;
            this.productPrevBtn.Click += new System.EventHandler(this.productPrevBtn_Click);
            // 
            // productNextBtn
            // 
            this.productNextBtn.BorderRadius = 6;
            this.productNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productNextBtn.FillColor = System.Drawing.SystemColors.Control;
            this.productNextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productNextBtn.ForeColor = System.Drawing.Color.White;
            this.productNextBtn.Image = global::EscopeWindowsApp.Properties.Resources.nextBtn;
            this.productNextBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.productNextBtn.Location = new System.Drawing.Point(87, 8);
            this.productNextBtn.Name = "productNextBtn";
            this.productNextBtn.Size = new System.Drawing.Size(26, 26);
            this.productNextBtn.TabIndex = 9;
            this.productNextBtn.Click += new System.EventHandler(this.productNextBtn_Click);
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 449);
            this.Controls.Add(this.productBtnPanel);
            this.Controls.Add(this.productSearchText);
            this.Controls.Add(this.proPanel3);
            this.Controls.Add(this.proPanel2);
            this.Controls.Add(this.proPanel1);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(908, 449);
            this.MinimumSize = new System.Drawing.Size(908, 449);
            this.Name = "TextForm";
            this.Text = "TextForm";
            this.Load += new System.EventHandler(this.TextForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.proPanel1.ResumeLayout(false);
            this.proPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox1)).EndInit();
            this.proPanel2.ResumeLayout(false);
            this.proPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox2)).EndInit();
            this.proPanel3.ResumeLayout(false);
            this.proPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox3)).EndInit();
            this.productBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel proPanel1;
        private System.Windows.Forms.Label productLabel1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox productPictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel proPanel2;
        private System.Windows.Forms.Label productLabel2;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox productPictureBox2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel proPanel3;
        private System.Windows.Forms.Label productLabel3;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox productPictureBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox productSearchText;
        private Siticone.Desktop.UI.WinForms.SiticonePanel productBtnPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton productPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton productNextBtn;
    }
}