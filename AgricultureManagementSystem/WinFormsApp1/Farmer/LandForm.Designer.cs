namespace AgricultureManagementSystem.Farmer
{
    partial class LandForm
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
            txtsoil = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnDeleteLand = new Button();
            btnAddLand = new Button();
            txtAddress = new TextBox();
            label7 = new Label();
            txtarea = new TextBox();
            Area = new Label();
            label5 = new Label();
            lblWeatherHeader = new Label();
            grdlands = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btndashboard = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            addStockToolStripMenuItem = new ToolStripMenuItem();
            recordUsageToolStripMenuItem = new ToolStripMenuItem();
            requestAdviceToolStripMenuItem = new ToolStripMenuItem();
            panelWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdlands).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelWeather
            // 
            panelWeather.BackColor = Color.WhiteSmoke;
            panelWeather.BorderStyle = BorderStyle.FixedSingle;
            panelWeather.Controls.Add(txtsoil);
            panelWeather.Controls.Add(btnSearch);
            panelWeather.Controls.Add(txtSearch);
            panelWeather.Controls.Add(btnDeleteLand);
            panelWeather.Controls.Add(btnAddLand);
            panelWeather.Controls.Add(txtAddress);
            panelWeather.Controls.Add(label7);
            panelWeather.Controls.Add(txtarea);
            panelWeather.Controls.Add(Area);
            panelWeather.Controls.Add(label5);
            panelWeather.Controls.Add(lblWeatherHeader);
            panelWeather.Controls.Add(grdlands);
            panelWeather.Dock = DockStyle.Fill;
            panelWeather.Location = new Point(266, 35);
            panelWeather.Margin = new Padding(4, 5, 4, 5);
            panelWeather.Name = "panelWeather";
            panelWeather.Size = new Size(1283, 1025);
            panelWeather.TabIndex = 12;
            // 
            // txtsoil
            // 
            txtsoil.FormattingEnabled = true;
            txtsoil.Items.AddRange(new object[] { "Alluvial\tزرخیز", "Loamy\tنرم", "Sandy\tریتیلی", "Clayey\tچکنی", "Black\tسیاہ", "Red\tسرخ", "Desert\tبنجر", "Hilly\tپہاڑی", "Marshy\tدلدلی", "Pasture\tچراگاہ" });
            txtsoil.Location = new Point(39, 537);
            txtsoil.Name = "txtsoil";
            txtsoil.Size = new Size(313, 33);
            txtsoil.TabIndex = 54;
            txtsoil.SelectedIndexChanged += txtsoil_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1119, 3);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(157, 53);
            btnSearch.TabIndex = 53;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.InfoText;
            txtSearch.Location = new Point(803, 8);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(308, 40);
            txtSearch.TabIndex = 52;
            // 
            // btnDeleteLand
            // 
            btnDeleteLand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteLand.BackColor = Color.FromArgb(192, 0, 0);
            btnDeleteLand.FlatStyle = FlatStyle.Flat;
            btnDeleteLand.ForeColor = Color.White;
            btnDeleteLand.Location = new Point(801, 946);
            btnDeleteLand.Margin = new Padding(6, 5, 6, 5);
            btnDeleteLand.Name = "btnDeleteLand";
            btnDeleteLand.Size = new Size(291, 58);
            btnDeleteLand.TabIndex = 51;
            btnDeleteLand.Text = "Delete Land";
            btnDeleteLand.UseVisualStyleBackColor = false;
            btnDeleteLand.Click += btnDeleteLand_Click_2;
            // 
            // btnAddLand
            // 
            btnAddLand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddLand.BackColor = Color.FromArgb(0, 192, 0);
            btnAddLand.FlatStyle = FlatStyle.Flat;
            btnAddLand.ForeColor = Color.White;
            btnAddLand.Location = new Point(394, 946);
            btnAddLand.Margin = new Padding(6, 5, 6, 5);
            btnAddLand.Name = "btnAddLand";
            btnAddLand.Size = new Size(291, 58);
            btnAddLand.TabIndex = 49;
            btnAddLand.Text = "Add New Land";
            btnAddLand.UseVisualStyleBackColor = false;
            btnAddLand.Click += btnAddLand_Click_1;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = SystemColors.InfoText;
            txtAddress.Location = new Point(29, 673);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(739, 131);
            txtAddress.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 617);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(203, 32);
            label7.TabIndex = 47;
            label7.Text = "Location/Address";
            // 
            // txtarea
            // 
            txtarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtarea.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtarea.ForeColor = SystemColors.InfoText;
            txtarea.Location = new Point(460, 537);
            txtarea.Margin = new Padding(4, 5, 4, 5);
            txtarea.Name = "txtarea";
            txtarea.Size = new Size(308, 40);
            txtarea.TabIndex = 36;
            // 
            // Area
            // 
            Area.AutoSize = true;
            Area.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Area.Location = new Point(470, 480);
            Area.Margin = new Padding(4, 0, 4, 0);
            Area.Name = "Area";
            Area.Size = new Size(65, 32);
            Area.TabIndex = 35;
            Area.Text = "Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 480);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 33;
            label5.Text = "Soil Type";
            // 
            // lblWeatherHeader
            // 
            lblWeatherHeader.AutoSize = true;
            lblWeatherHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWeatherHeader.Location = new Point(14, 17);
            lblWeatherHeader.Margin = new Padding(4, 0, 4, 0);
            lblWeatherHeader.Name = "lblWeatherHeader";
            lblWeatherHeader.Size = new Size(231, 30);
            lblWeatherHeader.TabIndex = 0;
            lblWeatherHeader.Text = "📏 Land Area Details";
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
            grdlands.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdlands.DefaultCellStyle = dataGridViewCellStyle2;
            grdlands.Location = new Point(14, 67);
            grdlands.Margin = new Padding(4, 5, 4, 5);
            grdlands.Name = "grdlands";
            grdlands.ReadOnly = true;
            grdlands.RowHeadersVisible = false;
            grdlands.RowHeadersWidth = 62;
            grdlands.Size = new Size(1071, 383);
            grdlands.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btndashboard);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 35);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 1025);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.farmer_icon;
            pictureBox1.Location = new Point(29, 28);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 178);
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
            btndashboard.Location = new Point(9, 325);
            btndashboard.Margin = new Padding(4, 5, 4, 5);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(257, 55);
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
            label1.Location = new Point(3, 132);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 72);
            label1.TabIndex = 10;
            label1.Text = "\r\n________________________";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(23, 24, 29);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1549, 35);
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
            // LandForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 1060);
            Controls.Add(panelWeather);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LandForm";
            Text = "LandForm";
            panelWeather.ResumeLayout(false);
            panelWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdlands).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem addStockToolStripMenuItem;
        private ToolStripMenuItem recordUsageToolStripMenuItem;
        private ToolStripMenuItem requestAdviceToolStripMenuItem;
        private TextBox txtarea;
        private Label Area;
        private Label label5;
        private TextBox txtAddress;
        private Label label7;
        private Button btnDeleteLand;
        private Button btnAddLand;
        private Button btnSearch;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private Button btndashboard;
        private Label label1;
        private ComboBox txtsoil;
    }
}