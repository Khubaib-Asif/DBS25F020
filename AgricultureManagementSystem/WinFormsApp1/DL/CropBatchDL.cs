using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using AgricultureManagementSystem.BL;

namespace AgricultureManagementSystem.DL
{
    public static class CropBatchDL
    {
        public static bool InsertCropBatch(CropStock cropBatch)
        {
            string query = "INSERT INTO crop_batch (Crop_id, Farmer_id, location, purpose, quantitykg, pricekg) " +
                          "VALUES (@cropid, @farmerid, @location, @pur, @quantity, @price)";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cropid", cropBatch.CropId);
                        cmd.Parameters.AddWithValue("@farmerid", cropBatch.FarmerId);
                        cmd.Parameters.AddWithValue("@location", cropBatch.Location);
                        cmd.Parameters.AddWithValue("@quantity", cropBatch.Quantity);
                        cmd.Parameters.AddWithValue("@pur", cropBatch.Purpose);
                        cmd.Parameters.AddWithValue("@price", cropBatch.Price);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting crop batch: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateCropBatch(CropStock cropBatch)
        {
            string query = "UPDATE crop_batch SET Crop_id = @cropid, location = @location, " +
                         "purpose = @pur, quantitykg = @quantity, pricekg = @price " +
                         "WHERE batch_id = @batchId";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cropid", cropBatch.CropId);
                        cmd.Parameters.AddWithValue("@location", cropBatch.Location);
                        cmd.Parameters.AddWithValue("@pur", cropBatch.Purpose);
                        cmd.Parameters.AddWithValue("@quantity", cropBatch.Quantity);
                        cmd.Parameters.AddWithValue("@price", cropBatch.Price);
                        cmd.Parameters.AddWithValue("@batchId", cropBatch.BatchId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating crop batch: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteCropBatch(int batchId)
        {
            string query = "DELETE FROM crop_batch WHERE batch_id = @batchId";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@batchId", batchId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting crop batch: " + ex.Message);
                return false;
            }
        }

        public static List<CropStock> GetCropStocksByFarmer(int farmerId)
        {
            string query = "SELECT * FROM crop_batch WHERE Farmer_id = @farmerId";
            List<CropStock> cropStocks = new List<CropStock>();

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@farmerId", farmerId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CropStock stock = new CropStock(
                                    Convert.ToInt32(reader["Crop_id"]),
                                    farmerId,
                                    reader["location"].ToString(),
                                    reader["purpose"].ToString(),
                                    Convert.ToDecimal(reader["pricekg"]),
                                    Convert.ToDecimal(reader["quantitykg"])
                                   
                                );
                                stock.BatchId = Convert.ToInt32(reader["batch_id"]);
                                cropStocks.Add(stock);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting crop stocks by farmer: " + ex.Message);
            }

            return cropStocks;
        }

        public static CropStock GetCropBatchById(int batchId)
        {
            string query = "SELECT * FROM crop_batch WHERE batch_id = @batchId";
            CropStock stock = null;

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@batchId", batchId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                stock = new CropStock(
                                    Convert.ToInt32(reader["Crop_id"]),
                                    Convert.ToInt32(reader["Farmer_id"]),
                                    reader["location"].ToString(),
                                    reader["purpose"].ToString(),
                                    Convert.ToDecimal(reader["pricekg"]),
                                    Convert.ToDecimal(reader["quantitykg"])
                                   

                                );
                                stock.BatchId = batchId;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting crop batch by ID: " + ex.Message);
            }

            return stock;
        }

        public static DataTable GetStockDataTable(int farmerId)
        {
            string query = @"SELECT cb.batch_id, c.crop_name, cb.location, cb.purpose, 
                       cb.quantitykg, cb.pricekg 
                       FROM crop_batch cb
                       JOIN crops c ON cb.Crop_id = c.crop_id
                       WHERE cb.Farmer_id = @farmerId";

            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@farmerId", farmerId);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting stock data table: " + ex.Message);
            }

            return dt;
        }
    }
}