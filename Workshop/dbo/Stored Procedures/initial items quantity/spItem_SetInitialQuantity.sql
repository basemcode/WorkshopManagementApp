
CREATE PROC [dbo].[spItem_SetInitialQuantity] 
	@Barcode NVARCHAR (50),
    @InitialQuantity INT,
    @BoxesInitialQuantity INT,
    @PeriodID            INT          
    
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	IF NOT EXISTS (SELECT 1 FROM dbo.InitialQuantityOfItems AS t
    where  t.Barcode=@Barcode
    AND t.[PeriodID] = @PeriodID
  )
  BEGIN
    INSERT INTO dbo.InitialQuantityOfItems(Barcode,InitialQuantity,BoxesInitialQuantity ,[PeriodID])
      SELECT @Barcode, @InitialQuantity,@BoxesInitialQuantity, @PeriodID ;
  END
  ELSE
  BEGIN
   UPDATE [dbo].[InitialQuantityOfItems]
   SET [InitialQuantity] = @InitialQuantity
   ,BoxesInitialQuantity=@BoxesInitialQuantity
   WHERE [Barcode]=@Barcode AND [PeriodID]=@PeriodID
  END

               
	COMMIT
