namespace EscopeWindowsApp
{
    partial class CreateBaseUnit
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
            this.baseUnitBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.createBaseUnitsCloseBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.creCatSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.creCatCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.createBaseUnitNameLabel = new System.Windows.Forms.Label();
            this.createBaseUnitNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createBaseUnitsLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseUnitBorderlessForm
            // 
            this.baseUnitBorderlessForm.BorderRadius = 25;
            this.baseUnitBorderlessForm.ContainerControl = this;
            this.baseUnitBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.baseUnitBorderlessForm.TransparentWhileDrag = true;
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
            this.headerPanel.TabIndex = 89;
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
            this.creCatSaveBtn.Location = new System.Drawing.Point(170, 201);
            this.creCatSaveBtn.Name = "creCatSaveBtn";
            this.creCatSaveBtn.Size = new System.Drawing.Size(91, 42);
            this.creCatSaveBtn.TabIndex = 87;
            this.creCatSaveBtn.Text = "Save";
            this.creCatSaveBtn.Click += new System.EventHandler(this.creCatSaveBtn_Click);
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
            this.creCatCancelBtn.Location = new System.Drawing.Point(278, 201);
            this.creCatCancelBtn.Name = "creCatCancelBtn";
            this.creCatCancelBtn.Size = new System.Drawing.Size(91, 42);
            this.creCatCancelBtn.TabIndex = 86;
            this.creCatCancelBtn.Text = "Cancel";
            this.creCatCancelBtn.Click += new System.EventHandler(this.creCatCancelBtn_Click);
            // 
            // createBaseUnitNameLabel
            // 
            this.createBaseUnitNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBaseUnitNameLabel.AutoSize = true;
            this.createBaseUnitNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.createBaseUnitNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBaseUnitNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.createBaseUnitNameLabel.Location = new System.Drawing.Point(17, 102);
            this.createBaseUnitNameLabel.Name = "createBaseUnitNameLabel";
            this.createBaseUnitNameLabel.Size = new System.Drawing.Size(60, 23);
            this.createBaseUnitNameLabel.TabIndex = 84;
            this.createBaseUnitNameLabel.Text = "Name:";
            // 
            // createBaseUnitNameText
            // 
            this.createBaseUnitNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBaseUnitNameText.BackColor = System.Drawing.Color.Transparent;
            this.createBaseUnitNameText.BorderRadius = 8;
            this.createBaseUnitNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createBaseUnitNameText.DefaultText = "";
            this.createBaseUnitNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createBaseUnitNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createBaseUnitNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createBaseUnitNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createBaseUnitNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createBaseUnitNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBaseUnitNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createBaseUnitNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createBaseUnitNameText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.createBaseUnitNameText.Location = new System.Drawing.Point(21, 132);
            this.createBaseUnitNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createBaseUnitNameText.Name = "createBaseUnitNameText";
            this.createBaseUnitNameText.PasswordChar = '\0';
            this.createBaseUnitNameText.PlaceholderText = "Name";
            this.createBaseUnitNameText.SelectedText = "";
            this.createBaseUnitNameText.Size = new System.Drawing.Size(348, 42);
            this.createBaseUnitNameText.TabIndex = 83;
            this.createBaseUnitNameText.TextChanged += new System.EventHandler(this.createBaseUnitNameText_TextChanged);
            // 
            // createBaseUnitsLabel
            // 
            this.createBaseUnitsLabel.BackColor = System.Drawing.Color.Transparent;
            this.createBaseUnitsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBaseUnitsLabel.Location = new System.Drawing.Point(20, 54);
            this.createBaseUnitsLabel.Name = "createBaseUnitsLabel";
            this.createBaseUnitsLabel.Size = new System.Drawing.Size(160, 25);
            this.createBaseUnitsLabel.TabIndex = 82;
            this.createBaseUnitsLabel.Text = "CREATE BASE UNITS";
            // 
            // CreateBaseUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 275);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.creCatSaveBtn);
            this.Controls.Add(this.creCatCancelBtn);
            this.Controls.Add(this.createBaseUnitNameLabel);
            this.Controls.Add(this.createBaseUnitNameText);
            this.Controls.Add(this.createBaseUnitsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 275);
            this.MinimumSize = new System.Drawing.Size(400, 275);
            this.Name = "CreateBaseUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateBaseUnit";
            this.Load += new System.EventHandler(this.CreateBaseUnit_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm baseUnitBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox createBaseUnitsCloseBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creCatSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creCatCancelBtn;
        private System.Windows.Forms.Label createBaseUnitNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createBaseUnitNameText;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel createBaseUnitsLabel;
    }
}