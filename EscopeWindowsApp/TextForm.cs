using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;

namespace EscopeWindowsApp
{
    public partial class TextForm : Form
    {
        private List<Product> allProducts;
        private List<Product> filteredProducts;
        private int currentIndex = 0;
        private const int productsPerPage = 3;
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;

        public TextForm()
        {
            InitializeComponent();
            // Configure PictureBox display settings
            productPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            productPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            productPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void TextForm_Load(object sender, EventArgs e)
        {
            allProducts = LoadProducts();
            filteredProducts = allProducts;
            DisplayProducts();
        }

        private List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT p.id, p.name, p.image_path, pr.variation_type
                        FROM products p
                        LEFT JOIN pricing pr ON p.id = pr.product_id
                        ORDER BY p.id, pr.variation_type";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product
                                {
                                    Id = reader.GetInt32("id"),
                                    Name = reader.GetString("name"),
                                    VariationType = reader["variation_type"] != DBNull.Value ? reader.GetString("variation_type") : "N/A"
                                };
                                try
                                {
                                    product.Image = reader["image_path"] != DBNull.Value ? Image.FromStream(new MemoryStream((byte[])reader["image_path"])) : null;
                                }
                                catch (Exception)
                                {
                                    product.Image = null; // Fallback if image loading fails
                                }
                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return products;
        }

        private void DisplayProducts()
        {
            // Reset displays and visibility
            productPictureBox1.Image = null;
            productPictureBox1.Visible = false;
            productLabel1.Text = "";
            productLabel1.Visible = false;

            productPictureBox2.Image = null;
            productPictureBox2.Visible = false;
            productLabel2.Text = "";
            productLabel2.Visible = false;

            productPictureBox3.Image = null;
            productPictureBox3.Visible = false;
            productLabel3.Text = "";
            productLabel3.Visible = false;

            if (filteredProducts == null || filteredProducts.Count == 0) return;

            int start = currentIndex;
            int end = Math.Min(start + productsPerPage, filteredProducts.Count);

            if (start < end)
            {
                Product p1 = filteredProducts[start];
                productPictureBox1.Image = p1.Image;
                productPictureBox1.Visible = true;
                productLabel1.Text = p1.VariationType == "N/A" ? p1.Name : $"{p1.Name} - {p1.VariationType}";
                productLabel1.Visible = true;
            }
            if (start + 1 < end)
            {
                Product p2 = filteredProducts[start + 1];
                productPictureBox2.Image = p2.Image;
                productPictureBox2.Visible = true;
                productLabel2.Text = p2.VariationType == "N/A" ? p2.Name : $"{p2.Name} - {p2.VariationType}";
                productLabel2.Visible = true;
            }
            if (start + 2 < end)
            {
                Product p3 = filteredProducts[start + 2];
                productPictureBox3.Image = p3.Image;
                productPictureBox3.Visible = true;
                productLabel3.Text = p3.VariationType == "N/A" ? p3.Name : $"{p3.Name} - {p3.VariationType}";
                productLabel3.Visible = true;
            }

            // Enable/disable navigation buttons
            productPrevBtn.Enabled = currentIndex > 0;
            productNextBtn.Enabled = end < filteredProducts.Count;
        }

        private void productNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex + productsPerPage < filteredProducts.Count)
            {
                currentIndex += productsPerPage;
                DisplayProducts();
            }
        }

        private void productPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex - productsPerPage >= 0)
            {
                currentIndex -= productsPerPage;
                DisplayProducts();
            }
            else
            {
                currentIndex = 0;
                DisplayProducts();
            }
        }

        private void productSearchText_TextChanged(object sender, EventArgs e)
        {
            string searchText = productSearchText.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                filteredProducts = new List<Product>(allProducts);
            }
            else
            {
                filteredProducts = allProducts
                    .Where(p => p.Name.ToLower().Contains(searchText) || p.VariationType.ToLower().Contains(searchText))
                    .ToList();
            }
            currentIndex = 0;
            DisplayProducts();
        }

        private void proPanel2_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Add custom painting if needed
        }

        private void productPictureBox1_Click(object sender, EventArgs e)
        {
            // Placeholder for future functionality, e.g., showing product details
        }

        private void productLabel1_Click(object sender, EventArgs e)
        {
            // Placeholder for future functionality
        }

        private void productPictureBox2_Click(object sender, EventArgs e)
        {
            // Placeholder for future functionality
        }

        private void productLabel2_Click(object sender, EventArgs e)
        {
            // Placeholder for future functionality
        }

        private void productPictureBox3_Click(object sender, EventArgs e)
        {
            // Placeholder for future functionality
        }

        private void productLabel3_Click(object sender, EventArgs e)
        {
            // Placeholder for future functionality
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }
        public string VariationType { get; set; }
    }
}