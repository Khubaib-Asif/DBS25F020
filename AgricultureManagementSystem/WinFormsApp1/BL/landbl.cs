using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AgricultureManagementSystem
{
    public class landbl
    {
        public int landblid { get; set; }
        public int farmerid { get; set; }
        public string location { get; set; }
        public float area { get; set; }
        public string soilType { get; set; }

        // === Constructors ===
        public landbl() { }

        public landbl(int landblid, int farmerid, string location, float area, string soilType)
        {
            this.landblid = landblid;
            this.farmerid = farmerid;
            this.location = location;
            this.area = area;
            this.soilType = soilType;
        }

        // === Business Logic Methods ===

        public bool Save()
        {
            landdl dl = new landdl();
            return dl.InsertLand(this);
        }

        public bool Update()
        {
            landdl dl = new landdl();
            return dl.UpdateLand(this);
        }

        public bool Delete()
        {
            landdl dl = new landdl();
            return dl.DeleteLand(this.landblid);
        }

        public static landbl GetById(int id)
        {
            landdl dl = new landdl();
            return dl.GetLandById(id);
        }

        public static List<landbl> GetByFarmerId(int farmerId)
        {
            landdl dl = new landdl();
            return dl.GetLandsByFarmerId(farmerId);
        }
        public static bool areacehekr(float areai)
        {
            if(areai<=0)
            {
                return false;
            }
            return true;
        }
    }
}
