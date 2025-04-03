using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace EscopeWindowsApp
{
    public partial class SideBarForm : Form
    {
        DashBoardForm dashBoardForm;
        Production productionForm;
        Category categoryForm;
        Variations variationsForm;
        Brands brandForm;
        Units unitForm;
        BaseUnit baseUnitForm;
        SalesForm salesForm;
        SaleReturnForm salesReturnForm;
        Barcode barcodeForm;
        ExpensesForm expensesForm;
        ExpensesCategory expensesCategoryForm;
        CustomerForm customerForm;
        SupplierForm supplierForm;
        UserForm userForm;
        Quotations quatationsForm; // Added for QuatationsForm
        WarehouseForm warehouseForm; // Added for WarehouseForm
        AdjustmentsForm adjustmentsForm; // Added for AdjustmentsForm
        Transfer transferForm; // Added for Transfer
        Reports reportsForm; // Added for Reports
        Setting settingForm; // Added for Setting
        private Control currentCheckedButton = null; // Track the currently checked control
        private Color checkedColor = Color.LightBlue; // Color when checked
        private Color uncheckedColor = SystemColors.Control; // Default color
        private Timer timeTimer; // Timer for timeLabel
        private Timer dateTimer; // Timer for dateLabel

        public SideBarForm()
        {
            InitializeComponent();

            // Disable horizontal scrolling
            sideBarPanel.AutoScroll = false;
            sideBarPanel.HorizontalScroll.Visible = false;
            sideBarPanel.HorizontalScroll.Enabled = false;
            sideBarPanel.VerticalScroll.Visible = true;
            sideBarPanel.VerticalScroll.Enabled = true;

            // Set initial button styles
            SetButtonStyles();

            // Initialize and start the time timer
            timeTimer = new Timer();
            timeTimer.Interval = 1000; // Update every 1 second
            timeTimer.Tick += TimeTimer_Tick;
            timeTimer.Start();

            // Initialize and start the date timer
            dateTimer = new Timer();
            dateTimer.Interval = 1000; // Update every 1 second
            dateTimer.Tick += DateTimer_Tick;
            dateTimer.Start();

            // Ensure labels can display their content
            timeLabel.AutoSize = false; // Still needed for multi-line display
            dateLabel.AutoSize = false; // Allow manual sizing
        }

        private void SetButtonStyles()
        {
            Control[] sidebarButtons = new Control[]
            {
                manuBtn, expensesBtn, salesBtn, peoplesBtn, dashboardBtn,
                adjBtn, quatationBtn, wareHouseBtn, transferBtn, reportsBtn,
                settingBtn, sidebarBtn, proBtn, proCatBtn, varBtn,
                brandBtn, unitsBtn, baseUnitBtn, salesListBtn, salesRetBtn,
                barcodePrtBtn, creExpBtn, expCatBtn, cusBtn, supBtn, userBtn
            };

            foreach (Control ctrl in sidebarButtons)
            {
                ctrl.BackColor = uncheckedColor;
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
        }

        private void SideBarForm_Load(object sender, EventArgs e)
        {
        }

        bool manuExpand = false;
        bool purchesesExpand = false;
        bool salesExpand = false;
        bool peopleExpand = false;
        bool sideBarExpand = true;

        private void ExpandSidebarIfCollapsed()
        {
            if (sideBarExpand)
            {
                sidebarTransition.Start();
            }
        }

        private void CollapseAllPanels()
        {
            if (manuExpand)
            {
                manuTransition.Start();
            }
            if (purchesesExpand)
            {
                purchesTransition.Start();
            }
            if (salesExpand)
            {
                salesTransition.Start();
            }
            if (peopleExpand)
            {
                peoplesTransition.Start();
            }
        }

        private void CheckButton(Control control)
        {
            if (currentCheckedButton != null && currentCheckedButton != control)
            {
                currentCheckedButton.BackColor = uncheckedColor;
            }
            control.BackColor = checkedColor;
            currentCheckedButton = control;
        }

        // Timer Tick event for timeLabel
        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt") + "\n" + DateTime.Now.ToString("yyyy-MM-dd");
            // Example: "02:35:42 PM\n2025-03-20"
        }

        // Timer Tick event for dateLabel with day, fixed to 20 characters
        private void DateTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy");
            // Example: "Thu, Mar 20, 2025" (20 characters)
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
            // Do nothing - time cannot be stopped
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {
            // Do nothing - date cannot be stopped
        }

        // Manu Panel
        private void manuTransition_Tick(object sender, EventArgs e)
        {
            if (manuExpand)
            {
                manuLayoutPanel.Height -= 10;
                if (manuLayoutPanel.Height <= 41)
                {
                    manuTransition.Stop();
                    manuExpand = false;
                    sideBarPanel.AutoScroll = false;
                }
            }
            else
            {
                manuLayoutPanel.Height += 10;
                if (manuLayoutPanel.Height >= 327)
                {
                    manuTransition.Stop();
                    manuExpand = true;
                    sideBarPanel.AutoScroll = true;
                    sideBarPanel.AutoScrollMinSize = new Size(0, 816);
                    sideBarPanel.HorizontalScroll.Visible = false;
                    sideBarPanel.HorizontalScroll.Enabled = false;
                    sideBarPanel.VerticalScroll.Visible = true;
                    sideBarPanel.VerticalScroll.Enabled = true;
                }
            }
        }

        private void manuBtn_Click(object sender, EventArgs e)
        {
            CheckButton(manuBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (!manuExpand)
            {
                manuTransition.Start();
            }
        }

        // Purchases Panel
        private void purchesTransition_Tick(object sender, EventArgs e)
        {
            if (purchesesExpand)
            {
                purchLayoutPanel.Height -= 10;
                if (purchLayoutPanel.Height <= 41)
                {
                    purchesTransition.Stop();
                    purchesesExpand = false;
                }
            }
            else
            {
                purchLayoutPanel.Height += 10;
                if (purchLayoutPanel.Height >= 123)
                {
                    purchesTransition.Stop();
                    purchesesExpand = true;
                }
            }
        }

        private void ExpensesBtn_Click(object sender, EventArgs e)
        {
            CheckButton(expensesBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (!purchesesExpand)
            {
                purchesTransition.Start();
            }
        }

        // Sales Panel
        private void salesTransition_Tick(object sender, EventArgs e)
        {
            if (salesExpand)
            {
                salesLayoutPanel.Height -= 10;
                if (salesLayoutPanel.Height <= 41)
                {
                    salesTransition.Stop();
                    salesExpand = false;
                }
            }
            else
            {
                salesLayoutPanel.Height += 10;
                if (salesLayoutPanel.Height >= 123)
                {
                    salesTransition.Stop();
                    salesExpand = true;
                }
            }
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            CheckButton(salesBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (!salesExpand)
            {
                salesTransition.Start();
            }
        }

        // People Panel
        private void peoplesTransition_Tick(object sender, EventArgs e)
        {
            if (peopleExpand)
            {
                peoplesLayoutPanel.Height -= 10;
                if (peoplesLayoutPanel.Height <= 41)
                {
                    peoplesTransition.Stop();
                    peopleExpand = false;
                }
            }
            else
            {
                peoplesLayoutPanel.Height += 10;
                if (peoplesLayoutPanel.Height >= 167)
                {
                    peoplesTransition.Stop();
                    peopleExpand = true;
                }
            }
        }

        private void peoplesBtn_Click(object sender, EventArgs e)
        {
            CheckButton(peoplesBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (!peopleExpand)
            {
                peoplesTransition.Start();
            }
        }

        // Sidebar Panel
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBarPanel.Width += 20;
                if (sideBarPanel.Width >= 250)
                {
                    sideBarPanel.Width = 250; // Force it to exactly 250
                    sidebarTransition.Stop();
                    sideBarExpand = false;
                    // Set all button panel widths to exactly 250
                    dashBtnPanel.Width = 250;
                    settingBtnPanel.Width = 250;
                    adjBtnPanel.Width = 250;
                    varBtnPanel.Width = 250;
                    reportsBtnPanel.Width = 250;
                    transferBtnPanel.Width = 250;
                    wareHouseBtnPanel.Width = 250;
                    userBtnPanel.Width = 250;
                    supBtnPanel.Width = 250;
                    cusBtnPanel.Width = 250;
                    peoplesBtnPanel.Width = 250;
                    expPanel.Width = 250;
                    creExpBtnPanel.Width = 250;
                    expCatBtnPanel.Width = 250;
                    salesBtnPanel.Width = 250;
                    salesListBtnPanel.Width = 250;
                    salesRetBtnPanel.Width = 250;
                    qutationBtnPanel.Width = 250;
                    barcodePrtBtnPanel.Width = 250;
                    baseUnitBtnPanel.Width = 250;
                    unitsBtnPanel.Width = 250;
                    brandBtnPanel.Width = 250;
                    proCatBtnPanel.Width = 250;
                    proBtnPanel.Width = 250;
                    manuBtnPanel.Width = 250;
                    sidebarBtnPanel.Width = 250;
                }
            }
            else
            {
                sideBarPanel.Width -= 20;
                if (sideBarPanel.Width <= 56)
                {
                    sideBarPanel.Width = 56; // Force it to exactly 56 when collapsed
                    sidebarTransition.Stop();
                    sideBarExpand = true;
                    dashBtnPanel.Width = 56;
                    settingBtnPanel.Width = 56;
                    adjBtnPanel.Width = 56;
                    varBtnPanel.Width = 56;
                    reportsBtnPanel.Width = 56;
                    transferBtnPanel.Width = 56;
                    wareHouseBtnPanel.Width = 56;
                    userBtnPanel.Width = 56;
                    supBtnPanel.Width = 56;
                    cusBtnPanel.Width = 56;
                    peoplesBtnPanel.Width = 56;
                    expCatBtnPanel.Width = 56;
                    expPanel.Width = 56;
                    creExpBtnPanel.Width = 56;
                    salesBtnPanel.Width = 56;
                    salesListBtnPanel.Width = 56;
                    salesRetBtnPanel.Width = 56;
                    qutationBtnPanel.Width = 56;
                    barcodePrtBtnPanel.Width = 56;
                    baseUnitBtnPanel.Width = 56;
                    unitsBtnPanel.Width = 56;
                    brandBtnPanel.Width = 56;
                    proCatBtnPanel.Width = 56;
                    proBtnPanel.Width = 56;
                    manuBtnPanel.Width = 56;
                    sidebarBtnPanel.Width = 56;
                    CollapseAllPanels();
                }
            }
        }

        private void sidebarBtn_Click(object sender, EventArgs e)
        {
            CheckButton(sidebarBtn);
            sidebarTransition.Start();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            CheckButton(dashboardBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (dashBoardForm == null)
            {
                dashBoardForm = new DashBoardForm();
                dashBoardForm.FormClosed += DashBoardForm_FormClosed;
                dashBoardForm.MdiParent = this;
                dashBoardForm.Dock = DockStyle.Fill;
                dashBoardForm.Show();
            }
            else
            {
                dashBoardForm.Activate();
                dashBoardForm.Show();
            }
        }

        private void DashBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashBoardForm = null;
        }

        private void sideBarPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void adjBtn_Click(object sender, EventArgs e)
        {
            CheckButton(adjBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (adjustmentsForm == null)
            {
                adjustmentsForm = new AdjustmentsForm();
                adjustmentsForm.FormClosed += AdjustmentsForm_FormClosed;
                adjustmentsForm.MdiParent = this;
                adjustmentsForm.Dock = DockStyle.Fill;
                adjustmentsForm.Show();
            }
            else
            {
                adjustmentsForm.Activate();
                adjustmentsForm.Show();
            }
        }

        private void AdjustmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            adjustmentsForm = null;
        }

        private void quatationBtn_Click(object sender, EventArgs e)
        {
            CheckButton(quatationBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (quatationsForm == null)
            {
                quatationsForm = new Quotations();
                quatationsForm.FormClosed += QuatationsForm_FormClosed;
                quatationsForm.MdiParent = this;
                quatationsForm.Dock = DockStyle.Fill;
                quatationsForm.Show();
            }
            else
            {
                quatationsForm.Activate();
                quatationsForm.Show();
            }
        }

        private void QuatationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            quatationsForm = null;
        }

        private void wareHouseBtn_Click(object sender, EventArgs e)
        {
            CheckButton(wareHouseBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (warehouseForm == null)
            {
                warehouseForm = new WarehouseForm();
                warehouseForm.FormClosed += WarehouseForm_FormClosed;
                warehouseForm.MdiParent = this;
                warehouseForm.Dock = DockStyle.Fill;
                warehouseForm.Show();
            }
            else
            {
                warehouseForm.Activate();
                warehouseForm.Show();
            }
        }

        private void WarehouseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            warehouseForm = null;
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            CheckButton(transferBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (transferForm == null)
            {
                transferForm = new Transfer();
                transferForm.FormClosed += TransferForm_FormClosed;
                transferForm.MdiParent = this;
                transferForm.Dock = DockStyle.Fill;
                transferForm.Show();
            }
            else
            {
                transferForm.Activate();
                transferForm.Show();
            }
        }

        private void TransferForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            transferForm = null;
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            CheckButton(reportsBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (reportsForm == null)
            {
                reportsForm = new Reports();
                reportsForm.FormClosed += ReportsForm_FormClosed;
                reportsForm.MdiParent = this;
                reportsForm.Dock = DockStyle.Fill;
                reportsForm.Show();
            }
            else
            {
                reportsForm.Activate();
                reportsForm.Show();
            }
        }

        private void ReportsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportsForm = null;
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            CheckButton(settingBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (settingForm == null)
            {
                settingForm = new Setting();
                settingForm.FormClosed += SettingForm_FormClosed;
                settingForm.MdiParent = this;
                settingForm.Dock = DockStyle.Fill;
                settingForm.Show();
            }
            else
            {
                settingForm.Activate();
                settingForm.Show();
            }
        }

        private void SettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingForm = null;
        }

        private void sidebarBtnPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void proBtn_Click(object sender, EventArgs e)
        {
            if (productionForm == null)
            {
                productionForm = new Production();
                productionForm.FormClosed += Production_FormClosed;
                productionForm.MdiParent = this;
                productionForm.Dock = DockStyle.Fill;
                productionForm.Show();
            }
            else
            {
                productionForm.Activate();
                productionForm.Show();
            }
        }

        private void Production_FormClosed(object sender, FormClosedEventArgs e)
        {
            productionForm = null;
        }

        private void proCatBtn_Click(object sender, EventArgs e)
        {
            if (categoryForm == null)
            {
                categoryForm = new Category();
                categoryForm.FormClosed += Category_FormClosed;
                categoryForm.MdiParent = this;
                categoryForm.Dock = DockStyle.Fill;
                categoryForm.Show();
            }
            else
            {
                categoryForm.Activate();
                categoryForm.Show();
            }
        }

        private void Category_FormClosed(object sender, FormClosedEventArgs e)
        {
            categoryForm = null;
        }

        private void varBtn_Click(object sender, EventArgs e)
        {
            if (variationsForm == null)
            {
                variationsForm = new Variations();
                variationsForm.FormClosed += Variations_FormClosed;
                variationsForm.MdiParent = this;
                variationsForm.Dock = DockStyle.Fill;
                variationsForm.Show();
            }
            else
            {
                variationsForm.Activate();
                variationsForm.Show();
            }
        }

        private void Variations_FormClosed(object sender, FormClosedEventArgs e)
        {
            variationsForm = null;
        }

        private void brandBtn_Click(object sender, EventArgs e)
        {
            if (brandForm == null)
            {
                brandForm = new Brands();
                brandForm.FormClosed += Brand_FormClosed;
                brandForm.MdiParent = this;
                brandForm.Dock = DockStyle.Fill;
                brandForm.Show();
            }
            else
            {
                brandForm.Activate();
                brandForm.Show();
            }
        }

        private void Brand_FormClosed(object sender, FormClosedEventArgs e)
        {
            brandForm = null;
        }

        private void unitsBtn_Click(object sender, EventArgs e)
        {
            if (unitForm == null)
            {
                unitForm = new Units();
                unitForm.FormClosed += Unit_FormClosed;
                unitForm.MdiParent = this;
                unitForm.Dock = DockStyle.Fill;
                unitForm.Show();
            }
            else
            {
                unitForm.Activate();
                unitForm.Show();
            }
        }

        private void Unit_FormClosed(object sender, FormClosedEventArgs e)
        {
            unitForm = null;
        }

        private void baseUnitBtn_Click(object sender, EventArgs e)
        {
            if (baseUnitForm == null)
            {
                baseUnitForm = new BaseUnit();
                baseUnitForm.FormClosed += BaseUnit_FormClosed;
                baseUnitForm.MdiParent = this;
                baseUnitForm.Dock = DockStyle.Fill;
                baseUnitForm.Show();
            }
            else
            {
                baseUnitForm.Activate();
                baseUnitForm.Show();
            }
        }

        private void BaseUnit_FormClosed(object sender, FormClosedEventArgs e)
        {
            baseUnitForm = null;
        }

        private void salesListBtn_Click(object sender, EventArgs e)
        {
            if (salesForm == null)
            {
                salesForm = new SalesForm();
                salesForm.FormClosed += SalesForm_FormClosed;
                salesForm.MdiParent = this;
                salesForm.Dock = DockStyle.Fill;
                salesForm.Show();
            }
            else
            {
                salesForm.Activate();
                salesForm.Show();
            }
        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesForm = null;
        }

        private void salesRetBtn_Click(object sender, EventArgs e)
        {
            if (salesReturnForm == null)
            {
                salesReturnForm = new SaleReturnForm();
                salesReturnForm.FormClosed += SalesReturnForm_FormClosed;
                salesReturnForm.MdiParent = this;
                salesReturnForm.Dock = DockStyle.Fill;
                salesReturnForm.Show();
            }
            else
            {
                salesReturnForm.Activate();
                salesReturnForm.Show();
            }
        }

        private void SalesReturnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesReturnForm = null;
        }

        private void barcodePrtBtn_Click(object sender, EventArgs e)
        {
            if (barcodeForm == null)
            {
                barcodeForm = new Barcode();
                barcodeForm.FormClosed += Barcode_FormClosed;
                barcodeForm.MdiParent = this;
                barcodeForm.Dock = DockStyle.Fill;
                barcodeForm.Show();
            }
            else
            {
                barcodeForm.Activate();
                barcodeForm.Show();
            }
        }

        private void Barcode_FormClosed(object sender, FormClosedEventArgs e)
        {
            barcodeForm = null;
        }

        private void cusBtn_Click(object sender, EventArgs e)
        {
            if (customerForm == null)
            {
                customerForm = new CustomerForm();
                customerForm.FormClosed += CustomerForm_FormClosed;
                customerForm.MdiParent = this;
                customerForm.Dock = DockStyle.Fill;
                customerForm.Show();
            }
            else
            {
                customerForm.Activate();
                customerForm.Show();
            }
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            customerForm = null;
        }

        private void supBtn_Click(object sender, EventArgs e)
        {
            if (supplierForm == null)
            {
                supplierForm = new SupplierForm();
                supplierForm.FormClosed += SupplierForm_FormClosed;
                supplierForm.MdiParent = this;
                supplierForm.Dock = DockStyle.Fill;
                supplierForm.Show();
            }
            else
            {
                supplierForm.Activate();
                supplierForm.Show();
            }
        }

        private void SupplierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            supplierForm = null;
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            if (userForm == null)
            {
                userForm = new UserForm();
                userForm.FormClosed += UserForm_FormClosed;
                userForm.MdiParent = this;
                userForm.Dock = DockStyle.Fill;
                userForm.Show();
            }
            else
            {
                userForm.Activate();
                userForm.Show();
            }
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userForm = null;
        }

        private void creExpBtn_Click(object sender, EventArgs e)
        {
            if (expensesForm == null)
            {
                expensesForm = new ExpensesForm();
                expensesForm.FormClosed += ExpensesForm_FormClosed;
                expensesForm.MdiParent = this;
                expensesForm.Dock = DockStyle.Fill;
                expensesForm.Show();
            }
            else
            {
                expensesForm.Activate();
                expensesForm.Show();
            }
        }

        private void ExpensesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            expensesForm = null;
        }

        private void expCatBtn_Click(object sender, EventArgs e)
        {
            if (expensesCategoryForm == null)
            {
                expensesCategoryForm = new ExpensesCategory();
                expensesCategoryForm.FormClosed += ExpensesCategoryForm_FormClosed;
                expensesCategoryForm.MdiParent = this;
                expensesCategoryForm.Dock = DockStyle.Fill;
                expensesCategoryForm.Show();
            }
            else
            {
                expensesCategoryForm.Activate();
                expensesCategoryForm.Show();
            }
        }
        private void ExpensesCategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            expensesCategoryForm = null;
        }
    }
}