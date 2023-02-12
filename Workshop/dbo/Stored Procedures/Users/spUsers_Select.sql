

CREATE PROC [dbo].[spUsers_Select] 
    @UserID int= NULL,
	@Username nvarchar(50)= NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [UserID], [FirstName], [MiddleName], [LastName], [Username], [Password], [Privileges] 
	FROM   [dbo].[Users] 
	WHERE  ([UserID] = @UserID OR [Username] = @Username OR (@UserID IS NULL AND @Username IS NULL)) 

	COMMIT
