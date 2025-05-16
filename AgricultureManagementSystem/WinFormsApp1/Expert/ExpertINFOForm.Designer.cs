namespace AgricultureManagementSystem
{
    partial class ExpertINFOForm
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
            btnSave = new Button();
            txtAdress = new TextBox();
            label7 = new Label();
            label6 = new Label();
            Dob = new DateTimePicker();
            Contactmask = new MaskedTextBox();
            CNICmask = new MaskedTextBox();
            label2 = new Label();
            txtLname = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtFname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtAdress);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Dob);
            panel2.Controls.Add(Contactmask);
            panel2.Controls.Add(CNICmask);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtLname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtFname);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 611);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(402, 529);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 39);
            btnSave.TabIndex = 44;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtAdress
            // 
            txtAdress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAdress.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdress.ForeColor = SystemColors.InfoText;
            txtAdress.Location = new Point(240, 295);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.ScrollBars = ScrollBars.Vertical;
            txtAdress.Size = new Size(518, 80);
            txtAdress.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(247, 261);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 42;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(247, 387);
            label6.Name = "label6";
            label6.Size = new Size(103, 21);
            label6.TabIndex = 41;
            label6.Text = "Date of Birth";
            // 
            // Dob
            // 
            Dob.Location = new Point(247, 425);
            Dob.MaxDate = new DateTime(2010, 5, 1, 0, 0, 0, 0);
            Dob.Name = "Dob";
            Dob.Size = new Size(200, 23);
            Dob.TabIndex = 40;
            Dob.Value = new DateTime(2010, 5, 1, 0, 0, 0, 0);
            // 
            // Contactmask
            // 
            Contactmask.Location = new Point(542, 215);
            Contactmask.Mask = "0000-0000000";
            Contactmask.Name = "Contactmask";
            Contactmask.Size = new Size(216, 23);
            Contactmask.TabIndex = 36;
            // 
            // CNICmask
            // 
            CNICmask.Location = new Point(240, 215);
            CNICmask.Mask = "00000-0000000-0";
            CNICmask.Name = "CNICmask";
            CNICmask.Size = new Size(216, 23);
            CNICmask.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(542, 181);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 33;
            label2.Text = "Contact";
            // 
            // txtLname
            // 
            txtLname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLname.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLname.ForeColor = SystemColors.InfoText;
            txtLname.Location = new Point(542, 139);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(216, 29);
            txtLname.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(549, 104);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 31;
            label3.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 181);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 7;
            label1.Text = "CNIC";
            // 
            // txtFname
            // 
            txtFname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFname.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFname.ForeColor = SystemColors.InfoText;
            txtFname.Location = new Point(240, 139);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(216, 29);
            txtFname.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(247, 104);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 1;
            label5.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 24.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(23, 24, 29);
            label4.Location = new Point(332, 23);
            label4.Name = "label4";
            label4.Size = new Size(300, 45);
            label4.TabIndex = 0;
            label4.Text = "Create Your Profile";
            // 
            // ExpertINFOForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(panel2);
            Name = "ExpertINFOForm";
            Text = "ExpertINFOForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnSave;
        private TextBox txtAdress;
        private Label label7;
        private Label label6;
        private DateTimePicker Dob;
        private MaskedTextBox Contactmask;
        private MaskedTextBox CNICmask;
        private Label label2;
        private TextBox txtLname;
        private Label label3;
        private Label label1;
        private TextBox txtFname;
        private Label label5;
        private Label label4;
    }
}