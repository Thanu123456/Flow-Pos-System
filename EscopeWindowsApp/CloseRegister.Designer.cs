namespace EscopeWindowsApp
{
    partial class CloseRegister
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
            this.closeRegBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.detailsPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.DetailsTable = new System.Windows.Forms.TableLayoutPanel();
            this.cardLabel = new System.Windows.Forms.Label();
            this.cardAmount = new System.Windows.Forms.Label();
            this.cashLabel = new System.Windows.Forms.Label();
            this.cashAmount = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.cashInHandAmount = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.cashInHandLabel = new System.Windows.Forms.Label();
            this.cashRegDateLable = new System.Windows.Forms.Label();
            this.cashRegDetailsLabel = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.subTotLabel = new System.Windows.Forms.Label();
            this.subTotAmount = new System.Windows.Forms.Label();
            this.totRefundLabel = new System.Windows.Forms.Label();
            this.totRefAmount = new System.Windows.Forms.Label();
            this.totSaleAmount = new System.Windows.Forms.Label();
            this.totSaleLabel = new System.Windows.Forms.Label();
            this.closetotcashPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.noteLabel = new System.Windows.Forms.Label();
            this.noteText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.totCashLabel = new System.Windows.Forms.Label();
            this.totCashText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.closeRegBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.closeRegCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.DetailsTable.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.closetotcashPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeRegBorderlessForm
            // 
            this.closeRegBorderlessForm.BorderRadius = 25;
            this.closeRegBorderlessForm.ContainerControl = this;
            this.closeRegBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.closeRegBorderlessForm.TransparentWhileDrag = true;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(429, 34);
            this.headerPanel.TabIndex = 29;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(337, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(92, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(45, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 26);
            this.closeBtn.TabIndex = 0;
            // 
            // detailsPanel
            // 
            this.detailsPanel.BackColor = System.Drawing.Color.Transparent;
            this.detailsPanel.BorderRadius = 8;
            this.detailsPanel.Controls.Add(this.DetailsTable);
            this.detailsPanel.FillColor = System.Drawing.Color.White;
            this.detailsPanel.Location = new System.Drawing.Point(23, 92);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(380, 174);
            this.detailsPanel.TabIndex = 34;
            // 
            // DetailsTable
            // 
            this.DetailsTable.ColumnCount = 2;
            this.DetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DetailsTable.Controls.Add(this.cardLabel, 0, 3);
            this.DetailsTable.Controls.Add(this.cardAmount, 1, 3);
            this.DetailsTable.Controls.Add(this.cashLabel, 0, 2);
            this.DetailsTable.Controls.Add(this.cashAmount, 1, 2);
            this.DetailsTable.Controls.Add(this.paymentTypeLabel, 0, 0);
            this.DetailsTable.Controls.Add(this.cashInHandAmount, 1, 1);
            this.DetailsTable.Controls.Add(this.amountLabel, 1, 0);
            this.DetailsTable.Controls.Add(this.cashInHandLabel, 0, 1);
            this.DetailsTable.Location = new System.Drawing.Point(17, 20);
            this.DetailsTable.Margin = new System.Windows.Forms.Padding(0);
            this.DetailsTable.Name = "DetailsTable";
            this.DetailsTable.RowCount = 4;
            this.DetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.DetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.DetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.DetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.DetailsTable.Size = new System.Drawing.Size(335, 151);
            this.DetailsTable.TabIndex = 36;
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardLabel.Location = new System.Drawing.Point(3, 113);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(50, 21);
            this.cardLabel.TabIndex = 39;
            this.cardLabel.Text = "Card :";
            // 
            // cardAmount
            // 
            this.cardAmount.AutoSize = true;
            this.cardAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardAmount.Location = new System.Drawing.Point(170, 113);
            this.cardAmount.Name = "cardAmount";
            this.cardAmount.Size = new System.Drawing.Size(67, 21);
            this.cardAmount.TabIndex = 38;
            this.cardAmount.Text = "0000.00";
            this.cardAmount.Click += new System.EventHandler(this.cardAmount_Click);
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.Location = new System.Drawing.Point(3, 78);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(51, 21);
            this.cashLabel.TabIndex = 37;
            this.cashLabel.Text = "Cash :";
            // 
            // cashAmount
            // 
            this.cashAmount.AutoSize = true;
            this.cashAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashAmount.Location = new System.Drawing.Point(170, 78);
            this.cashAmount.Name = "cashAmount";
            this.cashAmount.Size = new System.Drawing.Size(67, 21);
            this.cashAmount.TabIndex = 36;
            this.cashAmount.Text = "0000.00";
            this.cashAmount.Click += new System.EventHandler(this.cashAmount_Click);
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeLabel.Location = new System.Drawing.Point(3, 0);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(132, 25);
            this.paymentTypeLabel.TabIndex = 32;
            this.paymentTypeLabel.Text = "Payment Type";
            // 
            // cashInHandAmount
            // 
            this.cashInHandAmount.AutoSize = true;
            this.cashInHandAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashInHandAmount.Location = new System.Drawing.Point(170, 43);
            this.cashInHandAmount.Name = "cashInHandAmount";
            this.cashInHandAmount.Size = new System.Drawing.Size(67, 21);
            this.cashInHandAmount.TabIndex = 35;
            this.cashInHandAmount.Text = "0000.00";
            this.cashInHandAmount.Click += new System.EventHandler(this.cashInHandAmount_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(170, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(82, 25);
            this.amountLabel.TabIndex = 33;
            this.amountLabel.Text = "Amount";
            // 
            // cashInHandLabel
            // 
            this.cashInHandLabel.AutoSize = true;
            this.cashInHandLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashInHandLabel.Location = new System.Drawing.Point(3, 43);
            this.cashInHandLabel.Name = "cashInHandLabel";
            this.cashInHandLabel.Size = new System.Drawing.Size(109, 21);
            this.cashInHandLabel.TabIndex = 34;
            this.cashInHandLabel.Text = "Cash In Hand :";
            // 
            // cashRegDateLable
            // 
            this.cashRegDateLable.AutoSize = true;
            this.cashRegDateLable.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRegDateLable.Location = new System.Drawing.Point(169, 50);
            this.cashRegDateLable.Name = "cashRegDateLable";
            this.cashRegDateLable.Size = new System.Drawing.Size(53, 25);
            this.cashRegDateLable.TabIndex = 33;
            this.cashRegDateLable.Text = "Date";
            this.cashRegDateLable.Click += new System.EventHandler(this.cashRegDateLable_Click);
            // 
            // cashRegDetailsLabel
            // 
            this.cashRegDetailsLabel.AutoSize = true;
            this.cashRegDetailsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRegDetailsLabel.Location = new System.Drawing.Point(18, 50);
            this.cashRegDetailsLabel.Name = "cashRegDetailsLabel";
            this.cashRegDetailsLabel.Size = new System.Drawing.Size(150, 25);
            this.cashRegDetailsLabel.TabIndex = 32;
            this.cashRegDetailsLabel.Text = "Register Details:";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.BorderRadius = 8;
            this.siticonePanel1.Controls.Add(this.tableLayoutPanel1);
            this.siticonePanel1.FillColor = System.Drawing.Color.White;
            this.siticonePanel1.Location = new System.Drawing.Point(23, 272);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(380, 138);
            this.siticonePanel1.TabIndex = 38;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.subTotLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.subTotAmount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.totRefundLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.totRefAmount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.totSaleAmount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.totSaleLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(335, 116);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // subTotLabel
            // 
            this.subTotLabel.AutoSize = true;
            this.subTotLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotLabel.Location = new System.Drawing.Point(3, 76);
            this.subTotLabel.Name = "subTotLabel";
            this.subTotLabel.Size = new System.Drawing.Size(85, 21);
            this.subTotLabel.TabIndex = 39;
            this.subTotLabel.Text = "Sub Total :";
            // 
            // subTotAmount
            // 
            this.subTotAmount.AutoSize = true;
            this.subTotAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotAmount.Location = new System.Drawing.Point(170, 76);
            this.subTotAmount.Name = "subTotAmount";
            this.subTotAmount.Size = new System.Drawing.Size(68, 21);
            this.subTotAmount.TabIndex = 38;
            this.subTotAmount.Text = "0000.00";
            this.subTotAmount.Click += new System.EventHandler(this.subTotAmount_Click);
            // 
            // totRefundLabel
            // 
            this.totRefundLabel.AutoSize = true;
            this.totRefundLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totRefundLabel.Location = new System.Drawing.Point(3, 38);
            this.totRefundLabel.Name = "totRefundLabel";
            this.totRefundLabel.Size = new System.Drawing.Size(110, 21);
            this.totRefundLabel.TabIndex = 37;
            this.totRefundLabel.Text = "Total Refund :";
            // 
            // totRefAmount
            // 
            this.totRefAmount.AutoSize = true;
            this.totRefAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totRefAmount.Location = new System.Drawing.Point(170, 38);
            this.totRefAmount.Name = "totRefAmount";
            this.totRefAmount.Size = new System.Drawing.Size(68, 21);
            this.totRefAmount.TabIndex = 36;
            this.totRefAmount.Text = "0000.00";
            this.totRefAmount.Click += new System.EventHandler(this.totRefAmount_Click);
            // 
            // totSaleAmount
            // 
            this.totSaleAmount.AutoSize = true;
            this.totSaleAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totSaleAmount.Location = new System.Drawing.Point(170, 0);
            this.totSaleAmount.Name = "totSaleAmount";
            this.totSaleAmount.Size = new System.Drawing.Size(68, 21);
            this.totSaleAmount.TabIndex = 35;
            this.totSaleAmount.Text = "0000.00";
            this.totSaleAmount.Click += new System.EventHandler(this.totSaleAmount_Click);
            // 
            // totSaleLabel
            // 
            this.totSaleLabel.AutoSize = true;
            this.totSaleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totSaleLabel.Location = new System.Drawing.Point(3, 0);
            this.totSaleLabel.Name = "totSaleLabel";
            this.totSaleLabel.Size = new System.Drawing.Size(94, 21);
            this.totSaleLabel.TabIndex = 34;
            this.totSaleLabel.Text = "Total Sales :";
            // 
            // closetotcashPanel
            // 
            this.closetotcashPanel.BackColor = System.Drawing.Color.Transparent;
            this.closetotcashPanel.BorderRadius = 8;
            this.closetotcashPanel.Controls.Add(this.noteLabel);
            this.closetotcashPanel.Controls.Add(this.noteText);
            this.closetotcashPanel.Controls.Add(this.totCashLabel);
            this.closetotcashPanel.Controls.Add(this.totCashText);
            this.closetotcashPanel.FillColor = System.Drawing.Color.White;
            this.closetotcashPanel.Location = new System.Drawing.Point(23, 425);
            this.closetotcashPanel.Name = "closetotcashPanel";
            this.closetotcashPanel.Size = new System.Drawing.Size(380, 179);
            this.closetotcashPanel.TabIndex = 39;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.BackColor = System.Drawing.Color.Transparent;
            this.noteLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.noteLabel.Location = new System.Drawing.Point(22, 91);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(57, 25);
            this.noteLabel.TabIndex = 68;
            this.noteLabel.Text = "Note:";
            // 
            // noteText
            // 
            this.noteText.BackColor = System.Drawing.Color.Transparent;
            this.noteText.BorderRadius = 8;
            this.noteText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noteText.DefaultText = "";
            this.noteText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.noteText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.noteText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.noteText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.noteText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noteText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteText.ForeColor = System.Drawing.Color.Black;
            this.noteText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noteText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.noteText.Location = new System.Drawing.Point(26, 120);
            this.noteText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.noteText.Name = "noteText";
            this.noteText.PasswordChar = '\0';
            this.noteText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.noteText.PlaceholderText = "Note";
            this.noteText.SelectedText = "";
            this.noteText.Size = new System.Drawing.Size(328, 42);
            this.noteText.TabIndex = 67;
            this.noteText.TextChanged += new System.EventHandler(this.noteText_TextChanged);
            // 
            // totCashLabel
            // 
            this.totCashLabel.AutoSize = true;
            this.totCashLabel.BackColor = System.Drawing.Color.Transparent;
            this.totCashLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totCashLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.totCashLabel.Location = new System.Drawing.Point(20, 12);
            this.totCashLabel.Name = "totCashLabel";
            this.totCashLabel.Size = new System.Drawing.Size(102, 25);
            this.totCashLabel.TabIndex = 66;
            this.totCashLabel.Text = "Total Cash:";
            // 
            // totCashText
            // 
            this.totCashText.BackColor = System.Drawing.Color.Transparent;
            this.totCashText.BorderRadius = 8;
            this.totCashText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totCashText.DefaultText = "";
            this.totCashText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totCashText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totCashText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totCashText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totCashText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totCashText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totCashText.ForeColor = System.Drawing.Color.Black;
            this.totCashText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totCashText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.totCashText.Location = new System.Drawing.Point(24, 41);
            this.totCashText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totCashText.Name = "totCashText";
            this.totCashText.PasswordChar = '\0';
            this.totCashText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.totCashText.PlaceholderText = "Total Cash";
            this.totCashText.SelectedText = "";
            this.totCashText.Size = new System.Drawing.Size(328, 42);
            this.totCashText.TabIndex = 65;
            this.totCashText.TextChanged += new System.EventHandler(this.totCashText_TextChanged);
            // 
            // closeRegBtn
            // 
            this.closeRegBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeRegBtn.Animated = true;
            this.closeRegBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeRegBtn.BorderRadius = 8;
            this.closeRegBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeRegBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeRegBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeRegBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeRegBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeRegBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeRegBtn.ForeColor = System.Drawing.Color.White;
            this.closeRegBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.closeRegBtn.Location = new System.Drawing.Point(247, 625);
            this.closeRegBtn.Name = "closeRegBtn";
            this.closeRegBtn.Size = new System.Drawing.Size(157, 45);
            this.closeRegBtn.TabIndex = 41;
            this.closeRegBtn.Text = "Close Register";
            this.closeRegBtn.Click += new System.EventHandler(this.closeRegBtn_Click);
            // 
            // closeRegCancelBtn
            // 
            this.closeRegCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeRegCancelBtn.Animated = true;
            this.closeRegCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeRegCancelBtn.BorderRadius = 8;
            this.closeRegCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeRegCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeRegCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeRegCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeRegCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.closeRegCancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeRegCancelBtn.ForeColor = System.Drawing.Color.White;
            this.closeRegCancelBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.closeRegCancelBtn.Location = new System.Drawing.Point(142, 625);
            this.closeRegCancelBtn.Name = "closeRegCancelBtn";
            this.closeRegCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.closeRegCancelBtn.TabIndex = 40;
            this.closeRegCancelBtn.Text = "Cancel";
            this.closeRegCancelBtn.Click += new System.EventHandler(this.closeRegCancelBtn_Click);
            // 
            // CloseRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 702);
            this.Controls.Add(this.closeRegBtn);
            this.Controls.Add(this.closeRegCancelBtn);
            this.Controls.Add(this.closetotcashPanel);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.cashRegDateLable);
            this.Controls.Add(this.cashRegDetailsLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CloseRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloseRegister";
            this.Load += new System.EventHandler(this.CloseRegister_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.detailsPanel.ResumeLayout(false);
            this.DetailsTable.ResumeLayout(false);
            this.DetailsTable.PerformLayout();
            this.siticonePanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.closetotcashPanel.ResumeLayout(false);
            this.closetotcashPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm closeRegBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel detailsPanel;
        private System.Windows.Forms.TableLayoutPanel DetailsTable;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label cardAmount;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label cashAmount;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Label cashInHandAmount;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label cashInHandLabel;
        private System.Windows.Forms.Label cashRegDateLable;
        private System.Windows.Forms.Label cashRegDetailsLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label subTotLabel;
        private System.Windows.Forms.Label subTotAmount;
        private System.Windows.Forms.Label totRefundLabel;
        private System.Windows.Forms.Label totRefAmount;
        private System.Windows.Forms.Label totSaleAmount;
        private System.Windows.Forms.Label totSaleLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel closetotcashPanel;
        private System.Windows.Forms.Label noteLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox noteText;
        private System.Windows.Forms.Label totCashLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox totCashText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton closeRegBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton closeRegCancelBtn;
    }
}