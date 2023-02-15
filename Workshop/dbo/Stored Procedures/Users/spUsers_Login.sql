

CREATE PROC [dbo].[spUsers_Login] 
    @Username nvarchar(50),
	@Password nvarchar(50)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [UserID], [FirstName], [MiddleName], [LastName], [Username], [Password], [Privileges] 
	FROM   [dbo].[Users] 
	WHERE  ([Username]=@Username COLLATE SQL_Latin1_General_CP1_CS_AS
	AND [Password]=@Password COLLATE SQL_Latin1_General_CP1_CS_AS) 

	COMMIT
