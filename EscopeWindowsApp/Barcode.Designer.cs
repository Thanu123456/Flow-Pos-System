namespace EscopeWindowsApp
{
    partial class Barcode
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barcodePictureBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.enterProIDtextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.qtytextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.productNameTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.generateBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.printBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.serialNoDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.productSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // barcodePictureBox
            // 
            this.barcodePictureBox.ImageRotate = 0F;
            this.barcodePictureBox.Location = new System.Drawing.Point(36, 413);
            this.barcodePictureBox.Name = "barcodePictureBox";
            this.barcodePictureBox.Size = new System.Drawing.Size(540, 280);
            this.barcodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.barcodePictureBox.TabIndex = 0;
            this.barcodePictureBox.TabStop = false;
            this.barcodePictureBox.Click += new System.EventHandler(this.barcodePictureBox_Click);
            // 
            // enterProIDtextBox
            // 
            this.enterProIDtextBox.BorderColor = System.Drawing.Color.Gray;
            this.enterProIDtextBox.BorderRadius = 8;
            this.enterProIDtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enterProIDtextBox.DefaultText = "";
            this.enterProIDtextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.enterProIDtextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.enterProIDtextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.enterProIDtextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.enterProIDtextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enterProIDtextBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.enterProIDtextBox.ForeColor = System.Drawing.Color.Black;
            this.enterProIDtextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enterProIDtextBox.Location = new System.Drawing.Point(35, 348);
            this.enterProIDtextBox.Name = "enterProIDtextBox";
            this.enterProIDtextBox.PasswordChar = '\0';
            this.enterProIDtextBox.PlaceholderText = "Enter ProductID";
            this.enterProIDtextBox.SelectedText = "";
            this.enterProIDtextBox.Size = new System.Drawing.Size(200, 36);
            this.enterProIDtextBox.TabIndex = 1;
            this.enterProIDtextBox.TextChanged += new System.EventHandler(this.enterProIDtextBox_TextChanged_1);
            // 
            // qtytextBox
            // 
            this.qtytextBox.BorderColor = System.Drawing.Color.Gray;
            this.qtytextBox.BorderRadius = 8;
            this.qtytextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qtytextBox.DefaultText = "";
            this.qtytextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.qtytextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.qtytextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.qtytextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.qtytextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qtytextBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.qtytextBox.ForeColor = System.Drawing.Color.Black;
            this.qtytextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qtytextBox.Location = new System.Drawing.Point(489, 348);
            this.qtytextBox.Name = "qtytextBox";
            this.qtytextBox.PasswordChar = '\0';
            this.qtytextBox.PlaceholderText = "Quantity";
            this.qtytextBox.SelectedText = "";
            this.qtytextBox.Size = new System.Drawing.Size(200, 36);
            this.qtytextBox.TabIndex = 2;
            this.qtytextBox.TextChanged += new System.EventHandler(this.qtytextBox_TextChanged);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.productNameTextBox.BorderRadius = 8;
            this.productNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productNameTextBox.DefaultText = "";
            this.productNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productNameTextBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.productNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.productNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productNameTextBox.Location = new System.Drawing.Point(258, 348);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.PasswordChar = '\0';
            this.productNameTextBox.PlaceholderText = "Enter Product Name";
            this.productNameTextBox.SelectedText = "";
            this.productNameTextBox.Size = new System.Drawing.Size(200, 36);
            this.productNameTextBox.TabIndex = 3;
            this.productNameTextBox.TextChanged += new System.EventHandler(this.productNameTextBox_TextChanged_1);
            // 
            // generateBtn
            // 
            this.generateBtn.BorderRadius = 8;
            this.generateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.generateBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.Location = new System.Drawing.Point(669, 462);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(180, 45);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate";
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BorderRadius = 8;
            this.printBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.printBtn.FillColor = System.Drawing.Color.Green;
            this.printBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(669, 536);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(180, 45);
            this.printBtn.TabIndex = 5;
            this.printBtn.Text = "Print";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // serialNoDataGridView
            // 
            this.serialNoDataGridView.AllowUserToAddRows = false;
            this.serialNoDataGridView.AllowUserToDeleteRows = false;
            this.serialNoDataGridView.AllowUserToResizeColumns = false;
            this.serialNoDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.serialNoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.serialNoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serialNoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.serialNoDataGridView.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serialNoDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.serialNoDataGridView.GridColor = System.Drawing.Color.White;
            this.serialNoDataGridView.Location = new System.Drawing.Point(35, 82);
            this.serialNoDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.serialNoDataGridView.Name = "serialNoDataGridView";
            this.serialNoDataGridView.ReadOnly = true;
            this.serialNoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serialNoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.serialNoDataGridView.RowHeadersVisible = false;
            this.serialNoDataGridView.RowHeadersWidth = 22;
            this.serialNoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.serialNoDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.serialNoDataGridView.RowTemplate.Height = 35;
            this.serialNoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serialNoDataGridView.Size = new System.Drawing.Size(890, 223);
            this.serialNoDataGridView.TabIndex = 85;
            this.serialNoDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.serialNoDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.serialNoDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNoDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.serialNoDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.serialNoDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.serialNoDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.serialNoDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.serialNoDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.serialNoDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.serialNoDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNoDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.serialNoDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.serialNoDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.serialNoDataGridView.ThemeStyle.ReadOnly = true;
            this.serialNoDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.serialNoDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.serialNoDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNoDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.serialNoDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.serialNoDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.serialNoDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.serialNoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serialNoDataGridView_CellContentClick);
            // 
            // productSearchText
            // 
            this.productSearchText.BorderColor = System.Drawing.Color.Gray;
            this.productSearchText.BorderRadius = 8;
            this.productSearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productSearchText.DefaultText = "";
            this.productSearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productSearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productSearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productSearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productSearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productSearchText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.productSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productSearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productSearchText.IconLeft = global::EscopeWindowsApp.Properties.Resources.search;
            this.productSearchText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.productSearchText.Location = new System.Drawing.Point(36, 13);
            this.productSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productSearchText.Name = "productSearchText";
            this.productSearchText.PasswordChar = '\0';
            this.productSearchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.productSearchText.PlaceholderText = "Search";
            this.productSearchText.SelectedText = "";
            this.productSearchText.Size = new System.Drawing.Size(400, 42);
            this.productSearchText.TabIndex = 86;
            this.productSearchText.TextChanged += new System.EventHandler(this.productSearchText_TextChanged);
            // 
            // Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 718);
            this.ControlBox = false;
            this.Controls.Add(this.productSearchText);
            this.Controls.Add(this.serialNoDataGridView);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.qtytextBox);
            this.Controls.Add(this.enterProIDtextBox);
            this.Controls.Add(this.barcodePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1364, 718);
            this.Name = "Barcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode";
            this.Load += new System.EventHandler(this.Barcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox barcodePictureBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox enterProIDtextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox qtytextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox productNameTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton printBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView serialNoDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox productSearchText;
    }
}