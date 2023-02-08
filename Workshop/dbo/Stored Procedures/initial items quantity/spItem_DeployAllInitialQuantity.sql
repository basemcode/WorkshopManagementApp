CREATE PROCEDURE [dbo].[spItem_DeployAllInitialQuantity]
	@PeriodID int 
AS
DECLARE @CursorID INT = 1;
DECLARE @RowCnt BIGINT = 0;
DECLARE @Barcode NVARCHAR(50);

-- get a count of total rows to process 
SELECT @RowCnt = COUNT(0) FROM dbo.InitialQuantityOfItems;

WHILE @CursorID <= @RowCnt
BEGIN
SELECT
    @Barcode=Barcode
FROM
    (
        SELECT
            ROW_NUMBER () OVER (ORDER BY PeriodID asc) AS RowNum,
            *
        FROM
            InitialQuantityOfItems
    ) sub
WHERE
    RowNum = @CursorID AND PeriodID=@PeriodID
    EXECUTE [dbo].[spItem_DeployInitialQuantity] 
   @Barcode
  ,@PeriodID

   SET @CursorID = @CursorID + 1 
 
END