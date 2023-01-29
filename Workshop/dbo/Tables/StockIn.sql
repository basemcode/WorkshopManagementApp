CREATE TABLE [dbo].[StockIn] (
    [StockInID] INT            IDENTITY (1, 1) NOT NULL,
    [Date]      DATE           NULL,
    [UserID]    INT            NULL,
    [Note]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_StockIn] PRIMARY KEY CLUSTERED ([StockInID] ASC)
);

