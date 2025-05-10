namespace EscopeWindowsApp
{
    partial class ProductPricing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPricing));
            this.priceBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimumBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.proPriceLabel = new System.Windows.Forms.Label();
            this.productPriMainPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.pricingPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.ty5UPCNumberText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ty4UPCNumberText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ty3UPCNumberText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ty2UPCNumberText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ty1UPCNumberText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ty5RetPriText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.priVarType5Lbl = new System.Windows.Forms.Label();
            this.priVar5NameLbl = new System.Windows.Forms.Label();
            this.ty5CostPriText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ty4RetPriText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.priVarType4Lbl = new System.Windows.Forms.Label();
            this.priVar4NameLbl = new System.Windows.Forms.Label();
            this.ty4CostPriText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ty3RetPriText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.priVarType3Lbl = new System.Windows.Forms.Label();
            this.priVar3NameLbl = new System.Windows.Forms.Label();
            this.ty3CostPriText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ty2RetPriText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.priVarType2Lbl = new System.Windows.Forms.Label();
            this.priVar2NameLbl = new System.Windows.Forms.Label();
            this.ty2CostPriText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ty1RetPriText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.priVarType1Lbl = new System.Windows.Forms.Label();
            this.priVar1NameLbl = new System.Windows.Forms.Label();
            this.ty1CostPriText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.priceVarNameLabel = new System.Windows.Forms.Label();
            this.priceVarNameText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.priCancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.priSaveBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.productPriMainPanel.SuspendLayout();
            this.pricingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceBorderlessForm
            // 
            this.priceBorderlessForm.BorderRadius = 25;
            this.priceBorderlessForm.ContainerControl = this;
            this.priceBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.priceBorderlessForm.TransparentWhileDrag = true;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(793, 34);
            this.headerPanel.TabIndex = 25;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.minimumBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(681, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(112, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // minimumBtn
            // 
            this.minimumBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumBtn.BorderRadius = 8;
            this.minimumBtn.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimumBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minimumBtn.IconColor = System.Drawing.Color.White;
            this.minimumBtn.Location = new System.Drawing.Point(34, 2);
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
            this.closeBtn.Location = new System.Drawing.Point(65, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 26);
            this.closeBtn.TabIndex = 0;
            // 
            // proPriceLabel
            // 
            this.proPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proPriceLabel.AutoSize = true;
            this.proPriceLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.proPriceLabel.Location = new System.Drawing.Point(22, 47);
            this.proPriceLabel.Name = "proPriceLabel";
            this.proPriceLabel.Size = new System.Drawing.Size(165, 29);
            this.proPriceLabel.TabIndex = 26;
            this.proPriceLabel.Text = "Product Pricing";
            // 
            // productPriMainPanel
            // 
            this.productPriMainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.productPriMainPanel.BorderRadius = 8;
            this.productPriMainPanel.Controls.Add(this.priceLabel);
            this.productPriMainPanel.Controls.Add(this.pricingPanel);
            this.productPriMainPanel.Controls.Add(this.priceVarNameLabel);
            this.productPriMainPanel.Controls.Add(this.priceVarNameText);
            this.productPriMainPanel.FillColor = System.Drawing.Color.White;
            this.productPriMainPanel.Location = new System.Drawing.Point(27, 93);
            this.productPriMainPanel.Name = "productPriMainPanel";
            this.productPriMainPanel.Size = new System.Drawing.Size(738, 581);
            this.productPriMainPanel.TabIndex = 27;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priceLabel.Location = new System.Drawing.Point(30, 102);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(53, 23);
            this.priceLabel.TabIndex = 28;
            this.priceLabel.Text = "Price:";
            // 
            // pricingPanel
            // 
            this.pricingPanel.BackColor = System.Drawing.Color.Transparent;
            this.pricingPanel.BorderColor = System.Drawing.Color.Gray;
            this.pricingPanel.BorderRadius = 8;
            this.pricingPanel.BorderThickness = 1;
            this.pricingPanel.Controls.Add(this.ty5UPCNumberText);
            this.pricingPanel.Controls.Add(this.ty4UPCNumberText);
            this.pricingPanel.Controls.Add(this.ty3UPCNumberText);
            this.pricingPanel.Controls.Add(this.ty2UPCNumberText);
            this.pricingPanel.Controls.Add(this.ty1UPCNumberText);
            this.pricingPanel.Controls.Add(this.ty5RetPriText);
            this.pricingPanel.Controls.Add(this.priVarType5Lbl);
            this.pricingPanel.Controls.Add(this.priVar5NameLbl);
            this.pricingPanel.Controls.Add(this.ty5CostPriText);
            this.pricingPanel.Controls.Add(this.ty4RetPriText);
            this.pricingPanel.Controls.Add(this.priVarType4Lbl);
            this.pricingPanel.Controls.Add(this.priVar4NameLbl);
            this.pricingPanel.Controls.Add(this.ty4CostPriText);
            this.pricingPanel.Controls.Add(this.ty3RetPriText);
            this.pricingPanel.Controls.Add(this.priVarType3Lbl);
            this.pricingPanel.Controls.Add(this.priVar3NameLbl);
            this.pricingPanel.Controls.Add(this.ty3CostPriText);
            this.pricingPanel.Controls.Add(this.ty2RetPriText);
            this.pricingPanel.Controls.Add(this.priVarType2Lbl);
            this.pricingPanel.Controls.Add(this.priVar2NameLbl);
            this.pricingPanel.Controls.Add(this.ty2CostPriText);
            this.pricingPanel.Controls.Add(this.ty1RetPriText);
            this.pricingPanel.Controls.Add(this.priVarType1Lbl);
            this.pricingPanel.Controls.Add(this.priVar1NameLbl);
            this.pricingPanel.Controls.Add(this.ty1CostPriText);
            this.pricingPanel.Location = new System.Drawing.Point(22, 114);
            this.pricingPanel.Name = "pricingPanel";
            this.pricingPanel.Size = new System.Drawing.Size(695, 453);
            this.pricingPanel.TabIndex = 27;
            // 
            // ty5UPCNumberText
            // 
            this.ty5UPCNumberText.BackColor = System.Drawing.Color.Transparent;
            this.ty5UPCNumberText.BorderRadius = 8;
            this.ty5UPCNumberText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty5UPCNumberText.DefaultText = "";
            this.ty5UPCNumberText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty5UPCNumberText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty5UPCNumberText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty5UPCNumberText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty5UPCNumberText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty5UPCNumberText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty5UPCNumberText.ForeColor = System.Drawing.Color.Black;
            this.ty5UPCNumberText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty5UPCNumberText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty5UPCNumberText.Location = new System.Drawing.Point(471, 398);
            this.ty5UPCNumberText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty5UPCNumberText.Name = "ty5UPCNumberText";
            this.ty5UPCNumberText.PasswordChar = '\0';
            this.ty5UPCNumberText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty5UPCNumberText.PlaceholderText = "UPC/EAN Number";
            this.ty5UPCNumberText.SelectedText = "";
            this.ty5UPCNumberText.Size = new System.Drawing.Size(210, 42);
            this.ty5UPCNumberText.TabIndex = 57;
            this.ty5UPCNumberText.TextChanged += new System.EventHandler(this.ty5UPCNumberText_TextChanged);
            // 
            // ty4UPCNumberText
            // 
            this.ty4UPCNumberText.BackColor = System.Drawing.Color.Transparent;
            this.ty4UPCNumberText.BorderRadius = 8;
            this.ty4UPCNumberText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty4UPCNumberText.DefaultText = "";
            this.ty4UPCNumberText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty4UPCNumberText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty4UPCNumberText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty4UPCNumberText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty4UPCNumberText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty4UPCNumberText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty4UPCNumberText.ForeColor = System.Drawing.Color.Black;
            this.ty4UPCNumberText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty4UPCNumberText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty4UPCNumberText.Location = new System.Drawing.Point(471, 310);
            this.ty4UPCNumberText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty4UPCNumberText.Name = "ty4UPCNumberText";
            this.ty4UPCNumberText.PasswordChar = '\0';
            this.ty4UPCNumberText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty4UPCNumberText.PlaceholderText = "UPC/EAN Number";
            this.ty4UPCNumberText.SelectedText = "";
            this.ty4UPCNumberText.Size = new System.Drawing.Size(210, 42);
            this.ty4UPCNumberText.TabIndex = 56;
            this.ty4UPCNumberText.TextChanged += new System.EventHandler(this.ty4UPCNumberText_TextChanged);
            // 
            // ty3UPCNumberText
            // 
            this.ty3UPCNumberText.BackColor = System.Drawing.Color.Transparent;
            this.ty3UPCNumberText.BorderRadius = 8;
            this.ty3UPCNumberText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty3UPCNumberText.DefaultText = "";
            this.ty3UPCNumberText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty3UPCNumberText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty3UPCNumberText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty3UPCNumberText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty3UPCNumberText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty3UPCNumberText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty3UPCNumberText.ForeColor = System.Drawing.Color.Black;
            this.ty3UPCNumberText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty3UPCNumberText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty3UPCNumberText.Location = new System.Drawing.Point(471, 225);
            this.ty3UPCNumberText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty3UPCNumberText.Name = "ty3UPCNumberText";
            this.ty3UPCNumberText.PasswordChar = '\0';
            this.ty3UPCNumberText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty3UPCNumberText.PlaceholderText = "UPC/EAN Number";
            this.ty3UPCNumberText.SelectedText = "";
            this.ty3UPCNumberText.Size = new System.Drawing.Size(210, 42);
            this.ty3UPCNumberText.TabIndex = 55;
            this.ty3UPCNumberText.TextChanged += new System.EventHandler(this.ty3UPCNumberText_TextChanged);
            // 
            // ty2UPCNumberText
            // 
            this.ty2UPCNumberText.BackColor = System.Drawing.Color.Transparent;
            this.ty2UPCNumberText.BorderRadius = 8;
            this.ty2UPCNumberText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty2UPCNumberText.DefaultText = "";
            this.ty2UPCNumberText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty2UPCNumberText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty2UPCNumberText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty2UPCNumberText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty2UPCNumberText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty2UPCNumberText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty2UPCNumberText.ForeColor = System.Drawing.Color.Black;
            this.ty2UPCNumberText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty2UPCNumberText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty2UPCNumberText.Location = new System.Drawing.Point(471, 137);
            this.ty2UPCNumberText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty2UPCNumberText.Name = "ty2UPCNumberText";
            this.ty2UPCNumberText.PasswordChar = '\0';
            this.ty2UPCNumberText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty2UPCNumberText.PlaceholderText = "UPC/EAN Number";
            this.ty2UPCNumberText.SelectedText = "";
            this.ty2UPCNumberText.Size = new System.Drawing.Size(210, 42);
            this.ty2UPCNumberText.TabIndex = 54;
            this.ty2UPCNumberText.TextChanged += new System.EventHandler(this.ty2UPCNumberText_TextChanged);
            // 
            // ty1UPCNumberText
            // 
            this.ty1UPCNumberText.BackColor = System.Drawing.Color.Transparent;
            this.ty1UPCNumberText.BorderRadius = 8;
            this.ty1UPCNumberText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty1UPCNumberText.DefaultText = "";
            this.ty1UPCNumberText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty1UPCNumberText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty1UPCNumberText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty1UPCNumberText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty1UPCNumberText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty1UPCNumberText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty1UPCNumberText.ForeColor = System.Drawing.Color.Black;
            this.ty1UPCNumberText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty1UPCNumberText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty1UPCNumberText.Location = new System.Drawing.Point(471, 51);
            this.ty1UPCNumberText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty1UPCNumberText.Name = "ty1UPCNumberText";
            this.ty1UPCNumberText.PasswordChar = '\0';
            this.ty1UPCNumberText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty1UPCNumberText.PlaceholderText = "UPC/EAN Number";
            this.ty1UPCNumberText.SelectedText = "";
            this.ty1UPCNumberText.Size = new System.Drawing.Size(210, 42);
            this.ty1UPCNumberText.TabIndex = 53;
            this.ty1UPCNumberText.TextChanged += new System.EventHandler(this.ty1UPCNumberText_TextChanged);
            // 
            // ty5RetPriText
            // 
            this.ty5RetPriText.BackColor = System.Drawing.Color.Transparent;
            this.ty5RetPriText.BorderRadius = 8;
            this.ty5RetPriText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty5RetPriText.DefaultText = "";
            this.ty5RetPriText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty5RetPriText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty5RetPriText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty5RetPriText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty5RetPriText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty5RetPriText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty5RetPriText.ForeColor = System.Drawing.Color.Black;
            this.ty5RetPriText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty5RetPriText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty5RetPriText.Location = new System.Drawing.Point(240, 398);
            this.ty5RetPriText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty5RetPriText.Name = "ty5RetPriText";
            this.ty5RetPriText.PasswordChar = '\0';
            this.ty5RetPriText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty5RetPriText.PlaceholderText = "Retail Price";
            this.ty5RetPriText.SelectedText = "";
            this.ty5RetPriText.Size = new System.Drawing.Size(210, 42);
            this.ty5RetPriText.TabIndex = 52;
            // 
            // priVarType5Lbl
            // 
            this.priVarType5Lbl.AutoSize = true;
            this.priVarType5Lbl.BackColor = System.Drawing.Color.Transparent;
            this.priVarType5Lbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priVarType5Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priVarType5Lbl.Location = new System.Drawing.Point(139, 368);
            this.priVarType5Lbl.Name = "priVarType5Lbl";
            this.priVarType5Lbl.Size = new System.Drawing.Size(26, 23);
            this.priVarType5Lbl.TabIndex = 51;
            this.priVarType5Lbl.Text = "M";
            // 
            // priVar5NameLbl
            // 
            this.priVar5NameLbl.AutoSize = true;
            this.priVar5NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.priVar5NameLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priVar5NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priVar5NameLbl.Location = new System.Drawing.Point(8, 368);
            this.priVar5NameLbl.Name = "priVar5NameLbl";
            this.priVar5NameLbl.Size = new System.Drawing.Size(125, 23);
            this.priVar5NameLbl.TabIndex = 50;
            this.priVar5NameLbl.Text = "Variation Type:";
            // 
            // ty5CostPriText
            // 
            this.ty5CostPriText.BackColor = System.Drawing.Color.Transparent;
            this.ty5CostPriText.BorderRadius = 8;
            this.ty5CostPriText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty5CostPriText.DefaultText = "";
            this.ty5CostPriText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty5CostPriText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty5CostPriText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty5CostPriText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty5CostPriText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty5CostPriText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty5CostPriText.ForeColor = System.Drawing.Color.Black;
            this.ty5CostPriText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty5CostPriText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty5CostPriText.Location = new System.Drawing.Point(12, 398);
            this.ty5CostPriText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty5CostPriText.Name = "ty5CostPriText";
            this.ty5CostPriText.PasswordChar = '\0';
            this.ty5CostPriText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty5CostPriText.PlaceholderText = "Cost Price";
            this.ty5CostPriText.SelectedText = "";
            this.ty5CostPriText.Size = new System.Drawing.Size(210, 42);
            this.ty5CostPriText.TabIndex = 49;
            // 
            // ty4RetPriText
            // 
            this.ty4RetPriText.BackColor = System.Drawing.Color.Transparent;
            this.ty4RetPriText.BorderRadius = 8;
            this.ty4RetPriText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty4RetPriText.DefaultText = "";
            this.ty4RetPriText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty4RetPriText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty4RetPriText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty4RetPriText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty4RetPriText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty4RetPriText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty4RetPriText.ForeColor = System.Drawing.Color.Black;
            this.ty4RetPriText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty4RetPriText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty4RetPriText.Location = new System.Drawing.Point(240, 310);
            this.ty4RetPriText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty4RetPriText.Name = "ty4RetPriText";
            this.ty4RetPriText.PasswordChar = '\0';
            this.ty4RetPriText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty4RetPriText.PlaceholderText = "Retail Price";
            this.ty4RetPriText.SelectedText = "";
            this.ty4RetPriText.Size = new System.Drawing.Size(210, 42);
            this.ty4RetPriText.TabIndex = 47;
            // 
            // priVarType4Lbl
            // 
            this.priVarType4Lbl.AutoSize = true;
            this.priVarType4Lbl.BackColor = System.Drawing.Color.Transparent;
            this.priVarType4Lbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priVarType4Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priVarType4Lbl.Location = new System.Drawing.Point(139, 280);
            this.priVarType4Lbl.Name = "priVarType4Lbl";
            this.priVarType4Lbl.Size = new System.Drawing.Size(26, 23);
            this.priVarType4Lbl.TabIndex = 46;
            this.priVarType4Lbl.Text = "M";
            // 
            // priVar4NameLbl
            // 
            this.priVar4NameLbl.AutoSize = true;
            this.priVar4NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.priVar4NameLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priVar4NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priVar4NameLbl.Location = new System.Drawing.Point(8, 280);
            this.priVar4NameLbl.Name = "priVar4NameLbl";
            this.priVar4NameLbl.Size = new System.Drawing.Size(125, 23);
            this.priVar4NameLbl.TabIndex = 45;
            this.priVar4NameLbl.Text = "Variation Type:";
            // 
            // ty4CostPriText
            // 
            this.ty4CostPriText.BackColor = System.Drawing.Color.Transparent;
            this.ty4CostPriText.BorderRadius = 8;
            this.ty4CostPriText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty4CostPriText.DefaultText = "";
            this.ty4CostPriText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty4CostPriText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty4CostPriText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty4CostPriText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty4CostPriText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty4CostPriText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty4CostPriText.ForeColor = System.Drawing.Color.Black;
            this.ty4CostPriText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty4CostPriText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty4CostPriText.Location = new System.Drawing.Point(12, 310);
            this.ty4CostPriText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty4CostPriText.Name = "ty4CostPriText";
            this.ty4CostPriText.PasswordChar = '\0';
            this.ty4CostPriText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty4CostPriText.PlaceholderText = "Cost Price";
            this.ty4CostPriText.SelectedText = "";
            this.ty4CostPriText.Size = new System.Drawing.Size(210, 42);
            this.ty4CostPriText.TabIndex = 44;
            // 
            // ty3RetPriText
            // 
            this.ty3RetPriText.BackColor = System.Drawing.Color.Transparent;
            this.ty3RetPriText.BorderRadius = 8;
            this.ty3RetPriText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty3RetPriText.DefaultText = "";
            this.ty3RetPriText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty3RetPriText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty3RetPriText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty3RetPriText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty3RetPriText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty3RetPriText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty3RetPriText.ForeColor = System.Drawing.Color.Black;
            this.ty3RetPriText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty3RetPriText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty3RetPriText.Location = new System.Drawing.Point(240, 225);
            this.ty3RetPriText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty3RetPriText.Name = "ty3RetPriText";
            this.ty3RetPriText.PasswordChar = '\0';
            this.ty3RetPriText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty3RetPriText.PlaceholderText = "Retail Price";
            this.ty3RetPriText.SelectedText = "";
            this.ty3RetPriText.Size = new System.Drawing.Size(210, 42);
            this.ty3RetPriText.TabIndex = 42;
            // 
            // priVarType3Lbl
            // 
            this.priVarType3Lbl.AutoSize = true;
            this.priVarType3Lbl.BackColor = System.Drawing.Color.Transparent;
            this.priVarType3Lbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priVarType3Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priVarType3Lbl.Location = new System.Drawing.Point(139, 195);
            this.priVarType3Lbl.Name = "priVarType3Lbl";
            this.priVarType3Lbl.Size = new System.Drawing.Size(26, 23);
            this.priVarType3Lbl.TabIndex = 41;
            this.priVarType3Lbl.Text = "M";
            // 
            // priVar3NameLbl
            // 
            this.priVar3NameLbl.AutoSize = true;
            this.priVar3NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.priVar3NameLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priVar3NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priVar3NameLbl.Location = new System.Drawing.Point(8, 195);
            this.priVar3NameLbl.Name = "priVar3NameLbl";
            this.priVar3NameLbl.Size = new System.Drawing.Size(125, 23);
            this.priVar3NameLbl.TabIndex = 40;
            this.priVar3NameLbl.Text = "Variation Type:";
            // 
            // ty3CostPriText
            // 
            this.ty3CostPriText.BackColor = System.Drawing.Color.Transparent;
            this.ty3CostPriText.BorderRadius = 8;
            this.ty3CostPriText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty3CostPriText.DefaultText = "";
            this.ty3CostPriText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty3CostPriText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty3CostPriText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty3CostPriText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty3CostPriText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty3CostPriText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty3CostPriText.ForeColor = System.Drawing.Color.Black;
            this.ty3CostPriText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty3CostPriText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty3CostPriText.Location = new System.Drawing.Point(12, 225);
            this.ty3CostPriText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty3CostPriText.Name = "ty3CostPriText";
            this.ty3CostPriText.PasswordChar = '\0';
            this.ty3CostPriText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty3CostPriText.PlaceholderText = "Cost Price";
            this.ty3CostPriText.SelectedText = "";
            this.ty3CostPriText.Size = new System.Drawing.Size(210, 42);
            this.ty3CostPriText.TabIndex = 39;
            // 
            // ty2RetPriText
            // 
            this.ty2RetPriText.BackColor = System.Drawing.Color.Transparent;
            this.ty2RetPriText.BorderRadius = 8;
            this.ty2RetPriText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty2RetPriText.DefaultText = "";
            this.ty2RetPriText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty2RetPriText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty2RetPriText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty2RetPriText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty2RetPriText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty2RetPriText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty2RetPriText.ForeColor = System.Drawing.Color.Black;
            this.ty2RetPriText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty2RetPriText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty2RetPriText.Location = new System.Drawing.Point(240, 137);
            this.ty2RetPriText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty2RetPriText.Name = "ty2RetPriText";
            this.ty2RetPriText.PasswordChar = '\0';
            this.ty2RetPriText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty2RetPriText.PlaceholderText = "Retail Price";
            this.ty2RetPriText.SelectedText = "";
            this.ty2RetPriText.Size = new System.Drawing.Size(210, 42);
            this.ty2RetPriText.TabIndex = 37;
            // 
            // priVarType2Lbl
            // 
            this.priVarType2Lbl.AutoSize = true;
            this.priVarType2Lbl.BackColor = System.Drawing.Color.Transparent;
            this.priVarType2Lbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priVarType2Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priVarType2Lbl.Location = new System.Drawing.Point(139, 107);
            this.priVarType2Lbl.Name = "priVarType2Lbl";
            this.priVarType2Lbl.Size = new System.Drawing.Size(26, 23);
            this.priVarType2Lbl.TabIndex = 36;
            this.priVarType2Lbl.Text = "M";
            // 
            // priVar2NameLbl
            // 
            this.priVar2NameLbl.AutoSize = true;
            this.priVar2NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.priVar2NameLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priVar2NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priVar2NameLbl.Location = new System.Drawing.Point(8, 107);
            this.priVar2NameLbl.Name = "priVar2NameLbl";
            this.priVar2NameLbl.Size = new System.Drawing.Size(125, 23);
            this.priVar2NameLbl.TabIndex = 35;
            this.priVar2NameLbl.Text = "Variation Type:";
            // 
            // ty2CostPriText
            // 
            this.ty2CostPriText.BackColor = System.Drawing.Color.Transparent;
            this.ty2CostPriText.BorderRadius = 8;
            this.ty2CostPriText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty2CostPriText.DefaultText = "";
            this.ty2CostPriText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty2CostPriText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty2CostPriText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty2CostPriText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty2CostPriText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty2CostPriText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty2CostPriText.ForeColor = System.Drawing.Color.Black;
            this.ty2CostPriText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty2CostPriText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty2CostPriText.Location = new System.Drawing.Point(12, 137);
            this.ty2CostPriText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty2CostPriText.Name = "ty2CostPriText";
            this.ty2CostPriText.PasswordChar = '\0';
            this.ty2CostPriText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty2CostPriText.PlaceholderText = "Cost Price";
            this.ty2CostPriText.SelectedText = "";
            this.ty2CostPriText.Size = new System.Drawing.Size(210, 42);
            this.ty2CostPriText.TabIndex = 34;
            // 
            // ty1RetPriText
            // 
            this.ty1RetPriText.BackColor = System.Drawing.Color.Transparent;
            this.ty1RetPriText.BorderRadius = 8;
            this.ty1RetPriText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty1RetPriText.DefaultText = "";
            this.ty1RetPriText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty1RetPriText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty1RetPriText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty1RetPriText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty1RetPriText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty1RetPriText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty1RetPriText.ForeColor = System.Drawing.Color.Black;
            this.ty1RetPriText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty1RetPriText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty1RetPriText.Location = new System.Drawing.Point(240, 51);
            this.ty1RetPriText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty1RetPriText.Name = "ty1RetPriText";
            this.ty1RetPriText.PasswordChar = '\0';
            this.ty1RetPriText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty1RetPriText.PlaceholderText = "Retail Price";
            this.ty1RetPriText.SelectedText = "";
            this.ty1RetPriText.Size = new System.Drawing.Size(210, 42);
            this.ty1RetPriText.TabIndex = 32;
            // 
            // priVarType1Lbl
            // 
            this.priVarType1Lbl.AutoSize = true;
            this.priVarType1Lbl.BackColor = System.Drawing.Color.Transparent;
            this.priVarType1Lbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priVarType1Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priVarType1Lbl.Location = new System.Drawing.Point(139, 21);
            this.priVarType1Lbl.Name = "priVarType1Lbl";
            this.priVarType1Lbl.Size = new System.Drawing.Size(26, 23);
            this.priVarType1Lbl.TabIndex = 31;
            this.priVarType1Lbl.Text = "M";
            // 
            // priVar1NameLbl
            // 
            this.priVar1NameLbl.AutoSize = true;
            this.priVar1NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.priVar1NameLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priVar1NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priVar1NameLbl.Location = new System.Drawing.Point(8, 21);
            this.priVar1NameLbl.Name = "priVar1NameLbl";
            this.priVar1NameLbl.Size = new System.Drawing.Size(125, 23);
            this.priVar1NameLbl.TabIndex = 30;
            this.priVar1NameLbl.Text = "Variation Type:";
            // 
            // ty1CostPriText
            // 
            this.ty1CostPriText.BackColor = System.Drawing.Color.Transparent;
            this.ty1CostPriText.BorderRadius = 8;
            this.ty1CostPriText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ty1CostPriText.DefaultText = "";
            this.ty1CostPriText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ty1CostPriText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ty1CostPriText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty1CostPriText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ty1CostPriText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty1CostPriText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty1CostPriText.ForeColor = System.Drawing.Color.Black;
            this.ty1CostPriText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ty1CostPriText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ty1CostPriText.Location = new System.Drawing.Point(12, 51);
            this.ty1CostPriText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ty1CostPriText.Name = "ty1CostPriText";
            this.ty1CostPriText.PasswordChar = '\0';
            this.ty1CostPriText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ty1CostPriText.PlaceholderText = "Cost Price";
            this.ty1CostPriText.SelectedText = "";
            this.ty1CostPriText.Size = new System.Drawing.Size(210, 42);
            this.ty1CostPriText.TabIndex = 29;
            this.ty1CostPriText.TextChanged += new System.EventHandler(this.ty1CostPriText_TextChanged);
            // 
            // priceVarNameLabel
            // 
            this.priceVarNameLabel.AutoSize = true;
            this.priceVarNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceVarNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceVarNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.priceVarNameLabel.Location = new System.Drawing.Point(18, 19);
            this.priceVarNameLabel.Name = "priceVarNameLabel";
            this.priceVarNameLabel.Size = new System.Drawing.Size(134, 23);
            this.priceVarNameLabel.TabIndex = 24;
            this.priceVarNameLabel.Text = "Variation Name:";
            // 
            // priceVarNameText
            // 
            this.priceVarNameText.BackColor = System.Drawing.Color.Transparent;
            this.priceVarNameText.BorderRadius = 8;
            this.priceVarNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceVarNameText.DefaultText = "";
            this.priceVarNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceVarNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceVarNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceVarNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceVarNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceVarNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceVarNameText.ForeColor = System.Drawing.Color.Black;
            this.priceVarNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceVarNameText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.priceVarNameText.Location = new System.Drawing.Point(22, 46);
            this.priceVarNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceVarNameText.Name = "priceVarNameText";
            this.priceVarNameText.PasswordChar = '\0';
            this.priceVarNameText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.priceVarNameText.PlaceholderText = "Variation Name";
            this.priceVarNameText.SelectedText = "";
            this.priceVarNameText.Size = new System.Drawing.Size(327, 42);
            this.priceVarNameText.TabIndex = 9;
            // 
            // priCancelBtn
            // 
            this.priCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priCancelBtn.Animated = true;
            this.priCancelBtn.BorderRadius = 8;
            this.priCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.priCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.priCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.priCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.priCancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.priCancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priCancelBtn.ForeColor = System.Drawing.Color.White;
            this.priCancelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.priCancelBtn.Location = new System.Drawing.Point(670, 694);
            this.priCancelBtn.Name = "priCancelBtn";
            this.priCancelBtn.Size = new System.Drawing.Size(95, 45);
            this.priCancelBtn.TabIndex = 58;
            this.priCancelBtn.Text = "Cancel";
            this.priCancelBtn.Click += new System.EventHandler(this.priCancelBtn_Click_1);
            // 
            // priSaveBtn
            // 
            this.priSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priSaveBtn.Animated = true;
            this.priSaveBtn.BorderRadius = 8;
            this.priSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.priSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.priSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.priSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.priSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.priSaveBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priSaveBtn.ForeColor = System.Drawing.Color.White;
            this.priSaveBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.priSaveBtn.Location = new System.Drawing.Point(568, 694);
            this.priSaveBtn.Name = "priSaveBtn";
            this.priSaveBtn.Size = new System.Drawing.Size(95, 45);
            this.priSaveBtn.TabIndex = 59;
            this.priSaveBtn.Text = "Save";
            this.priSaveBtn.Click += new System.EventHandler(this.priSaveBtn_Click_2);
            // 
            // ProductPricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 756);
            this.Controls.Add(this.priCancelBtn);
            this.Controls.Add(this.priSaveBtn);
            this.Controls.Add(this.productPriMainPanel);
            this.Controls.Add(this.proPriceLabel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(793, 756);
            this.MinimumSize = new System.Drawing.Size(793, 718);
            this.Name = "ProductPricing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prices";
            this.Load += new System.EventHandler(this.ProductPricing_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.productPriMainPanel.ResumeLayout(false);
            this.productPriMainPanel.PerformLayout();
            this.pricingPanel.ResumeLayout(false);
            this.pricingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm priceBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimumBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeBtn;
        private System.Windows.Forms.Label proPriceLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel productPriMainPanel;
        private System.Windows.Forms.Label priceVarNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox priceVarNameText;
        private System.Windows.Forms.Label priceLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel pricingPanel;
        private System.Windows.Forms.Label priVarType1Lbl;
        private System.Windows.Forms.Label priVar1NameLbl;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty1CostPriText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty1RetPriText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty2RetPriText;
        private System.Windows.Forms.Label priVarType2Lbl;
        private System.Windows.Forms.Label priVar2NameLbl;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty2CostPriText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty4RetPriText;
        private System.Windows.Forms.Label priVarType4Lbl;
        private System.Windows.Forms.Label priVar4NameLbl;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty4CostPriText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty3RetPriText;
        private System.Windows.Forms.Label priVarType3Lbl;
        private System.Windows.Forms.Label priVar3NameLbl;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty3CostPriText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty5RetPriText;
        private System.Windows.Forms.Label priVarType5Lbl;
        private System.Windows.Forms.Label priVar5NameLbl;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty5CostPriText;
        private Siticone.Desktop.UI.WinForms.SiticoneButton priCancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton priSaveBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty4UPCNumberText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty3UPCNumberText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty2UPCNumberText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty1UPCNumberText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ty5UPCNumberText;
    }
}