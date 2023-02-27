CREATE PROCEDURE [dbo].[spStockInDetails_GetSumOfStockInsOfItem]
  @itemID int,
  @MinMonth date,
  @MaxMonth date
AS
begin
     select sum(Quantity) from StockIn inner join StockInDetails
     on StockIn.StockInID=StockInDetails.StockInID
     where dbo.TRUNC_DATE(StockIn.[Date],'MONTH')>=dbo.TRUNC_DATE(@MinMonth,'MONTH') and dbo.TRUNC_DATE(StockIn.[Date],'MONTH')<=dbo.TRUNC_DATE(@MaxMonth,'MONTH')
     and ItemID=@itemID
end
