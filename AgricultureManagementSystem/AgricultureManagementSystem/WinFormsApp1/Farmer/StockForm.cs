using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgricultureManagementSystem.Farmer
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }

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
            btnReports = new Button();
            label1 = new Label();
            btnExpertAdvice = new Button();
            btnEquipment = new Button();
            btnMyLands = new Button();
            btnInventory = new Button();
            btnCropSuggestions = new Button();
            tabControlExpert = new TabControl();
            tabAdd = new TabPage();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            numericUpDown3 = new NumericUpDown();
            label7 = new Label();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
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
            this.btnwater = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            tabControlExpert.SuspendLayout();
            tabAdd.SuspendLayout();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            ((ISupportInitialize)numericUpDown3).BeginInit();
            ((ISupportInitialize)grdstock).BeginInit();
            tabremovestock.SuspendLayout();
            ((ISupportInitialize)numericUpDown2).BeginInit();
            ((ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(23, 24, 29);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1084, 24);
            menuStrip1.TabIndex = 10;
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(this.btnwater);
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
            panel1.Size = new Size(186, 612);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
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
            btnReports.Location = new Point(-3, 268);
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
            btnExpertAdvice.Location = new Point(6, 318);
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
            btnEquipment.Location = new Point(2, 377);
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
            btnMyLands.Location = new Point(-3, 209);
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
            btnInventory.Location = new Point(-3, 96);
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
            btnCropSuggestions.Location = new Point(0, 152);
            btnCropSuggestions.Name = "btnCropSuggestions";
            btnCropSuggestions.Size = new Size(180, 33);
            btnCropSuggestions.TabIndex = 1;
            btnCropSuggestions.Text = "📊 Crop Section";
            btnCropSuggestions.TextAlign = ContentAlignment.BottomCenter;
            btnCropSuggestions.UseVisualStyleBackColor = false;
            // 
            // tabControlExpert
            // 
            tabControlExpert.Controls.Add(tabAdd);
            tabControlExpert.Controls.Add(tabremovestock);
            tabControlExpert.Dock = DockStyle.Fill;
            tabControlExpert.Location = new Point(186, 24);
            tabControlExpert.Margin = new Padding(4, 3, 4, 3);
            tabControlExpert.Name = "tabControlExpert";
            tabControlExpert.SelectedIndex = 0;
            tabControlExpert.Size = new Size(898, 612);
            tabControlExpert.TabIndex = 13;
            // 
            // tabAdd
            // 
            tabAdd.BackColor = Color.WhiteSmoke;
            tabAdd.Controls.Add(numericUpDown1);
            tabAdd.Controls.Add(label6);
            tabAdd.Controls.Add(numericUpDown3);
            tabAdd.Controls.Add(label7);
            tabAdd.Controls.Add(label5);
            tabAdd.Controls.Add(comboBox3);
            tabAdd.Controls.Add(label2);
            tabAdd.Controls.Add(comboBox1);
            tabAdd.Controls.Add(btnSearch);
            tabAdd.Controls.Add(txtSearch);
            tabAdd.Controls.Add(lblWeatherHeader);
            tabAdd.Controls.Add(grdstock);
            tabAdd.Controls.Add(cmbpurpose);
            tabAdd.Controls.Add(label3);
            tabAdd.Controls.Add(label8);
            tabAdd.Controls.Add(cmbcrop);
            tabAdd.Controls.Add(btnaddstock);
            tabAdd.Location = new Point(4, 24);
            tabAdd.Margin = new Padding(4, 3, 4, 3);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(4, 3, 4, 3);
            tabAdd.Size = new Size(890, 584);
            tabAdd.TabIndex = 2;
            tabAdd.Text = "Add stock";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(539, 436);
            numericUpDown1.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(201, 23);
            numericUpDown1.TabIndex = 67;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(539, 398);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 66;
            label6.Text = "Price";
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Location = new Point(282, 440);
            numericUpDown3.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(201, 23);
            numericUpDown3.TabIndex = 65;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(282, 402);
            label7.Name = "label7";
            label7.Size = new Size(105, 21);
            label7.TabIndex = 64;
            label7.Text = "Quantity / kg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(543, 294);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 63;
            label5.Text = "Location";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "WareHouse 1", "WareHouse 2" });
            comboBox3.Location = new Point(539, 331);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(201, 23);
            comboBox3.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(286, 294);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 61;
            label2.Text = "Category";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Vegetables", "Grains", "Fruits" });
            comboBox1.Location = new Point(282, 331);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 60;
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
            txtSearch.Size = new Size(216, 29);
            txtSearch.TabIndex = 58;
            // 
            // lblWeatherHeader
            // 
            lblWeatherHeader.AutoSize = true;
            lblWeatherHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWeatherHeader.Location = new Point(0, 17);
            lblWeatherHeader.Name = "lblWeatherHeader";
            lblWeatherHeader.Size = new Size(203, 20);
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
            grdstock.Size = new Size(750, 230);
            grdstock.TabIndex = 57;
            // 
            // cmbpurpose
            // 
            cmbpurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbpurpose.FormattingEnabled = true;
            cmbpurpose.Items.AddRange(new object[] { "Harvested", "Purchased" });
            cmbpurpose.Location = new Point(13, 439);
            cmbpurpose.Name = "cmbpurpose";
            cmbpurpose.Size = new Size(201, 23);
            cmbpurpose.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 402);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 24;
            label3.Text = "Purpose";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 294);
            label8.Name = "label8";
            label8.Size = new Size(93, 21);
            label8.TabIndex = 22;
            label8.Text = "Crop Name";
            // 
            // cmbcrop
            // 
            cmbcrop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbcrop.FormattingEnabled = true;
            cmbcrop.Location = new Point(19, 331);
            cmbcrop.Name = "cmbcrop";
            cmbcrop.Size = new Size(201, 23);
            cmbcrop.TabIndex = 21;
            // 
            // btnaddstock
            // 
            btnaddstock.BackColor = Color.FromArgb(0, 192, 0);
            btnaddstock.FlatStyle = FlatStyle.Flat;
            btnaddstock.ForeColor = Color.White;
            btnaddstock.Location = new Point(754, 541);
            btnaddstock.Margin = new Padding(4, 3, 4, 3);
            btnaddstock.Name = "btnaddstock";
            btnaddstock.Size = new Size(117, 35);
            btnaddstock.TabIndex = 7;
            btnaddstock.Text = "Add new stock";
            btnaddstock.UseVisualStyleBackColor = false;
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
            tabremovestock.Location = new Point(4, 24);
            tabremovestock.Margin = new Padding(5, 3, 5, 3);
            tabremovestock.Name = "tabremovestock";
            tabremovestock.Padding = new Padding(5, 3, 5, 3);
            tabremovestock.Size = new Size(890, 584);
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
            btnDeletestock.Location = new Point(324, 292);
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
            numericUpDown2.Size = new Size(201, 23);
            numericUpDown2.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(603, 155);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 78;
            label4.Text = "Price";
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown4.Location = new Point(346, 197);
            numericUpDown4.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(201, 23);
            numericUpDown4.TabIndex = 77;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(346, 159);
            label9.Name = "label9";
            label9.Size = new Size(105, 21);
            label9.TabIndex = 76;
            label9.Text = "Quantity / kg";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(603, 60);
            label11.Name = "label11";
            label11.Size = new Size(73, 21);
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
            comboBox2.Size = new Size(201, 23);
            comboBox2.TabIndex = 74;
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Usage", "Sold", "Loss" });
            comboBox5.Location = new Point(77, 196);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(201, 23);
            comboBox5.TabIndex = 71;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(83, 159);
            label13.Name = "label13";
            label13.Size = new Size(70, 21);
            label13.TabIndex = 70;
            label13.Text = "Purpose";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(87, 51);
            label14.Name = "label14";
            label14.Size = new Size(93, 21);
            label14.TabIndex = 69;
            label14.Text = "Crop Name";
            // 
            // comboBox6
            // 
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(83, 88);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(201, 23);
            comboBox6.TabIndex = 68;
            // 
            // btnSubmitResponse
            // 
            btnSubmitResponse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitResponse.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmitResponse.FlatStyle = FlatStyle.Flat;
            btnSubmitResponse.ForeColor = Color.White;
            btnSubmitResponse.Location = new Point(1638, 1095);
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
            txtResponse.Location = new Point(32, 962);
            txtResponse.Margin = new Padding(5, 3, 5, 3);
            txtResponse.Multiline = true;
            txtResponse.Name = "txtResponse";
            txtResponse.Size = new Size(1809, 106);
            txtResponse.TabIndex = 2;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(32, 936);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 1;
            label10.Text = "Response:";
            // 
            // btnwater
            // 
            this.btnwater.Anchor = AnchorStyles.None;
            this.btnwater.BackColor = Color.Transparent;
            this.btnwater.FlatAppearance.BorderColor = Color.White;
            this.btnwater.FlatAppearance.MouseDownBackColor = Color.White;
            this.btnwater.FlatAppearance.MouseOverBackColor = Color.White;
            this.btnwater.FlatStyle = FlatStyle.Flat;
            this.btnwater.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnwater.ForeColor = Color.FromArgb(23, 24, 29);
            this.btnwater.ImageAlign = ContentAlignment.TopCenter;
            this.btnwater.Location = new Point(6, 426);
            this.btnwater.Name = "btnwater";
            this.btnwater.Size = new Size(180, 33);
            this.btnwater.TabIndex = 7;
            this.btnwater.Text = "🚰 Water Resources ";
            this.btnwater.TextAlign = ContentAlignment.BottomCenter;
            this.btnwater.UseVisualStyleBackColor = false;
            // 
            // StockForm
            // 
            ClientSize = new Size(1084, 636);
            Controls.Add(tabControlExpert);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "StockForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlExpert.ResumeLayout(false);
            tabAdd.ResumeLayout(false);
            tabAdd.PerformLayout();
            ((ISupportInitialize)numericUpDown1).EndInit();
            ((ISupportInitialize)numericUpDown3).EndInit();
            ((ISupportInitialize)grdstock).EndInit();
            tabremovestock.ResumeLayout(false);
            tabremovestock.PerformLayout();
            ((ISupportInitialize)numericUpDown2).EndInit();
            ((ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
