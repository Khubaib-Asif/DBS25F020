using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgricultureManagementSystem.DL;

namespace AgricultureManagementSystem.BL
{
    public class VendorProfile
    {
        private int _vendorId;
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _cnic;
        private string _contactInfo;
           
        // getters and setters
        public int VendorId
        {
            get { return _vendorId; }
            set { _vendorId = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }

        public string CNIC
        {
            get { return _cnic; }
            set
            {
                _cnic = value;
            }
        }

        public string ContactInfo
        {
            get { return _contactInfo; }
            set
            {
                _contactInfo = value;
            }
        }

        // Constructor
        public VendorProfile()
        {

        }

        public bool Save()
        {
            VendorProfileDl dl = new VendorProfileDl();
            return dl.InsertVendor(this);
        }

        public bool Update()
        {
            VendorProfileDl dl = new VendorProfileDl();
            return dl.UpdateVendor(this);
        }

        public bool Delete()
        {
            VendorProfileDl dl = new VendorProfileDl();
            return dl.DeleteVendor(this.VendorId);
        }

        // Static methods for retrieval
        public static List<VendorProfile> GetAll()
        {
            VendorProfileDl dl = new VendorProfileDl();
            return dl.GetAllVendors();
        }

        public static VendorProfile GetById(int id)
        {
            VendorProfileDl dl = new VendorProfileDl();
            return dl.GetVendorById(id);
        }
    }
}
