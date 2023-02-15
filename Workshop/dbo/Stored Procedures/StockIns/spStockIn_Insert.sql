
CREATE PROCEDURE [dbo].[spStockIn_Insert]
           @Date datetime,
           @UserID int,
           @Note nvarchar(max)  
AS
begin
	insert into [dbo].[StockIn]
           ([Date],
			[UserID],
			[Note])		
	values (@Date,
           @UserID,
           @Note);

		   select cast( SCOPE_IDENTITY() as int)	  
end

