using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class StockOutDetailData
{
    public static IEnumerable<StockOutDetailModel> GetAllDetailsOfStockOut(int StockOutID) =>
        SqlDataAccess.LoadData<StockOutDetailModel, dynamic>("dbo.spStockOutDetails_GetAllDetailsOfStockOut", new { StockOutID = StockOutID });

    public static void InsertStockOutDetail(StockOutDetailModel Item) =>
        SqlDataAccess.SaveData("dbo.spStockOutDetails_Insert", new
        {
            Item.StockOutID,
            Item.ItemID,
            Item.Quantity,
            Item.BoxesQuantity
        });

    public static void UpdateStockOut(StockOutModel Item) =>
        SqlDataAccess.SaveData("dbo.spStockOut_Update", Item);

    public static void DeleteStockOut(int StockOutID) =>
        SqlDataAccess.SaveData("dbo.spStockOut_Delete", new { StockOutID = StockOutID });
}
