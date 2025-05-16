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

namespace AgricultureManagementSystem.Farmer
{
    public partial class AgriProductForm : Form
    {
        FarmerProfile profile1;

        public AgriProductForm(FarmerProfile profile)
        {
            InitializeComponent();
            profile1 = profile;
            this.Size = new Size(1360, 860);
            this.StartPosition = FormStartPosition.CenterScreen;
            loadCombo();
            loadGrid();
        }

        private void loadGrid()
        {
            try
            {
                List<AgriProductStock> stocks = AgriProductStockDL.GetAllAgriProductStocks(profile1.FarmerID);

                var displayList = stocks.Select(s => new
                {
                    BatchID = s.StockID,
                    Category = AgriProductStockDL.GetCategoryName(s.AgriID),
                    Product = s.AgriName,
                    Company = s.CompanyName,
                    Location = s.Location,
                    Quantity = s.Quantity,
                    Price = s.Price,
                    Total = s.Total,
                    ExpiryDate = s.ExpiryDate.ToString("yyyy-MM-dd")
                }).ToList();

                grdstock.DataSource = displayList;
                grdstock.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grid: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadCombo()
        {
            try
            {
                cmbcatagory.DisplayMember = "Type";
                cmbcatagory.ValueMember = "aggriid";
                cmbcatagory.DataSource = AgriProductStockDL.Loadcombobox();
                cmbcatagory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnaddagri_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (cmbcatagory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtcompany.Text) ||
                    string.IsNullOrWhiteSpace(txtagriname.Text) ||
                    string.IsNullOrWhiteSpace(txtlocation.Text))
                {
                    MessageBox.Show("Company, Product Name, and Location are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtquanitty.Text, out decimal quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtprice.Text, out decimal price) || price < 0)
                {
                    MessageBox.Show("Please enter a valid price (0 or greater).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create and save the product
                int agriId = (int)cmbcatagory.SelectedValue;
                DateTime expiryDate = dtvExpirydate.Value.Date;

                AgriProductStock stock = new AgriProductStock(
                    agriId,
                    profile1.FarmerID,
                    txtagriname.Text.Trim(),
                    txtlocation.Text.Trim(),
                    txtcompany.Text.Trim(),
                    quantity,
                    price,
                    expiryDate
                );

                if (stock.Save())
                {
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    loadGrid();
                }
                else
                {
                    MessageBox.Show("Failed to save the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtcompany.Clear();
            txtagriname.Clear();
            txtlocation.Clear();
            txtquanitty.Clear();
            txtprice.Clear();
            cmbcatagory.SelectedIndex = -1;
            dtvExpirydate.Value = DateTime.Now.AddMonths(1);
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

        private void btndashboard_Click(object sender, EventArgs e)
        {
            FarmerDashboard farmerDashboard = new FarmerDashboard(profile1);
            farmerDashboard.Show();
            this.Hide();
        }
    }
}