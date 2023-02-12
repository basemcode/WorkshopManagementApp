

CREATE   PROCEDURE [dbo].[spStockOutDetails_GetAllDetailsOfStockOut]
@StockOutID int
AS
begin
SELECT 
		Items.Barcode
		,Items.ItemCodeWithColor
		,Items.[Image]
		,[StockOutDetails].StockOutDetailID
		,[StockOutDetails].ItemID
		,[StockOutDetails].Quantity
		,[StockOutDetails].BoxesQuantity
		,Items.ProductName
		,Items.Category
		
		
FROM dbo.[StockOutDetails]

INNER JOIN [Items] ON StockOutDetails.ItemID=[Items].ItemID
where StockOutID= @StockOutID;
end
