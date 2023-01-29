CREATE PROCEDURE [dbo].[spItem_Get]
	@ItemID int
AS
begin
	SELECT *
	from dbo.Items
	where ItemID = @ItemID;
end

