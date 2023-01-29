using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class StockInData
{
    public static IEnumerable<StockInModel> GetAllStockIns() =>
        SqlDataAccess.LoadData<StockInModel, dynamic>("dbo.spStockIn_GetAll", new { });
    
    public static int InsertStockIn(StockInModel Item) =>
        SqlDataAccess.SaveDataAndReturnLastID<dynamic>("dbo.spStockIn_Insert", new
        {
            Item.Date,
            Item.UserID,
            Item.Note, 
        });

    public static void UpdateStockIn(StockInModel Item) =>
        SqlDataAccess.SaveData("dbo.spStockIn_Update", Item);

    public static int DeleteStockIn(int StockInID) =>
        SqlDataAccess.SaveData("dbo.spStockIn_Delete", new { StockInID = StockInID });
}
