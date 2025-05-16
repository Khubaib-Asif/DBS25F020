using System;
using System.Collections.Generic;
using System.Data;
using AgricultureManagementSystem.BL;
using MySql.Data.MySqlClient;

namespace AgricultureManagementSystem.DL
{
    public class AgriProductStockDL
    {
        public bool InsertAgriProductStock(AgriProductStock stock)
        {
            string query = @"INSERT INTO aggriproducts_stock 
                            (aggri_id, farmer_id, aggri_Name, location, companyName, 
                             quantity, price, entry, expiryDate, Total) 
                            VALUES (@aggriId, @farmerId, @aggriName, @location, 
                                    @companyName, @quantity, @price, @entry, @expiryDate, @total)";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        stock.UpdateTotal();

                        cmd.Parameters.AddWithValue("@aggriId", stock.AgriID);
                        cmd.Parameters.AddWithValue("@farmerId", stock.FarmerID);
                        cmd.Parameters.AddWithValue("@aggriName", stock.AgriName);
                        cmd.Parameters.AddWithValue("@location", stock.Location);
                        cmd.Parameters.AddWithValue("@companyName", stock.CompanyName);
                        cmd.Parameters.AddWithValue("@quantity", stock.Quantity);
                        cmd.Parameters.AddWithValue("@price", stock.Price);
                        cmd.Parameters.AddWithValue("@entry", stock.EntryDate);
                        cmd.Parameters.AddWithValue("@expiryDate", stock.ExpiryDate);
                        cmd.Parameters.AddWithValue("@total", stock.Total);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool UpdateAgriProductStock(AgriProductStock stock)
        {
            string query = @"UPDATE aggriproducts_stock SET 
                            aggri_id = @aggriId, 
                            farmer_id = @farmerId, 
                            aggri_Name = @aggriName, 
                            location = @location, 
                            companyName = @companyName, 
                            quantity = @quantity, 
                            price = @price, 
                            entry = @entry, 
                            expiryDate = @expiryDate, 
                            Total = @total
                            WHERE stock_id = @stockId";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        stock.UpdateTotal();

                        cmd.Parameters.AddWithValue("@aggriId", stock.AgriID);
                        cmd.Parameters.AddWithValue("@farmerId", stock.FarmerID);
                        cmd.Parameters.AddWithValue("@aggriName", stock.AgriName);
                        cmd.Parameters.AddWithValue("@location", stock.Location);
                        cmd.Parameters.AddWithValue("@companyName", stock.CompanyName);
                        cmd.Parameters.AddWithValue("@quantity", stock.Quantity);
                        cmd.Parameters.AddWithValue("@price", stock.Price);
                        cmd.Parameters.AddWithValue("@entry", stock.EntryDate);
                        cmd.Parameters.AddWithValue("@expiryDate", stock.ExpiryDate);
                        cmd.Parameters.AddWithValue("@total", stock.Total);
                        cmd.Parameters.AddWithValue("@stockId", stock.StockID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable Loadcombobox()
        {
            string query = "SELECT aggriid, Type FROM aggri";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static string GetCategoryName(int agriId)
        {
            string query = "SELECT Type FROM aggri WHERE aggriid = @agriId";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@agriId", agriId);
                        object result = cmd.ExecuteScalar();
                        return result?.ToString() ?? "Unknown";
                    }
                }
            }
            catch
            {
                return "Unknown";
            }
        }

        public static bool DeleteAgriProductStock(int stockId)
        {
            string query = "DELETE FROM aggriproducts_stock WHERE stock_id = @stockId";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@stockId", stockId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static List<AgriProductStock> GetAllAgriProductStocks(int farmerId)
        {
            var stocks = new List<AgriProductStock>();
            string query = "SELECT * FROM aggriproducts_stock WHERE farmer_id = @farmerId";

            try
            {
                using (var conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@farmerId", farmerId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var stock = new AgriProductStock();

                                stock.StockID = reader["stock_id"] != DBNull.Value ? Convert.ToInt32(reader["stock_id"]) : 0;
                                stock.AgriID = reader["aggri_id"] != DBNull.Value ? Convert.ToInt32(reader["aggri_id"]) : 0;
                                stock.FarmerID = reader["farmer_id"] != DBNull.Value ? Convert.ToInt32(reader["farmer_id"]) : 0;
                                stock.AgriName = reader["aggri_Name"]?.ToString() ?? string.Empty;
                                stock.Location = reader["location"]?.ToString() ?? string.Empty;
                                stock.CompanyName = reader["companyName"]?.ToString() ?? string.Empty;
                                stock.Quantity = reader["quantity"] != DBNull.Value ? Convert.ToDecimal(reader["quantity"]) : 0m;
                                stock.Price = reader["price"] != DBNull.Value ? Convert.ToDecimal(reader["price"]) : 0m;
                                stock.EntryDate = reader["entry"] != DBNull.Value ? Convert.ToDateTime(reader["entry"]) : DateTime.Now.Date;
                                stock.ExpiryDate = reader["expiryDate"] != DBNull.Value ? Convert.ToDateTime(reader["expiryDate"]) : DateTime.Now.Date.AddMonths(1);

                                stock.UpdateTotal();
                                stocks.Add(stock);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return stocks;
        }

        public static AgriProductStock GetAgriProductStockById(int stockId)
        {
            string query = "SELECT * FROM aggriproducts_stock WHERE stock_id = @stockId";
            AgriProductStock stock = null;

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@stockId", stockId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                stock = new AgriProductStock
                                {
                                    StockID = Convert.ToInt32(reader["stock_id"]),
                                    AgriID = Convert.ToInt32(reader["aggri_id"]),
                                    FarmerID = Convert.ToInt32(reader["farmer_id"]),
                                    AgriName = reader["aggri_Name"].ToString(),
                                    Location = reader["location"].ToString(),
                                    CompanyName = reader["companyName"].ToString(),
                                    Quantity = Convert.ToDecimal(reader["quantity"]),
                                    Price = Convert.ToDecimal(reader["price"]),
                                    EntryDate = Convert.ToDateTime(reader["entry"]),
                                    ExpiryDate = Convert.ToDateTime(reader["expiryDate"])
                                };
                                stock.UpdateTotal();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return stock;
        }
    }
}