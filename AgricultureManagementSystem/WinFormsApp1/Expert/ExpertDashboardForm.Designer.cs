namespace AgricultureManagementSystem
{
    partial class ExpertDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            myProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tabConsultations = new TabPage();
            btnSubmitResponse = new Button();
            txtResponse = new TextBox();
            label5 = new Label();
            gridFramerRequest = new DataGridView();
            colRequestId = new DataGridViewTextBoxColumn();
            colFarmerName = new DataGridViewTextBoxColumn();
            colRequestType = new DataGridViewTextBoxColumn();
            colRequestDetails = new DataGridViewTextBoxColumn();
            colRequestStatus = new DataGridViewTextBoxColumn();
            tabEditProfile = new TabPage();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            numericUpDown3 = new NumericUpDown();
            label7 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            txtEmail = new TextBox();
            label9 = new Label();
            btnSaveProfile = new Button();
            btnCancelEdit = new Button();
            txtEditFullName = new TextBox();
            label6 = new Label();
            lblFullNameValue = new Label();
            lblEmailValue = new Label();
            lblSpecialtyValue = new Label();
            tabControlExpert = new TabControl();
            menuStrip1.SuspendLayout();
            tabConsultations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridFramerRequest).BeginInit();
            tabEditProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabControlExpert.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(23, 24, 29);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1500, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myProfileToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // myProfileToolStripMenuItem
            // 
            myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            myProfileToolStripMenuItem.Size = new Size(194, 34);
            myProfileToolStripMenuItem.Text = "My Profile";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(194, 34);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(194, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // tabConsultations
            // 
            tabConsultations.Controls.Add(btnSubmitResponse);
            tabConsultations.Controls.Add(txtResponse);
            tabConsultations.Controls.Add(label5);
            tabConsultations.Controls.Add(gridFramerRequest);
            tabConsultations.Location = new Point(4, 34);
            tabConsultations.Margin = new Padding(7, 5, 7, 5);
            tabConsultations.Name = "tabConsultations";
            tabConsultations.Padding = new Padding(7, 5, 7, 5);
            tabConsultations.Size = new Size(1492, 1027);
            tabConsultations.TabIndex = 1;
            tabConsultations.Text = "Farmer Consultations";
            tabConsultations.UseVisualStyleBackColor = true;
            // 
            // btnSubmitResponse
            // 
            btnSubmitResponse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitResponse.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmitResponse.FlatStyle = FlatStyle.Flat;
            btnSubmitResponse.ForeColor = Color.White;
            btnSubmitResponse.Location = new Point(1071, 942);
            btnSubmitResponse.Margin = new Padding(7, 5, 7, 5);
            btnSubmitResponse.Name = "btnSubmitResponse";
            btnSubmitResponse.Size = new Size(291, 67);
            btnSubmitResponse.TabIndex = 3;
            btnSubmitResponse.Text = "Submit Response";
            btnSubmitResponse.UseVisualStyleBackColor = false;
            // 
            // txtResponse
            // 
            txtResponse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResponse.Location = new Point(39, 745);
            txtResponse.Margin = new Padding(7, 5, 7, 5);
            txtResponse.Multiline = true;
            txtResponse.Name = "txtResponse";
            txtResponse.Size = new Size(1300, 174);
            txtResponse.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(39, 685);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 1;
            label5.Text = "Response:";
            // 
            // gridFramerRequest
            // 
            gridFramerRequest.AllowUserToAddRows = false;
            gridFramerRequest.AllowUserToDeleteRows = false;
            gridFramerRequest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridFramerRequest.BackgroundColor = Color.White;
            gridFramerRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFramerRequest.Columns.AddRange(new DataGridViewColumn[] { colRequestId, colFarmerName, colRequestType, colRequestDetails, colRequestStatus });
            gridFramerRequest.Location = new Point(39, 45);
            gridFramerRequest.Margin = new Padding(7, 5, 7, 5);
            gridFramerRequest.Name = "gridFramerRequest";
            gridFramerRequest.ReadOnly = true;
            gridFramerRequest.RowHeadersWidth = 62;
            gridFramerRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridFramerRequest.Size = new Size(1024, 565);
            gridFramerRequest.TabIndex = 0;
            // 
            // colRequestId
            // 
            colRequestId.DataPropertyName = "RequestId";
            colRequestId.HeaderText = "ID";
            colRequestId.MinimumWidth = 8;
            colRequestId.Name = "colRequestId";
            colRequestId.ReadOnly = true;
            colRequestId.Width = 50;
            // 
            // colFarmerName
            // 
            colFarmerName.DataPropertyName = "FarmerName";
            colFarmerName.HeaderText = "Farmer";
            colFarmerName.MinimumWidth = 8;
            colFarmerName.Name = "colFarmerName";
            colFarmerName.ReadOnly = true;
            colFarmerName.Width = 120;
            // 
            // colRequestType
            // 
            colRequestType.DataPropertyName = "RequestType";
            colRequestType.HeaderText = "Type";
            colRequestType.MinimumWidth = 8;
            colRequestType.Name = "colRequestType";
            colRequestType.ReadOnly = true;
            colRequestType.Width = 150;
            // 
            // colRequestDetails
            // 
            colRequestDetails.DataPropertyName = "RequestDetails";
            colRequestDetails.HeaderText = "Details";
            colRequestDetails.MinimumWidth = 8;
            colRequestDetails.Name = "colRequestDetails";
            colRequestDetails.ReadOnly = true;
            colRequestDetails.Width = 300;
            // 
            // colRequestStatus
            // 
            colRequestStatus.DataPropertyName = "RequestStatus";
            colRequestStatus.HeaderText = "Status";
            colRequestStatus.MinimumWidth = 8;
            colRequestStatus.Name = "colRequestStatus";
            colRequestStatus.ReadOnly = true;
            colRequestStatus.Width = 150;
            // 
            // tabEditProfile
            // 
            tabEditProfile.Controls.Add(textBox2);
            tabEditProfile.Controls.Add(label10);
            tabEditProfile.Controls.Add(textBox1);
            tabEditProfile.Controls.Add(label4);
            tabEditProfile.Controls.Add(comboBox2);
            tabEditProfile.Controls.Add(numericUpDown3);
            tabEditProfile.Controls.Add(label7);
            tabEditProfile.Controls.Add(numericUpDown2);
            tabEditProfile.Controls.Add(numericUpDown1);
            tabEditProfile.Controls.Add(label1);
            tabEditProfile.Controls.Add(label3);
            tabEditProfile.Controls.Add(label2);
            tabEditProfile.Controls.Add(label8);
            tabEditProfile.Controls.Add(comboBox1);
            tabEditProfile.Controls.Add(txtEmail);
            tabEditProfile.Controls.Add(label9);
            tabEditProfile.Controls.Add(btnSaveProfile);
            tabEditProfile.Controls.Add(btnCancelEdit);
            tabEditProfile.Controls.Add(txtEditFullName);
            tabEditProfile.Controls.Add(label6);
            tabEditProfile.Location = new Point(4, 34);
            tabEditProfile.Margin = new Padding(6, 5, 6, 5);
            tabEditProfile.Name = "tabEditProfile";
            tabEditProfile.Padding = new Padding(6, 5, 6, 5);
            tabEditProfile.Size = new Size(1492, 1027);
            tabEditProfile.TabIndex = 2;
            tabEditProfile.Text = "Edit Profile";
            tabEditProfile.UseVisualStyleBackColor = true;
            tabEditProfile.Click += tabEditProfile_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(859, 72);
            textBox2.Margin = new Padding(6, 5, 6, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(285, 31);
            textBox2.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(859, 33);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(108, 28);
            label10.TabIndex = 50;
            label10.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(343, 653);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(808, 131);
            textBox1.TabIndex = 49;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(341, 595);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 32);
            label4.TabIndex = 48;
            label4.Text = "Description";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            comboBox2.Location = new Point(866, 510);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(285, 33);
            comboBox2.TabIndex = 30;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Location = new Point(343, 510);
            numericUpDown3.Margin = new Padding(4, 5, 4, 5);
            numericUpDown3.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(287, 31);
            numericUpDown3.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(343, 447);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(155, 32);
            label7.TabIndex = 28;
            label7.Text = "CGPA / SGPA";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(866, 362);
            numericUpDown2.Margin = new Padding(4, 5, 4, 5);
            numericUpDown2.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(287, 31);
            numericUpDown2.TabIndex = 27;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(343, 362);
            numericUpDown1.Margin = new Padding(4, 5, 4, 5);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(287, 31);
            numericUpDown1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(866, 297);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 25;
            label1.Text = "Total Marks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(866, 447);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 32);
            label3.TabIndex = 24;
            label3.Text = "Passing Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(343, 297);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 23;
            label2.Text = "Obtained Marks";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(343, 142);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(151, 32);
            label8.TabIndex = 22;
            label8.Text = "Degree Type";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "HSC", "BSc", "MSc", "PhD", "Other" });
            comboBox1.Location = new Point(343, 208);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 33);
            comboBox1.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.InfoText;
            txtEmail.Location = new Point(866, 205);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MaxLength = 11;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(285, 40);
            txtEmail.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(866, 142);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(93, 32);
            label9.TabIndex = 19;
            label9.Text = "Roll No";
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.BackColor = Color.FromArgb(0, 192, 0);
            btnSaveProfile.FlatStyle = FlatStyle.Flat;
            btnSaveProfile.ForeColor = Color.White;
            btnSaveProfile.Location = new Point(959, 887);
            btnSaveProfile.Margin = new Padding(6, 5, 6, 5);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(167, 58);
            btnSaveProfile.TabIndex = 7;
            btnSaveProfile.Text = "Save";
            btnSaveProfile.UseVisualStyleBackColor = false;
            btnSaveProfile.Click += btnSaveProfile_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.ForeColor = Color.White;
            btnCancelEdit.Location = new Point(1209, 887);
            btnCancelEdit.Margin = new Padding(6, 5, 6, 5);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(167, 58);
            btnCancelEdit.TabIndex = 6;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = false;
            // 
            // txtEditFullName
            // 
            txtEditFullName.Location = new Point(343, 72);
            txtEditFullName.Margin = new Padding(6, 5, 6, 5);
            txtEditFullName.Name = "txtEditFullName";
            txtEditFullName.Size = new Size(285, 31);
            txtEditFullName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(343, 33);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 28);
            label6.TabIndex = 0;
            label6.Text = "First Name";
            // 
            // lblFullNameValue
            // 
            lblFullNameValue.AutoSize = true;
            lblFullNameValue.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullNameValue.Location = new Point(175, 46);
            lblFullNameValue.Margin = new Padding(4, 0, 4, 0);
            lblFullNameValue.Name = "lblFullNameValue";
            lblFullNameValue.Size = new Size(70, 15);
            lblFullNameValue.TabIndex = 4;
            lblFullNameValue.Text = "[Full Name]";
            // 
            // lblEmailValue
            // 
            lblEmailValue.AutoSize = true;
            lblEmailValue.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailValue.Location = new Point(175, 92);
            lblEmailValue.Margin = new Padding(4, 0, 4, 0);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(45, 15);
            lblEmailValue.TabIndex = 5;
            lblEmailValue.Text = "[Email]";
            // 
            // lblSpecialtyValue
            // 
            lblSpecialtyValue.AutoSize = true;
            lblSpecialtyValue.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpecialtyValue.Location = new Point(175, 138);
            lblSpecialtyValue.Margin = new Padding(4, 0, 4, 0);
            lblSpecialtyValue.Name = "lblSpecialtyValue";
            lblSpecialtyValue.Size = new Size(62, 15);
            lblSpecialtyValue.TabIndex = 6;
            lblSpecialtyValue.Text = "[Specialty]";
            // 
            // tabControlExpert
            // 
            tabControlExpert.Controls.Add(tabEditProfile);
            tabControlExpert.Controls.Add(tabConsultations);
            tabControlExpert.Dock = DockStyle.Fill;
            tabControlExpert.Location = new Point(0, 35);
            tabControlExpert.Margin = new Padding(6, 5, 6, 5);
            tabControlExpert.Name = "tabControlExpert";
            tabControlExpert.SelectedIndex = 0;
            tabControlExpert.Size = new Size(1500, 1065);
            tabControlExpert.TabIndex = 1;
            // 
            // ExpertDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 1100);
            Controls.Add(tabControlExpert);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 5, 6, 5);
            MinimumSize = new Size(1513, 1126);
            Name = "ExpertDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmer Management System - Expert Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabConsultations.ResumeLayout(false);
            tabConsultations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridFramerRequest).EndInit();
            tabEditProfile.ResumeLayout(false);
            tabEditProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabControlExpert.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private TabPage tabConsultations;
        private Button btnSubmitResponse;
        private TextBox txtResponse;
        private Label label5;
        private DataGridView gridFramerRequest;
        private DataGridViewTextBoxColumn colRequestId;
        private DataGridViewTextBoxColumn colFarmerName;
        private DataGridViewTextBoxColumn colRequestType;
        private DataGridViewTextBoxColumn colRequestDetails;
        private DataGridViewTextBoxColumn colRequestStatus;
        private TabPage tabEditProfile;
        private Button btnSaveProfile;
        private Button btnCancelEdit;
        private TextBox txtEditFullName;
        private Label label6;
        private TabPage tabViewProfile;
        private Panel panelProfileView;
        private Label lblSpecialtyValue;
        private Label lblEmailValue;
        private Label lblFullNameValue;
        private Label lblSpecialty;
        private Label lblEmail;
        private Label lblFullName;
        private Button btnEditProfile;
        private TabControl tabControlExpert;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label8;
        private ComboBox comboBox1;
        private TextBox txtEmail;
        private Label label9;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label10;
    }
}