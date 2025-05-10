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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCategory));
            this.creCatBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.createBrandsCloseBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.creCategorySaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.creCategoryCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.creCategoryLogoBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.creteCategoryLogoChangelabel = new System.Windows.Forms.Label();
            this.createCategoryNameLabel = new System.Windows.Forms.Label();
            this.createCategoryNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createCategoryLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.creCategoryImgUploadBtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creCategoryLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // creCatBorderlessForm
            // 
            this.creCatBorderlessForm.BorderRadius = 25;
            this.creCatBorderlessForm.ContainerControl = this;
            this.creCatBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.creCatBorderlessForm.TransparentWhileDrag = true;
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
            this.headerPanel.TabIndex = 69;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.createBrandsCloseBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(335, 2);
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
            // creCategorySaveBtn
            // 
            this.creCategorySaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creCategorySaveBtn.Animated = true;
            this.creCategorySaveBtn.BorderRadius = 8;
            this.creCategorySaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.creCategorySaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.creCategorySaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.creCategorySaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.creCategorySaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.creCategorySaveBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creCategorySaveBtn.ForeColor = System.Drawing.Color.White;
            this.creCategorySaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.creCategorySaveBtn.Location = new System.Drawing.Point(170, 364);
            this.creCategorySaveBtn.Name = "creCategorySaveBtn";
            this.creCategorySaveBtn.Size = new System.Drawing.Size(95, 45);
            this.creCategorySaveBtn.TabIndex = 76;
            this.creCategorySaveBtn.Text = "Save";
            this.creCategorySaveBtn.Click += new System.EventHandler(this.creCategorySaveBtn_Click);
            // 
            // creCategoryCancelBtn
            // 
            this.creCategoryCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creCategoryCancelBtn.Animated = true;
            this.creCategoryCancelBtn.BorderRadius = 8;
            this.creCategoryCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.creCategoryCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.creCategoryCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.creCategoryCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.creCategoryCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.creCategoryCancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creCategoryCancelBtn.ForeColor = System.Drawing.Color.White;
            this.creCategoryCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.creCategoryCancelBtn.Location = new System.Drawing.Point(278, 364);
            this.creCategoryCancelBtn.Name = "creCategoryCancelBtn";
            this.creCategoryCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.creCategoryCancelBtn.TabIndex = 75;
            this.creCategoryCancelBtn.Text = "Cancel";
            this.creCategoryCancelBtn.Click += new System.EventHandler(this.creCategoryCancelBtn_Click);
            // 
            // creCategoryLogoBox
            // 
            this.creCategoryLogoBox.BorderRadius = 8;
            this.creCategoryLogoBox.ImageRotate = 0F;
            this.creCategoryLogoBox.Location = new System.Drawing.Point(25, 235);
            this.creCategoryLogoBox.Name = "creCategoryLogoBox";
            this.creCategoryLogoBox.Size = new System.Drawing.Size(106, 106);
            this.creCategoryLogoBox.TabIndex = 74;
            this.creCategoryLogoBox.TabStop = false;
            this.creCategoryLogoBox.Click += new System.EventHandler(this.creCategoryLogoBox_Click);
            // 
            // creteCategoryLogoChangelabel
            // 
            this.creteCategoryLogoChangelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creteCategoryLogoChangelabel.AutoSize = true;
            this.creteCategoryLogoChangelabel.BackColor = System.Drawing.Color.Transparent;
            this.creteCategoryLogoChangelabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creteCategoryLogoChangelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.creteCategoryLogoChangelabel.Location = new System.Drawing.Point(21, 199);
            this.creteCategoryLogoChangelabel.Name = "creteCategoryLogoChangelabel";
            this.creteCategoryLogoChangelabel.Size = new System.Drawing.Size(113, 23);
            this.creteCategoryLogoChangelabel.TabIndex = 73;
            this.creteCategoryLogoChangelabel.Text = "Change Logo:";
            // 
            // createCategoryNameLabel
            // 
            this.createCategoryNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createCategoryNameLabel.AutoSize = true;
            this.createCategoryNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.createCategoryNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCategoryNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.createCategoryNameLabel.Location = new System.Drawing.Point(21, 98);
            this.createCategoryNameLabel.Name = "createCategoryNameLabel";
            this.createCategoryNameLabel.Size = new System.Drawing.Size(60, 23);
            this.createCategoryNameLabel.TabIndex = 72;
            this.createCategoryNameLabel.Text = "Name:";
            // 
            // createCategoryNameText
            // 
            this.createCategoryNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createCategoryNameText.BackColor = System.Drawing.Color.Transparent;
            this.createCategoryNameText.BorderRadius = 8;
            this.createCategoryNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createCategoryNameText.DefaultText = "";
            this.createCategoryNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createCategoryNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createCategoryNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createCategoryNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createCategoryNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createCategoryNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCategoryNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createCategoryNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createCategoryNameText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.createCategoryNameText.Location = new System.Drawing.Point(25, 128);
            this.createCategoryNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createCategoryNameText.Name = "createCategoryNameText";
            this.createCategoryNameText.PasswordChar = '\0';
            this.createCategoryNameText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.createCategoryNameText.PlaceholderText = "Name";
            this.createCategoryNameText.SelectedText = "";
            this.createCategoryNameText.Size = new System.Drawing.Size(348, 42);
            this.createCategoryNameText.TabIndex = 71;
            this.createCategoryNameText.TextChanged += new System.EventHandler(this.createCategoryNameText_TextChanged);
            // 
            // createCategoryLabel
            // 
            this.createCategoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.createCategoryLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCategoryLabel.Location = new System.Drawing.Point(24, 51);
            this.createCategoryLabel.Name = "createCategoryLabel";
            this.createCategoryLabel.Size = new System.Drawing.Size(153, 25);
            this.createCategoryLabel.TabIndex = 70;
            this.createCategoryLabel.Text = "CREATE CATEGORY";
            // 
            // creCategoryImgUploadBtn
            // 
            this.creCategoryImgUploadBtn.Animated = true;
            this.creCategoryImgUploadBtn.BackColor = System.Drawing.Color.Transparent;
            this.creCategoryImgUploadBtn.BorderColor = System.Drawing.Color.Transparent;
            this.creCategoryImgUploadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.creCategoryImgUploadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.creCategoryImgUploadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.creCategoryImgUploadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.creCategoryImgUploadBtn.FillColor = System.Drawing.Color.DarkGray;
            this.creCategoryImgUploadBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.creCategoryImgUploadBtn.ForeColor = System.Drawing.Color.White;
            this.creCategoryImgUploadBtn.Image = global::EscopeWindowsApp.Properties.Resources.ImgUpload_Icon;
            this.creCategoryImgUploadBtn.ImageOffset = new System.Drawing.Point(0, -2);
            this.creCategoryImgUploadBtn.Location = new System.Drawing.Point(110, 317);
            this.creCategoryImgUploadBtn.Name = "creCategoryImgUploadBtn";
            this.creCategoryImgUploadBtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.creCategoryImgUploadBtn.Size = new System.Drawing.Size(30, 30);
            this.creCategoryImgUploadBtn.TabIndex = 77;
            this.creCategoryImgUploadBtn.UseTransparentBackground = true;
            this.creCategoryImgUploadBtn.Click += new System.EventHandler(this.creCategoryImgUploadBtn_Click);
            // 
            // CreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 440);
            this.Controls.Add(this.creCategoryImgUploadBtn);
            this.Controls.Add(this.creCategorySaveBtn);
            this.Controls.Add(this.creCategoryCancelBtn);
            this.Controls.Add(this.creCategoryLogoBox);
            this.Controls.Add(this.creteCategoryLogoChangelabel);
            this.Controls.Add(this.createCategoryNameLabel);
            this.Controls.Add(this.createCategoryNameText);
            this.Controls.Add(this.createCategoryLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 440);
            this.MinimumSize = new System.Drawing.Size(400, 440);
            this.Name = "CreateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Category";
            this.Load += new System.EventHandler(this.CreateCategory_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.creCategoryLogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm creCatBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox createBrandsCloseBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creCategorySaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creCategoryCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox creCategoryLogoBox;
        private System.Windows.Forms.Label creteCategoryLogoChangelabel;
        private System.Windows.Forms.Label createCategoryNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createCategoryNameText;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel createCategoryLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton creCategoryImgUploadBtn;
    }
}