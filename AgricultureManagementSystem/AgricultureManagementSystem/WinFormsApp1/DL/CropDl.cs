using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgricultureManagementSystem.BL;
using MySql.Data.MySqlClient;

namespace AgricultureManagementSystem.DL
{
    public class CropDl
    {
        public bool InsertCrop(Crop crop)
        {
            string query = @"INSERT INTO crop 
                          (crop_name, description) 
                          VALUES 
                          (@cropName, @description)";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cropName", crop.CropName);
                    cmd.Parameters.AddWithValue("@description", crop.Description);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<Crop> GetAllCrops()
        {
            List<Crop> crops = new List<Crop>();
            string query = "SELECT * FROM crop";

            DataTable dt = DatabaseHelper.Instance.GetData(query);
            foreach (DataRow row in dt.Rows)
            {
                crops.Add(new Crop
                {
                    CropId = Convert.ToInt32(row["crop_id"]),
                    CropName = row["crop_name"].ToString(),
                    Description = row["description"].ToString()
                });
            }

            return crops;
        }

        public bool UpdateCrop(Crop crop)
        {
            string query = @"UPDATE crop SET 
                          crop_name = @cropName, 
                          description = @description 
                          WHERE crop_id = @cropId";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cropName", crop.CropName);
                    cmd.Parameters.AddWithValue("@description", crop.Description);
                    cmd.Parameters.AddWithValue("@cropId", crop.CropId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteCrop(int cropId)
        {
            string query = "DELETE FROM crop WHERE crop_id = @cropId";
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cropId", cropId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public Crop GetCropById(int id)
        {
            string query = "SELECT * FROM crop WHERE crop_id = @cropId";
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cropId", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Crop
                            {
                                CropId = Convert.ToInt32(reader["crop_id"]),
                                CropName = reader["crop_name"].ToString(),
                                Description = reader["description"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
