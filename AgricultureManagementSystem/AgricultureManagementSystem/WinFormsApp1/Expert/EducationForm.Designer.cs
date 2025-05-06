namespace AgricultureManagementSystem
{
    partial class EducationForm
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
            panel2 = new Panel();
            button3 = new Button();
            textBox1 = new TextBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            numericUpDown3 = new NumericUpDown();
            label7 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnRegister = new Button();
            btnForgot = new Button();
            button1 = new Button();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(numericUpDown3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(btnForgot);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(-4, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(991, 667);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(390, 601);
            button3.Name = "button3";
            button3.Size = new Size(110, 39);
            button3.TabIndex = 46;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(195, 426);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(567, 80);
            textBox1.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(202, 392);
            label8.Name = "label8";
            label8.Size = new Size(94, 21);
            label8.TabIndex = 44;
            label8.Text = "Description";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            comboBox2.Location = new Point(561, 346);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 23);
            comboBox2.TabIndex = 18;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Location = new Point(195, 346);
            numericUpDown3.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(201, 23);
            numericUpDown3.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(195, 308);
            label7.Name = "label7";
            label7.Size = new Size(104, 21);
            label7.TabIndex = 16;
            label7.Text = "CGPA / SGPA";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(561, 257);
            numericUpDown2.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(201, 23);
            numericUpDown2.TabIndex = 15;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(195, 257);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(201, 23);
            numericUpDown1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(561, 218);
            label6.Name = "label6";
            label6.Size = new Size(93, 21);
            label6.TabIndex = 13;
            label6.Text = "Total Marks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(561, 308);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 12;
            label3.Text = "Passing Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(195, 218);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 11;
            label2.Text = "Obtained Marks";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 125);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 10;
            label1.Text = "Degree Type";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "HSC", "BSc", "MSc", "PhD", "Other" });
            comboBox1.Location = new Point(195, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegister.BackColor = Color.LightGreen;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.LightGreen;
            btnRegister.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnRegister.ForeColor = SystemColors.Highlight;
            btnRegister.Location = new Point(902, 1011);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(257, 40);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Don't have an account? Register here.";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnForgot
            // 
            btnForgot.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnForgot.BackColor = Color.LightGreen;
            btnForgot.Cursor = Cursors.Hand;
            btnForgot.FlatAppearance.BorderColor = Color.LightGreen;
            btnForgot.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnForgot.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            btnForgot.FlatStyle = FlatStyle.Flat;
            btnForgot.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnForgot.ForeColor = SystemColors.Highlight;
            btnForgot.Location = new Point(886, 900);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(151, 40);
            btnForgot.TabIndex = 7;
            btnForgot.Text = "Forgot Password";
            btnForgot.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.LightGray;
            button1.FlatAppearance.BorderColor = Color.LightGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(969, 950);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 5;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.InfoText;
            txtEmail.Location = new Point(561, 163);
            txtEmail.MaxLength = 11;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(201, 29);
            txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(561, 125);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 1;
            label5.Text = "Roll No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 24, 29);
            label4.Location = new Point(322, 32);
            label4.Name = "label4";
            label4.Size = new Size(401, 47);
            label4.TabIndex = 0;
            label4.Text = "Educational Information";
            label4.Click += label4_Click;
            // 
            // EducationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(panel2);
            Name = "EducationForm";
            Text = "EducationForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnRegister;
        private Button btnForgot;
        private Button button1;
        private TextBox txtEmail;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private NumericUpDown numericUpDown3;
        private Label label7;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label8;
        private Button button3;
    }
}