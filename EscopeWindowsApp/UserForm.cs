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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AddUserForm)
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
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void addUserLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
