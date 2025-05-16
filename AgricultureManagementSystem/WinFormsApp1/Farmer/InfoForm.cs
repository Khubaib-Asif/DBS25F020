using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgricultureManagementSystem.BL;
namespace AgricultureManagementSystem
{
    public partial class InfoForm : Form
    {

        private string Acceptedrole;
        private string Email;

        public InfoForm(string Role,string email)
        {
            InitializeComponent();
            this.Acceptedrole = Role;
            this.Email = email;
            btnSave.Click += btnSave_Click;
            this.Size = new Size(1360, 860); // Set your desired default size
            this.StartPosition = FormStartPosition.CenterScreen; // Optional: center


        }

        private void Contactmask_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

           
        }



        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string firstName = txtFname.Text.Trim();
            string lastName = txtLname.Text.Trim();
            string cnic = CNICmask.Text.Trim();
            string address = txtage.Text.Trim();
            string dob = Dob.Value.ToString("yyyy-MM-dd");
            string contact = Contactmask.Text.Trim();
            string email = Email;

            validations validator = new validations();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(cnic) ||
                string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(dob) ||
                string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            if (!validator.cnicChecker(cnic))
            {
                MessageBox.Show("Invalid CNIC. It must be exactly 13 digits.");
                return;
            }

            if (!validator.phoneChecker(contact))
            {
                MessageBox.Show("Invalid phone number. It must start with '03' and be 11 digits long.");
                return;
            }

            if (Acceptedrole == "Farmer")
            {
                FarmerProfile profile = new FarmerProfile();
                profile.FirstName = firstName;
                profile.LastName = lastName;
                profile.Address = address;
                profile.Email = email;
                profile.CNIC = cnic;
                profile.Dob = dob;
                profile.contact = contact;

                bool success = profile.Save();
                if (success)
                {
                    MessageBox.Show("Thanks for registering! Redirecting to login page.");
                    LoginForm loginPasswordForm = new LoginForm();
                    loginPasswordForm.StartPosition = FormStartPosition.WindowsDefaultLocation;
                    loginPasswordForm.Location = this.Location;
                    loginPasswordForm.Show();
                    this.Hide();
                }
            }
            else if (Acceptedrole == "Expert")  // FIX: This should not be inside the Farmer block
            {
                ExpertProfile expertProfile = new ExpertProfile();
                expertProfile.FirstName = firstName;
                expertProfile.LastName = lastName;
                expertProfile.Address = address;
                expertProfile.Email = email;
                expertProfile.CNIC = cnic;
                expertProfile.DOB = dob;
                expertProfile.Contact = contact;

                bool s = expertProfile.Save();
                if (s)
                {
                    MessageBox.Show("Thanks for registering! Redirecting to login page.");
                    LoginForm loginPasswordForm = new LoginForm();
                    loginPasswordForm.StartPosition = FormStartPosition.WindowsDefaultLocation;
                    loginPasswordForm.Location = this.Location;
                    loginPasswordForm.Show();
                    this.Hide();
                }
            }

        }

    }
}