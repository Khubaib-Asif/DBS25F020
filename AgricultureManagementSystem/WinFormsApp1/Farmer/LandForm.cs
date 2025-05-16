using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgricultureManagementSystem.Farmer
{
    public partial class LandForm : Form
    {
        private int ID;
        FarmerProfile profile = new FarmerProfile();
        public LandForm(FarmerProfile farmer)
        {
            InitializeComponent();
            profile = farmer;
            LoadFarmerLands(profile.FarmerID);
            this.Size = new Size(1360, 860); // Set your desired default size
            this.StartPosition = FormStartPosition.CenterScreen; // Optional: center


        }

        private void LandForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadFarmerLands(int farmerId)
        {
            List<landbl> lands = landbl.GetByFarmerId(farmerId);


            var displayList = lands.Select(l => new
            {
                LandID = l.landblid,
                Location = l.location,
                Area = l.area,
                SoilType = l.soilType,
            }).ToList();

            grdlands.DataSource = displayList;
        }


        private void btnAddLand_Click(object sender, EventArgs e)
        {
            string location = txtAddress.Text.Trim();
            string area = txtarea.Text.Trim();
            string soil = txtsoil.SelectedItem?.ToString();
            int id = profile.FarmerID;
            float farea = float.Parse(area);
            if (id == 0)
            {
                MessageBox.Show("Validate Error ");
            }
            if (location == null || area == null || soil == null)
            {
                MessageBox.Show("PLease Fill All Fields ");
            }

            bool postivearea = landbl.areacehekr(farea);
            if (postivearea)
            {
                landbl bl = new landbl();
                bl.location = location;
                bl.area = farea;
                bl.soilType = soil;
                bl.farmerid = id;
                bl.Save();
                MessageBox.Show("saved successfully !");
                LoadFarmerLands(profile.FarmerID);

            }
            else
            {
                MessageBox.Show("Validate error");

            }

        }

        private void dataGridViewLands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Make sure the "LandID" column exists
                DataGridViewRow row = grdlands.Rows[e.RowIndex];
                string landID = row.Cells["LandID"].Value?.ToString(); // Handle possible null values

                if (int.TryParse(landID, out int selectedID))
                {
                    ID = selectedID;
                }
                else
                {
                    MessageBox.Show("Invalid Land ID selected.");
                }
            }
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnDeleteLand_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnAddLand_Click_1(object sender, EventArgs e)
        {

            string location = txtAddress.Text.Trim();
            string area = txtarea.Text.Trim();
            string soil = txtsoil.SelectedItem?.ToString();
            int id = profile.FarmerID;
            float farea = float.Parse(area);
            if (id == 0)
            {
                MessageBox.Show("Validate Error ");
            }
            if (location == null || area == null || soil == null)
            {
                MessageBox.Show("PLease Fill All Fields ");
            }

            bool postivearea = landbl.areacehekr(farea);
            if (postivearea)
            {
                landbl bl = new landbl();
                bl.location = location;
                bl.area = farea;
                bl.soilType = soil;
                bl.farmerid = id;
                bl.Save();
                MessageBox.Show("saved successfully !");
                LoadFarmerLands(profile.FarmerID);

            }
            else
            {
                MessageBox.Show("Validate error");

            }
        }


        private void txtsoil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            FarmerDashboard far = new FarmerDashboard(profile);
            far.Show();
            this.Hide();
        }


        private void btnDeleteLand_Click_2(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Please select a row to delete.");
            }
            else
            {
                landdl dl = new landdl();

                bool success = dl.DeleteLand(ID); // Ensure this returns a boolean
                if (success)
                {
                    MessageBox.Show("Land deleted successfully!");
                    LoadFarmerLands(profile.FarmerID); // Reload the data
                }
                else
                {
                    MessageBox.Show("Error deleting the land.");
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
