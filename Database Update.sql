ALTER PROC [dbo].[SpSaveRateMaster] (@UDT_RateMaster UDT_RateMaster readonly)
As
BEGIN TRAN

BEGIN TRY

	Insert into RateMaster(ProductCode, BuyRate, SellMarginPercentage, SellRate, CreatedBy, CreatedDateTime)
	Select ProductCode, BuyRate, SellMarginPercentage, SellRate, CreatedBy, GETDATE() From @UDT_RateMaster AS R1
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
    SNo INT IDENTITY(1,1) ,           
    Code INT PRIMARY KEY NOT NULL,               
    [Name] VARCHAR(100) NOT NULL,               
    ShortName VARCHAR(100) NOT NULL,                      
    MobileNo BIGINT,                             
    [Address] VARCHAR(200),
	
    Active CHAR(1) DEFAULT 'Y',                  
    CreatedBy INT NOT NULL,                      
    CreatedDate DATETIME,      
    LastUpdatedBy INT,                           
    LastUpdatedDate DATETIME,                    
    FOREIGN KEY (CreatedBy) REFERENCES [USER](Code),
    FOREIGN KEY (LastUpdatedBy) REFERENCES [USER](Code)
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

CREATE PROC [dbo].[SpUpdateVendor](@Code int, @Name VARCHAR(100), @ShortName VARCHAR(100), @MobileNo BIGINT, @Address VARCHAR(200), 
@Active VARCHAR(50), @LastUpdatedBy int)
As
Update [Vendor] set [Name]=@Name, [ShortName]=@ShortName, [MobileNo]=@MobileNo, [Address]=@Address, 
[Active]=@Active, [LastUpdatedBy]=@LastUpdatedBy, [LastUpdatedDate]=GetDate()
Where [Code] = @Code

--------------
Go
--------------


