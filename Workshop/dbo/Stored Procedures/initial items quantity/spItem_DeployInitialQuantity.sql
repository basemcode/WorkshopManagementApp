CREATE PROCEDURE [dbo].[spItem_DeployInitialQuantity]
	@Barcode NVARCHAR(100),
	@PeriodID int
AS
BEGIN
  BEGIN TRY
    BEGIN TRANSACTION;
   declare @InitialQuantity INT;            
   declare @LatelyAddedQuantity INT ;
   declare @BoxesInitialQuantity INT;   
   declare @LatelyAddedBoxesQuantity INT;   
   
   select @InitialQuantity=InitialQuantity
	,@BoxesInitialQuantity=BoxesInitialQuantity
	

	from [InitialQuantityOfItems]
	where Barcode=@Barcode And PeriodID=@PeriodID

	select @LatelyAddedQuantity=LatelyAddedQuantity
	,@LatelyAddedBoxesQuantity=LatelyAddedBoxesQuantity
	from [InitialQuantityOfItems]
	where Barcode=@Barcode And PeriodID=1

	update Items
	set QuantityInStock=QuantityInStock-@LatelyAddedQuantity+@InitialQuantity,
	 BoxesQuantity=BoxesQuantity-@LatelyAddedBoxesQuantity+@BoxesInitialQuantity
	where Barcode=@Barcode

	update [InitialQuantityOfItems]
	set LatelyAddedQuantity=@InitialQuantity
	,LatelyAddedBoxesQuantity=@BoxesInitialQuantity
	where Barcode=@Barcode AND PeriodID=1
	COMMIT TRANSACTION;
  END TRY
  BEGIN CATCH
    ROLLBACK TRANSACTION;
  END CATCH
  
END