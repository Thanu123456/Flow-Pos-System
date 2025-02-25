using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class sideBarForm : Form
    {
        DashBoardForm dashboard;
        UserForm user;
        SupplierForm supplier;
        CustomerForm customer;
        InventoryForm inventory;
        Adjustments adjustments;


        public sideBarForm()
        {
            InitializeComponent();
        }

        bool manuExpand = false;

        private void masterTransition_Tick(object sender, EventArgs e)
        {
            if (manuExpand == false)
            {
                masterContainer.Height += 10;
                if (masterContainer.Height >= 286)
                {
                    masterTransition.Stop();
                    manuExpand = true;
                    this.Refresh();
                }
            }
            else
            {
                masterContainer.Height -= 10;
                if (masterContainer.Height <= 50)
                {
                    masterTransition.Stop();
                    manuExpand = false;
                    this.Refresh();
                }

            }
        }

        private void masterBtn_Click(object sender, EventArgs e)
        {
            masterTransition.Start();
        }


        private void logoBtn_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 50)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = false;
                    this.Refresh();

                    logoBtn.Width = sidebar.Width;
                    dashboardBtn.Width = sidebar.Width;
                    masterBtn.Width = sidebar.Width;
                    userBtn.Width = sidebar.Width;
                    supplierBtn.Width = sidebar.Width;
                    inventoryBtn.Width = sidebar.Width;
                    customerBtn.Width = sidebar.Width;
                    adjustmentBtn.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 211)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;
                    this.Refresh();

                    logoBtn.Width = sidebar.Width;
                    dashboardBtn.Width = sidebar.Width;
                    masterBtn.Width = sidebar.Width;
                    userBtn.Width = sidebar.Width;
                    supplierBtn.Width = sidebar.Width;
                    inventoryBtn.Width = sidebar.Width;
                    customerBtn.Width = sidebar.Width;
                    adjustmentBtn.Width = sidebar.Width;
                }
            }
        }

        private void sideBarForm_Load(object sender, EventArgs e)
        {

        }

        private void masterLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new DashBoardForm();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                user = new UserForm();
                user.FormClosed += User_FormClosed;
                user.MdiParent = this;
                user.Dock = DockStyle.Fill;
                user.Show();
            }
            else
            {
                user.Activate();
            }
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            user = null;
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            if (supplier == null)
            {
                supplier = new SupplierForm();
                supplier.FormClosed += Supplier_FormClosed;
                supplier.MdiParent = this;
                supplier.Dock = DockStyle.Fill;
                supplier.Show();
            }
            else
            {
                supplier.Activate();
            }
        }

        private void Supplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            supplier = null;
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            if (customer == null)
            {
                customer = new CustomerForm();
                customer.FormClosed += Customer_FormClosed;
                customer.MdiParent = this;
                customer.Dock = DockStyle.Fill;
                customer.Show();
            }
            else
            {
                customer.Activate();
            }
        }

        private void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            customer = null;
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            if (inventory == null)
            {
                inventory = new InventoryForm();
                inventory.FormClosed += Inventory_FormClosed;
                inventory.MdiParent = this;
                inventory.Dock = DockStyle.Fill;
                inventory.Show();
            }
            else
            {
                inventory.Activate();
            }
        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            inventory = null;
        }

        private void adjustmentBtn_Click(object sender, EventArgs e)
        {
            if (adjustments == null)
            {
                adjustments = new Adjustments();
                adjustments.FormClosed += Adjustments_FormClosed;
                adjustments.MdiParent = this;
                adjustments.Dock = DockStyle.Fill;
                adjustments.Show();
            }
            else
            {
                adjustments.Activate();
            }
        }

        private void Adjustments_FormClosed(object sender, FormClosedEventArgs e)
        {
            adjustments = null;
        }
    }
}

