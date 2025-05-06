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
    public partial class InfoForm : Form
    {

        private int userId;

        public InfoForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            btnSave.Click += btnSave_Click;
        }

        private void Contactmask_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFname.Text.Trim();
            string lastName = txtLname.Text.Trim();
            string cnic = CNICmask.Text.Trim();
            string address = txtAddress.Text.Trim();
            string dob = Dob.Value.ToString("yyyy-MM-dd");
            string contact = Contactmask.Text.Trim();


            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(cnic) ||
                string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(dob) ||
                string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            FarmerProfile farmer = new FarmerProfile
            {
                FirstName = firstName,
                LastName = lastName,
                CNIC = cnic,
                Address = address,
                Dob = dob,  // Changed to match FarmerProfile property
                contact = contact  // Changed to match FarmerProfile property
            };

            if (farmer.Save())
            {
                var insertedFarmer = FarmerProfile.GetAll().FirstOrDefault(fp =>
                    fp.FirstName == firstName &&
                    fp.LastName == lastName &&
                    fp.CNIC == cnic);

                if (insertedFarmer != null)
                {
                    MessageBox.Show("Farmer profile saved successfully.");
                    // Correct way to create FarmerDashboard now:
                    FarmerDashboard dashboard = new FarmerDashboard(insertedFarmer.FarmerID);  // Changed to FarmerID
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Profile saved but couldn't retrieve the ID.");
                }
            }
            else
            {
                MessageBox.Show("Failed to save farmer profile.");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}