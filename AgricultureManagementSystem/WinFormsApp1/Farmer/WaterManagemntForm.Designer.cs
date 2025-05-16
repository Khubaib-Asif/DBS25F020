namespace AgricultureManagementSystem.Farmer
{
    partial class WaterManagemntForm
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
            panel2 = new Panel();
            btnusage = new Button();
            cmbagrip = new ComboBox();
            numericUpDown5 = new NumericUpDown();
            label15 = new Label();
            label16 = new Label();
            cmbplanted = new ComboBox();
            label18 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label2 = new Label();
            cmbwater = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblWeatherHeader = new Label();
            grdstock = new DataGridView();
            btnaddagri = new Button();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdstock).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnusage);
            panel2.Controls.Add(cmbagrip);
            panel2.Controls.Add(numericUpDown5);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(cmbplanted);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbwater);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(lblWeatherHeader);
            panel2.Controls.Add(grdstock);
            panel2.Controls.Add(btnaddagri);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(186, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(998, 712);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // btnusage
            // 
            btnusage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnusage.BackColor = Color.FromArgb(192, 0, 0);
            btnusage.FlatStyle = FlatStyle.Flat;
            btnusage.ForeColor = Color.White;
            btnusage.Location = new Point(822, 351);
            btnusage.Margin = new Padding(4, 3, 4, 3);
            btnusage.Name = "btnusage";
            btnusage.Size = new Size(96, 35);
            btnusage.TabIndex = 111;
            btnusage.Text = "Record Usage";
            btnusage.UseVisualStyleBackColor = false;
            // 
            // cmbagrip
            // 
            cmbagrip.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbagrip.FormattingEnabled = true;
            cmbagrip.Location = new Point(773, 101);
            cmbagrip.Name = "cmbagrip";
            cmbagrip.Size = new Size(201, 23);
            cmbagrip.TabIndex = 110;
            // 
            // numericUpDown5
            // 
            numericUpDown5.DecimalPlaces = 2;
            numericUpDown5.Location = new Point(777, 255);
            numericUpDown5.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(201, 23);
            numericUpDown5.TabIndex = 108;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(781, 220);
            label15.Name = "label15";
            label15.Size = new Size(103, 21);
            label15.TabIndex = 107;
            label15.Text = "Usage Hours";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(785, 146);
            label16.Name = "label16";
            label16.Size = new Size(105, 21);
            label16.TabIndex = 106;
            label16.Text = "Planted Crop";
            // 
            // cmbplanted
            // 
            cmbplanted.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbplanted.FormattingEnabled = true;
            cmbplanted.Location = new Point(777, 180);
            cmbplanted.Name = "cmbplanted";
            cmbplanted.Size = new Size(201, 23);
            cmbplanted.TabIndex = 105;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(773, 67);
            label18.Name = "label18";
            label18.Size = new Size(125, 21);
            label18.TabIndex = 103;
            label18.Text = "Water Resource";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(21, 422);
            numericUpDown1.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(201, 23);
            numericUpDown1.TabIndex = 98;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 387);
            label6.Name = "label6";
            label6.Size = new Size(98, 21);
            label6.TabIndex = 97;
            label6.Text = "Price / Hour";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(286, 289);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 94;
            label5.Text = "Location";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "WareHouse 1", "WareHouse 2" });
            comboBox3.Location = new Point(278, 323);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(201, 23);
            comboBox3.TabIndex = 93;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 289);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 92;
            label2.Text = "Water Type";
            // 
            // cmbwater
            // 
            cmbwater.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbwater.FormattingEnabled = true;
            cmbwater.Items.AddRange(new object[] { "Canal", "Tube Well", "River" });
            cmbwater.Location = new Point(21, 323);
            cmbwater.Name = "cmbwater";
            cmbwater.Size = new Size(201, 23);
            cmbwater.TabIndex = 91;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(869, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 32);
            btnSearch.TabIndex = 90;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.InfoText;
            txtSearch.Location = new Point(652, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(210, 29);
            txtSearch.TabIndex = 89;
            // 
            // lblWeatherHeader
            // 
            lblWeatherHeader.AutoSize = true;
            lblWeatherHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWeatherHeader.Location = new Point(0, 21);
            lblWeatherHeader.Name = "lblWeatherHeader";
            lblWeatherHeader.Size = new Size(159, 20);
            lblWeatherHeader.TabIndex = 87;
            lblWeatherHeader.Text = "🌊💧 Water Resource";
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
            grdstock.Location = new Point(6, 48);
            grdstock.Name = "grdstock";
            grdstock.ReadOnly = true;
            grdstock.RowHeadersVisible = false;
            grdstock.Size = new Size(750, 230);
            grdstock.TabIndex = 88;
            // 
            // btnaddagri
            // 
            btnaddagri.BackColor = Color.FromArgb(0, 192, 0);
            btnaddagri.FlatStyle = FlatStyle.Flat;
            btnaddagri.ForeColor = Color.White;
            btnaddagri.Location = new Point(223, 538);
            btnaddagri.Margin = new Padding(4, 3, 4, 3);
            btnaddagri.Name = "btnaddagri";
            btnaddagri.Size = new Size(117, 35);
            btnaddagri.TabIndex = 84;
            btnaddagri.Text = "Add new Product";
            btnaddagri.UseVisualStyleBackColor = false;
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
            panel1.Size = new Size(186, 712);
            panel1.TabIndex = 18;
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
            btnReports.Location = new Point(3, 263);
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
            btnExpertAdvice.Location = new Point(3, 313);
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
            btnEquipment.Location = new Point(1, 372);
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
            btnMyLands.Location = new Point(3, 204);
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
            btnInventory.Location = new Point(3, 91);
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
            btnCropSuggestions.Location = new Point(4, 147);
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
            menuStrip1.TabIndex = 17;
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
            btnwater.Location = new Point(3, 434);
            btnwater.Name = "btnwater";
            btnwater.Size = new Size(180, 33);
            btnwater.TabIndex = 6;
            btnwater.Text = "🚰 Water Resources ";
            btnwater.TextAlign = ContentAlignment.BottomCenter;
            btnwater.UseVisualStyleBackColor = false;
            // 
            // WaterManagemntForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 736);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "WaterManagemntForm";
            Text = "WaterManagemntForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdstock).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnusage;
        private ComboBox cmbagrip;
        private NumericUpDown numericUpDown5;
        private Label label15;
        private Label label16;
        private ComboBox cmbplanted;
        private Label label18;
        private TextBox txtcompany;
        private Label label12;
        private DateTimePicker Expiry;
        private TextBox txtagriname;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label5;
        private ComboBox comboBox3;
        private Label label2;
        private ComboBox cmbwater;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblWeatherHeader;
        private DataGridView grdstock;
        private Label label3;
        private Label label8;
        private Button btnaddagri;
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
        private Button btnwater;
    }
}