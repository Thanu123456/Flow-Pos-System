using System;
using System.Linq;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class HoldReference : Form
    {
        public HoldReference()
        {
            InitializeComponent();
        }

        public string ReferenceNumber => refNumberText.Text;

        private void HoldReference_Load(object sender, EventArgs e)
        {
        }

        private void refNumberText_TextChanged(object sender, EventArgs e)
        {
            // Restrict to numbers only, max 10 digits
            string text = refNumberText.Text;
            if (!string.IsNullOrEmpty(text))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(text, @"^\d{0,10}$"))
                {
                    refNumberText.Text = new string(text.Where(char.IsDigit).Take(10).ToArray());
                    refNumberText.SelectionStart = refNumberText.Text.Length;
                }
            }
        }

        private void holdOkayBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(refNumberText.Text))
            {
                MessageBox.Show("Please enter a reference number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void holdCancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}