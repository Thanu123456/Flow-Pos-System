namespace EscopeWindowsApp
{
    partial class CreateCategory
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
            this.CategoryBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.createProCatLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.createProCatNameLabel = new System.Windows.Forms.Label();
            this.createProCatNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.creteCatLogoChangelabel = new System.Windows.Forms.Label();
            this.creCatSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.creCatCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.createCatCloseBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.creCatLogoBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creCatLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryBorderlessForm
            // 
            this.CategoryBorderlessForm.BorderRadius = 25;
            this.CategoryBorderlessForm.ContainerControl = this;
            this.CategoryBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.CategoryBorderlessForm.TransparentWhileDrag = true;
            // 
            // createProCatLabel
            // 
            this.createProCatLabel.BackColor = System.Drawing.Color.Transparent;
            this.createProCatLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProCatLabel.Location = new System.Drawing.Point(24, 50);
            this.createProCatLabel.Name = "createProCatLabel";
            this.createProCatLabel.Size = new System.Drawing.Size(234, 25);
            this.createProCatLabel.TabIndex = 0;
            this.createProCatLabel.Text = "CREATE PRODUCT CATEGORY";
            // 
            // createProCatNameLabel
            // 
            this.createProCatNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createProCatNameLabel.AutoSize = true;
            this.createProCatNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.createProCatNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProCatNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.createProCatNameLabel.Location = new System.Drawing.Point(21, 98);
            this.createProCatNameLabel.Name = "createProCatNameLabel";
            this.createProCatNameLabel.Size = new System.Drawing.Size(60, 23);
            this.createProCatNameLabel.TabIndex = 26;
            this.createProCatNameLabel.Text = "Name:";
            // 
            // createProCatNameText
            // 
            this.createProCatNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createProCatNameText.BackColor = System.Drawing.Color.Transparent;
            this.createProCatNameText.BorderRadius = 8;
            this.createProCatNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createProCatNameText.DefaultText = "";
            this.createProCatNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createProCatNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createProCatNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createProCatNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createProCatNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createProCatNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProCatNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createProCatNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createProCatNameText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.createProCatNameText.Location = new System.Drawing.Point(25, 128);
            this.createProCatNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createProCatNameText.Name = "createProCatNameText";
            this.createProCatNameText.PasswordChar = '\0';
            this.createProCatNameText.PlaceholderText = "Name";
            this.createProCatNameText.SelectedText = "";
            this.createProCatNameText.Size = new System.Drawing.Size(348, 42);
            this.createProCatNameText.TabIndex = 25;
            // 
            // creteCatLogoChangelabel
            // 
            this.creteCatLogoChangelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creteCatLogoChangelabel.AutoSize = true;
            this.creteCatLogoChangelabel.BackColor = System.Drawing.Color.Transparent;
            this.creteCatLogoChangelabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creteCatLogoChangelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.creteCatLogoChangelabel.Location = new System.Drawing.Point(21, 199);
            this.creteCatLogoChangelabel.Name = "creteCatLogoChangelabel";
            this.creteCatLogoChangelabel.Size = new System.Drawing.Size(113, 23);
            this.creteCatLogoChangelabel.TabIndex = 28;
            this.creteCatLogoChangelabel.Text = "Change Logo:";
            // 
            // creCatSaveBtn
            // 
            this.creCatSaveBtn.Animated = true;
            this.creCatSaveBtn.BorderRadius = 8;
            this.creCatSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.creCatSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.creCatSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.creCatSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.creCatSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.creCatSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.creCatSaveBtn.ForeColor = System.Drawing.Color.White;
            this.creCatSaveBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.creCatSaveBtn.Location = new System.Drawing.Point(174, 363);
            this.creCatSaveBtn.Name = "creCatSaveBtn";
            this.creCatSaveBtn.Size = new System.Drawing.Size(91, 42);
            this.creCatSaveBtn.TabIndex = 59;
            this.creCatSaveBtn.Text = "Save";
            // 
            // creCatCancelBtn
            // 
            this.creCatCancelBtn.Animated = true;
            this.creCatCancelBtn.BorderRadius = 8;
            this.creCatCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.creCatCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.creCatCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.creCatCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.creCatCancelBtn.FillColor = System.Drawing.Color.Red;
            this.creCatCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.creCatCancelBtn.ForeColor = System.Drawing.Color.White;
            this.creCatCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.creCatCancelBtn.Location = new System.Drawing.Point(282, 363);
            this.creCatCancelBtn.Name = "creCatCancelBtn";
            this.creCatCancelBtn.Size = new System.Drawing.Size(91, 42);
            this.creCatCancelBtn.TabIndex = 58;
            this.creCatCancelBtn.Text = "Cancel";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(400, 34);
            this.headerPanel.TabIndex = 60;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.createCatCloseBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(335, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(65, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // createCatCloseBtn
            // 
            this.createCatCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createCatCloseBtn.BorderRadius = 8;
            this.createCatCloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createCatCloseBtn.IconColor = System.Drawing.Color.White;
            this.createCatCloseBtn.Location = new System.Drawing.Point(16, 2);
            this.createCatCloseBtn.Name = "createCatCloseBtn";
            this.createCatCloseBtn.Size = new System.Drawing.Size(28, 26);
            this.createCatCloseBtn.TabIndex = 0;
            // 
            // creCatLogoBox
            // 
            this.creCatLogoBox.BorderRadius = 8;
            this.creCatLogoBox.ImageRotate = 0F;
            this.creCatLogoBox.Location = new System.Drawing.Point(25, 235);
            this.creCatLogoBox.Name = "creCatLogoBox";
            this.creCatLogoBox.Size = new System.Drawing.Size(109, 99);
            this.creCatLogoBox.TabIndex = 29;
            this.creCatLogoBox.TabStop = false;
            // 
            // CreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 440);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.creCatSaveBtn);
            this.Controls.Add(this.creCatCancelBtn);
            this.Controls.Add(this.creCatLogoBox);
            this.Controls.Add(this.creteCatLogoChangelabel);
            this.Controls.Add(this.createProCatNameLabel);
            this.Controls.Add(this.createProCatNameText);
            this.Controls.Add(this.createProCatLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 440);
            this.MinimumSize = new System.Drawing.Size(400, 440);
            this.Name = "CreateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateCategory";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.creCatLogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm CategoryBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel createProCatLabel;
        private System.Windows.Forms.Label createProCatNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createProCatNameText;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox creCatLogoBox;
        private System.Windows.Forms.Label creteCatLogoChangelabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creCatSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creCatCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox createCatCloseBtn;
    }
}