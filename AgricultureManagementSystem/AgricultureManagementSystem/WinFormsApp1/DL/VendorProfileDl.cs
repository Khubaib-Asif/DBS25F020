using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using AgricultureManagementSystem.BL;

namespace AgricultureManagementSystem.DL
{
    public class VendorProfileDl
    {
        public bool InsertVendorProfile(VendorProfile vendor)
        {
            string query = @"INSERT INTO vendorprofile 
                          (first_name, last_name, address, cnic, contact_info) 
                          VALUES 
                          (@firstName, @lastName, @address, @cnic, @contact)";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", vendor.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", vendor.LastName);
                    cmd.Parameters.AddWithValue("@address", vendor.Address);
                    cmd.Parameters.AddWithValue("@cnic", vendor.CNIC);
                    cmd.Parameters.AddWithValue("@contact", vendor.Contact);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<VendorProfile> GetAllVendorProfiles()
        {
            List<VendorProfile> vendors = new List<VendorProfile>();
            string query = "SELECT * FROM vendorprofile";

            DataTable dt = DatabaseHelper.Instance.GetData(query);
            foreach (DataRow row in dt.Rows)
            {
                vendors.Add(new VendorProfile
                {
                    VendorId = Convert.ToInt32(row["vendor_id"]),
                    FirstName = row["first_name"].ToString(),
                    LastName = row["last_name"].ToString(),
                    Address = row["address"].ToString(),
                    CNIC = row["cnic"].ToString(),
                    Contact = row["contact_info"].ToString()
                });
            }

            return vendors;
        }

        public bool UpdateVendorProfile(VendorProfile vendor)
        {
            string query = @"UPDATE vendorprofile 
                          SET first_name = @firstName, 
                              last_name = @lastName, 
                              address = @address,
                              cnic = @cnic,
                              contact_info = @contact
                          WHERE vendor_id = @vendorId";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", vendor.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", vendor.LastName);
                    cmd.Parameters.AddWithValue("@address", vendor.Address);
                    cmd.Parameters.AddWithValue("@cnic", vendor.CNIC);
                    cmd.Parameters.AddWithValue("@contact", vendor.Contact);
                    cmd.Parameters.AddWithValue("@vendorId", vendor.VendorId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteVendorProfile(int vendorId)
        {
            string query = "DELETE FROM vendorprofile WHERE vendor_id = @vendorId";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@vendorId", vendorId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public VendorProfile GetVendorProfileById(int id)
        {
            string query = "SELECT * FROM vendorprofile WHERE vendor_id = @vendorId";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@vendorId", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new VendorProfile
                            {
                                VendorId = Convert.ToInt32(reader["vendor_id"]),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                Address = reader["address"].ToString(),
                                CNIC = reader["cnic"].ToString(),
                                Contact = reader["contact_info"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public VendorProfile GetVendorProfileByCnic(string cnic)
        {
            string query = "SELECT * FROM vendorprofile WHERE cnic = @cnic";

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
                            return new VendorProfile
                            {
                                VendorId = Convert.ToInt32(reader["vendor_id"]),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                Address = reader["address"].ToString(),
                                CNIC = reader["cnic"].ToString(),
                                Contact = reader["contact_info"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}