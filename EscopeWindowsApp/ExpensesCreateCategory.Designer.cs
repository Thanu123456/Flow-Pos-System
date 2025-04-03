namespace EscopeWindowsApp
{
    partial class ExpensesCreateCategory
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
            this.expensesCatBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.createBrandsCloseBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.creExpSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.creExpCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.createExpNameLabel = new System.Windows.Forms.Label();
            this.createExpNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.createExpCategoryLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // expensesCatBorderlessForm
            // 
            this.expensesCatBorderlessForm.BorderRadius = 25;
            this.expensesCatBorderlessForm.ContainerControl = this;
            this.expensesCatBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.expensesCatBorderlessForm.TransparentWhileDrag = true;
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
            this.headerPanel.TabIndex = 70;
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
            // creExpSaveBtn
            // 
            this.creExpSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creExpSaveBtn.Animated = true;
            this.creExpSaveBtn.BorderRadius = 8;
            this.creExpSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.creExpSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.creExpSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.creExpSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.creExpSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.creExpSaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.creExpSaveBtn.ForeColor = System.Drawing.Color.White;
            this.creExpSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.creExpSaveBtn.Location = new System.Drawing.Point(166, 201);
            this.creExpSaveBtn.Name = "creExpSaveBtn";
            this.creExpSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.creExpSaveBtn.TabIndex = 81;
            this.creExpSaveBtn.Text = "Save";
            // 
            // creExpCancelBtn
            // 
            this.creExpCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creExpCancelBtn.Animated = true;
            this.creExpCancelBtn.BorderRadius = 8;
            this.creExpCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.creExpCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.creExpCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.creExpCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.creExpCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.creExpCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.creExpCancelBtn.ForeColor = System.Drawing.Color.White;
            this.creExpCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.creExpCancelBtn.Location = new System.Drawing.Point(274, 201);
            this.creExpCancelBtn.Name = "creExpCancelBtn";
            this.creExpCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.creExpCancelBtn.TabIndex = 80;
            this.creExpCancelBtn.Text = "Cancel";
            // 
            // createExpNameLabel
            // 
            this.createExpNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createExpNameLabel.AutoSize = true;
            this.createExpNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.createExpNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createExpNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.createExpNameLabel.Location = new System.Drawing.Point(21, 98);
            this.createExpNameLabel.Name = "createExpNameLabel";
            this.createExpNameLabel.Size = new System.Drawing.Size(60, 23);
            this.createExpNameLabel.TabIndex = 79;
            this.createExpNameLabel.Text = "Name:";
            // 
            // createExpNameText
            // 
            this.createExpNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createExpNameText.BackColor = System.Drawing.Color.Transparent;
            this.createExpNameText.BorderRadius = 8;
            this.createExpNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createExpNameText.DefaultText = "";
            this.createExpNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createExpNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createExpNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createExpNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createExpNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createExpNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createExpNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createExpNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createExpNameText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.createExpNameText.Location = new System.Drawing.Point(25, 128);
            this.createExpNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createExpNameText.Name = "createExpNameText";
            this.createExpNameText.PasswordChar = '\0';
            this.createExpNameText.PlaceholderText = "Name";
            this.createExpNameText.SelectedText = "";
            this.createExpNameText.Size = new System.Drawing.Size(348, 42);
            this.createExpNameText.TabIndex = 78;
            // 
            // createExpCategoryLabel
            // 
            this.createExpCategoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.createExpCategoryLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createExpCategoryLabel.Location = new System.Drawing.Point(24, 51);
            this.createExpCategoryLabel.Name = "createExpCategoryLabel";
            this.createExpCategoryLabel.Size = new System.Drawing.Size(171, 25);
            this.createExpCategoryLabel.TabIndex = 77;
            this.createExpCategoryLabel.Text = "EXPENSES CATEGORY";
            // 
            // ExpensesCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 275);
            this.Controls.Add(this.creExpSaveBtn);
            this.Controls.Add(this.creExpCancelBtn);
            this.Controls.Add(this.createExpNameLabel);
            this.Controls.Add(this.createExpNameText);
            this.Controls.Add(this.createExpCategoryLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 275);
            this.MinimumSize = new System.Drawing.Size(400, 275);
            this.Name = "ExpensesCategory";
            this.Text = "Expenses Category";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm expensesCatBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox createBrandsCloseBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creExpSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creExpCancelBtn;
        private System.Windows.Forms.Label createExpNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox createExpNameText;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel createExpCategoryLabel;
    }
}