using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class StockInDetailData
{
    public static IEnumerable<StockInDetailModel> GetAllDetailsOfStockIn(int StockInID) =>
        SqlDataAccess.LoadData<StockInDetailModel, dynamic>("dbo.spStockInDetails_GetAllDetailsOfStockIn", new { StockInID = StockInID });

    public static void InsertStockInDetail(StockInDetailModel Item) =>
        SqlDataAccess.SaveData("dbo.spStockInDetails_Insert", new
        {
            Item.StockInID,
            Item.ItemID,
            Item.Quantity,
            Item.BoxesQuantity
        });

    public static void UpdateStockIn(StockInModel Item) =>
        SqlDataAccess.SaveData("dbo.spStockIn_Update", Item);

    public static void DeleteStockIn(int StockInID) =>
        SqlDataAccess.SaveData("dbo.spStockIn_Delete", new { StockInID = StockInID });
}
