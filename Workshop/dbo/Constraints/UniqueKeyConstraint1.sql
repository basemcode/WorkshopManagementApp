ALTER TABLE dbo.[InitialQuantityOfItems]
  ADD CONSTRAINT uq_InitialQuantityOfItems UNIQUE([Barcode], [PeriodID]);