using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgricultureManagementSystem.DL;

namespace AgricultureManagementSystem.BL
{
    public class Crop
    {
        private int _cropId;
        private string _cropName;
        private string _description;

        //  getters and setters
        public int CropId
        {
            get { return _cropId; }
            set { _cropId = value; }
        }

        public string CropName
        {
            get { return _cropName; }
            set
            {
                _cropName = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        // Business logic methods
        public bool Save()
        {
            CropDl dl = new CropDl();
            return dl.InsertCrop(this);
        }

        public bool Update()
        {
            CropDl dl = new CropDl();
            return dl.UpdateCrop(this);
        }

        public bool Delete()
        {
            CropDl dl = new CropDl();
            return dl.DeleteCrop(this.CropId);
        }

        // Static methods for retrieval
        public static List<Crop> GetAll()
        {
            CropDl dl = new CropDl();
            return dl.GetAllCrops();
        }

        public static Crop GetById(int id)
        {
            CropDl dl = new CropDl();
            return dl.GetCropById(id);
        }
    }
}
