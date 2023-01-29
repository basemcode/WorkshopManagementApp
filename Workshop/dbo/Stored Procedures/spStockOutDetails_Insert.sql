


CREATE   PROCEDURE [dbo].[spStockOutDetails_Insert]
           @StockOutID int,
           @ItemID int,
           @Quantity int,
		   @BoxesQuantity int
AS
begin
	insert into [dbo].[StockOutDetails]
           ([StockOutID],
			[ItemID],
			[Quantity],
			[BoxesQuantity])
	values (@StockOutID,
           @ItemID,
		   @Quantity,
		   @BoxesQuantity)

		   Update dbo.Items set QuantityInStock=QuantityInStock-@Quantity,BoxesQuantity=BoxesQuantity-@BoxesQuantity
		   where ItemID=@ItemID
end

