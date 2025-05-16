using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureManagementSystem.BL
{
    public class validations
    {
        public bool cnicChecker(string cnic)
        {

            return cnic.Length == 13 && cnic.All(char.IsDigit);
        }
        public bool phoneChecker(string phone)
        {
            return phone.Length == 11 && phone.StartsWith("03") && phone.All(char.IsDigit);
        }

    }


        
}

