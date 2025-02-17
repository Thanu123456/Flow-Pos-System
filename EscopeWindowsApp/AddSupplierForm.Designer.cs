namespace EscopeWindowsApp
{
    partial class AddSupplierForm
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
            this.addSupLabel = new System.Windows.Forms.Label();
            this.generalinfoLabel = new System.Windows.Forms.Label();
            this.supGinfoPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.addSupEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addSupPhoneText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addSupNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addSupIDText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addSupDateText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addSupDescText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.supResetBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.addSupBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.supAnimateWindow = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.supGinfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(837, 34);
            this.headerPanel.TabIndex = 2;
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
            // addSupLabel
            // 
            this.addSupLabel.AutoSize = true;
            this.addSupLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSupLabel.Location = new System.Drawing.Point(12, 47);
            this.addSupLabel.Name = "addSupLabel";
            this.addSupLabel.Size = new System.Drawing.Size(159, 17);
            this.addSupLabel.TabIndex = 3;
            this.addSupLabel.Text = "Create New Supplier";
            // 
            // generalinfoLabel
            // 
            this.generalinfoLabel.AutoSize = true;
            this.generalinfoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalinfoLabel.Location = new System.Drawing.Point(40, 87);
            this.generalinfoLabel.Name = "generalinfoLabel";
            this.generalinfoLabel.Size = new System.Drawing.Size(122, 14);
            this.generalinfoLabel.TabIndex = 6;
            this.generalinfoLabel.Text = "General Information";
            // 
            // supGinfoPanel
            // 
            this.supGinfoPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supGinfoPanel.BorderRadius = 8;
            this.supGinfoPanel.BorderThickness = 1;
            this.supGinfoPanel.Controls.Add(this.addSupDescText);
            this.supGinfoPanel.Controls.Add(this.addSupDateText);
            this.supGinfoPanel.Controls.Add(this.addSupEmailText);
            this.supGinfoPanel.Controls.Add(this.addSupPhoneText);
            this.supGinfoPanel.Controls.Add(this.addSupNameText);
            this.supGinfoPanel.Controls.Add(this.addSupIDText);
            this.supGinfoPanel.Location = new System.Drawing.Point(15, 93);
            this.supGinfoPanel.Name = "supGinfoPanel";
            this.supGinfoPanel.Size = new System.Drawing.Size(810, 331);
            this.supGinfoPanel.TabIndex = 5;
            // 
            // addSupEmailText
            // 
            this.addSupEmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSupEmailText.BorderRadius = 8;
            this.addSupEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addSupEmailText.DefaultText = "";
            this.addSupEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addSupEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addSupEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addSupEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addSupEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addSupEmailText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addSupEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addSupEmailText.Location = new System.Drawing.Point(12, 278);
            this.addSupEmailText.Name = "addSupEmailText";
            this.addSupEmailText.PasswordChar = '\0';
            this.addSupEmailText.PlaceholderText = "Enter Supplier Email";
            this.addSupEmailText.SelectedText = "";
            this.addSupEmailText.Size = new System.Drawing.Size(247, 36);
            this.addSupEmailText.TabIndex = 5;
            // 
            // addSupPhoneText
            // 
            this.addSupPhoneText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSupPhoneText.BorderRadius = 8;
            this.addSupPhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addSupPhoneText.DefaultText = "";
            this.addSupPhoneText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addSupPhoneText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addSupPhoneText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addSupPhoneText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addSupPhoneText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addSupPhoneText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addSupPhoneText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addSupPhoneText.Location = new System.Drawing.Point(281, 278);
            this.addSupPhoneText.Name = "addSupPhoneText";
            this.addSupPhoneText.PasswordChar = '\0';
            this.addSupPhoneText.PlaceholderText = "Enter Supplier Phone";
            this.addSupPhoneText.SelectedText = "";
            this.addSupPhoneText.Size = new System.Drawing.Size(247, 36);
            this.addSupPhoneText.TabIndex = 4;
            // 
            // addSupNameText
            // 
            this.addSupNameText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSupNameText.BorderRadius = 8;
            this.addSupNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addSupNameText.DefaultText = "";
            this.addSupNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addSupNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addSupNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addSupNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addSupNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addSupNameText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addSupNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addSupNameText.Location = new System.Drawing.Point(281, 22);
            this.addSupNameText.Name = "addSupNameText";
            this.addSupNameText.PasswordChar = '\0';
            this.addSupNameText.PlaceholderText = "Enter Supplier Name";
            this.addSupNameText.SelectedText = "";
            this.addSupNameText.Size = new System.Drawing.Size(247, 36);
            this.addSupNameText.TabIndex = 2;
            // 
            // addSupIDText
            // 
            this.addSupIDText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSupIDText.BorderRadius = 8;
            this.addSupIDText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addSupIDText.DefaultText = "";
            this.addSupIDText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addSupIDText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addSupIDText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addSupIDText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addSupIDText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addSupIDText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addSupIDText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addSupIDText.Location = new System.Drawing.Point(12, 22);
            this.addSupIDText.Name = "addSupIDText";
            this.addSupIDText.PasswordChar = '\0';
            this.addSupIDText.PlaceholderText = "Enter Supplier ID";
            this.addSupIDText.SelectedText = "";
            this.addSupIDText.Size = new System.Drawing.Size(247, 36);
            this.addSupIDText.TabIndex = 1;
            // 
            // addSupDateText
            // 
            this.addSupDateText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSupDateText.BorderRadius = 8;
            this.addSupDateText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addSupDateText.DefaultText = "";
            this.addSupDateText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addSupDateText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addSupDateText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addSupDateText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addSupDateText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addSupDateText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addSupDateText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addSupDateText.Location = new System.Drawing.Point(550, 278);
            this.addSupDateText.Name = "addSupDateText";
            this.addSupDateText.PasswordChar = '\0';
            this.addSupDateText.PlaceholderText = "Enter Created At Date";
            this.addSupDateText.SelectedText = "";
            this.addSupDateText.Size = new System.Drawing.Size(247, 36);
            this.addSupDateText.TabIndex = 6;
            // 
            // addSupDescText
            // 
            this.addSupDescText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSupDescText.BorderRadius = 8;
            this.addSupDescText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addSupDescText.DefaultText = "";
            this.addSupDescText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addSupDescText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addSupDescText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addSupDescText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addSupDescText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addSupDescText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.addSupDescText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addSupDescText.Location = new System.Drawing.Point(12, 100);
            this.addSupDescText.Name = "addSupDescText";
            this.addSupDescText.PasswordChar = '\0';
            this.addSupDescText.PlaceholderText = "Enter Supplier Description";
            this.addSupDescText.SelectedText = "";
            this.addSupDescText.Size = new System.Drawing.Size(785, 142);
            this.addSupDescText.TabIndex = 7;
            this.addSupDescText.TextChanged += new System.EventHandler(this.siticoneTextBox2_TextChanged);
            // 
            // supResetBtn
            // 
            this.supResetBtn.BorderRadius = 8;
            this.supResetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supResetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supResetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supResetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supResetBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.supResetBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.supResetBtn.ForeColor = System.Drawing.Color.White;
            this.supResetBtn.Location = new System.Drawing.Point(719, 458);
            this.supResetBtn.Name = "supResetBtn";
            this.supResetBtn.Size = new System.Drawing.Size(106, 45);
            this.supResetBtn.TabIndex = 12;
            this.supResetBtn.Text = "Reset";
            // 
            // supSaveBtn
            // 
            this.supSaveBtn.BorderRadius = 8;
            this.supSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.supSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.supSaveBtn.ForeColor = System.Drawing.Color.White;
            this.supSaveBtn.Location = new System.Drawing.Point(584, 458);
            this.supSaveBtn.Name = "supSaveBtn";
            this.supSaveBtn.Size = new System.Drawing.Size(106, 45);
            this.supSaveBtn.TabIndex = 11;
            this.supSaveBtn.Text = "Save";
            // 
            // addSupBorderlessForm
            // 
            this.addSupBorderlessForm.BorderRadius = 25;
            this.addSupBorderlessForm.ContainerControl = this;
            this.addSupBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.addSupBorderlessForm.TransparentWhileDrag = true;
            // 
            // supAnimateWindow
            // 
            this.supAnimateWindow.TargetForm = this;
            // 
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 515);
            this.Controls.Add(this.supResetBtn);
            this.Controls.Add(this.supSaveBtn);
            this.Controls.Add(this.generalinfoLabel);
            this.Controls.Add(this.supGinfoPanel);
            this.Controls.Add(this.addSupLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSupplierForm";
            this.Text = "AddSupplierForm";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.supGinfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox maximumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private System.Windows.Forms.Label addSupLabel;
        private System.Windows.Forms.Label generalinfoLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel supGinfoPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addSupEmailText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addSupPhoneText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addSupNameText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addSupIDText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addSupDescText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addSupDateText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supResetBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm addSupBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow supAnimateWindow;
    }
}