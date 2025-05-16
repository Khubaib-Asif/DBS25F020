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
    public partial class EquipmentForm : Form
    {
        FarmerProfile  farmer=new FarmerProfile();
        public EquipmentForm(FarmerProfile profile)
        {
            InitializeComponent();
            farmer=profile;

            this.Size = new Size(1360, 860); // Set your desired default size
            this.StartPosition = FormStartPosition.CenterScreen; // Optional: center


        }

        private void grdlands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelWeather_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
