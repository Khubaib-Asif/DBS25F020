using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace AgricultureManagementSystem
{
    public class DatabaseHelper
    {
        private readonly string connectionString =
            "server=127.0.0.1;port=3306;user=root;password=22138sma.;database=project_20;AllowPublicKeyRetrieval=True;SslMode=none;";

        private static DatabaseHelper _instance;

        private DatabaseHelper() { }

        public static DatabaseHelper Instance => _instance ??= new DatabaseHelper();

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            return dt;
        }
    }
}
