
ALTER TABLE [dbo].[User] ADD [WorkingHour] TIME(0) NULL;

-------------------------------------
GO
-------------------------------------

--UPDATE [dbo].[User] SET [WorkingHour] = '07:30' WHERE [Code] = 7;
--UPDATE [dbo].[User] SET [WorkingHour] = '07:30' WHERE [Code] = 9;
--UPDATE [dbo].[User] SET [WorkingHour] = '10:00' WHERE [Code] = 8;

-------------------------------------
GO
-------------------------------------

CREATE TABLE [dbo].[SalesPersonAttendance]
(
    [Id]            INT IDENTITY(1,1) PRIMARY KEY,
    [SalesPersonId] INT NOT NULL,
    [AttendanceDate] DATE NOT NULL,
    [LogIn]       DATETIME2 NOT NULL,
    [LogOut]      DATETIME2 NULL,
    [WorkedMinutes] INT NULL,
	[Remarks] VARCHAR(50)
);

-------------------------------------
GO
-------------------------------------

ALTER PROCEDURE [dbo].[SpUpdateSalesPersonAttendance]
(
    @SalesPersonId INT,
    @Action VARCHAR(10),
    @Remarks VARCHAR(50)
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE
        @AttendanceId INT,
        @WorkingHour VARCHAR(8),
        @WorkingMinutes INT,
        @CurrentDate DATE,
        @CurrentDateTime DATETIME2,
        @CurrentSessionMinutes INT;

    SET @CurrentDate = CAST(GETDATE() AS DATE);
    SET @CurrentDateTime = GETDATE();

    BEGIN TRY

        BEGIN TRANSACTION;

        ------------------------------------------------------------
        -- Get employee working hour
        ------------------------------------------------------------
        SELECT @WorkingHour = [WorkingHour]
        FROM [dbo].[User]
        WHERE [Code] = @SalesPersonId;

        IF @WorkingHour IS NULL
        BEGIN
            RAISERROR('Working hour is not configured for this employee.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;

        ------------------------------------------------------------
        -- Convert WorkingHour to minutes
        ------------------------------------------------------------
        SET @WorkingMinutes =
              DATEPART(HOUR, TRY_CONVERT(TIME, @WorkingHour)) * 60
            + DATEPART(MINUTE, TRY_CONVERT(TIME, @WorkingHour));

        IF @WorkingMinutes IS NULL OR @WorkingMinutes <= 0
        BEGIN
            RAISERROR('Invalid working hour configuration.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;

        ------------------------------------------------------------
        -- Validate Action
        ------------------------------------------------------------
        IF UPPER(@Action) NOT IN ('LOGIN', 'LOGOUT')
        BEGIN
            RAISERROR('Invalid action. Use LOGIN or LOGOUT.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;


        /************************************************************
                            LOGIN
        ************************************************************/
        IF UPPER(@Action) = 'LOGIN'
        BEGIN

            --------------------------------------------------------
            -- Close forgotten LOGIN records from previous days
            --------------------------------------------------------
            UPDATE A
            SET
                A.WorkedMinutes =
                    CASE
                        WHEN @WorkingMinutes - ISNULL(X.CompletedMinutes, 0) > 0
                            THEN @WorkingMinutes - ISNULL(X.CompletedMinutes, 0)
                        ELSE 0
                    END,

                A.[Logout] =
                    DATEADD
                    (
                        MINUTE,
                        CASE
                            WHEN @WorkingMinutes - ISNULL(X.CompletedMinutes, 0) > 0
                                THEN @WorkingMinutes - ISNULL(X.CompletedMinutes, 0)
                            ELSE 0
                        END,
                        A.[Login]
                    ),

                A.[Remarks] = 'Forgotten Logout'

            FROM [dbo].[SalesPersonAttendance] A

            OUTER APPLY
            (
                SELECT
                    SUM(ISNULL(A2.WorkedMinutes, 0)) AS CompletedMinutes
                FROM [dbo].[SalesPersonAttendance] A2
                WHERE A2.SalesPersonId = A.SalesPersonId
                  AND A2.AttendanceDate = A.AttendanceDate
                  AND A2.Logout IS NOT NULL
                  AND A2.Id <> A.Id
            ) X

            WHERE A.SalesPersonId = @SalesPersonId
              AND A.AttendanceDate < @CurrentDate
              AND A.[Login] IS NOT NULL
              AND A.[Logout] IS NULL;


            --------------------------------------------------------
            -- Check whether employee is already logged in today
            --------------------------------------------------------
            IF EXISTS
            (
                SELECT 1
                FROM [dbo].[SalesPersonAttendance]
                WHERE SalesPersonId = @SalesPersonId
                  AND AttendanceDate = @CurrentDate
                  AND [Login] IS NOT NULL
                  AND [Logout] IS NULL
            )
            BEGIN
                RAISERROR('Sales person is already logged in.', 16, 1);
                ROLLBACK TRANSACTION;
                RETURN;
            END;


            --------------------------------------------------------
            -- Insert new LOGIN record
            --------------------------------------------------------
            INSERT INTO [dbo].[SalesPersonAttendance]
            (
                SalesPersonId,
                AttendanceDate,
                [Login],
                [Logout],
                WorkedMinutes,
                [Remarks]
            )
            VALUES
            (
                @SalesPersonId,
                @CurrentDate,
                @CurrentDateTime,
                NULL,
                0,
                @Remarks
            );

        END;


        /************************************************************
                            LOGOUT
        ************************************************************/
        ELSE IF UPPER(@Action) = 'LOGOUT'
        BEGIN

            --------------------------------------------------------
            -- Find current open LOGIN
            --------------------------------------------------------
            SELECT TOP 1
                @AttendanceId = Id
            FROM [dbo].[SalesPersonAttendance]
            WHERE SalesPersonId = @SalesPersonId
              AND AttendanceDate = @CurrentDate
              AND [Login] IS NOT NULL
              AND [Logout] IS NULL
            ORDER BY [Login] DESC, Id DESC;


            --------------------------------------------------------
            -- No open login
            --------------------------------------------------------
            IF @AttendanceId IS NULL
            BEGIN
                RAISERROR('Sales person is not currently logged in.', 16, 1);
                ROLLBACK TRANSACTION;
                RETURN;
            END;


            --------------------------------------------------------
            -- Calculate ACTUAL session duration
            --------------------------------------------------------
            SELECT
                @CurrentSessionMinutes =
                    DATEDIFF
                    (
                        MINUTE,
                        [Login],
                        @CurrentDateTime
                    )
            FROM [dbo].[SalesPersonAttendance]
            WHERE Id = @AttendanceId;


            --------------------------------------------------------
            -- Update LOGOUT record
            --------------------------------------------------------
            UPDATE [dbo].[SalesPersonAttendance]
            SET
                [Logout] = @CurrentDateTime,
                WorkedMinutes = @CurrentSessionMinutes,
                [Remarks] = @Remarks
            WHERE Id = @AttendanceId;

        END;


        COMMIT TRANSACTION;

    END TRY
    BEGIN CATCH

        IF XACT_STATE() <> 0
            ROLLBACK TRANSACTION;

        THROW;

    END CATCH
END;
GO
-------------------------------------
