

CREATE PROCEDURE [dbo].[spStockIn_Update]
		   @StockInID int,
		   @Date date,
           @UserID int,
           @Note nvarchar(max)
AS
begin
	update [dbo].[StockIn]

        set [Date]=@Date
           ,[UserID]=@UserID
           ,[Note]=@Note

	where [StockInID]=@StockInID
end

