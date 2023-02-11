
CREATE PROCEDURE [dbo].[spItem_GetItemsOfCategory]
	@Category nvarchar(20)
AS
begin
	SELECT [ItemID]
      ,[ItemCode]
      ,[ItemCodeWithColor]
      ,[Barcode]
      ,[Image]
      ,[ItemNumberOnWB]
      ,[InternalCode]
      ,[ProductName]
      ,[Color]
      ,[HardboardBoxNumber]
      ,[Unit]
      ,[GofferNumber]
      ,[Category]
      ,[Note]
      ,[QuantityInStock]
      ,[BoxesQuantity]
      ,[MinimumQuantity]
	from dbo.Items
	where Category= @Category;
end

