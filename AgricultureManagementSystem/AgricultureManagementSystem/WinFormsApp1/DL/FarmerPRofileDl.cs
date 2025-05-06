using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace AgricultureManagementSystem
{
    public class FarmerProfileDl
    {
        // CREATE
        public bool InsertFarmer(FarmerProfile farmer)
        {
            string query = @"INSERT INTO farmer_profile 
                            (first_name, last_name, cnic, profile_pic, address, contact, email, dob, age) 
                            VALUES 
                            (@firstName, @lastName, @cnic, @profilePic, @address, @contact, @email, @dob, @age)";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", farmer.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", farmer.LastName);
                    cmd.Parameters.AddWithValue("@cnic", farmer.CNIC);
                    cmd.Parameters.AddWithValue("@profilePic", farmer.profilepiclink);
                    cmd.Parameters.AddWithValue("@address", farmer.Address);
                    cmd.Parameters.AddWithValue("@contact", farmer.contact);
                    cmd.Parameters.AddWithValue("@email", farmer.Email);
                    cmd.Parameters.AddWithValue("@dob", farmer.Dob);
                    cmd.Parameters.AddWithValue("@age", farmer.age);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // READ
        public List<FarmerProfile> GetAllFarmers()
        {
            List<FarmerProfile> farmers = new List<FarmerProfile>();
            string query = "SELECT * FROM farmer_profile";

            DataTable dt = DatabaseHelper.Instance.GetData(query);
            foreach (DataRow row in dt.Rows)
            {
                farmers.Add(new FarmerProfile
                {
                    FarmerID = Convert.ToInt32(row["farmer_id"]),
                    FirstName = row["first_name"].ToString(),
                    LastName = row["last_name"].ToString(),
                    CNIC = row["cnic"].ToString(),
                    profilepiclink = row["profile_pic"].ToString(),
                    Address = row["address"].ToString(),
                    contact = row["contact"].ToString(),
                    Email = row["email"].ToString(),
                    Dob = Convert.ToDateTime(row["dob"]).ToString("yyyy-MM-dd"),
                    age = Convert.ToInt32(row["age"])
                });
            }
            return farmers;
        }

        // UPDATE
        public bool UpdateFarmer(FarmerProfile farmer)
        {
            string query = @"UPDATE farmer_profile SET 
                            first_name = @firstName, 
                            last_name = @lastName, 
                            cnic = @cnic, 
                            profile_pic = @profilePic, 
                            address = @address, 
                            contact = @contact, 
                            email = @email, 
                            dob = @dob, 
                            age = @age
                            WHERE farmer_id = @farmerId";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", farmer.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", farmer.LastName);
                    cmd.Parameters.AddWithValue("@cnic", farmer.CNIC);
                    cmd.Parameters.AddWithValue("@profilePic", farmer.profilepiclink);
                    cmd.Parameters.AddWithValue("@address", farmer.Address);
                    cmd.Parameters.AddWithValue("@contact", farmer.contact);
                    cmd.Parameters.AddWithValue("@email", farmer.Email);
                    cmd.Parameters.AddWithValue("@dob", farmer.Dob);
                    cmd.Parameters.AddWithValue("@age", farmer.age);
                    cmd.Parameters.AddWithValue("@farmerId", farmer.FarmerID);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // DELETE
        public bool DeleteFarmer(int farmerId)
        {
            string query = "DELETE FROM farmer_profile WHERE farmer_id = @farmerId";
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@farmerId", farmerId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // READ BY ID (Optional)
        public FarmerProfile GetFarmerById(int farmerId)
        {
            string query = "SELECT * FROM farmer_profile WHERE farmer_id = @farmerId";
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@farmerId", farmerId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new FarmerProfile
                            {
                                FarmerID = Convert.ToInt32(reader["farmer_id"]),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                CNIC = reader["cnic"].ToString(),
                                profilepiclink = reader["profile_pic"].ToString(),
                                Address = reader["address"].ToString(),
                                contact = reader["contact"].ToString(),
                                Email = reader["email"].ToString(),
                                Dob = Convert.ToDateTime(reader["dob"]).ToString("yyyy-MM-dd"),
                                age = Convert.ToInt32(reader["age"])
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
