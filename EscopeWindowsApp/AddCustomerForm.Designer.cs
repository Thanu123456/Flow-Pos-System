namespace EscopeWindowsApp
{
    partial class AddCustomerForm
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
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.maximumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.generalinfoLabel = new System.Windows.Forms.Label();
            this.cusGinfoPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.cusResetBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.addCusCreatedText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addCusAddressText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addCusDescText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addCusEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addCusPhoneText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addCusNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addCusLabel = new System.Windows.Forms.Label();
            this.addCusBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.cusAnimateWindow = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.cusGinfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(838, 34);
            this.headerPanel.TabIndex = 2;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlPanel.Controls.Add(this.minimumBtn);
            this.controlPanel.Controls.Add(this.maximumBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.SystemColors.Control;
            this.controlPanel.Location = new System.Drawing.Point(693, 1);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(142, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // minimumBtn
            // 
            this.minimumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumBtn.BorderRadius = 8;
            this.minimumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimumBtn.FillColor = System.Drawing.Color.Silver;
            this.minimumBtn.IconColor = System.Drawing.Color.White;
            this.minimumBtn.Location = new System.Drawing.Point(4, 3);
            this.minimumBtn.Name = "minimumBtn";
            this.minimumBtn.Size = new System.Drawing.Size(41, 25);
            this.minimumBtn.TabIndex = 2;
            // 
            // maximumBtn
            // 
            this.maximumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximumBtn.BorderRadius = 8;
            this.maximumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maximumBtn.FillColor = System.Drawing.Color.Silver;
            this.maximumBtn.IconColor = System.Drawing.Color.White;
            this.maximumBtn.Location = new System.Drawing.Point(51, 2);
            this.maximumBtn.Name = "maximumBtn";
            this.maximumBtn.Size = new System.Drawing.Size(41, 26);
            this.maximumBtn.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.FillColor = System.Drawing.Color.Silver;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(98, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(41, 26);
            this.closeBtn.TabIndex = 0;
            // 
            // generalinfoLabel
            // 
            this.generalinfoLabel.AutoSize = true;
            this.generalinfoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalinfoLabel.Location = new System.Drawing.Point(41, 78);
            this.generalinfoLabel.Name = "generalinfoLabel";
            this.generalinfoLabel.Size = new System.Drawing.Size(122, 14);
            this.generalinfoLabel.TabIndex = 7;
            this.generalinfoLabel.Text = "General Information";
            // 
            // cusGinfoPanel
            // 
            this.cusGinfoPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cusGinfoPanel.BorderRadius = 8;
            this.cusGinfoPanel.BorderThickness = 1;
            this.cusGinfoPanel.Controls.Add(this.cusResetBtn);
            this.cusGinfoPanel.Controls.Add(this.cusSaveBtn);
            this.cusGinfoPanel.Controls.Add(this.addCusCreatedText);
            this.cusGinfoPanel.Controls.Add(this.addCusAddressText);
            this.cusGinfoPanel.Controls.Add(this.addCusDescText);
            this.cusGinfoPanel.Controls.Add(this.addCusEmailText);
            this.cusGinfoPanel.Controls.Add(this.addCusPhoneText);
            this.cusGinfoPanel.Controls.Add(this.addCusNameText);
            this.cusGinfoPanel.Location = new System.Drawing.Point(16, 84);
            this.cusGinfoPanel.Name = "cusGinfoPanel";
            this.cusGinfoPanel.Size = new System.Drawing.Size(810, 395);
            this.cusGinfoPanel.TabIndex = 6;
            // 
            // cusResetBtn
            // 
            this.cusResetBtn.BorderRadius = 8;
            this.cusResetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusResetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusResetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusResetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusResetBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cusResetBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cusResetBtn.ForeColor = System.Drawing.Color.White;
            this.cusResetBtn.Location = new System.Drawing.Point(691, 330);
            this.cusResetBtn.Name = "cusResetBtn";
            this.cusResetBtn.Size = new System.Drawing.Size(106, 45);
            this.cusResetBtn.TabIndex = 12;
            this.cusResetBtn.Text = "Reset";
            // 
            // cusSaveBtn
            // 
            this.cusSaveBtn.BorderRadius = 8;
            this.cusSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.cusSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cusSaveBtn.ForeColor = System.Drawing.Color.White;
            this.cusSaveBtn.Location = new System.Drawing.Point(556, 330);
            this.cusSaveBtn.Name = "cusSaveBtn";
            this.cusSaveBtn.Size = new System.Drawing.Size(106, 45);
            this.cusSaveBtn.TabIndex = 11;
            this.cusSaveBtn.Text = "Save";
            // 
            // addCusCreatedText
            // 
            this.addCusCreatedText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addCusCreatedText.BorderRadius = 8;
            this.addCusCreatedText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCusCreatedText.DefaultText = "";
            this.addCusCreatedText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addCusCreatedText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addCusCreatedText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusCreatedText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusCreatedText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusCreatedText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addCusCreatedText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusCreatedText.Location = new System.Drawing.Point(430, 256);
            this.addCusCreatedText.Name = "addCusCreatedText";
            this.addCusCreatedText.PasswordChar = '\0';
            this.addCusCreatedText.PlaceholderText = "Enter Customer Created At";
            this.addCusCreatedText.SelectedText = "";
            this.addCusCreatedText.Size = new System.Drawing.Size(367, 36);
            this.addCusCreatedText.TabIndex = 8;
            // 
            // addCusAddressText
            // 
            this.addCusAddressText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addCusAddressText.BorderRadius = 8;
            this.addCusAddressText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCusAddressText.DefaultText = "";
            this.addCusAddressText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addCusAddressText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addCusAddressText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusAddressText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusAddressText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusAddressText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addCusAddressText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusAddressText.Location = new System.Drawing.Point(12, 256);
            this.addCusAddressText.Name = "addCusAddressText";
            this.addCusAddressText.PasswordChar = '\0';
            this.addCusAddressText.PlaceholderText = "Enter Customer Address";
            this.addCusAddressText.SelectedText = "";
            this.addCusAddressText.Size = new System.Drawing.Size(367, 36);
            this.addCusAddressText.TabIndex = 6;
            // 
            // addCusDescText
            // 
            this.addCusDescText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addCusDescText.BorderRadius = 8;
            this.addCusDescText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCusDescText.DefaultText = "";
            this.addCusDescText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addCusDescText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addCusDescText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusDescText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusDescText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusDescText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addCusDescText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusDescText.Location = new System.Drawing.Point(12, 97);
            this.addCusDescText.Name = "addCusDescText";
            this.addCusDescText.PasswordChar = '\0';
            this.addCusDescText.PlaceholderText = "Enter Description";
            this.addCusDescText.SelectedText = "";
            this.addCusDescText.Size = new System.Drawing.Size(785, 110);
            this.addCusDescText.TabIndex = 5;
            // 
            // addCusEmailText
            // 
            this.addCusEmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addCusEmailText.BorderRadius = 8;
            this.addCusEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCusEmailText.DefaultText = "";
            this.addCusEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addCusEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addCusEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusEmailText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addCusEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusEmailText.Location = new System.Drawing.Point(281, 22);
            this.addCusEmailText.Name = "addCusEmailText";
            this.addCusEmailText.PasswordChar = '\0';
            this.addCusEmailText.PlaceholderText = "Enter Customer Email";
            this.addCusEmailText.SelectedText = "";
            this.addCusEmailText.Size = new System.Drawing.Size(247, 36);
            this.addCusEmailText.TabIndex = 4;
            // 
            // addCusPhoneText
            // 
            this.addCusPhoneText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addCusPhoneText.BorderRadius = 8;
            this.addCusPhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCusPhoneText.DefaultText = "";
            this.addCusPhoneText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addCusPhoneText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addCusPhoneText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusPhoneText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusPhoneText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusPhoneText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addCusPhoneText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusPhoneText.Location = new System.Drawing.Point(550, 22);
            this.addCusPhoneText.Name = "addCusPhoneText";
            this.addCusPhoneText.PasswordChar = '\0';
            this.addCusPhoneText.PlaceholderText = "Enter Customer Phone";
            this.addCusPhoneText.SelectedText = "";
            this.addCusPhoneText.Size = new System.Drawing.Size(247, 36);
            this.addCusPhoneText.TabIndex = 3;
            // 
            // addCusNameText
            // 
            this.addCusNameText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addCusNameText.BorderRadius = 8;
            this.addCusNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCusNameText.DefaultText = "";
            this.addCusNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addCusNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addCusNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addCusNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusNameText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addCusNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addCusNameText.Location = new System.Drawing.Point(12, 22);
            this.addCusNameText.Name = "addCusNameText";
            this.addCusNameText.PasswordChar = '\0';
            this.addCusNameText.PlaceholderText = "Enter Customer Name";
            this.addCusNameText.SelectedText = "";
            this.addCusNameText.Size = new System.Drawing.Size(247, 36);
            this.addCusNameText.TabIndex = 1;
            // 
            // addCusLabel
            // 
            this.addCusLabel.AutoSize = true;
            this.addCusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCusLabel.Location = new System.Drawing.Point(13, 44);
            this.addCusLabel.Name = "addCusLabel";
            this.addCusLabel.Size = new System.Drawing.Size(169, 17);
            this.addCusLabel.TabIndex = 5;
            this.addCusLabel.Text = "Create New Customer";
            // 
            // addCusBorderlessForm
            // 
            this.addCusBorderlessForm.BorderRadius = 25;
            this.addCusBorderlessForm.ContainerControl = this;
            this.addCusBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.addCusBorderlessForm.TransparentWhileDrag = true;
            // 
            // cusAnimateWindow
            // 
            this.cusAnimateWindow.TargetForm = this;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 519);
            this.Controls.Add(this.generalinfoLabel);
            this.Controls.Add(this.cusGinfoPanel);
            this.Controls.Add(this.addCusLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.cusGinfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox maximumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private System.Windows.Forms.Label generalinfoLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel cusGinfoPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addCusDescText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addCusEmailText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addCusPhoneText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addCusNameText;
        private System.Windows.Forms.Label addCusLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addCusCreatedText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addCusAddressText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusResetBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm addCusBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow cusAnimateWindow;
    }
}