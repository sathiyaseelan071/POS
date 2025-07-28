ALTER PROC [dbo].[SpSaveRateMaster] (@UDT_RateMaster UDT_RateMaster readonly)
As
BEGIN TRAN

BEGIN TRY

	INSERT INTO RateMaster(ProductCode, BuyRate, SellMarginPercentage, SellRate, CreatedBy, CreatedDateTime)
	SELECT ProductCode, BuyRate, SellMarginPercentage, SellRate, CreatedBy, GETDATE() FROM @UDT_RateMaster AS R1
	WHERE NOT EXISTS (SELECT ProductCode FROM RateMaster AS R2 WHERE R1.ProductCode = R2.ProductCode)

	UPDATE R SET 
	R.BuyRate = U.BuyRate, 
	R.SellMarginPercentage = U.SellMarginPercentage, 
	R.SellRate = U.SellRate, 
	R.CreatedBy = U.CreatedBy, 
	R.CreatedDateTime = GETDATE()
	FROM RateMaster AS R 
	INNER JOIN @UDT_RateMaster AS U ON R.ProductCode = U.ProductCode

COMMIT TRAN

END TRY
BEGIN CATCH

	ROLLBACK TRAN

END CATCH

--------------
Go
--------------

CREATE TABLE Vendor(
    [SNo] INT IDENTITY(1,1) ,           
    [Code] INT PRIMARY KEY NOT NULL,               
    [Name] VARCHAR(100) NOT NULL,               
    [ShortName] VARCHAR(100) NOT NULL,                      
    [MobileNo] BIGINT,                             
    [Address] VARCHAR(200),
	
    [Active] CHAR(1) DEFAULT 'Y',                  
    [CreatedBy] INT NOT NULL,                      
    [CreatedDate] DATETIME,      
    [LastUpdatedBy] INT,                           
    [LastUpdatedDate] DATETIME,                    
    FOREIGN KEY ([CreatedBy]) REFERENCES [USER]([Code]),
    FOREIGN KEY ([LastUpdatedBy]) REFERENCES [USER]([Code])
)

--------------
Go
--------------

CREATE PROC [dbo].[SpSaveVendor] (@Name VARCHAR(100), @ShortName VARCHAR(100), @MobileNo BIGINT, @Address VARCHAR(200), 
@Active VARCHAR(50), @CreatedBy INT, @LastUpdatedBy INT)
As

DECLARE @Code INT
SET @Code = (SELECT ISNULL(MAX([Code]), 0) + 1 FROM [Vendor])

INSERT INTO [Vendor]([Code],[Name],[ShortName],[MobileNo],[Address],
[Active],[CreatedBy],[CreatedDate],[LastUpdatedBy],[LastUpdatedDate])
VALUES (@Code, @Name, @ShortName, @MobileNo, @Address, 
@Active, @CreatedBy, GETDATE(), @LastUpdatedBy, GETDATE())

--------------
Go
--------------

CREATE PROC [dbo].[SpUpdateVendor](@Code INT, @Name VARCHAR(100), @ShortName VARCHAR(100), @MobileNo BIGINT, @Address VARCHAR(200), 
@Active VARCHAR(50), @LastUpdatedBy INT)
As
UPDATE [Vendor] SET [Name]=@Name, [ShortName]=@ShortName, [MobileNo]=@MobileNo, [Address]=@Address, 
[Active]=@Active, [LastUpdatedBy]=@LastUpdatedBy, [LastUpdatedDate]=GETDATE()
WHERE [Code] = @Code

--------------
Go
--------------

CREATE PROC [dbo].[SpGetVendorMaster]
AS

SELECT V.SNo, V.[Code], V.[Name], V.[ShortName], CAST(V.[MobileNo] AS VARCHAR) AS MobileNo, V.[Address],
V.[Active] AS ActiveStatusCode, (CASE WHEN V.[Active] = 'Y' THEN 'Yes' ELSE 'No' END) AS Active,
CU.[Name] AS CreatedBy, V.[CreatedDate], UU.[Name] AS LastUpdatedBy, V.[LastUpdatedDate]
FROM [Vendor] AS V
Left Join [User] AS CU ON V.[CreatedBy] = CU.[Code]
Left Join [User] AS UU ON V.[LastUpdatedBy] = UU.[Code]
ORDER BY V.SNo DESC

--------------
Go
--------------

CREATE TABLE [Customer](
    [SNo] INT IDENTITY(1,1) ,           
    [Code] INT PRIMARY KEY NOT NULL,               
    [Name] VARCHAR(100) NOT NULL,                     
    [MobileNo] BIGINT,
    [Address] VARCHAR(200),
	
    [Active] CHAR(1) DEFAULT 'Y',                  
    [CreatedBy] INT NOT NULL,                      
    [CreatedDate] DATETIME,      
    [LastUpdatedBy] INT,                           
    [LastUpdatedDate] DATETIME,                    
    FOREIGN KEY ([CreatedBy]) REFERENCES [USER]([Code]),
    FOREIGN KEY ([LastUpdatedBy]) REFERENCES [USER]([Code])
)

--------------
Go
--------------

CREATE PROC [dbo].[SpSaveCustomer](@Name VARCHAR(100), @MobileNo BIGINT, @Address VARCHAR(200), 
@Active VARCHAR(50), @CreatedBy INT, @LastUpdatedBy INT)
As

DECLARE @Code INT
SET @Code = (SELECT ISNULL(MAX([Code]), 0) + 1 FROM [Customer])

INSERT INTO [Customer]([Code],[Name],[MobileNo],[Address],
[Active],[CreatedBy],[CreatedDate],[LastUpdatedBy],[LastUpdatedDate])
VALUES (@Code, @Name, @MobileNo, @Address, 
@Active, @CreatedBy, GETDATE(), @LastUpdatedBy, GETDATE())

--------------
Go
--------------

CREATE PROC [dbo].[SpUpdateCustomer](@Code INT, @Name VARCHAR(100), @MobileNo BIGINT, @Address VARCHAR(200), 
@Active VARCHAR(50), @LastUpdatedBy INT)
As
UPDATE [Customer] SET [Name]=@Name, [MobileNo]=@MobileNo, [Address]=@Address, 
[Active]=@Active, [LastUpdatedBy]=@LastUpdatedBy, [LastUpdatedDate]=GETDATE()
WHERE [Code] = @Code

--------------
Go
--------------

CREATE PROC [dbo].[SpGetCustomerMaster]
AS

SELECT C.SNo, C.[Code], C.[Name], CAST(C.[MobileNo] AS VARCHAR) AS MobileNo, C.[Address],
C.[Active] AS ActiveStatusCode, (CASE WHEN C.[Active] = 'Y' THEN 'Yes' ELSE 'No' END) AS Active,
CU.[Name] AS CreatedBy, C.[CreatedDate], UU.[Name] AS LastUpdatedBy, C.[LastUpdatedDate]
FROM [Customer] AS C
Left Join [User] AS CU ON C.[CreatedBy] = CU.[Code]
Left Join [User] AS UU ON C.[LastUpdatedBy] = UU.[Code]
ORDER BY C.SNo DESC

--------------
Go
--------------

ALTER TABLE [User] ADD [Password] VARCHAR(15)

--------------
Go
--------------

CREATE PROC [dbo].[SpSaveUser](@Name VARCHAR(100), @Password VARCHAR(15), 
@Active VARCHAR(50), @CreatedBy INT, @LastUpdatedBy INT)
As

DECLARE @Code INT
SET @Code = (SELECT ISNULL(MAX([Code]), 0) + 1 FROM [User])

INSERT INTO [User]([Code],[Name],[Password],
[Active],[CreatedBy],[CreatedDateTime],[LastUpdatedBy],[LastUpdatedDateTime])
VALUES (@Code, @Name, @Password,
@Active, @CreatedBy, GETDATE(), @LastUpdatedBy, GETDATE())

--------------
Go
--------------

CREATE PROC [dbo].[SpUpdateUser](@Code INT, @Name VARCHAR(100), @Password VARCHAR(15), 
@Active VARCHAR(50), @LastUpdatedBy INT)
As
UPDATE [User] SET [Name]=@Name, [Password]=@Password, 
[Active]=@Active, [LastUpdatedBy]=@LastUpdatedBy, [LastUpdatedDateTime]=GETDATE()
WHERE [Code] = @Code

--------------
Go
--------------

CREATE PROC [dbo].[SpGetUser]
AS

SELECT C.SNo, C.[Code], C.[Name], C.[Password],
C.[Active] AS ActiveStatusCode, (CASE WHEN C.[Active] = 'Y' THEN 'Yes' ELSE 'No' END) AS Active,
CU.[Name] AS CreatedBy, C.[CreatedDateTime] AS CreatedDate, UU.[Name] AS LastUpdatedBy, C.[LastUpdatedDateTime] AS LastUpdatedDate
FROM [User] AS C
Left Join [User] AS CU ON C.[CreatedBy] = CU.[Code]
Left Join [User] AS UU ON C.[LastUpdatedBy] = UU.[Code]
ORDER BY C.SNo DESC

--------------
Go
--------------



