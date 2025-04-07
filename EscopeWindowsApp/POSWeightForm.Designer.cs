namespace EscopeWindowsApp
{
    partial class POSWeightForm
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
            this.posWeightBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.createBrandsCloseBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.kilogramNameLabel = new System.Windows.Forms.Label();
            this.kilogramText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.kilogramLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.kiloSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.kiloCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.gramLabel = new System.Windows.Forms.Label();
            this.gramText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // posWeightBorderlessForm
            // 
            this.posWeightBorderlessForm.BorderRadius = 25;
            this.posWeightBorderlessForm.ContainerControl = this;
            this.posWeightBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.posWeightBorderlessForm.TransparentWhileDrag = true;
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
            // kilogramNameLabel
            // 
            this.kilogramNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kilogramNameLabel.AutoSize = true;
            this.kilogramNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.kilogramNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilogramNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.kilogramNameLabel.Location = new System.Drawing.Point(21, 98);
            this.kilogramNameLabel.Name = "kilogramNameLabel";
            this.kilogramNameLabel.Size = new System.Drawing.Size(83, 23);
            this.kilogramNameLabel.TabIndex = 66;
            this.kilogramNameLabel.Text = "Kilogram:";
            // 
            // kilogramText
            // 
            this.kilogramText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kilogramText.BackColor = System.Drawing.Color.Transparent;
            this.kilogramText.BorderColor = System.Drawing.Color.Gray;
            this.kilogramText.BorderRadius = 8;
            this.kilogramText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kilogramText.DefaultText = "";
            this.kilogramText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kilogramText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kilogramText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kilogramText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kilogramText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kilogramText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilogramText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kilogramText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kilogramText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.kilogramText.Location = new System.Drawing.Point(25, 128);
            this.kilogramText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kilogramText.Name = "kilogramText";
            this.kilogramText.PasswordChar = '\0';
            this.kilogramText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.kilogramText.PlaceholderText = "Kilogram";
            this.kilogramText.SelectedText = "";
            this.kilogramText.Size = new System.Drawing.Size(348, 42);
            this.kilogramText.TabIndex = 65;
            // 
            // kilogramLabel
            // 
            this.kilogramLabel.BackColor = System.Drawing.Color.Transparent;
            this.kilogramLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilogramLabel.Location = new System.Drawing.Point(24, 51);
            this.kilogramLabel.Name = "kilogramLabel";
            this.kilogramLabel.Size = new System.Drawing.Size(91, 25);
            this.kilogramLabel.TabIndex = 64;
            this.kilogramLabel.Text = "KILOGRAM";
            // 
            // kiloSaveBtn
            // 
            this.kiloSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kiloSaveBtn.Animated = true;
            this.kiloSaveBtn.BorderRadius = 8;
            this.kiloSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kiloSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kiloSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kiloSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kiloSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.kiloSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.kiloSaveBtn.ForeColor = System.Drawing.Color.White;
            this.kiloSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.kiloSaveBtn.Location = new System.Drawing.Point(170, 291);
            this.kiloSaveBtn.Name = "kiloSaveBtn";
            this.kiloSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.kiloSaveBtn.TabIndex = 71;
            this.kiloSaveBtn.Text = "Save";
            // 
            // kiloCancelBtn
            // 
            this.kiloCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kiloCancelBtn.Animated = true;
            this.kiloCancelBtn.BorderRadius = 8;
            this.kiloCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kiloCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kiloCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kiloCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kiloCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kiloCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.kiloCancelBtn.ForeColor = System.Drawing.Color.White;
            this.kiloCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.kiloCancelBtn.Location = new System.Drawing.Point(278, 291);
            this.kiloCancelBtn.Name = "kiloCancelBtn";
            this.kiloCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.kiloCancelBtn.TabIndex = 70;
            this.kiloCancelBtn.Text = "Cancel";
            // 
            // gramLabel
            // 
            this.gramLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gramLabel.AutoSize = true;
            this.gramLabel.BackColor = System.Drawing.Color.Transparent;
            this.gramLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gramLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gramLabel.Location = new System.Drawing.Point(24, 184);
            this.gramLabel.Name = "gramLabel";
            this.gramLabel.Size = new System.Drawing.Size(58, 23);
            this.gramLabel.TabIndex = 73;
            this.gramLabel.Text = "Gram:";
            // 
            // gramText
            // 
            this.gramText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gramText.BackColor = System.Drawing.Color.Transparent;
            this.gramText.BorderColor = System.Drawing.Color.Gray;
            this.gramText.BorderRadius = 8;
            this.gramText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gramText.DefaultText = "";
            this.gramText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gramText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gramText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gramText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gramText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gramText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gramText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gramText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gramText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.gramText.Location = new System.Drawing.Point(28, 214);
            this.gramText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gramText.Name = "gramText";
            this.gramText.PasswordChar = '\0';
            this.gramText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gramText.PlaceholderText = "Gram";
            this.gramText.SelectedText = "";
            this.gramText.Size = new System.Drawing.Size(348, 42);
            this.gramText.TabIndex = 72;
            // 
            // POSWeightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 360);
            this.Controls.Add(this.gramLabel);
            this.Controls.Add(this.gramText);
            this.Controls.Add(this.kiloSaveBtn);
            this.Controls.Add(this.kiloCancelBtn);
            this.Controls.Add(this.kilogramNameLabel);
            this.Controls.Add(this.kilogramText);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.kilogramLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 440);
            this.MinimumSize = new System.Drawing.Size(400, 360);
            this.Name = "POSWeightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSWeightForm";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm posWeightBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox createBrandsCloseBtn;
        private System.Windows.Forms.Label kilogramNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox kilogramText;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel kilogramLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton kiloSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton kiloCancelBtn;
        private System.Windows.Forms.Label gramLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox gramText;
    }
}