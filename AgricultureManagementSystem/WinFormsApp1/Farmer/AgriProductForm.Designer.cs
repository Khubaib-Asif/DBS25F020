namespace AgricultureManagementSystem.Farmer
{
    partial class AgriProductForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btndashboard = new Button();
            label1 = new Label();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            addStockToolStripMenuItem = new ToolStripMenuItem();
            recordUsageToolStripMenuItem = new ToolStripMenuItem();
            requestAdviceToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            panel2 = new Panel();
            btndelete = new Button();
            txtprice = new TextBox();
            txtquanitty = new TextBox();
            txtlocation = new TextBox();
            btnusage = new Button();
            cmbagrip = new ComboBox();
            txtdescription = new TextBox();
            numericUpDown5 = new NumericUpDown();
            label15 = new Label();
            label16 = new Label();
            cmbplanted = new ComboBox();
            label17 = new Label();
            label18 = new Label();
            txtcompany = new TextBox();
            label12 = new Label();
            dtvExpirydate = new DateTimePicker();
            txtagriname = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            cmbcatagory = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblWeatherHeader = new Label();
            grdstock = new DataGridView();
            label3 = new Label();
            label8 = new Label();
            btnaddagri = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdstock).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(266, 1135);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.farmer_icon;
            pictureBox1.Location = new Point(28, 12);
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
            btndashboard.Location = new Point(6, 310);
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
            label1.Location = new Point(6, 138);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 72);
            label1.TabIndex = 10;
            label1.Text = "\r\n________________________";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(23, 24, 29);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1691, 35);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // panel2
            // 
            panel2.Controls.Add(btndelete);
            panel2.Controls.Add(txtprice);
            panel2.Controls.Add(txtquanitty);
            panel2.Controls.Add(txtlocation);
            panel2.Controls.Add(btnusage);
            panel2.Controls.Add(cmbagrip);
            panel2.Controls.Add(txtdescription);
            panel2.Controls.Add(numericUpDown5);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(cmbplanted);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(txtcompany);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(dtvExpirydate);
            panel2.Controls.Add(txtagriname);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbcatagory);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(lblWeatherHeader);
            panel2.Controls.Add(grdstock);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnaddagri);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(266, 35);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1425, 1135);
            panel2.TabIndex = 16;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.FromArgb(0, 192, 0);
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.ForeColor = Color.White;
            btndelete.Location = new Point(555, 1034);
            btndelete.Margin = new Padding(6, 5, 6, 5);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(167, 58);
            btndelete.TabIndex = 115;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(794, 740);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(125, 31);
            txtprice.TabIndex = 114;
            // 
            // txtquanitty
            // 
            txtquanitty.Location = new Point(429, 740);
            txtquanitty.Name = "txtquanitty";
            txtquanitty.Size = new Size(143, 31);
            txtquanitty.TabIndex = 113;
            // 
            // txtlocation
            // 
            txtlocation.Location = new Point(794, 555);
            txtlocation.Name = "txtlocation";
            txtlocation.Size = new Size(295, 31);
            txtlocation.TabIndex = 112;
            // 
            // btnusage
            // 
            btnusage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnusage.BackColor = Color.FromArgb(192, 0, 0);
            btnusage.FlatStyle = FlatStyle.Flat;
            btnusage.ForeColor = Color.White;
            btnusage.Location = new Point(1186, 663);
            btnusage.Margin = new Padding(6, 5, 6, 5);
            btnusage.Name = "btnusage";
            btnusage.Size = new Size(137, 58);
            btnusage.TabIndex = 111;
            btnusage.Text = "Record Usage";
            btnusage.UseVisualStyleBackColor = false;
            // 
            // cmbagrip
            // 
            cmbagrip.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbagrip.FormattingEnabled = true;
            cmbagrip.Location = new Point(1104, 168);
            cmbagrip.Margin = new Padding(4, 5, 4, 5);
            cmbagrip.Name = "cmbagrip";
            cmbagrip.Size = new Size(285, 33);
            cmbagrip.TabIndex = 110;
            // 
            // txtdescription
            // 
            txtdescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtdescription.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdescription.ForeColor = SystemColors.InfoText;
            txtdescription.Location = new Point(1096, 553);
            txtdescription.Margin = new Padding(4, 5, 4, 5);
            txtdescription.Multiline = true;
            txtdescription.Name = "txtdescription";
            txtdescription.ScrollBars = ScrollBars.Vertical;
            txtdescription.Size = new Size(299, 79);
            txtdescription.TabIndex = 109;
            // 
            // numericUpDown5
            // 
            numericUpDown5.DecimalPlaces = 2;
            numericUpDown5.Location = new Point(1110, 425);
            numericUpDown5.Margin = new Padding(4, 5, 4, 5);
            numericUpDown5.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(287, 31);
            numericUpDown5.TabIndex = 108;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(1116, 367);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(221, 32);
            label15.TabIndex = 107;
            label15.Text = "Used Quantity / kg";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(1121, 243);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(156, 32);
            label16.TabIndex = 106;
            label16.Text = "Planted Crop";
            // 
            // cmbplanted
            // 
            cmbplanted.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbplanted.FormattingEnabled = true;
            cmbplanted.Location = new Point(1110, 300);
            cmbplanted.Margin = new Padding(4, 5, 4, 5);
            cmbplanted.Name = "cmbplanted";
            cmbplanted.Size = new Size(285, 33);
            cmbplanted.TabIndex = 105;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(1101, 490);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(137, 32);
            label17.TabIndex = 104;
            label17.Text = "Description";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(1104, 112);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(134, 32);
            label18.TabIndex = 103;
            label18.Text = "Agri-Name";
            // 
            // txtcompany
            // 
            txtcompany.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtcompany.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcompany.ForeColor = SystemColors.InfoText;
            txtcompany.Location = new Point(16, 740);
            txtcompany.Margin = new Padding(4, 5, 4, 5);
            txtcompany.Name = "txtcompany";
            txtcompany.Size = new Size(299, 40);
            txtcompany.TabIndex = 102;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(16, 848);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(151, 32);
            label12.TabIndex = 101;
            label12.Text = "Expiray Date";
            // 
            // dtvExpirydate
            // 
            dtvExpirydate.Location = new Point(16, 912);
            dtvExpirydate.Margin = new Padding(4, 5, 4, 5);
            dtvExpirydate.MaxDate = new DateTime(2050, 5, 1, 0, 0, 0, 0);
            dtvExpirydate.Name = "dtvExpirydate";
            dtvExpirydate.Size = new Size(284, 31);
            dtvExpirydate.TabIndex = 100;
            dtvExpirydate.Value = new DateTime(2010, 5, 1, 0, 0, 0, 0);
            // 
            // txtagriname
            // 
            txtagriname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtagriname.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtagriname.ForeColor = SystemColors.InfoText;
            txtagriname.Location = new Point(16, 553);
            txtagriname.Margin = new Padding(4, 5, 4, 5);
            txtagriname.Name = "txtagriname";
            txtagriname.Size = new Size(264, 40);
            txtagriname.TabIndex = 99;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(794, 689);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 32);
            label6.TabIndex = 97;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(420, 689);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(160, 32);
            label7.TabIndex = 95;
            label7.Text = "Quantity / kg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(821, 497);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 94;
            label5.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(466, 506);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 92;
            label2.Text = "Category";
            // 
            // cmbcatagory
            // 
            cmbcatagory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbcatagory.FormattingEnabled = true;
            cmbcatagory.Items.AddRange(new object[] { "Fertilizer", "Pesticide", "Seeds" });
            cmbcatagory.Location = new Point(451, 555);
            cmbcatagory.Margin = new Padding(4, 5, 4, 5);
            cmbcatagory.Name = "cmbcatagory";
            cmbcatagory.Size = new Size(285, 33);
            cmbcatagory.TabIndex = 91;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1241, 7);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(157, 53);
            btnSearch.TabIndex = 90;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.InfoText;
            txtSearch.Location = new Point(931, 12);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(299, 40);
            txtSearch.TabIndex = 89;
            // 
            // lblWeatherHeader
            // 
            lblWeatherHeader.AutoSize = true;
            lblWeatherHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWeatherHeader.Location = new Point(0, 35);
            lblWeatherHeader.Margin = new Padding(4, 0, 4, 0);
            lblWeatherHeader.Name = "lblWeatherHeader";
            lblWeatherHeader.Size = new Size(266, 30);
            lblWeatherHeader.TabIndex = 87;
            lblWeatherHeader.Text = "🚜 Agriculture Products";
            // 
            // grdstock
            // 
            grdstock.AllowUserToAddRows = false;
            grdstock.AllowUserToResizeRows = false;
            grdstock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdstock.ColumnHeadersHeight = 34;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            grdstock.DefaultCellStyle = dataGridViewCellStyle4;
            grdstock.Location = new Point(9, 80);
            grdstock.Margin = new Padding(4, 5, 4, 5);
            grdstock.Name = "grdstock";
            grdstock.ReadOnly = true;
            grdstock.RowHeadersVisible = false;
            grdstock.RowHeadersWidth = 62;
            grdstock.Size = new Size(1071, 383);
            grdstock.TabIndex = 88;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 677);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 32);
            label3.TabIndex = 86;
            label3.Text = "Company Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 497);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(134, 32);
            label8.TabIndex = 85;
            label8.Text = "Agri-Name";
            // 
            // btnaddagri
            // 
            btnaddagri.BackColor = Color.FromArgb(0, 192, 0);
            btnaddagri.FlatStyle = FlatStyle.Flat;
            btnaddagri.ForeColor = Color.White;
            btnaddagri.Location = new Point(287, 1034);
            btnaddagri.Margin = new Padding(6, 5, 6, 5);
            btnaddagri.Name = "btnaddagri";
            btnaddagri.Size = new Size(167, 58);
            btnaddagri.TabIndex = 84;
            btnaddagri.Text = "Add new Product";
            btnaddagri.UseVisualStyleBackColor = false;
            btnaddagri.Click += btnaddagri_Click;
            // 
            // AgriProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1691, 1170);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AgriProductForm";
            Text = "AgriProductForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdstock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem addStockToolStripMenuItem;
        private ToolStripMenuItem recordUsageToolStripMenuItem;
        private ToolStripMenuItem requestAdviceToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Panel panel2;
        private Button btnusage;
        private ComboBox cmbagrip;
        private TextBox txtdescription;
        private NumericUpDown numericUpDown5;
        private Label label15;
        private Label label16;
        private ComboBox cmbplanted;
        private Label label17;
        private Label label18;
        private TextBox txtcompany;
        private Label label12;
        private DateTimePicker dtvExpirydate;
        private TextBox txtagriname;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label2;
        private ComboBox cmbcatagory;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblWeatherHeader;
        private DataGridView grdstock;
        private Label label3;
        private Label label8;
        private Button btnaddagri;
        private PictureBox pictureBox1;
        private Button btndashboard;
        private Label label1;
        private TextBox txtlocation;
        private TextBox txtquanitty;
        private TextBox txtprice;
        private Button btndelete;
    }
}