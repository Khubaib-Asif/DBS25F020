using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
namespace AgricultureManagementSystem
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            cbShowpassword.CheckedChanged += new EventHandler(this.cbShowpassword_CheckedChanged);
            btnForgot.Click += btnForgotPassword_Click;
            btnRegister.Click += btnRegistered_Click;
        }
        private void cbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbShowpassword.Checked;
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotForm forgotPasswordForm = new ForgotForm();
            forgotPasswordForm.Show();
            this.Hide(); // Hide login form temporarily
        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    string email = txtEmail.Text;
        //    string password = txtPassword.Text;

        //    User loggedInUser = User.AuthenticateUser(email, password);

        //    if (loggedInUser != null)
        //    {
        //        this.Hide();

        //        if (loggedInUser.Role_id == 1)
        //        {
        //            DashboardStaff dashboardStaff = new DashboardStaff(loggedInUser.Email, loggedInUser.User_id);
        //            dashboardStaff.Show();
        //        }
        //        else if (loggedInUser.Role_id == 3)
        //        {
        //            DashboardForm dashboardForm = new DashboardForm(loggedInUser.Email, loggedInUser.User_id);
        //            dashboardForm.Show();
        //        }
        //        else if (loggedInUser.Role_id == 2)
        //        {
        //            DashboardFaculty dashboardFaculty = new DashboardFaculty(loggedInUser.Email, loggedInUser.User_id);
        //            dashboardFaculty.Show();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid email or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistered_Click(object sender, EventArgs e)
        {
            SignUpForm signupForm = new SignUpForm();
            signupForm.FormClosed += (s, args) => this.Close();
            signupForm.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            Users loggedInUser = Users.Login(email, password);

            if (loggedInUser != null)
            {
                MessageBox.Show($"Login successful. Welcome, {loggedInUser.Role}!");
                if (loggedInUser.Role == "Farmer")
                {

                }
                else if (loggedInUser.Role == "admin")
                {
                }


            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}
