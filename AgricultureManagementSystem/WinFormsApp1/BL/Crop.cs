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
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Crop name cannot be empty");
                _cropName = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public bool Save()
        {
            return CropDL.InsertCrop(this);
        }

        public bool Update()
        {
            return CropDL.UpdateCrop(this);
        }

        public bool Delete()
        {
            return CropDL.DeleteCrop(this.CropId);
        }

        public static List<Crop> GetAllCrops()
        {
            return CropDL.GetAllCrops();
        }

        public static Crop GetById(int cropId)
        {
            return CropDL.GetCropById(cropId);
        }
    }
}
