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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            addStockToolStripMenuItem = new ToolStripMenuItem();
            recordUsageToolStripMenuItem = new ToolStripMenuItem();
            requestAdviceToolStripMenuItem = new ToolStripMenuItem();
            btnReports = new Button();
            btnExpertAdvice = new Button();
            btnEquipment = new Button();
            btnInventory = new Button();
            btnCropSuggestions = new Button();
            btnMyLands = new Button();
            dataGridViewRecent = new DataGridView();
            statusStrip1 = new StatusStrip();
            toolStripStatusUser = new ToolStripStatusLabel();
            toolStripStatusLastLogin = new ToolStripStatusLabel();
            toolStripStatusConnection = new ToolStripStatusLabel();
            panelRight = new Panel();
            lblAlerts = new Label();
            lstAlerts = new ListBox();
            lblStorage = new Label();
            progressStorage = new ProgressBar();
            lblSeason = new Label();
            progressSeason = new ProgressBar();
            panel1 = new Panel();
            label1 = new Label();
            panelWeather = new Panel();
            lblWeatherHeader = new Label();
            dgvWeatherForecast = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecent).BeginInit();
            statusStrip1.SuspendLayout();
            panelRight.SuspendLayout();
            panel1.SuspendLayout();
            panelWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWeatherForecast).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1258, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
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
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(59, 20);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // addStockToolStripMenuItem
            // 
            addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            addStockToolStripMenuItem.Size = new Size(180, 22);
            addStockToolStripMenuItem.Text = "Add Stock";
            // 
            // recordUsageToolStripMenuItem
            // 
            recordUsageToolStripMenuItem.Name = "recordUsageToolStripMenuItem";
            recordUsageToolStripMenuItem.Size = new Size(180, 22);
            recordUsageToolStripMenuItem.Text = "Record Usage";
            // 
            // requestAdviceToolStripMenuItem
            // 
            requestAdviceToolStripMenuItem.Name = "requestAdviceToolStripMenuItem";
            requestAdviceToolStripMenuItem.Size = new Size(180, 22);
            requestAdviceToolStripMenuItem.Text = "Request Advice";
            // 
            // btnReports
            // 
            btnReports.Anchor = AnchorStyles.None;
            btnReports.BackColor = Color.Transparent;
            btnReports.FlatAppearance.BorderColor = Color.LimeGreen;
            btnReports.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnReports.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.ImageAlign = ContentAlignment.TopCenter;
            btnReports.Location = new Point(0, 253);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(180, 33);
            btnReports.TabIndex = 5;
            btnReports.Text = "📑 Reports";
            btnReports.TextAlign = ContentAlignment.BottomCenter;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnExpertAdvice
            // 
            btnExpertAdvice.Anchor = AnchorStyles.None;
            btnExpertAdvice.BackColor = Color.Transparent;
            btnExpertAdvice.FlatAppearance.BorderColor = Color.LimeGreen;
            btnExpertAdvice.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnExpertAdvice.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnExpertAdvice.FlatStyle = FlatStyle.Flat;
            btnExpertAdvice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExpertAdvice.ForeColor = Color.White;
            btnExpertAdvice.ImageAlign = ContentAlignment.TopCenter;
            btnExpertAdvice.Location = new Point(3, 311);
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
            btnEquipment.FlatAppearance.BorderColor = Color.LimeGreen;
            btnEquipment.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnEquipment.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnEquipment.FlatStyle = FlatStyle.Flat;
            btnEquipment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEquipment.ForeColor = Color.White;
            btnEquipment.ImageAlign = ContentAlignment.TopCenter;
            btnEquipment.Location = new Point(0, 378);
            btnEquipment.Name = "btnEquipment";
            btnEquipment.Size = new Size(180, 33);
            btnEquipment.TabIndex = 3;
            btnEquipment.Text = "🔧 Equipment";
            btnEquipment.TextAlign = ContentAlignment.BottomCenter;
            btnEquipment.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            btnInventory.Anchor = AnchorStyles.None;
            btnInventory.BackColor = Color.Transparent;
            btnInventory.FlatAppearance.BorderColor = Color.LimeGreen;
            btnInventory.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnInventory.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.ImageAlign = ContentAlignment.TopCenter;
            btnInventory.Location = new Point(0, 81);
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
            btnCropSuggestions.FlatAppearance.BorderColor = Color.LimeGreen;
            btnCropSuggestions.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnCropSuggestions.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnCropSuggestions.FlatStyle = FlatStyle.Flat;
            btnCropSuggestions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCropSuggestions.ForeColor = Color.White;
            btnCropSuggestions.ImageAlign = ContentAlignment.TopCenter;
            btnCropSuggestions.Location = new Point(3, 137);
            btnCropSuggestions.Name = "btnCropSuggestions";
            btnCropSuggestions.Size = new Size(180, 33);
            btnCropSuggestions.TabIndex = 1;
            btnCropSuggestions.Text = "📊 Crop Suggestions";
            btnCropSuggestions.TextAlign = ContentAlignment.BottomCenter;
            btnCropSuggestions.UseVisualStyleBackColor = false;
            // 
            // btnMyLands
            // 
            btnMyLands.Anchor = AnchorStyles.None;
            btnMyLands.BackColor = Color.Transparent;
            btnMyLands.FlatAppearance.BorderColor = Color.LimeGreen;
            btnMyLands.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnMyLands.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnMyLands.FlatStyle = FlatStyle.Flat;
            btnMyLands.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMyLands.ForeColor = Color.White;
            btnMyLands.ImageAlign = ContentAlignment.TopCenter;
            btnMyLands.Location = new Point(0, 194);
            btnMyLands.Name = "btnMyLands";
            btnMyLands.Size = new Size(180, 33);
            btnMyLands.TabIndex = 0;
            btnMyLands.Text = "🌱 My Lands";
            btnMyLands.TextAlign = ContentAlignment.BottomCenter;
            btnMyLands.UseVisualStyleBackColor = false;
            // 
            // dataGridViewRecent
            // 
            dataGridViewRecent.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewRecent.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRecent.Dock = DockStyle.Bottom;
            dataGridViewRecent.Location = new Point(0, 500);
            dataGridViewRecent.Name = "dataGridViewRecent";
            dataGridViewRecent.Size = new Size(1258, 150);
            dataGridViewRecent.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Honeydew;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusUser, toolStripStatusLastLogin, toolStripStatusConnection });
            statusStrip1.Location = new Point(0, 478);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1258, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusUser
            // 
            toolStripStatusUser.ForeColor = Color.DarkGreen;
            toolStripStatusUser.Name = "toolStripStatusUser";
            toolStripStatusUser.Size = new Size(73, 17);
            toolStripStatusUser.Text = "User: Farmer";
            // 
            // toolStripStatusLastLogin
            // 
            toolStripStatusLastLogin.ForeColor = Color.DarkGreen;
            toolStripStatusLastLogin.Name = "toolStripStatusLastLogin";
            toolStripStatusLastLogin.Size = new Size(125, 17);
            toolStripStatusLastLogin.Text = "Last Login: 2024-05-10";
            // 
            // toolStripStatusConnection
            // 
            toolStripStatusConnection.ForeColor = Color.DarkGreen;
            toolStripStatusConnection.Name = "toolStripStatusConnection";
            toolStripStatusConnection.Size = new Size(42, 17);
            toolStripStatusConnection.Text = "Online";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.LightGreen;
            panelRight.Controls.Add(lblAlerts);
            panelRight.Controls.Add(lstAlerts);
            panelRight.Controls.Add(lblStorage);
            panelRight.Controls.Add(progressStorage);
            panelRight.Controls.Add(lblSeason);
            panelRight.Controls.Add(progressSeason);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(958, 24);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(300, 454);
            panelRight.TabIndex = 6;
            // 
            // lblAlerts
            // 
            lblAlerts.AutoSize = true;
            lblAlerts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAlerts.Location = new Point(10, 10);
            lblAlerts.Name = "lblAlerts";
            lblAlerts.Size = new Size(102, 19);
            lblAlerts.TabIndex = 0;
            lblAlerts.Text = "Urgent Alerts:";
            // 
            // lstAlerts
            // 
            lstAlerts.ItemHeight = 15;
            lstAlerts.Items.AddRange(new object[] { "Silo 95% full!", "Wheat expiring in 5 days" });
            lstAlerts.Location = new Point(10, 40);
            lstAlerts.Name = "lstAlerts";
            lstAlerts.Size = new Size(270, 49);
            lstAlerts.TabIndex = 1;
            // 
            // lblStorage
            // 
            lblStorage.AutoSize = true;
            lblStorage.Location = new Point(10, 110);
            lblStorage.Name = "lblStorage";
            lblStorage.Size = new Size(96, 15);
            lblStorage.TabIndex = 2;
            lblStorage.Text = "Storage Capacity";
            // 
            // progressStorage
            // 
            progressStorage.BackColor = Color.FromArgb(129, 199, 132);
            progressStorage.Location = new Point(10, 130);
            progressStorage.Name = "progressStorage";
            progressStorage.Size = new Size(270, 20);
            progressStorage.TabIndex = 3;
            progressStorage.Value = 95;
            // 
            // lblSeason
            // 
            lblSeason.AutoSize = true;
            lblSeason.Location = new Point(10, 170);
            lblSeason.Name = "lblSeason";
            lblSeason.Size = new Size(92, 15);
            lblSeason.TabIndex = 4;
            lblSeason.Text = "Season Progress";
            // 
            // progressSeason
            // 
            progressSeason.BackColor = Color.FromArgb(129, 199, 132);
            progressSeason.Location = new Point(10, 190);
            progressSeason.Name = "progressSeason";
            progressSeason.Size = new Size(270, 20);
            progressSeason.TabIndex = 5;
            progressSeason.Value = 40;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
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
            panel1.Size = new Size(186, 454);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(180, 50);
            label1.TabIndex = 0;
            label1.Text = "Dashboard\r\n________________________";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelWeather
            // 
            panelWeather.BackColor = Color.WhiteSmoke;
            panelWeather.BorderStyle = BorderStyle.FixedSingle;
            panelWeather.Controls.Add(lblWeatherHeader);
            panelWeather.Controls.Add(dgvWeatherForecast);
            panelWeather.Dock = DockStyle.Fill;
            panelWeather.Location = new Point(186, 24);
            panelWeather.Name = "panelWeather";
            panelWeather.Size = new Size(772, 454);
            panelWeather.TabIndex = 8;
            // 
            // lblWeatherHeader
            // 
            lblWeatherHeader.AutoSize = true;
            lblWeatherHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWeatherHeader.Location = new Point(10, 10);
            lblWeatherHeader.Name = "lblWeatherHeader";
            lblWeatherHeader.Size = new Size(203, 20);
            lblWeatherHeader.TabIndex = 0;
            lblWeatherHeader.Text = "📅 5-Day Weather Forecast";
            // 
            // dgvWeatherForecast
            // 
            dgvWeatherForecast.AllowUserToAddRows = false;
            dgvWeatherForecast.AllowUserToResizeRows = false;
            dgvWeatherForecast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvWeatherForecast.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvWeatherForecast.DefaultCellStyle = dataGridViewCellStyle4;
            dgvWeatherForecast.Location = new Point(10, 40);
            dgvWeatherForecast.Name = "dgvWeatherForecast";
            dgvWeatherForecast.ReadOnly = true;
            dgvWeatherForecast.RowHeadersVisible = false;
            dgvWeatherForecast.Size = new Size(750, 230);
            dgvWeatherForecast.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FarmerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 245, 233);
            ClientSize = new Size(1258, 650);
            Controls.Add(panelWeather);
            Controls.Add(panel1);
            Controls.Add(panelRight);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridViewRecent);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 600);
            Name = "FarmerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmer Dashboard";
            Load += FarmerDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecent).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelWeather.ResumeLayout(false);
            panelWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWeatherForecast).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordUsageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestAdviceToolStripMenuItem;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExpertAdvice;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnCropSuggestions;
        private System.Windows.Forms.Button btnMyLands;
        private System.Windows.Forms.DataGridView dataGridViewRecent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLastLogin;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusConnection;
        private Panel panelRight;
        private Label lblAlerts;
        private ListBox lstAlerts;
        private Label lblStorage;
        private ProgressBar progressStorage;
        private Label lblSeason;
        private ProgressBar progressSeason;
        private Panel panel1;
        private Label label1;
        private Panel panelWeather;
        private Label lblCity;
        private PictureBox picWeatherIcon;
        private Label lblWeatherHeader;
        private DataGridView dgvWeatherForecast;
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
    }
}