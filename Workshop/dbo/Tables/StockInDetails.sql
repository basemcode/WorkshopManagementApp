CREATE TABLE [dbo].[StockInDetails] (
    [StockInDetailID] INT IDENTITY (1, 1) NOT NULL,
    [StockInID]       INT NOT NULL,
    [ItemID]          INT NOT NULL,
    [Quantity]        INT NOT NULL,
    [BoxesQuantity]   INT CONSTRAINT [DF_StockInDetails_BoxesQuantity] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_StockInDetails] PRIMARY KEY CLUSTERED ([StockInDetailID] ASC)
);

