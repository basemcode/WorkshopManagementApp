
CREATE     PROCEDURE [dbo].[spStockIn_Delete]
           @StockInID int
AS
BEGIN
  BEGIN TRY
    BEGIN TRANSACTION;
declare @ItemID int;
declare @Quantity int;
declare @BoxesQuantity int;

/****** begin of cursor ******/
declare StockIns_cursor CURSOR FOR

select ItemID,Quantity,BoxesQuantity from StockInDetails
where StockInID=@StockInID

open StockIns_cursor    --open and start cursor

fetch next from StockIns_cursor into @ItemID, @Quantity,@BoxesQuantity

while @@FETCH_STATUS=0
begin
update Items
set QuantityInStock=QuantityInStock-@Quantity,
	BoxesQuantity=BoxesQuantity-@BoxesQuantity
where ItemId=@ItemID
fetch next from StockIns_cursor into @ItemID, @Quantity,@BoxesQuantity
end

close StockIns_cursor  --open and start cursor
deallocate StockIns_cursor 
/****** end of cursor ******/

--delete all records with StockInID from StockInDetails
delete from StockInDetails
where StockInID=@StockInID

--delete StockIn record from StockIns
delete from StockIn
where StockInID=@StockInID

COMMIT TRANSACTION;
  END TRY
  BEGIN CATCH
    ROLLBACK TRANSACTION;
  END CATCH
  
END