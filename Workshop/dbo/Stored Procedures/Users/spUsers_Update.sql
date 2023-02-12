
CREATE PROC [dbo].[spUsers_Update] 
    @UserID int,
    @FirstName nvarchar(50) = NULL,
    @MiddleName nvarchar(50) = NULL,
    @LastName nvarchar(50) = NULL,
    @Username nvarchar(50) = NULL,
    @Password nvarchar(50) = NULL,
    @Privileges nvarchar(50) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Users]
	SET    [FirstName] = @FirstName, [MiddleName] = @MiddleName, [LastName] = @LastName, [Username] = @Username, [Password] = @Password, [Privileges] = @Privileges
	WHERE  [UserID] = @UserID
	
	/*-- Begin Return Select <- do not remove
	SELECT [UserID], [FirstName], [MiddleName], [LastName], [Username], [Password], [privileges]
	FROM   [dbo].[Users]
	WHERE  [UserID] = @UserID	
	-- End Return Select <- do not remove*/

	COMMIT
