
CREATE PROCEDURE [dbo].[spItem_GetByBarcode]
	@Barcode nvarchar(100)
AS
begin
	SELECT *
	from dbo.Items
	where Barcode = @Barcode;
end

