
CREATE   PROCEDURE [dbo].[spItem_UpdateImage]
		    @ItemID int,		   
           @Image varbinary(MAX) 	   
AS
begin
	update [dbo].[Items]
           set [Image]=@Image
	where [ItemID]=@ItemID
end