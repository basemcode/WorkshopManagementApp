CREATE TABLE [dbo].[InitialQuantityOfItems] (
    [Barcode]         NVARCHAR (50) NULL,
    [InitialQuantity] INT           NULL DEFAULT 0,
    [LatelyAddedQuantity] INT           NULL DEFAULT 0,
    [BoxesInitialQuantity] INT           NULL DEFAULT 0,
    [LatelyAddedBoxesQuantity] INT           NULL DEFAULT 0,
    [PeriodID]            INT          NULL
);

