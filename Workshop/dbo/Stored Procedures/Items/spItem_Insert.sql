CREATE PROCEDURE [dbo].[spItem_Insert]
	@ItemID int,
	@ItemCode nvarchar(100) = NULL,
    @ItemCodeWithColor nvarchar(100) = NULL,
    @Barcode nvarchar(100) = NULL,
    @Image varbinary(MAX) = NULL,
    @ItemNumberOnWB nvarchar(100) = NULL,
    @InternalCode nvarchar(100) = NULL,
    @ProductName nvarchar(100) = NULL,
    @SubGroup nvarchar(100) = NULL,
    @Color nvarchar(100) = NULL,
    @HardboardBoxNumber nvarchar(100) = NULL,
    @Unit nvarchar(100) = NULL,
    @GofferNumber nvarchar(100) = NULL,
    @Category nvarchar(100) = NULL,
    @Note nvarchar(MAX) = NULL,
    @QuantityInStock int = 0,
    @BoxesQuantity int = 0,
    @MinimumQuantity int = 0
	 
AS
begin
	insert into [dbo].[Items]
           ([ItemCode]
           ,[ItemCodeWithColor]
           ,[Barcode]
           ,[Image]
           ,[ItemNumberOnWB]
           ,[InternalCode]
           ,[ProductName]
           ,[SubGroup]
           ,[Color]
           ,[HardboardBoxNumber]
           ,[Unit]
           ,[GofferNumber]
		   ,[Category]
           ,[Note]
		   ,[QuantityInStock]
           ,[BoxesQuantity]
           ,[MinimumQuantity])
	values (@ItemCode
           ,@ItemCodeWithColor
           ,@Barcode
           ,@Image
           ,@ItemNumberOnWB
           ,@InternalCode
           ,@ProductName
           ,@SubGroup
           ,@Color
           ,@HardboardBoxNumber
           ,@Unit
           ,@GofferNumber
		   ,@Category
           ,@Note
		   ,@QuantityInStock 
		   ,@BoxesQuantity 
		   ,@MinimumQuantity )
end