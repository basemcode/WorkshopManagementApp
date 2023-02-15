
CREATE PROCEDURE [dbo].[spStockIn_GetAll]
AS
begin
SELECT 
		[StockIn].StockInID
		,[StockIn].[Date]
		,[StockIn].UserID
		,[Users].FirstName+' '+[Users].MiddleName as UserFullName
		,[StockIn].Note
FROM dbo.[StockIn]
INNER JOIN [Users] ON StockIn.UserID=[Users].UserID;

	
end
