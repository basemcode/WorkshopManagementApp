CREATE TABLE [dbo].[Users] (
    [UserID]     INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (50) NULL,
    [MiddleName] NVARCHAR (50) NULL,
    [LastName]   NVARCHAR (50) NULL,
    [Username]   NVARCHAR (50) NULL,
    [Password]   NVARCHAR (50) NULL,
    [Privileges] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Имя', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Users', @level2type = N'COLUMN', @level2name = N'FirstName';

