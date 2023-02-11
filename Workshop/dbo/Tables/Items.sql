CREATE TABLE [dbo].[Items] (
    [ItemID]             INT             IDENTITY (1, 1) NOT FOR REPLICATION NOT NULL,
    [ItemCode]           NVARCHAR (100)  NULL,
    [ItemCodeWithColor]  NVARCHAR (100)  NULL,
    [Barcode]            NVARCHAR (100)  CONSTRAINT [DF_Items_Barcode] DEFAULT ((0)) NULL,
    [Image]              VARBINARY (MAX) NULL,
    [ItemNumberOnWB]     NVARCHAR (100)  NULL,
    [InternalCode]       NVARCHAR (100)  NULL,
    [ProductName]        NVARCHAR (100)  NULL,
    [SubGroup]           NVARCHAR (100)  NULL,
    [Color]              NVARCHAR (100)  NULL,
    [HardboardBoxNumber] NVARCHAR (100)  NULL,
    [Unit]               NVARCHAR (100)  NULL,
    [GofferNumber]       NVARCHAR (100)  NULL,
    [Category]           NVARCHAR (100)  NULL,
    [Note]               NVARCHAR (MAX)  NULL,
    [QuantityInStock]    INT             CONSTRAINT [DF_Items_QuantityInStock] DEFAULT ((0)) NULL,
    [BoxesQuantity]      INT             CONSTRAINT [DF_Items_BoxesQuantity] DEFAULT ((0)) NULL,
    [MinimumQuantity]    INT             CONSTRAINT [DF_Items_MinimumQuantity] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([ItemID] ASC)
);

