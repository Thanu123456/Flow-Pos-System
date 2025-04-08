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
            this.unitsCal = new System.Windows.Forms.Label();
            this.calculateNum = new System.Windows.Forms.Label();
            this.unitShortName = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.blank_r = new System.Windows.Forms.Label();
            this.blank_l = new System.Windows.Forms.Label();
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
            this.kilogramNameLabel.Click += new System.EventHandler(this.kilogramNameLabel_Click);
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
            this.kilogramText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.kilogramText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kilogramText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kilogramText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.kilogramText.Location = new System.Drawing.Point(25, 128);
            this.kilogramText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kilogramText.Name = "kilogramText";
            this.kilogramText.PasswordChar = '\0';
            this.kilogramText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.kilogramText.PlaceholderText = "Add Volums";
            this.kilogramText.SelectedText = "";
            this.kilogramText.Size = new System.Drawing.Size(348, 42);
            this.kilogramText.TabIndex = 65;
            this.kilogramText.TextChanged += new System.EventHandler(this.kilogramText_TextChanged);
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
            this.kilogramLabel.Click += new System.EventHandler(this.kilogramLabel_Click);
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
            this.kiloSaveBtn.Location = new System.Drawing.Point(170, 354);
            this.kiloSaveBtn.Name = "kiloSaveBtn";
            this.kiloSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.kiloSaveBtn.TabIndex = 71;
            this.kiloSaveBtn.Text = "Save";
            this.kiloSaveBtn.Click += new System.EventHandler(this.kiloSaveBtn_Click);
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
            this.kiloCancelBtn.Location = new System.Drawing.Point(278, 354);
            this.kiloCancelBtn.Name = "kiloCancelBtn";
            this.kiloCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.kiloCancelBtn.TabIndex = 70;
            this.kiloCancelBtn.Text = "Cancel";
            this.kiloCancelBtn.Click += new System.EventHandler(this.kiloCancelBtn_Click);
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
            this.gramLabel.Click += new System.EventHandler(this.gramLabel_Click);
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
            this.gramText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gramText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gramText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gramText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.gramText.Location = new System.Drawing.Point(28, 214);
            this.gramText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gramText.Name = "gramText";
            this.gramText.PasswordChar = '\0';
            this.gramText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gramText.PlaceholderText = "Add Volums";
            this.gramText.SelectedText = "";
            this.gramText.Size = new System.Drawing.Size(348, 42);
            this.gramText.TabIndex = 72;
            this.gramText.TextChanged += new System.EventHandler(this.gramText_TextChanged);
            // 
            // unitsCal
            // 
            this.unitsCal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitsCal.AutoSize = true;
            this.unitsCal.BackColor = System.Drawing.Color.Transparent;
            this.unitsCal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsCal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.unitsCal.Location = new System.Drawing.Point(24, 293);
            this.unitsCal.Name = "unitsCal";
            this.unitsCal.Size = new System.Drawing.Size(87, 23);
            this.unitsCal.TabIndex = 74;
            this.unitsCal.Text = "Killogram:";
            this.unitsCal.Click += new System.EventHandler(this.unitsCal_Click);
            // 
            // calculateNum
            // 
            this.calculateNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateNum.AutoSize = true;
            this.calculateNum.BackColor = System.Drawing.Color.Transparent;
            this.calculateNum.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.calculateNum.Location = new System.Drawing.Point(151, 293);
            this.calculateNum.Name = "calculateNum";
            this.calculateNum.Size = new System.Drawing.Size(45, 23);
            this.calculateNum.TabIndex = 75;
            this.calculateNum.Text = "0.00";
            this.calculateNum.Click += new System.EventHandler(this.calculateNum_Click);
            // 
            // unitShortName
            // 
            this.unitShortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitShortName.AutoSize = true;
            this.unitShortName.BackColor = System.Drawing.Color.Transparent;
            this.unitShortName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitShortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.unitShortName.Location = new System.Drawing.Point(53, 326);
            this.unitShortName.Name = "unitShortName";
            this.unitShortName.Size = new System.Drawing.Size(29, 23);
            this.unitShortName.TabIndex = 76;
            this.unitShortName.Text = "Kg";
            this.unitShortName.Click += new System.EventHandler(this.unitShortName_Click);
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(117, 299);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(13, 15);
            this.equal.TabIndex = 77;
            this.equal.Text = "=";
            // 
            // blank_r
            // 
            this.blank_r.AutoSize = true;
            this.blank_r.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blank_r.Location = new System.Drawing.Point(78, 330);
            this.blank_r.Name = "blank_r";
            this.blank_r.Size = new System.Drawing.Size(14, 19);
            this.blank_r.TabIndex = 78;
            this.blank_r.Text = ")";
            // 
            // blank_l
            // 
            this.blank_l.AutoSize = true;
            this.blank_l.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blank_l.Location = new System.Drawing.Point(43, 329);
            this.blank_l.Name = "blank_l";
            this.blank_l.Size = new System.Drawing.Size(14, 19);
            this.blank_l.TabIndex = 79;
            this.blank_l.Text = "(";
            // 
            // POSWeightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 423);
            this.Controls.Add(this.blank_l);
            this.Controls.Add(this.blank_r);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.unitShortName);
            this.Controls.Add(this.calculateNum);
            this.Controls.Add(this.unitsCal);
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
            this.Load += new System.EventHandler(this.POSWeightForm_Load);
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
        private System.Windows.Forms.Label unitsCal;
        private System.Windows.Forms.Label calculateNum;
        private System.Windows.Forms.Label unitShortName;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Label blank_r;
        private System.Windows.Forms.Label blank_l;
    }
}