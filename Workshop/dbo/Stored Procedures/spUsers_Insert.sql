
CREATE PROC [dbo].[spUsers_Insert] 
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
	
	INSERT INTO [dbo].[Users] ([FirstName], [MiddleName], [LastName], [Username], [Password], [Privileges])
	SELECT @FirstName, @MiddleName, @LastName, @Username, @Password, @Privileges
	
	/*/*-- Begin Return Select <- do not remove
	SELECT [UserID], [FirstName], [MiddleName], [LastName], [Username], [Password], [privileges]
	FROM   [dbo].[Users]
	WHERE  [UserID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove*/*/
               
	COMMIT
