namespace EscopeWindowsApp
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.loadingBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.loadingPictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.loadingPictureBox2 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.loadingPictureBox3 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.loadingFormLabel1 = new System.Windows.Forms.Label();
            this.loadingFormLabel2 = new System.Windows.Forms.Label();
            this.loadingDetailsLabel = new System.Windows.Forms.Label();
            this.loadingProgressBar = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.loadingPictureBoxLogo = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingBorderlessForm
            // 
            this.loadingBorderlessForm.BorderRadius = 25;
            this.loadingBorderlessForm.ContainerControl = this;
            this.loadingBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.loadingBorderlessForm.TransparentWhileDrag = true;
            // 
            // loadingPictureBox1
            // 
            this.loadingPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.loadingPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("loadingPictureBox1.Image")));
            this.loadingPictureBox1.ImageRotate = 0F;
            this.loadingPictureBox1.Location = new System.Drawing.Point(275, 37);
            this.loadingPictureBox1.Name = "loadingPictureBox1";
            this.loadingPictureBox1.Size = new System.Drawing.Size(530, 412);
            this.loadingPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingPictureBox1.TabIndex = 0;
            this.loadingPictureBox1.TabStop = false;
            this.loadingPictureBox1.UseTransparentBackground = true;
            // 
            // loadingPictureBox2
            // 
            this.loadingPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.loadingPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("loadingPictureBox2.Image")));
            this.loadingPictureBox2.ImageRotate = 0F;
            this.loadingPictureBox2.Location = new System.Drawing.Point(275, 12);
            this.loadingPictureBox2.Name = "loadingPictureBox2";
            this.loadingPictureBox2.Size = new System.Drawing.Size(530, 449);
            this.loadingPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingPictureBox2.TabIndex = 1;
            this.loadingPictureBox2.TabStop = false;
            this.loadingPictureBox2.UseTransparentBackground = true;
            this.loadingPictureBox2.Click += new System.EventHandler(this.loadingPictureBox2_Click);
            // 
            // loadingPictureBox3
            // 
            this.loadingPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.loadingPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("loadingPictureBox3.Image")));
            this.loadingPictureBox3.ImageRotate = 0F;
            this.loadingPictureBox3.Location = new System.Drawing.Point(35, 128);
            this.loadingPictureBox3.Name = "loadingPictureBox3";
            this.loadingPictureBox3.Size = new System.Drawing.Size(376, 296);
            this.loadingPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingPictureBox3.TabIndex = 2;
            this.loadingPictureBox3.TabStop = false;
            this.loadingPictureBox3.UseTransparentBackground = true;
            // 
            // loadingFormLabel1
            // 
            this.loadingFormLabel1.AutoSize = true;
            this.loadingFormLabel1.BackColor = System.Drawing.Color.Transparent;
            this.loadingFormLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingFormLabel1.Location = new System.Drawing.Point(28, 37);
            this.loadingFormLabel1.Name = "loadingFormLabel1";
            this.loadingFormLabel1.Size = new System.Drawing.Size(383, 43);
            this.loadingFormLabel1.TabIndex = 3;
            this.loadingFormLabel1.Text = "Welcome To FlowPOS";
            // 
            // loadingFormLabel2
            // 
            this.loadingFormLabel2.AutoSize = true;
            this.loadingFormLabel2.BackColor = System.Drawing.Color.Transparent;
            this.loadingFormLabel2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingFormLabel2.Location = new System.Drawing.Point(34, 83);
            this.loadingFormLabel2.Name = "loadingFormLabel2";
            this.loadingFormLabel2.Size = new System.Drawing.Size(353, 24);
            this.loadingFormLabel2.TabIndex = 4;
            this.loadingFormLabel2.Text = "Inventory Management System by Escope ";
            // 
            // loadingDetailsLabel
            // 
            this.loadingDetailsLabel.AutoSize = true;
            this.loadingDetailsLabel.BackColor = System.Drawing.Color.White;
            this.loadingDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingDetailsLabel.Location = new System.Drawing.Point(59, 143);
            this.loadingDetailsLabel.Name = "loadingDetailsLabel";
            this.loadingDetailsLabel.Size = new System.Drawing.Size(311, 208);
            this.loadingDetailsLabel.TabIndex = 5;
            this.loadingDetailsLabel.Text = resources.GetString("loadingDetailsLabel.Text");
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.BackColor = System.Drawing.Color.White;
            this.loadingProgressBar.BorderRadius = 5;
            this.loadingProgressBar.Location = new System.Drawing.Point(62, 377);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(94)))));
            this.loadingProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(94)))));
            this.loadingProgressBar.Size = new System.Drawing.Size(308, 14);
            this.loadingProgressBar.TabIndex = 6;
            this.loadingProgressBar.Text = "Loading Bar";
            this.loadingProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.loadingProgressBar.ValueChanged += new System.EventHandler(this.loadingProgressBar_ValueChanged);
            // 
            // loadingPictureBoxLogo
            // 
            this.loadingPictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.loadingPictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("loadingPictureBoxLogo.Image")));
            this.loadingPictureBoxLogo.ImageRotate = 0F;
            this.loadingPictureBoxLogo.Location = new System.Drawing.Point(631, 22);
            this.loadingPictureBoxLogo.Name = "loadingPictureBoxLogo";
            this.loadingPictureBoxLogo.Size = new System.Drawing.Size(143, 42);
            this.loadingPictureBoxLogo.TabIndex = 7;
            this.loadingPictureBoxLogo.TabStop = false;
            this.loadingPictureBoxLogo.UseTransparentBackground = true;
            // 
            // loadingTimer
            // 
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadingPictureBoxLogo);
            this.Controls.Add(this.loadingProgressBar);
            this.Controls.Add(this.loadingDetailsLabel);
            this.Controls.Add(this.loadingFormLabel2);
            this.Controls.Add(this.loadingFormLabel1);
            this.Controls.Add(this.loadingPictureBox3);
            this.Controls.Add(this.loadingPictureBox2);
            this.Controls.Add(this.loadingPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm loadingBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox loadingPictureBox2;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox loadingPictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox loadingPictureBox3;
        private System.Windows.Forms.Label loadingDetailsLabel;
        private System.Windows.Forms.Label loadingFormLabel2;
        private System.Windows.Forms.Label loadingFormLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneProgressBar loadingProgressBar;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox loadingPictureBoxLogo;
        private System.Windows.Forms.Timer loadingTimer;
    }
}