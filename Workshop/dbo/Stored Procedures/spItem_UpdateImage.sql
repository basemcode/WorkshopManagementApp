
CREATE   PROCEDURE [dbo].[spItem_UpdateImage]
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
           set [Image]=@Image
	where [ItemID]=@ItemID
end