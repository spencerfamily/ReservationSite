Delete FROM Reservations Where DatePart(dw, StartDate) != 1
Declare  @StartDay DateTime = '2019-04-01'
Declare  @EndDay DateTime = '2019-10-01'
While (@StartDay < @EndDay)
BEGIN
	if (DatePart(dw, @StartDay) = 1)
	BEGIN
		Insert Into Reservations (Id, UserId, StartDate, EndDate)
		Values (newid(), '00000000-0000-0000-0000-000000000000', @StartDay, DATEADD(wk, 1, @StartDay) )
		SET @StartDay = DATEADD(wk, 1, @StartDay)
	END	
	ELSE
		SET @StartDay = DATEADD(dd, 1, @StartDay)
END
select * from Reservations