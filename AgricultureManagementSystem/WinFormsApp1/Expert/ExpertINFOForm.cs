using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AgricultureManagementSystem
{
    public partial class ExpertINFOForm : Form
    {
        private int userId;

        public ExpertINFOForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            btnSave.Click += btnSave_Click;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFname.Text.Trim();
            string lastName = txtLname.Text.Trim();
            string cnic = CNICmask.Text.Trim();
            string address = txtAdress.Text.Trim();
            string dob = Dob.Value.ToString("yyyy-MM-dd");
            string contact = Contactmask.Text.Trim();

            // Handle profile picture
            string profilePicPath = string.Empty;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(cnic) ||
                string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(dob) ||
                string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            ExpertProfile expert = new ExpertProfile
            {
                FirstName = firstName,
                LastName = lastName,
                CNIC = cnic,
                Address = address,
                DOB = dob,
                Contact = contact
            };

            if (expert.Save()) // Using the Save method from ExpertProfile class
            {
                // Get the newly inserted expert with EID
                var insertedExpert = ExpertProfile.GetAll().FirstOrDefault(ep =>
                    ep.FirstName == firstName &&
                    ep.LastName == lastName &&
                    ep.CNIC == cnic);

                if (insertedExpert != null)
                {
                    MessageBox.Show("Expert profile saved successfully.");
                    EducationForm eduForm = new EducationForm(insertedExpert.EID);
                    eduForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Profile saved but couldn't retrieve the ID.");
                }
            }
            else
            {
                MessageBox.Show("Failed to save expert profile.");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}