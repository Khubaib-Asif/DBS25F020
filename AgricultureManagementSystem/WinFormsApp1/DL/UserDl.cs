using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace AgricultureManagementSystem
{
    public class UserDl
    {
        public List<Users> GetUsers()
        {
            List<Users> users = new List<Users>();
            string query = "SELECT * FROM users";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Users user = new Users(
                        Convert.ToInt32(row["user_id"]),
                        row["username"].ToString(),
                        row["hashed_password"].ToString(),
                        row["email"].ToString(),
                        row["role"].ToString()
                    );
                    users.Add(user);
                }
            }
            return users;
        }
        public Users AuthenticateUser(string email, string password)
        {
            try
            {
                string query = "SELECT * FROM users WHERE email = @Email AND hashed_password = @Password LIMIT 1";

                using (var conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password); // consider hashing in real applications

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["user_id"]);
                                string username = reader["username"].ToString();
                                string role = reader["role"].ToString();
                                string pass = reader["hashed_password"].ToString();

                                return new Users(id, username, pass, email, role);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
            }

            return null;
        }

        public bool InsertUser(Users user)
        {
            try
            {
                using (var conn = DatabaseHelper.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO users (username, hashed_password, email, role) VALUES (@username, @password, @email, @role)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.UserName);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@role", user.Role);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting user: " + ex.Message);
                return false;
            }
        }
    }
}
