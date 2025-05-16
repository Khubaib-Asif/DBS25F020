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
    public partial class ReportForm : Form
    { 
        FarmerProfile profile=new FarmerProfile();
        public ReportForm(FarmerProfile famer)
        {
            InitializeComponent();
            profile = famer;
            this.Size = new Size(1360, 860); // Set your desired default size
            this.StartPosition = FormStartPosition.CenterScreen; // Optional: center


        }

        private void txtarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabsuggestion_Click(object sender, EventArgs e)
        {

        }
    }
}
