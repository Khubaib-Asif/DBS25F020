using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using AgricultureManagementSystem.BL;

namespace AgricultureManagementSystem.DL
{
    public class ExpertProfileDl
    {
        public bool InsertExpertProfile(ExpertProfile expert)
        {
            string query = @"INSERT INTO expertprofile 
                          (first_name, last_name, profile_pic, cnic, email, address, dob, contact) 
                          VALUES 
                          (@firstName, @lastName, @profilePic, @cnic, @email, @address, @dob, @contact)";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", expert.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", expert.LastName);
                    cmd.Parameters.AddWithValue("@profilePic", expert.ProfilePic);
                    cmd.Parameters.AddWithValue("@cnic", expert.CNIC);
                    cmd.Parameters.AddWithValue("@email", expert.Email);
                    cmd.Parameters.AddWithValue("@address", expert.Address);
                    cmd.Parameters.AddWithValue("@dob", expert.Dob);
                    cmd.Parameters.AddWithValue("@contact", expert.Contact);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<ExpertProfile> GetAllExpertProfiles()
        {
            List<ExpertProfile> experts = new List<ExpertProfile>();
            string query = "SELECT * FROM expertprofile";

            DataTable dt = DatabaseHelper.Instance.GetData(query);
            foreach (DataRow row in dt.Rows)
            {
                experts.Add(new ExpertProfile
                {
                    ExpertId = Convert.ToInt32(row["e_id"]),
                    FirstName = row["first_name"].ToString(),
                    LastName = row["last_name"].ToString(),
                    ProfilePic = row["profile_pic"].ToString(),
                    CNIC = row["cnic"].ToString(),
                    Email = row["email"].ToString(),
                    Address = row["address"].ToString(),
                    Dob = Convert.ToDateTime(row["dob"]),
                    Contact = row["contact"].ToString()
                });
            }

            return experts;
        }

        public bool UpdateExpertProfile(ExpertProfile expert)
        {
            string query = @"UPDATE expertprofile 
                          SET first_name = @firstName, 
                              last_name = @lastName, 
                              profile_pic = @profilePic,
                              cnic = @cnic,
                              email = @email,
                              address = @address,
                              dob = @dob,
                              contact = @contact
                          WHERE e_id = @expertId";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", expert.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", expert.LastName);
                    cmd.Parameters.AddWithValue("@profilePic", expert.ProfilePic);
                    cmd.Parameters.AddWithValue("@cnic", expert.CNIC);
                    cmd.Parameters.AddWithValue("@email", expert.Email);
                    cmd.Parameters.AddWithValue("@address", expert.Address);
                    cmd.Parameters.AddWithValue("@dob", expert.Dob);
                    cmd.Parameters.AddWithValue("@contact", expert.Contact);
                    cmd.Parameters.AddWithValue("@expertId", expert.ExpertId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteExpertProfile(int expertId)
        {
            string query = "DELETE FROM expertprofile WHERE e_id = @expertId";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@expertId", expertId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public ExpertProfile GetExpertProfileById(int id)
        {
            string query = "SELECT * FROM expertprofile WHERE e_id = @expertId";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@expertId", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ExpertProfile
                            {
                                ExpertId = Convert.ToInt32(reader["e_id"]),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                ProfilePic = reader["profile_pic"].ToString(),
                                CNIC = reader["cnic"].ToString(),
                                Email = reader["email"].ToString(),
                                Address = reader["address"].ToString(),
                                Dob = Convert.ToDateTime(reader["dob"]),
                                Contact = reader["contact"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public ExpertProfile GetExpertProfileByCnic(string cnic)
        {
            string query = "SELECT * FROM expertprofile WHERE cnic = @cnic";

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
                            return new ExpertProfile
                            {
                                ExpertId = Convert.ToInt32(reader["e_id"]),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                ProfilePic = reader["profile_pic"].ToString(),
                                CNIC = reader["cnic"].ToString(),
                                Email = reader["email"].ToString(),
                                Address = reader["address"].ToString(),
                                Dob = Convert.ToDateTime(reader["dob"]),
                                Contact = reader["contact"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public ExpertProfile GetExpertProfileByEmail(string email)
        {
            string query = "SELECT * FROM expertprofile WHERE email = @email";

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
                            return new ExpertProfile
                            {
                                ExpertId = Convert.ToInt32(reader["e_id"]),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                ProfilePic = reader["profile_pic"].ToString(),
                                CNIC = reader["cnic"].ToString(),
                                Email = reader["email"].ToString(),
                                Address = reader["address"].ToString(),
                                Dob = Convert.ToDateTime(reader["dob"]),
                                Contact = reader["contact"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}