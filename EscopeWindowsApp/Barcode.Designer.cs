namespace EscopeWindowsApp
{
    partial class Barcode
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
            this.barcodePictureBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.enterProIDtextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.qtytextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.productNameTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.generateBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.printBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // barcodePictureBox
            // 
            this.barcodePictureBox.ImageRotate = 0F;
            this.barcodePictureBox.Location = new System.Drawing.Point(36, 358);
            this.barcodePictureBox.Name = "barcodePictureBox";
            this.barcodePictureBox.Size = new System.Drawing.Size(540, 280);
            this.barcodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.barcodePictureBox.TabIndex = 0;
            this.barcodePictureBox.TabStop = false;
            this.barcodePictureBox.Click += new System.EventHandler(this.barcodePictureBox_Click);
            // 
            // enterProIDtextBox
            // 
            this.enterProIDtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enterProIDtextBox.DefaultText = "";
            this.enterProIDtextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.enterProIDtextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.enterProIDtextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.enterProIDtextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.enterProIDtextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enterProIDtextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enterProIDtextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enterProIDtextBox.Location = new System.Drawing.Point(36, 133);
            this.enterProIDtextBox.Name = "enterProIDtextBox";
            this.enterProIDtextBox.PasswordChar = '\0';
            this.enterProIDtextBox.PlaceholderText = "Enter ProductID";
            this.enterProIDtextBox.SelectedText = "";
            this.enterProIDtextBox.Size = new System.Drawing.Size(200, 36);
            this.enterProIDtextBox.TabIndex = 1;
            this.enterProIDtextBox.TextChanged += new System.EventHandler(this.enterProIDtextBox_TextChanged_1);
            // 
            // qtytextBox
            // 
            this.qtytextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qtytextBox.DefaultText = "";
            this.qtytextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.qtytextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.qtytextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.qtytextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.qtytextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qtytextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.qtytextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qtytextBox.Location = new System.Drawing.Point(481, 133);
            this.qtytextBox.Name = "qtytextBox";
            this.qtytextBox.PasswordChar = '\0';
            this.qtytextBox.PlaceholderText = "Quantity";
            this.qtytextBox.SelectedText = "";
            this.qtytextBox.Size = new System.Drawing.Size(200, 36);
            this.qtytextBox.TabIndex = 2;
            this.qtytextBox.TextChanged += new System.EventHandler(this.qtytextBox_TextChanged);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productNameTextBox.DefaultText = "";
            this.productNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productNameTextBox.Location = new System.Drawing.Point(261, 133);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.PasswordChar = '\0';
            this.productNameTextBox.PlaceholderText = "";
            this.productNameTextBox.SelectedText = "";
            this.productNameTextBox.Size = new System.Drawing.Size(200, 36);
            this.productNameTextBox.TabIndex = 3;
            this.productNameTextBox.TextChanged += new System.EventHandler(this.productNameTextBox_TextChanged_1);
            // 
            // generateBtn
            // 
            this.generateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.Location = new System.Drawing.Point(618, 457);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(180, 45);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate";
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.printBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(618, 521);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(180, 45);
            this.printBtn.TabIndex = 5;
            this.printBtn.Text = "Print";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 718);
            this.ControlBox = false;
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.qtytextBox);
            this.Controls.Add(this.enterProIDtextBox);
            this.Controls.Add(this.barcodePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1364, 718);
            this.Name = "Barcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode";
            this.Load += new System.EventHandler(this.Barcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox barcodePictureBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox enterProIDtextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox qtytextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox productNameTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton printBtn;
    }
}