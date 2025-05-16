namespace AgricultureManagementSystem
{
    partial class FarmerDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            generateReportToolStripMenuItem = new ToolStripMenuItem();
            panelWeather = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            lblWelcome = new Label();
            lblWeatherHeader = new Label();
            dgvWeatherForecast = new DataGridView();
            panelRight = new Panel();
            lblAlerts = new Label();
            lstAlerts = new ListBox();
            lblStorage = new Label();
            progressStorage = new ProgressBar();
            lblSeason = new Label();
            progressSeason = new ProgressBar();
            dataGridViewRecent = new DataGridView();
            panel1 = new Panel();
            btnagriproducts = new Button();
            pictureBox1 = new PictureBox();
            btnwater = new Button();
            btnReports = new Button();
            label1 = new Label();
            btnExpertAdvice = new Button();
            btnEquipment = new Button();
            btnMyLands = new Button();
            btnInventory = new Button();
            btnCropSuggestions = new Button();
            menuStrip1.SuspendLayout();
            panelWeather.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWeatherForecast).BeginInit();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecent).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(23, 24, 29);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1797, 35);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(171, 34);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(171, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateReportToolStripMenuItem });
            actionsToolStripMenuItem.ForeColor = Color.White;
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(81, 29);
            actionsToolStripMenuItem.Text = "Report";
            // 
            // generateReportToolStripMenuItem
            // 
            generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            generateReportToolStripMenuItem.Size = new Size(270, 34);
            generateReportToolStripMenuItem.Text = "Generate Report";
            generateReportToolStripMenuItem.Click += generateReportToolStripMenuItem_Click;
            // 
            // panelWeather
            // 
            panelWeather.BackColor = Color.WhiteSmoke;
            panelWeather.BorderStyle = BorderStyle.FixedSingle;
            panelWeather.Controls.Add(panel2);
            panelWeather.Controls.Add(lblWeatherHeader);
            panelWeather.Controls.Add(dgvWeatherForecast);
            panelWeather.Dock = DockStyle.Fill;
            panelWeather.Location = new Point(266, 35);
            panelWeather.Margin = new Padding(4, 5, 4, 5);
            panelWeather.Name = "panelWeather";
            panelWeather.Size = new Size(1102, 850);
            panelWeather.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblWelcome);
            panel2.Location = new Point(14, 15);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1071, 286);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = Properties.Resources.farmer_3474718;
            pictureBox2.Location = new Point(863, 97);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(854, 187);
            label2.TabIndex = 11;
            label2.Text = "Let's grow smarter together. Your farm data, insights, and expert help—right at your fingertips!\"";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(1069, 97);
            lblWelcome.TabIndex = 10;
            lblWelcome.Text = "Welcome, {user}🌿";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWeatherHeader
            // 
            lblWeatherHeader.AutoSize = true;
            lblWeatherHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWeatherHeader.Location = new Point(14, 345);
            lblWeatherHeader.Margin = new Padding(4, 0, 4, 0);
            lblWeatherHeader.Name = "lblWeatherHeader";
            lblWeatherHeader.Size = new Size(299, 30);
            lblWeatherHeader.TabIndex = 0;
            lblWeatherHeader.Text = "📅 5-Day Weather Forecast";
            // 
            // dgvWeatherForecast
            // 
            dgvWeatherForecast.AllowUserToAddRows = false;
            dgvWeatherForecast.AllowUserToResizeRows = false;
            dgvWeatherForecast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvWeatherForecast.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvWeatherForecast.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvWeatherForecast.DefaultCellStyle = dataGridViewCellStyle2;
            dgvWeatherForecast.Location = new Point(14, 395);
            dgvWeatherForecast.Margin = new Padding(4, 5, 4, 5);
            dgvWeatherForecast.Name = "dgvWeatherForecast";
            dgvWeatherForecast.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvWeatherForecast.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvWeatherForecast.RowHeadersVisible = false;
            dgvWeatherForecast.RowHeadersWidth = 62;
            dgvWeatherForecast.Size = new Size(1071, 383);
            dgvWeatherForecast.TabIndex = 1;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(lblAlerts);
            panelRight.Controls.Add(lstAlerts);
            panelRight.Controls.Add(lblStorage);
            panelRight.Controls.Add(progressStorage);
            panelRight.Controls.Add(lblSeason);
            panelRight.Controls.Add(progressSeason);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(1368, 35);
            panelRight.Margin = new Padding(4, 5, 4, 5);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(429, 850);
            panelRight.TabIndex = 15;
            // 
            // lblAlerts
            // 
            lblAlerts.AutoSize = true;
            lblAlerts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAlerts.Location = new Point(14, 17);
            lblAlerts.Margin = new Padding(4, 0, 4, 0);
            lblAlerts.Name = "lblAlerts";
            lblAlerts.Size = new Size(145, 28);
            lblAlerts.TabIndex = 0;
            lblAlerts.Text = "Urgent Alerts:";
            // 
            // lstAlerts
            // 
            lstAlerts.ItemHeight = 25;
            lstAlerts.Items.AddRange(new object[] { "Silo 95% full!", "Wheat expiring in 5 days" });
            lstAlerts.Location = new Point(14, 67);
            lstAlerts.Margin = new Padding(4, 5, 4, 5);
            lstAlerts.Name = "lstAlerts";
            lstAlerts.Size = new Size(384, 79);
            lstAlerts.TabIndex = 1;
            // 
            // lblStorage
            // 
            lblStorage.AutoSize = true;
            lblStorage.Location = new Point(14, 183);
            lblStorage.Margin = new Padding(4, 0, 4, 0);
            lblStorage.Name = "lblStorage";
            lblStorage.Size = new Size(145, 25);
            lblStorage.TabIndex = 2;
            lblStorage.Text = "Storage Capacity";
            // 
            // progressStorage
            // 
            progressStorage.BackColor = Color.FromArgb(129, 199, 132);
            progressStorage.Location = new Point(14, 217);
            progressStorage.Margin = new Padding(4, 5, 4, 5);
            progressStorage.Name = "progressStorage";
            progressStorage.Size = new Size(386, 33);
            progressStorage.TabIndex = 3;
            progressStorage.Value = 95;
            // 
            // lblSeason
            // 
            lblSeason.AutoSize = true;
            lblSeason.Location = new Point(14, 283);
            lblSeason.Margin = new Padding(4, 0, 4, 0);
            lblSeason.Name = "lblSeason";
            lblSeason.Size = new Size(143, 25);
            lblSeason.TabIndex = 4;
            lblSeason.Text = "Season Progress";
            // 
            // progressSeason
            // 
            progressSeason.BackColor = Color.FromArgb(129, 199, 132);
            progressSeason.Location = new Point(14, 317);
            progressSeason.Margin = new Padding(4, 5, 4, 5);
            progressSeason.Name = "progressSeason";
            progressSeason.Size = new Size(386, 33);
            progressSeason.TabIndex = 5;
            progressSeason.Value = 40;
            // 
            // dataGridViewRecent
            // 
            dataGridViewRecent.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewRecent.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewRecent.Dock = DockStyle.Bottom;
            dataGridViewRecent.Location = new Point(266, 885);
            dataGridViewRecent.Margin = new Padding(4, 5, 4, 5);
            dataGridViewRecent.Name = "dataGridViewRecent";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewRecent.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewRecent.RowHeadersWidth = 62;
            dataGridViewRecent.Size = new Size(1531, 198);
            dataGridViewRecent.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnagriproducts);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnwater);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExpertAdvice);
            panel1.Controls.Add(btnEquipment);
            panel1.Controls.Add(btnMyLands);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(btnCropSuggestions);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 35);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 1048);
            panel1.TabIndex = 13;
            // 
            // btnagriproducts
            // 
            btnagriproducts.Anchor = AnchorStyles.None;
            btnagriproducts.BackColor = Color.Transparent;
            btnagriproducts.FlatAppearance.BorderColor = Color.White;
            btnagriproducts.FlatAppearance.MouseDownBackColor = Color.White;
            btnagriproducts.FlatAppearance.MouseOverBackColor = Color.White;
            btnagriproducts.FlatStyle = FlatStyle.Flat;
            btnagriproducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnagriproducts.ForeColor = Color.FromArgb(23, 24, 29);
            btnagriproducts.ImageAlign = ContentAlignment.TopCenter;
            btnagriproducts.Location = new Point(0, 378);
            btnagriproducts.Margin = new Padding(4, 5, 4, 5);
            btnagriproducts.Name = "btnagriproducts";
            btnagriproducts.Size = new Size(257, 55);
            btnagriproducts.TabIndex = 9;
            btnagriproducts.Text = "🚜 Agri Products";
            btnagriproducts.TextAlign = ContentAlignment.BottomCenter;
            btnagriproducts.UseVisualStyleBackColor = false;
            btnagriproducts.Click += btnagriproducts_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.farmer_icon;
            pictureBox1.Location = new Point(33, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnwater
            // 
            btnwater.Anchor = AnchorStyles.None;
            btnwater.BackColor = Color.Transparent;
            btnwater.FlatAppearance.BorderColor = Color.White;
            btnwater.FlatAppearance.MouseDownBackColor = Color.White;
            btnwater.FlatAppearance.MouseOverBackColor = Color.White;
            btnwater.FlatStyle = FlatStyle.Flat;
            btnwater.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnwater.ForeColor = Color.FromArgb(23, 24, 29);
            btnwater.ImageAlign = ContentAlignment.TopCenter;
            btnwater.Location = new Point(9, 531);
            btnwater.Margin = new Padding(4, 5, 4, 5);
            btnwater.Name = "btnwater";
            btnwater.Size = new Size(257, 55);
            btnwater.TabIndex = 7;
            btnwater.Text = "🚰 Water Resources ";
            btnwater.TextAlign = ContentAlignment.BottomCenter;
            btnwater.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.Anchor = AnchorStyles.None;
            btnReports.BackColor = Color.Transparent;
            btnReports.FlatAppearance.BorderColor = Color.White;
            btnReports.FlatAppearance.MouseDownBackColor = Color.White;
            btnReports.FlatAppearance.MouseOverBackColor = Color.White;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReports.ForeColor = Color.FromArgb(23, 24, 29);
            btnReports.ImageAlign = ContentAlignment.TopCenter;
            btnReports.Location = new Point(0, 616);
            btnReports.Margin = new Padding(4, 5, 4, 5);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(257, 55);
            btnReports.TabIndex = 5;
            btnReports.Text = "📑 Reports";
            btnReports.TextAlign = ContentAlignment.BottomCenter;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(23, 24, 29);
            label1.Location = new Point(4, 130);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 72);
            label1.TabIndex = 0;
            label1.Text = "\r\n________________________";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExpertAdvice
            // 
            btnExpertAdvice.Anchor = AnchorStyles.None;
            btnExpertAdvice.BackColor = Color.Transparent;
            btnExpertAdvice.FlatAppearance.BorderColor = Color.White;
            btnExpertAdvice.FlatAppearance.MouseDownBackColor = Color.White;
            btnExpertAdvice.FlatAppearance.MouseOverBackColor = Color.White;
            btnExpertAdvice.FlatStyle = FlatStyle.Flat;
            btnExpertAdvice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExpertAdvice.ForeColor = Color.FromArgb(23, 24, 29);
            btnExpertAdvice.ImageAlign = ContentAlignment.TopCenter;
            btnExpertAdvice.Location = new Point(0, 698);
            btnExpertAdvice.Margin = new Padding(4, 5, 4, 5);
            btnExpertAdvice.Name = "btnExpertAdvice";
            btnExpertAdvice.Size = new Size(257, 55);
            btnExpertAdvice.TabIndex = 4;
            btnExpertAdvice.Text = "💬 Expert Advice";
            btnExpertAdvice.TextAlign = ContentAlignment.BottomCenter;
            btnExpertAdvice.UseVisualStyleBackColor = false;
            // 
            // btnEquipment
            // 
            btnEquipment.Anchor = AnchorStyles.None;
            btnEquipment.BackColor = Color.Transparent;
            btnEquipment.FlatAppearance.BorderColor = Color.White;
            btnEquipment.FlatAppearance.MouseDownBackColor = Color.White;
            btnEquipment.FlatAppearance.MouseOverBackColor = Color.White;
            btnEquipment.FlatStyle = FlatStyle.Flat;
            btnEquipment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEquipment.ForeColor = Color.FromArgb(23, 24, 29);
            btnEquipment.ImageAlign = ContentAlignment.TopCenter;
            btnEquipment.Location = new Point(0, 456);
            btnEquipment.Margin = new Padding(4, 5, 4, 5);
            btnEquipment.Name = "btnEquipment";
            btnEquipment.Size = new Size(257, 55);
            btnEquipment.TabIndex = 3;
            btnEquipment.Text = "🔧 Equipment";
            btnEquipment.TextAlign = ContentAlignment.BottomCenter;
            btnEquipment.UseVisualStyleBackColor = false;
            // 
            // btnMyLands
            // 
            btnMyLands.Anchor = AnchorStyles.None;
            btnMyLands.BackColor = Color.Transparent;
            btnMyLands.FlatAppearance.BorderColor = Color.White;
            btnMyLands.FlatAppearance.MouseDownBackColor = Color.White;
            btnMyLands.FlatAppearance.MouseOverBackColor = Color.White;
            btnMyLands.FlatStyle = FlatStyle.Flat;
            btnMyLands.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMyLands.ForeColor = Color.FromArgb(23, 24, 29);
            btnMyLands.ImageAlign = ContentAlignment.TopCenter;
            btnMyLands.Location = new Point(1, 253);
            btnMyLands.Margin = new Padding(4, 5, 4, 5);
            btnMyLands.Name = "btnMyLands";
            btnMyLands.Size = new Size(257, 55);
            btnMyLands.TabIndex = 0;
            btnMyLands.Text = "🌱 My Lands";
            btnMyLands.TextAlign = ContentAlignment.BottomCenter;
            btnMyLands.UseVisualStyleBackColor = false;
            btnMyLands.Click += btnMyLands_Click_1;
            // 
            // btnInventory
            // 
            btnInventory.Anchor = AnchorStyles.None;
            btnInventory.BackColor = Color.Transparent;
            btnInventory.FlatAppearance.BorderColor = Color.White;
            btnInventory.FlatAppearance.MouseDownBackColor = Color.White;
            btnInventory.FlatAppearance.MouseOverBackColor = Color.White;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInventory.ForeColor = Color.FromArgb(23, 24, 29);
            btnInventory.ImageAlign = ContentAlignment.TopCenter;
            btnInventory.Location = new Point(4, 313);
            btnInventory.Margin = new Padding(4, 5, 4, 5);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(257, 55);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "📦 Stock Inventory";
            btnInventory.TextAlign = ContentAlignment.BottomCenter;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click_1;
            // 
            // btnCropSuggestions
            // 
            btnCropSuggestions.Anchor = AnchorStyles.None;
            btnCropSuggestions.BackColor = Color.Transparent;
            btnCropSuggestions.FlatAppearance.BorderColor = Color.White;
            btnCropSuggestions.FlatAppearance.MouseDownBackColor = Color.White;
            btnCropSuggestions.FlatAppearance.MouseOverBackColor = Color.White;
            btnCropSuggestions.FlatStyle = FlatStyle.Flat;
            btnCropSuggestions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCropSuggestions.ForeColor = Color.FromArgb(23, 24, 29);
            btnCropSuggestions.ImageAlign = ContentAlignment.TopCenter;
            btnCropSuggestions.Location = new Point(9, 763);
            btnCropSuggestions.Margin = new Padding(4, 5, 4, 5);
            btnCropSuggestions.Name = "btnCropSuggestions";
            btnCropSuggestions.Size = new Size(257, 55);
            btnCropSuggestions.TabIndex = 1;
            btnCropSuggestions.Text = "📊 Crop Suggestions";
            btnCropSuggestions.TextAlign = ContentAlignment.BottomCenter;
            btnCropSuggestions.UseVisualStyleBackColor = false;
            // 
            // FarmerDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 245, 233);
            ClientSize = new Size(1797, 1083);
            Controls.Add(panelWeather);
            Controls.Add(panelRight);
            Controls.Add(dataGridViewRecent);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1133, 963);
            Name = "FarmerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmer Dashboard";
            Load += FarmerDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelWeather.ResumeLayout(false);
            panelWeather.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWeatherForecast).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label lblCity;
        private PictureBox picWeatherIcon;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeatherDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeatherDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeatherCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeatherHighTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeatherLowTemp;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private Panel panelWeather;
        private Label lblWeatherHeader;
        private Panel panelRight;
        private Label lblAlerts;
        private ListBox lstAlerts;
        private Label lblStorage;
        private ProgressBar progressStorage;
        private Label lblSeason;
        private ProgressBar progressSeason;
        private DataGridView dataGridViewRecent;
        private Panel panel1;
        private Button btnwater;
        private Button btnReports;
        private Label label1;
        private Button btnExpertAdvice;
        private Button btnEquipment;
        private Button btnMyLands;
        private Button btnInventory;
        private Button btnCropSuggestions;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lblWelcome;
        private Label label2;
        private DataGridView dgvWeatherForecast;
        private PictureBox pictureBox2;
        private Button btnagriproducts;
        private ToolStripMenuItem generateReportToolStripMenuItem;
    }
}