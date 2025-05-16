using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgricultureManagementSystem.BL;
using AgricultureManagementSystem.DL;
using Org.BouncyCastle.Asn1.X509;

namespace AgricultureManagementSystem.Farmer
{
    public partial class StockForm : Form
    {
        private decimal HavestedTotal;
        private decimal PurchedTotal;
        FarmerProfile profile = new FarmerProfile();
        private int selectedBatchId = -1; // Track the selected batch ID
        public StockForm(FarmerProfile farmer)
        {

            InitializeComponent();
            profile = farmer;
            this.Size = new Size(1360, 860); // Set your desired default size
            this.StartPosition = FormStartPosition.CenterScreen; // Optional: center
            loadcombo();
            Loadgrid();
            HavestedTotal = 0;
            PurchedTotal = 0;

            List<CropStock> lands = CropBatchDL.GetCropStocksByFarmer(profile.FarmerID);
            foreach (var l in lands)
            {
                if (l.Purpose == "Harvested")
                {
                    HavestedTotal = HavestedTotal + (l.Quantity * l.Price);
                }
                else if (l.Purpose == "Purchased")
                {
                    PurchedTotal = PurchedTotal + (l.Quantity * l.Price);
                }
            }
            lblTotal.Text = $"Harvested Total : {HavestedTotal}       " +
                $"Purchased Total : {PurchedTotal}";
        }
        private int ID = -1;
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            addStockToolStripMenuItem = new ToolStripMenuItem();
            recordUsageToolStripMenuItem = new ToolStripMenuItem();
            requestAdviceToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btndashboard = new Button();
            label1 = new Label();
            tabControlExpert = new TabControl();
            tabAdd = new TabPage();
            lblTotal = new Label();
            btndelelte = new Button();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtLocation = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblWeatherHeader = new Label();
            grdstock = new DataGridView();
            cmbpurpose = new ComboBox();
            label3 = new Label();
            label8 = new Label();
            cmbcrop = new ComboBox();
            btnaddstock = new Button();
            tabremovestock = new TabPage();
            btnDeletestock = new Button();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            numericUpDown4 = new NumericUpDown();
            label9 = new Label();
            label11 = new Label();
            comboBox2 = new ComboBox();
            comboBox5 = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            comboBox6 = new ComboBox();
            btnSubmitResponse = new Button();
            txtResponse = new TextBox();
            label10 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            tabControlExpert.SuspendLayout();
            tabAdd.SuspendLayout();
            ((ISupportInitialize)grdstock).BeginInit();
            tabremovestock.SuspendLayout();
            ((ISupportInitialize)numericUpDown2).BeginInit();
            ((ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(23, 24, 29);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1402, 33);
            menuStrip1.TabIndex = 10;
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
            logoutToolStripMenuItem.Size = new Size(270, 34);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStockToolStripMenuItem, recordUsageToolStripMenuItem, requestAdviceToolStripMenuItem });
            actionsToolStripMenuItem.ForeColor = Color.White;
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(87, 29);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // addStockToolStripMenuItem
            // 
            addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            addStockToolStripMenuItem.Size = new Size(235, 34);
            addStockToolStripMenuItem.Text = "Add Stock";
            // 
            // recordUsageToolStripMenuItem
            // 
            recordUsageToolStripMenuItem.Name = "recordUsageToolStripMenuItem";
            recordUsageToolStripMenuItem.Size = new Size(235, 34);
            recordUsageToolStripMenuItem.Text = "Record Usage";
            // 
            // requestAdviceToolStripMenuItem
            // 
            requestAdviceToolStripMenuItem.Name = "requestAdviceToolStripMenuItem";
            requestAdviceToolStripMenuItem.Size = new Size(235, 34);
            requestAdviceToolStripMenuItem.Text = "Request Advice";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btndashboard);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 802);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.farmer_icon;
            pictureBox1.Location = new Point(20, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btndashboard
            // 
            btndashboard.Anchor = AnchorStyles.None;
            btndashboard.BackColor = Color.Transparent;
            btndashboard.FlatAppearance.BorderColor = Color.White;
            btndashboard.FlatAppearance.MouseDownBackColor = Color.White;
            btndashboard.FlatAppearance.MouseOverBackColor = Color.White;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btndashboard.ForeColor = Color.FromArgb(23, 24, 29);
            btndashboard.ImageAlign = ContentAlignment.TopCenter;
            btndashboard.Location = new Point(2, 233);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(180, 33);
            btndashboard.TabIndex = 19;
            btndashboard.Text = "🖥️ Dashboard";
            btndashboard.TextAlign = ContentAlignment.BottomCenter;
            btndashboard.UseVisualStyleBackColor = false;
            btndashboard.Click += btndashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(23, 24, 29);
            label1.Location = new Point(2, 79);
            label1.Name = "label1";
            label1.Size = new Size(279, 72);
            label1.TabIndex = 10;
            label1.Text = "\r\n________________________";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControlExpert
            // 
            tabControlExpert.Controls.Add(tabAdd);
            tabControlExpert.Controls.Add(tabremovestock);
            tabControlExpert.Dock = DockStyle.Fill;
            tabControlExpert.Location = new Point(186, 33);
            tabControlExpert.Margin = new Padding(4, 3, 4, 3);
            tabControlExpert.Name = "tabControlExpert";
            tabControlExpert.SelectedIndex = 0;
            tabControlExpert.Size = new Size(1216, 802);
            tabControlExpert.TabIndex = 13;
            // 
            // tabAdd
            // 
            tabAdd.BackColor = Color.WhiteSmoke;
            tabAdd.Controls.Add(lblTotal);
            tabAdd.Controls.Add(btndelelte);
            tabAdd.Controls.Add(txtPrice);
            tabAdd.Controls.Add(txtQuantity);
            tabAdd.Controls.Add(txtLocation);
            tabAdd.Controls.Add(label6);
            tabAdd.Controls.Add(label7);
            tabAdd.Controls.Add(label5);
            tabAdd.Controls.Add(btnSearch);
            tabAdd.Controls.Add(txtSearch);
            tabAdd.Controls.Add(lblWeatherHeader);
            tabAdd.Controls.Add(grdstock);
            tabAdd.Controls.Add(cmbpurpose);
            tabAdd.Controls.Add(label3);
            tabAdd.Controls.Add(label8);
            tabAdd.Controls.Add(cmbcrop);
            tabAdd.Controls.Add(btnaddstock);
            tabAdd.Location = new Point(4, 34);
            tabAdd.Margin = new Padding(4, 3, 4, 3);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(4, 3, 4, 3);
            tabAdd.Size = new Size(1208, 764);
            tabAdd.TabIndex = 2;
            tabAdd.Text = "Add stock";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotal.Location = new Point(47, 640);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(71, 26);
            lblTotal.TabIndex = 72;
            lblTotal.Text = "label2";
            // 
            // btndelelte
            // 
            btndelelte.BackColor = Color.FromArgb(0, 192, 0);
            btndelelte.FlatStyle = FlatStyle.Flat;
            btndelelte.ForeColor = Color.White;
            btndelelte.Location = new Point(587, 539);
            btndelelte.Margin = new Padding(4, 3, 4, 3);
            btndelelte.Name = "btndelelte";
            btndelelte.Size = new Size(117, 35);
            btndelelte.TabIndex = 71;
            btndelelte.Text = "Delete";
            btndelelte.UseVisualStyleBackColor = false;
            btndelelte.Click += btndelelte_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(259, 444);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(194, 31);
            txtPrice.TabIndex = 70;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(35, 444);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(185, 31);
            txtQuantity.TabIndex = 69;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(539, 341);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(229, 31);
            txtLocation.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(259, 400);
            label6.Name = "label6";
            label6.Size = new Size(67, 32);
            label6.TabIndex = 66;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 404);
            label7.Name = "label7";
            label7.Size = new Size(160, 32);
            label7.TabIndex = 64;
            label7.Text = "Quantity / kg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(543, 294);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 63;
            label5.Text = "Location";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(773, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 32);
            btnSearch.TabIndex = 59;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.InfoText;
            txtSearch.Location = new Point(552, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(534, 40);
            txtSearch.TabIndex = 58;
            // 
            // lblWeatherHeader
            // 
            lblWeatherHeader.AutoSize = true;
            lblWeatherHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWeatherHeader.Location = new Point(0, 17);
            lblWeatherHeader.Name = "lblWeatherHeader";
            lblWeatherHeader.Size = new Size(298, 30);
            lblWeatherHeader.TabIndex = 56;
            lblWeatherHeader.Text = "🏬 Current Stock Inventory";
            // 
            // grdstock
            // 
            grdstock.AllowUserToAddRows = false;
            grdstock.AllowUserToResizeRows = false;
            grdstock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdstock.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdstock.DefaultCellStyle = dataGridViewCellStyle2;
            grdstock.Location = new Point(0, 47);
            grdstock.Name = "grdstock";
            grdstock.ReadOnly = true;
            grdstock.RowHeadersVisible = false;
            grdstock.RowHeadersWidth = 62;
            grdstock.Size = new Size(750, 230);
            grdstock.TabIndex = 57;
            grdstock.CellContentClick += grdstock_CellContentClick;
            // 
            // cmbpurpose
            // 
            cmbpurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbpurpose.FormattingEnabled = true;
            cmbpurpose.Items.AddRange(new object[] { "Harvested", "Purchased" });
            cmbpurpose.Location = new Point(270, 331);
            cmbpurpose.Name = "cmbpurpose";
            cmbpurpose.Size = new Size(201, 33);
            cmbpurpose.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(286, 295);
            label3.Name = "label3";
            label3.Size = new Size(102, 32);
            label3.TabIndex = 24;
            label3.Text = "Purpose";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 294);
            label8.Name = "label8";
            label8.Size = new Size(138, 32);
            label8.TabIndex = 22;
            label8.Text = "Crop Name";
            // 
            // cmbcrop
            // 
            cmbcrop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbcrop.FormattingEnabled = true;
            cmbcrop.Location = new Point(19, 331);
            cmbcrop.Name = "cmbcrop";
            cmbcrop.Size = new Size(201, 33);
            cmbcrop.TabIndex = 21;
            // 
            // btnaddstock
            // 
            btnaddstock.BackColor = Color.FromArgb(0, 192, 0);
            btnaddstock.FlatStyle = FlatStyle.Flat;
            btnaddstock.ForeColor = Color.White;
            btnaddstock.Location = new Point(415, 539);
            btnaddstock.Margin = new Padding(4, 3, 4, 3);
            btnaddstock.Name = "btnaddstock";
            btnaddstock.Size = new Size(117, 35);
            btnaddstock.TabIndex = 7;
            btnaddstock.Text = "Add new stock";
            btnaddstock.UseVisualStyleBackColor = false;
            btnaddstock.Click += btnaddstock_Click_1;
            // 
            // tabremovestock
            // 
            tabremovestock.Controls.Add(btnDeletestock);
            tabremovestock.Controls.Add(numericUpDown2);
            tabremovestock.Controls.Add(label4);
            tabremovestock.Controls.Add(numericUpDown4);
            tabremovestock.Controls.Add(label9);
            tabremovestock.Controls.Add(label11);
            tabremovestock.Controls.Add(comboBox2);
            tabremovestock.Controls.Add(comboBox5);
            tabremovestock.Controls.Add(label13);
            tabremovestock.Controls.Add(label14);
            tabremovestock.Controls.Add(comboBox6);
            tabremovestock.Controls.Add(btnSubmitResponse);
            tabremovestock.Controls.Add(txtResponse);
            tabremovestock.Controls.Add(label10);
            tabremovestock.Location = new Point(4, 34);
            tabremovestock.Margin = new Padding(5, 3, 5, 3);
            tabremovestock.Name = "tabremovestock";
            tabremovestock.Padding = new Padding(5, 3, 5, 3);
            tabremovestock.Size = new Size(1208, 764);
            tabremovestock.TabIndex = 1;
            tabremovestock.Text = "Record Usage";
            tabremovestock.UseVisualStyleBackColor = true;
            // 
            // btnDeletestock
            // 
            btnDeletestock.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeletestock.BackColor = Color.FromArgb(192, 0, 0);
            btnDeletestock.FlatStyle = FlatStyle.Flat;
            btnDeletestock.ForeColor = Color.White;
            btnDeletestock.Location = new Point(642, 472);
            btnDeletestock.Margin = new Padding(4, 3, 4, 3);
            btnDeletestock.Name = "btnDeletestock";
            btnDeletestock.Size = new Size(204, 35);
            btnDeletestock.TabIndex = 80;
            btnDeletestock.Text = "Remove Stock";
            btnDeletestock.UseVisualStyleBackColor = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(601, 193);
            numericUpDown2.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(201, 31);
            numericUpDown2.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(603, 155);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 78;
            label4.Text = "Price";
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown4.Location = new Point(346, 197);
            numericUpDown4.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(201, 31);
            numericUpDown4.TabIndex = 77;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(346, 159);
            label9.Name = "label9";
            label9.Size = new Size(160, 32);
            label9.TabIndex = 76;
            label9.Text = "Quantity / kg";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(603, 60);
            label11.Name = "label11";
            label11.Size = new Size(107, 32);
            label11.TabIndex = 75;
            label11.Text = "Location";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "WareHouse 1", "WareHouse 2" });
            comboBox2.Location = new Point(599, 97);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 33);
            comboBox2.TabIndex = 74;
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Usage", "Sold", "Loss" });
            comboBox5.Location = new Point(77, 196);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(201, 33);
            comboBox5.TabIndex = 71;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(83, 159);
            label13.Name = "label13";
            label13.Size = new Size(102, 32);
            label13.TabIndex = 70;
            label13.Text = "Purpose";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(87, 51);
            label14.Name = "label14";
            label14.Size = new Size(138, 32);
            label14.TabIndex = 69;
            label14.Text = "Crop Name";
            // 
            // comboBox6
            // 
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(83, 88);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(201, 33);
            comboBox6.TabIndex = 68;
            // 
            // btnSubmitResponse
            // 
            btnSubmitResponse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitResponse.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmitResponse.FlatStyle = FlatStyle.Flat;
            btnSubmitResponse.ForeColor = Color.White;
            btnSubmitResponse.Location = new Point(1956, 1275);
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
            txtResponse.Location = new Point(32, 1142);
            txtResponse.Margin = new Padding(5, 3, 5, 3);
            txtResponse.Multiline = true;
            txtResponse.Name = "txtResponse";
            txtResponse.Size = new Size(2127, 106);
            txtResponse.TabIndex = 2;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(32, 1116);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(92, 25);
            label10.TabIndex = 1;
            label10.Text = "Response:";
            // 
            // StockForm
            // 
            ClientSize = new Size(1402, 835);
            Controls.Add(tabControlExpert);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "StockForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            tabControlExpert.ResumeLayout(false);
            tabAdd.ResumeLayout(false);
            tabAdd.PerformLayout();
            ((ISupportInitialize)grdstock).EndInit();
            tabremovestock.ResumeLayout(false);
            tabremovestock.PerformLayout();
            ((ISupportInitialize)numericUpDown2).EndInit();
            ((ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private void Loadgrid()
        {
            List<CropStock> lands = CropBatchDL.GetCropStocksByFarmer(profile.FarmerID);


            var displayList = lands.Select(l => new
            {
                BatchID = l.BatchId,
                Crop = l.CropId,
                Location = l.Location,
                Purpose = l.Purpose,
                Quantity = l.Quantity,
                Price = l.Price,


            }).ToList();

            grdstock.DataSource = displayList;
        }
        public void loadtotal()
        {

        }
        private void loadtest()
        {
            lblTotal.Text = $"Harvested Total : {HavestedTotal}       Purchased Total : {PurchedTotal}";
        }
        private void loadcombo()
        {
            try
            {
                cmbcrop.DisplayMember = "crop_name";
                cmbcrop.ValueMember = "crop_id";
                cmbcrop.DataSource = CropDL.Loadcombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

        }
        private void btnaddstock_Click_1(object sender, EventArgs e)
        {
            string location = txtLocation.Text.Trim();
            string price = txtPrice.Text.Trim();
            string quantity = txtQuantity.Text.Trim();
            string purpose = cmbpurpose.SelectedItem?.ToString();
            object cropSelection = cmbcrop.SelectedValue;


            if (string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Location is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!CropStock.PriceChecker(price))
            {
                MessageBox.Show("Enter a valid price greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int pri = int.Parse(price);
            if (!CropStock.QuantityChecker(quantity))
            {
                MessageBox.Show("Enter a valid quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quan = int.Parse(quantity);
            if (string.IsNullOrEmpty(purpose))
            {
                MessageBox.Show("Please select a purpose.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (cropSelection == null || !int.TryParse(cropSelection.ToString(), out int cropId))
            {
                MessageBox.Show("Please select a valid crop.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CropStock crop = new CropStock(cropId, profile.FarmerID, location, purpose, pri, quan);
            crop.Save();
            ClearForm();
            Loadgrid();
            loadtest();
            MessageBox.Show("Added Successfully");
        }




        private void ClearForm()
        {

            txtLocation.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cmbpurpose.SelectedIndex = -1;
            cmbcrop.SelectedIndex = -1;
            btnaddstock.Text = "Add New Stock";
            btndelelte.Visible = true;
        }



        private void btndelelte_Click(object sender, EventArgs e)
        {
            if (ID <= 0)
            {
                MessageBox.Show("Please select a valid stock entry to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this stock entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                CropStock stock = CropStock.GetById(ID);
                if (stock != null)
                {
                    bool isDeleted = stock.Delete();
                    if (isDeleted)
                    {
                        MessageBox.Show("Stock entry deleted successfully.");
                        Loadgrid(); // Refresh the DataGridView
                        ID = 0; // Reset selected ID
                    }
                    else
                    {
                        MessageBox.Show("Error occurred while deleting the stock entry.");
                    }
                }
                else
                {
                    MessageBox.Show("Stock not found.");
                }
                loadtest();
            }
        }

        private void grdstock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Make sure the "LandID" column exists
                DataGridViewRow row = grdstock.Rows[e.RowIndex];
                string landID = row.Cells["BatchID"].Value?.ToString(); // Handle possible null values

                if (int.TryParse(landID, out int selectedID))
                {
                    ID = selectedID;
                }
                else
                {
                    MessageBox.Show("Invalid Land ID selected.");
                }
            }
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            FarmerDashboard farmerDashboard = new FarmerDashboard(profile);
            farmerDashboard.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
