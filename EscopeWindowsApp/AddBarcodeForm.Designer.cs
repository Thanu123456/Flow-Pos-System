namespace EscopeWindowsApp
{
    partial class AddBarcodeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBarcodeForm));
            this.barProIDText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.barProIDLabel = new System.Windows.Forms.Label();
            this.barProNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.barProNameLabel = new System.Windows.Forms.Label();
            this.barQuantityLabel = new System.Windows.Forms.Label();
            this.barQuantityText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.barStartRangeText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.barStartRangeLabel = new System.Windows.Forms.Label();
            this.barEndRangeText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.barEndRangeLabel = new System.Windows.Forms.Label();
            this.barDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.barcodeSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.barcodeCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.barAddToListBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.barSingleText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.barSingleLabel = new System.Windows.Forms.Label();
            this.checkRange = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.addBarcodeBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.detailsPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.barVarTypLabel = new System.Windows.Forms.Label();
            this.barVarTypCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barDataGridView)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // barProIDText
            // 
            this.barProIDText.BackColor = System.Drawing.Color.Transparent;
            this.barProIDText.BorderRadius = 8;
            this.barProIDText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barProIDText.DefaultText = "";
            this.barProIDText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.barProIDText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.barProIDText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barProIDText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barProIDText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barProIDText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barProIDText.ForeColor = System.Drawing.Color.Black;
            this.barProIDText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barProIDText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.barProIDText.Location = new System.Drawing.Point(18, 47);
            this.barProIDText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barProIDText.Name = "barProIDText";
            this.barProIDText.PasswordChar = '\0';
            this.barProIDText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.barProIDText.PlaceholderText = "Product ID";
            this.barProIDText.SelectedText = "";
            this.barProIDText.Size = new System.Drawing.Size(107, 42);
            this.barProIDText.TabIndex = 10;
            this.barProIDText.TextChanged += new System.EventHandler(this.barProIDText_TextChanged);
            // 
            // barProIDLabel
            // 
            this.barProIDLabel.AutoSize = true;
            this.barProIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.barProIDLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barProIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.barProIDLabel.Location = new System.Drawing.Point(16, 18);
            this.barProIDLabel.Name = "barProIDLabel";
            this.barProIDLabel.Size = new System.Drawing.Size(98, 23);
            this.barProIDLabel.TabIndex = 25;
            this.barProIDLabel.Text = "Product ID:";
            // 
            // barProNameText
            // 
            this.barProNameText.BackColor = System.Drawing.Color.Transparent;
            this.barProNameText.BorderRadius = 8;
            this.barProNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barProNameText.DefaultText = "";
            this.barProNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.barProNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.barProNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barProNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barProNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barProNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barProNameText.ForeColor = System.Drawing.Color.Black;
            this.barProNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barProNameText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.barProNameText.Location = new System.Drawing.Point(144, 47);
            this.barProNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barProNameText.Name = "barProNameText";
            this.barProNameText.PasswordChar = '\0';
            this.barProNameText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.barProNameText.PlaceholderText = "Product Name";
            this.barProNameText.SelectedText = "";
            this.barProNameText.Size = new System.Drawing.Size(291, 42);
            this.barProNameText.TabIndex = 63;
            this.barProNameText.TextChanged += new System.EventHandler(this.barProNameText_TextChanged);
            // 
            // barProNameLabel
            // 
            this.barProNameLabel.AutoSize = true;
            this.barProNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.barProNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barProNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.barProNameLabel.Location = new System.Drawing.Point(142, 18);
            this.barProNameLabel.Name = "barProNameLabel";
            this.barProNameLabel.Size = new System.Drawing.Size(125, 23);
            this.barProNameLabel.TabIndex = 64;
            this.barProNameLabel.Text = "Product Name:";
            // 
            // barQuantityLabel
            // 
            this.barQuantityLabel.AutoSize = true;
            this.barQuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.barQuantityLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.barQuantityLabel.Location = new System.Drawing.Point(629, 19);
            this.barQuantityLabel.Name = "barQuantityLabel";
            this.barQuantityLabel.Size = new System.Drawing.Size(83, 23);
            this.barQuantityLabel.TabIndex = 78;
            this.barQuantityLabel.Text = "Quantity:";
            // 
            // barQuantityText
            // 
            this.barQuantityText.BackColor = System.Drawing.Color.Transparent;
            this.barQuantityText.BorderRadius = 8;
            this.barQuantityText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barQuantityText.DefaultText = "";
            this.barQuantityText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.barQuantityText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.barQuantityText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barQuantityText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barQuantityText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barQuantityText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barQuantityText.ForeColor = System.Drawing.Color.Black;
            this.barQuantityText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barQuantityText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.barQuantityText.Location = new System.Drawing.Point(631, 47);
            this.barQuantityText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barQuantityText.Name = "barQuantityText";
            this.barQuantityText.PasswordChar = '\0';
            this.barQuantityText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.barQuantityText.PlaceholderText = "Quantity";
            this.barQuantityText.SelectedText = "";
            this.barQuantityText.Size = new System.Drawing.Size(118, 42);
            this.barQuantityText.TabIndex = 79;
            this.barQuantityText.TextChanged += new System.EventHandler(this.barQuantityText_TextChanged);
            // 
            // barStartRangeText
            // 
            this.barStartRangeText.BackColor = System.Drawing.Color.Transparent;
            this.barStartRangeText.BorderRadius = 8;
            this.barStartRangeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barStartRangeText.DefaultText = "";
            this.barStartRangeText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.barStartRangeText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.barStartRangeText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barStartRangeText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barStartRangeText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barStartRangeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStartRangeText.ForeColor = System.Drawing.Color.Black;
            this.barStartRangeText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barStartRangeText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.barStartRangeText.Location = new System.Drawing.Point(375, 143);
            this.barStartRangeText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barStartRangeText.Name = "barStartRangeText";
            this.barStartRangeText.PasswordChar = '\0';
            this.barStartRangeText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.barStartRangeText.PlaceholderText = "Started Serial Number";
            this.barStartRangeText.SelectedText = "";
            this.barStartRangeText.Size = new System.Drawing.Size(252, 42);
            this.barStartRangeText.TabIndex = 81;
            this.barStartRangeText.TextChanged += new System.EventHandler(this.barStartRangeText_TextChanged);
            // 
            // barStartRangeLabel
            // 
            this.barStartRangeLabel.AutoSize = true;
            this.barStartRangeLabel.BackColor = System.Drawing.Color.Transparent;
            this.barStartRangeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStartRangeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.barStartRangeLabel.Location = new System.Drawing.Point(307, 146);
            this.barStartRangeLabel.Name = "barStartRangeLabel";
            this.barStartRangeLabel.Size = new System.Drawing.Size(52, 23);
            this.barStartRangeLabel.TabIndex = 80;
            this.barStartRangeLabel.Text = "Start:";
            // 
            // barEndRangeText
            // 
            this.barEndRangeText.BackColor = System.Drawing.Color.Transparent;
            this.barEndRangeText.BorderRadius = 8;
            this.barEndRangeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barEndRangeText.DefaultText = "";
            this.barEndRangeText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.barEndRangeText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.barEndRangeText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barEndRangeText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barEndRangeText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barEndRangeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barEndRangeText.ForeColor = System.Drawing.Color.Black;
            this.barEndRangeText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barEndRangeText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.barEndRangeText.Location = new System.Drawing.Point(375, 196);
            this.barEndRangeText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barEndRangeText.Name = "barEndRangeText";
            this.barEndRangeText.PasswordChar = '\0';
            this.barEndRangeText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.barEndRangeText.PlaceholderText = "Ended Serial Number";
            this.barEndRangeText.SelectedText = "";
            this.barEndRangeText.Size = new System.Drawing.Size(252, 42);
            this.barEndRangeText.TabIndex = 83;
            this.barEndRangeText.TextChanged += new System.EventHandler(this.barEndRangeText_TextChanged);
            // 
            // barEndRangeLabel
            // 
            this.barEndRangeLabel.AutoSize = true;
            this.barEndRangeLabel.BackColor = System.Drawing.Color.Transparent;
            this.barEndRangeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barEndRangeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.barEndRangeLabel.Location = new System.Drawing.Point(307, 196);
            this.barEndRangeLabel.Name = "barEndRangeLabel";
            this.barEndRangeLabel.Size = new System.Drawing.Size(44, 23);
            this.barEndRangeLabel.TabIndex = 82;
            this.barEndRangeLabel.Text = "End:";
            // 
            // barDataGridView
            // 
            this.barDataGridView.AllowUserToAddRows = false;
            this.barDataGridView.AllowUserToDeleteRows = false;
            this.barDataGridView.AllowUserToResizeColumns = false;
            this.barDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.barDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.barDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.barDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.barDataGridView.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.barDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.barDataGridView.GridColor = System.Drawing.Color.White;
            this.barDataGridView.Location = new System.Drawing.Point(12, 383);
            this.barDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.barDataGridView.Name = "barDataGridView";
            this.barDataGridView.ReadOnly = true;
            this.barDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.barDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.barDataGridView.RowHeadersVisible = false;
            this.barDataGridView.RowHeadersWidth = 22;
            this.barDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.barDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.barDataGridView.RowTemplate.Height = 35;
            this.barDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.barDataGridView.Size = new System.Drawing.Size(770, 237);
            this.barDataGridView.TabIndex = 84;
            this.barDataGridView.Theme = Siticone.Desktop.UI.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.barDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.barDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.barDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.barDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.barDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.barDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.barDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.barDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.barDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.barDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.barDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.barDataGridView.ThemeStyle.ReadOnly = true;
            this.barDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.barDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.barDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.barDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.barDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.barDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.barDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barDataGridView_CellContentClick);
            // 
            // barcodeSaveBtn
            // 
            this.barcodeSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeSaveBtn.Animated = true;
            this.barcodeSaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.barcodeSaveBtn.BorderRadius = 8;
            this.barcodeSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.barcodeSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.barcodeSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.barcodeSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.barcodeSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.barcodeSaveBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeSaveBtn.ForeColor = System.Drawing.Color.White;
            this.barcodeSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.barcodeSaveBtn.Location = new System.Drawing.Point(575, 638);
            this.barcodeSaveBtn.Name = "barcodeSaveBtn";
            this.barcodeSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.barcodeSaveBtn.TabIndex = 85;
            this.barcodeSaveBtn.Text = "Save";
            this.barcodeSaveBtn.Click += new System.EventHandler(this.barcodeSaveBtn_Click);
            // 
            // barcodeCancelBtn
            // 
            this.barcodeCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeCancelBtn.Animated = true;
            this.barcodeCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.barcodeCancelBtn.BorderRadius = 8;
            this.barcodeCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.barcodeCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.barcodeCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.barcodeCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.barcodeCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.barcodeCancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeCancelBtn.ForeColor = System.Drawing.Color.White;
            this.barcodeCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.barcodeCancelBtn.Location = new System.Drawing.Point(687, 638);
            this.barcodeCancelBtn.Name = "barcodeCancelBtn";
            this.barcodeCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.barcodeCancelBtn.TabIndex = 86;
            this.barcodeCancelBtn.Text = "Cancel";
            this.barcodeCancelBtn.Click += new System.EventHandler(this.barcodeCancelBtn_Click);
            // 
            // barAddToListBtn
            // 
            this.barAddToListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.barAddToListBtn.Animated = true;
            this.barAddToListBtn.BackColor = System.Drawing.Color.Transparent;
            this.barAddToListBtn.BorderRadius = 8;
            this.barAddToListBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.barAddToListBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.barAddToListBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.barAddToListBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.barAddToListBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.barAddToListBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barAddToListBtn.ForeColor = System.Drawing.Color.White;
            this.barAddToListBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.barAddToListBtn.Location = new System.Drawing.Point(623, 254);
            this.barAddToListBtn.Name = "barAddToListBtn";
            this.barAddToListBtn.Size = new System.Drawing.Size(126, 45);
            this.barAddToListBtn.TabIndex = 87;
            this.barAddToListBtn.Text = "Add to List";
            this.barAddToListBtn.Click += new System.EventHandler(this.barAddToListBtn_Click);
            // 
            // barSingleText
            // 
            this.barSingleText.BackColor = System.Drawing.Color.Transparent;
            this.barSingleText.BorderRadius = 8;
            this.barSingleText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barSingleText.DefaultText = "";
            this.barSingleText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.barSingleText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.barSingleText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barSingleText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barSingleText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barSingleText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barSingleText.ForeColor = System.Drawing.Color.Black;
            this.barSingleText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barSingleText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.barSingleText.Location = new System.Drawing.Point(18, 135);
            this.barSingleText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barSingleText.Name = "barSingleText";
            this.barSingleText.PasswordChar = '\0';
            this.barSingleText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.barSingleText.PlaceholderText = "Single Serial Number";
            this.barSingleText.SelectedText = "";
            this.barSingleText.Size = new System.Drawing.Size(252, 42);
            this.barSingleText.TabIndex = 89;
            this.barSingleText.TextChanged += new System.EventHandler(this.barSingleText_TextChanged);
            // 
            // barSingleLabel
            // 
            this.barSingleLabel.AutoSize = true;
            this.barSingleLabel.BackColor = System.Drawing.Color.Transparent;
            this.barSingleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barSingleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.barSingleLabel.Location = new System.Drawing.Point(16, 106);
            this.barSingleLabel.Name = "barSingleLabel";
            this.barSingleLabel.Size = new System.Drawing.Size(130, 23);
            this.barSingleLabel.TabIndex = 88;
            this.barSingleLabel.Text = "For Single Item:";
            // 
            // checkRange
            // 
            this.checkRange.AutoSize = true;
            this.checkRange.CheckedState.BorderColor = System.Drawing.Color.White;
            this.checkRange.CheckedState.BorderRadius = 5;
            this.checkRange.CheckedState.BorderThickness = 1;
            this.checkRange.CheckedState.FillColor = System.Drawing.Color.ForestGreen;
            this.checkRange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRange.Location = new System.Drawing.Point(311, 107);
            this.checkRange.Name = "checkRange";
            this.checkRange.Size = new System.Drawing.Size(145, 25);
            this.checkRange.TabIndex = 90;
            this.checkRange.Text = "Available Range";
            this.checkRange.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkRange.UncheckedState.BorderRadius = 5;
            this.checkRange.UncheckedState.BorderThickness = 1;
            this.checkRange.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkRange.CheckedChanged += new System.EventHandler(this.checkRange_CheckedChanged);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 34);
            this.headerPanel.TabIndex = 91;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.minimumBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(707, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(93, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // minimumBtn
            // 
            this.minimumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumBtn.BorderRadius = 8;
            this.minimumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimumBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minimumBtn.IconColor = System.Drawing.Color.White;
            this.minimumBtn.Location = new System.Drawing.Point(15, 2);
            this.minimumBtn.Name = "minimumBtn";
            this.minimumBtn.Size = new System.Drawing.Size(26, 26);
            this.minimumBtn.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(46, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 26);
            this.closeBtn.TabIndex = 0;
            // 
            // addBarcodeBorderlessForm
            // 
            this.addBarcodeBorderlessForm.BorderRadius = 25;
            this.addBarcodeBorderlessForm.ContainerControl = this;
            this.addBarcodeBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.addBarcodeBorderlessForm.TransparentWhileDrag = true;
            // 
            // detailsPanel
            // 
            this.detailsPanel.BackColor = System.Drawing.Color.Transparent;
            this.detailsPanel.BorderRadius = 8;
            this.detailsPanel.Controls.Add(this.barProIDLabel);
            this.detailsPanel.Controls.Add(this.barAddToListBtn);
            this.detailsPanel.Controls.Add(this.checkRange);
            this.detailsPanel.Controls.Add(this.barProIDText);
            this.detailsPanel.Controls.Add(this.barEndRangeText);
            this.detailsPanel.Controls.Add(this.barSingleText);
            this.detailsPanel.Controls.Add(this.barEndRangeLabel);
            this.detailsPanel.Controls.Add(this.barProNameLabel);
            this.detailsPanel.Controls.Add(this.barSingleLabel);
            this.detailsPanel.Controls.Add(this.barProNameText);
            this.detailsPanel.Controls.Add(this.barStartRangeText);
            this.detailsPanel.Controls.Add(this.barVarTypLabel);
            this.detailsPanel.Controls.Add(this.barVarTypCombo);
            this.detailsPanel.Controls.Add(this.barQuantityLabel);
            this.detailsPanel.Controls.Add(this.barStartRangeLabel);
            this.detailsPanel.Controls.Add(this.barQuantityText);
            this.detailsPanel.FillColor = System.Drawing.Color.White;
            this.detailsPanel.Location = new System.Drawing.Point(12, 55);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(767, 310);
            this.detailsPanel.TabIndex = 92;
            // 
            // barVarTypLabel
            // 
            this.barVarTypLabel.AutoSize = true;
            this.barVarTypLabel.BackColor = System.Drawing.Color.Transparent;
            this.barVarTypLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barVarTypLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.barVarTypLabel.Location = new System.Drawing.Point(455, 19);
            this.barVarTypLabel.Name = "barVarTypLabel";
            this.barVarTypLabel.Size = new System.Drawing.Size(125, 23);
            this.barVarTypLabel.TabIndex = 75;
            this.barVarTypLabel.Text = "Variation Type:";
            // 
            // barVarTypCombo
            // 
            this.barVarTypCombo.BackColor = System.Drawing.Color.Transparent;
            this.barVarTypCombo.BorderRadius = 8;
            this.barVarTypCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.barVarTypCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barVarTypCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barVarTypCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barVarTypCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barVarTypCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.barVarTypCombo.ItemHeight = 36;
            this.barVarTypCombo.Items.AddRange(new object[] {
            "Variation Type",
            "CocaCola",
            "Manchee",
            "Maliban"});
            this.barVarTypCombo.Location = new System.Drawing.Point(457, 47);
            this.barVarTypCombo.Name = "barVarTypCombo";
            this.barVarTypCombo.Size = new System.Drawing.Size(150, 42);
            this.barVarTypCombo.StartIndex = 0;
            this.barVarTypCombo.TabIndex = 76;
            this.barVarTypCombo.SelectedIndexChanged += new System.EventHandler(this.barVarTypCombo_SelectedIndexChanged);
            // 
            // AddBarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.barcodeCancelBtn);
            this.Controls.Add(this.barcodeSaveBtn);
            this.Controls.Add(this.barDataGridView);
            this.Controls.Add(this.detailsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBarcodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Searial Numbers";
            this.Load += new System.EventHandler(this.AddBarcodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barDataGridView)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox barProIDText;
        private System.Windows.Forms.Label barProIDLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox barProNameText;
        private System.Windows.Forms.Label barProNameLabel;
        private System.Windows.Forms.Label barQuantityLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox barQuantityText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox barStartRangeText;
        private System.Windows.Forms.Label barStartRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox barEndRangeText;
        private System.Windows.Forms.Label barEndRangeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView barDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneButton barcodeSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton barcodeCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton barAddToListBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox barSingleText;
        private System.Windows.Forms.Label barSingleLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox checkRange;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm addBarcodeBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel detailsPanel;
        private System.Windows.Forms.Label barVarTypLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox barVarTypCombo;
    }
}