using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class StockManager
{
    private readonly string _connectionString;

    public StockManager(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void AddStockFromGRN(int grnItemsId, int productId, string variationType, string unit, decimal quantity, DateTime expiryDate)
    {
        using (MySqlConnection conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            using (MySqlTransaction transaction = conn.BeginTransaction())
            {
                try
                {
                    bool isExpired = expiryDate.Date < DateTime.Today;

                    if (isExpired)
                    {
                        string insertExpiredQuery = @"
                            INSERT INTO expired_items (stock_details_id, product_id, variation_type, unit, expired_qty, expiry_date, removed_date)
                            VALUES (@stockDetailsId, @productId, @variationType, @unit, @expiredQty, @expiryDate, CURDATE())";
                        using (MySqlCommand cmd = new MySqlCommand(insertExpiredQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@stockDetailsId", DBNull.Value);
                            cmd.Parameters.AddWithValue("@productId", productId);
                            cmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@expiredQty", quantity);
                            cmd.Parameters.AddWithValue("@expiryDate", expiryDate);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertStockDetailsQuery = @"
                            INSERT INTO stock_details (grn_items_id, remaining_qty, is_expired)
                            VALUES (@grnItemsId, @quantity, 0)";
                        using (MySqlCommand cmd = new MySqlCommand(insertStockDetailsQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@grnItemsId", grnItemsId);
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.ExecuteNonQuery();
                        }

                        string checkStockQuery = @"
                            SELECT stock 
                            FROM stock 
                            WHERE product_id = @productId 
                            AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                            AND (unit = @unit OR (unit IS NULL AND @unit IS NULL))
                            LIMIT 1";
                        using (MySqlCommand checkCmd = new MySqlCommand(checkStockQuery, conn, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@productId", productId);
                            checkCmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                            checkCmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);

                            object result = checkCmd.ExecuteScalar();

                            if (result != null)
                            {
                                decimal currentStock = Convert.ToDecimal(result);
                                decimal newStock = currentStock + quantity;

                                string updateStockQuery = @"
                                    UPDATE stock 
                                    SET stock = @newStock 
                                    WHERE product_id = @productId 
                                    AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                                    AND (unit = @unit OR (unit IS NULL AND @unit IS NULL))";
                                using (MySqlCommand updateCmd = new MySqlCommand(updateStockQuery, conn, transaction))
                                {
                                    updateCmd.Parameters.AddWithValue("@newStock", newStock);
                                    updateCmd.Parameters.AddWithValue("@productId", productId);
                                    updateCmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                    updateCmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                string insertStockQuery = @"
                                    INSERT INTO stock (product_id, variation_type, stock, unit)
                                    VALUES (@productId, @variationType, @quantity, @unit)";
                                using (MySqlCommand insertCmd = new MySqlCommand(insertStockQuery, conn, transaction))
                                {
                                    insertCmd.Parameters.AddWithValue("@productId", productId);
                                    insertCmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                    insertCmd.Parameters.AddWithValue("@quantity", quantity);
                                    insertCmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);
                                    insertCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Failed to add stock from GRN: " + ex.Message);
                }
            }
        }
    }

    public void AddRefundToOldestBatch(int productId, string variationType, string unit, decimal quantity)
    {
        using (MySqlConnection conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            using (MySqlTransaction transaction = conn.BeginTransaction())
            {
                try
                {
                    string batchQuery = @"
                        SELECT sd.id, sd.remaining_qty, gi.expiry_date
                        FROM stock_details sd
                        JOIN grn_items gi ON sd.grn_items_id = gi.id
                        WHERE gi.product_id = @productId
                        AND (gi.variation_type = @variationType OR (gi.variation_type IS NULL AND @variationType IS NULL))
                        AND (gi.unit = @unit OR (gi.unit IS NULL AND @unit IS NULL))
                        AND sd.is_expired = 0
                        ORDER BY gi.expiry_date ASC
                        LIMIT 1";
                    int? stockDetailsId = null;
                    using (MySqlCommand cmd = new MySqlCommand(batchQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                stockDetailsId = reader.GetInt32("id");
                            }
                        }
                    }

                    if (stockDetailsId.HasValue)
                    {
                        string updateBatchQuery = @"
                            UPDATE stock_details
                            SET remaining_qty = remaining_qty + @quantity
                            WHERE id = @stockDetailsId";
                        using (MySqlCommand cmd = new MySqlCommand(updateBatchQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.Parameters.AddWithValue("@stockDetailsId", stockDetailsId.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string grnQuery = @"
                            SELECT gi.id
                            FROM grn_items gi
                            WHERE gi.product_id = @productId
                            AND (gi.variation_type = @variationType OR (gi.variation_type IS NULL AND @variationType IS NULL))
                            AND (gi.unit = @unit OR (gi.unit IS NULL AND @unit IS NULL))
                            LIMIT 1";
                        int? grnItemsId = null;
                        using (MySqlCommand cmd = new MySqlCommand(grnQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@productId", productId);
                            cmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    grnItemsId = reader.GetInt32("id");
                                }
                            }
                        }

                        if (!grnItemsId.HasValue)
                        {
                            string insertGrnQuery = @"
                                INSERT INTO grn (grn_no, supplier_id, date, total_price)
                                VALUES (@grnNo, @supplierId, @date, 0)";
                            string newGrnNo = $"REFUND-{DateTime.Now.Ticks}";
                            int supplierId = 1;
                            using (MySqlCommand cmd = new MySqlCommand(insertGrnQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@grnNo", newGrnNo);
                                cmd.Parameters.AddWithValue("@supplierId", supplierId);
                                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                                cmd.ExecuteNonQuery();
                                grnItemsId = (int)cmd.LastInsertedId;
                            }

                            string insertGrnItemsQuery = @"
                                INSERT INTO grn_items (grn_id, product_id, variation_type, unit, quantity, cost_price, net_price, expiry_date)
                                VALUES (@grnId, @productId, @variationType, @unit, @quantity, 0, 0, DATE_ADD(CURDATE(), INTERVAL 1 YEAR))";
                            using (MySqlCommand cmd = new MySqlCommand(insertGrnItemsQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@grnId", grnItemsId);
                                cmd.Parameters.AddWithValue("@productId", productId);
                                cmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.ExecuteNonQuery();
                                grnItemsId = (int)cmd.LastInsertedId;
                            }
                        }

                        string insertStockDetailsQuery = @"
                            INSERT INTO stock_details (grn_items_id, remaining_qty)
                            VALUES (@grnItemsId, @quantity)";
                        using (MySqlCommand cmd = new MySqlCommand(insertStockDetailsQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@grnItemsId", grnItemsId.Value);
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    string updateStockQuery = @"
                        UPDATE stock
                        SET stock = stock + @quantity
                        WHERE product_id = @productId
                        AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                        AND (unit = @unit OR (unit IS NULL AND @unit IS NULL))";
                    using (MySqlCommand cmd = new MySqlCommand(updateStockQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
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
                    string varType = string.IsNullOrEmpty(variationType) || variationType == "N/A" ? null : variationType;
                    string unitValue = string.IsNullOrEmpty(unit) || unit == "N/A" ? null : unit;

                    if (!isIncrease)
                    {
                        string checkStockQuery = @"
                            SELECT COALESCE((SELECT SUM(sd.remaining_qty) 
                                             FROM stock_details sd
                                             JOIN grn_items gi ON sd.grn_items_id = gi.id
                                             WHERE gi.product_id = @productId
                                             AND (gi.variation_type = @variationType OR (gi.variation_type IS NULL AND @variationType IS NULL))
                                             AND (gi.unit = @unit OR (gi.unit IS NULL AND @unit IS NULL))
                                             AND sd.is_expired = 0
                                             AND sd.remaining_qty > 0), 0) AS available_stock";
                        using (MySqlCommand checkCmd = new MySqlCommand(checkStockQuery, conn, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@productId", productId);
                            checkCmd.Parameters.AddWithValue("@variationType", varType ?? (object)DBNull.Value);
                            checkCmd.Parameters.AddWithValue("@unit", unitValue ?? (object)DBNull.Value);
                            decimal availableStock = Convert.ToDecimal(checkCmd.ExecuteScalar());
                            if (availableStock < quantity)
                            {
                                throw new InvalidOperationException($"Cannot return product. Insufficient non-expired stock. Available: {availableStock}, Required: {quantity}");
                            }
                        }

                        ReduceStockFromBatches(productId, varType, unitValue, quantity, conn, transaction);
                    }
                    else
                    {
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
                                decimal newStock = currentStock + quantity;

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

    public void ReduceStockFromBatches(int productId, string variationType, string unit, decimal quantityToDeduct)
    {
        using (MySqlConnection conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            using (MySqlTransaction transaction = conn.BeginTransaction())
            {
                ReduceStockFromBatches(productId, variationType, unit, quantityToDeduct, conn, transaction);
                transaction.Commit();
            }
        }
    }

    public void ReduceStockFromBatches(int productId, string variationType, string unit, decimal quantityToDeduct, MySqlConnection conn, MySqlTransaction transaction)
    {
        string varType = string.IsNullOrEmpty(variationType) || variationType == "N/A" ? null : variationType;
        string unitValue = string.IsNullOrEmpty(unit) || unit == "N/A" ? null : unit;

        string batchQuery = @"
            SELECT sd.id, sd.remaining_qty, gi.expiry_date
            FROM stock_details sd
            JOIN grn_items gi ON sd.grn_items_id = gi.id
            WHERE gi.product_id = @productId
            AND (gi.variation_type = @variationType OR (gi.variation_type IS NULL AND @variationType IS NULL))
            AND (gi.unit = @unit OR (gi.unit IS NULL AND @unit IS NULL))
            AND sd.remaining_qty > 0
            AND sd.is_expired = 0
            AND gi.expiry_date >= CURDATE()
            ORDER BY gi.expiry_date ASC";

        using (MySqlCommand batchCmd = new MySqlCommand(batchQuery, conn, transaction))
        {
            batchCmd.Parameters.AddWithValue("@productId", productId);
            batchCmd.Parameters.AddWithValue("@variationType", varType ?? (object)DBNull.Value);
            batchCmd.Parameters.AddWithValue("@unit", unitValue ?? (object)DBNull.Value);

            using (MySqlDataReader reader = batchCmd.ExecuteReader())
            {
                decimal remainingToDeduct = quantityToDeduct;
                var batches = new List<(int Id, decimal Quantity)>();

                while (reader.Read() && remainingToDeduct > 0)
                {
                    int batchId = reader.GetInt32("id");
                    decimal available = reader.GetDecimal("remaining_qty");

                    decimal deduct = Math.Min(available, remainingToDeduct);
                    batches.Add((batchId, deduct));
                    remainingToDeduct -= deduct;
                }

                if (remainingToDeduct > 0)
                {
                    throw new InvalidOperationException("Not enough non-expired stock in batches to complete the deduction.");
                }

                reader.Close();

                foreach (var (batchId, deductQty) in batches)
                {
                    string updateBatchQuery = "UPDATE stock_details SET remaining_qty = remaining_qty - @deductQty WHERE id = @batchId";
                    using (MySqlCommand updateBatchCmd = new MySqlCommand(updateBatchQuery, conn, transaction))
                    {
                        updateBatchCmd.Parameters.AddWithValue("@deductQty", deductQty);
                        updateBatchCmd.Parameters.AddWithValue("@batchId", batchId);
                        updateBatchCmd.ExecuteNonQuery();
                    }
                }

                string updateStockQuery = @"
                    UPDATE stock 
                    SET stock = stock - @deducted 
                    WHERE product_id = @productId 
                    AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                    AND (unit = @unit OR (unit IS NULL AND @unit IS NULL))";
                using (MySqlCommand updateStockCmd = new MySqlCommand(updateStockQuery, conn, transaction))
                {
                    updateStockCmd.Parameters.AddWithValue("@deducted", quantityToDeduct);
                    updateStockCmd.Parameters.AddWithValue("@productId", productId);
                    updateStockCmd.Parameters.AddWithValue("@variationType", varType ?? (object)DBNull.Value);
                    updateStockCmd.Parameters.AddWithValue("@unit", unitValue ?? (object)DBNull.Value);
                    updateStockCmd.ExecuteNonQuery();
                }
            }
        }
    }
}