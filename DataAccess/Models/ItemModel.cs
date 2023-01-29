using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class ItemModel
{
    public int ItemID { get; set; }
    public string ItemCode { get; set; }
    public string ItemCodeWithColor { get; set; }
    public string Barcode { get; set; }
    public byte[] Image { get; set; }
    public string ItemNumberOnWB { get; set; }
    public string InternalCode { get; set; }
    public string ProductName { get; set; }
    public string Color { get; set; }
    public string HardboardBoxNumber { get; set; }
    public string Unit { get; set; }
    public string GofferNumber { get; set; }
    public string Note { get; set; }
    public string Category { get; set; }
    public int QuantityInStock { get; set; }
    public int MinimumQuantity { get; set; }
    public int BoxesQuantity { get; set; }
    
}
