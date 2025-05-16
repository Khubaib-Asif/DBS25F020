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
    public partial class ExpertDashboardForm : Form
    {
        private ExpertProfile ExpertProfile=new ExpertProfile();
        public ExpertDashboardForm(ExpertProfile profile)
        {
            InitializeComponent();
            ExpertProfile = profile;
        }

        private void tabEditProfile_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
