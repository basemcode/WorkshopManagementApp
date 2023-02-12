

CREATE   PROCEDURE [dbo].[spStockOut_Insert]
           @Date datetime,
           @UserID int,
           @Note nvarchar(max)  
AS
begin
	insert into [dbo].[StockOut]
           ([Date],
			[UserID],
			[Note])		
	values (@Date,
           @UserID,
           @Note);

		   select cast( SCOPE_IDENTITY() as int)	  
end

