using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class UserForm : Form
    {
        private DataTable usersTable;
        private BindingSource bindingSource;
        private int currentIndex = 0;
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;

        public UserForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            LoadUsersData();
            // Ensure all events are properly wired
            userDataGridView.CellPainting += UserDataGridView_CellPainting;
            userDataGridView.CellFormatting += UserDataGridView_CellFormatting;
            userDataGridView.CellContentClick += userDataGridView_CellContentClick; // Explicitly wire the click event
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            userDataGridView.DataSource = bindingSource;
        }

        private void ConfigureDataGridView()
        {
            userDataGridView.AutoGenerateColumns = false;
            userDataGridView.Columns.Clear();

            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "USER ID"
            });
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "first_name",
                Name = "first_name",
                HeaderText = "FIRST STAT"
            });
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "last_name",
                Name = "last_name",
                HeaderText = "LAST NAME"
            });
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "email",
                Name = "email",
                HeaderText = "EMAIL"
            });
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "phone_number",
                Name = "phone_number",
                HeaderText = "PHONE"
            });
            userDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "role",
                Name = "role",
                HeaderText = "ROLE"
            });

            // Hide password column if it exists (though not added here)
            if (userDataGridView.Columns["password"] != null)
                userDataGridView.Columns["password"].Visible = false;

            userDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "EDIT",
                Width = 50,
                ToolTipText = "Edit this user"
            });

            userDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "DELETE",
                Width = 50,
                ToolTipText = "Delete this user"
            });

            // Prevent the empty row at the end
            userDataGridView.AllowUserToAddRows = false;
        }

        private void UserDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (userDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                if (e.Value != null)
                {
                    int userId = Convert.ToInt32(e.Value);
                    e.Value = $"USER{userId:D3}";
                    e.FormattingApplied = true;
                }
            }
        }

        private void UserDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (userDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    e.PaintBackground(e.CellBounds, true);
                    Image editIcon = Properties.Resources.edit;
                    int iconSize = (int)(Math.Min(e.CellBounds.Width, e.CellBounds.Height) * 0.7);
                    if (iconSize <= 0) iconSize = 16;
                    int x = e.CellBounds.X + (e.CellBounds.Width - iconSize) / 2;
                    int y = e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2;
                    e.Graphics.DrawImage(editIcon, x, y, iconSize, iconSize);
                    e.Handled = true;
                }

                if (userDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    e.PaintBackground(e.CellBounds, true);
                    Image deleteIcon = Properties.Resources.delete;
                    int iconSize = (int)(Math.Min(e.CellBounds.Width, e.CellBounds.Height) * 0.7);
                    if (iconSize <= 0) iconSize = 16;
                    int x = e.CellBounds.X + (e.CellBounds.Width - iconSize) / 2;
                    int y = e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2;
                    e.Graphics.DrawImage(deleteIcon, x, y, iconSize, iconSize);
                    e.Handled = true;
                }
            }
        }

        private void LoadUsersData()
        {
            try
            {
                usersTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, first_name, last_name, email, phone_number, role, password FROM users";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(usersTable);
                    }
                }

                // Replace DBNull with default values
                foreach (DataRow row in usersTable.Rows)
                {
                    for (int i = 0; i < usersTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (usersTable.Columns[i].DataType == typeof(string))
                            {
                                row[i] = "";
                            }
                            else if (usersTable.Columns[i].DataType == typeof(DateTime))
                            {
                                row[i] = DateTime.MinValue;
                            }
                        }
                    }
                }

                bindingSource.DataSource = usersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                usersTable = new DataTable();
                usersTable.Columns.Add("id", typeof(int));
                usersTable.Columns.Add("first_name", typeof(string));
                usersTable.Columns.Add("last_name", typeof(string));
                usersTable.Columns.Add("email", typeof(string));
                usersTable.Columns.Add("phone_number", typeof(string));
                usersTable.Columns.Add("role", typeof(string));
                usersTable.Columns.Add("password", typeof(string));
                bindingSource.DataSource = usersTable;
            }
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
            addUserForm.FormClosed += (s, args) => LoadUsersData();
            addUserForm.Show();
        }

        private void userSearchText_TextChanged(object sender, EventArgs e)
        {
            string searchText = userSearchText.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(searchText))
            {
                bindingSource.Filter = $"first_name LIKE '%{searchText}%' OR " +
                                       $"last_name LIKE '%{searchText}%' OR " +
                                       $"email LIKE '%{searchText}%' OR " +
                                       $"phone_number LIKE '%{searchText}%' OR " +
                                       $"role LIKE '%{searchText}%'";
            }
            else
            {
                bindingSource.Filter = null;
            }
        }

        private void userFilterBtn_Click(object sender, EventArgs e)
        {
            // Uncomment and implement if you add a DateTimePicker for filtering
            // DateTime selectedDate = selectUserDateTime.Value.Date;
            // bindingSource.Filter = $"created_at >= #{selectedDate:yyyy-MM-dd}# AND created_at < #{selectedDate.AddDays(1):yyyy-MM-dd}#";
        }

        private void userRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadUsersData();
            userSearchText.Text = string.Empty;
            // Reset DateTimePicker if added (e.g., selectUserDateTime.Value = DateTime.Now;)
            bindingSource.Filter = null; // Explicitly clear any existing filter
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = userDataGridView.Rows[e.RowIndex];
                string columnName = userDataGridView.Columns[e.ColumnIndex].Name;

                // Debugging: Confirm the column clicked
                Console.WriteLine($"Clicked column: {columnName}");

                if (columnName == "EditColumn")
                {
                    try
                    {
                        int userId = Convert.ToInt32(row.Cells["id"].Value);
                        string firstName = row.Cells["first_name"].Value.ToString();
                        string lastName = row.Cells["last_name"].Value.ToString();
                        string email = row.Cells["email"].Value.ToString();
                        string phoneNumber = row.Cells["phone_number"].Value.ToString();
                        string role = row.Cells["role"].Value.ToString();

                        AddUserForm editUserForm = new AddUserForm(userId, firstName, lastName, email, phoneNumber, role);
                        editUserForm.FormClosed += (s, args) => LoadUsersData();
                        editUserForm.Show();

                        Console.WriteLine($"Edit button clicked for user ID: {userId}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening edit form: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (columnName == "DeleteColumn")
                {
                    int userId = Convert.ToInt32(row.Cells["id"].Value);
                    string formattedId = $"user{userId:D3}";

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete user {formattedId}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();
                                string query = "DELETE FROM users WHERE id = @userId";
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@userId", userId);
                                    command.ExecuteNonQuery();
                                }
                            }
                            LoadUsersData();
                            MessageBox.Show($"User {formattedId} deleted successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting user: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    Console.WriteLine($"Delete button clicked for user ID: {userId}");
                }
            }
        }

        private void userFirstBtn_Click(object sender, EventArgs e)
        {
            if (userDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                userDataGridView.CurrentCell = userDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void userPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                userDataGridView.CurrentCell = userDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void userNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < userDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                userDataGridView.CurrentCell = userDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void userLastBtn_Click(object sender, EventArgs e)
        {
            if (userDataGridView.Rows.Count > 0)
            {
                currentIndex = userDataGridView.Rows.Count - 1;
                userDataGridView.CurrentCell = userDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void selectUserDateTime_ValueChanged(object sender, EventArgs e)
        {
            // No action needed unless you implement filtering in userFilterBtn_Click
        }
    }
}