

create PROCEDURE [dbo].[spStockOut_GetAll]
AS
begin
SELECT 
		[StockOut].StockOutID
		,[StockOut].[Date]
		,[StockOut].UserID
		,[Users].FirstName+' '+[Users].MiddleName as UserFullName
		,[StockOut].Note
FROM dbo.[StockOut]
INNER JOIN [Users] ON StockOut.UserID=[Users].UserID;

	
end
