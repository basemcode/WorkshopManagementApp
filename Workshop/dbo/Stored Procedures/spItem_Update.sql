
CREATE PROCEDURE [dbo].[spItem_Update]
		   @ItemID int,
		   @ItemCode nvarchar(100), 
           @ItemCodeWithColor nvarchar(100),
           @Barcode nvarchar(100),
           @Image varbinary(MAX),
           @ItemNumberOnWB nvarchar(100),
           @InternalCode nvarchar(100),
           @ProductName nvarchar(100),
           @Color nvarchar(100),
           @HardboardBoxNumber nvarchar(100),
           @Unit nvarchar(100),
           @GofferNumber nvarchar(100),
		   @Category nvarchar(100),
           @Note nvarchar(max),
	   	   @QuantityInStock int = NULL,
		   @BoxesQuantity int = NULL,
		   @MinimumQuantity int = NULL
		   
AS
begin
	update [dbo].[Items]
           set [ItemCode]=@ItemCode
           ,[ItemCodeWithColor]=@ItemCodeWithColor
           ,[Barcode]=@Barcode
           ,[Image]=@Image
           ,[ItemNumberOnWB]=@ItemNumberOnWB
           ,[InternalCode]=@InternalCode
           ,[ProductName]=@ProductName
           ,[Color]=@Color
           ,[HardboardBoxNumber]=@HardboardBoxNumber
           ,[Unit]=@Unit
           ,[GofferNumber]=@GofferNumber
		   ,[Category]=@Category
           ,[Note]=@Note
		   /*,QuantityInStock=@QuantityInStock
		   ,MinimumQuantity=@MinimumQuantity*/

	where [ItemID]=@ItemID
end