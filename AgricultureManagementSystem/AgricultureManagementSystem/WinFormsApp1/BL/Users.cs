using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgricultureManagementSystem
{
    public class Users
    {
        public int UserId;
        public string UserName;
        public string Password;
        public string Email;
        public string Role;

        public Users(string username, string password, string email, string role)
        {
            this.UserName = username;
            this.Password = password;
            this.Email = email;
            this.Role = role;
        }

        public Users(int userId, string username, string password, string email, string role)
        {
            this.UserId = userId;
            this.UserName = username;
            this.Password = password;
            this.Email = email;
            this.Role = role;
        }
        public bool IsStrongPassword()
        {
            if (Password.Length < 8)
                return false;

            bool hasUpper = false, hasLower = false, hasDigit = false, hasSpecial = false;

            foreach (char c in Password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c)) hasLower = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if (!char.IsLetterOrDigit(c)) hasSpecial = true;
            }

            return hasUpper && hasLower && hasDigit && hasSpecial;
        }

        public bool IsValidEmail()
        {
            return Email.Contains("@") && Email.Contains(".") && Email.IndexOf("@") < Email.LastIndexOf(".");
        }

        public bool IsUniqueUsername()
        {
            UserDl userDl = new UserDl();
            var users = userDl.GetUsers();
            foreach (var user in users)
            {
                if (user.UserName.Equals(this.UserName, StringComparison.OrdinalIgnoreCase))
                    return false;
            }
            return true;
        }

        public bool IsUniqueEmail()
        {
            UserDl userDl = new UserDl();
            var users = userDl.GetUsers();
            foreach (var user in users)
            {
                if (user.Email.Equals(this.Email, StringComparison.OrdinalIgnoreCase))
                    return false;
            }
            return true;
        }

        public bool Insert()
        {
            if (!IsValidEmail())
            {
                MessageBox.Show("Invalid email format.");
                return false;
            }

            if (!IsStrongPassword())
            {
                MessageBox.Show("Password must be at least 8 characters and include upper/lowercase letters, a digit, and a special character.");
                return false;
            }

            if (!IsUniqueUsername())
            {
                MessageBox.Show("Username already exists.");
                return false;
            }

            if (!IsUniqueEmail())
            {
                MessageBox.Show("Email already registered.");
                return false;
            }

            UserDl userDl = new UserDl();
            return userDl.InsertUser(this);
        }
        public static Users Login(string email, string password)
        {
            UserDl userDl = new UserDl();
            return userDl.AuthenticateUser(email, password);
        }

    }
}
