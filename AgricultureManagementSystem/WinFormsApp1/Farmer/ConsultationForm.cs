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
    public partial class ConsultationForm : Form
    {
        FarmerProfile FarmerProfile=new FarmerProfile();
        public ConsultationForm(FarmerProfile profile)
        {
            InitializeComponent();
            FarmerProfile = profile;
            this.Size = new Size(1360, 860); // Set your desired default size
            this.StartPosition = FormStartPosition.CenterScreen; // Optional: center


        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabControlExpert = new TabControl();
            tabRequest = new TabPage();
            txtdescription = new TextBox();
            label7 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblWeatherHeader = new Label();
            grdrequest = new DataGridView();
            label8 = new Label();
            cmbrequestype = new ComboBox();
            btnaddrequest = new Button();
            tabexpertresponse = new TabPage();
            label2 = new Label();
            cmbrequestid = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            btnDeletestock = new Button();
            numericRating = new NumericUpDown();
            label4 = new Label();
            btnSubmitResponse = new Button();
            txtResponse = new TextBox();
            label10 = new Label();
            panel1 = new Panel();
            btnwater = new Button();
            btnEquioment = new Button();
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
            tabControlExpert.SuspendLayout();
            tabRequest.SuspendLayout();
            ((ISupportInitialize)grdrequest).BeginInit();
            tabexpertresponse.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            ((ISupportInitialize)numericRating).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlExpert
            // 
            tabControlExpert.Controls.Add(tabRequest);
            tabControlExpert.Controls.Add(tabexpertresponse);
            tabControlExpert.Dock = DockStyle.Fill;
            tabControlExpert.Location = new Point(186, 33);
            tabControlExpert.Margin = new Padding(4, 3, 4, 3);
            tabControlExpert.Name = "tabControlExpert";
            tabControlExpert.SelectedIndex = 0;
            tabControlExpert.Size = new Size(1200, 734);
            tabControlExpert.TabIndex = 16;
            // 
            // tabRequest
            // 
            tabRequest.BackColor = Color.WhiteSmoke;
            tabRequest.Controls.Add(txtdescription);
            tabRequest.Controls.Add(label7);
            tabRequest.Controls.Add(btnSearch);
            tabRequest.Controls.Add(txtSearch);
            tabRequest.Controls.Add(lblWeatherHeader);
            tabRequest.Controls.Add(grdrequest);
            tabRequest.Controls.Add(label8);
            tabRequest.Controls.Add(cmbrequestype);
            tabRequest.Controls.Add(btnaddrequest);
            tabRequest.Location = new Point(4, 34);
            tabRequest.Margin = new Padding(4, 3, 4, 3);
            tabRequest.Name = "tabRequest";
            tabRequest.Padding = new Padding(4, 3, 4, 3);
            tabRequest.Size = new Size(1192, 696);
            tabRequest.TabIndex = 2;
            tabRequest.Text = "Consult Expert";
            // 
            // txtdescription
            // 
            txtdescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtdescription.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdescription.ForeColor = SystemColors.InfoText;
            txtdescription.Location = new Point(339, 367);
            txtdescription.Multiline = true;
            txtdescription.Name = "txtdescription";
            txtdescription.ScrollBars = ScrollBars.Vertical;
            txtdescription.Size = new Size(525, 80);
            txtdescription.TabIndex = 61;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(346, 333);
            label7.Name = "label7";
            label7.Size = new Size(137, 32);
            label7.TabIndex = 60;
            label7.Text = "Description";
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
            txtSearch.Location = new Point(556, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(512, 40);
            txtSearch.TabIndex = 58;
            // 
            // lblWeatherHeader
            // 
            lblWeatherHeader.AutoSize = true;
            lblWeatherHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWeatherHeader.Location = new Point(4, 20);
            lblWeatherHeader.Name = "lblWeatherHeader";
            lblWeatherHeader.Size = new Size(208, 30);
            lblWeatherHeader.TabIndex = 56;
            lblWeatherHeader.Text = "\U0001f9e0 Request Expert";
            // 
            // grdrequest
            // 
            grdrequest.AllowUserToAddRows = false;
            grdrequest.AllowUserToResizeRows = false;
            grdrequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdrequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdrequest.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdrequest.DefaultCellStyle = dataGridViewCellStyle2;
            grdrequest.Location = new Point(0, 47);
            grdrequest.Name = "grdrequest";
            grdrequest.ReadOnly = true;
            grdrequest.RowHeadersVisible = false;
            grdrequest.RowHeadersWidth = 62;
            grdrequest.Size = new Size(750, 230);
            grdrequest.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 333);
            label8.Name = "label8";
            label8.Size = new Size(159, 32);
            label8.TabIndex = 22;
            label8.Text = "Request Type";
            // 
            // cmbrequestype
            // 
            cmbrequestype.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbrequestype.FormattingEnabled = true;
            cmbrequestype.Items.AddRange(new object[] { "Crop Health & Diseases", "Soil Quality & Fertilization", "Pest & Weed Control", "Crop Selection & Rotation", "Climate/Weather Impact", "Harvesting & Storage" });
            cmbrequestype.Location = new Point(19, 367);
            cmbrequestype.Name = "cmbrequestype";
            cmbrequestype.Size = new Size(201, 33);
            cmbrequestype.TabIndex = 21;
            // 
            // btnaddrequest
            // 
            btnaddrequest.BackColor = Color.FromArgb(0, 192, 0);
            btnaddrequest.FlatStyle = FlatStyle.Flat;
            btnaddrequest.ForeColor = Color.White;
            btnaddrequest.Location = new Point(225, 541);
            btnaddrequest.Margin = new Padding(4, 3, 4, 3);
            btnaddrequest.Name = "btnaddrequest";
            btnaddrequest.Size = new Size(117, 35);
            btnaddrequest.TabIndex = 7;
            btnaddrequest.Text = "Add new Request";
            btnaddrequest.UseVisualStyleBackColor = false;
            // 
            // tabexpertresponse
            // 
            tabexpertresponse.Controls.Add(label2);
            tabexpertresponse.Controls.Add(cmbrequestid);
            tabexpertresponse.Controls.Add(button1);
            tabexpertresponse.Controls.Add(textBox1);
            tabexpertresponse.Controls.Add(label9);
            tabexpertresponse.Controls.Add(dataGridView1);
            tabexpertresponse.Controls.Add(btnDeletestock);
            tabexpertresponse.Controls.Add(numericRating);
            tabexpertresponse.Controls.Add(label4);
            tabexpertresponse.Controls.Add(btnSubmitResponse);
            tabexpertresponse.Controls.Add(txtResponse);
            tabexpertresponse.Controls.Add(label10);
            tabexpertresponse.Location = new Point(4, 34);
            tabexpertresponse.Margin = new Padding(5, 3, 5, 3);
            tabexpertresponse.Name = "tabexpertresponse";
            tabexpertresponse.Padding = new Padding(5, 3, 5, 3);
            tabexpertresponse.Size = new Size(890, 574);
            tabexpertresponse.TabIndex = 1;
            tabexpertresponse.Text = "Expert Response";
            tabexpertresponse.UseVisualStyleBackColor = true;
            tabexpertresponse.Click += tabexpertresponse_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 319);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 86;
            label2.Text = "Request ID";
            // 
            // cmbrequestid
            // 
            cmbrequestid.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbrequestid.FormattingEnabled = true;
            cmbrequestid.Location = new Point(11, 353);
            cmbrequestid.Name = "cmbrequestid";
            cmbrequestid.Size = new Size(201, 33);
            cmbrequestid.TabIndex = 85;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(776, 4);
            button1.Name = "button1";
            button1.Size = new Size(110, 32);
            button1.TabIndex = 84;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(571, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 40);
            textBox1.TabIndex = 83;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.Location = new Point(12, 15);
            label9.Name = "label9";
            label9.Size = new Size(222, 30);
            label9.TabIndex = 81;
            label9.Text = "\U0001f9e0 Expert Response";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(8, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(750, 230);
            dataGridView1.TabIndex = 82;
            // 
            // btnDeletestock
            // 
            btnDeletestock.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeletestock.BackColor = Color.FromArgb(192, 0, 0);
            btnDeletestock.FlatStyle = FlatStyle.Flat;
            btnDeletestock.ForeColor = Color.White;
            btnDeletestock.Location = new Point(1009, 763);
            btnDeletestock.Margin = new Padding(4, 3, 4, 3);
            btnDeletestock.Name = "btnDeletestock";
            btnDeletestock.Size = new Size(204, 35);
            btnDeletestock.TabIndex = 80;
            btnDeletestock.Text = "Remove Stock";
            btnDeletestock.UseVisualStyleBackColor = false;
            // 
            // numericRating
            // 
            numericRating.DecimalPlaces = 2;
            numericRating.Location = new Point(12, 435);
            numericRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericRating.Name = "numericRating";
            numericRating.Size = new Size(201, 31);
            numericRating.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 400);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 78;
            label4.Text = "Rating";
            // 
            // btnSubmitResponse
            // 
            btnSubmitResponse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitResponse.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmitResponse.FlatStyle = FlatStyle.Flat;
            btnSubmitResponse.ForeColor = Color.White;
            btnSubmitResponse.Location = new Point(19, 526);
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
            txtResponse.Location = new Point(37, 1433);
            txtResponse.Margin = new Padding(5, 3, 5, 3);
            txtResponse.Multiline = true;
            txtResponse.Name = "txtResponse";
            txtResponse.Size = new Size(2489, 106);
            txtResponse.TabIndex = 2;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(37, 1407);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(92, 25);
            label10.TabIndex = 1;
            label10.Text = "Response:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnwater);
            panel1.Controls.Add(btnEquioment);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExpertAdvice);
            panel1.Controls.Add(btnEquipment);
            panel1.Controls.Add(btnMyLands);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(btnCropSuggestions);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 734);
            panel1.TabIndex = 15;
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
            btnwater.Location = new Point(3, 470);
            btnwater.Name = "btnwater";
            btnwater.Size = new Size(180, 33);
            btnwater.TabIndex = 7;
            btnwater.Text = "🚰 Water Resources ";
            btnwater.TextAlign = ContentAlignment.BottomCenter;
            btnwater.UseVisualStyleBackColor = false;
            // 
            // btnEquioment
            // 
            btnEquioment.Anchor = AnchorStyles.None;
            btnEquioment.BackColor = Color.Transparent;
            btnEquioment.FlatAppearance.BorderColor = Color.White;
            btnEquioment.FlatAppearance.MouseDownBackColor = Color.White;
            btnEquioment.FlatAppearance.MouseOverBackColor = Color.White;
            btnEquioment.FlatStyle = FlatStyle.Flat;
            btnEquioment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEquioment.ForeColor = Color.FromArgb(23, 24, 29);
            btnEquioment.ImageAlign = ContentAlignment.TopCenter;
            btnEquioment.Location = new Point(-2, 419);
            btnEquioment.Name = "btnEquioment";
            btnEquioment.Size = new Size(180, 33);
            btnEquioment.TabIndex = 6;
            btnEquioment.Text = "🔧 Equipment";
            btnEquioment.TextAlign = ContentAlignment.BottomCenter;
            btnEquioment.UseVisualStyleBackColor = false;
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
            btnReports.Location = new Point(-7, 316);
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
            label1.Size = new Size(279, 72);
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
            btnExpertAdvice.Location = new Point(2, 371);
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
            btnEquipment.Location = new Point(-5, 694);
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
            btnMyLands.Location = new Point(-7, 261);
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
            btnInventory.Location = new Point(-7, 152);
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
            btnCropSuggestions.Location = new Point(-4, 205);
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
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1386, 33);
            menuStrip1.TabIndex = 14;
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
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(171, 34);
            exitToolStripMenuItem.Text = "Exit";
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
            // ConsultationForm
            // 
            ClientSize = new Size(1386, 767);
            Controls.Add(tabControlExpert);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "ConsultationForm";
            tabControlExpert.ResumeLayout(false);
            tabRequest.ResumeLayout(false);
            tabRequest.PerformLayout();
            ((ISupportInitialize)grdrequest).EndInit();
            tabexpertresponse.ResumeLayout(false);
            tabexpertresponse.PerformLayout();
            ((ISupportInitialize)dataGridView1).EndInit();
            ((ISupportInitialize)numericRating).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private void tabexpertresponse_Click(object sender, EventArgs e)
        {

        }
    }
}
