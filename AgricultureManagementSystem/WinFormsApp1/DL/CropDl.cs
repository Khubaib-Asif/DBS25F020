using System;
using System.Collections.Generic;
using System.Data;
using AgricultureManagementSystem.BL;
using MySql.Data.MySqlClient;

namespace AgricultureManagementSystem.DL
{
    public static class CropDL
    {
        public static bool InsertCrop(Crop crop)
        {
            string query = "INSERT INTO crop (crop_name, description) VALUES (@cropName, @description)";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cropName", crop.CropName);
                        cmd.Parameters.AddWithValue("@description", crop.Description);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting crop: " + ex.Message);
                return false;
            }
        }
        public static DataTable Loadcombobox()
        {
            string query = "select crop_id,crop_name from crop";

            DataTable dataTable = DatabaseHelper.Instance.GetData(query);
            return dataTable;
        }
        public static bool UpdateCrop(Crop crop)
        {
            string query = "UPDATE crop SET crop_name = @cropName, description = @description " +
                          "WHERE crop_id = @cropId";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cropName", crop.CropName);
                        cmd.Parameters.AddWithValue("@description", crop.Description);
                        cmd.Parameters.AddWithValue("@cropId", crop.CropId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating crop: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteCrop(int cropId)
        {
            string query = "DELETE FROM crop WHERE crop_id = @cropId";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cropId", cropId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting crop: " + ex.Message);
                return false;
            }
        }

        public static List<Crop> GetAllCrops()
        {
            string query = "SELECT * FROM crop";
            List<Crop> crops = new List<Crop>();

            try
            {
                DataTable dt = DatabaseHelper.Instance.GetData(query);
                foreach (DataRow row in dt.Rows)
                {
                    Crop crop = new Crop();
                    crop.CropId = Convert.ToInt32(row["crop_id"]);
                    crop.CropName = row["crop_name"].ToString();
                    crop.Description = row["description"].ToString();

                    crops.Add(crop);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting all crops: " + ex.Message);
            }

            return crops;
        }

        public static Crop GetCropById(int cropId)
        {
            string query = "SELECT * FROM crop WHERE crop_id = @cropId";
            Crop crop = null;

            try
            {
                using (MySqlConnection conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cropId", cropId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                crop = new Crop();
                                crop.CropId = Convert.ToInt32(reader["crop_id"]);
                                crop.CropName = reader["crop_name"].ToString();
                                crop.Description = reader["description"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting crop by ID: " + ex.Message);
            }

            return crop;
        }
    }
}