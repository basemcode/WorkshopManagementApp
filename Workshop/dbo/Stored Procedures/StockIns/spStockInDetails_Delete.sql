CREATE PROCEDURE [dbo].[spStockInDetails_Delete]
	@StockInDetailID int	
AS
BEGIN
  BEGIN TRY
	BEGIN TRANSACTION;
		declare @StockInID int ;
		declare @ItemID int ;
		declare @Quantity int ;
		declare @BoxesQuantity int ;
		
		SELECT @StockInID = s.StockInID 
			  ,@ItemID=ItemID
			  ,@Quantity=Quantity
			  ,@BoxesQuantity=BoxesQuantity
		FROM dbo.StockInDetails s
		WHERE s.StockInDetailID = @StockInDetailID
		
		UPDATE Items
		SET QuantityInStock=QuantityInStock-@Quantity,
			BoxesQuantity=BoxesQuantity-@BoxesQuantity
		WHERE ItemID=@ItemID
		
		DELETE FROM StockInDetails 
		WHERE StockInDetailID=@StockInDetailID
	COMMIT TRANSACTION;
  END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
END CATCH
  
END
