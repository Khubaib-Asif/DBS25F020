namespace AgricultureManagementSystem.Farmer
{
    partial class ReportGenerater
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
            cmbreportgenerater = new ComboBox();
            label1 = new Label();
            btnGenerate = new Button();
            btnExport = new Button();
            dataGridView1 = new DataGridView();
            btnDashboard = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbreportgenerater
            // 
            cmbreportgenerater.FormattingEnabled = true;
            cmbreportgenerater.Location = new Point(526, 207);
            cmbreportgenerater.Name = "cmbreportgenerater";
            cmbreportgenerater.Size = new Size(397, 32);
            cmbreportgenerater.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(572, 157);
            label1.Name = "label1";
            label1.Size = new Size(295, 24);
            label1.TabIndex = 1;
            label1.Text = "Select Which Report you want";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(618, 267);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(204, 34);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(618, 320);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(204, 34);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(150, 404);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1194, 225);
            dataGridView1.TabIndex = 5;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(52, 59);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(204, 34);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "DashBoard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // ReportGenerater
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1583, 629);
            Controls.Add(btnDashboard);
            Controls.Add(dataGridView1);
            Controls.Add(btnExport);
            Controls.Add(btnGenerate);
            Controls.Add(label1);
            Controls.Add(cmbreportgenerater);
            Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ReportGenerater";
            RightToLeft = RightToLeft.No;
            Text = "ReportGenerater";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbreportgenerater;
        private Label label1;
        private Button btnGenerate;
        private Button btnExport;
        private DataGridView dataGridView1;
        private Button btnDashboard;
    }
}