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
            btnpic.Click += button1_Click;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select Profile Picture";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the image to verify it's valid
                    Image img = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = img;

                    // Optionally store the original path if needed
                    // txtProfilePic.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
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


        string profilePicPath = string.Empty;
             if (pictureBox1.Image != null)
             {
    
                 string profilePicsDir = Path.Combine(Application.StartupPath, "ProfilePictures");
                 if (!Directory.Exists(profilePicsDir))
                 {
                     Directory.CreateDirectory(profilePicsDir);
                 }

          
                 string fileName = $"{Guid.NewGuid()}.jpg";
                 profilePicPath = Path.Combine(profilePicsDir, fileName);

                 pictureBox1.Image.Save(profilePicPath, System.Drawing.Imaging.ImageFormat.Jpeg);

                 profilePicPath = $"ProfilePictures/{fileName}";
             }

             if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                 string.IsNullOrWhiteSpace(cnic) ||
                 string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(dob) ||
                 string.IsNullOrWhiteSpace(contact))
             {
                 MessageBox.Show("Please fill all required fields.");
                 return;
             }

             FarmerProfile farmer= new FarmerProfile
             {
                 FirstName = firstName,
                 LastName = lastName,
                 CNIC = cnic,
               //  ProfilePic = profilePicPath,
                 Address = address,
                 //DOB = dob,
                 //Contact = contact
             };

             if (farmer.Save())
            {
                 var insertedExpert = FarmerProfile.GetAll().FirstOrDefault(ep =>
                     ep.FirstName == firstName &&
                     ep.LastName == lastName &&
                     ep.CNIC == cnic);

                 if (insertedExpert != null)
                 {
                     MessageBox.Show("Expert profile saved successfully.");
                    // FarmerDashboard eduForm = new FarmerDashboard(insertedFarmer.EID);
                     //eduForm.Show();
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
    }
}