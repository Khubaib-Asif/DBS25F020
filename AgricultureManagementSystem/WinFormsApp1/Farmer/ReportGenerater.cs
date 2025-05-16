using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AgricultureManagementSystem.Farmer
{
    public partial class ReportGenerater : Form
    {
        private string connectionString = "server=127.0.0.1;port=3306;user=root;password=22138sma.;database=project_20;AllowPublicKeyRetrieval=True;SslMode=none;";
        FarmerProfile profile = new FarmerProfile();
        public ReportGenerater(FarmerProfile farmerProfile)
        {
            this.profile = farmerProfile;
            InitializeComponent();
            cmbreportgenerater.Items.AddRange(new string[]
            {
                "Farmer Inventory Report",
                "Crop Production Report",
                "Equipment Utilization Report",
                "Water Resource Usage Report",
                "Financial Summary Report",
                "Expiring Products Alert Report"
            });
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string query = GetQuery(cmbreportgenerater.SelectedItem?.ToString());
            if (query == null)
            {
                MessageBox.Show("Please select a report type.");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = cmbreportgenerater.SelectedItem + ".pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportToPDF(sfd.FileName);
            }
        }

        private void ExportToPDF(string filePath)
        {
            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
            pdfTable.WidthPercentage = 100;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                pdfTable.AddCell(new Phrase(column.HeaderText));
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value?.ToString() ?? "");
                }
            }

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 10f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph(cmbreportgenerater.SelectedItem.ToString(), FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD)));
                pdfDoc.Add(new Paragraph("Generated On: " + DateTime.Now.ToString()));
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }

            MessageBox.Show("PDF Exported Successfully!");
        }

        private string GetQuery(string reportName)
        {
            switch (reportName)
            {
                case "Farmer Inventory Report":
                    return @"SELECT f.first_name as FirstName, f.last_name as LastName, f.contact as Contact,
                             aps.aggri_Name AS product_name, aps.quantity as Quantity, aps.price as Price, aps.Total,
                             a.Type AS product_category , aps.expiryDate
                             FROM farmer_profile f
                             JOIN aggriproducts_stock aps ON f.farmer_id = aps.farmer_id
                             JOIN aggri a ON aps.aggri_id = a.aggriid
                             ORDER BY f.first_name, aps.expiryDate";

                case "Crop Production Report":
                    return @"SELECT f.first_name, f.last_name, c.crop_name,
                             pc.year, pc.season, pc.area, pc.status,
                             l.location AS land_location, l.soil_type
                             FROM farmer_profile f
                             JOIN planted_crops pc ON f.farmer_id = pc.farmer_id
                             JOIN crop c ON pc.crop_id = c.crop_id
                             JOIN land l ON pc.land_id = l.land_id
                             ORDER BY pc.year DESC, pc.season";

                case "Equipment Utilization Report":
                    return @"SELECT f.first_name, f.last_name,
                             e.eq_name AS equipment_type,
                             COALESCE(oe.model, re.model) AS model,
                             CASE WHEN oe.owned_id IS NOT NULL THEN 'Owned' ELSE 'Rented' END AS ownership_type,
                             oe.cost AS purchase_cost, re.rental_cost,
                             re.rental_start_date, re.rental_end_date
                             FROM farmer_profile f
                             LEFT JOIN owned_equipment oe ON f.farmer_id = oe.farmer_id
                             LEFT JOIN equipments e ON oe.eq_id = e.eq_id
                             LEFT JOIN rented_equipment re ON f.farmer_id = re.farmer_id AND re.eq_id = e.eq_id
                             WHERE oe.owned_id IS NOT NULL OR re.rental_id IS NOT NULL";

                case "Water Resource Usage Report":
                    return @"SELECT f.first_name, f.last_name,
                             c.crop_name, wr.type AS water_source,
                             wu.usage_hours, wr.cost_per_hour, wu.total_cost,
                             pc.year, pc.season
                             FROM water_usage wu
                             JOIN water_resources wr ON wu.w_id = wr.w_id
                             JOIN planted_crops pc ON wu.planted_id = pc.p_id
                             JOIN crop c ON pc.crop_id = c.crop_id
                             JOIN farmer_profile f ON wr.farmer_id = f.farmer_id
                             ORDER BY pc.year, pc.season";

                case "Financial Summary Report":
                    return @"SELECT f.first_name, f.last_name,
                             (SELECT SUM(Total) FROM aggriproducts_stock WHERE farmer_id = f.farmer_id) AS product_inventory_value,
                             (SELECT SUM(Total) FROM crop_batch WHERE Farmer_id = f.farmer_id) AS crop_sales_value,
                             (SELECT SUM(cost) FROM owned_equipment WHERE farmer_id = f.farmer_id) AS equipment_investment,
                             (SELECT SUM(rental_cost) FROM rented_equipment WHERE farmer_id = f.farmer_id) AS equipment_rental_cost,
                             (SELECT SUM(total_cost) FROM water_usage wu 
                                JOIN water_resources wr ON wu.w_id = wr.w_id 
                              WHERE wr.farmer_id = f.farmer_id) AS water_usage_cost
                             FROM farmer_profile f";

                case "Expiring Products Alert Report":
                    return @"SELECT f.first_name, f.last_name, f.contact,
                             aps.aggri_Name AS product_name, a.Type AS category,
                             aps.quantity, aps.expiryDate,
                             DATEDIFF(aps.expiryDate, CURDATE()) AS days_until_expiry
                             FROM aggriproducts_stock aps
                             JOIN farmer_profile f ON aps.farmer_id = f.farmer_id
                             JOIN aggri a ON aps.aggri_id = a.aggriid
                             WHERE aps.expiryDate BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 30 DAY)
                             ORDER BY days_until_expiry";

                default:
                    return null;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FarmerDashboard das = new FarmerDashboard(profile);
            das.Show();
            this.Close();
        }
    }
}
