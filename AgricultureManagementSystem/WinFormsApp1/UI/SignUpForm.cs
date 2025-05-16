using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgricultureManagementSystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            cbShowpassword.CheckedChanged += CbShowpassword_CheckedChanged;
            this.Size = new Size(1360, 860); // Set your desired default size
            this.StartPosition = FormStartPosition.CenterScreen; // Optional: center


            btnlogin.Click += btnLogin_Click;
        }

        private void CbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbShowpassword.Checked;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginPasswordForm = new LoginForm();
            loginPasswordForm.StartPosition = FormStartPosition.Manual;
            loginPasswordForm.Location = this.Location;
            loginPasswordForm.Show();
            this.Hide();
        }


        private void btnSignUP_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
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
                MessageBox.Show("Now please Fill All information related to you");
                InfoForm info=new InfoForm(role,email);
                info.Show();
                this.Hide();
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            LoginForm loginPasswordForm = new LoginForm();
            loginPasswordForm.StartPosition = FormStartPosition.WindowsDefaultLocation;
            loginPasswordForm.Location = this.Location;
            loginPasswordForm.Show();
            this.Hide();
        }
    }
}
