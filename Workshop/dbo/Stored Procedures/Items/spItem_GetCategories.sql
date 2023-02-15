CREATE PROCEDURE [dbo].[spItem_GetCategories]
AS
begin
SELECT Distinct Category 
FROM dbo.[Items];
end
RETURN 0