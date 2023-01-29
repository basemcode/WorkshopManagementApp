using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class StockOutData
{
    public static IEnumerable<StockOutModel> GetAllStockOuts() =>
        SqlDataAccess.LoadData<StockOutModel, dynamic>("dbo.spStockOut_GetAll", new { });

    public static int InsertStockOut(StockOutModel Item) =>
        SqlDataAccess.SaveDataAndReturnLastID<dynamic>("dbo.spStockOut_Insert", new
        {
            Item.Date,
            Item.UserID,
            Item.Note, 
        });

    public static void UpdateStockOut(StockOutModel Item) =>
        SqlDataAccess.SaveData("dbo.spStockOut_Update", Item);

    public static int DeleteStockOut(int StockOutID) =>
        SqlDataAccess.SaveData("dbo.spStockOut_Delete", new { StockOutID = StockOutID });
}
