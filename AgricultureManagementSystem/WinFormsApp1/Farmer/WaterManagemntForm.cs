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
    public partial class WaterManagemntForm : Form
    {
        FarmerProfile Farmerprofile=new FarmerProfile();
        public WaterManagemntForm(FarmerProfile profile)
        {
            InitializeComponent();
            Farmerprofile = profile;
            this.Size = new Size(1360, 860); // Set your desired default size
            this.StartPosition = FormStartPosition.CenterScreen; // Optional: center


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
