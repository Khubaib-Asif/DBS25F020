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
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
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
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(600, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 700);
            panel1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 315);
            label7.Name = "label7";
            label7.Padding = new Padding(24, 0, 24, 0);
            label7.Size = new Size(623, 76);
            label7.TabIndex = 4;
            label7.Text = resources.GetString("label7.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 210);
            label2.Name = "label2";
            label2.Padding = new Padding(24, 0, 24, 0);
            label2.Size = new Size(625, 90);
            label2.TabIndex = 1;
            label2.Text = "Streamline Faculty Workload, Simplify \r\nResource Allocation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(426, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 50);
            label1.TabIndex = 0;
            label1.Text = "EduTrack";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 700);
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
            panel3.Location = new Point(47, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(509, 540);
            panel3.TabIndex = 4;
            // 
            // btnVerifyEmail
            // 
            btnVerifyEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVerifyEmail.BackColor = Color.FromArgb(23, 24, 29);
            btnVerifyEmail.FlatStyle = FlatStyle.Flat;
            btnVerifyEmail.Font = new Font("Segoe UI Semibold", 13.75F, FontStyle.Bold);
            btnVerifyEmail.ForeColor = Color.White;
            btnVerifyEmail.Location = new Point(183, 219);
            btnVerifyEmail.Name = "btnVerifyEmail";
            btnVerifyEmail.Size = new Size(110, 40);
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
            btnResetPassword.Location = new Point(181, 378);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(100, 40);
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
            txtNewPassword.Location = new Point(109, 310);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(263, 29);
            txtNewPassword.TabIndex = 4;
            txtNewPassword.Visible = false;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(109, 276);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(79, 21);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "Password";
            lblNewPassword.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.InfoText;
            txtEmail.Location = new Point(111, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 29);
            txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(111, 139);
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
            label4.Location = new Point(110, 53);
            label4.Name = "label4";
            label4.Size = new Size(265, 47);
            label4.TabIndex = 0;
            label4.Text = "Reset Password";
            // 
            // ForgotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ForgotForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
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