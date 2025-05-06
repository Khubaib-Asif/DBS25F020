using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using AgricultureManagementSystem.BL;

namespace AgricultureManagementSystem.DL
{
    public class FarmerProfileDl
    {
        public bool InsertFarmerProfile(FarmerProfile farmer)
        {
            string query = @"INSERT INTO farmerprofile 
                          (first_name, last_name, cnic, profile_pic, address, contact, email, dob) 
                          VALUES 
                          (@firstName, @lastName, @cnic, @profilePic, @address, @contact, @email, @dob)";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", farmer.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", farmer.LastName);
                    cmd.Parameters.AddWithValue("@cnic", farmer.CNIC);
                    cmd.Parameters.AddWithValue("@profilePic", farmer.ProfilePic);
                    cmd.Parameters.AddWithValue("@address", farmer.Address);
                    cmd.Parameters.AddWithValue("@contact", farmer.Contact);
                    cmd.Parameters.AddWithValue("@email", farmer.Email);
                    cmd.Parameters.AddWithValue("@dob", farmer.Dob);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<FarmerProfile> GetAllFarmerProfiles()
        {
            List<FarmerProfile> farmers = new List<FarmerProfile>();
            string query = "SELECT * FROM farmerprofile";

            DataTable dt = DatabaseHelper.Instance.GetData(query);
            foreach (DataRow row in dt.Rows)
            {
                farmers.Add(new FarmerProfile
                {
                    FarmerId = Convert.ToInt32(row["farmer_id"]),
                    FirstName = row["first_name"].ToString(),
                    LastName = row["last_name"].ToString(),
                    CNIC = row["cnic"].ToString(),
                    ProfilePic = row["profile_pic"].ToString(),
                    Address = row["address"].ToString(),
                    Contact = row["contact"].ToString(),
                    Email = row["email"].ToString(),
                    Dob = Convert.ToDateTime(row["dob"])
                });
            }

            return farmers;
        }

        public bool UpdateFarmerProfile(FarmerProfile farmer)
        {
            string query = @"UPDATE farmerprofile 
                          SET first_name = @firstName, 
                              last_name = @lastName, 
                              cnic = @cnic,
                              profile_pic = @profilePic,
                              address = @address,
                              contact = @contact,
                              email = @email,
                              dob = @dob
                          WHERE farmer_id = @farmerId";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", farmer.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", farmer.LastName);
                    cmd.Parameters.AddWithValue("@cnic", farmer.CNIC);
                    cmd.Parameters.AddWithValue("@profilePic", farmer.ProfilePic);
                    cmd.Parameters.AddWithValue("@address", farmer.Address);
                    cmd.Parameters.AddWithValue("@contact", farmer.Contact);
                    cmd.Parameters.AddWithValue("@email", farmer.Email);
                    cmd.Parameters.AddWithValue("@dob", farmer.Dob);
                    cmd.Parameters.AddWithValue("@farmerId", farmer.FarmerId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteFarmerProfile(int farmerId)
        {
            string query = "DELETE FROM farmerprofile WHERE farmer_id = @farmerId";

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

        public FarmerProfile GetFarmerProfileById(int id)
        {
            string query = "SELECT * FROM farmerprofile WHERE farmer_id = @farmerId";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@farmerId", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new FarmerProfile
                            {
                                FarmerId = Convert.ToInt32(reader["farmer_id"]),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                CNIC = reader["cnic"].ToString(),
                                ProfilePic = reader["profile_pic"].ToString(),
                                Address = reader["address"].ToString(),
                                Contact = reader["contact"].ToString(),
                                Email = reader["email"].ToString(),
                                Dob = Convert.ToDateTime(reader["dob"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public FarmerProfile GetFarmerProfileByCnic(string cnic)
        {
            string query = "SELECT * FROM farmerprofile WHERE cnic = @cnic";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cnic", cnic);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new FarmerProfile
                            {
                                FarmerId = Convert.ToInt32(reader["farmer_id"]),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                CNIC = reader["cnic"].ToString(),
                                ProfilePic = reader["profile_pic"].ToString(),
                                Address = reader["address"].ToString(),
                                Contact = reader["contact"].ToString(),
                                Email = reader["email"].ToString(),
                                Dob = Convert.ToDateTime(reader["dob"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public FarmerProfile GetFarmerProfileByEmail(string email)
        {
            string query = "SELECT * FROM farmerprofile WHERE email = @email";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new FarmerProfile
                            {
                                FarmerId = Convert.ToInt32(reader["farmer_id"]),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                CNIC = reader["cnic"].ToString(),
                                ProfilePic = reader["profile_pic"].ToString(),
                                Address = reader["address"].ToString(),
                                Contact = reader["contact"].ToString(),
                                Email = reader["email"].ToString(),
                                Dob = Convert.ToDateTime(reader["dob"])
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}