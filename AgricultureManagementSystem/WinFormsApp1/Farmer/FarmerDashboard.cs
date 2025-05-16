using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgricultureManagementSystem.Farmer;
namespace AgricultureManagementSystem
{
    public partial class FarmerDashboard : Form
    {
        private FarmerProfile farmerProfile = new FarmerProfile();

        public FarmerDashboard(FarmerProfile farmer)
        {
            InitializeComponent();
            farmerProfile = farmer;
            this.Size = new Size(1360, 860); // Set your desired default size
            this.StartPosition = FormStartPosition.CenterScreen; // Optional: center


        }

        private void FarmerDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Name : {farmerProfile.FirstName} {farmerProfile.LastName}   CNIC: {farmerProfile.CNIC}";
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnMyLands_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMyLands_Click_1(object sender, EventArgs e)
        {
            LandForm form = new LandForm(farmerProfile);
            form.Show();
            this.Hide();
        }

        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            StockForm stock = new StockForm(farmerProfile);
            stock.Show();
            this.Hide();
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

        private void btnagriproducts_Click(object sender, EventArgs e)
        {
            AgriProductForm ag = new AgriProductForm(farmerProfile);
            ag.Show();
            this.Hide();
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportGenerater reportGenerater = new ReportGenerater(farmerProfile);
            reportGenerater.Show();
            this.Hide();

        }
    }
}
