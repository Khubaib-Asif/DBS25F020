using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            btnlogin.Click += btnRegister_Click;
            cbShowpassword.CheckedChanged += new EventHandler(this.cbShowpassword_CheckedChanged);
        }
        private void cbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbShowpassword.Checked;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close(); 
            loginForm.Show();
            this.Hide();
        }
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string username = textBox1.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRoleID.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create user object
            SignUser newUser = new SignUser(email,username,password,role);
            newUser.SetEmail(email);
            newUser.SetUsername(username);
            newUser.SetPassword(password);
            newUser.SetRole(role);

            // Call Business Logic Layer
            //UserBL userBL = new UserBL();
            //bool isRegistered = userBL.RegisterUser(newUser);

            //if (isRegistered)
            //{
            //    MessageBox.Show("Sign up successful. Proceeding to info form...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    // Navigate to InfoForm
            //    InfoForm infoForm = new InfoForm(newUser);
            //    infoForm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
