CREATE FUNCTION TRUNC_DATE
(
    @datetime datetime, -- datetime to be truncated
    @level VARCHAR(10)  -- truncation level: year, month, day, hour and minute
)
RETURNS DATETIME
AS
BEGIN

    IF (UPPER(@level) = 'YEAR')
       RETURN DATEADD(YEAR,   DATEDIFF(YEAR, 0, @datetime), 0)
    ELSE IF (UPPER(@level) = 'MONTH')
        RETURN DATEADD(MONTH,   DATEDIFF(MONTH, 0, @datetime), 0)
    ELSE IF(UPPER(@level) = 'DAY')
       RETURN DATEADD(DAY,   DATEDIFF(DAY, 0, @datetime), 0)
    ELSE IF (UPPER(@level) = 'HOUR')
       RETURN DATEADD(HOUR,   DATEDIFF(HOUR, 0, @datetime), 0)
    ELSE IF (UPPER(@level) = 'MINUTE')
       RETURN DATEADD(MINUTE,   DATEDIFF(MINUTE, 0, @datetime), 0)

    RETURN @datetime
END
