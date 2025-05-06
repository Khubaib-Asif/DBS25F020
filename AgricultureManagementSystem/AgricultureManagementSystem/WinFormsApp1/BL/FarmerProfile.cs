using System;
using System.Collections.Generic;

namespace AgricultureManagementSystem
{
    public class FarmerProfile
    {
        public int FarmerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CNIC { get; set; }
        public string profilepiclink { get; set; }
        public string Address { get; set; }
        public string contact { get; set; }
        public string Email { get; set; }
        public string Dob { get; set; }  // You may convert to DateTime if needed
        public int age { get; set; }

        // === Business Logic Layer ===

        public bool Save()
        {
            FarmerProfileDl dl = new FarmerProfileDl();
            return dl.InsertFarmer(this);
        }

        public bool Update()
        {
            FarmerProfileDl dl = new FarmerProfileDl();
            return dl.UpdateFarmer(this);
        }

        public bool Delete()
        {
            FarmerProfileDl dl = new FarmerProfileDl();
            return dl.DeleteFarmer(this.FarmerID);
        }

        public static List<FarmerProfile> GetAll()
        {
            FarmerProfileDl dl = new FarmerProfileDl();
            return dl.GetAllFarmers();
        }

        public static FarmerProfile GetById(int id)
        {
            FarmerProfileDl dl = new FarmerProfileDl();
            return dl.GetFarmerById(id);
        }
    }
}
