CREATE   PROCEDURE [dbo].[spStockInDetails_GetAllDetailsOfStockIn]
@StockInID int
AS
begin
SELECT 
		Items.Barcode
		,Items.ItemCodeWithColor
		,Items.[Image]
		,[StockInDetails].StockInDetailID
		,[StockInDetails].ItemID
		,[StockInDetails].Quantity
		,[StockInDetails].BoxesQuantity
		,Items.ProductName
		,Items.Category
		
		
FROM dbo.[StockInDetails]

INNER JOIN [Items] ON StockInDetails.ItemID=[Items].ItemID
where StockInID= @StockInID;
end