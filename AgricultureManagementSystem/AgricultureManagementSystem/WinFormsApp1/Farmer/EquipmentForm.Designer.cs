namespace AgricultureManagementSystem.Farmer
{
    partial class EquipmentForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelWeather = new Panel();
            btnnewvendor = new Button();
            label12 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            Dob = new DateTimePicker();
            label5 = new Label();
            cmbvendorname = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label8 = new Label();
            cmbrentequipment = new ComboBox();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            button1 = new Button();
            btnowned = new Button();
            label3 = new Label();
            cmbStatus = new ComboBox();
            numericUpDown3 = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            cmbequipment = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnDeleteLand = new Button();
            btnAddLand = new Button();
            txtdes = new TextBox();
            label7 = new Label();
            txtarea = new TextBox();
            Area = new Label();
            lblWeatherHeader = new Label();
            grdEquipments = new DataGridView();
            panel1 = new Panel();
            btnReports = new Button();
            label1 = new Label();
            btnExpertAdvice = new Button();
            btnEquipment = new Button();
            btnMyLands = new Button();
            btnInventory = new Button();
            btnCropSuggestions = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            addStockToolStripMenuItem = new ToolStripMenuItem();
            recordUsageToolStripMenuItem = new ToolStripMenuItem();
            requestAdviceToolStripMenuItem = new ToolStripMenuItem();
            btnwater = new Button();
            panelWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdEquipments).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelWeather
            // 
            panelWeather.BackColor = Color.WhiteSmoke;
            panelWeather.BorderStyle = BorderStyle.FixedSingle;
            panelWeather.Controls.Add(btnnewvendor);
            panelWeather.Controls.Add(label12);
            panelWeather.Controls.Add(dateTimePicker1);
            panelWeather.Controls.Add(label11);
            panelWeather.Controls.Add(Dob);
            panelWeather.Controls.Add(label5);
            panelWeather.Controls.Add(cmbvendorname);
            panelWeather.Controls.Add(numericUpDown1);
            panelWeather.Controls.Add(label6);
            panelWeather.Controls.Add(label8);
            panelWeather.Controls.Add(cmbrentequipment);
            panelWeather.Controls.Add(textBox1);
            panelWeather.Controls.Add(label9);
            panelWeather.Controls.Add(textBox2);
            panelWeather.Controls.Add(label10);
            panelWeather.Controls.Add(button1);
            panelWeather.Controls.Add(btnowned);
            panelWeather.Controls.Add(label3);
            panelWeather.Controls.Add(cmbStatus);
            panelWeather.Controls.Add(numericUpDown3);
            panelWeather.Controls.Add(label2);
            panelWeather.Controls.Add(label4);
            panelWeather.Controls.Add(cmbequipment);
            panelWeather.Controls.Add(btnSearch);
            panelWeather.Controls.Add(txtSearch);
            panelWeather.Controls.Add(btnDeleteLand);
            panelWeather.Controls.Add(btnAddLand);
            panelWeather.Controls.Add(txtdes);
            panelWeather.Controls.Add(label7);
            panelWeather.Controls.Add(txtarea);
            panelWeather.Controls.Add(Area);
            panelWeather.Controls.Add(lblWeatherHeader);
            panelWeather.Controls.Add(grdEquipments);
            panelWeather.Dock = DockStyle.Fill;
            panelWeather.Location = new Point(186, 24);
            panelWeather.Name = "panelWeather";
            panelWeather.Size = new Size(998, 702);
            panelWeather.TabIndex = 15;
            panelWeather.Paint += panelWeather_Paint;
            // 
            // btnnewvendor
            // 
            btnnewvendor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnnewvendor.BackColor = Color.FromArgb(255, 128, 0);
            btnnewvendor.FlatStyle = FlatStyle.Flat;
            btnnewvendor.ForeColor = Color.White;
            btnnewvendor.Location = new Point(697, 654);
            btnnewvendor.Margin = new Padding(4, 3, 4, 3);
            btnnewvendor.Name = "btnnewvendor";
            btnnewvendor.Size = new Size(204, 35);
            btnnewvendor.TabIndex = 92;
            btnnewvendor.Text = "Add New Vendor";
            btnnewvendor.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(27, 441);
            label12.Name = "label12";
            label12.Size = new Size(125, 21);
            label12.TabIndex = 91;
            label12.Text = "Rental End Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 479);
            dateTimePicker1.MaxDate = new DateTime(2030, 5, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 90;
            dateTimePicker1.Value = new DateTime(2010, 5, 1, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(27, 366);
            label11.Name = "label11";
            label11.Size = new Size(133, 21);
            label11.TabIndex = 89;
            label11.Text = "Rental Start Date";
            // 
            // Dob
            // 
            Dob.Location = new Point(27, 404);
            Dob.MaxDate = new DateTime(2030, 5, 1, 0, 0, 0, 0);
            Dob.Name = "Dob";
            Dob.Size = new Size(200, 23);
            Dob.TabIndex = 88;
            Dob.Value = new DateTime(2010, 5, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 291);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 87;
            label5.Text = "Vendor Name";
            // 
            // cmbvendorname
            // 
            cmbvendorname.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbvendorname.FormattingEnabled = true;
            cmbvendorname.Location = new Point(27, 326);
            cmbvendorname.Name = "cmbvendorname";
            cmbvendorname.Size = new Size(201, 23);
            cmbvendorname.TabIndex = 86;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(363, 479);
            numericUpDown1.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(201, 23);
            numericUpDown1.TabIndex = 85;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(363, 441);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 84;
            label6.Text = "Cost";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(367, 291);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 83;
            label8.Text = "Equipment";
            // 
            // cmbrentequipment
            // 
            cmbrentequipment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbrentequipment.FormattingEnabled = true;
            cmbrentequipment.Location = new Point(363, 326);
            cmbrentequipment.Name = "cmbrentequipment";
            cmbrentequipment.Size = new Size(201, 23);
            cmbrentequipment.TabIndex = 82;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(27, 549);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(200, 80);
            textBox1.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(34, 515);
            label9.Name = "label9";
            label9.Size = new Size(94, 21);
            label9.TabIndex = 80;
            label9.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.InfoText;
            textBox2.Location = new Point(362, 400);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 29);
            textBox2.TabIndex = 79;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(363, 366);
            label10.Name = "label10";
            label10.Size = new Size(58, 21);
            label10.TabIndex = 78;
            label10.Text = "Model";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(155, 654);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(146, 35);
            button1.TabIndex = 77;
            button1.Text = "Add Rented";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnowned
            // 
            btnowned.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnowned.BackColor = Color.FromArgb(0, 192, 0);
            btnowned.FlatStyle = FlatStyle.Flat;
            btnowned.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnowned.ForeColor = Color.White;
            btnowned.Location = new Point(730, 559);
            btnowned.Margin = new Padding(4, 3, 4, 3);
            btnowned.Name = "btnowned";
            btnowned.Size = new Size(121, 35);
            btnowned.TabIndex = 76;
            btnowned.Text = "Add Own";
            btnowned.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(698, 446);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 75;
            label3.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(694, 481);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(201, 23);
            cmbStatus.TabIndex = 74;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Location = new Point(698, 256);
            numericUpDown3.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(201, 23);
            numericUpDown3.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(698, 218);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 72;
            label2.Text = "Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(702, 68);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 69;
            label4.Text = "Equipment";
            // 
            // cmbequipment
            // 
            cmbequipment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbequipment.FormattingEnabled = true;
            cmbequipment.Location = new Point(698, 103);
            cmbequipment.Name = "cmbequipment";
            cmbequipment.Size = new Size(201, 23);
            cmbequipment.TabIndex = 68;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(872, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 32);
            btnSearch.TabIndex = 53;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.InfoText;
            txtSearch.Location = new Point(651, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 29);
            txtSearch.TabIndex = 52;
            // 
            // btnDeleteLand
            // 
            btnDeleteLand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteLand.BackColor = Color.FromArgb(192, 0, 0);
            btnDeleteLand.FlatStyle = FlatStyle.Flat;
            btnDeleteLand.ForeColor = Color.White;
            btnDeleteLand.Location = new Point(1356, 1164);
            btnDeleteLand.Margin = new Padding(4, 3, 4, 3);
            btnDeleteLand.Name = "btnDeleteLand";
            btnDeleteLand.Size = new Size(204, 35);
            btnDeleteLand.TabIndex = 51;
            btnDeleteLand.Text = "Delete Land";
            btnDeleteLand.UseVisualStyleBackColor = false;
            // 
            // btnAddLand
            // 
            btnAddLand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddLand.BackColor = Color.FromArgb(0, 192, 0);
            btnAddLand.FlatStyle = FlatStyle.Flat;
            btnAddLand.ForeColor = Color.White;
            btnAddLand.Location = new Point(1071, 1164);
            btnAddLand.Margin = new Padding(4, 3, 4, 3);
            btnAddLand.Name = "btnAddLand";
            btnAddLand.Size = new Size(204, 35);
            btnAddLand.TabIndex = 49;
            btnAddLand.Text = "Add New Land";
            btnAddLand.UseVisualStyleBackColor = false;
            // 
            // txtdes
            // 
            txtdes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtdes.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdes.ForeColor = SystemColors.InfoText;
            txtdes.Location = new Point(698, 335);
            txtdes.Multiline = true;
            txtdes.Name = "txtdes";
            txtdes.ScrollBars = ScrollBars.Vertical;
            txtdes.Size = new Size(200, 80);
            txtdes.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(705, 301);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 47;
            label7.Text = "Description";
            // 
            // txtarea
            // 
            txtarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtarea.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtarea.ForeColor = SystemColors.InfoText;
            txtarea.Location = new Point(697, 177);
            txtarea.Name = "txtarea";
            txtarea.Size = new Size(200, 29);
            txtarea.TabIndex = 36;
            // 
            // Area
            // 
            Area.AutoSize = true;
            Area.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Area.Location = new Point(698, 143);
            Area.Name = "Area";
            Area.Size = new Size(58, 21);
            Area.TabIndex = 35;
            Area.Text = "Model";
            // 
            // lblWeatherHeader
            // 
            lblWeatherHeader.AutoSize = true;
            lblWeatherHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWeatherHeader.Location = new Point(10, 10);
            lblWeatherHeader.Name = "lblWeatherHeader";
            lblWeatherHeader.Size = new Size(224, 20);
            lblWeatherHeader.TabIndex = 0;
            lblWeatherHeader.Text = "🛠️ Farm Equipment Inventory";
            // 
            // grdEquipments
            // 
            grdEquipments.AllowUserToAddRows = false;
            grdEquipments.AllowUserToResizeRows = false;
            grdEquipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdEquipments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            grdEquipments.DefaultCellStyle = dataGridViewCellStyle4;
            grdEquipments.Location = new Point(2, 41);
            grdEquipments.Name = "grdEquipments";
            grdEquipments.ReadOnly = true;
            grdEquipments.RowHeadersVisible = false;
            grdEquipments.Size = new Size(636, 230);
            grdEquipments.TabIndex = 1;
            grdEquipments.CellContentClick += grdlands_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnwater);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExpertAdvice);
            panel1.Controls.Add(btnEquipment);
            panel1.Controls.Add(btnMyLands);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(btnCropSuggestions);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 702);
            panel1.TabIndex = 14;
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
            btnReports.Location = new Point(0, 278);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(180, 33);
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
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(180, 50);
            label1.TabIndex = 0;
            label1.Text = "Dashboard\r\n________________________";
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
            btnExpertAdvice.Location = new Point(3, 336);
            btnExpertAdvice.Name = "btnExpertAdvice";
            btnExpertAdvice.Size = new Size(180, 33);
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
            btnEquipment.Location = new Point(-3, 389);
            btnEquipment.Name = "btnEquipment";
            btnEquipment.Size = new Size(180, 33);
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
            btnMyLands.Location = new Point(0, 219);
            btnMyLands.Name = "btnMyLands";
            btnMyLands.Size = new Size(180, 33);
            btnMyLands.TabIndex = 0;
            btnMyLands.Text = "🌱 My Lands";
            btnMyLands.TextAlign = ContentAlignment.BottomCenter;
            btnMyLands.UseVisualStyleBackColor = false;
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
            btnInventory.Location = new Point(0, 106);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(180, 33);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "📦 Stock Inventory";
            btnInventory.TextAlign = ContentAlignment.BottomCenter;
            btnInventory.UseVisualStyleBackColor = false;
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
            btnCropSuggestions.Location = new Point(3, 162);
            btnCropSuggestions.Name = "btnCropSuggestions";
            btnCropSuggestions.Size = new Size(180, 33);
            btnCropSuggestions.TabIndex = 1;
            btnCropSuggestions.Text = "📊 Crop Section";
            btnCropSuggestions.TextAlign = ContentAlignment.BottomCenter;
            btnCropSuggestions.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(23, 24, 29);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStockToolStripMenuItem, recordUsageToolStripMenuItem, requestAdviceToolStripMenuItem });
            actionsToolStripMenuItem.ForeColor = Color.White;
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(59, 20);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // addStockToolStripMenuItem
            // 
            addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            addStockToolStripMenuItem.Size = new Size(155, 22);
            addStockToolStripMenuItem.Text = "Add Stock";
            // 
            // recordUsageToolStripMenuItem
            // 
            recordUsageToolStripMenuItem.Name = "recordUsageToolStripMenuItem";
            recordUsageToolStripMenuItem.Size = new Size(155, 22);
            recordUsageToolStripMenuItem.Text = "Record Usage";
            // 
            // requestAdviceToolStripMenuItem
            // 
            requestAdviceToolStripMenuItem.Name = "requestAdviceToolStripMenuItem";
            requestAdviceToolStripMenuItem.Size = new Size(155, 22);
            requestAdviceToolStripMenuItem.Text = "Request Advice";
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
            btnwater.Location = new Point(3, 447);
            btnwater.Name = "btnwater";
            btnwater.Size = new Size(180, 33);
            btnwater.TabIndex = 7;
            btnwater.Text = "🚰 Water Resources ";
            btnwater.TextAlign = ContentAlignment.BottomCenter;
            btnwater.UseVisualStyleBackColor = false;
            // 
            // EquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 726);
            Controls.Add(panelWeather);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "EquipmentForm";
            Text = "EquipmentForm";
            panelWeather.ResumeLayout(false);
            panelWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdEquipments).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelWeather;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnDeleteLand;
        private Button btnAddLand;
        private TextBox txtdes;
        private Label label7;
        private TextBox txtarea;
        private Label Area;
        private Label lblWeatherHeader;
        private DataGridView grdEquipments;
        private Panel panel1;
        private Button btnReports;
        private Label label1;
        private Button btnExpertAdvice;
        private Button btnEquipment;
        private Button btnMyLands;
        private Button btnInventory;
        private Button btnCropSuggestions;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem addStockToolStripMenuItem;
        private ToolStripMenuItem recordUsageToolStripMenuItem;
        private ToolStripMenuItem requestAdviceToolStripMenuItem;
        private NumericUpDown numericUpDown3;
        private Label label2;
        private Label label4;
        private ComboBox cmbequipment;
        private Label label3;
        private ComboBox cmbStatus;
        private Button btnowned;
        private Label label5;
        private ComboBox cmbvendorname;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label8;
        private ComboBox cmbrentequipment;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox2;
        private Label label10;
        private Button button1;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private DateTimePicker Dob;
        private Button btnnewvendor;
        private Button btnwater;
    }
}