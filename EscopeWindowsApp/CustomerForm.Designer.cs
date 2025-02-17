namespace EscopeWindowsApp
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customersListLabel = new System.Windows.Forms.Label();
            this.cusSearchPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.cusSearchBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusAddBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusEmailText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.cusNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.cusPagiPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.cusNextBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusCurrentBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusPrevBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.cusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAddres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSearchPanel.SuspendLayout();
            this.cusPagiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cusDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customersListLabel
            // 
            this.customersListLabel.AutoSize = true;
            this.customersListLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersListLabel.Location = new System.Drawing.Point(12, 10);
            this.customersListLabel.Name = "customersListLabel";
            this.customersListLabel.Size = new System.Drawing.Size(117, 17);
            this.customersListLabel.TabIndex = 5;
            this.customersListLabel.Text = "Customers List";
            // 
            // cusSearchPanel
            // 
            this.cusSearchPanel.BorderColor = System.Drawing.Color.Black;
            this.cusSearchPanel.BorderRadius = 10;
            this.cusSearchPanel.BorderThickness = 1;
            this.cusSearchPanel.Controls.Add(this.cusSearchBtn);
            this.cusSearchPanel.Controls.Add(this.cusAddBtn);
            this.cusSearchPanel.Controls.Add(this.cusEmailText);
            this.cusSearchPanel.Controls.Add(this.cusNameText);
            this.cusSearchPanel.Location = new System.Drawing.Point(12, 43);
            this.cusSearchPanel.Name = "cusSearchPanel";
            this.cusSearchPanel.Size = new System.Drawing.Size(810, 148);
            this.cusSearchPanel.TabIndex = 4;
            // 
            // cusSearchBtn
            // 
            this.cusSearchBtn.BorderRadius = 8;
            this.cusSearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusSearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusSearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusSearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusSearchBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.cusSearchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cusSearchBtn.ForeColor = System.Drawing.Color.White;
            this.cusSearchBtn.Location = new System.Drawing.Point(679, 84);
            this.cusSearchBtn.Name = "cusSearchBtn";
            this.cusSearchBtn.Size = new System.Drawing.Size(106, 45);
            this.cusSearchBtn.TabIndex = 4;
            this.cusSearchBtn.Text = "Search";
            // 
            // cusAddBtn
            // 
            this.cusAddBtn.BorderRadius = 8;
            this.cusAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusAddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.cusAddBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cusAddBtn.ForeColor = System.Drawing.Color.White;
            this.cusAddBtn.Location = new System.Drawing.Point(550, 84);
            this.cusAddBtn.Name = "cusAddBtn";
            this.cusAddBtn.Size = new System.Drawing.Size(106, 45);
            this.cusAddBtn.TabIndex = 0;
            this.cusAddBtn.Text = "Add";
            this.cusAddBtn.Click += new System.EventHandler(this.cusAddBtn_Click);
            // 
            // cusEmailText
            // 
            this.cusEmailText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cusEmailText.BorderRadius = 8;
            this.cusEmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cusEmailText.DefaultText = "";
            this.cusEmailText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cusEmailText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cusEmailText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusEmailText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusEmailText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cusEmailText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusEmailText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cusEmailText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusEmailText.Location = new System.Drawing.Point(428, 20);
            this.cusEmailText.Name = "cusEmailText";
            this.cusEmailText.PasswordChar = '\0';
            this.cusEmailText.PlaceholderText = "Enter Email";
            this.cusEmailText.SelectedText = "";
            this.cusEmailText.Size = new System.Drawing.Size(357, 40);
            this.cusEmailText.TabIndex = 1;
            // 
            // cusNameText
            // 
            this.cusNameText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cusNameText.BorderRadius = 8;
            this.cusNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cusNameText.DefaultText = "";
            this.cusNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cusNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cusNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cusNameText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cusNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusNameText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cusNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cusNameText.Location = new System.Drawing.Point(14, 20);
            this.cusNameText.Name = "cusNameText";
            this.cusNameText.PasswordChar = '\0';
            this.cusNameText.PlaceholderText = "Enter Name";
            this.cusNameText.SelectedText = "";
            this.cusNameText.Size = new System.Drawing.Size(357, 40);
            this.cusNameText.TabIndex = 0;
            // 
            // cusPagiPanel
            // 
            this.cusPagiPanel.Controls.Add(this.cusNextBtn);
            this.cusPagiPanel.Controls.Add(this.cusCurrentBtn);
            this.cusPagiPanel.Controls.Add(this.cusPrevBtn);
            this.cusPagiPanel.FillColor = System.Drawing.Color.White;
            this.cusPagiPanel.Location = new System.Drawing.Point(342, 500);
            this.cusPagiPanel.Name = "cusPagiPanel";
            this.cusPagiPanel.Size = new System.Drawing.Size(183, 39);
            this.cusPagiPanel.TabIndex = 7;
            // 
            // cusNextBtn
            // 
            this.cusNextBtn.BorderRadius = 10;
            this.cusNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusNextBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.cusNextBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.cusNextBtn.ForeColor = System.Drawing.Color.White;
            this.cusNextBtn.Location = new System.Drawing.Point(125, 3);
            this.cusNextBtn.Name = "cusNextBtn";
            this.cusNextBtn.Size = new System.Drawing.Size(55, 33);
            this.cusNextBtn.TabIndex = 4;
            this.cusNextBtn.Text = "Next";
            // 
            // cusCurrentBtn
            // 
            this.cusCurrentBtn.BorderRadius = 10;
            this.cusCurrentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusCurrentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusCurrentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusCurrentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusCurrentBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.cusCurrentBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.cusCurrentBtn.ForeColor = System.Drawing.Color.White;
            this.cusCurrentBtn.Location = new System.Drawing.Point(64, 3);
            this.cusCurrentBtn.Name = "cusCurrentBtn";
            this.cusCurrentBtn.Size = new System.Drawing.Size(55, 33);
            this.cusCurrentBtn.TabIndex = 4;
            this.cusCurrentBtn.Text = "1";
            // 
            // cusPrevBtn
            // 
            this.cusPrevBtn.BorderRadius = 10;
            this.cusPrevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusPrevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusPrevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusPrevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusPrevBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.cusPrevBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.cusPrevBtn.ForeColor = System.Drawing.Color.White;
            this.cusPrevBtn.Location = new System.Drawing.Point(3, 3);
            this.cusPrevBtn.Name = "cusPrevBtn";
            this.cusPrevBtn.Size = new System.Drawing.Size(55, 33);
            this.cusPrevBtn.TabIndex = 3;
            this.cusPrevBtn.Text = "Prev";
            // 
            // cusDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cusDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cusDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cusDataGridView.ColumnHeadersHeight = 25;
            this.cusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.cusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusId,
            this.cusName,
            this.cusEmail,
            this.cusPhone,
            this.cusAddres,
            this.cusCreatedDate,
            this.cusAction});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cusDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.cusDataGridView.GridColor = System.Drawing.Color.White;
            this.cusDataGridView.Location = new System.Drawing.Point(12, 233);
            this.cusDataGridView.Name = "cusDataGridView";
            this.cusDataGridView.RowHeadersVisible = false;
            this.cusDataGridView.Size = new System.Drawing.Size(810, 306);
            this.cusDataGridView.TabIndex = 6;
            this.cusDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.cusDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.cusDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.cusDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.cusDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cusDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cusDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.cusDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.cusDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.cusDataGridView.ThemeStyle.ReadOnly = false;
            this.cusDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.cusDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cusDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.cusDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.cusDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.cusDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cusId
            // 
            this.cusId.HeaderText = "ID";
            this.cusId.Name = "cusId";
            // 
            // cusName
            // 
            this.cusName.HeaderText = "Name";
            this.cusName.Name = "cusName";
            // 
            // cusEmail
            // 
            this.cusEmail.HeaderText = "Email";
            this.cusEmail.Name = "cusEmail";
            // 
            // cusPhone
            // 
            this.cusPhone.HeaderText = "Phone";
            this.cusPhone.Name = "cusPhone";
            // 
            // cusAddres
            // 
            this.cusAddres.HeaderText = "Address";
            this.cusAddres.Name = "cusAddres";
            // 
            // cusCreatedDate
            // 
            this.cusCreatedDate.HeaderText = "Created At";
            this.cusCreatedDate.Name = "cusCreatedDate";
            // 
            // cusAction
            // 
            this.cusAction.HeaderText = "Action";
            this.cusAction.Name = "cusAction";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 599);
            this.Controls.Add(this.cusPagiPanel);
            this.Controls.Add(this.cusDataGridView);
            this.Controls.Add(this.customersListLabel);
            this.Controls.Add(this.cusSearchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.cusSearchPanel.ResumeLayout(false);
            this.cusPagiPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cusDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customersListLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel cusSearchPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusSearchBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusAddBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox cusEmailText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox cusNameText;
        private Siticone.Desktop.UI.WinForms.SiticonePanel cusPagiPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusNextBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusCurrentBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusPrevBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView cusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusAddres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusAction;
    }
}