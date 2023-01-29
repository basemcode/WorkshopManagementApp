CREATE TABLE [dbo].[ReportingPeriods]
(
    [PeriodID] int NOT NULL IDENTITY, 
    [Start] DATE NULL, 
    [End] DATE NULL, 
    CONSTRAINT [PK_ReportingPeriods] PRIMARY KEY ([PeriodID])
)
WITH
(
    DISTRIBUTION = HASH (PeriodID),
    CLUSTERED COLUMNSTORE INDEX
)
GO
