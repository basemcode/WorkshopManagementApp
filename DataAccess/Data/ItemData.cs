using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class ItemData 
{
    public static IEnumerable<ItemModel> GetAllItems() =>
        SqlDataAccess.LoadData<ItemModel, dynamic>("dbo.spItem_GetAll", new { });
    public static IEnumerable<string> GetSubGroups() =>
        SqlDataAccess.LoadData<string, dynamic>("dbo.spItem_GetSubGroups", new { });
    public static IEnumerable<string> GetAllBarcodes() =>
        SqlDataAccess.LoadData<string, dynamic>("dbo.spItem_GetAllBarcodes", new { });

    public static IEnumerable<ItemModel> GetItemsOfCategory(string category) =>
        SqlDataAccess.LoadData<ItemModel, dynamic>("dbo.spItem_GetItemsOfCategory", new { Category=category});

    public static ItemModel? GetItem(int ItemID)
    {
        var results = SqlDataAccess.LoadData<ItemModel, dynamic>(
            "dbo.spItem_Get",
            new { ItemID = ItemID });
        return results.FirstOrDefault();
    }

    public static ItemModel GetItemByBarcode(string Barcode)
    {
        var results = SqlDataAccess.LoadData<ItemModel, dynamic>(
            "dbo.spItem_GetByBarcode",
            new { Barcode = Barcode });
        return results.FirstOrDefault();
    }

    public static void InsertItem(ItemModel Item) =>
        SqlDataAccess.SaveData("dbo.spItem_Insert", Item);
    
    public static void UpdateItem(ItemModel Item) =>
        SqlDataAccess.SaveData("dbo.spItem_Update", Item);

    public static void UpdateItemImage(ItemModel Item) =>
        SqlDataAccess.SaveData("dbo.spItem_UpdateImage", new {ItemID=Item.ItemID,Image=Item.Image});

    public static void DeleteItem(int ItemID) =>
        SqlDataAccess.SaveData("dbo.spItem_Delete", new { ItemID = ItemID });
    public static void SetInitialQuantity(string barcode,int InitialQuantity,int BoxesInitialQuantity, int PeriodID) =>
        SqlDataAccess.SaveData("dbo.spItem_SetInitialQuantity",new { barcode, InitialQuantity, BoxesInitialQuantity, PeriodID });
    public static void DeployAllInitialQuantity( int PeriodID) =>
        SqlDataAccess.SaveData("dbo.spItem_DeployAllInitialQuantity", new {  PeriodID });
    
}
