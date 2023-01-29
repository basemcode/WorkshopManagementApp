CREATE TABLE [dbo].[StockOutDetails] (
    [StockOutDetailID] INT IDENTITY (1, 1) NOT NULL,
    [StockOutID]       INT NOT NULL,
    [ItemID]           INT NOT NULL,
    [Quantity]         INT NOT NULL,
    [BoxesQuantity]    INT CONSTRAINT [DF_StockOutDetails_BoxesQuantity] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_StockOutDetails] PRIMARY KEY CLUSTERED ([StockOutDetailID] ASC)
);

