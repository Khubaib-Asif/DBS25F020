namespace AgricultureManagementSystem
{
    partial class SignUpForm
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
            panel3 = new Panel();
            panel2 = new Panel();
            btnlogin = new Button();
            lblRole = new Label();
            cmbRoleID = new ComboBox();
            textBox1 = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            cbShowpassword = new CheckBox();
            button1 = new Button();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGreen;
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(984, 611);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnlogin);
            panel2.Controls.Add(lblRole);
            panel2.Controls.Add(cmbRoleID);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cbShowpassword);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(255, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 540);
            panel2.TabIndex = 2;
            // 
            // btnlogin
            // 
            btnlogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnlogin.BackColor = Color.LightGreen;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatAppearance.BorderColor = Color.LightGreen;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnlogin.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnlogin.ForeColor = SystemColors.Highlight;
            btnlogin.Location = new Point(126, 489);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(257, 40);
            btnlogin.TabIndex = 31;
            btnlogin.Text = "Already have an account? Login here.";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(86, 354);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(63, 21);
            lblRole.TabIndex = 30;
            lblRole.Text = "Role ID";
            // 
            // cmbRoleID
            // 
            cmbRoleID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbRoleID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleID.FormattingEnabled = true;
            cmbRoleID.Items.AddRange(new object[] { "Farmer", "Agriculture Expert" });
            cmbRoleID.Location = new Point(86, 389);
            cmbRoleID.Name = "cmbRoleID";
            cmbRoleID.Size = new Size(190, 23);
            cmbRoleID.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(87, 216);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 29);
            textBox1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 266);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 3;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtPassword.ForeColor = SystemColors.InfoText;
            txtPassword.Location = new Point(87, 300);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(335, 29);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 182);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 7;
            label1.Text = "Username";
            // 
            // cbShowpassword
            // 
            cbShowpassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbShowpassword.AutoSize = true;
            cbShowpassword.Cursor = Cursors.Hand;
            cbShowpassword.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowpassword.ForeColor = Color.DimGray;
            cbShowpassword.Location = new Point(332, 337);
            cbShowpassword.Name = "cbShowpassword";
            cbShowpassword.Size = new Size(107, 17);
            cbShowpassword.TabIndex = 6;
            cbShowpassword.Text = "Show Password";
            cbShowpassword.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.LightGray;
            button1.FlatAppearance.BorderColor = Color.LightGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 13.75F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(197, 440);
            button1.Name = "button1";
            button1.Size = new Size(95, 35);
            button1.TabIndex = 5;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.InfoText;
            txtEmail.Location = new Point(87, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(335, 29);
            txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(87, 105);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGreen;
            label4.Font = new Font("Segoe UI Semibold", 24.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(23, 24, 29);
            label4.Location = new Point(85, 16);
            label4.Name = "label4";
            label4.Size = new Size(337, 45);
            label4.TabIndex = 0;
            label4.Text = "Welcome to AgriHub";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(984, 611);
            Controls.Add(panel3);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private CheckBox cbShowpassword;
        private Button button1;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
        private Label lblRole;
        private ComboBox cmbRoleID;
        private Button btnlogin;
    }
}