namespace EscopeWindowsApp
{
    partial class POSRegister
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
            this.posRegBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.createBaseUnitsCloseBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.posRegSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cashInHandLabel = new System.Windows.Forms.Label();
            this.cashInHandText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.posRegLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // posRegBorderlessForm
            // 
            this.posRegBorderlessForm.BorderRadius = 25;
            this.posRegBorderlessForm.ContainerControl = this;
            this.posRegBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.posRegBorderlessForm.TransparentWhileDrag = true;
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
            this.headerPanel.TabIndex = 90;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.createBaseUnitsCloseBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(335, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(65, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // createBaseUnitsCloseBtn
            // 
            this.createBaseUnitsCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createBaseUnitsCloseBtn.BorderRadius = 8;
            this.createBaseUnitsCloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createBaseUnitsCloseBtn.IconColor = System.Drawing.Color.White;
            this.createBaseUnitsCloseBtn.Location = new System.Drawing.Point(16, 2);
            this.createBaseUnitsCloseBtn.Name = "createBaseUnitsCloseBtn";
            this.createBaseUnitsCloseBtn.Size = new System.Drawing.Size(28, 26);
            this.createBaseUnitsCloseBtn.TabIndex = 0;
            // 
            // posRegSaveBtn
            // 
            this.posRegSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.posRegSaveBtn.Animated = true;
            this.posRegSaveBtn.BorderRadius = 8;
            this.posRegSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.posRegSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.posRegSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.posRegSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.posRegSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.posRegSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.posRegSaveBtn.ForeColor = System.Drawing.Color.White;
            this.posRegSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.posRegSaveBtn.Location = new System.Drawing.Point(272, 201);
            this.posRegSaveBtn.Name = "posRegSaveBtn";
            this.posRegSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.posRegSaveBtn.TabIndex = 92;
            this.posRegSaveBtn.Text = "Submit";
            this.posRegSaveBtn.Click += new System.EventHandler(this.posRegSaveBtn_Click);
            // 
            // cashInHandLabel
            // 
            this.cashInHandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cashInHandLabel.AutoSize = true;
            this.cashInHandLabel.BackColor = System.Drawing.Color.Transparent;
            this.cashInHandLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashInHandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cashInHandLabel.Location = new System.Drawing.Point(17, 102);
            this.cashInHandLabel.Name = "cashInHandLabel";
            this.cashInHandLabel.Size = new System.Drawing.Size(117, 23);
            this.cashInHandLabel.TabIndex = 90;
            this.cashInHandLabel.Text = "Cash In Hand:";
            // 
            // cashInHandText
            // 
            this.cashInHandText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cashInHandText.BackColor = System.Drawing.Color.Transparent;
            this.cashInHandText.BorderRadius = 8;
            this.cashInHandText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cashInHandText.DefaultText = "";
            this.cashInHandText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cashInHandText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cashInHandText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cashInHandText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cashInHandText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cashInHandText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashInHandText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cashInHandText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cashInHandText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.cashInHandText.Location = new System.Drawing.Point(21, 132);
            this.cashInHandText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cashInHandText.Name = "cashInHandText";
            this.cashInHandText.PasswordChar = '\0';
            this.cashInHandText.PlaceholderText = "Amount";
            this.cashInHandText.SelectedText = "";
            this.cashInHandText.Size = new System.Drawing.Size(348, 42);
            this.cashInHandText.TabIndex = 89;
            this.cashInHandText.TextChanged += new System.EventHandler(this.cashInHandText_TextChanged);
            // 
            // posRegLabel
            // 
            this.posRegLabel.BackColor = System.Drawing.Color.Transparent;
            this.posRegLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posRegLabel.Location = new System.Drawing.Point(20, 54);
            this.posRegLabel.Name = "posRegLabel";
            this.posRegLabel.Size = new System.Drawing.Size(114, 25);
            this.posRegLabel.TabIndex = 88;
            this.posRegLabel.Text = "POS REGISTER";
            // 
            // POSRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 275);
            this.Controls.Add(this.posRegSaveBtn);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.cashInHandText);
            this.Controls.Add(this.cashInHandLabel);
            this.Controls.Add(this.posRegLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 275);
            this.MinimumSize = new System.Drawing.Size(400, 275);
            this.Name = "POSRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSRegister";
            this.Load += new System.EventHandler(this.POSRegister_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm posRegBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox createBaseUnitsCloseBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton posRegSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox cashInHandText;
        private System.Windows.Forms.Label cashInHandLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel posRegLabel;
    }
}