namespace EscopeWindowsApp
{
    partial class SupplierForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.suppliersListLabel = new System.Windows.Forms.Label();
            this.supSearchPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.supSearchBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supAddBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supPhoneText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.supEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.supNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.supIDText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.userPagiPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.userNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userCurrentBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.userDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supSearchPanel.SuspendLayout();
            this.userPagiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliersListLabel
            // 
            this.suppliersListLabel.AutoSize = true;
            this.suppliersListLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersListLabel.Location = new System.Drawing.Point(12, 10);
            this.suppliersListLabel.Name = "suppliersListLabel";
            this.suppliersListLabel.Size = new System.Drawing.Size(107, 17);
            this.suppliersListLabel.TabIndex = 5;
            this.suppliersListLabel.Text = "Suppliers List";
            // 
            // supSearchPanel
            // 
            this.supSearchPanel.BorderColor = System.Drawing.Color.Black;
            this.supSearchPanel.BorderRadius = 10;
            this.supSearchPanel.BorderThickness = 1;
            this.supSearchPanel.Controls.Add(this.supSearchBtn);
            this.supSearchPanel.Controls.Add(this.supAddBtn);
            this.supSearchPanel.Controls.Add(this.supPhoneText);
            this.supSearchPanel.Controls.Add(this.supEmailText);
            this.supSearchPanel.Controls.Add(this.supNameText);
            this.supSearchPanel.Controls.Add(this.supIDText);
            this.supSearchPanel.Location = new System.Drawing.Point(12, 43);
            this.supSearchPanel.Name = "supSearchPanel";
            this.supSearchPanel.Size = new System.Drawing.Size(810, 148);
            this.supSearchPanel.TabIndex = 4;
            // 
            // supSearchBtn
            // 
            this.supSearchBtn.BorderRadius = 8;
            this.supSearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supSearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supSearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supSearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supSearchBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.supSearchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.supSearchBtn.ForeColor = System.Drawing.Color.White;
            this.supSearchBtn.Location = new System.Drawing.Point(679, 84);
            this.supSearchBtn.Name = "supSearchBtn";
            this.supSearchBtn.Size = new System.Drawing.Size(106, 45);
            this.supSearchBtn.TabIndex = 4;
            this.supSearchBtn.Text = "Search";
            // 
            // supAddBtn
            // 
            this.supAddBtn.BorderRadius = 8;
            this.supAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supAddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.supAddBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.supAddBtn.ForeColor = System.Drawing.Color.White;
            this.supAddBtn.Location = new System.Drawing.Point(550, 84);
            this.supAddBtn.Name = "supAddBtn";
            this.supAddBtn.Size = new System.Drawing.Size(106, 45);
            this.supAddBtn.TabIndex = 0;
            this.supAddBtn.Text = "Add";
            this.supAddBtn.Click += new System.EventHandler(this.supAddBtn_Click);
            // 
            // supPhoneText
            // 
            this.supPhoneText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supPhoneText.BorderRadius = 8;
            this.supPhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supPhoneText.DefaultText = "";
            this.supPhoneText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supPhoneText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supPhoneText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supPhoneText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supPhoneText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.supPhoneText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supPhoneText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.supPhoneText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supPhoneText.Location = new System.Drawing.Point(14, 84);
            this.supPhoneText.Name = "supPhoneText";
            this.supPhoneText.PasswordChar = '\0';
            this.supPhoneText.PlaceholderText = "Enter Supplier Phone";
            this.supPhoneText.SelectedText = "";
            this.supPhoneText.Size = new System.Drawing.Size(247, 40);
            this.supPhoneText.TabIndex = 3;
            // 
            // supEmailText
            // 
            this.supEmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supEmailText.BorderRadius = 8;
            this.supEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supEmailText.DefaultText = "";
            this.supEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supEmailText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.supEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supEmailText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.supEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supEmailText.Location = new System.Drawing.Point(550, 20);
            this.supEmailText.Name = "supEmailText";
            this.supEmailText.PasswordChar = '\0';
            this.supEmailText.PlaceholderText = "Enter Supplier Email";
            this.supEmailText.SelectedText = "";
            this.supEmailText.Size = new System.Drawing.Size(247, 40);
            this.supEmailText.TabIndex = 2;
            // 
            // supNameText
            // 
            this.supNameText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supNameText.BorderRadius = 8;
            this.supNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supNameText.DefaultText = "";
            this.supNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supNameText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.supNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supNameText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.supNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supNameText.Location = new System.Drawing.Point(282, 20);
            this.supNameText.Name = "supNameText";
            this.supNameText.PasswordChar = '\0';
            this.supNameText.PlaceholderText = "Enter Supplier Name";
            this.supNameText.SelectedText = "";
            this.supNameText.Size = new System.Drawing.Size(247, 40);
            this.supNameText.TabIndex = 1;
            // 
            // supIDText
            // 
            this.supIDText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supIDText.BorderRadius = 8;
            this.supIDText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supIDText.DefaultText = "";
            this.supIDText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supIDText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supIDText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supIDText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supIDText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.supIDText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supIDText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.supIDText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supIDText.Location = new System.Drawing.Point(14, 20);
            this.supIDText.Name = "supIDText";
            this.supIDText.PasswordChar = '\0';
            this.supIDText.PlaceholderText = "Enter Supplier ID";
            this.supIDText.SelectedText = "";
            this.supIDText.Size = new System.Drawing.Size(247, 40);
            this.supIDText.TabIndex = 0;
            // 
            // userPagiPanel
            // 
            this.userPagiPanel.Controls.Add(this.userNextBtn);
            this.userPagiPanel.Controls.Add(this.userCurrentBtn);
            this.userPagiPanel.Controls.Add(this.userPrevBtn);
            this.userPagiPanel.FillColor = System.Drawing.Color.White;
            this.userPagiPanel.Location = new System.Drawing.Point(348, 499);
            this.userPagiPanel.Name = "userPagiPanel";
            this.userPagiPanel.Size = new System.Drawing.Size(183, 39);
            this.userPagiPanel.TabIndex = 7;
            // 
            // userNextBtn
            // 
            this.userNextBtn.BorderRadius = 10;
            this.userNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userNextBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.userNextBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.userNextBtn.ForeColor = System.Drawing.Color.White;
            this.userNextBtn.Location = new System.Drawing.Point(125, 3);
            this.userNextBtn.Name = "userNextBtn";
            this.userNextBtn.Size = new System.Drawing.Size(55, 33);
            this.userNextBtn.TabIndex = 4;
            this.userNextBtn.Text = "Next";
            // 
            // userCurrentBtn
            // 
            this.userCurrentBtn.BorderRadius = 10;
            this.userCurrentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userCurrentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userCurrentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userCurrentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userCurrentBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.userCurrentBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.userCurrentBtn.ForeColor = System.Drawing.Color.White;
            this.userCurrentBtn.Location = new System.Drawing.Point(64, 3);
            this.userCurrentBtn.Name = "userCurrentBtn";
            this.userCurrentBtn.Size = new System.Drawing.Size(55, 33);
            this.userCurrentBtn.TabIndex = 4;
            this.userCurrentBtn.Text = "1";
            // 
            // userPrevBtn
            // 
            this.userPrevBtn.BorderRadius = 10;
            this.userPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userPrevBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.userPrevBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.userPrevBtn.ForeColor = System.Drawing.Color.White;
            this.userPrevBtn.Location = new System.Drawing.Point(3, 3);
            this.userPrevBtn.Name = "userPrevBtn";
            this.userPrevBtn.Size = new System.Drawing.Size(55, 33);
            this.userPrevBtn.TabIndex = 3;
            this.userPrevBtn.Text = "Prev";
            // 
            // userDataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.userDataGridView.ColumnHeadersHeight = 25;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierID,
            this.supName,
            this.supDesc,
            this.supEmail,
            this.supPhone,
            this.createdAt,
            this.action});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.userDataGridView.GridColor = System.Drawing.Color.White;
            this.userDataGridView.Location = new System.Drawing.Point(12, 232);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersVisible = false;
            this.userDataGridView.Size = new System.Drawing.Size(810, 306);
            this.userDataGridView.TabIndex = 6;
            this.userDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.userDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.userDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.userDataGridView.ThemeStyle.ReadOnly = false;
            this.userDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.userDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.userDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.userDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.userDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // supplierID
            // 
            this.supplierID.HeaderText = "Supplier ID";
            this.supplierID.Name = "supplierID";
            // 
            // supName
            // 
            this.supName.HeaderText = "Name";
            this.supName.Name = "supName";
            // 
            // supDesc
            // 
            this.supDesc.HeaderText = "Description";
            this.supDesc.Name = "supDesc";
            // 
            // supEmail
            // 
            this.supEmail.HeaderText = "Email";
            this.supEmail.Name = "supEmail";
            // 
            // supPhone
            // 
            this.supPhone.HeaderText = "Phone";
            this.supPhone.Name = "supPhone";
            // 
            // createdAt
            // 
            this.createdAt.HeaderText = "Create At";
            this.createdAt.Name = "createdAt";
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 618);
            this.Controls.Add(this.userPagiPanel);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.suppliersListLabel);
            this.Controls.Add(this.supSearchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.supSearchPanel.ResumeLayout(false);
            this.userPagiPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label suppliersListLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel supSearchPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supSearchBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supAddBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox supPhoneText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox supEmailText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox supNameText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox supIDText;
        private Siticone.Desktop.UI.WinForms.SiticonePanel userPagiPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userCurrentBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton userPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn supEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn supPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
    }
}