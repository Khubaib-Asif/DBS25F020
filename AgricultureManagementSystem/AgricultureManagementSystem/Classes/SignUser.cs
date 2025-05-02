using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureManagementSystem
{
    public class SignUser
    {
        private string email;
        private string username;
        private string password;
        private string role;
        public SignUser(string email, string username, string password, string role)
        {
            this.email = email;
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetUsername()
        {
            return username;
        }

        public void SetUsername(string username)
        {
            this.username = username;
        }
        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }
        public string GetRole()
        {
            return role;
        }

        public void SetRole(string role)
        {
            this.role = role;
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(email) &&
                   !string.IsNullOrWhiteSpace(username) &&
                   !string.IsNullOrWhiteSpace(password) &&
                   !string.IsNullOrWhiteSpace(role);
        }
    }
}
