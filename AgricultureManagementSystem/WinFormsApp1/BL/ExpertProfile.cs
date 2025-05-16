using System;
using System.Collections.Generic;

namespace AgricultureManagementSystem
{
    public class ExpertProfile
    {
        public int EID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
      
        public string CNIC { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; } // string for simplicity
        public string Contact { get; set; }

        // Save (Insert)
        public bool Save()
        {
            ExpertProfileDl dl = new ExpertProfileDl();
            return dl.InsertExpert(this);
        }

        // Update
        public bool Update()
        {
            ExpertProfileDl dl = new ExpertProfileDl();
            return dl.UpdateExpert(this);
        }

        // Delete
       
        public bool Delete()
        {
            ExpertProfileDl dl = new ExpertProfileDl();
            return dl.DeleteExpert(this.EID);
        }

        // Static methods for retrieval
        public static List<ExpertProfile> GetAll()
        {
            ExpertProfileDl dl = new ExpertProfileDl();
            return dl.GetAllExperts();
        }

        public static ExpertProfile GetById(int id)
        {
            ExpertProfileDl dl = new ExpertProfileDl();
            return dl.GetExpertById(id);
        }
    }
}
