namespace AgricultureManagementSystem.Farmer
{
    partial class Crops_Growth
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelWeather = new Panel();
            btnAddCrop = new Button();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            label6 = new Label();
            txtarea = new TextBox();
            Area = new Label();
            label5 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            lblRole = new Label();
            cmbRoleID = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblWeatherHeader = new Label();
            grdlands = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)grdlands).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelWeather
            // 
            panelWeather.BackColor = Color.WhiteSmoke;
            panelWeather.BorderStyle = BorderStyle.FixedSingle;
            panelWeather.Controls.Add(btnAddCrop);
            panelWeather.Controls.Add(comboBox4);
            panelWeather.Controls.Add(comboBox3);
            panelWeather.Controls.Add(label6);
            panelWeather.Controls.Add(txtarea);
            panelWeather.Controls.Add(Area);
            panelWeather.Controls.Add(label5);
            panelWeather.Controls.Add(label3);
            panelWeather.Controls.Add(comboBox2);
            panelWeather.Controls.Add(label2);
            panelWeather.Controls.Add(comboBox1);
            panelWeather.Controls.Add(lblRole);
            panelWeather.Controls.Add(cmbRoleID);
            panelWeather.Controls.Add(btnSearch);
            panelWeather.Controls.Add(txtSearch);
            panelWeather.Controls.Add(lblWeatherHeader);
            panelWeather.Controls.Add(grdlands);
            panelWeather.Dock = DockStyle.Fill;
            panelWeather.Location = new Point(186, 24);
            panelWeather.Name = "panelWeather";
            panelWeather.Size = new Size(898, 612);
            panelWeather.TabIndex = 15;
            panelWeather.Paint += panelWeather_Paint;
            // 
            // btnAddCrop
            // 
            btnAddCrop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddCrop.BackColor = Color.FromArgb(0, 192, 0);
            btnAddCrop.FlatStyle = FlatStyle.Flat;
            btnAddCrop.ForeColor = Color.White;
            btnAddCrop.Location = new Point(160, 555);
            btnAddCrop.Margin = new Padding(4, 3, 4, 3);
            btnAddCrop.Name = "btnAddCrop";
            btnAddCrop.Size = new Size(204, 35);
            btnAddCrop.TabIndex = 69;
            btnAddCrop.Text = "Add New Crop";
            btnAddCrop.UseVisualStyleBackColor = false;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030" });
            comboBox4.Location = new Point(23, 397);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(201, 23);
            comboBox4.TabIndex = 68;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Spring", "Summer", "Winter", "Autumn" });
            comboBox3.Location = new Point(23, 495);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(190, 23);
            comboBox3.TabIndex = 67;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 450);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 66;
            label6.Text = "Season";
            // 
            // txtarea
            // 
            txtarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtarea.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtarea.ForeColor = SystemColors.InfoText;
            txtarea.Location = new Point(325, 391);
            txtarea.Name = "txtarea";
            txtarea.Size = new Size(216, 29);
            txtarea.TabIndex = 65;
            // 
            // Area
            // 
            Area.AutoSize = true;
            Area.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Area.Location = new Point(332, 357);
            Area.Name = "Area";
            Area.Size = new Size(44, 21);
            Area.TabIndex = 64;
            Area.Text = "Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 357);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 62;
            label5.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(325, 450);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 61;
            label3.Text = "Status";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Harvested", "Growing", "Planted" });
            comboBox2.Location = new Point(325, 492);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(190, 23);
            comboBox2.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(325, 278);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 59;
            label2.Text = "Crop Name";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(325, 313);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 23);
            comboBox1.TabIndex = 58;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(23, 278);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(112, 21);
            lblRole.TabIndex = 57;
            lblRole.Text = "Land Location";
            // 
            // cmbRoleID
            // 
            cmbRoleID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbRoleID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleID.FormattingEnabled = true;
            cmbRoleID.Location = new Point(23, 313);
            cmbRoleID.Name = "cmbRoleID";
            cmbRoleID.Size = new Size(190, 23);
            cmbRoleID.TabIndex = 56;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(783, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 32);
            btnSearch.TabIndex = 55;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.InfoText;
            txtSearch.Location = new Point(562, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(216, 29);
            txtSearch.TabIndex = 54;
            // 
            // lblWeatherHeader
            // 
            lblWeatherHeader.AutoSize = true;
            lblWeatherHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWeatherHeader.Location = new Point(10, 10);
            lblWeatherHeader.Name = "lblWeatherHeader";
            lblWeatherHeader.Size = new Size(202, 20);
            lblWeatherHeader.TabIndex = 0;
            lblWeatherHeader.Text = "🌾 Crops Planted Overview";
            // 
            // grdlands
            // 
            grdlands.AllowUserToAddRows = false;
            grdlands.AllowUserToResizeRows = false;
            grdlands.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdlands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdlands.DefaultCellStyle = dataGridViewCellStyle2;
            grdlands.Location = new Point(10, 40);
            grdlands.Name = "grdlands";
            grdlands.ReadOnly = true;
            grdlands.RowHeadersVisible = false;
            grdlands.Size = new Size(750, 230);
            grdlands.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
            panel1.Size = new Size(186, 612);
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
            btnReports.Location = new Point(5, 266);
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
            btnExpertAdvice.Location = new Point(0, 324);
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
            btnEquipment.Location = new Point(0, 375);
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
            btnMyLands.Location = new Point(5, 207);
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
            btnInventory.Location = new Point(5, 94);
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
            btnCropSuggestions.Location = new Point(8, 150);
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
            menuStrip1.Size = new Size(1084, 24);
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
            btnwater.Location = new Point(3, 427);
            btnwater.Name = "btnwater";
            btnwater.Size = new Size(180, 33);
            btnwater.TabIndex = 7;
            btnwater.Text = "🚰 Water Resources ";
            btnwater.TextAlign = ContentAlignment.BottomCenter;
            btnwater.UseVisualStyleBackColor = false;
            // 
            // Crops_Growth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 636);
            Controls.Add(panelWeather);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Crops_Growth";
            Text = "Crops_Growth";
            panelWeather.ResumeLayout(false);
            panelWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdlands).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelWeather;
        private Label lblWeatherHeader;
        private DataGridView grdlands;
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
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label3;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Label lblRole;
        private ComboBox cmbRoleID;
        private Label label6;
        private TextBox txtarea;
        private Label Area;
        private Label label5;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button btnAddCrop;
        private Button btnwater;
    }
}