namespace EscopeWindowsApp
{
    partial class AddWarehouseForm
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
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.maximumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.createWareLabel = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.createSupNameLabel = new System.Windows.Forms.Label();
            this.createWareNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createWareEmailLabel = new System.Windows.Forms.Label();
            this.createWareEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createWarePhoneLabel = new System.Windows.Forms.Label();
            this.createWarePhoneText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createWareCityText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createWareCityLabel = new System.Windows.Forms.Label();
            this.WareCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.WareSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1000, 34);
            this.headerPanel.TabIndex = 3;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlPanel.Controls.Add(this.minimumBtn);
            this.controlPanel.Controls.Add(this.maximumBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.SystemColors.Control;
            this.controlPanel.Location = new System.Drawing.Point(855, 1);
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
            // createWareLabel
            // 
            this.createWareLabel.AutoSize = true;
            this.createWareLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createWareLabel.Location = new System.Drawing.Point(26, 56);
            this.createWareLabel.Name = "createWareLabel";
            this.createWareLabel.Size = new System.Drawing.Size(228, 28);
            this.createWareLabel.TabIndex = 19;
            this.createWareLabel.Text = "Create Warehouse";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BorderRadius = 8;
            this.siticonePanel1.Controls.Add(this.WareCancelBtn);
            this.siticonePanel1.Controls.Add(this.WareSaveBtn);
            this.siticonePanel1.Controls.Add(this.createWareCityText);
            this.siticonePanel1.Controls.Add(this.createWareCityLabel);
            this.siticonePanel1.Controls.Add(this.createWarePhoneLabel);
            this.siticonePanel1.Controls.Add(this.createWarePhoneText);
            this.siticonePanel1.Controls.Add(this.createWareEmailLabel);
            this.siticonePanel1.Controls.Add(this.createWareEmailText);
            this.siticonePanel1.Controls.Add(this.createSupNameLabel);
            this.siticonePanel1.Controls.Add(this.createWareNameText);
            this.siticonePanel1.FillColor = System.Drawing.Color.White;
            this.siticonePanel1.Location = new System.Drawing.Point(31, 103);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(928, 374);
            this.siticonePanel1.TabIndex = 20;
            // 
            // createSupNameLabel
            // 
            this.createSupNameLabel.AutoSize = true;
            this.createSupNameLabel.BackColor = System.Drawing.Color.White;
            this.createSupNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSupNameLabel.Location = new System.Drawing.Point(17, 25);
            this.createSupNameLabel.Name = "createSupNameLabel";
            this.createSupNameLabel.Size = new System.Drawing.Size(60, 23);
            this.createSupNameLabel.TabIndex = 21;
            this.createSupNameLabel.Text = "Name:";
            // 
            // createWareNameText
            // 
            this.createWareNameText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createWareNameText.BorderRadius = 8;
            this.createWareNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createWareNameText.DefaultText = "";
            this.createWareNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createWareNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createWareNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createWareNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createWareNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createWareNameText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createWareNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createWareNameText.Location = new System.Drawing.Point(21, 64);
            this.createWareNameText.Name = "createWareNameText";
            this.createWareNameText.PasswordChar = '\0';
            this.createWareNameText.PlaceholderText = "Enter Warehouse Name";
            this.createWareNameText.SelectedText = "";
            this.createWareNameText.Size = new System.Drawing.Size(400, 42);
            this.createWareNameText.TabIndex = 20;
            // 
            // createWareEmailLabel
            // 
            this.createWareEmailLabel.AutoSize = true;
            this.createWareEmailLabel.BackColor = System.Drawing.Color.White;
            this.createWareEmailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createWareEmailLabel.Location = new System.Drawing.Point(503, 25);
            this.createWareEmailLabel.Name = "createWareEmailLabel";
            this.createWareEmailLabel.Size = new System.Drawing.Size(56, 23);
            this.createWareEmailLabel.TabIndex = 23;
            this.createWareEmailLabel.Text = "Email:";
            // 
            // createWareEmailText
            // 
            this.createWareEmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createWareEmailText.BorderRadius = 8;
            this.createWareEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createWareEmailText.DefaultText = "";
            this.createWareEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createWareEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createWareEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createWareEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createWareEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createWareEmailText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createWareEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createWareEmailText.Location = new System.Drawing.Point(507, 64);
            this.createWareEmailText.Name = "createWareEmailText";
            this.createWareEmailText.PasswordChar = '\0';
            this.createWareEmailText.PlaceholderText = "Enter Warehouse Email";
            this.createWareEmailText.SelectedText = "";
            this.createWareEmailText.Size = new System.Drawing.Size(400, 42);
            this.createWareEmailText.TabIndex = 22;
            // 
            // createWarePhoneLabel
            // 
            this.createWarePhoneLabel.AutoSize = true;
            this.createWarePhoneLabel.BackColor = System.Drawing.Color.White;
            this.createWarePhoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createWarePhoneLabel.Location = new System.Drawing.Point(17, 149);
            this.createWarePhoneLabel.Name = "createWarePhoneLabel";
            this.createWarePhoneLabel.Size = new System.Drawing.Size(131, 23);
            this.createWarePhoneLabel.TabIndex = 25;
            this.createWarePhoneLabel.Text = "Phone Number:";
            // 
            // createWarePhoneText
            // 
            this.createWarePhoneText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createWarePhoneText.BorderRadius = 8;
            this.createWarePhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createWarePhoneText.DefaultText = "";
            this.createWarePhoneText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createWarePhoneText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createWarePhoneText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createWarePhoneText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createWarePhoneText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createWarePhoneText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createWarePhoneText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createWarePhoneText.Location = new System.Drawing.Point(21, 186);
            this.createWarePhoneText.Name = "createWarePhoneText";
            this.createWarePhoneText.PasswordChar = '\0';
            this.createWarePhoneText.PlaceholderText = "Enter Warehouse Phone";
            this.createWarePhoneText.SelectedText = "";
            this.createWarePhoneText.Size = new System.Drawing.Size(400, 42);
            this.createWarePhoneText.TabIndex = 24;
            // 
            // createWareCityText
            // 
            this.createWareCityText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createWareCityText.BorderRadius = 8;
            this.createWareCityText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createWareCityText.DefaultText = "";
            this.createWareCityText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createWareCityText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createWareCityText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createWareCityText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createWareCityText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createWareCityText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.createWareCityText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createWareCityText.Location = new System.Drawing.Point(507, 186);
            this.createWareCityText.Name = "createWareCityText";
            this.createWareCityText.PasswordChar = '\0';
            this.createWareCityText.PlaceholderText = "Enter Warehouse City";
            this.createWareCityText.SelectedText = "";
            this.createWareCityText.Size = new System.Drawing.Size(400, 42);
            this.createWareCityText.TabIndex = 27;
            // 
            // createWareCityLabel
            // 
            this.createWareCityLabel.AutoSize = true;
            this.createWareCityLabel.BackColor = System.Drawing.Color.White;
            this.createWareCityLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createWareCityLabel.Location = new System.Drawing.Point(503, 149);
            this.createWareCityLabel.Name = "createWareCityLabel";
            this.createWareCityLabel.Size = new System.Drawing.Size(44, 23);
            this.createWareCityLabel.TabIndex = 26;
            this.createWareCityLabel.Text = "City:";
            // 
            // WareCancelBtn
            // 
            this.WareCancelBtn.BorderRadius = 8;
            this.WareCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WareCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WareCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WareCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WareCancelBtn.FillColor = System.Drawing.Color.DarkGray;
            this.WareCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.WareCancelBtn.ForeColor = System.Drawing.Color.White;
            this.WareCancelBtn.Location = new System.Drawing.Point(814, 299);
            this.WareCancelBtn.Name = "WareCancelBtn";
            this.WareCancelBtn.Size = new System.Drawing.Size(93, 47);
            this.WareCancelBtn.TabIndex = 32;
            this.WareCancelBtn.Text = "Cancel";
            // 
            // WareSaveBtn
            // 
            this.WareSaveBtn.BorderRadius = 8;
            this.WareSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WareSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WareSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WareSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WareSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.WareSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WareSaveBtn.ForeColor = System.Drawing.Color.White;
            this.WareSaveBtn.Location = new System.Drawing.Point(698, 299);
            this.WareSaveBtn.Name = "WareSaveBtn";
            this.WareSaveBtn.Size = new System.Drawing.Size(93, 47);
            this.WareSaveBtn.TabIndex = 31;
            this.WareSaveBtn.Text = "Save";
            // 
            // AddWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1000, 558);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.createWareLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddWarehouseForm";
            this.Text = "AddWarehouseForm";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox maximumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private System.Windows.Forms.Label createWareLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label createSupNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createWareNameText;
        private System.Windows.Forms.Label createWareEmailLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createWareEmailText;
        private System.Windows.Forms.Label createWarePhoneLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createWarePhoneText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createWareCityText;
        private System.Windows.Forms.Label createWareCityLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton WareCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton WareSaveBtn;
    }
}