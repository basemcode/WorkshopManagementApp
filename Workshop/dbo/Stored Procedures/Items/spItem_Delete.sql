
CREATE PROCEDURE [dbo].[spItem_Delete]
	@ItemID int
AS
begin
	delete from dbo.Items
	where ItemID = @ItemID;
end

