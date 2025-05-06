using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureManagementSystem.BL
{
    // Base class for all profile types
    public abstract class Profile
    {
        protected string _firstName;
        protected string _lastName;
        protected string _cnic;
        protected string _address;
        protected string _contact;
        protected string _email;

        // Common getters and setters
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string CNIC
        {
            get { return _cnic; }
            set { _cnic = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Abstract methods 
        public abstract bool Save();
        public abstract bool Update();
        public abstract bool Delete();
    }
}
