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
            tabControlExpert = new TabControl();
            tabViewProfile = new TabPage();
            panelProfileView = new Panel();
            lblSpecialtyValue = new Label();
            lblEmailValue = new Label();
            lblFullNameValue = new Label();
            lblSpecialty = new Label();
            lblEmail = new Label();
            lblFullName = new Label();
            btnEditProfile = new Button();
            tabEditProfile = new TabPage();
            btnSaveProfile = new Button();
            btnCancelEdit = new Button();
            txtEditSpecialty = new TextBox();
            label4 = new Label();
            txtEditEmail = new TextBox();
            label5 = new Label();
            txtEditFullName = new TextBox();
            label6 = new Label();
            tabConsultations = new TabPage();
            btnSubmitResponse = new Button();
            txtResponse = new TextBox();
            gridFramerRequest = new DataGridView();
            colRequestId = new DataGridViewTextBoxColumn();
            colFarmerName = new DataGridViewTextBoxColumn();
            colRequestType = new DataGridViewTextBoxColumn();
            colRequestDetails = new DataGridViewTextBoxColumn();
            colRequestStatus = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            tabControlExpert.SuspendLayout();
            tabViewProfile.SuspendLayout();
            panelProfileView.SuspendLayout();
            tabEditProfile.SuspendLayout();
            tabConsultations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridFramerRequest).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(76, 175, 80);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1050, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myProfileToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // myProfileToolStripMenuItem
            // 
            myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            myProfileToolStripMenuItem.Size = new Size(180, 22);
            myProfileToolStripMenuItem.Text = "My Profile";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // tabControlExpert
            // 
            tabControlExpert.Controls.Add(tabViewProfile);
            tabControlExpert.Controls.Add(tabEditProfile);
            tabControlExpert.Controls.Add(tabConsultations);
            tabControlExpert.Dock = DockStyle.Fill;
            tabControlExpert.Location = new Point(0, 24);
            tabControlExpert.Margin = new Padding(4, 3, 4, 3);
            tabControlExpert.Name = "tabControlExpert";
            tabControlExpert.SelectedIndex = 0;
            tabControlExpert.Size = new Size(1050, 614);
            tabControlExpert.TabIndex = 1;
            // 
            // tabViewProfile
            // 
            tabViewProfile.Controls.Add(panelProfileView);
            tabViewProfile.Location = new Point(4, 24);
            tabViewProfile.Margin = new Padding(4, 3, 4, 3);
            tabViewProfile.Name = "tabViewProfile";
            tabViewProfile.Padding = new Padding(4, 3, 4, 3);
            tabViewProfile.Size = new Size(1042, 586);
            tabViewProfile.TabIndex = 0;
            tabViewProfile.Text = "View Profile";
            tabViewProfile.UseVisualStyleBackColor = true;
            // 
            // panelProfileView
            // 
            panelProfileView.Anchor = AnchorStyles.None;
            panelProfileView.Controls.Add(lblSpecialtyValue);
            panelProfileView.Controls.Add(lblEmailValue);
            panelProfileView.Controls.Add(lblFullNameValue);
            panelProfileView.Controls.Add(lblSpecialty);
            panelProfileView.Controls.Add(lblEmail);
            panelProfileView.Controls.Add(lblFullName);
            panelProfileView.Controls.Add(btnEditProfile);
            panelProfileView.Location = new Point(233, 62);
            panelProfileView.Margin = new Padding(4, 3, 4, 3);
            panelProfileView.Name = "panelProfileView";
            panelProfileView.Size = new Size(583, 346);
            panelProfileView.TabIndex = 0;
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
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialty.Location = new Point(35, 138);
            lblSpecialty.Margin = new Padding(4, 0, 4, 0);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new Size(69, 15);
            lblSpecialty.TabIndex = 3;
            lblSpecialty.Text = "Specialty:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(35, 92);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(35, 46);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(77, 15);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.FromArgb(0, 120, 215);
            btnEditProfile.FlatStyle = FlatStyle.Flat;
            btnEditProfile.ForeColor = Color.White;
            btnEditProfile.Location = new Point(233, 231);
            btnEditProfile.Margin = new Padding(4, 3, 4, 3);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(117, 35);
            btnEditProfile.TabIndex = 0;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            // 
            // tabEditProfile
            // 
            tabEditProfile.Controls.Add(btnSaveProfile);
            tabEditProfile.Controls.Add(btnCancelEdit);
            tabEditProfile.Controls.Add(txtEditSpecialty);
            tabEditProfile.Controls.Add(label4);
            tabEditProfile.Controls.Add(txtEditEmail);
            tabEditProfile.Controls.Add(txtEditFullName);
            tabEditProfile.Controls.Add(label6);
            tabEditProfile.Location = new Point(4, 24);
            tabEditProfile.Margin = new Padding(4, 3, 4, 3);
            tabEditProfile.Name = "tabEditProfile";
            tabEditProfile.Padding = new Padding(4, 3, 4, 3);
            tabEditProfile.Size = new Size(1042, 586);
            tabEditProfile.TabIndex = 2;
            tabEditProfile.Text = "Edit Profile";
            tabEditProfile.UseVisualStyleBackColor = true;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.BackColor = Color.FromArgb(0, 192, 0);
            btnSaveProfile.FlatStyle = FlatStyle.Flat;
            btnSaveProfile.ForeColor = Color.White;
            btnSaveProfile.Location = new Point(408, 231);
            btnSaveProfile.Margin = new Padding(4, 3, 4, 3);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(117, 35);
            btnSaveProfile.TabIndex = 7;
            btnSaveProfile.Text = "Save";
            btnSaveProfile.UseVisualStyleBackColor = false;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.ForeColor = Color.White;
            btnCancelEdit.Location = new Point(583, 231);
            btnCancelEdit.Margin = new Padding(4, 3, 4, 3);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(117, 35);
            btnCancelEdit.TabIndex = 6;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = false;
            // 
            // txtEditSpecialty
            // 
            txtEditSpecialty.Location = new Point(408, 173);
            txtEditSpecialty.Margin = new Padding(4, 3, 4, 3);
            txtEditSpecialty.Name = "txtEditSpecialty";
            txtEditSpecialty.Size = new Size(349, 23);
            txtEditSpecialty.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 150);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 4;
            label4.Text = "Specialty";
            // 
            // txtEditEmail
            // 
            txtEditEmail.Location = new Point(408, 115);
            txtEditEmail.Margin = new Padding(4, 3, 4, 3);
            txtEditEmail.Name = "txtEditEmail";
            txtEditEmail.ReadOnly = true;
            txtEditEmail.Size = new Size(349, 23);
            txtEditEmail.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(27, 455);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 1;
            label5.Text = "Response:";
            // 
            // txtEditFullName
            // 
            txtEditFullName.Location = new Point(408, 58);
            txtEditFullName.Margin = new Padding(4, 3, 4, 3);
            txtEditFullName.Name = "txtEditFullName";
            txtEditFullName.Size = new Size(349, 23);
            txtEditFullName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 35);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 0;
            label6.Text = "Full Name";
            // 
            // tabConsultations
            // 
            tabConsultations.Controls.Add(btnSubmitResponse);
            tabConsultations.Controls.Add(txtResponse);
            tabConsultations.Controls.Add(label5);
            tabConsultations.Controls.Add(gridFramerRequest);
            tabConsultations.Location = new Point(4, 24);
            tabConsultations.Margin = new Padding(5, 3, 5, 3);
            tabConsultations.Name = "tabConsultations";
            tabConsultations.Padding = new Padding(5, 3, 5, 3);
            tabConsultations.Size = new Size(1042, 586);
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
            btnSubmitResponse.Location = new Point(953, 614);
            btnSubmitResponse.Margin = new Padding(5, 3, 5, 3);
            btnSubmitResponse.Name = "btnSubmitResponse";
            btnSubmitResponse.Size = new Size(204, 40);
            btnSubmitResponse.TabIndex = 3;
            btnSubmitResponse.Text = "Submit Response";
            btnSubmitResponse.UseVisualStyleBackColor = false;
            // 
            // txtResponse
            // 
            txtResponse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResponse.Location = new Point(27, 481);
            txtResponse.Margin = new Padding(5, 3, 5, 3);
            txtResponse.Multiline = true;
            txtResponse.Name = "txtResponse";
            txtResponse.Size = new Size(1129, 106);
            txtResponse.TabIndex = 2;
            // 
            // gridFramerRequest
            // 
            gridFramerRequest.AllowUserToAddRows = false;
            gridFramerRequest.AllowUserToDeleteRows = false;
            gridFramerRequest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridFramerRequest.BackgroundColor = Color.White;
            gridFramerRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFramerRequest.Columns.AddRange(new DataGridViewColumn[] { colRequestId, colFarmerName, colRequestType, colRequestDetails, colRequestStatus });
            gridFramerRequest.Location = new Point(27, 27);
            gridFramerRequest.Margin = new Padding(5, 3, 5, 3);
            gridFramerRequest.Name = "gridFramerRequest";
            gridFramerRequest.ReadOnly = true;
            gridFramerRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridFramerRequest.Size = new Size(1157, 414);
            gridFramerRequest.TabIndex = 0;
            // 
            // colRequestId
            // 
            colRequestId.DataPropertyName = "RequestId";
            colRequestId.HeaderText = "ID";
            colRequestId.Name = "colRequestId";
            colRequestId.ReadOnly = true;
            colRequestId.Width = 50;
            // 
            // colFarmerName
            // 
            colFarmerName.DataPropertyName = "FarmerName";
            colFarmerName.HeaderText = "Farmer";
            colFarmerName.Name = "colFarmerName";
            colFarmerName.ReadOnly = true;
            colFarmerName.Width = 120;
            // 
            // colRequestType
            // 
            colRequestType.DataPropertyName = "RequestType";
            colRequestType.HeaderText = "Type";
            colRequestType.Name = "colRequestType";
            colRequestType.ReadOnly = true;
            // 
            // colRequestDetails
            // 
            colRequestDetails.DataPropertyName = "RequestDetails";
            colRequestDetails.HeaderText = "Details";
            colRequestDetails.Name = "colRequestDetails";
            colRequestDetails.ReadOnly = true;
            colRequestDetails.Width = 300;
            // 
            // colRequestStatus
            // 
            colRequestStatus.DataPropertyName = "RequestStatus";
            colRequestStatus.HeaderText = "Status";
            colRequestStatus.Name = "colRequestStatus";
            colRequestStatus.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 638);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 19, 0);
            statusStrip1.Size = new Size(1050, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(110, 17);
            toolStripStatusLabel.Text = "Logged in as Expert";
            // 
            // ExpertDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 660);
            Controls.Add(tabControlExpert);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1066, 699);
            Name = "ExpertDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmer Management System - Expert Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControlExpert.ResumeLayout(false);
            tabViewProfile.ResumeLayout(false);
            panelProfileView.ResumeLayout(false);
            panelProfileView.PerformLayout();
            tabEditProfile.ResumeLayout(false);
            tabEditProfile.PerformLayout();
            tabConsultations.ResumeLayout(false);
            tabConsultations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridFramerRequest).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlExpert;
        private System.Windows.Forms.TabPage tabViewProfile;
        private System.Windows.Forms.Panel panelProfileView;
        private System.Windows.Forms.Label lblSpecialtyValue;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.TabPage tabEditProfile;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.TextBox txtEditSpecialty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEditFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabConsultations;
        private System.Windows.Forms.Button btnSubmitResponse;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridFramerRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFarmerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}