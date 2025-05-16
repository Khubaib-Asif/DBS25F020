using System;
using System.Collections.Generic;
using System.Data;
using AgricultureManagementSystem.DL;

namespace AgricultureManagementSystem.BL
{
    public class CropStock
    {
        public int BatchId { get; set; }
        public int CropId { get; set; }
        public int FarmerId { get; set; }
        public string Location { get; set; }
        public string Purpose { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
       
       
        public CropStock(int cropId, int farmerId, string location, string purpose, decimal price, decimal quantity)
        {
            CropId = cropId;
            FarmerId = farmerId;
            Location = location;
            Purpose = purpose;
            Price = price;
            Quantity = quantity;
           
        }

        public CropStock(int farmerId)
        {
            FarmerId = farmerId;
        }
        public CropStock() { }
        public static bool QuantityChecker(string quantity)
        {
            return decimal.TryParse(quantity, out decimal result) && result > 0;
        }

        public static bool PriceChecker(string price)
        {
            return decimal.TryParse(price, out decimal result) && result > 0;
        }

        public bool Save()
        {
            return CropBatchDL.InsertCropBatch(this);
        }

        public bool Update()
        {
            return CropBatchDL.UpdateCropBatch(this);
        }
      
        public bool Delete()
        {
            return CropBatchDL.DeleteCropBatch(this.BatchId);
        }

        public static List<CropStock> GetByFarmer(int farmerId)
        {
            return CropBatchDL.GetCropStocksByFarmer(farmerId);
        }
        
        public static CropStock GetById(int batchId)
        {
            return CropBatchDL.GetCropBatchById(batchId);
        }

        public static DataTable GetStockDataTable(int farmerId)
        {
            return CropBatchDL.GetStockDataTable(farmerId);
        }
    }
}