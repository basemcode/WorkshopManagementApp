﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class StockInDetailModel
    {
        public int StockInDetailID { get; set; }
        public int StockInID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public int BoxesQuantity { get; set; }
        public string ItemCodeWithColor { get; set; }
        public string Barcode { get; set; }
        public byte[] Image { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
    }
}
