using System;
using System.Windows.Forms;

namespace AgricultureManagementSystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            cbShowpassword.CheckedChanged += CbShowpassword_CheckedChanged;
            btnSignUP.Click += btnSignUp_Click;
            btnlogin.Click += btnLogin_Click;
        }

        private void CbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbShowpassword.Checked;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginPasswordForm = new LoginForm();
            loginPasswordForm.Show();
            this.Hide(); // Hide login form temporarily
        }
        private void BtnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string email = txtEmail.Text.Trim();
            string role = cmbRoleID.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Users user = new Users(username, password, email, role);
            // After successful user sign-up
            if (user.Role == "Expert")
            {
                ExpertINFOForm expertForm = new ExpertINFOForm(user.UserId);
                expertForm.Show();
            }
            else if (user.Role == "Farmer")
            {
                InfoForm farmerForm = new InfoForm(user.UserId);
                farmerForm.Show();
            }
            this.Hide(); // Hide sign-up form

            if (user.Insert())
            {
                MessageBox.Show("Account created successfully!");
                this.Close(); // or navigate to login formla
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
