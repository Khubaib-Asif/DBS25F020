using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AgricultureManagementSystem
{
    public class landdl
    {
        private readonly DatabaseHelper dbHelper = DatabaseHelper.Instance;

        public bool InsertLand(landbl land)
        {
            using (var conn = dbHelper.GetConnection())
            {
                conn.Open();
                const string query = @"INSERT INTO land 
                                    (farmer_id, location, area, soil_type) 
                                    VALUES (@farmerId, @location, @area, @soilType)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@farmerId", land.farmerid);
                    cmd.Parameters.AddWithValue("@location", land.location);
                    cmd.Parameters.AddWithValue("@area", land.area);
                    cmd.Parameters.AddWithValue("@soilType", land.soilType);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateLand(landbl land)
        {
            using (var conn = dbHelper.GetConnection())
            {
                conn.Open();
                const string query = @"UPDATE land SET 
                                    location = @location,
                                    area = @area,
                                    soil_type = @soilType
                                    WHERE land_id = @landId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@location", land.location);
                    cmd.Parameters.AddWithValue("@area", land.area);
                    cmd.Parameters.AddWithValue("@soilType", land.soilType);
                    cmd.Parameters.AddWithValue("@landId", land.landblid);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteLand(int landId)
        {
            using (var conn = dbHelper.GetConnection())
            {
                conn.Open();
                const string query = "DELETE FROM land WHERE land_id = @landId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@landId", landId);
                    return cmd.ExecuteNonQuery() > 0; // Ensure this returns a boolean
                }
            }
        }


        public landbl GetLandById(int landId)
        {
            using (var conn = dbHelper.GetConnection())
            {
                conn.Open();
                const string query = "SELECT * FROM land WHERE land_id = @landId LIMIT 1";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@landId", landId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new landbl(
                                Convert.ToInt32(reader["land_id"]),
                                Convert.ToInt32(reader["farmer_id"]),
                                reader["location"].ToString(),
                                Convert.ToSingle(reader["area"]),
                                reader["soil_type"].ToString()
                            );
                        }
                    }
                }
            }
            return null;
        }

        public List<landbl> GetLandsByFarmerId(int farmerId)
        {
            var lands = new List<landbl>();
            using (var conn = dbHelper.GetConnection())
            {
                conn.Open();
                const string query = "SELECT * FROM land WHERE farmer_id = @farmerId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@farmerId", farmerId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lands.Add(new landbl(
                                Convert.ToInt32(reader["land_id"]),
                                Convert.ToInt32(reader["farmer_id"]),
                                reader["location"].ToString(),
                                Convert.ToSingle(reader["area"]),
                                reader["soil_type"].ToString()
                            ));
                        }
                    }
                }
            }
            return lands;
        }
    }
}
