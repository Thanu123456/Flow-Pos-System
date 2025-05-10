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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcode));
            this.generateBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.printBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.productSearchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.previewBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.serialNoDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.serialNoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateBtn.BorderRadius = 8;
            this.generateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.generateBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.generateBtn.Location = new System.Drawing.Point(789, 715);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(180, 45);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate";
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printBtn.BorderRadius = 8;
            this.printBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.printBtn.FillColor = System.Drawing.Color.Green;
            this.printBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.printBtn.Location = new System.Drawing.Point(1184, 715);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(180, 45);
            this.printBtn.TabIndex = 5;
            this.printBtn.Text = "Print";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
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
            this.productSearchText.Location = new System.Drawing.Point(17, 30);
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
            // previewBtn
            // 
            this.previewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previewBtn.BorderRadius = 8;
            this.previewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.previewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.previewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.previewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.previewBtn.FillColor = System.Drawing.Color.Red;
            this.previewBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewBtn.ForeColor = System.Drawing.Color.White;
            this.previewBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.previewBtn.Location = new System.Drawing.Point(987, 715);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(180, 45);
            this.previewBtn.TabIndex = 87;
            this.previewBtn.Text = "Preview";
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // serialNoDataGridView
            // 
            this.serialNoDataGridView.AllowUserToAddRows = false;
            this.serialNoDataGridView.AllowUserToDeleteRows = false;
            this.serialNoDataGridView.AllowUserToResizeColumns = false;
            this.serialNoDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.serialNoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.serialNoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialNoDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serialNoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.serialNoDataGridView.ColumnHeadersHeight = 45;
            this.serialNoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serialNoDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.serialNoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.serialNoDataGridView.Location = new System.Drawing.Point(17, 100);
            this.serialNoDataGridView.Name = "serialNoDataGridView";
            this.serialNoDataGridView.ReadOnly = true;
            this.serialNoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serialNoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.serialNoDataGridView.RowHeadersVisible = false;
            this.serialNoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.serialNoDataGridView.RowTemplate.Height = 35;
            this.serialNoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serialNoDataGridView.Size = new System.Drawing.Size(1347, 581);
            this.serialNoDataGridView.TabIndex = 45;
            this.serialNoDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.serialNoDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.serialNoDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNoDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.serialNoDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.serialNoDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.serialNoDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.serialNoDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.serialNoDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.serialNoDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.serialNoDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNoDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.serialNoDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.serialNoDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.serialNoDataGridView.ThemeStyle.ReadOnly = true;
            this.serialNoDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.serialNoDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.serialNoDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNoDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.serialNoDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.serialNoDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.serialNoDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.serialNoDataGridView);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.productSearchText);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.generateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "Barcode";
            this.Text = "Barcode";
            this.Load += new System.EventHandler(this.Barcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serialNoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton generateBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton printBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox productSearchText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton previewBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView serialNoDataGridView;
    }
}