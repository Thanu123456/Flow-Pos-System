namespace EscopeWindowsApp
{
    partial class CodeReaderForm
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
            this.createBrandsCloseBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.codeReaderBorderless = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.dispalyCodePictureBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dispalyCodePictureBox)).BeginInit();
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
            this.headerPanel.Size = new System.Drawing.Size(590, 34);
            this.headerPanel.TabIndex = 70;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.createBrandsCloseBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(529, 4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(65, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // createBrandsCloseBtn
            // 
            this.createBrandsCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createBrandsCloseBtn.BorderRadius = 8;
            this.createBrandsCloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createBrandsCloseBtn.IconColor = System.Drawing.Color.White;
            this.createBrandsCloseBtn.Location = new System.Drawing.Point(16, 2);
            this.createBrandsCloseBtn.Name = "createBrandsCloseBtn";
            this.createBrandsCloseBtn.Size = new System.Drawing.Size(28, 26);
            this.createBrandsCloseBtn.TabIndex = 0;
            // 
            // codeReaderBorderless
            // 
            this.codeReaderBorderless.BorderRadius = 25;
            this.codeReaderBorderless.ContainerControl = this;
            this.codeReaderBorderless.DockIndicatorTransparencyValue = 0.6D;
            this.codeReaderBorderless.TransparentWhileDrag = true;
            // 
            // dispalyCodePictureBox
            // 
            this.dispalyCodePictureBox.ImageRotate = 0F;
            this.dispalyCodePictureBox.Location = new System.Drawing.Point(12, 63);
            this.dispalyCodePictureBox.Name = "dispalyCodePictureBox";
            this.dispalyCodePictureBox.Size = new System.Drawing.Size(566, 288);
            this.dispalyCodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dispalyCodePictureBox.TabIndex = 71;
            this.dispalyCodePictureBox.TabStop = false;
            this.dispalyCodePictureBox.Click += new System.EventHandler(this.dispalyCodePictureBox_Click);
            // 
            // CodeReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 393);
            this.Controls.Add(this.dispalyCodePictureBox);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CodeReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeReaderForm";
            this.Load += new System.EventHandler(this.CodeReaderForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dispalyCodePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox createBrandsCloseBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm codeReaderBorderless;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox dispalyCodePictureBox;
    }
}