using MySql.Data.MySqlClient;
using System;
using System.Data;

public class StockManager
{
    private readonly string _connectionString;

    public StockManager(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void UpdateStock(int productId, string variationType, decimal quantity, string unit, bool isIncrease)
    {
        using (MySqlConnection conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            using (MySqlTransaction transaction = conn.BeginTransaction())
            {
                try
                {
                    // Normalize variationType and unit
                    string varType = string.IsNullOrEmpty(variationType) || variationType == "N/A" ? null : variationType;
                    string unitValue = string.IsNullOrEmpty(unit) || unit == "N/A" ? null : unit;

                    // Check if stock entry exists
                    string checkQuery = @"
                        SELECT stock 
                        FROM stock 
                        WHERE product_id = @productId 
                        AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                        AND (unit = @unit OR (unit IS NULL AND @unit IS NULL))
                        LIMIT 1";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn, transaction))
                    {
                        checkCmd.Parameters.AddWithValue("@productId", productId);
                        checkCmd.Parameters.AddWithValue("@variationType", varType ?? (object)DBNull.Value);
                        checkCmd.Parameters.AddWithValue("@unit", unitValue ?? (object)DBNull.Value);
                        object result = checkCmd.ExecuteScalar();
                        if (result != null)
                        {
                            decimal currentStock = Convert.ToDecimal(result);
                            decimal newStock = isIncrease ? currentStock + quantity : currentStock - quantity;
                            if (newStock < 0)
                            {
                                throw new InvalidOperationException("Stock cannot be negative.");
                            }

                            string updateQuery = @"
                                UPDATE stock 
                                SET stock = @newStock 
                                WHERE product_id = @productId 
                                AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                                AND (unit = @unit OR (unit IS NULL AND @unit IS NULL))";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@newStock", newStock);
                                updateCmd.Parameters.AddWithValue("@productId", productId);
                                updateCmd.Parameters.AddWithValue("@variationType", varType ?? (object)DBNull.Value);
                                updateCmd.Parameters.AddWithValue("@unit", unitValue ?? (object)DBNull.Value);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            if (!isIncrease)
                            {
                                throw new InvalidOperationException("Cannot decrease stock for non-existing entry.");
                            }

                            string insertQuery = @"
                                INSERT INTO stock (product_id, variation_type, stock, unit)
                                VALUES (@productId, @variationType, @quantity, @unit)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@productId", productId);
                                insertCmd.Parameters.AddWithValue("@variationType", varType ?? (object)DBNull.Value);
                                insertCmd.Parameters.AddWithValue("@quantity", quantity);
                                insertCmd.Parameters.AddWithValue("@unit", unitValue ?? (object)DBNull.Value);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Stock update failed: " + ex.Message);
                }
            }
        }
    }
}