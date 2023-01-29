CREATE TABLE [dbo].[StockOut] (
    [StockOutID] INT            IDENTITY (1, 1) NOT NULL,
    [Date]       DATE           NULL,
    [UserID]     INT            NULL,
    [Note]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_StockOut] PRIMARY KEY CLUSTERED ([StockOutID] ASC)
);

