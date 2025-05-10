namespace EscopeWindowsApp
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.headerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.createUnitsCloseBtn = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.calculatorBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.finalNumLabel = new System.Windows.Forms.Label();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.clearBtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.no7Btn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.no8Btn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.no9Btn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.no4Btn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.no5Btn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.no6Btn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.no1Btn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.no2Btn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.no3Btn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.no00Btn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.no0Btn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.dotBtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.multipleBtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.plusBtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.equalBtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.substractBtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.cutBtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.percentageBtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.divideBtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.controlPanel);
            this.headerPanel.FillColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(-6, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(391, 34);
            this.headerPanel.TabIndex = 80;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.createUnitsCloseBtn);
            this.controlPanel.FillColor = System.Drawing.Color.White;
            this.controlPanel.Location = new System.Drawing.Point(330, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(49, 30);
            this.controlPanel.TabIndex = 1;
            // 
            // createUnitsCloseBtn
            // 
            this.createUnitsCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createUnitsCloseBtn.BorderRadius = 8;
            this.createUnitsCloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createUnitsCloseBtn.IconColor = System.Drawing.Color.White;
            this.createUnitsCloseBtn.Location = new System.Drawing.Point(13, 3);
            this.createUnitsCloseBtn.Name = "createUnitsCloseBtn";
            this.createUnitsCloseBtn.Size = new System.Drawing.Size(28, 26);
            this.createUnitsCloseBtn.TabIndex = 0;
            // 
            // calculatorBorderlessForm
            // 
            this.calculatorBorderlessForm.BorderRadius = 25;
            this.calculatorBorderlessForm.ContainerControl = this;
            this.calculatorBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.calculatorBorderlessForm.TransparentWhileDrag = true;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticonePanel1.BorderRadius = 8;
            this.siticonePanel1.Controls.Add(this.finalNumLabel);
            this.siticonePanel1.Controls.Add(this.numbersLabel);
            this.siticonePanel1.FillColor = System.Drawing.Color.White;
            this.siticonePanel1.Location = new System.Drawing.Point(18, 40);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(347, 113);
            this.siticonePanel1.TabIndex = 81;
            // 
            // finalNumLabel
            // 
            this.finalNumLabel.AutoSize = true;
            this.finalNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.finalNumLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalNumLabel.Location = new System.Drawing.Point(6, 47);
            this.finalNumLabel.Name = "finalNumLabel";
            this.finalNumLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.finalNumLabel.Size = new System.Drawing.Size(43, 50);
            this.finalNumLabel.TabIndex = 1;
            this.finalNumLabel.Text = "0";
            this.finalNumLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.finalNumLabel.Click += new System.EventHandler(this.finalNumLabel_Click);
            // 
            // numbersLabel
            // 
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.BackColor = System.Drawing.Color.Transparent;
            this.numbersLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersLabel.Location = new System.Drawing.Point(14, 12);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(24, 30);
            this.numbersLabel.TabIndex = 0;
            this.numbersLabel.Text = "0";
            this.numbersLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.numbersLabel.Click += new System.EventHandler(this.numbersLabel_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Animated = true;
            this.clearBtn.AnimatedGIF = true;
            this.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.clearBtn.Location = new System.Drawing.Point(18, 159);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.clearBtn.Size = new System.Drawing.Size(80, 80);
            this.clearBtn.TabIndex = 82;
            this.clearBtn.Text = "C";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // no7Btn
            // 
            this.no7Btn.Animated = true;
            this.no7Btn.AnimatedGIF = true;
            this.no7Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no7Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no7Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no7Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no7Btn.FillColor = System.Drawing.Color.White;
            this.no7Btn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no7Btn.ForeColor = System.Drawing.Color.Black;
            this.no7Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.no7Btn.Location = new System.Drawing.Point(18, 245);
            this.no7Btn.Name = "no7Btn";
            this.no7Btn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.no7Btn.Size = new System.Drawing.Size(80, 80);
            this.no7Btn.TabIndex = 89;
            this.no7Btn.Text = "7";
            this.no7Btn.Click += new System.EventHandler(this.no7Btn_Click);
            // 
            // no8Btn
            // 
            this.no8Btn.Animated = true;
            this.no8Btn.AnimatedGIF = true;
            this.no8Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no8Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no8Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no8Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no8Btn.FillColor = System.Drawing.Color.White;
            this.no8Btn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no8Btn.ForeColor = System.Drawing.Color.Black;
            this.no8Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.no8Btn.Location = new System.Drawing.Point(107, 245);
            this.no8Btn.Name = "no8Btn";
            this.no8Btn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.no8Btn.Size = new System.Drawing.Size(80, 80);
            this.no8Btn.TabIndex = 90;
            this.no8Btn.Text = "8";
            this.no8Btn.Click += new System.EventHandler(this.no8Btn_Click);
            // 
            // no9Btn
            // 
            this.no9Btn.Animated = true;
            this.no9Btn.AnimatedGIF = true;
            this.no9Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no9Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no9Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no9Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no9Btn.FillColor = System.Drawing.Color.White;
            this.no9Btn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no9Btn.ForeColor = System.Drawing.Color.Black;
            this.no9Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.no9Btn.Location = new System.Drawing.Point(196, 245);
            this.no9Btn.Name = "no9Btn";
            this.no9Btn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.no9Btn.Size = new System.Drawing.Size(80, 80);
            this.no9Btn.TabIndex = 91;
            this.no9Btn.Text = "9";
            this.no9Btn.Click += new System.EventHandler(this.no9Btn_Click);
            // 
            // no4Btn
            // 
            this.no4Btn.Animated = true;
            this.no4Btn.AnimatedGIF = true;
            this.no4Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no4Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no4Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no4Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no4Btn.FillColor = System.Drawing.Color.White;
            this.no4Btn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no4Btn.ForeColor = System.Drawing.Color.Black;
            this.no4Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.no4Btn.Location = new System.Drawing.Point(18, 332);
            this.no4Btn.Name = "no4Btn";
            this.no4Btn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.no4Btn.Size = new System.Drawing.Size(80, 80);
            this.no4Btn.TabIndex = 92;
            this.no4Btn.Text = "4";
            this.no4Btn.Click += new System.EventHandler(this.no4Btn_Click);
            // 
            // no5Btn
            // 
            this.no5Btn.Animated = true;
            this.no5Btn.AnimatedGIF = true;
            this.no5Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no5Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no5Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no5Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no5Btn.FillColor = System.Drawing.Color.White;
            this.no5Btn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no5Btn.ForeColor = System.Drawing.Color.Black;
            this.no5Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.no5Btn.Location = new System.Drawing.Point(107, 333);
            this.no5Btn.Name = "no5Btn";
            this.no5Btn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.no5Btn.Size = new System.Drawing.Size(80, 80);
            this.no5Btn.TabIndex = 93;
            this.no5Btn.Text = "5";
            this.no5Btn.Click += new System.EventHandler(this.no5Btn_Click);
            // 
            // no6Btn
            // 
            this.no6Btn.Animated = true;
            this.no6Btn.AnimatedGIF = true;
            this.no6Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no6Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no6Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no6Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no6Btn.FillColor = System.Drawing.Color.White;
            this.no6Btn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no6Btn.ForeColor = System.Drawing.Color.Black;
            this.no6Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.no6Btn.Location = new System.Drawing.Point(196, 332);
            this.no6Btn.Name = "no6Btn";
            this.no6Btn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.no6Btn.Size = new System.Drawing.Size(80, 80);
            this.no6Btn.TabIndex = 94;
            this.no6Btn.Text = "6";
            this.no6Btn.Click += new System.EventHandler(this.no6Btn_Click);
            // 
            // no1Btn
            // 
            this.no1Btn.Animated = true;
            this.no1Btn.AnimatedGIF = true;
            this.no1Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no1Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no1Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no1Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no1Btn.FillColor = System.Drawing.Color.White;
            this.no1Btn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no1Btn.ForeColor = System.Drawing.Color.Black;
            this.no1Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.no1Btn.Location = new System.Drawing.Point(18, 420);
            this.no1Btn.Name = "no1Btn";
            this.no1Btn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.no1Btn.Size = new System.Drawing.Size(80, 80);
            this.no1Btn.TabIndex = 95;
            this.no1Btn.Text = "1";
            this.no1Btn.Click += new System.EventHandler(this.no1Btn_Click);
            // 
            // no2Btn
            // 
            this.no2Btn.Animated = true;
            this.no2Btn.AnimatedGIF = true;
            this.no2Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no2Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no2Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no2Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no2Btn.FillColor = System.Drawing.Color.White;
            this.no2Btn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no2Btn.ForeColor = System.Drawing.Color.Black;
            this.no2Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.no2Btn.Location = new System.Drawing.Point(107, 420);
            this.no2Btn.Name = "no2Btn";
            this.no2Btn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.no2Btn.Size = new System.Drawing.Size(80, 80);
            this.no2Btn.TabIndex = 96;
            this.no2Btn.Text = "2";
            this.no2Btn.Click += new System.EventHandler(this.no2Btn_Click);
            // 
            // no3Btn
            // 
            this.no3Btn.Animated = true;
            this.no3Btn.AnimatedGIF = true;
            this.no3Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no3Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no3Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no3Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no3Btn.FillColor = System.Drawing.Color.White;
            this.no3Btn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no3Btn.ForeColor = System.Drawing.Color.Black;
            this.no3Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.no3Btn.Location = new System.Drawing.Point(196, 420);
            this.no3Btn.Name = "no3Btn";
            this.no3Btn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.no3Btn.Size = new System.Drawing.Size(80, 80);
            this.no3Btn.TabIndex = 97;
            this.no3Btn.Text = "3";
            this.no3Btn.Click += new System.EventHandler(this.no3Btn_Click);
            // 
            // no00Btn
            // 
            this.no00Btn.Animated = true;
            this.no00Btn.AnimatedGIF = true;
            this.no00Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no00Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no00Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no00Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no00Btn.FillColor = System.Drawing.Color.White;
            this.no00Btn.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no00Btn.ForeColor = System.Drawing.Color.Black;
            this.no00Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.no00Btn.Location = new System.Drawing.Point(107, 506);
            this.no00Btn.Name = "no00Btn";
            this.no00Btn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.no00Btn.Size = new System.Drawing.Size(80, 80);
            this.no00Btn.TabIndex = 98;
            this.no00Btn.Text = "00";
            this.no00Btn.Click += new System.EventHandler(this.no00Btn_Click);
            // 
            // no0Btn
            // 
            this.no0Btn.Animated = true;
            this.no0Btn.AnimatedGIF = true;
            this.no0Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no0Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no0Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no0Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no0Btn.FillColor = System.Drawing.Color.White;
            this.no0Btn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no0Btn.ForeColor = System.Drawing.Color.Black;
            this.no0Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.no0Btn.Location = new System.Drawing.Point(196, 506);
            this.no0Btn.Name = "no0Btn";
            this.no0Btn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.no0Btn.Size = new System.Drawing.Size(80, 80);
            this.no0Btn.TabIndex = 99;
            this.no0Btn.Text = "0";
            this.no0Btn.Click += new System.EventHandler(this.no0Btn_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.Animated = true;
            this.dotBtn.AnimatedGIF = true;
            this.dotBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dotBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dotBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dotBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dotBtn.FillColor = System.Drawing.Color.White;
            this.dotBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotBtn.ForeColor = System.Drawing.Color.Black;
            this.dotBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dotBtn.Location = new System.Drawing.Point(18, 506);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.dotBtn.Size = new System.Drawing.Size(80, 80);
            this.dotBtn.TabIndex = 100;
            this.dotBtn.Text = ".";
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // multipleBtn
            // 
            this.multipleBtn.Animated = true;
            this.multipleBtn.AnimatedGIF = true;
            this.multipleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.multipleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.multipleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.multipleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.multipleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.multipleBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multipleBtn.ForeColor = System.Drawing.Color.White;
            this.multipleBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.multipleBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_multiply_60;
            this.multipleBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.multipleBtn.Location = new System.Drawing.Point(285, 420);
            this.multipleBtn.Name = "multipleBtn";
            this.multipleBtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.multipleBtn.Size = new System.Drawing.Size(80, 80);
            this.multipleBtn.TabIndex = 101;
            this.multipleBtn.Click += new System.EventHandler(this.multipleBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Animated = true;
            this.plusBtn.AnimatedGIF = true;
            this.plusBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.plusBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.plusBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.plusBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.plusBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.plusBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.ForeColor = System.Drawing.Color.White;
            this.plusBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.plusBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_add_64;
            this.plusBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.plusBtn.Location = new System.Drawing.Point(285, 332);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.plusBtn.Size = new System.Drawing.Size(80, 80);
            this.plusBtn.TabIndex = 88;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Animated = true;
            this.equalBtn.AnimatedGIF = true;
            this.equalBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.equalBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.equalBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.equalBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.equalBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.equalBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.equalBtn.ForeColor = System.Drawing.Color.White;
            this.equalBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.equalBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_equal_sign_60;
            this.equalBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.equalBtn.Location = new System.Drawing.Point(285, 506);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.equalBtn.Size = new System.Drawing.Size(80, 80);
            this.equalBtn.TabIndex = 87;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // substractBtn
            // 
            this.substractBtn.Animated = true;
            this.substractBtn.AnimatedGIF = true;
            this.substractBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.substractBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.substractBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.substractBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.substractBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.substractBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substractBtn.ForeColor = System.Drawing.Color.White;
            this.substractBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.substractBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_subtract_60;
            this.substractBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.substractBtn.Location = new System.Drawing.Point(285, 245);
            this.substractBtn.Name = "substractBtn";
            this.substractBtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.substractBtn.Size = new System.Drawing.Size(80, 80);
            this.substractBtn.TabIndex = 86;
            this.substractBtn.Click += new System.EventHandler(this.substractBtn_Click);
            // 
            // cutBtn
            // 
            this.cutBtn.Animated = true;
            this.cutBtn.AnimatedGIF = true;
            this.cutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.cutBtn.ForeColor = System.Drawing.Color.White;
            this.cutBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.cutBtn.Image = global::EscopeWindowsApp.Properties.Resources.backspace_60;
            this.cutBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.cutBtn.Location = new System.Drawing.Point(285, 159);
            this.cutBtn.Name = "cutBtn";
            this.cutBtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.cutBtn.Size = new System.Drawing.Size(80, 80);
            this.cutBtn.TabIndex = 85;
            this.cutBtn.Click += new System.EventHandler(this.cutBtn_Click);
            // 
            // percentageBtn
            // 
            this.percentageBtn.Animated = true;
            this.percentageBtn.AnimatedGIF = true;
            this.percentageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.percentageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.percentageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.percentageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.percentageBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.percentageBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageBtn.ForeColor = System.Drawing.Color.White;
            this.percentageBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.percentageBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_percentage_64;
            this.percentageBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.percentageBtn.Location = new System.Drawing.Point(196, 159);
            this.percentageBtn.Name = "percentageBtn";
            this.percentageBtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.percentageBtn.Size = new System.Drawing.Size(80, 80);
            this.percentageBtn.TabIndex = 84;
            this.percentageBtn.Click += new System.EventHandler(this.percentageBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Animated = true;
            this.divideBtn.AnimatedGIF = true;
            this.divideBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.divideBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.divideBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.divideBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.divideBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.divideBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.ForeColor = System.Drawing.Color.White;
            this.divideBtn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.divideBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_divide_60;
            this.divideBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.divideBtn.Location = new System.Drawing.Point(107, 159);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.divideBtn.Size = new System.Drawing.Size(80, 80);
            this.divideBtn.TabIndex = 83;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 602);
            this.Controls.Add(this.multipleBtn);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.no0Btn);
            this.Controls.Add(this.no00Btn);
            this.Controls.Add(this.no3Btn);
            this.Controls.Add(this.no2Btn);
            this.Controls.Add(this.no1Btn);
            this.Controls.Add(this.no6Btn);
            this.Controls.Add(this.no5Btn);
            this.Controls.Add(this.no4Btn);
            this.Controls.Add(this.no9Btn);
            this.Controls.Add(this.no8Btn);
            this.Controls.Add(this.no7Btn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.substractBtn);
            this.Controls.Add(this.cutBtn);
            this.Controls.Add(this.percentageBtn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(385, 602);
            this.MinimumSize = new System.Drawing.Size(385, 602);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel headerPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox createUnitsCloseBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm calculatorBorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton clearBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton plusBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton equalBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton substractBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton cutBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton percentageBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton divideBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton dotBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton no0Btn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton no00Btn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton no3Btn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton no2Btn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton no1Btn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton no6Btn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton no5Btn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton no4Btn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton no9Btn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton no8Btn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton no7Btn;
        private System.Windows.Forms.Label numbersLabel;
        private System.Windows.Forms.Label finalNumLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton multipleBtn;
    }
}