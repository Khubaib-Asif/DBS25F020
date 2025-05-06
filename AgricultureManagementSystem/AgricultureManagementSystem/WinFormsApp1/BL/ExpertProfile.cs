using System;
using System.Collections.Generic;
using AgricultureManagementSystem.DL;

namespace AgricultureManagementSystem.BL
{
    public class ExpertProfile : Profile
    {
        private int _expertId;
        private string _profilePic;
        private DateTime _dob;

        
        public int ExpertId
        {
            get { return _expertId; }
            set { _expertId = value; }
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
            ExpertProfileDl dl = new ExpertProfileDl();
            return dl.InsertExpertProfile(this);
        }

        public override bool Update()
        {
            ExpertProfileDl dl = new ExpertProfileDl();
            return dl.UpdateExpertProfile(this);
        }

        public override bool Delete()
        {
            ExpertProfileDl dl = new ExpertProfileDl();
            return dl.DeleteExpertProfile(this.ExpertId);
        }

        // Static methods for retrieval
        public static List<ExpertProfile> GetAll()
        {
            ExpertProfileDl dl = new ExpertProfileDl();
            return dl.GetAllExpertProfiles();
        }

        public static ExpertProfile GetById(int id)
        {
            ExpertProfileDl dl = new ExpertProfileDl();
            return dl.GetExpertProfileById(id);
        }

        public static ExpertProfile GetByCnic(string cnic)
        {
            ExpertProfileDl dl = new ExpertProfileDl();
            return dl.GetExpertProfileByCnic(cnic);
        }

        public static ExpertProfile GetByEmail(string email)
        {
            ExpertProfileDl dl = new ExpertProfileDl();
            return dl.GetExpertProfileByEmail(email);
        }
    }
}