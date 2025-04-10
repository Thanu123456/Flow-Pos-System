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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void loadingProgressBar_ValueChanged(object sender, EventArgs e)
        {
            // Optional: Add logic if needed
        }

        private void loadingPictureBox2_Click(object sender, EventArgs e)
        {
            // Optional: Add logic if needed
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            loadingTimer.Start();
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            if (loadingProgressBar.Value < 100)
            {
                loadingProgressBar.Value += 2;
            }
            else
            {
                loadingTimer.Stop();
                this.Hide();
                LoginForm mainForm = new LoginForm();
                mainForm.FormClosed += (s, args) => Application.Exit(); // Exit the application when LoginForm is closed
                mainForm.Show();
            }
        }
    }
}