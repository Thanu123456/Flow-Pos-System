namespace EscopeWindowsApp
{
    partial class Reports
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
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.topProductsPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleRetReportBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.creditReportBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.logHistoryBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.purchasesReportBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.supReportBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cusReportBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.stockReportBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.saleReportBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.expReportBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topProductsPieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lineAnnotation1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            lineAnnotation1.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            lineAnnotation1.Name = "LineAnnotation1";
            this.chart1.Annotations.Add(lineAnnotation1);
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 10;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.Rotation = 20;
            chartArea1.Area3DStyle.WallWidth = 1;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(658, 31);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.MinimumSize = new System.Drawing.Size(420, 316);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(675, 316);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // topProductsPieChart
            // 
            this.topProductsPieChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lineAnnotation2.AllowAnchorMoving = true;
            lineAnnotation2.AllowMoving = true;
            lineAnnotation2.Name = "LineAnnotation1";
            this.topProductsPieChart.Annotations.Add(lineAnnotation2);
            this.topProductsPieChart.BackColor = System.Drawing.Color.Transparent;
            this.topProductsPieChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topProductsPieChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 74.52099F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 12.94635F;
            chartArea2.ShadowColor = System.Drawing.Color.LightGray;
            this.topProductsPieChart.ChartAreas.Add(chartArea2);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Segoe UI", 8F);
            legend1.InterlacedRows = true;
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend1.TitleAlignment = System.Drawing.StringAlignment.Far;
            legend1.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topProductsPieChart.Legends.Add(legend1);
            this.topProductsPieChart.Location = new System.Drawing.Point(706, 347);
            this.topProductsPieChart.Margin = new System.Windows.Forms.Padding(0);
            this.topProductsPieChart.Name = "topProductsPieChart";
            this.topProductsPieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ShadowColor = System.Drawing.Color.Gray;
            series2.ShadowOffset = 1;
            this.topProductsPieChart.Series.Add(series2);
            this.topProductsPieChart.Size = new System.Drawing.Size(671, 399);
            this.topProductsPieChart.TabIndex = 12;
            this.topProductsPieChart.Text = "Top 5 Products";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Top 5 Products by Sales Quantity (All Time)";
            this.topProductsPieChart.Titles.Add(title1);
            this.topProductsPieChart.Click += new System.EventHandler(this.topProductsPieChart_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.FillColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 751);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(1386, 37);
            this.siticonePanel1.TabIndex = 15;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Animated = true;
            this.siticoneButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.siticoneButton1.BorderRadius = 8;
            this.siticoneButton1.BorderThickness = 2;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.siticoneButton1.Image = global::EscopeWindowsApp.Properties.Resources.icons8_return_purchase_64;
            this.siticoneButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton1.ImageOffset = new System.Drawing.Point(5, 0);
            this.siticoneButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.siticoneButton1.Location = new System.Drawing.Point(358, 607);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(297, 125);
            this.siticoneButton1.TabIndex = 21;
            this.siticoneButton1.Text = "    PURCHASES RETURN REPORT";
            this.siticoneButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // saleRetReportBtn
            // 
            this.saleRetReportBtn.Animated = true;
            this.saleRetReportBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.saleRetReportBtn.BorderRadius = 8;
            this.saleRetReportBtn.BorderThickness = 2;
            this.saleRetReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleRetReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleRetReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleRetReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleRetReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.saleRetReportBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleRetReportBtn.ForeColor = System.Drawing.Color.White;
            this.saleRetReportBtn.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.saleRetReportBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_depreciation_48;
            this.saleRetReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.saleRetReportBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.saleRetReportBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.saleRetReportBtn.Location = new System.Drawing.Point(29, 607);
            this.saleRetReportBtn.Name = "saleRetReportBtn";
            this.saleRetReportBtn.Size = new System.Drawing.Size(297, 125);
            this.saleRetReportBtn.TabIndex = 20;
            this.saleRetReportBtn.Text = "SALES RETURN REPORT";
            this.saleRetReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.saleRetReportBtn.Click += new System.EventHandler(this.saleRetReportBtn_Click);
            // 
            // creditReportBtn
            // 
            this.creditReportBtn.Animated = true;
            this.creditReportBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.creditReportBtn.BorderRadius = 8;
            this.creditReportBtn.BorderThickness = 2;
            this.creditReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.creditReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.creditReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.creditReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.creditReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.creditReportBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditReportBtn.ForeColor = System.Drawing.Color.White;
            this.creditReportBtn.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.creditReportBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_credit_50;
            this.creditReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.creditReportBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.creditReportBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.creditReportBtn.Location = new System.Drawing.Point(358, 466);
            this.creditReportBtn.Name = "creditReportBtn";
            this.creditReportBtn.Size = new System.Drawing.Size(297, 125);
            this.creditReportBtn.TabIndex = 19;
            this.creditReportBtn.Text = "CREADIT REPORT";
            this.creditReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.creditReportBtn.Click += new System.EventHandler(this.creditReportBtn_Click);
            // 
            // logHistoryBtn
            // 
            this.logHistoryBtn.Animated = true;
            this.logHistoryBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.logHistoryBtn.BorderRadius = 8;
            this.logHistoryBtn.BorderThickness = 2;
            this.logHistoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logHistoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logHistoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logHistoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logHistoryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logHistoryBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logHistoryBtn.ForeColor = System.Drawing.Color.White;
            this.logHistoryBtn.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.logHistoryBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_login_64;
            this.logHistoryBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logHistoryBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.logHistoryBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.logHistoryBtn.Location = new System.Drawing.Point(29, 466);
            this.logHistoryBtn.Name = "logHistoryBtn";
            this.logHistoryBtn.Size = new System.Drawing.Size(297, 125);
            this.logHistoryBtn.TabIndex = 18;
            this.logHistoryBtn.Text = "LOGS HISTORY";
            this.logHistoryBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.logHistoryBtn.Click += new System.EventHandler(this.logHistoryBtn_Click);
            // 
            // purchasesReportBtn
            // 
            this.purchasesReportBtn.Animated = true;
            this.purchasesReportBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.purchasesReportBtn.BorderRadius = 8;
            this.purchasesReportBtn.BorderThickness = 2;
            this.purchasesReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.purchasesReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.purchasesReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.purchasesReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.purchasesReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.purchasesReportBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasesReportBtn.ForeColor = System.Drawing.Color.White;
            this.purchasesReportBtn.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.purchasesReportBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_buy_64;
            this.purchasesReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.purchasesReportBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.purchasesReportBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.purchasesReportBtn.Location = new System.Drawing.Point(358, 323);
            this.purchasesReportBtn.Name = "purchasesReportBtn";
            this.purchasesReportBtn.Size = new System.Drawing.Size(297, 125);
            this.purchasesReportBtn.TabIndex = 17;
            this.purchasesReportBtn.Text = "        PURCHASES REPORT";
            this.purchasesReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.purchasesReportBtn.Click += new System.EventHandler(this.purchasesReportBtn_Click);
            // 
            // supReportBtn
            // 
            this.supReportBtn.Animated = true;
            this.supReportBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.supReportBtn.BorderRadius = 8;
            this.supReportBtn.BorderThickness = 2;
            this.supReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.supReportBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supReportBtn.ForeColor = System.Drawing.Color.White;
            this.supReportBtn.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.supReportBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_supplier_64;
            this.supReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.supReportBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.supReportBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.supReportBtn.Location = new System.Drawing.Point(29, 323);
            this.supReportBtn.Name = "supReportBtn";
            this.supReportBtn.Size = new System.Drawing.Size(297, 125);
            this.supReportBtn.TabIndex = 16;
            this.supReportBtn.Text = "         SUPPLIERS REPORT";
            this.supReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.supReportBtn.Click += new System.EventHandler(this.supReportBtn_Click);
            // 
            // cusReportBtn
            // 
            this.cusReportBtn.Animated = true;
            this.cusReportBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cusReportBtn.BorderRadius = 8;
            this.cusReportBtn.BorderThickness = 2;
            this.cusReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cusReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cusReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cusReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cusReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cusReportBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusReportBtn.ForeColor = System.Drawing.Color.White;
            this.cusReportBtn.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.cusReportBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_customer_50;
            this.cusReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cusReportBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.cusReportBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.cusReportBtn.Location = new System.Drawing.Point(358, 176);
            this.cusReportBtn.Name = "cusReportBtn";
            this.cusReportBtn.Size = new System.Drawing.Size(297, 125);
            this.cusReportBtn.TabIndex = 4;
            this.cusReportBtn.Text = "     CUSTOMERS REPORT";
            this.cusReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cusReportBtn.Click += new System.EventHandler(this.cusReportBtn_Click);
            // 
            // stockReportBtn
            // 
            this.stockReportBtn.Animated = true;
            this.stockReportBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.stockReportBtn.BorderRadius = 8;
            this.stockReportBtn.BorderThickness = 2;
            this.stockReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stockReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stockReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stockReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stockReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.stockReportBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockReportBtn.ForeColor = System.Drawing.Color.White;
            this.stockReportBtn.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.stockReportBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_stock_64;
            this.stockReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stockReportBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.stockReportBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.stockReportBtn.Location = new System.Drawing.Point(29, 176);
            this.stockReportBtn.Name = "stockReportBtn";
            this.stockReportBtn.Size = new System.Drawing.Size(297, 125);
            this.stockReportBtn.TabIndex = 2;
            this.stockReportBtn.Text = "STOCK REPORT";
            this.stockReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.stockReportBtn.Click += new System.EventHandler(this.stockReportBtn_Click);
            // 
            // saleReportBtn
            // 
            this.saleReportBtn.Animated = true;
            this.saleReportBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.saleReportBtn.BorderRadius = 8;
            this.saleReportBtn.BorderThickness = 2;
            this.saleReportBtn.CustomBorderColor = System.Drawing.Color.Silver;
            this.saleReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.saleReportBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReportBtn.ForeColor = System.Drawing.Color.White;
            this.saleReportBtn.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.saleReportBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_total_sales_50__2_;
            this.saleReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.saleReportBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.saleReportBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.saleReportBtn.Location = new System.Drawing.Point(29, 31);
            this.saleReportBtn.Name = "saleReportBtn";
            this.saleReportBtn.Size = new System.Drawing.Size(297, 125);
            this.saleReportBtn.TabIndex = 1;
            this.saleReportBtn.Text = "SALES REPORT";
            this.saleReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.saleReportBtn.Click += new System.EventHandler(this.saleReportBtn_Click);
            // 
            // expReportBtn
            // 
            this.expReportBtn.Animated = true;
            this.expReportBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.expReportBtn.BorderRadius = 8;
            this.expReportBtn.BorderThickness = 2;
            this.expReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.expReportBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expReportBtn.ForeColor = System.Drawing.Color.White;
            this.expReportBtn.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.expReportBtn.Image = global::EscopeWindowsApp.Properties.Resources.icons8_initiate_money_transfer_48;
            this.expReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.expReportBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.expReportBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.expReportBtn.Location = new System.Drawing.Point(358, 31);
            this.expReportBtn.Name = "expReportBtn";
            this.expReportBtn.Size = new System.Drawing.Size(297, 125);
            this.expReportBtn.TabIndex = 0;
            this.expReportBtn.Text = "          EXPENSES REPORT";
            this.expReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expReportBtn.Click += new System.EventHandler(this.expReportBtn_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.saleRetReportBtn);
            this.Controls.Add(this.creditReportBtn);
            this.Controls.Add(this.logHistoryBtn);
            this.Controls.Add(this.purchasesReportBtn);
            this.Controls.Add(this.supReportBtn);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.topProductsPieChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cusReportBtn);
            this.Controls.Add(this.stockReportBtn);
            this.Controls.Add(this.saleReportBtn);
            this.Controls.Add(this.expReportBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topProductsPieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton expReportBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleReportBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton stockReportBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton cusReportBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart topProductsPieChart;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton purchasesReportBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton supReportBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton logHistoryBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton creditReportBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton saleRetReportBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
    }
}