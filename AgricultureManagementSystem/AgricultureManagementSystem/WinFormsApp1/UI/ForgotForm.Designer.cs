namespace AgricultureManagementSystem
{
    partial class ForgotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnVerifyEmail = new Button();
            btnResetPassword = new Button();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 29);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(857, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 1167);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 1167);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnVerifyEmail);
            panel3.Controls.Add(btnResetPassword);
            panel3.Controls.Add(txtNewPassword);
            panel3.Controls.Add(lblNewPassword);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(67, 102);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(727, 900);
            panel3.TabIndex = 4;
            // 
            // btnVerifyEmail
            // 
            btnVerifyEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVerifyEmail.BackColor = Color.FromArgb(23, 24, 29);
            btnVerifyEmail.FlatStyle = FlatStyle.Flat;
            btnVerifyEmail.Font = new Font("Segoe UI Semibold", 13.75F, FontStyle.Bold);
            btnVerifyEmail.ForeColor = Color.White;
            btnVerifyEmail.Location = new Point(261, 365);
            btnVerifyEmail.Margin = new Padding(4, 5, 4, 5);
            btnVerifyEmail.Name = "btnVerifyEmail";
            btnVerifyEmail.Size = new Size(157, 67);
            btnVerifyEmail.TabIndex = 7;
            btnVerifyEmail.Text = "Verify";
            btnVerifyEmail.UseVisualStyleBackColor = false;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnResetPassword.BackColor = Color.FromArgb(23, 24, 29);
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(259, 630);
            btnResetPassword.Margin = new Padding(4, 5, 4, 5);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(143, 67);
            btnResetPassword.TabIndex = 5;
            btnResetPassword.Text = "Reset";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Visible = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNewPassword.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtNewPassword.ForeColor = SystemColors.InfoText;
            txtNewPassword.Location = new Point(156, 517);
            txtNewPassword.Margin = new Padding(4, 5, 4, 5);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(374, 40);
            txtNewPassword.TabIndex = 4;
            txtNewPassword.Visible = false;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(156, 460);
            lblNewPassword.Margin = new Padding(4, 0, 4, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(115, 32);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "Password";
            lblNewPassword.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.InfoText;
            txtEmail.Location = new Point(159, 288);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(374, 40);
            txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(159, 232);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 32);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 24, 29);
            label4.Location = new Point(157, 88);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(402, 71);
            label4.TabIndex = 0;
            label4.Text = "Reset Password";
            // 
            // ForgotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1714, 1167);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ForgotForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Button btnVerifyEmail;
        private Button btnResetPassword;
        private TextBox txtNewPassword;
        private Label lblNewPassword;
        private TextBox txtEmail;
        private Label label5;
        private Label label4;
    }
}