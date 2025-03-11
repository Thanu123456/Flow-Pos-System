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
        private DataTable usersTable; // Data source for users
        private int currentIndex = 0; // Current index for navigation

        public UserForm()
        {
            InitializeComponent();
            LoadUsersData();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // Initialize users data on form load
            userDataGridView.DataSource = usersTable;
        }

        private void LoadUsersData()
        {
            // Load users data into usersTable
            usersTable = new DataTable();
            usersTable.Columns.Add("UserId", typeof(int));
            usersTable.Columns.Add("UserName", typeof(string));
            usersTable.Columns.Add("Email", typeof(string));

            // Sample data - replace with actual data retrieval logic
            usersTable.Rows.Add(1, "John Doe", "john.doe@example.com");
            usersTable.Rows.Add(2, "Jane Smith", "jane.smith@example.com");
            usersTable.Rows.Add(3, "Bob Johnson", "bob.johnson@example.com");
            usersTable.Rows.Add(4, "Alice Williams", "alice.williams@example.com");
        }

        private void createUserBtn_Click(object sender, EventArgs e)
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

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks, for example to edit or delete users
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = userDataGridView.Rows[e.RowIndex];
                int userId = Convert.ToInt32(row.Cells["UserId"].Value);
                string userName = row.Cells["UserName"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();

                // Implement logic to handle the cell content click event
            }
        }

        private void userSearchText_TextChanged(object sender, EventArgs e)
        {
            // Search users as text changes
            string searchText = userSearchText.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredRows = usersTable.AsEnumerable()
                    .Where(row => row.Field<string>("UserName").ToLower().Contains(searchText)
                               || row.Field<string>("Email").ToLower().Contains(searchText));

                if (filteredRows.Any())
                {
                    userDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    userDataGridView.DataSource = null;
                }
            }
            else
            {
                userDataGridView.DataSource = usersTable;
            }
        }

        private void userFilterBtn_Click(object sender, EventArgs e)
        {
            // Filter users where UserId is greater than 2
            var filteredRows = usersTable.AsEnumerable()
                .Where(row => row.Field<int>("UserId") > 2);

            if (filteredRows.Any())
            {
                userDataGridView.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                userDataGridView.DataSource = null;
            }
        }

        private void userFirstBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the first user
            if (userDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                userDataGridView.CurrentCell = userDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void userPrevBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the previous user
            if (currentIndex > 0)
            {
                currentIndex--;
                userDataGridView.CurrentCell = userDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void userNextBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the next user
            if (currentIndex < userDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                userDataGridView.CurrentCell = userDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void userLastBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the last user
            if (userDataGridView.Rows.Count > 0)
            {
                currentIndex = userDataGridView.Rows.Count - 1;
                userDataGridView.CurrentCell = userDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}
