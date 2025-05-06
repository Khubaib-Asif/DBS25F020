namespace AgricultureManagementSystem
{
    partial class InfoForm
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
            txtAddress = new TextBox();
            label7 = new Label();
            label6 = new Label();
            Dob = new DateTimePicker();
            btnpic = new Button();
            pictureBox1 = new PictureBox();
            Contactmask = new MaskedTextBox();
            CNICmask = new MaskedTextBox();
            label2 = new Label();
            txtLname = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtFname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Dob);
            panel2.Controls.Add(btnpic);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(Contactmask);
            panel2.Controls.Add(CNICmask);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtLname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtFname);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 611);
            panel2.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(410, 529);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 39);
            btnSave.TabIndex = 44;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = SystemColors.InfoText;
            txtAddress.Location = new Point(543, 290);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(223, 80);
            txtAddress.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(550, 256);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 42;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(550, 386);
            label6.Name = "label6";
            label6.Size = new Size(103, 21);
            label6.TabIndex = 41;
            label6.Text = "Date of Birth";
            // 
            // Dob
            // 
            Dob.Location = new Point(550, 424);
            Dob.MaxDate = new DateTime(2010, 5, 1, 0, 0, 0, 0);
            Dob.Name = "Dob";
            Dob.Size = new Size(200, 23);
            Dob.TabIndex = 40;
            Dob.Value = new DateTime(2010, 5, 1, 0, 0, 0, 0);
            // 
            // btnpic
            // 
            btnpic.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpic.Location = new Point(255, 407);
            btnpic.Name = "btnpic";
            btnpic.Size = new Size(110, 39);
            btnpic.TabIndex = 39;
            btnpic.Text = "Upload Image";
            btnpic.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(248, 256);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // Contactmask
            // 
            Contactmask.Location = new Point(550, 215);
            Contactmask.Mask = "0000-0000000";
            Contactmask.Name = "Contactmask";
            Contactmask.Size = new Size(216, 23);
            Contactmask.TabIndex = 36;
            Contactmask.MaskInputRejected += Contactmask_MaskInputRejected;
            // 
            // CNICmask
            // 
            CNICmask.Location = new Point(248, 215);
            CNICmask.Mask = "00000-0000000-0";
            CNICmask.Name = "CNICmask";
            CNICmask.Size = new Size(216, 23);
            CNICmask.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(550, 181);
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
            txtLname.Location = new Point(550, 138);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(216, 29);
            txtLname.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(557, 104);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 31;
            label3.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 181);
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
            txtFname.Location = new Point(248, 138);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(216, 29);
            txtFname.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(255, 104);
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
            label4.Location = new Point(340, 23);
            label4.Name = "label4";
            label4.Size = new Size(300, 45);
            label4.TabIndex = 0;
            label4.Text = "Create Your Profile";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGreen;
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(986, 611);
            panel3.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "Select Image";
            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.InitialDirectory = "C:\\\\";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 611);
            Controls.Add(panel3);
            Name = "InfoForm";
            Text = "InfoForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private TextBox txtLname;
        private Label label3;
        private Label label1;
        private TextBox txtFname;
        private Label label5;
        private Label label4;
        private Panel panel3;
        private MaskedTextBox CNICmask;
        private MaskedTextBox Contactmask;
        private PictureBox pictureBox1;
        private Label label6;
        private DateTimePicker Dob;
        private Button btnpic;
        private TextBox txtAddress;
        private Label label7;
        private Button btnSave;
        private OpenFileDialog openFileDialog1;
    }
}