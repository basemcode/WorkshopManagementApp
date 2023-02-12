CREATE PROCEDURE [dbo].[spStockOutDetails_Delete]
	@StockOutDetailID int	
AS
BEGIN
  BEGIN TRY
	BEGIN TRANSACTION;
		declare @StockOutID int ;
		declare @ItemID int ;
		declare @Quantity int ;
		declare @BoxesQuantity int ;
		
		SELECT @StockOutID = s.StockOutID 
			  ,@ItemID=ItemID
			  ,@Quantity=Quantity
			  ,@BoxesQuantity=BoxesQuantity
		FROM dbo.StockOutDetails s
		WHERE s.StockOutDetailID = @StockOutDetailID
		
		UPDATE Items
		SET QuantityInStock=QuantityInStock+@Quantity,
			BoxesQuantity=BoxesQuantity+@BoxesQuantity
		WHERE ItemID=@ItemID
		
		DELETE FROM StockOutDetails 
		WHERE StockOutDetailID=@StockOutDetailID
	COMMIT TRANSACTION;
  END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
END CATCH
  
END
