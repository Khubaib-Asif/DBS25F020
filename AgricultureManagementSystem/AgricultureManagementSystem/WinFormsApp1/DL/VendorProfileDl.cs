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
    public class VendorProfileDl
    {
        public bool InsertVendor(VendorProfile vendor)
        {
            string query = @"INSERT INTO vendor_profile 
                          ( first_name, last_name, address, cnic, contact_info) 
                          VALUES 
                          ( @firstName, @lastName, @address, @cnic, @contactInfo)";

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", vendor.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", vendor.LastName);
                    cmd.Parameters.AddWithValue("@address", vendor.Address);
                    cmd.Parameters.AddWithValue("@cnic", vendor.CNIC);
                    cmd.Parameters.AddWithValue("@contactInfo", vendor.ContactInfo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<VendorProfile> GetAllVendors()
        {
            List<VendorProfile> vendors = new List<VendorProfile>();
            string query = "SELECT * FROM vendor_profile";

            DataTable dt = DatabaseHelper.Instance.GetData(query);
            foreach (DataRow row in dt.Rows)
            {
                vendors.Add(MapRowToVendor(row));
            }

            return vendors;
        }

        public bool UpdateVendor(VendorProfile vendor)
        {
            string query = @"UPDATE vendor_profile SET 
                          first_name = @firstName, 
                          last_name = @lastName, 
                          address = @address, 
                          cnic = @cnic, 
                          contact_info = @contactInfo 
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
                    cmd.Parameters.AddWithValue("@contactInfo", vendor.ContactInfo);
                    cmd.Parameters.AddWithValue("@vendorId", vendor.VendorId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteVendor(int vendorId)
        {
            string query = "DELETE FROM vendor_profile WHERE vendor_id = @vendorId";
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

        public VendorProfile GetVendorById(int id)
        {
            string query = "SELECT * FROM vendor_profile WHERE vendor_id = @vendorId";
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
                                ContactInfo = reader["contact_info"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        

        private VendorProfile MapRowToVendor(DataRow row)
        {
            return new VendorProfile
            {
                VendorId = Convert.ToInt32(row["vendor_id"]),
                FirstName = row["first_name"].ToString(),
                LastName = row["last_name"].ToString(),
                Address = row["address"].ToString(),
                CNIC = row["cnic"].ToString(),
                ContactInfo = row["contact_info"].ToString()
            };
        }
    }
}