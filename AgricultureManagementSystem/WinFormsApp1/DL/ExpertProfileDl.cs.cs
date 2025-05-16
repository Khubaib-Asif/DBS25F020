using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace AgricultureManagementSystem
{
    public class ExpertProfileDl
    {
        public bool InsertExpert(ExpertProfile expert)
        {
            string query = @"INSERT INTO expert_profile 
                            (first_name, last_name, cnic, email, address, dob, contact) 
                            VALUES 
                            (@firstName, @lastName, @cnic, @email, @address, @dob, @contact)";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", expert.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", expert.LastName);
                    
                    cmd.Parameters.AddWithValue("@cnic", expert.CNIC);
                    cmd.Parameters.AddWithValue("@email", expert.Email);
                    cmd.Parameters.AddWithValue("@address", expert.Address);
                    cmd.Parameters.AddWithValue("@dob", expert.DOB);
                    cmd.Parameters.AddWithValue("@contact", expert.Contact);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<ExpertProfile> GetAllExperts()
        {
            List<ExpertProfile> experts = new List<ExpertProfile>();
            string query = "SELECT * FROM expert_profile";

            DataTable dt = DatabaseHelper.Instance.GetData(query);
            foreach (DataRow row in dt.Rows)
            {
                experts.Add(new ExpertProfile
                {
                    EID = Convert.ToInt32(row["e_id"]),
                    FirstName = row["first_name"].ToString(),
                    LastName = row["last_name"].ToString(),
                  
                    CNIC = row["cnic"].ToString(),
                    Email = row["email"].ToString(),
                    Address = row["address"].ToString(),
                    DOB = Convert.ToDateTime(row["dob"]).ToString("yyyy-MM-dd"),
                    Contact = row["contact"].ToString()
                });
            }

            return experts;
        }

        public bool UpdateExpert(ExpertProfile expert)
        {
            string query = @"UPDATE expert_profile SET 
                            first_name = @firstName, 
                            last_name = @lastName, 
                            profile_pic = @profilePic, 
                            cnic = @cnic, 
                            email = @email, 
                            address = @address, 
                            dob = @dob, 
                            contact = @contact 
                            WHERE e_id = @id";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", expert.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", expert.LastName);
                 
                    cmd.Parameters.AddWithValue("@cnic", expert.CNIC);
                    cmd.Parameters.AddWithValue("@email", expert.Email);
                    cmd.Parameters.AddWithValue("@address", expert.Address);
                    cmd.Parameters.AddWithValue("@dob", expert.DOB);
                    cmd.Parameters.AddWithValue("@contact", expert.Contact);
                    cmd.Parameters.AddWithValue("@id", expert.EID);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteExpert(int expertId)
        {
            string query = "DELETE FROM expert_profile WHERE e_id = @id";
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", expertId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public ExpertProfile GetExpertById(int id)
        {
            string query = "SELECT * FROM expert_profile WHERE e_id = @id";
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ExpertProfile
                            {
                                EID = Convert.ToInt32(reader["e_id"]),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                              
                                CNIC = reader["cnic"].ToString(),
                                Email = reader["email"].ToString(),
                                Address = reader["address"].ToString(),
                                DOB = Convert.ToDateTime(reader["dob"]).ToString("yyyy-MM-dd"),
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
