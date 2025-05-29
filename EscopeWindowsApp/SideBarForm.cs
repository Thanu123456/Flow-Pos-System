using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing;
using Org.BouncyCastle.Utilities;
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
        Quotations quatationsForm;
        WarehouseForm warehouseForm;
        Reports reportsForm;
        Setting settingForm;
        PurchasesForm purchasesForm;
        PurchasesReturn purchasesReturnForm;
        private Control currentCheckedButton = null;
        private Color checkedColor = Color.LightSteelBlue;
        private Color uncheckedColor = Color.White;
        private Timer timeTimer;
        private Timer dateTimer;
        private string userName;
        private string userEmail;

        public SideBarForm(string username = "", string email = "")
        {
            InitializeComponent();
            this.userName = username;
            this.userEmail = email;

            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            sideBarPanel.AutoScroll = false;
            sideBarPanel.HorizontalScroll.Visible = false;
            sideBarPanel.HorizontalScroll.Enabled = false;
            sideBarPanel.VerticalScroll.Visible = true;
            sideBarPanel.VerticalScroll.Enabled = true;

            SetButtonStyles();

            timeTimer = new Timer();
            timeTimer.Interval = 1000;
            timeTimer.Tick += TimeTimer_Tick;
            timeTimer.Start();

            dateTimer = new Timer();
            dateTimer.Interval = 1000;
            dateTimer.Tick += DateTimer_Tick;
            dateTimer.Start();

            timeLabel.AutoSize = false;
            dateLabel.AutoSize = false;
        }

        private void SetButtonStyles()
        {
            Control[] sidebarButtons = new Control[]
            {
        manuBtn, expensesBtn, salesBtn, peoplesBtn, dashboardBtn,
        quatationBtn, wareHouseBtn, reportsBtn,
        settingBtn, proBtn, proCatBtn, varBtn,
        brandBtn, unitsBtn, baseUnitBtn, salesListBtn, salesRetBtn,
        barcodePrtBtn, creExpBtn, expCatBtn, cusBtn, supBtn, userBtn,
        purBtn, purPanelBtn, purRetBtn
            };

            // In constructor after SetButtonStyles()
            sidebarBtn.Checked = false;
            sidebarBtn.FillColor = Color.White;
            sidebarBtn.UseTransparentBackground = true;

            posBtn.Checked = false;
            posBtn.FillColor = Color.RoyalBlue;
            posBtn.UseTransparentBackground = false;
            posBtn.PressedColor = Color.RoyalBlue;
            posBtn.HoverState.FillColor = Color.Navy; // Maintain color on hover
            posBtn.PressedColor = Color.RoyalBlue;
            posBtn.CheckedState.FillColor = Color.RoyalBlue;

            userProfileBtn.HoverState.FillColor = Color.LightGray;
            userProfileBtn.PressedColor = Color.White;
            userProfileBtn.UseTransparentBackground = true;
            userProfileBtn.BackColor = Color.Transparent;
            userProfileBtn.Checked = false;
            userProfileBtn.BorderColor = Color.Black;
            userProfileBtn.CheckedState.BorderColor = Color.Black;
            userProfileBtn.BorderThickness = 1;
            userProfileBtn.FillColor = Color.White;
            userProfileBtn.CheckedState.FillColor = Color.White;


            foreach (Control ctrl in sidebarButtons)
            {
                if (ctrl is SiticoneButton btn)
                {
                    btn.Checked = false;
                    btn.FillColor = uncheckedColor;
                    btn.CheckedState.FillColor = checkedColor;
                }
            }
        }

        private void SideBarForm_Load(object sender, EventArgs e)
        {
            dashboardBtn_Click(dashboardBtn, EventArgs.Empty);
        }

        bool manuExpand = false;
        bool purchesesExpand = false;
        bool salesExpand = false;
        bool peopleExpand = false;
        bool sideBarExpand = true;
        bool purchasesPanelExpand = false;

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
            if (purchasesPanelExpand)
            {
                purchTransition.Start();
            }
        }

        private Control GetParentPanel(Control control)
        {
            Control parent = control.Parent;
            while (parent != null)
            {
                if (parent == manuLayoutPanel || parent == expLayoutPanel ||
                    parent == salesLayoutPanel || parent == peoplesLayoutPanel ||
                    parent == purchflowlayoutpanel)
                {
                    return parent;
                }
                parent = parent.Parent;
            }
            return null;
        }

        private void CollapseAllPanels(Control excludePanel = null)
        {
            if (manuExpand && GetParentPanel(currentCheckedButton) != manuLayoutPanel)
                manuTransition.Start();
            if (purchesesExpand && GetParentPanel(currentCheckedButton) != expLayoutPanel)
                purchesTransition.Start();
            if (salesExpand && GetParentPanel(currentCheckedButton) != salesLayoutPanel)
                salesTransition.Start();
            if (peopleExpand && GetParentPanel(currentCheckedButton) != peoplesLayoutPanel)
                peoplesTransition.Start();
            if (purchasesPanelExpand && GetParentPanel(currentCheckedButton) != purchflowlayoutpanel)
                purchTransition.Start();
        }

        private void CheckButton(Control control)
        {
            if (currentCheckedButton != control)
            {
                // Reset previous button
                if (currentCheckedButton != null)
                {
                    if (currentCheckedButton is SiticoneButton prevBtn)
                    {
                        prevBtn.Checked = false;
                        prevBtn.FillColor = uncheckedColor;
                    }
                }

                // Set new button
                if (control is SiticoneButton newBtn)
                {
                    newBtn.Checked = true;
                    newBtn.FillColor = checkedColor;
                    currentCheckedButton = control;

                    // Ensure parent panel is expanded
                    var parentPanel = GetParentPanel(control);
                    if (parentPanel != null)
                    {
                        if (parentPanel == manuLayoutPanel && !manuExpand) manuTransition.Start();
                        if (parentPanel == expLayoutPanel && !purchesesExpand) purchesTransition.Start();
                        if (parentPanel == salesLayoutPanel && !salesExpand) salesTransition.Start();
                        if (parentPanel == peoplesLayoutPanel && !peopleExpand) peoplesTransition.Start();
                        if (parentPanel == purchflowlayoutpanel && !purchasesPanelExpand) purchTransition.Start();
                    }
                }
            }
        }

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt") + "\n" + DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy");
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {
        }

        private void manuTransition_Tick(object sender, EventArgs e)
        {
            if (manuExpand)
            {
                manuLayoutPanel.Height -= 10;
                if (manuLayoutPanel.Height <= 41)
                {
                    manuTransition.Stop();
                    manuExpand = false;
                    UpdateScrollSettings();
                }
            }
            else
            {
                manuLayoutPanel.Height += 10;
                if (manuLayoutPanel.Height >= 327)
                {
                    manuTransition.Stop();
                    manuExpand = true;
                    UpdateScrollSettings();
                }
            }
        }

        private void UpdateScrollSettings()
        {
            if (manuExpand)
            {
                // When manuExpand is true, enable vertical scrolling
                sideBarPanel.AutoScroll = true;
                sideBarPanel.VerticalScroll.Enabled = true;
                sideBarPanel.VerticalScroll.Visible = true;
                sideBarPanel.AutoScrollMinSize = new Size(0, 816);
            }
            else
            {
                // When manuExpand is false, disable scrolling
                sideBarPanel.AutoScroll = false;
                sideBarPanel.VerticalScroll.Enabled = false;
                sideBarPanel.VerticalScroll.Visible = false;
                sideBarPanel.AutoScrollMinSize = new Size(0, 0);
            }

            // Always keep horizontal scroll disabled
            sideBarPanel.HorizontalScroll.Enabled = false;
            sideBarPanel.HorizontalScroll.Visible = false;

            // Force layout update
            sideBarPanel.PerformLayout();
        }

        private void manuBtn_Click(object sender, EventArgs e)
        {
            CheckButton(manuBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (!manuExpand) manuTransition.Start();
        }

        private void purchesTransition_Tick(object sender, EventArgs e)
        {
            if (purchesesExpand)
            {
                expLayoutPanel.Height -= 10;
                if (expLayoutPanel.Height <= 41)
                {
                    purchesTransition.Stop();
                    purchesesExpand = false;
                }
            }
            else
            {
                expLayoutPanel.Height += 10;
                if (expLayoutPanel.Height >= 123)
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

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBarPanel.Width += 20;
                if (sideBarPanel.Width >= 250)
                {
                    sideBarPanel.Width = 250;
                    sidebarTransition.Stop();
                    sideBarExpand = false;
                    dashBtnPanel.Width = 250;
                    settingBtnPanel.Width = 250;
                    varBtnPanel.Width = 250;
                    reportsBtnPanel.Width = 250;
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
                    baseUnitBtnPanel.Width = 250;
                    unitsBtnPanel.Width = 250;
                    brandBtnPanel.Width = 250;
                    proCatBtnPanel.Width = 250;
                    proBtnPanel.Width = 250;
                    manuBtnPanel.Width = 250;
                    sidebarBtnPanel.Width = 250;
                    purBtnPanel.Width = 250;
                }
            }
            else
            {
                sideBarPanel.Width -= 20;
                if (sideBarPanel.Width <= 56)
                {
                    sideBarPanel.Width = 56;
                    sidebarTransition.Stop();
                    sideBarExpand = true;
                    dashBtnPanel.Width = 56;
                    settingBtnPanel.Width = 56;
                    varBtnPanel.Width = 56;
                    reportsBtnPanel.Width = 56;
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
                    baseUnitBtnPanel.Width = 56;
                    unitsBtnPanel.Width = 56;
                    brandBtnPanel.Width = 56;
                    proCatBtnPanel.Width = 56;
                    proBtnPanel.Width = 56;
                    manuBtnPanel.Width = 56;
                    sidebarBtnPanel.Width = 56;
                    purBtnPanel.Width = 56;
                    CollapseAllPanels();
                }
            }
        }

        private void sidebarBtn_Click(object sender, EventArgs e)
        {
            CheckButton(sidebarBtn);
            sidebarTransition.Start();
        }

        private void OpenFormAndClosePrevious<T>(ref T form, Action<T> setFormClosed) where T : Form, new()
        {
            Console.WriteLine($"MDI children before closing: {string.Join(", ", this.MdiChildren.Select(f => f.Name))}");

            // Close only forms that are NOT of type T
            foreach (Form child in this.MdiChildren.ToList())
            {
                if (child != null && !child.IsDisposed && !(child is T))
                {
                    Console.WriteLine($"Attempting to close MDI child: {child.Name}, Visible: {child.Visible}, IsHandleCreated: {child.IsHandleCreated}");
                    try
                    {
                        if (child is IProgrammaticCloseable pc)
                        {
                            pc.AllowProgrammaticClose = true;
                        }
                        child.Close();
                        Console.WriteLine($"Successfully closed MDI child: {child.Name}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error closing MDI child {child.Name}: {ex.Message}");
                    }
                }
            }

            Console.WriteLine($"MDI children after closing: {string.Join(", ", this.MdiChildren.Select(f => f.Name))}");

            // Check if there's already an instance of T open
            T existingForm = this.MdiChildren.OfType<T>().FirstOrDefault();

            if (existingForm != null && !existingForm.IsDisposed)
            {
                // If form of type T already exists, just activate it
                Console.WriteLine($"Activating existing form: {typeof(T).Name}, Visible: {existingForm.Visible}, IsDisposed: {existingForm.IsDisposed}");
                existingForm.Activate();
                if (!existingForm.Visible)
                {
                    existingForm.Show();
                }
                form = existingForm; // Update the reference
            }
            else
            {
                // Create new form only if none exists
                if (form == null || form.IsDisposed)
                {
                    form = new T();
                    setFormClosed(form);
                    form.MdiParent = this;
                    form.Dock = DockStyle.Fill;
                    Console.WriteLine($"Opening new form: {typeof(T).Name}");
                    try
                    {
                        form.Show();
                        Console.WriteLine($"Successfully shown form: {typeof(T).Name}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error showing form {typeof(T).Name}: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"Activating existing form: {typeof(T).Name}, Visible: {form.Visible}, IsDisposed: {form.IsDisposed}");
                    form.Activate();
                    if (!form.Visible)
                    {
                        form.Show();
                    }
                }
            }

            Console.WriteLine($"MDI children after opening: {string.Join(", ", this.MdiChildren.Select(f => f.Name))}");
        }

        private interface IProgrammaticCloseable
        {
            bool AllowProgrammaticClose { get; set; }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            CheckButton(dashboardBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            OpenFormAndClosePrevious(ref dashBoardForm, (form) => form.FormClosed += DashBoardForm_FormClosed);
        }

        private void DashBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashBoardForm = null;
            Console.WriteLine("DashBoardForm closed");
        }

        private void sideBarPanel_Paint(object sender, PaintEventArgs e)
        {
            // Empty method to satisfy designer event binding
        }

        private void quatationBtn_Click(object sender, EventArgs e)
        {
            CheckButton(quatationBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            OpenFormAndClosePrevious(ref quatationsForm, (form) => form.FormClosed += QuatationsForm_FormClosed);
        }

        private void QuatationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            quatationsForm = null;
            Console.WriteLine("QuotationsForm closed");
        }

        private void wareHouseBtn_Click(object sender, EventArgs e)
        {
            CheckButton(wareHouseBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            OpenFormAndClosePrevious(ref warehouseForm, (form) => form.FormClosed += WarehouseForm_FormClosed);
        }

        private void WarehouseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            warehouseForm = null;
            Console.WriteLine("WarehouseForm closed");
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            CheckButton(reportsBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            OpenFormAndClosePrevious(ref reportsForm, (form) => form.FormClosed += ReportsForm_FormClosed);
        }

        private void ReportsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportsForm = null;
            Console.WriteLine("ReportsForm closed");
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            CheckButton(settingBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            OpenFormAndClosePrevious(ref settingForm, (form) => form.FormClosed += SettingForm_FormClosed);
            if (settingForm != null && !settingForm.IsDisposed)
            {
                settingForm.Activate(); // Bring the existing form to the front
                if (!settingForm.Visible)
                {
                    settingForm.Show();
                }
            }
            else
            {
                // Open a new SettingForm only if it doesn't exist
                OpenFormAndClosePrevious(ref settingForm, (form) => form.FormClosed += SettingForm_FormClosed);
            }
        }

        private void SettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingForm = null;
            Console.WriteLine("SettingForm closed");
        }

        private void proBtn_Click(object sender, EventArgs e)
        {
            CheckButton(proBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref productionForm, (form) => form.FormClosed += Production_FormClosed);
        }

        private void Production_FormClosed(object sender, FormClosedEventArgs e)
        {
            productionForm = null;
            Console.WriteLine("ProductionForm closed");
        }

        private void proCatBtn_Click(object sender, EventArgs e)
        {
            CheckButton(proCatBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref categoryForm, (form) => form.FormClosed += Category_FormClosed);
        }

        private void Category_FormClosed(object sender, FormClosedEventArgs e)
        {
            categoryForm = null;
            Console.WriteLine("CategoryForm closed");
        }

        private void varBtn_Click(object sender, EventArgs e)
        {
            CheckButton(varBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref variationsForm, (form) => form.FormClosed += Variations_FormClosed);
        }

        private void Variations_FormClosed(object sender, FormClosedEventArgs e)
        {
            variationsForm = null;
            Console.WriteLine("VariationsForm closed");
        }

        private void brandBtn_Click(object sender, EventArgs e)
        {
            CheckButton(brandBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref brandForm, (form) => form.FormClosed += Brand_FormClosed);
        }

        private void Brand_FormClosed(object sender, FormClosedEventArgs e)
        {
            brandForm = null;
            Console.WriteLine("BrandForm closed");
        }

        private void unitsBtn_Click(object sender, EventArgs e)
        {
            CheckButton(unitsBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref unitForm, (form) => form.FormClosed += Unit_FormClosed);
        }

        private void Unit_FormClosed(object sender, FormClosedEventArgs e)
        {
            unitForm = null;
            Console.WriteLine("UnitForm closed");
        }

        private void baseUnitBtn_Click(object sender, EventArgs e)
        {
            CheckButton(baseUnitBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref baseUnitForm, (form) => form.FormClosed += BaseUnit_FormClosed);
        }

        private void BaseUnit_FormClosed(object sender, FormClosedEventArgs e)
        {
            baseUnitForm = null;
            Console.WriteLine("BaseUnitForm closed");
        }

        private void salesListBtn_Click(object sender, EventArgs e)
        {
            CheckButton(salesListBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref salesForm, (form) => form.FormClosed += SalesForm_FormClosed);
        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesForm = null;
            Console.WriteLine("SalesForm closed");
        }

        private void salesRetBtn_Click(object sender, EventArgs e)
        {
            CheckButton(salesRetBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref salesReturnForm, (form) => form.FormClosed += SalesReturnForm_FormClosed);
        }

        private void SalesReturnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesReturnForm = null;
            Console.WriteLine("SalesReturnForm closed");
        }

        private void barcodePrtBtn_Click(object sender, EventArgs e)
        {
            CheckButton(barcodePrtBtn);
            ExpandSidebarIfCollapsed();
            
            OpenFormAndClosePrevious(ref barcodeForm, (form) => form.FormClosed += Barcode_FormClosed);
        }

        private void Barcode_FormClosed(object sender, FormClosedEventArgs e)
        {
            barcodeForm = null;
            Console.WriteLine("BarcodeForm closed");
        }

        private void cusBtn_Click(object sender, EventArgs e)
        {
            CheckButton(cusBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref customerForm, (form) => form.FormClosed += CustomerForm_FormClosed);
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            customerForm = null;
            Console.WriteLine("CustomerForm closed");
        }

        private void supBtn_Click(object sender, EventArgs e)
        {
            CheckButton(supBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref supplierForm, (form) => form.FormClosed += SupplierForm_FormClosed);
        }

        private void SupplierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            supplierForm = null;
            Console.WriteLine("SupplierForm closed");
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            CheckButton(userBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref userForm, (form) => form.FormClosed += UserForm_FormClosed);
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userForm = null;
            Console.WriteLine("UserForm closed");
        }

        private void creExpBtn_Click(object sender, EventArgs e)
        {
            CheckButton(creExpBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref expensesForm, (form) => form.FormClosed += ExpensesForm_FormClosed);
        }

        private void ExpensesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            expensesForm = null;
            Console.WriteLine("ExpensesForm closed");
        }

        private void expCatBtn_Click(object sender, EventArgs e)
        {
            CheckButton(expCatBtn);
            ExpandSidebarIfCollapsed();
            OpenFormAndClosePrevious(ref expensesCategoryForm, (form) => form.FormClosed += ExpensesCategoryForm_FormClosed);
        }

        private void ExpensesCategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            expensesCategoryForm = null;
            Console.WriteLine("ExpensesCategoryForm closed");
        }

        private void posBtn_Click(object sender, EventArgs e)
        {
            // Remove CheckButton call
            ExpandSidebarIfCollapsed();

            // Keep existing POS logic
            if (!this.MdiChildren.Any())
            {
                OpenFormAndClosePrevious(ref dashBoardForm, (form) => form.FormClosed += DashBoardForm_FormClosed);
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is POSRegister)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }

            POSRegister newPosRegister = new POSRegister(userName, userEmail);
            newPosRegister.FormClosed += (s, args) => Console.WriteLine("POSRegister closed");
            newPosRegister.StartPosition = FormStartPosition.CenterScreen;
            newPosRegister.Show();
        }

        private void purchTransition_Tick(object sender, EventArgs e)
        {
            if (purchasesPanelExpand)
            {
                purchflowlayoutpanel.Height -= 10;
                if (purchflowlayoutpanel.Height <= 41)
                {
                    purchTransition.Stop();
                    purchasesPanelExpand = false;
                }
            }
            else
            {
                purchflowlayoutpanel.Height += 10;
                if (purchflowlayoutpanel.Height >= 123)
                {
                    purchTransition.Stop();
                    purchasesPanelExpand = true;
                }
            }
        }

        private void purBtn_Click(object sender, EventArgs e)
        {
            CheckButton(purBtn);
            ExpandSidebarIfCollapsed();
            if (!purchasesPanelExpand)
            {
                purchTransition.Start();
            }
            OpenFormAndClosePrevious(ref purchasesForm, (form) => form.FormClosed += PurchasesForm_FormClosed);
        }

        private void PurchasesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            purchasesForm = null;
            Console.WriteLine("PurchasesForm closed");
        }

        private void purPanelBtn_Click(object sender, EventArgs e)
        {
            CheckButton(purPanelBtn);
            ExpandSidebarIfCollapsed();
            CollapseAllPanels();
            if (!purchasesPanelExpand)
            {
                purchTransition.Start();
            }
        }

        private void purRetBtn_Click(object sender, EventArgs e)
        {
            CheckButton(purRetBtn);
            ExpandSidebarIfCollapsed();
            if (!purchasesPanelExpand)
            {
                purchTransition.Start();
            }
            OpenFormAndClosePrevious(ref purchasesReturnForm, (form) => form.FormClosed += PurchasesReturnForm_FormClosed);
        }

        private void PurchasesReturnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            purchasesReturnForm = null;
            Console.WriteLine("PurchasesReturnForm closed");
        }

        private void userProfileBtn_Click(object sender, EventArgs e)
        {
            // Remove CheckButton call
            ExpandSidebarIfCollapsed();

            // Keep existing logout logic
            if (!this.MdiChildren.Any())
            {
                OpenFormAndClosePrevious(ref dashBoardForm, (form) => form.FormClosed += DashBoardForm_FormClosed);
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is LogOutForm)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }

            LogOutForm newLogOutForm = new LogOutForm(this.userName, this.userEmail);
            newLogOutForm.FormClosed += (s, args) => Console.WriteLine("LogOutForm closed");
            newLogOutForm.StartPosition = FormStartPosition.CenterScreen;
            newLogOutForm.Show();
        }

        private void grnBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is GRNForm)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            GRNForm gRNForm = new GRNForm();
            gRNForm.Show();
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is GRNForm)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            GRNForm gRNForm = new GRNForm();
            gRNForm.Show();
        }

        private void siticonePanel4_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}