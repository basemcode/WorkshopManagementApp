


CREATE   PROCEDURE [dbo].[spStockInDetails_Insert]
           @StockInID int,
           @ItemID int,
           @Quantity int,
		   @BoxesQuantity int
AS
begin
	insert into [dbo].[StockInDetails]
           ([StockInID],
			[ItemID],
			[Quantity],
			[BoxesQuantity])
	values (@StockInID,
           @ItemID,
		   @Quantity,
		   @BoxesQuantity)

		   Update dbo.Items set QuantityInStock=QuantityInStock+@Quantity,BoxesQuantity=BoxesQuantity+@BoxesQuantity
		   where ItemID=@ItemID
end

