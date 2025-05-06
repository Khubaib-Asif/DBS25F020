using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgricultureManagementSystem.DL;

namespace AgricultureManagementSystem.BL
{
    public class VendorProfile : Profile
    {
        private int _vendorId;
        public int VendorId
        {
            get { return _vendorId; }
            set { _vendorId = value; }
        }

        // Implement abstract methods
        public override bool Save()
        {
            VendorProfileDl dl = new VendorProfileDl();
            return dl.InsertVendorProfile(this);
        }

        public override bool Update()
        {
            VendorProfileDl dl = new VendorProfileDl();
            return dl.UpdateVendorProfile(this);
        }

        public override bool Delete()
        {
            VendorProfileDl dl = new VendorProfileDl();
            return dl.DeleteVendorProfile(this.VendorId);
        }

        // Static methods for retrieval
        public static List<VendorProfile> GetAll()
        {
            VendorProfileDl dl = new VendorProfileDl();
            return dl.GetAllVendorProfiles();
        }

        public static VendorProfile GetById(int id)
        {
            VendorProfileDl dl = new VendorProfileDl();
            return dl.GetVendorProfileById(id);
        }

        public static VendorProfile GetByCnic(string cnic)
        {
            VendorProfileDl dl = new VendorProfileDl();
            return dl.GetVendorProfileByCnic(cnic);
        }
    }
}
