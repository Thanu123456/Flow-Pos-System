using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class ProductPricing : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"]?.ConnectionString;
        private int variationId;
        private string variationName;
        private string selectedVariationType;
        private List<string> variationTypes;
        private int productId;
        public List<PricingDetail> PricingDetails { get; private set; }

        public ProductPricing(int variationId, int productId = -1, string selectedVariationType = null)
        {
            InitializeComponent();
            this.variationId = variationId;
            this.productId = productId;
            this.selectedVariationType = selectedVariationType;

            LoadVariationData();
            if (productId != -1)
            {
                LoadExistingPricing();
            }
            SetupForm();
        }

        private void LoadVariationData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT name, type1, type2, type3, type4, type5 FROM variations WHERE id = @variationId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@variationId", variationId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                variationName = reader.GetString("name");
                                variationTypes = new List<string>();
                                for (int i = 1; i <= 5; i++)
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal($"type{i}")))
                                    {
                                        string type = reader.GetString($"type{i}");
                                        if (!string.IsNullOrWhiteSpace(type))
                                        {
                                            variationTypes.Add(type);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading variation data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupForm()
        {
            priceVarNameText.Text = variationName;
            priceVarNameText.ReadOnly = true;

            var nameLabels = new[] { priVar1NameLbl, priVar2NameLbl, priVar3NameLbl, priVar4NameLbl, priVar5NameLbl };
            var typeLabels = new[] { priVarType1Lbl, priVarType2Lbl, priVarType3Lbl, priVarType4Lbl, priVarType5Lbl };
            var costTexts = new[] { ty1CostPriText, ty2CostPriText, ty3CostPriText, ty4CostPriText, ty5CostPriText };
            var retailTexts = new[] { ty1RetPriText, ty2RetPriText, ty3RetPriText, ty4RetPriText, ty5RetPriText };
            var wholeTexts = new[] { ty1WholePriText, ty2WholePriText, ty3WholePriText, ty4WholePriText, ty5WholePriText };

            if (selectedVariationType != null)
            {
                int index = variationTypes.IndexOf(selectedVariationType);
                if (index >= 0)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (i == index)
                        {
                            nameLabels[i].Text = variationName;
                            typeLabels[i].Text = variationTypes[i];
                            costTexts[i].Enabled = true;
                            retailTexts[i].Enabled = true;
                            wholeTexts[i].Enabled = true;
                        }
                        else
                        {
                            nameLabels[i].Text = variationName;
                            typeLabels[i].Text = i < variationTypes.Count ? variationTypes[i] : "";
                            costTexts[i].Enabled = false;
                            retailTexts[i].Enabled = false;
                            wholeTexts[i].Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selected variation type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i < variationTypes.Count)
                    {
                        nameLabels[i].Text = variationName;
                        typeLabels[i].Text = variationTypes[i];
                        costTexts[i].Enabled = true;
                        retailTexts[i].Enabled = true;
                        wholeTexts[i].Enabled = true;
                    }
                    else
                    {
                        nameLabels[i].Text = "";
                        typeLabels[i].Text = "";
                        costTexts[i].Enabled = false;
                        retailTexts[i].Enabled = false;
                        wholeTexts[i].Enabled = false;
                        costTexts[i].Text = "";
                        retailTexts[i].Text = "";
                        wholeTexts[i].Text = "";
                    }
                }
            }
        }

        private void LoadExistingPricing()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT variation_type, cost_price, retail_price, wholesale_price " +
                                   "FROM pricing WHERE product_id = @productId AND variation_id = @variationId";
                    if (selectedVariationType != null)
                    {
                        query += " AND variation_type = @selectedVariationType";
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@variationId", variationId);
                        if (selectedVariationType != null)
                        {
                            cmd.Parameters.AddWithValue("@selectedVariationType", selectedVariationType);
                        }
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string variationType = reader.GetString("variation_type");
                                decimal costPrice = reader.GetDecimal("cost_price");
                                decimal retailPrice = reader.GetDecimal("retail_price");
                                decimal wholesalePrice = reader.GetDecimal("wholesale_price");

                                int index = variationTypes.IndexOf(variationType);
                                if (index >= 0 && index < 5)
                                {
                                    ty1CostPriText.Text = index == 0 ? costPrice.ToString() : ty1CostPriText.Text;
                                    ty1RetPriText.Text = index == 0 ? retailPrice.ToString() : ty1RetPriText.Text;
                                    ty1WholePriText.Text = index == 0 ? wholesalePrice.ToString() : ty1WholePriText.Text;

                                    ty2CostPriText.Text = index == 1 ? costPrice.ToString() : ty2CostPriText.Text;
                                    ty2RetPriText.Text = index == 1 ? retailPrice.ToString() : ty2RetPriText.Text;
                                    ty2WholePriText.Text = index == 1 ? wholesalePrice.ToString() : ty2WholePriText.Text;

                                    ty3CostPriText.Text = index == 2 ? costPrice.ToString() : ty3CostPriText.Text;
                                    ty3RetPriText.Text = index == 2 ? retailPrice.ToString() : ty3RetPriText.Text;
                                    ty3WholePriText.Text = index == 2 ? wholesalePrice.ToString() : ty3WholePriText.Text;

                                    ty4CostPriText.Text = index == 3 ? costPrice.ToString() : ty4CostPriText.Text;
                                    ty4RetPriText.Text = index == 3 ? retailPrice.ToString() : ty4RetPriText.Text;
                                    ty4WholePriText.Text = index == 3 ? wholesalePrice.ToString() : ty4WholePriText.Text;

                                    ty5CostPriText.Text = index == 4 ? costPrice.ToString() : ty5CostPriText.Text;
                                    ty5RetPriText.Text = index == 4 ? retailPrice.ToString() : ty5RetPriText.Text;
                                    ty5WholePriText.Text = index == 4 ? wholesalePrice.ToString() : ty5WholePriText.Text;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading existing pricing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void priSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var costTexts = new[] { ty1CostPriText, ty2CostPriText, ty3CostPriText, ty4CostPriText, ty5CostPriText };
                var retailTexts = new[] { ty1RetPriText, ty2RetPriText, ty3RetPriText, ty4RetPriText, ty5RetPriText };
                var wholeTexts = new[] { ty1WholePriText, ty2WholePriText, ty3WholePriText, ty4WholePriText, ty5WholePriText };

                if (selectedVariationType != null)
                {
                    int index = variationTypes.IndexOf(selectedVariationType);
                    if (index >= 0)
                    {
                        if (string.IsNullOrWhiteSpace(costTexts[index].Text) ||
                            string.IsNullOrWhiteSpace(retailTexts[index].Text) ||
                            string.IsNullOrWhiteSpace(wholeTexts[index].Text))
                        {
                            MessageBox.Show("Please fill in all pricing fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        decimal costPrice = decimal.Parse(costTexts[index].Text);
                        decimal retailPrice = decimal.Parse(retailTexts[index].Text);
                        decimal wholesalePrice = decimal.Parse(wholeTexts[index].Text);

                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            string updateQuery = "UPDATE pricing SET cost_price = @costPrice, retail_price = @retailPrice, wholesale_price = @wholesalePrice " +
                                                 "WHERE product_id = @productId AND variation_id = @variationId AND variation_type = @variationType";
                            using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@costPrice", costPrice);
                                cmd.Parameters.AddWithValue("@retailPrice", retailPrice);
                                cmd.Parameters.AddWithValue("@wholesalePrice", wholesalePrice);
                                cmd.Parameters.AddWithValue("@productId", productId);
                                cmd.Parameters.AddWithValue("@variationId", variationId);
                                cmd.Parameters.AddWithValue("@variationType", selectedVariationType);
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected == 0)
                                {
                                    MessageBox.Show("No pricing record found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Selected variation type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    PricingDetails = new List<PricingDetail>();
                    for (int i = 0; i < variationTypes.Count; i++)
                    {
                        if (string.IsNullOrWhiteSpace(costTexts[i].Text) || string.IsNullOrWhiteSpace(retailTexts[i].Text) ||
                            string.IsNullOrWhiteSpace(wholeTexts[i].Text))
                        {
                            MessageBox.Show("Please fill in all pricing fields for enabled variations.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        PricingDetails.Add(new PricingDetail
                        {
                            VariationType = variationTypes[i],
                            CostPrice = decimal.Parse(costTexts[i].Text),
                            RetailPrice = decimal.Parse(retailTexts[i].Text),
                            WholesalePrice = decimal.Parse(wholeTexts[i].Text)
                        });
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving pricing details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void priSaveBtn_Click_2(object sender, EventArgs e)
        {
            try
            {
                PricingDetails = new List<PricingDetail>();
                var costTexts = new[] { ty1CostPriText, ty2CostPriText, ty3CostPriText, ty4CostPriText, ty5CostPriText };
                var retailTexts = new[] { ty1RetPriText, ty2RetPriText, ty3RetPriText, ty4RetPriText, ty5RetPriText };
                var wholeTexts = new[] { ty1WholePriText, ty2WholePriText, ty3WholePriText, ty4WholePriText, ty5WholePriText };
                int validVariations = 0;

                for (int i = 0; i < variationTypes.Count; i++)
                {
                    bool isAnyFieldFilled = !string.IsNullOrWhiteSpace(costTexts[i].Text) ||
                                            !string.IsNullOrWhiteSpace(retailTexts[i].Text) ||
                                            !string.IsNullOrWhiteSpace(wholeTexts[i].Text);
                    bool isAllFieldsEmpty = string.IsNullOrWhiteSpace(costTexts[i].Text) &&
                                            string.IsNullOrWhiteSpace(retailTexts[i].Text) &&
                                            string.IsNullOrWhiteSpace(wholeTexts[i].Text);

                    if (isAllFieldsEmpty)
                    {
                        continue; // Skip empty variations
                    }

                    if (isAnyFieldFilled)
                    {
                        if (string.IsNullOrWhiteSpace(costTexts[i].Text) ||
                            string.IsNullOrWhiteSpace(retailTexts[i].Text) ||
                            string.IsNullOrWhiteSpace(wholeTexts[i].Text))
                        {
                            MessageBox.Show($"Please fill in all pricing fields for {variationTypes[i]}.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            PricingDetails = null;
                            return;
                        }

                        if (!decimal.TryParse(costTexts[i].Text, out decimal costPrice) ||
                            !decimal.TryParse(retailTexts[i].Text, out decimal retailPrice) ||
                            !decimal.TryParse(wholeTexts[i].Text, out decimal wholesalePrice))
                        {
                            MessageBox.Show($"Please enter valid numeric values for {variationTypes[i]}.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            PricingDetails = null;
                            return;
                        }

                        PricingDetails.Add(new PricingDetail
                        {
                            VariationType = variationTypes[i],
                            CostPrice = costPrice,
                            RetailPrice = retailPrice,
                            WholesalePrice = wholesalePrice
                        });
                        validVariations++;
                    }
                }

                if (validVariations < 1)
                {
                    MessageBox.Show("Please provide complete pricing details for at least two variations.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PricingDetails = null;
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving pricing details: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PricingDetails = null;
            }
        }

        private void priCancelBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ProductPricing_Load(object sender, EventArgs e)
        {
        }
    }

    public class PricingDetail
    {
        public string VariationType { get; set; }
        public decimal CostPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal WholesalePrice { get; set; }
    }
}