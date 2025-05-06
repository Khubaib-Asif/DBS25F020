namespace AgricultureManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            panel2 = new Panel();
            btnRegister = new Button();
            btnForgot = new Button();
            cbShowpassword = new CheckBox();
            button1 = new Button();
            txtPassword = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(984, 611);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(btnForgot);
            panel2.Controls.Add(cbShowpassword);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(255, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 540);
            panel2.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegister.BackColor = Color.White;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.White;
            btnRegister.FlatAppearance.MouseDownBackColor = Color.White;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnRegister.ForeColor = SystemColors.Highlight;
            btnRegister.Location = new Point(111, 458);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(257, 40);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Don't have an account? Register here.";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnForgot
            // 
            btnForgot.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnForgot.BackColor = Color.White;
            btnForgot.Cursor = Cursors.Hand;
            btnForgot.FlatAppearance.BorderColor = Color.White;
            btnForgot.FlatAppearance.MouseDownBackColor = Color.White;
            btnForgot.FlatAppearance.MouseOverBackColor = Color.White;
            btnForgot.FlatStyle = FlatStyle.Flat;
            btnForgot.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnForgot.ForeColor = SystemColors.Highlight;
            btnForgot.Location = new Point(95, 333);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(151, 40);
            btnForgot.TabIndex = 7;
            btnForgot.Text = "Forgot Password";
            btnForgot.UseVisualStyleBackColor = false;
            // 
            // cbShowpassword
            // 
            cbShowpassword.AutoSize = true;
            cbShowpassword.Cursor = Cursors.Hand;
            cbShowpassword.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowpassword.ForeColor = Color.DimGray;
            cbShowpassword.Location = new Point(267, 344);
            cbShowpassword.Name = "cbShowpassword";
            cbShowpassword.Size = new Size(107, 17);
            cbShowpassword.TabIndex = 6;
            cbShowpassword.Text = "Show Password";
            cbShowpassword.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.LightGray;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(23, 24, 29);
            button1.Location = new Point(191, 407);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 5;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtPassword.ForeColor = SystemColors.InfoText;
            txtPassword.Location = new Point(111, 296);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 29);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(111, 262);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 3;
            label6.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.InfoText;
            txtEmail.Location = new Point(111, 210);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 29);
            txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(111, 176);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 24, 29);
            label4.Location = new Point(95, 63);
            label4.Name = "label4";
            label4.Size = new Size(317, 47);
            label4.TabIndex = 0;
            label4.Text = "Sign In to AgriHub";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(984, 611);
            Controls.Add(panel3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel2;
        private Button btnForgot;
        private CheckBox cbShowpassword;
        private Button button1;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private Label label4;
        private Button btnRegister;
    }
}
