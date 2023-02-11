CREATE PROCEDURE [dbo].[spItem_GetSubGroups]
AS
begin
SELECT Distinct SubGroup 
FROM dbo.[Items];
end
RETURN 0
