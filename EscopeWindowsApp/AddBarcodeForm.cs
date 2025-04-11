using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class AddBarcodeForm : Form
    {
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
        private string productId; // Stores numeric ID (e.g., "19")
        private string variationType;
        private int quantity;
        private string productName;

        public AddBarcodeForm()
        {
            InitializeComponent();
        }

        public AddBarcodeForm(string productId, string variationType, int quantity)
        {
            this.productId = productId; // Store numeric ID
            this.variationType = variationType == "N/A" ? null : variationType;
            this.quantity = quantity;
            InitializeComponent();
            InitializeForm();
        }

        private void AddBarcodeForm_Load(object sender, EventArgs e)
        {
            // Already handled in InitializeForm for constructor with arguments
        }

        private void InitializeForm()
        {
            try
            {
                // Fetch product name
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT name FROM products WHERE id = @productId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        productName = cmd.ExecuteScalar()?.ToString() ?? "Unknown";
                    }
                }

                // Ensure productId is parsed as an integer and formatted with 3 digits
                int numericProductId = int.Parse(productId); // Convert string to int to ensure proper formatting
                string formattedProductId = $"PRO{numericProductId:D3}"; // Guarantees "PRO019" for 19

                // Autofill fields with formatted product ID
                barProIDText.Text = formattedProductId; // Display as "PRO019"
                barProNameText.Text = productName;
                barQuantityText.Text = quantity.ToString();
                barVarTypCombo.Items.Add(variationType ?? "N/A");
                barVarTypCombo.SelectedIndex = 0;

                // Set readonly
                barProIDText.ReadOnly = true;
                barProNameText.ReadOnly = true;
                barQuantityText.ReadOnly = true;
                barVarTypCombo.Enabled = false;

                // Initialize DataGridView
                if (barDataGridView.Columns.Count == 0)
                {
                    barDataGridView.Columns.Add("Count", "Count");
                    barDataGridView.Columns.Add("ProductID", "Product ID");
                    barDataGridView.Columns.Add("ProductName", "Product Name");
                    barDataGridView.Columns.Add("VariationType", "Variation Type");
                    barDataGridView.Columns.Add("SerialNumber", "Serial Number");
                }
                barDataGridView.AllowUserToAddRows = false;

                // Pre-populate rows based on quantity with formatted product ID
                for (int i = 0; i < quantity; i++)
                {
                    barDataGridView.Rows.Add((i + 1).ToString(), formattedProductId, productName, variationType ?? "N/A", "");
                }

                // Handle single quantity case
                if (quantity == 1)
                {
                    barStartRangeText.Enabled = false;
                    barEndRangeText.Enabled = false;
                    checkRange.Enabled = false; // Disable range checkbox
                    checkRange.Checked = false; // Ensure it's unchecked
                    barDataGridView.Enabled = false; // Disable grid for single entry
                    barSingleText.Enabled = true;
                    barSingleText.Focus(); // Focus on single text box
                }
                else
                {
                    barStartRangeText.Enabled = false;
                    barEndRangeText.Enabled = false;
                    barSingleText.Enabled = true; // Enabled by default for manual entry
                    checkRange.Enabled = true; // Enable range checkbox for multiple quantities
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barProIDText_TextChanged(object sender, EventArgs e)
        {
            // Autofilled and readonly, no action needed
        }

        private void barProNameText_TextChanged(object sender, EventArgs e)
        {
            // Autofilled and readonly, no action needed
        }

        private void barVarTypCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Autofilled and readonly, no action needed
        }

        private void barQuantityText_TextChanged(object sender, EventArgs e)
        {
            // Autofilled and readonly, no action needed
        }

        private void barStartRangeText_TextChanged(object sender, EventArgs e)
        {
            // Enabled only when checkRange is checked
        }

        private void barEndRangeText_TextChanged(object sender, EventArgs e)
        {
            // Enabled only when checkRange is checked
        }

        private void barSingleText_TextChanged(object sender, EventArgs e)
        {
            // Handle single serial number input here if needed
        }

        private void barDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display columns as initialized
        }

        private void barAddToListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int numericProductId = int.Parse(productId); // Ensure numeric conversion
                string formattedProductId = $"PRO{numericProductId:D3}"; // Guarantees "PRO019"

                if (quantity == 1)
                {
                    // Handle single serial number from barSingleText
                    string serial = barSingleText.Text.Trim();
                    if (string.IsNullOrWhiteSpace(serial))
                    {
                        MessageBox.Show("Please enter a serial number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    barDataGridView.Rows.Clear();
                    barDataGridView.Rows.Add("1", formattedProductId, productName, variationType ?? "N/A", serial);
                }
                else if (checkRange.Checked)
                {
                    // Handle range-based serial numbers
                    if (!long.TryParse(barStartRangeText.Text, out long startRange) ||
                        !long.TryParse(barEndRangeText.Text, out long endRange))
                    {
                        MessageBox.Show("Please enter valid numeric start and end ranges.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    long rangeCount = endRange - startRange + 1;
                    if (rangeCount != quantity)
                    {
                        MessageBox.Show($"The range must provide exactly {quantity} serial numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (startRange > endRange)
                    {
                        MessageBox.Show("Start range must be less than or equal to end range.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    barDataGridView.Rows.Clear();
                    for (int i = 0; i < quantity; i++)
                    {
                        string serial = (startRange + i).ToString();
                        barDataGridView.Rows.Add((i + 1).ToString(), formattedProductId, productName, variationType ?? "N/A", serial);
                    }
                }
                else
                {
                    // Validate manual entry in grid
                    int nonEmptyRows = 0;
                    foreach (DataGridViewRow row in barDataGridView.Rows)
                    {
                        if (!string.IsNullOrWhiteSpace(row.Cells["SerialNumber"].Value?.ToString()))
                        {
                            nonEmptyRows++;
                        }
                    }
                    if (nonEmptyRows < quantity)
                    {
                        MessageBox.Show($"Please provide serial numbers for all {quantity} items.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barcodeSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var serialNumbers = new List<string>();
                foreach (DataGridViewRow row in barDataGridView.Rows)
                {
                    string serial = row.Cells["SerialNumber"].Value?.ToString()?.Trim();
                    if (string.IsNullOrWhiteSpace(serial))
                    {
                        MessageBox.Show("All serial numbers must be provided.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (serialNumbers.Contains(serial))
                    {
                        MessageBox.Show("Duplicate serial numbers are not allowed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    serialNumbers.Add(serial);
                }

                if (serialNumbers.Count != quantity)
                {
                    MessageBox.Show($"Exactly {quantity} serial numbers must be provided.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (string serial in serialNumbers)
                    {
                        string query = @"
                            INSERT INTO serial_numbers (product_id, variation_type, serial_number, product_name)
                            VALUES (@productId, @variationType, @serialNumber, @productName)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@productId", productId); // Use numeric ID for database
                            cmd.Parameters.AddWithValue("@variationType", (object)variationType ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@serialNumber", serial);
                            cmd.Parameters.AddWithValue("@productName", productName);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Serial numbers saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving serial numbers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barcodeCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkRange_CheckedChanged(object sender, EventArgs e)
        {
            barStartRangeText.Enabled = checkRange.Checked && quantity > 1; // Only enable if quantity > 1
            barEndRangeText.Enabled = checkRange.Checked && quantity > 1;   // Only enable if quantity > 1
            barDataGridView.ReadOnly = checkRange.Checked;                 // Make grid readonly when using range
            barSingleText.Enabled = !checkRange.Checked;                   // Disable barSingleText when checkRange is checked
            if (!checkRange.Checked && quantity > 1)
            {
                barDataGridView.Enabled = true; // Enable grid for manual entry when range is unchecked
            }
        }
    }
}