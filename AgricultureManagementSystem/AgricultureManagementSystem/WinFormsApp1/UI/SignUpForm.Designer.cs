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
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1406, 1018);
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
            panel2.Location = new Point(364, 68);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 900);
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
            btnlogin.Location = new Point(180, 815);
            btnlogin.Margin = new Padding(4, 5, 4, 5);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(367, 67);
            btnlogin.TabIndex = 31;
            btnlogin.Text = "Already have an account? Login here.";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(123, 590);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(92, 32);
            lblRole.TabIndex = 30;
            lblRole.Text = "Role ID";
            // 
            // cmbRoleID
            // 
            cmbRoleID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbRoleID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleID.FormattingEnabled = true;
            cmbRoleID.Items.AddRange(new object[] { "Farmer", "Expert" });
            cmbRoleID.Location = new Point(123, 648);
            cmbRoleID.Margin = new Padding(4, 5, 4, 5);
            cmbRoleID.Name = "cmbRoleID";
            cmbRoleID.Size = new Size(270, 33);
            cmbRoleID.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(124, 360);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(477, 40);
            textBox1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(124, 443);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 32);
            label6.TabIndex = 3;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Microsoft Sans Serif", 14.25F);
            txtPassword.ForeColor = SystemColors.InfoText;
            txtPassword.Location = new Point(124, 500);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(477, 40);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 303);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
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
            cbShowpassword.Location = new Point(474, 562);
            cbShowpassword.Margin = new Padding(4, 5, 4, 5);
            cbShowpassword.Name = "cbShowpassword";
            cbShowpassword.Size = new Size(152, 27);
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
            button1.Location = new Point(281, 733);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(136, 58);
            button1.TabIndex = 5;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.InfoText;
            txtEmail.Location = new Point(124, 232);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(477, 40);
            txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(124, 175);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 32);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGreen;
            label4.Font = new Font("Segoe UI Semibold", 24.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(23, 24, 29);
            label4.Location = new Point(121, 27);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(496, 66);
            label4.TabIndex = 0;
            label4.Text = "Welcome to AgriHub";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1406, 1018);
            Controls.Add(panel3);
            Margin = new Padding(4, 5, 4, 5);
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