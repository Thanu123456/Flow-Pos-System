namespace EscopeWindowsApp
{
    partial class DashBoardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.startDateTime = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.endDateTime = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.customeBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.todayBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.last7DaysBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Last30DaysBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.thisMonthBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.numOfOrderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.orderCountLabel = new System.Windows.Forms.Label();
            this.numberOrderLabel = new System.Windows.Forms.Label();
            this.totalRevenuePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.reveCountLabel = new System.Windows.Forms.Label();
            this.numberTrevenueLabel = new System.Windows.Forms.Label();
            this.totalProfitPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.countProfitLabel = new System.Windows.Forms.Label();
            this.numberTprofitLabel = new System.Windows.Forms.Label();
            this.grossRevenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.topProductsPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.totalCounterPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tNOPLabel = new System.Windows.Forms.Label();
            this.countOfProductLabel = new System.Windows.Forms.Label();
            this.tNOSLabel = new System.Windows.Forms.Label();
            this.countOFSupLabel = new System.Windows.Forms.Label();
            this.tNOCLabel = new System.Windows.Forms.Label();
            this.countOFCusLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.proUnderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.underStockDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.numOfOrderPanel.SuspendLayout();
            this.totalRevenuePanel.SuspendLayout();
            this.totalProfitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grossRevenueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topProductsPieChart)).BeginInit();
            this.totalCounterPanel.SuspendLayout();
            this.proUnderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.underStockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateTime
            // 
            this.startDateTime.BorderRadius = 8;
            this.startDateTime.Checked = true;
            this.startDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startDateTime.Location = new System.Drawing.Point(29, 12);
            this.startDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(200, 28);
            this.startDateTime.TabIndex = 0;
            this.startDateTime.Value = new System.DateTime(2025, 3, 9, 21, 35, 17, 763);
            // 
            // endDateTime
            // 
            this.endDateTime.BorderRadius = 8;
            this.endDateTime.Checked = true;
            this.endDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.endDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.endDateTime.Location = new System.Drawing.Point(260, 12);
            this.endDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.endDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(200, 28);
            this.endDateTime.TabIndex = 1;
            this.endDateTime.Value = new System.DateTime(2025, 3, 9, 21, 35, 17, 763);
            // 
            // customeBtn
            // 
            this.customeBtn.BorderRadius = 8;
            this.customeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customeBtn.ForeColor = System.Drawing.Color.White;
            this.customeBtn.Location = new System.Drawing.Point(1065, 12);
            this.customeBtn.Name = "customeBtn";
            this.customeBtn.Size = new System.Drawing.Size(121, 28);
            this.customeBtn.TabIndex = 2;
            this.customeBtn.Text = "Custome";
            // 
            // todayBtn
            // 
            this.todayBtn.BorderRadius = 8;
            this.todayBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.todayBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.todayBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.todayBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.todayBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.todayBtn.ForeColor = System.Drawing.Color.White;
            this.todayBtn.Location = new System.Drawing.Point(1211, 12);
            this.todayBtn.Name = "todayBtn";
            this.todayBtn.Size = new System.Drawing.Size(121, 28);
            this.todayBtn.TabIndex = 3;
            this.todayBtn.Text = "Today";
            // 
            // last7DaysBtn
            // 
            this.last7DaysBtn.BorderRadius = 8;
            this.last7DaysBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.last7DaysBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.last7DaysBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.last7DaysBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.last7DaysBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.last7DaysBtn.ForeColor = System.Drawing.Color.White;
            this.last7DaysBtn.Location = new System.Drawing.Point(1354, 12);
            this.last7DaysBtn.Name = "last7DaysBtn";
            this.last7DaysBtn.Size = new System.Drawing.Size(121, 28);
            this.last7DaysBtn.TabIndex = 4;
            this.last7DaysBtn.Text = "Last 7 Days";
            // 
            // Last30DaysBtn
            // 
            this.Last30DaysBtn.BorderRadius = 8;
            this.Last30DaysBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Last30DaysBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Last30DaysBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Last30DaysBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Last30DaysBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Last30DaysBtn.ForeColor = System.Drawing.Color.White;
            this.Last30DaysBtn.Location = new System.Drawing.Point(940, 222);
            this.Last30DaysBtn.Name = "Last30DaysBtn";
            this.Last30DaysBtn.Size = new System.Drawing.Size(121, 28);
            this.Last30DaysBtn.TabIndex = 5;
            this.Last30DaysBtn.Text = "Last 30 Days";
            // 
            // thisMonthBtn
            // 
            this.thisMonthBtn.BorderRadius = 8;
            this.thisMonthBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thisMonthBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thisMonthBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thisMonthBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thisMonthBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.thisMonthBtn.ForeColor = System.Drawing.Color.White;
            this.thisMonthBtn.Location = new System.Drawing.Point(1133, 222);
            this.thisMonthBtn.Name = "thisMonthBtn";
            this.thisMonthBtn.Size = new System.Drawing.Size(121, 28);
            this.thisMonthBtn.TabIndex = 6;
            this.thisMonthBtn.Text = "This Month";
            // 
            // numOfOrderPanel
            // 
            this.numOfOrderPanel.BorderThickness = 10;
            this.numOfOrderPanel.Controls.Add(this.orderCountLabel);
            this.numOfOrderPanel.Controls.Add(this.numberOrderLabel);
            this.numOfOrderPanel.FillColor = System.Drawing.Color.White;
            this.numOfOrderPanel.Location = new System.Drawing.Point(29, 81);
            this.numOfOrderPanel.Name = "numOfOrderPanel";
            this.numOfOrderPanel.Size = new System.Drawing.Size(229, 125);
            this.numOfOrderPanel.TabIndex = 7;
            // 
            // orderCountLabel
            // 
            this.orderCountLabel.AutoSize = true;
            this.orderCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderCountLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCountLabel.Location = new System.Drawing.Point(65, 60);
            this.orderCountLabel.Name = "orderCountLabel";
            this.orderCountLabel.Size = new System.Drawing.Size(94, 32);
            this.orderCountLabel.TabIndex = 1;
            this.orderCountLabel.Text = "10000";
            // 
            // numberOrderLabel
            // 
            this.numberOrderLabel.AutoSize = true;
            this.numberOrderLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberOrderLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOrderLabel.Location = new System.Drawing.Point(21, 11);
            this.numberOrderLabel.Name = "numberOrderLabel";
            this.numberOrderLabel.Size = new System.Drawing.Size(188, 24);
            this.numberOrderLabel.TabIndex = 0;
            this.numberOrderLabel.Text = "Number Of Oders";
            // 
            // totalRevenuePanel
            // 
            this.totalRevenuePanel.BorderThickness = 10;
            this.totalRevenuePanel.Controls.Add(this.reveCountLabel);
            this.totalRevenuePanel.Controls.Add(this.numberTrevenueLabel);
            this.totalRevenuePanel.FillColor = System.Drawing.Color.White;
            this.totalRevenuePanel.Location = new System.Drawing.Point(333, 81);
            this.totalRevenuePanel.Name = "totalRevenuePanel";
            this.totalRevenuePanel.Size = new System.Drawing.Size(459, 125);
            this.totalRevenuePanel.TabIndex = 8;
            // 
            // reveCountLabel
            // 
            this.reveCountLabel.AutoSize = true;
            this.reveCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.reveCountLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reveCountLabel.Location = new System.Drawing.Point(65, 60);
            this.reveCountLabel.Name = "reveCountLabel";
            this.reveCountLabel.Size = new System.Drawing.Size(94, 32);
            this.reveCountLabel.TabIndex = 1;
            this.reveCountLabel.Text = "10000";
            // 
            // numberTrevenueLabel
            // 
            this.numberTrevenueLabel.AutoSize = true;
            this.numberTrevenueLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberTrevenueLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTrevenueLabel.Location = new System.Drawing.Point(21, 11);
            this.numberTrevenueLabel.Name = "numberTrevenueLabel";
            this.numberTrevenueLabel.Size = new System.Drawing.Size(154, 24);
            this.numberTrevenueLabel.TabIndex = 0;
            this.numberTrevenueLabel.Text = "Total Revenue";
            // 
            // totalProfitPanel
            // 
            this.totalProfitPanel.BorderThickness = 10;
            this.totalProfitPanel.Controls.Add(this.countProfitLabel);
            this.totalProfitPanel.Controls.Add(this.numberTprofitLabel);
            this.totalProfitPanel.FillColor = System.Drawing.Color.White;
            this.totalProfitPanel.Location = new System.Drawing.Point(869, 81);
            this.totalProfitPanel.Name = "totalProfitPanel";
            this.totalProfitPanel.Size = new System.Drawing.Size(750, 125);
            this.totalProfitPanel.TabIndex = 9;
            // 
            // countProfitLabel
            // 
            this.countProfitLabel.AutoSize = true;
            this.countProfitLabel.BackColor = System.Drawing.Color.Transparent;
            this.countProfitLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countProfitLabel.Location = new System.Drawing.Point(65, 60);
            this.countProfitLabel.Name = "countProfitLabel";
            this.countProfitLabel.Size = new System.Drawing.Size(94, 32);
            this.countProfitLabel.TabIndex = 1;
            this.countProfitLabel.Text = "10000";
            // 
            // numberTprofitLabel
            // 
            this.numberTprofitLabel.AutoSize = true;
            this.numberTprofitLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberTprofitLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTprofitLabel.Location = new System.Drawing.Point(21, 11);
            this.numberTprofitLabel.Name = "numberTprofitLabel";
            this.numberTprofitLabel.Size = new System.Drawing.Size(122, 24);
            this.numberTprofitLabel.TabIndex = 0;
            this.numberTprofitLabel.Text = "Total Profit";
            // 
            // grossRevenueChart
            // 
            chartArea1.Name = "ChartArea1";
            this.grossRevenueChart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.grossRevenueChart.Legends.Add(legend1);
            this.grossRevenueChart.Location = new System.Drawing.Point(29, 277);
            this.grossRevenueChart.Name = "grossRevenueChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grossRevenueChart.Series.Add(series1);
            this.grossRevenueChart.Size = new System.Drawing.Size(763, 300);
            this.grossRevenueChart.TabIndex = 10;
            this.grossRevenueChart.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Gross Revenue";
            this.grossRevenueChart.Titles.Add(title1);
            // 
            // topProductsPieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.topProductsPieChart.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.topProductsPieChart.Legends.Add(legend2);
            this.topProductsPieChart.Location = new System.Drawing.Point(869, 277);
            this.topProductsPieChart.Name = "topProductsPieChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.topProductsPieChart.Series.Add(series2);
            this.topProductsPieChart.Size = new System.Drawing.Size(570, 475);
            this.topProductsPieChart.TabIndex = 11;
            this.topProductsPieChart.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Top 5 Produts";
            this.topProductsPieChart.Titles.Add(title2);
            // 
            // totalCounterPanel
            // 
            this.totalCounterPanel.BorderThickness = 10;
            this.totalCounterPanel.Controls.Add(this.tNOPLabel);
            this.totalCounterPanel.Controls.Add(this.countOfProductLabel);
            this.totalCounterPanel.Controls.Add(this.tNOSLabel);
            this.totalCounterPanel.Controls.Add(this.countOFSupLabel);
            this.totalCounterPanel.Controls.Add(this.tNOCLabel);
            this.totalCounterPanel.Controls.Add(this.countOFCusLabel);
            this.totalCounterPanel.Controls.Add(this.label8);
            this.totalCounterPanel.FillColor = System.Drawing.Color.White;
            this.totalCounterPanel.Location = new System.Drawing.Point(29, 627);
            this.totalCounterPanel.Name = "totalCounterPanel";
            this.totalCounterPanel.Size = new System.Drawing.Size(262, 284);
            this.totalCounterPanel.TabIndex = 12;
            // 
            // tNOPLabel
            // 
            this.tNOPLabel.AutoSize = true;
            this.tNOPLabel.BackColor = System.Drawing.Color.Transparent;
            this.tNOPLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNOPLabel.Location = new System.Drawing.Point(22, 191);
            this.tNOPLabel.Name = "tNOPLabel";
            this.tNOPLabel.Size = new System.Drawing.Size(197, 22);
            this.tNOPLabel.TabIndex = 14;
            this.tNOPLabel.Text = "Number Of Products";
            // 
            // countOfProductLabel
            // 
            this.countOfProductLabel.AutoSize = true;
            this.countOfProductLabel.BackColor = System.Drawing.Color.Transparent;
            this.countOfProductLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countOfProductLabel.Location = new System.Drawing.Point(22, 220);
            this.countOfProductLabel.Name = "countOfProductLabel";
            this.countOfProductLabel.Size = new System.Drawing.Size(65, 22);
            this.countOfProductLabel.TabIndex = 13;
            this.countOfProductLabel.Text = "10000";
            // 
            // tNOSLabel
            // 
            this.tNOSLabel.AutoSize = true;
            this.tNOSLabel.BackColor = System.Drawing.Color.Transparent;
            this.tNOSLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNOSLabel.Location = new System.Drawing.Point(21, 119);
            this.tNOSLabel.Name = "tNOSLabel";
            this.tNOSLabel.Size = new System.Drawing.Size(201, 22);
            this.tNOSLabel.TabIndex = 14;
            this.tNOSLabel.Text = "Number Of Suppliers";
            // 
            // countOFSupLabel
            // 
            this.countOFSupLabel.AutoSize = true;
            this.countOFSupLabel.BackColor = System.Drawing.Color.Transparent;
            this.countOFSupLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countOFSupLabel.Location = new System.Drawing.Point(21, 148);
            this.countOFSupLabel.Name = "countOFSupLabel";
            this.countOFSupLabel.Size = new System.Drawing.Size(65, 22);
            this.countOFSupLabel.TabIndex = 13;
            this.countOFSupLabel.Text = "10000";
            // 
            // tNOCLabel
            // 
            this.tNOCLabel.AutoSize = true;
            this.tNOCLabel.BackColor = System.Drawing.Color.Transparent;
            this.tNOCLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNOCLabel.Location = new System.Drawing.Point(22, 53);
            this.tNOCLabel.Name = "tNOCLabel";
            this.tNOCLabel.Size = new System.Drawing.Size(213, 22);
            this.tNOCLabel.TabIndex = 2;
            this.tNOCLabel.Text = "Number Of Customers";
            // 
            // countOFCusLabel
            // 
            this.countOFCusLabel.AutoSize = true;
            this.countOFCusLabel.BackColor = System.Drawing.Color.Transparent;
            this.countOFCusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countOFCusLabel.Location = new System.Drawing.Point(22, 82);
            this.countOFCusLabel.Name = "countOFCusLabel";
            this.countOFCusLabel.Size = new System.Drawing.Size(65, 22);
            this.countOFCusLabel.TabIndex = 1;
            this.countOFCusLabel.Text = "10000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Counter";
            // 
            // proUnderPanel
            // 
            this.proUnderPanel.BorderThickness = 10;
            this.proUnderPanel.Controls.Add(this.underStockDataGridView);
            this.proUnderPanel.Controls.Add(this.label20);
            this.proUnderPanel.FillColor = System.Drawing.Color.White;
            this.proUnderPanel.Location = new System.Drawing.Point(345, 627);
            this.proUnderPanel.Name = "proUnderPanel";
            this.proUnderPanel.Size = new System.Drawing.Size(447, 284);
            this.proUnderPanel.TabIndex = 13;
            // 
            // underStockDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.underStockDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.underStockDataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.underStockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.underStockDataGridView.ColumnHeadersHeight = 15;
            this.underStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.underStockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.underStockDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.underStockDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.underStockDataGridView.Location = new System.Drawing.Point(15, 53);
            this.underStockDataGridView.Name = "underStockDataGridView";
            this.underStockDataGridView.RowHeadersVisible = false;
            this.underStockDataGridView.Size = new System.Drawing.Size(418, 214);
            this.underStockDataGridView.TabIndex = 1;
            this.underStockDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.underStockDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.underStockDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.underStockDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.underStockDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.underStockDataGridView.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.underStockDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.underStockDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.underStockDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.underStockDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underStockDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.underStockDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.underStockDataGridView.ThemeStyle.HeaderStyle.Height = 15;
            this.underStockDataGridView.ThemeStyle.ReadOnly = false;
            this.underStockDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.underStockDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.underStockDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underStockDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.underStockDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.underStockDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.underStockDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(258, 28);
            this.label20.TabIndex = 0;
            this.label20.Text = "Products Understock";
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.proUnderPanel);
            this.Controls.Add(this.totalCounterPanel);
            this.Controls.Add(this.topProductsPieChart);
            this.Controls.Add(this.grossRevenueChart);
            this.Controls.Add(this.totalProfitPanel);
            this.Controls.Add(this.totalRevenuePanel);
            this.Controls.Add(this.numOfOrderPanel);
            this.Controls.Add(this.thisMonthBtn);
            this.Controls.Add(this.Last30DaysBtn);
            this.Controls.Add(this.last7DaysBtn);
            this.Controls.Add(this.todayBtn);
            this.Controls.Add(this.customeBtn);
            this.Controls.Add(this.endDateTime);
            this.Controls.Add(this.startDateTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoardForm";
            this.Text = "DashBoardForm";
            this.numOfOrderPanel.ResumeLayout(false);
            this.numOfOrderPanel.PerformLayout();
            this.totalRevenuePanel.ResumeLayout(false);
            this.totalRevenuePanel.PerformLayout();
            this.totalProfitPanel.ResumeLayout(false);
            this.totalProfitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grossRevenueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topProductsPieChart)).EndInit();
            this.totalCounterPanel.ResumeLayout(false);
            this.totalCounterPanel.PerformLayout();
            this.proUnderPanel.ResumeLayout(false);
            this.proUnderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.underStockDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker startDateTime;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker endDateTime;
        private Siticone.Desktop.UI.WinForms.SiticoneButton customeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton todayBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton last7DaysBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Last30DaysBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton thisMonthBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel numOfOrderPanel;
        private System.Windows.Forms.Label orderCountLabel;
        private System.Windows.Forms.Label numberOrderLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel totalRevenuePanel;
        private System.Windows.Forms.Label reveCountLabel;
        private System.Windows.Forms.Label numberTrevenueLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel totalProfitPanel;
        private System.Windows.Forms.Label countProfitLabel;
        private System.Windows.Forms.Label numberTprofitLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart grossRevenueChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart topProductsPieChart;
        private Siticone.Desktop.UI.WinForms.SiticonePanel totalCounterPanel;
        private System.Windows.Forms.Label tNOCLabel;
        private System.Windows.Forms.Label countOFCusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tNOPLabel;
        private System.Windows.Forms.Label countOfProductLabel;
        private System.Windows.Forms.Label tNOSLabel;
        private System.Windows.Forms.Label countOFSupLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel proUnderPanel;
        private System.Windows.Forms.Label label20;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView underStockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}