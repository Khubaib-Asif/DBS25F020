namespace AgricultureManagementSystem.Farmer
{
    partial class VendorForm
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
            txtAddress = new TextBox();
            label7 = new Label();
            Contactmask = new MaskedTextBox();
            CNICmask = new MaskedTextBox();
            label2 = new Label();
            txtLname = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtFname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnaddvendor = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnaddvendor);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(Contactmask);
            panel2.Controls.Add(CNICmask);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtLname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtFname);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 611);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = SystemColors.InfoText;
            txtAddress.Location = new Point(248, 294);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(200, 80);
            txtAddress.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(255, 260);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 42;
            label7.Text = "Address";
            // 
            // Contactmask
            // 
            Contactmask.Location = new Point(550, 215);
            Contactmask.Mask = "0000-0000000";
            Contactmask.Name = "Contactmask";
            Contactmask.Size = new Size(216, 23);
            Contactmask.TabIndex = 36;
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
            label4.Size = new Size(341, 45);
            label4.TabIndex = 0;
            label4.Text = "Create Vendor Profile";
            // 
            // btnaddvendor
            // 
            btnaddvendor.BackColor = Color.FromArgb(0, 192, 0);
            btnaddvendor.FlatStyle = FlatStyle.Flat;
            btnaddvendor.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddvendor.ForeColor = Color.White;
            btnaddvendor.Location = new Point(416, 473);
            btnaddvendor.Margin = new Padding(4, 3, 4, 3);
            btnaddvendor.Name = "btnaddvendor";
            btnaddvendor.Size = new Size(117, 35);
            btnaddvendor.TabIndex = 44;
            btnaddvendor.Text = "Add Vendor";
            btnaddvendor.UseVisualStyleBackColor = false;
            // 
            // VendorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 537);
            Controls.Add(panel2);
            Name = "VendorForm";
            Text = "VendorForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtAddress;
        private Label label7;
        private MaskedTextBox Contactmask;
        private MaskedTextBox CNICmask;
        private Label label2;
        private TextBox txtLname;
        private Label label3;
        private Label label1;
        private TextBox txtFname;
        private Label label5;
        private Label label4;
        private Button btnaddvendor;
    }
}