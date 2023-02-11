
CREATE PROCEDURE [dbo].[spItem_GetAllBarcodes]
AS
begin
	select [Barcode]
	from dbo.[Items];
end
