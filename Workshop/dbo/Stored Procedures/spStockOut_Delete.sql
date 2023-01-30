

CREATE     PROCEDURE [dbo].[spStockOut_Delete]
           @StockOutID int
AS
BEGIN
  BEGIN TRY
    BEGIN TRANSACTION;
declare @ItemID int;
declare @Quantity int;
declare @BoxesQuantity int;

/****** begin of cursor ******/
declare StockOuts_cursor CURSOR FOR

select ItemID,Quantity,BoxesQuantity from StockOutDetails
where StockOutID=@StockOutID

open StockOuts_cursor    --open and start cursor

fetch next from StockOuts_cursor into @ItemID, @Quantity,@BoxesQuantity

while @@FETCH_STATUS=0
begin
update Items
set QuantityInStock=QuantityInStock+@Quantity,
	BoxesQuantity=BoxesQuantity+@BoxesQuantity
where ItemID=@ItemID
fetch next from StockOuts_cursor into @ItemID, @Quantity,@BoxesQuantity
end

close StockOuts_cursor  --open and start cursor
deallocate StockOuts_cursor 
/****** end of cursor ******/

--delete all records with StockOutID from StockOutDetails
delete from StockOutDetails
where StockOutID=@StockOutID

--delete StockOut record from StockOuts
delete from StockOut
where StockOutID=@StockOutID

COMMIT TRANSACTION;
  END TRY
  BEGIN CATCH
    ROLLBACK TRANSACTION;
  END CATCH
  
END
