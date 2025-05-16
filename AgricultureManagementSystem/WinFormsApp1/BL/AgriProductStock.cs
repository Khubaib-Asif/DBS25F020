using System;
using System.Collections.Generic;
using AgricultureManagementSystem.DL;

namespace AgricultureManagementSystem.BL
{
    public class AgriProductStock
    {
        public int StockID { get; set; }
        public int AgriID { get; set; }
        public int FarmerID { get; set; }
        public string AgriName { get; set; }
        public string Location { get; set; }
        public string CompanyName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Total { get; private set; }

        public AgriProductStock()
        {
            EntryDate = DateTime.Now.Date; // Default to today
        }

        public AgriProductStock(int stockID, int agriID, int farmerID, string agriName,
                                string location, string companyName, decimal quantity,
                                decimal price, DateTime entryDate, DateTime expiryDate)
        {
            StockID = stockID;
            AgriID = agriID;
            FarmerID = farmerID;
            AgriName = agriName;
            Location = location;
            CompanyName = companyName;
            Quantity = quantity;
            Price = price;
            EntryDate = entryDate;
            ExpiryDate = expiryDate;
            UpdateTotal();
        }

        public AgriProductStock(int agriID, int farmerID, string agriName, string location,
                              string company, decimal quantity, decimal price, DateTime expiryDate)
        {
            AgriID = agriID;
            FarmerID = farmerID;
            AgriName = agriName;
            Location = location;
            CompanyName = company;
            Quantity = quantity;
            Price = price;
            ExpiryDate = expiryDate;
            EntryDate = DateTime.Now.Date;
            UpdateTotal();
        }

        public void UpdateTotal()
        {
            Total = Quantity * Price;
        }

        public static bool QuantityChecker(string quantity)
        {
            return decimal.TryParse(quantity, out decimal result) && result > 0;
        }

        public static bool PriceChecker(string price)
        {
            return decimal.TryParse(price, out decimal result) && result > 0;
        }

        public bool IsValid(out string validationMessage)
        {
            if (AgriID <= 0)
            {
                validationMessage = "Invalid AgriID.";
                return false;
            }
            if (FarmerID <= 0)
            {
                validationMessage = "Invalid FarmerID.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(AgriName))
            {
                validationMessage = "AgriName is required.";
                return false;
            }
            if (Quantity <= 0)
            {
                validationMessage = "Quantity must be greater than 0.";
                return false;
            }
            if (Price < 0)
            {
                validationMessage = "Price cannot be negative.";
                return false;
            }
            if (ExpiryDate < EntryDate.Date)
            {
                validationMessage = "ExpiryDate cannot be earlier than Entry date.";
                return false;
            }

            validationMessage = null;
            return true;
        }

        public bool Save()
        {
            if (!IsValid(out string message))
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            AgriProductStockDL dl = new AgriProductStockDL();
            return dl.InsertAgriProductStock(this);
        }
    }
}