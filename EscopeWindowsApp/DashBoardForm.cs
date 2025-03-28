﻿using System;
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
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void numberOrderLabel_Click(object sender, EventArgs e)
        {

        }

        private void grossRevenueChart_Click(object sender, EventArgs e)
        {

        }

        private void topProductsPieChart_Click(object sender, EventArgs e)
        {

        }

        private void numberTrevenueLabel_Click(object sender, EventArgs e)
        {

        }

        private void last7DaysBtn_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tNOCLabel_Click(object sender, EventArgs e)
        {

        }

        private void tNOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void dashNOCBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AddCustomerForm)
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
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }

        private void dashNOSBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AddSupplierForm)
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
            AddSupplierForm addSupplierForm = new AddSupplierForm();
            addSupplierForm.Show();
        }

        private void dashNOPBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateProduct)
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
            CreateProduct createProduct = new CreateProduct();
            createProduct.Show();
        }
    }
}