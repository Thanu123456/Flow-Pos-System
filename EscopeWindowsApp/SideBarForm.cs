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
    public partial class SideBarForm : Form
    {

        DashBoardForm dashBoardForm;
        public SideBarForm()
        {
            InitializeComponent();
        }

        bool manuExpand = false;
        private void manuTransition_Tick(object sender, EventArgs e)
        {
            if (manuExpand == false)
            {
                manuLayoutPanel.Height += 10;
                if(manuLayoutPanel.Height >= 182)
                {
                    manuTransition.Stop();
                    manuExpand = true;
                    
                }
            }
            else
            {
                manuLayoutPanel.Height -= 10;
                if (manuLayoutPanel.Height <= 45)
                {
                    manuTransition.Stop();
                    manuExpand = false;
                    
                }
            }
        }

        private void manuBtn_Click(object sender, EventArgs e)
        {
            manuTransition.Start();
        }

        private void SideBarForm_Load(object sender, EventArgs e)
        {

        }

        bool sideBarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBarPanel.Width += 5;
                if (sideBarPanel.Width >= 218)
                {
                    sideBarExpand = false;
                    sidebarTransition.Stop();

                    dashboardBtn.Width = sideBarPanel.Width;

                }
            }
            else
            {
                sideBarPanel.Width -= 5;
                if (sideBarPanel.Width <= 37)
                {
                    sideBarExpand = true;
                    sidebarTransition.Stop();

                    dashboardBtn.Width = sideBarPanel.Width;
                }
            }
        }

        private void sidebarBtn_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
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

        private void siticoneButton2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
