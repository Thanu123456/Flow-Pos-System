namespace EscopeWindowsApp
{
    partial class CreateVariations
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
            this.createVarCloseBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.creCatSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.creCatCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.creteVarTypeChangelabel = new System.Windows.Forms.Label();
            this.createVarNameLabel = new System.Windows.Forms.Label();
            this.createVarNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createVarLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.variationBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.varTypeTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addVarTypeBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
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
            this.headerPanel.Size = new System.Drawing.Size(400, 34);
            this.headerPanel.TabIndex = 68;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.createVarCloseBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(335, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(65, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // createVarCloseBtn
            // 
            this.createVarCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createVarCloseBtn.BorderRadius = 8;
            this.createVarCloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createVarCloseBtn.IconColor = System.Drawing.Color.White;
            this.createVarCloseBtn.Location = new System.Drawing.Point(16, 2);
            this.createVarCloseBtn.Name = "createVarCloseBtn";
            this.createVarCloseBtn.Size = new System.Drawing.Size(28, 26);
            this.createVarCloseBtn.TabIndex = 0;
            // 
            // creCatSaveBtn
            // 
            this.creCatSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creCatSaveBtn.Animated = true;
            this.creCatSaveBtn.BorderRadius = 8;
            this.creCatSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.creCatSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.creCatSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.creCatSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.creCatSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.creCatSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.creCatSaveBtn.ForeColor = System.Drawing.Color.White;
            this.creCatSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.creCatSaveBtn.Location = new System.Drawing.Point(166, 366);
            this.creCatSaveBtn.Name = "creCatSaveBtn";
            this.creCatSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.creCatSaveBtn.TabIndex = 67;
            this.creCatSaveBtn.Text = "Save";
            this.creCatSaveBtn.Click += new System.EventHandler(this.creCatSaveBtn_Click);
            // 
            // creCatCancelBtn
            // 
            this.creCatCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creCatCancelBtn.Animated = true;
            this.creCatCancelBtn.BorderRadius = 8;
            this.creCatCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.creCatCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.creCatCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.creCatCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.creCatCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.creCatCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.creCatCancelBtn.ForeColor = System.Drawing.Color.White;
            this.creCatCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.creCatCancelBtn.Location = new System.Drawing.Point(274, 366);
            this.creCatCancelBtn.Name = "creCatCancelBtn";
            this.creCatCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.creCatCancelBtn.TabIndex = 66;
            this.creCatCancelBtn.Text = "Cancel";
            this.creCatCancelBtn.Click += new System.EventHandler(this.creCatCancelBtn_Click);
            // 
            // creteVarTypeChangelabel
            // 
            this.creteVarTypeChangelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creteVarTypeChangelabel.AutoSize = true;
            this.creteVarTypeChangelabel.BackColor = System.Drawing.Color.Transparent;
            this.creteVarTypeChangelabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creteVarTypeChangelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.creteVarTypeChangelabel.Location = new System.Drawing.Point(17, 197);
            this.creteVarTypeChangelabel.Name = "creteVarTypeChangelabel";
            this.creteVarTypeChangelabel.Size = new System.Drawing.Size(133, 23);
            this.creteVarTypeChangelabel.TabIndex = 64;
            this.creteVarTypeChangelabel.Text = "Variation Types:";
            // 
            // createVarNameLabel
            // 
            this.createVarNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createVarNameLabel.AutoSize = true;
            this.createVarNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.createVarNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createVarNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.createVarNameLabel.Location = new System.Drawing.Point(17, 102);
            this.createVarNameLabel.Name = "createVarNameLabel";
            this.createVarNameLabel.Size = new System.Drawing.Size(60, 23);
            this.createVarNameLabel.TabIndex = 63;
            this.createVarNameLabel.Text = "Name:";
            // 
            // createVarNameText
            // 
            this.createVarNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createVarNameText.BackColor = System.Drawing.Color.Transparent;
            this.createVarNameText.BorderRadius = 8;
            this.createVarNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createVarNameText.DefaultText = "";
            this.createVarNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createVarNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createVarNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createVarNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createVarNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createVarNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createVarNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createVarNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createVarNameText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.createVarNameText.Location = new System.Drawing.Point(21, 132);
            this.createVarNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createVarNameText.Name = "createVarNameText";
            this.createVarNameText.PasswordChar = '\0';
            this.createVarNameText.PlaceholderText = "Name";
            this.createVarNameText.SelectedText = "";
            this.createVarNameText.Size = new System.Drawing.Size(348, 42);
            this.createVarNameText.TabIndex = 62;
            this.createVarNameText.TextChanged += new System.EventHandler(this.createVarNameText_TextChanged);
            // 
            // createVarLabel
            // 
            this.createVarLabel.BackColor = System.Drawing.Color.Transparent;
            this.createVarLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createVarLabel.Location = new System.Drawing.Point(20, 54);
            this.createVarLabel.Name = "createVarLabel";
            this.createVarLabel.Size = new System.Drawing.Size(158, 25);
            this.createVarLabel.TabIndex = 61;
            this.createVarLabel.Text = "CREATE VARIATION";
            // 
            // variationBorderlessForm
            // 
            this.variationBorderlessForm.BorderRadius = 25;
            this.variationBorderlessForm.ContainerControl = this;
            this.variationBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.variationBorderlessForm.TransparentWhileDrag = true;
            // 
            // varTypeTextBox
            // 
            this.varTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.varTypeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.varTypeTextBox.BorderRadius = 8;
            this.varTypeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.varTypeTextBox.DefaultText = "";
            this.varTypeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.varTypeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.varTypeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.varTypeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.varTypeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.varTypeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varTypeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.varTypeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.varTypeTextBox.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.varTypeTextBox.Location = new System.Drawing.Point(20, 229);
            this.varTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.varTypeTextBox.Name = "varTypeTextBox";
            this.varTypeTextBox.PasswordChar = '\0';
            this.varTypeTextBox.PlaceholderText = "Please Enter Variation Type";
            this.varTypeTextBox.SelectedText = "";
            this.varTypeTextBox.Size = new System.Drawing.Size(281, 42);
            this.varTypeTextBox.TabIndex = 69;
            this.varTypeTextBox.TextChanged += new System.EventHandler(this.varTypeTextBox_TextChanged);
            // 
            // addVarTypeBtn
            // 
            this.addVarTypeBtn.Animated = true;
            this.addVarTypeBtn.BorderRadius = 8;
            this.addVarTypeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addVarTypeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addVarTypeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addVarTypeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addVarTypeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.addVarTypeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.addVarTypeBtn.ForeColor = System.Drawing.Color.White;
            this.addVarTypeBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.addVarTypeBtn.Location = new System.Drawing.Point(321, 229);
            this.addVarTypeBtn.Name = "addVarTypeBtn";
            this.addVarTypeBtn.Size = new System.Drawing.Size(47, 42);
            this.addVarTypeBtn.TabIndex = 70;
            this.addVarTypeBtn.Text = "+";
            this.addVarTypeBtn.Click += new System.EventHandler(this.addVarTypeBtn_Click);
            // 
            // CreateVariations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 440);
            this.Controls.Add(this.addVarTypeBtn);
            this.Controls.Add(this.varTypeTextBox);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.creCatSaveBtn);
            this.Controls.Add(this.creCatCancelBtn);
            this.Controls.Add(this.creteVarTypeChangelabel);
            this.Controls.Add(this.createVarNameLabel);
            this.Controls.Add(this.createVarNameText);
            this.Controls.Add(this.createVarLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 440);
            this.MinimumSize = new System.Drawing.Size(400, 440);
            this.Name = "CreateVariations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateVariations";
            this.Load += new System.EventHandler(this.CreateVariations_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox createVarCloseBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creCatSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creCatCancelBtn;
        private System.Windows.Forms.Label creteVarTypeChangelabel;
        private System.Windows.Forms.Label createVarNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createVarNameText;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel createVarLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm variationBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox varTypeTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addVarTypeBtn;
    }
}