DECLARE @FromDate DATETIME = '2021-01-25 00:00:00.001'
DECLARE @ToDate   DATETIME = '2021-02-25 00:00:00.001'

DECLARE @Seconds INT = DATEDIFF(SECOND, @FromDate, @ToDate)
DECLARE @Random INT = ROUND(((@Seconds-1) * RAND()), 0)
DECLARE @Milliseconds INT = ROUND((999 * RAND()), 0)

SELECT DATEADD(MILLISECOND, @Milliseconds, DATEADD(SECOND, @Random, @FromDate))

--DECLARE @milliseconds INT = DATEDIFF(MILLISECOND, @FromDate, @ToDate)
--DECLARE @Random INT = ROUND(((@milliseconds-1) * RAND()), 0)


/*
  -- I should use DATETIME2 from now(2021/01/25) on
  DECLARE @startingDatetime datetime = '2021-01-25 00:00:00.001'; select @startingDatetime
  DECLARE @millisecondsDay int = 1000 * 60 * 60 * 24
  DECLARE @randomdatetime datetime = DATEADD(millisecond, ABS(CHECKSUM(NEWID()) % @millisecondsDay * 31), @startingDatetime); select @randomdatetime
  --DECLARE @datetime2 datetime2 = '2021-01-25 00:00:00.0000001'; select @datetime2
*/


UPDATE [WesserTask].[dbo].[Customer] set [StartingDate] = DATEADD(MILLISECOND, ROUND((999 * RAND()), 0), DATEADD(SECOND, ROUND((((DATEDIFF(SECOND, @FromDate, @ToDate))-1) * RAND()), 0), @FromDate)) WHERE Id =	1

update Customer set HomePhone = RIGHT('1234567890'+cast(cast(9999999999*rand(checksum(newid())) as bigint) as varchar(10)),10)