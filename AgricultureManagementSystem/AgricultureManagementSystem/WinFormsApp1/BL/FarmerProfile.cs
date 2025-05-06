using System;
using System.Collections.Generic;
using AgricultureManagementSystem.DL;

namespace AgricultureManagementSystem.BL
{
    public class FarmerProfile : Profile
    {
        private int _farmerId;
        private string _profilePic;
        private DateTime _dob;

        // Additional getter setters
        public int FarmerId
        {
            get { return _farmerId; }
            set { _farmerId = value; }
        }

        public string ProfilePic
        {
            get { return _profilePic; }
            set { _profilePic = value; }
        }

        public DateTime Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }

        // Implement abstract methods 
        public override bool Save()
        {
            FarmerProfileDl dl = new FarmerProfileDl();
            return dl.InsertFarmerProfile(this);
        }

        public override bool Update()
        {
            FarmerProfileDl dl = new FarmerProfileDl();
            return dl.UpdateFarmerProfile(this);
        }

        public override bool Delete()
        {
            FarmerProfileDl dl = new FarmerProfileDl();
            return dl.DeleteFarmerProfile(this.FarmerId);
        }

        // Static methods for retrieval
        public static List<FarmerProfile> GetAll()
        {
            FarmerProfileDl dl = new FarmerProfileDl();
            return dl.GetAllFarmerProfiles();
        }

        public static FarmerProfile GetById(int id)
        {
            FarmerProfileDl dl = new FarmerProfileDl();
            return dl.GetFarmerProfileById(id);
        }

        public static FarmerProfile GetByCnic(string cnic)
        {
            FarmerProfileDl dl = new FarmerProfileDl();
            return dl.GetFarmerProfileByCnic(cnic);
        }

        public static FarmerProfile GetByEmail(string email)
        {
            FarmerProfileDl dl = new FarmerProfileDl();
            return dl.GetFarmerProfileByEmail(email);
        }
    }
}