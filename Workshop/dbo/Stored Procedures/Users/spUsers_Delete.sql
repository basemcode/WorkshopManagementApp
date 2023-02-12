
CREATE PROC [dbo].[spUsers_Delete] 
    @UserID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Users]
	WHERE  [UserID] = @UserID

	COMMIT
