
SELECT U.[Code] AS [UserId], U.[Name] AS [Name], [AttendanceDate], SUM(ISNULL([WorkedMinutes], 0)) AS TotalWorkedMinutes,
CONCAT(SUM(ISNULL([WorkedMinutes], 0)) / 60, ':', RIGHT('00' + CAST(SUM(ISNULL([WorkedMinutes], 0)) % 60 AS VARCHAR(2)), 2)) AS TotalWorkingHr
FROM [dbo].[SalesPersonAttendance] AS S
INNER JOIN [dbo].[User] AS U ON U.[Code] = S.[SalesPersonId]
WHERE 1=1
AND S.[AttendanceDate] >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
AND S.[AttendanceDate] <= CAST(GETDATE() AS DATE)
GROUP BY U.[Code], U.[Name], [AttendanceDate]
ORDER BY [AttendanceDate], U.[Code];



SELECT U.[Code] AS [UserId], U.[Name] AS [Name], FORMAT(S.[Login], 'dd-MMM-yyyy hh:mm tt') AS [LoginTime], 
FORMAT(S.[Logout], 'dd-MMM-yyyy hh:mm tt') AS [LogOutTime],
CAST(S.[WorkedMinutes] / 60 AS VARCHAR(10)) + ':' + RIGHT('00' + CAST(S.[WorkedMinutes] % 60 AS VARCHAR(2)), 2) AS [TotalHr],
S.[Remarks]
FROM [dbo].[SalesPersonAttendance] AS S
INNER JOIN [dbo].[User] AS U ON U.[Code] = S.[SalesPersonId]
WHERE 1=1 
--AND S.[SalesPersonId] = @SalesPersonId
AND S.[AttendanceDate] = CAST(GETDATE() AS DATE)
ORDER BY S.[Login] DESC;





