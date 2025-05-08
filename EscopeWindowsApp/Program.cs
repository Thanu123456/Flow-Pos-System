using System;
using System.Linq;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check if the command-line argument --start-with-login is present
            bool startWithLogin = args.Contains("--start-with-login");

            if (startWithLogin)
            {
                Application.Run(new LoginForm());
            }
            else
            {
                Application.Run(new SideBarForm());
            }
        }
    }
}