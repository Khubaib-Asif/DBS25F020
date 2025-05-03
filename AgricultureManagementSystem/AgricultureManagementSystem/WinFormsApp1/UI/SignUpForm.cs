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
            //btnSignUp.Click += BtnSignUp_Click;
        }

        private void CbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbShowpassword.Checked;
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string username = textBox1.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRoleID.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Users newUser = new Users(username, password, email, role);
            bool success = newUser.Insert();

            if (success)
            {
                MessageBox.Show("User registered successfully.");
                // Optionally open login form
            }
        }
    }
}
