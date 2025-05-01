namespace EscopeWindowsApp
{
    partial class CashBookDetails
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
            this.cashDetailsBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.cashRegDetailsLabel = new System.Windows.Forms.Label();
            this.cashRegDateLable = new System.Windows.Forms.Label();
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.subTotLabel = new System.Windows.Forms.Label();
            this.subTotAmount = new System.Windows.Forms.Label();
            this.totRefundLabel = new System.Windows.Forms.Label();
            this.totRefAmount = new System.Windows.Forms.Label();
            this.totSaleAmount = new System.Windows.Forms.Label();
            this.totSaleLabel = new System.Windows.Forms.Label();
            this.cashbookDetailsCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cashBookPrintBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.DetailsTable.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashDetailsBorderlessForm
            // 
            this.cashDetailsBorderlessForm.BorderRadius = 25;
            this.cashDetailsBorderlessForm.ContainerControl = this;
            this.cashDetailsBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.cashDetailsBorderlessForm.TransparentWhileDrag = true;
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
            this.headerPanel.TabIndex = 28;
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
            // cashRegDetailsLabel
            // 
            this.cashRegDetailsLabel.AutoSize = true;
            this.cashRegDetailsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRegDetailsLabel.Location = new System.Drawing.Point(18, 50);
            this.cashRegDetailsLabel.Name = "cashRegDetailsLabel";
            this.cashRegDetailsLabel.Size = new System.Drawing.Size(142, 23);
            this.cashRegDetailsLabel.TabIndex = 29;
            this.cashRegDetailsLabel.Text = "Register Details:";
            // 
            // cashRegDateLable
            // 
            this.cashRegDateLable.AutoSize = true;
            this.cashRegDateLable.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRegDateLable.Location = new System.Drawing.Point(169, 50);
            this.cashRegDateLable.Name = "cashRegDateLable";
            this.cashRegDateLable.Size = new System.Drawing.Size(48, 23);
            this.cashRegDateLable.TabIndex = 30;
            this.cashRegDateLable.Text = "Date";
            this.cashRegDateLable.Click += new System.EventHandler(this.cashRegDateLable_Click);
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
            this.detailsPanel.TabIndex = 31;
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
            this.cardLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardLabel.Location = new System.Drawing.Point(3, 113);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(47, 19);
            this.cardLabel.TabIndex = 39;
            this.cardLabel.Text = "Card :";
            // 
            // cardAmount
            // 
            this.cardAmount.AutoSize = true;
            this.cardAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardAmount.Location = new System.Drawing.Point(170, 113);
            this.cardAmount.Name = "cardAmount";
            this.cardAmount.Size = new System.Drawing.Size(61, 19);
            this.cardAmount.TabIndex = 38;
            this.cardAmount.Text = "0000.00";
            this.cardAmount.Click += new System.EventHandler(this.cardAmount_Click);
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.Location = new System.Drawing.Point(3, 78);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(49, 19);
            this.cashLabel.TabIndex = 37;
            this.cashLabel.Text = "Cash :";
            // 
            // cashAmount
            // 
            this.cashAmount.AutoSize = true;
            this.cashAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashAmount.Location = new System.Drawing.Point(170, 78);
            this.cashAmount.Name = "cashAmount";
            this.cashAmount.Size = new System.Drawing.Size(61, 19);
            this.cashAmount.TabIndex = 36;
            this.cashAmount.Text = "0000.00";
            this.cashAmount.Click += new System.EventHandler(this.cashAmount_Click);
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeLabel.Location = new System.Drawing.Point(3, 0);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(121, 23);
            this.paymentTypeLabel.TabIndex = 32;
            this.paymentTypeLabel.Text = "Payment Type";
            // 
            // cashInHandAmount
            // 
            this.cashInHandAmount.AutoSize = true;
            this.cashInHandAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashInHandAmount.Location = new System.Drawing.Point(170, 43);
            this.cashInHandAmount.Name = "cashInHandAmount";
            this.cashInHandAmount.Size = new System.Drawing.Size(61, 19);
            this.cashInHandAmount.TabIndex = 35;
            this.cashInHandAmount.Text = "0000.00";
            this.cashInHandAmount.Click += new System.EventHandler(this.cashInHandAmount_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(170, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(74, 23);
            this.amountLabel.TabIndex = 33;
            this.amountLabel.Text = "Amount";
            // 
            // cashInHandLabel
            // 
            this.cashInHandLabel.AutoSize = true;
            this.cashInHandLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashInHandLabel.Location = new System.Drawing.Point(3, 43);
            this.cashInHandLabel.Name = "cashInHandLabel";
            this.cashInHandLabel.Size = new System.Drawing.Size(103, 19);
            this.cashInHandLabel.TabIndex = 34;
            this.cashInHandLabel.Text = "Cash In Hand :";
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
            this.siticonePanel1.TabIndex = 37;
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
            this.subTotLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotLabel.Location = new System.Drawing.Point(3, 76);
            this.subTotLabel.Name = "subTotLabel";
            this.subTotLabel.Size = new System.Drawing.Size(81, 19);
            this.subTotLabel.TabIndex = 39;
            this.subTotLabel.Text = "Sub Total :";
            // 
            // subTotAmount
            // 
            this.subTotAmount.AutoSize = true;
            this.subTotAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotAmount.Location = new System.Drawing.Point(170, 76);
            this.subTotAmount.Name = "subTotAmount";
            this.subTotAmount.Size = new System.Drawing.Size(61, 19);
            this.subTotAmount.TabIndex = 38;
            this.subTotAmount.Text = "0000.00";
            this.subTotAmount.Click += new System.EventHandler(this.subTotAmount_Click);
            // 
            // totRefundLabel
            // 
            this.totRefundLabel.AutoSize = true;
            this.totRefundLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totRefundLabel.Location = new System.Drawing.Point(3, 38);
            this.totRefundLabel.Name = "totRefundLabel";
            this.totRefundLabel.Size = new System.Drawing.Size(104, 19);
            this.totRefundLabel.TabIndex = 37;
            this.totRefundLabel.Text = "Total Refund :";
            // 
            // totRefAmount
            // 
            this.totRefAmount.AutoSize = true;
            this.totRefAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totRefAmount.Location = new System.Drawing.Point(170, 38);
            this.totRefAmount.Name = "totRefAmount";
            this.totRefAmount.Size = new System.Drawing.Size(61, 19);
            this.totRefAmount.TabIndex = 36;
            this.totRefAmount.Text = "0000.00";
            this.totRefAmount.Click += new System.EventHandler(this.totRefAmount_Click);
            // 
            // totSaleAmount
            // 
            this.totSaleAmount.AutoSize = true;
            this.totSaleAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totSaleAmount.Location = new System.Drawing.Point(170, 0);
            this.totSaleAmount.Name = "totSaleAmount";
            this.totSaleAmount.Size = new System.Drawing.Size(61, 19);
            this.totSaleAmount.TabIndex = 35;
            this.totSaleAmount.Text = "0000.00";
            this.totSaleAmount.Click += new System.EventHandler(this.totSaleAmount_Click);
            // 
            // totSaleLabel
            // 
            this.totSaleLabel.AutoSize = true;
            this.totSaleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totSaleLabel.Location = new System.Drawing.Point(3, 0);
            this.totSaleLabel.Name = "totSaleLabel";
            this.totSaleLabel.Size = new System.Drawing.Size(89, 19);
            this.totSaleLabel.TabIndex = 34;
            this.totSaleLabel.Text = "Total Sales :";
            // 
            // cashbookDetailsCancelBtn
            // 
            this.cashbookDetailsCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cashbookDetailsCancelBtn.Animated = true;
            this.cashbookDetailsCancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cashbookDetailsCancelBtn.BorderRadius = 8;
            this.cashbookDetailsCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cashbookDetailsCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cashbookDetailsCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cashbookDetailsCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cashbookDetailsCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cashbookDetailsCancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashbookDetailsCancelBtn.ForeColor = System.Drawing.Color.White;
            this.cashbookDetailsCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.cashbookDetailsCancelBtn.Location = new System.Drawing.Point(308, 430);
            this.cashbookDetailsCancelBtn.Name = "cashbookDetailsCancelBtn";
            this.cashbookDetailsCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.cashbookDetailsCancelBtn.TabIndex = 39;
            this.cashbookDetailsCancelBtn.Text = "Cancel";
            this.cashbookDetailsCancelBtn.Click += new System.EventHandler(this.cashbookDetailsCancelBtn_Click);
            // 
            // cashBookPrintBtn
            // 
            this.cashBookPrintBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cashBookPrintBtn.Animated = true;
            this.cashBookPrintBtn.BackColor = System.Drawing.Color.Transparent;
            this.cashBookPrintBtn.BorderRadius = 8;
            this.cashBookPrintBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cashBookPrintBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cashBookPrintBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cashBookPrintBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cashBookPrintBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.cashBookPrintBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashBookPrintBtn.ForeColor = System.Drawing.Color.White;
            this.cashBookPrintBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.cashBookPrintBtn.Location = new System.Drawing.Point(203, 430);
            this.cashBookPrintBtn.Name = "cashBookPrintBtn";
            this.cashBookPrintBtn.Size = new System.Drawing.Size(95, 45);
            this.cashBookPrintBtn.TabIndex = 38;
            this.cashBookPrintBtn.Text = "Print";
            this.cashBookPrintBtn.Click += new System.EventHandler(this.cashBookPrintBtn_Click);
            // 
            // CashBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 496);
            this.Controls.Add(this.cashbookDetailsCancelBtn);
            this.Controls.Add(this.cashBookPrintBtn);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.cashRegDateLable);
            this.Controls.Add(this.cashRegDetailsLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashBookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterDetails";
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.detailsPanel.ResumeLayout(false);
            this.DetailsTable.ResumeLayout(false);
            this.DetailsTable.PerformLayout();
            this.siticonePanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm cashDetailsBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private System.Windows.Forms.Label cashRegDetailsLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel detailsPanel;
        private System.Windows.Forms.Label cashRegDateLable;
        private System.Windows.Forms.TableLayoutPanel DetailsTable;
        private System.Windows.Forms.Label cashInHandAmount;
        private System.Windows.Forms.Label cashInHandLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label cardAmount;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label cashAmount;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label subTotLabel;
        private System.Windows.Forms.Label subTotAmount;
        private System.Windows.Forms.Label totRefundLabel;
        private System.Windows.Forms.Label totRefAmount;
        private System.Windows.Forms.Label totSaleAmount;
        private System.Windows.Forms.Label totSaleLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cashbookDetailsCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cashBookPrintBtn;
    }
}