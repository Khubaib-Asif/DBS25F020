namespace AgricultureManagementSystem
{
    partial class AdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tabControlAdmin = new TabControl();
            tabExpertRegistration = new TabPage();
            btnBanExpert = new Button();
            btnRejectExpert = new Button();
            btnApproveExpert = new Button();
            dgvExpertApplications = new DataGridView();
            colExpertAppId = new DataGridViewTextBoxColumn();
            colExpertName = new DataGridViewTextBoxColumn();
            colExpertEmail = new DataGridViewTextBoxColumn();
            colExpertSpecialty = new DataGridViewTextBoxColumn();
            colExpertDocuments = new DataGridViewButtonColumn();
            tabFraudReports = new TabPage();
            btnDismissReport = new Button();
            btnBanReportedExpert = new Button();
            dgvFraudReports = new DataGridView();
            colReportId = new DataGridViewTextBoxColumn();
            colFarmerID = new DataGridViewTextBoxColumn();
            colExpertID = new DataGridViewTextBoxColumn();
            colReportType = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewButtonColumn();
            tabEquipmentCatalog = new TabPage();
            btnDeleteEquipment = new Button();
            btnUpdateEquipment = new Button();
            btnAddEquipment = new Button();
            txtEquipmentDescription = new TextBox();
            label4 = new Label();
            txtEquipmentName = new TextBox();
            label3 = new Label();
            dgvEquipment = new DataGridView();
            colEquipmentId = new DataGridViewTextBoxColumn();
            colEquipmentName = new DataGridViewTextBoxColumn();
            colEquipmentDesc = new DataGridViewTextBoxColumn();
            tabCropCatalog = new TabPage();
            textBox1 = new TextBox();
            label2 = new Label();
            btnDeleteCrop = new Button();
            btnUpdateCrop = new Button();
            btnAddCrop = new Button();
            txtCropName = new TextBox();
            label1 = new Label();
            dgvCrops = new DataGridView();
            colCropId = new DataGridViewTextBoxColumn();
            colCropName = new DataGridViewTextBoxColumn();
            colCropDescription = new DataGridViewTextBoxColumn();
            tabProductRequests = new TabPage();
            btnRejectRequest = new Button();
            btnApproveRequest = new Button();
            dgvProductRequests = new DataGridView();
            colRequestId = new DataGridViewTextBoxColumn();
            colRequestFarmer = new DataGridViewTextBoxColumn();
            colRequestType = new DataGridViewTextBoxColumn();
            colRequestDescription = new DataGridViewTextBoxColumn();
            colRequestStatus = new DataGridViewTextBoxColumn();
            colEquipmentStatus = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLastLogin = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            tabControlAdmin.SuspendLayout();
            tabExpertRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpertApplications).BeginInit();
            tabFraudReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFraudReports).BeginInit();
            tabEquipmentCatalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            tabCropCatalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCrops).BeginInit();
            tabProductRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductRequests).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(23, 24, 29);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1148, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.FromArgb(23, 24, 29);
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
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
            // tabControlAdmin
            // 
            tabControlAdmin.Controls.Add(tabExpertRegistration);
            tabControlAdmin.Controls.Add(tabFraudReports);
            tabControlAdmin.Controls.Add(tabEquipmentCatalog);
            tabControlAdmin.Controls.Add(tabCropCatalog);
            tabControlAdmin.Controls.Add(tabProductRequests);
            tabControlAdmin.Dock = DockStyle.Fill;
            tabControlAdmin.Location = new Point(0, 24);
            tabControlAdmin.Margin = new Padding(4, 3, 4, 3);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
            tabControlAdmin.Size = new Size(1148, 601);
            tabControlAdmin.TabIndex = 1;
            // 
            // tabExpertRegistration
            // 
            tabExpertRegistration.Controls.Add(btnBanExpert);
            tabExpertRegistration.Controls.Add(btnRejectExpert);
            tabExpertRegistration.Controls.Add(btnApproveExpert);
            tabExpertRegistration.Controls.Add(dgvExpertApplications);
            tabExpertRegistration.Location = new Point(4, 24);
            tabExpertRegistration.Margin = new Padding(4, 3, 4, 3);
            tabExpertRegistration.Name = "tabExpertRegistration";
            tabExpertRegistration.Padding = new Padding(4, 3, 4, 3);
            tabExpertRegistration.Size = new Size(1140, 573);
            tabExpertRegistration.TabIndex = 0;
            tabExpertRegistration.Text = "Expert Applications";
            tabExpertRegistration.UseVisualStyleBackColor = true;
            // 
            // btnBanExpert
            // 
            btnBanExpert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBanExpert.BackColor = Color.FromArgb(192, 0, 0);
            btnBanExpert.FlatStyle = FlatStyle.Flat;
            btnBanExpert.ForeColor = Color.White;
            btnBanExpert.Location = new Point(927, 529);
            btnBanExpert.Margin = new Padding(4, 3, 4, 3);
            btnBanExpert.Name = "btnBanExpert";
            btnBanExpert.Size = new Size(204, 35);
            btnBanExpert.TabIndex = 3;
            btnBanExpert.Text = "Ban Expert";
            btnBanExpert.UseVisualStyleBackColor = false;
            // 
            // btnRejectExpert
            // 
            btnRejectExpert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRejectExpert.BackColor = Color.FromArgb(255, 128, 0);
            btnRejectExpert.FlatStyle = FlatStyle.Flat;
            btnRejectExpert.ForeColor = Color.White;
            btnRejectExpert.Location = new Point(716, 529);
            btnRejectExpert.Margin = new Padding(4, 3, 4, 3);
            btnRejectExpert.Name = "btnRejectExpert";
            btnRejectExpert.Size = new Size(204, 35);
            btnRejectExpert.TabIndex = 2;
            btnRejectExpert.Text = "Reject Application";
            btnRejectExpert.UseVisualStyleBackColor = false;
            // 
            // btnApproveExpert
            // 
            btnApproveExpert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnApproveExpert.BackColor = Color.FromArgb(0, 192, 0);
            btnApproveExpert.FlatStyle = FlatStyle.Flat;
            btnApproveExpert.ForeColor = Color.White;
            btnApproveExpert.Location = new Point(505, 529);
            btnApproveExpert.Margin = new Padding(4, 3, 4, 3);
            btnApproveExpert.Name = "btnApproveExpert";
            btnApproveExpert.Size = new Size(204, 35);
            btnApproveExpert.TabIndex = 1;
            btnApproveExpert.Text = "Approve Application";
            btnApproveExpert.UseVisualStyleBackColor = false;
            // 
            // dgvExpertApplications
            // 
            dgvExpertApplications.AllowUserToAddRows = false;
            dgvExpertApplications.AllowUserToDeleteRows = false;
            dgvExpertApplications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvExpertApplications.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExpertApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExpertApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpertApplications.Columns.AddRange(new DataGridViewColumn[] { colExpertAppId, colExpertName, colExpertEmail, colExpertSpecialty, colExpertDocuments });
            dgvExpertApplications.Location = new Point(7, 7);
            dgvExpertApplications.Margin = new Padding(4, 3, 4, 3);
            dgvExpertApplications.Name = "dgvExpertApplications";
            dgvExpertApplications.ReadOnly = true;
            dgvExpertApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpertApplications.Size = new Size(1125, 515);
            dgvExpertApplications.TabIndex = 0;
            // 
            // colExpertAppId
            // 
            colExpertAppId.DataPropertyName = "Id";
            colExpertAppId.HeaderText = "Application ID";
            colExpertAppId.Name = "colExpertAppId";
            colExpertAppId.ReadOnly = true;
            colExpertAppId.Width = 80;
            // 
            // colExpertName
            // 
            colExpertName.DataPropertyName = "Name";
            colExpertName.HeaderText = "Expert Name";
            colExpertName.Name = "colExpertName";
            colExpertName.ReadOnly = true;
            colExpertName.Width = 150;
            // 
            // colExpertEmail
            // 
            colExpertEmail.DataPropertyName = "Email";
            colExpertEmail.HeaderText = "Email";
            colExpertEmail.Name = "colExpertEmail";
            colExpertEmail.ReadOnly = true;
            colExpertEmail.Width = 200;
            // 
            // colExpertSpecialty
            // 
            colExpertSpecialty.DataPropertyName = "Specialty";
            colExpertSpecialty.HeaderText = "Specialty";
            colExpertSpecialty.Name = "colExpertSpecialty";
            colExpertSpecialty.ReadOnly = true;
            colExpertSpecialty.Width = 150;
            // 
            // colExpertDocuments
            // 
            colExpertDocuments.HeaderText = "Documents";
            colExpertDocuments.Name = "colExpertDocuments";
            colExpertDocuments.ReadOnly = true;
            colExpertDocuments.Text = "View";
            colExpertDocuments.UseColumnTextForButtonValue = true;
            // 
            // tabFraudReports
            // 
            tabFraudReports.Controls.Add(btnDismissReport);
            tabFraudReports.Controls.Add(btnBanReportedExpert);
            tabFraudReports.Controls.Add(dgvFraudReports);
            tabFraudReports.Location = new Point(4, 24);
            tabFraudReports.Margin = new Padding(4, 3, 4, 3);
            tabFraudReports.Name = "tabFraudReports";
            tabFraudReports.Padding = new Padding(4, 3, 4, 3);
            tabFraudReports.Size = new Size(1140, 573);
            tabFraudReports.TabIndex = 1;
            tabFraudReports.Text = "Fraud Reports";
            tabFraudReports.UseVisualStyleBackColor = true;
            // 
            // btnDismissReport
            // 
            btnDismissReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDismissReport.BackColor = Color.FromArgb(192, 192, 0);
            btnDismissReport.FlatStyle = FlatStyle.Flat;
            btnDismissReport.ForeColor = Color.White;
            btnDismissReport.Location = new Point(716, 529);
            btnDismissReport.Margin = new Padding(4, 3, 4, 3);
            btnDismissReport.Name = "btnDismissReport";
            btnDismissReport.Size = new Size(204, 35);
            btnDismissReport.TabIndex = 2;
            btnDismissReport.Text = "Dismiss Report";
            btnDismissReport.UseVisualStyleBackColor = false;
            // 
            // btnBanReportedExpert
            // 
            btnBanReportedExpert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBanReportedExpert.BackColor = Color.FromArgb(192, 0, 0);
            btnBanReportedExpert.FlatStyle = FlatStyle.Flat;
            btnBanReportedExpert.ForeColor = Color.White;
            btnBanReportedExpert.Location = new Point(927, 529);
            btnBanReportedExpert.Margin = new Padding(4, 3, 4, 3);
            btnBanReportedExpert.Name = "btnBanReportedExpert";
            btnBanReportedExpert.Size = new Size(204, 35);
            btnBanReportedExpert.TabIndex = 1;
            btnBanReportedExpert.Text = "Ban Reported Expert";
            btnBanReportedExpert.UseVisualStyleBackColor = false;
            // 
            // dgvFraudReports
            // 
            dgvFraudReports.AllowUserToAddRows = false;
            dgvFraudReports.AllowUserToDeleteRows = false;
            dgvFraudReports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFraudReports.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFraudReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFraudReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFraudReports.Columns.AddRange(new DataGridViewColumn[] { colReportId, colFarmerID, colExpertID, colReportType, colDescription, colStatus });
            dgvFraudReports.Location = new Point(7, 7);
            dgvFraudReports.Margin = new Padding(4, 3, 4, 3);
            dgvFraudReports.Name = "dgvFraudReports";
            dgvFraudReports.ReadOnly = true;
            dgvFraudReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFraudReports.Size = new Size(1125, 515);
            dgvFraudReports.TabIndex = 0;
            // 
            // colReportId
            // 
            colReportId.DataPropertyName = "Id";
            colReportId.HeaderText = "Report ID";
            colReportId.Name = "colReportId";
            colReportId.ReadOnly = true;
            colReportId.Width = 70;
            // 
            // colFarmerID
            // 
            colFarmerID.DataPropertyName = "FarmerName";
            colFarmerID.HeaderText = "Farmer ID";
            colFarmerID.Name = "colFarmerID";
            colFarmerID.ReadOnly = true;
            colFarmerID.Width = 120;
            // 
            // colExpertID
            // 
            colExpertID.DataPropertyName = "ExpertName";
            colExpertID.HeaderText = "Expert ID";
            colExpertID.Name = "colExpertID";
            colExpertID.ReadOnly = true;
            colExpertID.Width = 120;
            // 
            // colReportType
            // 
            colReportType.DataPropertyName = "Type";
            colReportType.HeaderText = "Report Type";
            colReportType.Name = "colReportType";
            colReportType.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.DataPropertyName = "Detail";
            colDescription.HeaderText = "Report description ";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            colDescription.Width = 300;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Text = "View";
            colStatus.UseColumnTextForButtonValue = true;
            // 
            // tabEquipmentCatalog
            // 
            tabEquipmentCatalog.Controls.Add(btnDeleteEquipment);
            tabEquipmentCatalog.Controls.Add(btnUpdateEquipment);
            tabEquipmentCatalog.Controls.Add(btnAddEquipment);
            tabEquipmentCatalog.Controls.Add(txtEquipmentDescription);
            tabEquipmentCatalog.Controls.Add(label4);
            tabEquipmentCatalog.Controls.Add(txtEquipmentName);
            tabEquipmentCatalog.Controls.Add(label3);
            tabEquipmentCatalog.Controls.Add(dgvEquipment);
            tabEquipmentCatalog.Location = new Point(4, 24);
            tabEquipmentCatalog.Margin = new Padding(4, 3, 4, 3);
            tabEquipmentCatalog.Name = "tabEquipmentCatalog";
            tabEquipmentCatalog.Padding = new Padding(4, 3, 4, 3);
            tabEquipmentCatalog.Size = new Size(1140, 573);
            tabEquipmentCatalog.TabIndex = 2;
            tabEquipmentCatalog.Text = "Equipment Catalog";
            tabEquipmentCatalog.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEquipment
            // 
            btnDeleteEquipment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteEquipment.BackColor = Color.FromArgb(192, 0, 0);
            btnDeleteEquipment.FlatStyle = FlatStyle.Flat;
            btnDeleteEquipment.ForeColor = Color.White;
            btnDeleteEquipment.Location = new Point(927, 529);
            btnDeleteEquipment.Margin = new Padding(4, 3, 4, 3);
            btnDeleteEquipment.Name = "btnDeleteEquipment";
            btnDeleteEquipment.Size = new Size(204, 35);
            btnDeleteEquipment.TabIndex = 7;
            btnDeleteEquipment.Text = "Delete Equipment";
            btnDeleteEquipment.UseVisualStyleBackColor = false;
            // 
            // btnUpdateEquipment
            // 
            btnUpdateEquipment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateEquipment.BackColor = Color.FromArgb(0, 192, 0);
            btnUpdateEquipment.FlatStyle = FlatStyle.Flat;
            btnUpdateEquipment.ForeColor = Color.White;
            btnUpdateEquipment.Location = new Point(716, 529);
            btnUpdateEquipment.Margin = new Padding(4, 3, 4, 3);
            btnUpdateEquipment.Name = "btnUpdateEquipment";
            btnUpdateEquipment.Size = new Size(204, 35);
            btnUpdateEquipment.TabIndex = 6;
            btnUpdateEquipment.Text = "Update Equipment";
            btnUpdateEquipment.UseVisualStyleBackColor = false;
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddEquipment.BackColor = Color.FromArgb(0, 192, 0);
            btnAddEquipment.FlatStyle = FlatStyle.Flat;
            btnAddEquipment.ForeColor = Color.White;
            btnAddEquipment.Location = new Point(505, 529);
            btnAddEquipment.Margin = new Padding(4, 3, 4, 3);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(204, 35);
            btnAddEquipment.TabIndex = 5;
            btnAddEquipment.Text = "Add New Equipment";
            btnAddEquipment.UseVisualStyleBackColor = false;
            // 
            // txtEquipmentDescription
            // 
            txtEquipmentDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEquipmentDescription.Location = new Point(503, 98);
            txtEquipmentDescription.Margin = new Padding(4, 3, 4, 3);
            txtEquipmentDescription.Multiline = true;
            txtEquipmentDescription.Name = "txtEquipmentDescription";
            txtEquipmentDescription.Size = new Size(626, 69);
            txtEquipmentDescription.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(503, 80);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 3;
            label4.Text = "Equipment Description";
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEquipmentName.Location = new Point(506, 42);
            txtEquipmentName.Margin = new Padding(4, 3, 4, 3);
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.Size = new Size(623, 23);
            txtEquipmentName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(503, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 1;
            label3.Text = "Equipment Name";
            // 
            // dgvEquipment
            // 
            dgvEquipment.AllowUserToAddRows = false;
            dgvEquipment.AllowUserToDeleteRows = false;
            dgvEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvEquipment.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Columns.AddRange(new DataGridViewColumn[] { colEquipmentId, colEquipmentName, colEquipmentDesc });
            dgvEquipment.Location = new Point(7, 7);
            dgvEquipment.Margin = new Padding(4, 3, 4, 3);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.ReadOnly = true;
            dgvEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipment.Size = new Size(488, 557);
            dgvEquipment.TabIndex = 0;
            // 
            // colEquipmentId
            // 
            colEquipmentId.DataPropertyName = "Id";
            colEquipmentId.HeaderText = "ID";
            colEquipmentId.Name = "colEquipmentId";
            colEquipmentId.ReadOnly = true;
            colEquipmentId.Width = 50;
            // 
            // colEquipmentName
            // 
            colEquipmentName.DataPropertyName = "Name";
            colEquipmentName.HeaderText = "Name";
            colEquipmentName.Name = "colEquipmentName";
            colEquipmentName.ReadOnly = true;
            // 
            // colEquipmentDesc
            // 
            colEquipmentDesc.DataPropertyName = "Description";
            colEquipmentDesc.HeaderText = "Description";
            colEquipmentDesc.Name = "colEquipmentDesc";
            colEquipmentDesc.ReadOnly = true;
            colEquipmentDesc.Width = 150;
            // 
            // tabCropCatalog
            // 
            tabCropCatalog.Controls.Add(textBox1);
            tabCropCatalog.Controls.Add(label2);
            tabCropCatalog.Controls.Add(btnDeleteCrop);
            tabCropCatalog.Controls.Add(btnUpdateCrop);
            tabCropCatalog.Controls.Add(btnAddCrop);
            tabCropCatalog.Controls.Add(txtCropName);
            tabCropCatalog.Controls.Add(label1);
            tabCropCatalog.Controls.Add(dgvCrops);
            tabCropCatalog.Location = new Point(4, 24);
            tabCropCatalog.Margin = new Padding(4, 3, 4, 3);
            tabCropCatalog.Name = "tabCropCatalog";
            tabCropCatalog.Padding = new Padding(4, 3, 4, 3);
            tabCropCatalog.Size = new Size(1140, 573);
            tabCropCatalog.TabIndex = 3;
            tabCropCatalog.Text = "Crop Catalog";
            tabCropCatalog.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(505, 109);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(626, 69);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(505, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 8;
            label2.Text = "Crop Description";
            // 
            // btnDeleteCrop
            // 
            btnDeleteCrop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteCrop.BackColor = Color.FromArgb(192, 0, 0);
            btnDeleteCrop.FlatStyle = FlatStyle.Flat;
            btnDeleteCrop.ForeColor = Color.White;
            btnDeleteCrop.Location = new Point(927, 529);
            btnDeleteCrop.Margin = new Padding(4, 3, 4, 3);
            btnDeleteCrop.Name = "btnDeleteCrop";
            btnDeleteCrop.Size = new Size(204, 35);
            btnDeleteCrop.TabIndex = 7;
            btnDeleteCrop.Text = "Delete Crop";
            btnDeleteCrop.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCrop
            // 
            btnUpdateCrop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateCrop.BackColor = Color.FromArgb(0, 192, 0);
            btnUpdateCrop.FlatStyle = FlatStyle.Flat;
            btnUpdateCrop.ForeColor = Color.White;
            btnUpdateCrop.Location = new Point(716, 529);
            btnUpdateCrop.Margin = new Padding(4, 3, 4, 3);
            btnUpdateCrop.Name = "btnUpdateCrop";
            btnUpdateCrop.Size = new Size(204, 35);
            btnUpdateCrop.TabIndex = 6;
            btnUpdateCrop.Text = "Update Crop";
            btnUpdateCrop.UseVisualStyleBackColor = false;
            // 
            // btnAddCrop
            // 
            btnAddCrop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddCrop.BackColor = Color.FromArgb(0, 192, 0);
            btnAddCrop.FlatStyle = FlatStyle.Flat;
            btnAddCrop.ForeColor = Color.White;
            btnAddCrop.Location = new Point(505, 529);
            btnAddCrop.Margin = new Padding(4, 3, 4, 3);
            btnAddCrop.Name = "btnAddCrop";
            btnAddCrop.Size = new Size(204, 35);
            btnAddCrop.TabIndex = 5;
            btnAddCrop.Text = "Add New Crop";
            btnAddCrop.UseVisualStyleBackColor = false;
            // 
            // txtCropName
            // 
            txtCropName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCropName.Location = new Point(505, 44);
            txtCropName.Margin = new Padding(4, 3, 4, 3);
            txtCropName.Name = "txtCropName";
            txtCropName.Size = new Size(626, 23);
            txtCropName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(502, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Crop Name";
            // 
            // dgvCrops
            // 
            dgvCrops.AllowUserToAddRows = false;
            dgvCrops.AllowUserToDeleteRows = false;
            dgvCrops.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvCrops.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCrops.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCrops.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCrops.Columns.AddRange(new DataGridViewColumn[] { colCropId, colCropName, colCropDescription });
            dgvCrops.Location = new Point(7, 7);
            dgvCrops.Margin = new Padding(4, 3, 4, 3);
            dgvCrops.Name = "dgvCrops";
            dgvCrops.ReadOnly = true;
            dgvCrops.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCrops.Size = new Size(488, 557);
            dgvCrops.TabIndex = 0;
            // 
            // colCropId
            // 
            colCropId.DataPropertyName = "Id";
            colCropId.HeaderText = "ID";
            colCropId.Name = "colCropId";
            colCropId.ReadOnly = true;
            colCropId.Width = 50;
            // 
            // colCropName
            // 
            colCropName.DataPropertyName = "Name";
            colCropName.HeaderText = "Name";
            colCropName.Name = "colCropName";
            colCropName.ReadOnly = true;
            // 
            // colCropDescription
            // 
            colCropDescription.DataPropertyName = "Duration";
            colCropDescription.HeaderText = "Duration";
            colCropDescription.Name = "colCropDescription";
            colCropDescription.ReadOnly = true;
            // 
            // tabProductRequests
            // 
            tabProductRequests.Controls.Add(btnRejectRequest);
            tabProductRequests.Controls.Add(btnApproveRequest);
            tabProductRequests.Controls.Add(dgvProductRequests);
            tabProductRequests.Location = new Point(4, 24);
            tabProductRequests.Margin = new Padding(4, 3, 4, 3);
            tabProductRequests.Name = "tabProductRequests";
            tabProductRequests.Padding = new Padding(4, 3, 4, 3);
            tabProductRequests.Size = new Size(1140, 573);
            tabProductRequests.TabIndex = 4;
            tabProductRequests.Text = "Product Requests";
            tabProductRequests.UseVisualStyleBackColor = true;
            // 
            // btnRejectRequest
            // 
            btnRejectRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRejectRequest.BackColor = Color.FromArgb(255, 128, 0);
            btnRejectRequest.FlatStyle = FlatStyle.Flat;
            btnRejectRequest.ForeColor = Color.White;
            btnRejectRequest.Location = new Point(716, 529);
            btnRejectRequest.Margin = new Padding(4, 3, 4, 3);
            btnRejectRequest.Name = "btnRejectRequest";
            btnRejectRequest.Size = new Size(204, 35);
            btnRejectRequest.TabIndex = 2;
            btnRejectRequest.Text = "Reject Request";
            btnRejectRequest.UseVisualStyleBackColor = false;
            // 
            // btnApproveRequest
            // 
            btnApproveRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnApproveRequest.BackColor = Color.FromArgb(0, 192, 0);
            btnApproveRequest.FlatStyle = FlatStyle.Flat;
            btnApproveRequest.ForeColor = Color.White;
            btnApproveRequest.Location = new Point(505, 529);
            btnApproveRequest.Margin = new Padding(4, 3, 4, 3);
            btnApproveRequest.Name = "btnApproveRequest";
            btnApproveRequest.Size = new Size(204, 35);
            btnApproveRequest.TabIndex = 1;
            btnApproveRequest.Text = "Approve Request";
            btnApproveRequest.UseVisualStyleBackColor = false;
            // 
            // dgvProductRequests
            // 
            dgvProductRequests.AllowUserToAddRows = false;
            dgvProductRequests.AllowUserToDeleteRows = false;
            dgvProductRequests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductRequests.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProductRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProductRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductRequests.Columns.AddRange(new DataGridViewColumn[] { colRequestId, colRequestFarmer, colRequestType, colRequestDescription, colRequestStatus });
            dgvProductRequests.Location = new Point(7, 7);
            dgvProductRequests.Margin = new Padding(4, 3, 4, 3);
            dgvProductRequests.Name = "dgvProductRequests";
            dgvProductRequests.ReadOnly = true;
            dgvProductRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductRequests.Size = new Size(1125, 515);
            dgvProductRequests.TabIndex = 0;
            // 
            // colRequestId
            // 
            colRequestId.DataPropertyName = "Id";
            colRequestId.HeaderText = "Request ID";
            colRequestId.Name = "colRequestId";
            colRequestId.ReadOnly = true;
            colRequestId.Width = 70;
            // 
            // colRequestFarmer
            // 
            colRequestFarmer.DataPropertyName = "FarmerName";
            colRequestFarmer.HeaderText = "Farmer";
            colRequestFarmer.Name = "colRequestFarmer";
            colRequestFarmer.ReadOnly = true;
            colRequestFarmer.Width = 120;
            // 
            // colRequestType
            // 
            colRequestType.DataPropertyName = "Type";
            colRequestType.HeaderText = "Type";
            colRequestType.Name = "colRequestType";
            colRequestType.ReadOnly = true;
            // 
            // colRequestDescription
            // 
            colRequestDescription.DataPropertyName = "Name";
            colRequestDescription.HeaderText = "Description";
            colRequestDescription.Name = "colRequestDescription";
            colRequestDescription.ReadOnly = true;
            colRequestDescription.Width = 150;
            // 
            // colRequestStatus
            // 
            colRequestStatus.DataPropertyName = "Status";
            colRequestStatus.HeaderText = "Status";
            colRequestStatus.Name = "colRequestStatus";
            colRequestStatus.ReadOnly = true;
            // 
            // colEquipmentStatus
            // 
            colEquipmentStatus.DataPropertyName = "Status";
            colEquipmentStatus.HeaderText = "Status";
            colEquipmentStatus.Name = "colEquipmentStatus";
            colEquipmentStatus.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLastLogin });
            statusStrip1.Location = new Point(0, 625);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1148, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(61, 17);
            toolStripStatusLabel1.Text = "Last login:";
            // 
            // toolStripStatusLastLogin
            // 
            toolStripStatusLastLogin.Name = "toolStripStatusLastLogin";
            toolStripStatusLastLogin.Size = new Size(41, 17);
            toolStripStatusLastLogin.Text = "[TIME]";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 647);
            Controls.Add(tabControlAdmin);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1164, 686);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmer Management System - Admin Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControlAdmin.ResumeLayout(false);
            tabExpertRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExpertApplications).EndInit();
            tabFraudReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFraudReports).EndInit();
            tabEquipmentCatalog.ResumeLayout(false);
            tabEquipmentCatalog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            tabCropCatalog.ResumeLayout(false);
            tabCropCatalog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCrops).EndInit();
            tabProductRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductRequests).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabExpertRegistration;
        private System.Windows.Forms.TabPage tabFraudReports;
        private System.Windows.Forms.TabPage tabEquipmentCatalog;
        private System.Windows.Forms.TabPage tabCropCatalog;
        private System.Windows.Forms.TabPage tabProductRequests;
        private System.Windows.Forms.DataGridView dgvExpertApplications;
        private System.Windows.Forms.Button btnBanExpert;
        private System.Windows.Forms.Button btnRejectExpert;
        private System.Windows.Forms.Button btnApproveExpert;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpertAppId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpertName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpertEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpertSpecialty;
        private System.Windows.Forms.DataGridViewButtonColumn colExpertDocuments;
        private System.Windows.Forms.Button btnDismissReport;
        private System.Windows.Forms.Button btnBanReportedExpert;
        private System.Windows.Forms.DataGridView dgvFraudReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReportId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFarmerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpertID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReportType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewButtonColumn colStatus;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnUpdateEquipment;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.TextBox txtEquipmentDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipmentDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipmentStatus;
        private System.Windows.Forms.Button btnDeleteCrop;
        private System.Windows.Forms.Button btnUpdateCrop;
        private System.Windows.Forms.Button btnAddCrop;
        private System.Windows.Forms.TextBox txtCropName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCrops;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCropId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCropName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCropDescription;
        private System.Windows.Forms.Button btnRejectRequest;
        private System.Windows.Forms.Button btnApproveRequest;
        private System.Windows.Forms.DataGridView dgvProductRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestFarmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLastLogin;
        private TextBox textBox1;
        private Label label2;
    }
}
