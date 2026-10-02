ALTER PROCEDURE [dbo].[SpSaveRateMaster] (@UDT_RateMaster UDT_RateMaster readonly)
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

CREATE TABLE [Vendor](
    [SNo] INT IDENTITY(1,1) ,           
    [Code] INT PRIMARY KEY NOT NULL,               
    [Name] VARCHAR(100) UNIQUE NOT NULL,               
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

CREATE PROCEDURE [dbo].[SpSaveVendor] (@Name VARCHAR(100), @ShortName VARCHAR(100), @MobileNo BIGINT, @Address VARCHAR(200), 
@Active VARCHAR(50), @CreatedBy INT, @LastUpdatedBy INT)
AS BEGIN
    SET NOCOUNT ON;

	DECLARE @Code INT
	SET @Code = (SELECT ISNULL(MAX([Code]), 0) + 1 FROM [Vendor])

	INSERT INTO [Vendor]([Code],[Name],[ShortName],[MobileNo],[Address],
	[Active],[CreatedBy],[CreatedDate],[LastUpdatedBy],[LastUpdatedDate])
	VALUES (@Code, @Name, @ShortName, @MobileNo, @Address, 
	@Active, @CreatedBy, GETDATE(), @LastUpdatedBy, GETDATE())
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpUpdateVendor](@Code INT, @Name VARCHAR(100), @ShortName VARCHAR(100), @MobileNo BIGINT, @Address VARCHAR(200), 
@Active VARCHAR(50), @LastUpdatedBy INT)
AS BEGIN
    SET NOCOUNT ON;

	UPDATE [Vendor] SET [Name]=@Name, [ShortName]=@ShortName, [MobileNo]=@MobileNo, [Address]=@Address, 
	[Active]=@Active, [LastUpdatedBy]=@LastUpdatedBy, [LastUpdatedDate]=GETDATE()
	WHERE [Code] = @Code
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpGetVendorMaster]
AS BEGIN
    SET NOCOUNT ON;

	SELECT V.SNo, V.[Code], V.[Name], V.[ShortName], CAST(V.[MobileNo] AS VARCHAR) AS MobileNo, V.[Address],
	V.[Active] AS ActiveStatusCode, (CASE WHEN V.[Active] = 'Y' THEN 'Yes' ELSE 'No' END) AS Active,
	CU.[Name] AS CreatedBy, V.[CreatedDate], UU.[Name] AS LastUpdatedBy, V.[LastUpdatedDate]
	FROM [Vendor] AS V
	Left Join [User] AS CU ON V.[CreatedBy] = CU.[Code]
	Left Join [User] AS UU ON V.[LastUpdatedBy] = UU.[Code]
	ORDER BY V.SNo DESC
END

--------------
Go
--------------

CREATE TABLE [Customer](
    [SNo] INT IDENTITY(1,1) ,           
    [Code] INT PRIMARY KEY NOT NULL,               
    [Name] VARCHAR(100) UNIQUE NOT NULL,                     
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

CREATE PROCEDURE [dbo].[SpSaveCustomer](@Name VARCHAR(100), @MobileNo BIGINT, @Address VARCHAR(200), 
@Active VARCHAR(50), @CreatedBy INT, @LastUpdatedBy INT)
AS BEGIN
    SET NOCOUNT ON;

	DECLARE @Code INT
	SET @Code = (SELECT ISNULL(MAX([Code]), 0) + 1 FROM [Customer])

	INSERT INTO [Customer]([Code],[Name],[MobileNo],[Address],
	[Active],[CreatedBy],[CreatedDate],[LastUpdatedBy],[LastUpdatedDate])
	VALUES (@Code, @Name, @MobileNo, @Address, 
	@Active, @CreatedBy, GETDATE(), @LastUpdatedBy, GETDATE())
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpUpdateCustomer](@Code INT, @Name VARCHAR(100), @MobileNo BIGINT, @Address VARCHAR(200), 
@Active VARCHAR(50), @LastUpdatedBy INT)
AS BEGIN
    SET NOCOUNT ON;

	UPDATE [Customer] SET [Name]=@Name, [MobileNo]=@MobileNo, [Address]=@Address, 
	[Active]=@Active, [LastUpdatedBy]=@LastUpdatedBy, [LastUpdatedDate]=GETDATE()
	WHERE [Code] = @Code
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpGetCustomerMaster]
AS BEGIN
    SET NOCOUNT ON;

	SELECT C.SNo, C.[Code], C.[Name], CAST(C.[MobileNo] AS VARCHAR) AS MobileNo, C.[Address],
	C.[Active] AS ActiveStatusCode, (CASE WHEN C.[Active] = 'Y' THEN 'Yes' ELSE 'No' END) AS Active,
	CU.[Name] AS CreatedBy, C.[CreatedDate], UU.[Name] AS LastUpdatedBy, C.[LastUpdatedDate]
	FROM [Customer] AS C
	Left Join [User] AS CU ON C.[CreatedBy] = CU.[Code]
	Left Join [User] AS UU ON C.[LastUpdatedBy] = UU.[Code]
	ORDER BY C.SNo DESC
END

--------------
Go
--------------

ALTER TABLE [User] ADD [Password] VARCHAR(15)

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpSaveUser](@Name VARCHAR(100), @Password VARCHAR(15), 
@Active VARCHAR(50), @CreatedBy INT, @LastUpdatedBy INT)
AS BEGIN
    SET NOCOUNT ON;

	DECLARE @Code INT
	SET @Code = (SELECT ISNULL(MAX([Code]), 0) + 1 FROM [User])

	INSERT INTO [User]([Code],[Name],[Password],
	[Active],[CreatedBy],[CreatedDateTime],[LastUpdatedBy],[LastUpdatedDateTime])
	VALUES (@Code, @Name, @Password,
	@Active, @CreatedBy, GETDATE(), @LastUpdatedBy, GETDATE())
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpUpdateUser](@Code INT, @Name VARCHAR(100), @Password VARCHAR(15), 
@Active VARCHAR(50), @LastUpdatedBy INT)
AS BEGIN
    SET NOCOUNT ON;

	UPDATE [User] SET [Name]=@Name, [Password]=@Password, 
	[Active]=@Active, [LastUpdatedBy]=@LastUpdatedBy, [LastUpdatedDateTime]=GETDATE()
	WHERE [Code] = @Code
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpGetUser]
AS BEGIN
    SET NOCOUNT ON;

	SELECT C.SNo, C.[Code], C.[Name], C.[Password],
	C.[Active] AS ActiveStatusCode, (CASE WHEN C.[Active] = 'Y' THEN 'Yes' ELSE 'No' END) AS Active,
	CU.[Name] AS CreatedBy, C.[CreatedDateTime] AS CreatedDate, UU.[Name] AS LastUpdatedBy, C.[LastUpdatedDateTime] AS LastUpdatedDate
	FROM [User] AS C
	Left Join [User] AS CU ON C.[CreatedBy] = CU.[Code]
	Left Join [User] AS UU ON C.[LastUpdatedBy] = UU.[Code]
	ORDER BY C.SNo DESC
END

--------------
Go
--------------

--------------
Go
--------------

CREATE TABLE [ExpenseMaster](
    [SNo] INT IDENTITY(1,1) ,           
    [Code] INT PRIMARY KEY NOT NULL,               
    [Name] VARCHAR(100) UNIQUE NOT NULL,               
	
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

CREATE PROCEDURE [dbo].[SpSaveExpenseMaster](@Name VARCHAR(100),
@Active VARCHAR(50), @CreatedBy INT, @LastUpdatedBy INT)
AS BEGIN
    SET NOCOUNT ON;

	DECLARE @Code INT
	SET @Code = (SELECT ISNULL(MAX([Code]), 0) + 1 FROM [ExpenseMaster])

	INSERT INTO [ExpenseMaster]([Code],[Name],
	[Active],[CreatedBy],[CreatedDate],[LastUpdatedBy],[LastUpdatedDate])
	VALUES (@Code, @Name,
	@Active, @CreatedBy, GETDATE(), @LastUpdatedBy, GETDATE())

END
--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpUpdateExpenseMaster](@Code INT, @Name VARCHAR(100), 
@Active VARCHAR(50), @LastUpdatedBy INT)
AS BEGIN
    SET NOCOUNT ON;

	UPDATE [ExpenseMaster] SET [Name]=@Name,
	[Active]=@Active, [LastUpdatedBy]=@LastUpdatedBy, [LastUpdatedDate]=GETDATE()
	WHERE [Code] = @Code
END
--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpGetExpenseMaster]
AS BEGIN
    SET NOCOUNT ON;

	SELECT E.SNo, E.[Code], E.[Name],
	E.[Active] AS ActiveStatusCode, (CASE WHEN E.[Active] = 'Y' THEN 'Yes' ELSE 'No' END) AS Active,
	CU.[Name] AS CreatedBy, E.[CreatedDate] AS CreatedDate, UU.[Name] AS LastUpdatedBy, E.[LastUpdatedDate] AS LastUpdatedDate
	FROM [ExpenseMaster] AS E
	Left Join [User] AS CU ON E.[CreatedBy] = CU.[Code]
	Left Join [User] AS UU ON E.[LastUpdatedBy] = UU.[Code]
	ORDER BY E.SNo DESC
END

--------------
Go
--------------

CREATE TABLE [PaymentType](
    [SNo] INT IDENTITY(1,1) ,           
    [Code] VARCHAR(1) PRIMARY KEY NOT NULL,               
    [Name] VARCHAR(20) UNIQUE NOT NULL,               
	
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

INSERT INTO [PaymentType]([Code], [Name], [Active], [CreatedBy], [CreatedDate], [LastUpdatedBy], [LastUpdatedDate]) 
VALUES('H', 'Cash', 'Y', 1, GETDATE(), 1, GETDATE())

INSERT INTO [PaymentType]([Code], [Name], [Active], [CreatedBy], [CreatedDate], [LastUpdatedBy], [LastUpdatedDate]) 
VALUES('I', 'UPI', 'Y', 1, GETDATE(), 1, GETDATE())

INSERT INTO [PaymentType]([Code], [Name], [Active], [CreatedBy], [CreatedDate], [LastUpdatedBy], [LastUpdatedDate]) 
VALUES('R', 'Card', 'Y', 1, GETDATE(), 1, GETDATE())

INSERT INTO [PaymentType]([Code], [Name], [Active], [CreatedBy], [CreatedDate], [LastUpdatedBy], [LastUpdatedDate]) 
VALUES('Y', 'GPay/Phone Pay', 'Y', 1, GETDATE(), 1, GETDATE())

INSERT INTO [PaymentType]([Code], [Name], [Active], [CreatedBy], [CreatedDate], [LastUpdatedBy], [LastUpdatedDate]) 
VALUES('T', 'On Credit', 'Y', 1, GETDATE(), 1, GETDATE())

--------------
Go
--------------

CREATE TABLE [CustomerCreditDebitNote](
    [SNo] INT IDENTITY(1,1),
	[TranNo] INT PRIMARY KEY NOT NULL,
    [TranDate] DATE NOT NULL,
    [CustomerCode] INT  NOT NULL,    
	[TransType] CHAR(1) CHECK ([TransType] IN ('C','D'))  NOT NULL,
	[BillNo] INT,
	[BillDate] DATE NOT NULL,
	[Amount] NUMERIC(12, 2) NOT NULL,
	[PaymentType] VARCHAR(1) NOT NULL,
	[Remarks] VARCHAR(100),
    [UpdatedBy] INT NOT NULL,
    [UpdatedDate] DATETIME NOT NULL,                    
    FOREIGN KEY ([CustomerCode]) REFERENCES [Customer]([Code]),
	FOREIGN KEY ([PaymentType]) REFERENCES [PaymentType]([Code]),
    FOREIGN KEY ([UpdatedBy]) REFERENCES [USER]([Code])
)

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpSaveCustomerCreditDebitNote](@CustomerCode INT, @TransType CHAR(1), @BillNo INT, @BillDate DATE,
    @Amount NUMERIC(12, 2), @PaymentType VARCHAR(1), @Remarks VARCHAR(100), @UpdatedBy INT)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TranNo INT;

    -- Generate new TranNo
    SET @TranNo = (SELECT ISNULL(MAX([TranNo]), 0) + 1 FROM [CustomerCreditDebitNote]);

    -- Insert record
    INSERT INTO [CustomerCreditDebitNote] ([TranNo], [TranDate], [CustomerCode], [TransType], [BillNo], [BillDate], 
	[Amount], [PaymentType], [Remarks], [UpdatedBy], [UpdatedDate])
    VALUES (@TranNo, GETDATE(), @CustomerCode, @TransType, @BillNo, @BillDate, 
	@Amount, @PaymentType, @Remarks, @UpdatedBy, GETDATE());
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpUpdateCustomerCreditDebitNote](
    @TranNo INT, @CustomerCode INT, @TransType CHAR(1), @BillNo INT, @BillDate DATE,
    @Amount NUMERIC(12, 2), @PaymentType VARCHAR(1), @Remarks VARCHAR(100), @UpdatedBy INT)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [CustomerCreditDebitNote] SET [CustomerCode] = @CustomerCode, [TransType] = @TransType, [BillNo] = @BillNo, [BillDate] = @BillDate,
	[Amount] = @Amount, [PaymentType] = @PaymentType, [Remarks] = @Remarks, [UpdatedBy] = @UpdatedBy, [UpdatedDate] = GETDATE()
	WHERE [TranNo] = @TranNo;
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpGetCustomerCreditDebitNote]
AS
BEGIN
    SET NOCOUNT ON

    SELECT N.[SNo], N.[TranNo], N.[CustomerCode], C.[Name] AS CustomerName, N.[TransType] AS TransTypeCode,
        (CASE WHEN N.[TransType] = 'C' THEN 'Payment Received' WHEN N.[TransType] = 'D' THEN 'Purchase On Credit' ELSE 'Unknown' END) AS TransType,
		N.[BillNo], N.[BillDate], N.[Amount], N.[PaymentType] AS PaymentTypeCode, PT.[Name] AS PaymentType, N.[Remarks], U.[Name] AS UpdatedBy, N.[UpdatedDate]
		FROM [CustomerCreditDebitNote] AS N
		LEFT JOIN [Customer] AS C ON N.[CustomerCode] = C.[Code]
		LEFT JOIN [PaymentType] AS PT ON N.[PaymentType] = PT.[Code]
		LEFT JOIN [User] AS U ON N.[UpdatedBy] = U.[Code]
    ORDER BY N.[SNo] DESC
END

--------------
Go
--------------

CREATE TABLE [Expenses](
    [SNo] INT IDENTITY(1,1),
	[TranNo] INT PRIMARY KEY NOT NULL,
	[TranDate] DATE NOT NULL,
    [ExpenseCode] INT  NOT NULL,    
	[TransType] CHAR(1) CHECK ([TransType] IN ('C','D'))  NOT NULL,
	[BillNo] INT,
	[BillDate] DATE NOT NULL,
	[Amount] NUMERIC(12, 2) NOT NULL,
	[PaymentType] VARCHAR(1) NOT NULL,
	[Remarks] VARCHAR(100),
    [UpdatedBy] INT NOT NULL,                           
    [UpdatedDate] DATETIME NOT NULL,                    
    FOREIGN KEY ([ExpenseCode]) REFERENCES [ExpenseMaster]([Code]),
	FOREIGN KEY ([PaymentType]) REFERENCES [PaymentType]([Code]),
    FOREIGN KEY ([UpdatedBy]) REFERENCES [USER]([Code])
)

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpSaveExpenses](@ExpenseCode INT, @TransType CHAR(1), @BillNo INT, @BillDate DATE,
    @Amount NUMERIC(12, 2), @PaymentType VARCHAR(1), @Remarks VARCHAR(100), @UpdatedBy INT)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TranNo INT;

    -- Generate new TranNo
    SET @TranNo = (SELECT ISNULL(MAX([TranNo]), 0) + 1 FROM [Expenses]);

    -- Insert record
    INSERT INTO [Expenses] ([TranNo], [TranDate], [ExpenseCode], [TransType], [BillNo], [BillDate], 
	[Amount], [PaymentType], [Remarks], [UpdatedBy], [UpdatedDate])
    VALUES (@TranNo, GETDATE(), @ExpenseCode, @TransType, @BillNo, @BillDate, 
	@Amount, @PaymentType, @Remarks, @UpdatedBy, GETDATE());
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpUpdateExpenses](
    @TranNo INT, @ExpenseCode INT, @TransType CHAR(1), @BillNo INT, @BillDate DATE,
    @Amount NUMERIC(12, 2), @PaymentType VARCHAR(1), @Remarks VARCHAR(100), @UpdatedBy INT)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [Expenses] SET [ExpenseCode] = @ExpenseCode, [TransType] = @TransType, [BillNo] = @BillNo, [BillDate] = @BillDate,
	[Amount] = @Amount, [PaymentType] = @PaymentType, [Remarks] = @Remarks, [UpdatedBy] = @UpdatedBy, [UpdatedDate] = GETDATE()
	WHERE [TranNo] = @TranNo;
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpGetExpenses]
AS
BEGIN
    SET NOCOUNT ON

    SELECT N.[SNo], N.[TranNo], N.[ExpenseCode], C.[Name] AS ExpenseName, N.[TransType] AS TransTypeCode,
        (CASE WHEN N.[TransType] = 'C' THEN 'Earning' WHEN N.[TransType] = 'D' THEN 'Spending' ELSE 'Unknown' END) AS TransType,
		N.[BillNo], N.[BillDate], N.[Amount], N.[PaymentType] AS PaymentTypeCode, PT.[Name] AS PaymentType, N.[Remarks], U.[Name] AS UpdatedBy, N.[UpdatedDate]
		FROM [Expenses] AS N
		LEFT JOIN [ExpenseMaster] AS C ON N.[ExpenseCode] = C.[Code]
		LEFT JOIN [PaymentType] AS PT ON N.[PaymentType] = PT.[Code]
		LEFT JOIN [User] AS U ON N.[UpdatedBy] = U.[Code]
    ORDER BY N.[SNo] DESC
END

--------------
Go
--------------

CREATE TABLE [ProgressStatusMaster](
    [SNo] INT IDENTITY(1,1) ,           
    [Code] VARCHAR(1) PRIMARY KEY NOT NULL,               
    [Name] VARCHAR(20) UNIQUE NOT NULL,               
	
    [Active] CHAR(1) DEFAULT 'Y' CHECK ([Active] IN ('Y', 'N')),                  
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

INSERT INTO [ProgressStatusMaster]([Code], [Name], [Active], [CreatedBy], [CreatedDate], [LastUpdatedBy], [LastUpdatedDate]) 
VALUES('N', 'Not Started', 'Y', 1, GETDATE(), 1, GETDATE())

INSERT INTO [ProgressStatusMaster]([Code], [Name], [Active], [CreatedBy], [CreatedDate], [LastUpdatedBy], [LastUpdatedDate]) 
VALUES('P', 'In Progress', 'Y', 1, GETDATE(), 1, GETDATE())

INSERT INTO [ProgressStatusMaster]([Code], [Name], [Active], [CreatedBy], [CreatedDate], [LastUpdatedBy], [LastUpdatedDate]) 
VALUES('C', 'Completed', 'Y', 1, GETDATE(), 1, GETDATE())

--------------
Go
--------------

CREATE TABLE [VendorBillDetails](
    [SNo] INT IDENTITY(1,1),
	[TranNo] INT PRIMARY KEY NOT NULL,
	[TranDate] DATE NOT NULL,
	[VendorCode] INT NOT NULL,
	[BillNo] VARCHAR(20),
	[BillDate] DATE NOT NULL,
	[BillAmount] NUMERIC(12, 2) NOT NULL,
	[BillChecked] CHAR(1) CHECK ([BillChecked] IN (NULL, 'Y','N')),
    [BillCheckedBy] INT,

	[ItemsCount] INT,
    [IsItemMissing] CHAR(1) CHECK ([IsItemMissing] IN (NULL, 'Y','N')),
    [MissingItemDetails] VARCHAR(100),
	[IsMissingItemReceived] CHAR(1) CHECK ([IsMissingItemReceived] IN (NULL, 'Y','N')),
	[MissingItemReceivedBy] INT,
	[PurchaseEntryStatus] VARCHAR(1),
    [PurchaseEntryBy] INT,

	[Remarks] VARCHAR(100),
	[AmountPaid] NUMERIC(12, 2) NOT NULL,
    [UpdatedBy] INT NOT NULL,                           
    [UpdatedDate] DATETIME NOT NULL,
	
    FOREIGN KEY ([VendorCode]) REFERENCES [Vendor]([Code]),	
	FOREIGN KEY ([BillCheckedBy]) REFERENCES [USER]([Code]),
	FOREIGN KEY ([MissingItemReceivedBy]) REFERENCES [USER]([Code]),
	FOREIGN KEY ([PurchaseEntryStatus]) REFERENCES [ProgressStatusMaster]([Code]),
	FOREIGN KEY ([PurchaseEntryBy]) REFERENCES [USER]([Code]),
    FOREIGN KEY ([UpdatedBy]) REFERENCES [USER]([Code])
)

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpSaveVendorBillDetails](@VendorCode INT, @BillNo VARCHAR(20), @BillDate DATE, @BillAmount NUMERIC(12, 2), @BillChecked CHAR(1), @BillCheckedBy INT, 
    @ItemsCount INT, @IsItemMissing CHAR(1), @MissingItemDetails VARCHAR(100), @IsMissingItemReceived CHAR(1), @MissingItemReceivedBy INT, 
    @PurchaseEntryStatus VARCHAR(20),@PurchaseEntryBy INT, @Remarks VARCHAR(100), @AmountPaid NUMERIC(12, 2), @UpdatedBy INT)
AS BEGIN
    SET NOCOUNT ON;

    DECLARE @TranNo INT;

    -- Generate new TranNo
    SET @TranNo = (SELECT ISNULL(MAX(TranNo), 0) + 1 FROM [VendorBillDetails]);

    -- Insert record
    INSERT INTO [VendorBillDetails] ([TranNo], [TranDate], [VendorCode], [BillNo], [BillDate], [BillAmount], [BillChecked], [BillCheckedBy], 
	[ItemsCount], [IsItemMissing], [MissingItemDetails], [IsMissingItemReceived], [MissingItemReceivedBy], 
	[PurchaseEntryStatus], [PurchaseEntryBy], [Remarks], [AmountPaid], [UpdatedBy], [UpdatedDate])
    VALUES (@TranNo, GETDATE(), @VendorCode, @BillNo, @BillDate, @BillAmount, @BillChecked, @BillCheckedBy,
	@ItemsCount, @IsItemMissing, @MissingItemDetails, @IsMissingItemReceived, @MissingItemReceivedBy, 
	@PurchaseEntryStatus, @PurchaseEntryBy, @Remarks, @AmountPaid, @UpdatedBy, GETDATE());


END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpUpdateVendorBillDetails](@TranNo INT, @VendorCode INT, @BillNo VARCHAR(20), @BillDate DATE, @BillAmount NUMERIC(12, 2), @BillChecked CHAR(1), @BillCheckedBy INT, 
    @ItemsCount INT, @IsItemMissing CHAR(1), @MissingItemDetails VARCHAR(100), @IsMissingItemReceived CHAR(1), @MissingItemReceivedBy INT, 
    @PurchaseEntryStatus VARCHAR(20),@PurchaseEntryBy INT, @Remarks VARCHAR(100), @AmountPaid NUMERIC(12, 2), @UpdatedBy INT)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [VendorBillDetails] SET  [VendorCode] = @VendorCode, [BillNo] = @BillNo, [BillDate] = @BillDate, [BillAmount] = @BillAmount, [BillChecked] = @BillChecked, [BillCheckedBy] = @BillCheckedBy,
	[ItemsCount] = @ItemsCount,	[IsItemMissing] = @IsItemMissing, [MissingItemDetails] = @MissingItemDetails, [IsMissingItemReceived] = @IsMissingItemReceived,  [MissingItemReceivedBy] = @MissingItemReceivedBy, 
	[PurchaseEntryStatus] = @PurchaseEntryStatus, [PurchaseEntryBy] = @PurchaseEntryBy,	[Remarks] = @Remarks, [AmountPaid] = @AmountPaid, [UpdatedBy] = @UpdatedBy, [UpdatedDate] = GETDATE()
    WHERE [TranNo] = @TranNo;
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpGetVendorBillDetails]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT VT.[SNo], VT.[TranNo], VM.[Name] AS VendorName, VT.[BillNo], VT.[BillDate], VT.[BillAmount], 
	(CASE WHEN VT.[BillChecked] = 'Y' THEN 'Yes' WHEN VT.[BillChecked] = 'N' THEN 'No' ELSE '' END) AS BillChecked, UB.[Name] AS BillCheckedBy, 
	VT.[ItemsCount],  (CASE WHEN VT.[IsItemMissing] = 'Y' THEN 'Yes' WHEN VT.[IsItemMissing] = 'N' THEN 'No' ELSE '' END) AS [IsItemMissing], VT.[MissingItemDetails], 
	(CASE WHEN VT.[IsMissingItemReceived] = 'Y' THEN 'Yes' WHEN VT.[IsMissingItemReceived] = 'N' THEN 'No' ELSE '' END) AS IsMissingItemReceived, UM.[Name] AS MissingItemReceivedBy, 
	PS.[Name] AS PurchaseEntryStatus, UP.[Name] AS PurchaseEntryBy,	VT.[Remarks], VT.[AmountPaid], UU.[Name] AS UpdatedBy, VT.[UpdatedDate],
	VT.[VendorCode], VT.[BillChecked] AS BillCheckedCode, VT.[BillCheckedBy] AS BillCheckedByCode,  VT.[IsItemMissing] AS IsItemMissingCode, VT.[IsMissingItemReceived] AS IsMissingItemReceivedCode,
	VT.[MissingItemReceivedBy] AS MissingItemReceivedByCode,  VT.[PurchaseEntryStatus] AS PurchaseEntryStatusCode, 	VT.[PurchaseEntryBy] AS PurchaseEntryByCode, 
	VT.[UpdatedBy] AS UpdatedByCode
    FROM [VendorBillDetails] AS VT
    LEFT JOIN [Vendor] AS VM ON VT.[VendorCode] = VM.[Code]
	LEFT JOIN [ProgressStatusMaster] AS PS ON VT.[PurchaseEntryStatus] = PS.[Code]
    LEFT JOIN [User] AS UB ON VT.[BillCheckedBy] = UB.[Code]
    LEFT JOIN [User] AS UP ON VT.[PurchaseEntryBy] = UP.[Code]
    LEFT JOIN [User] AS UM ON VT.[MissingItemReceivedBy] = UM.[Code]
    LEFT JOIN [User] AS UU ON VT.[UpdatedBy] = UU.[Code]
    ORDER BY VT.[SNo] DESC;
END

--------------
Go
--------------

CREATE TABLE [VendorPaymentDetails] (
    [SNo] INT IDENTITY(1,1),
    [TranNo] INT  PRIMARY KEY NOT NULL,
	[TranDate] DATE NOT NULL,
    [VendorCode] INT NOT NULL,
    [BillNo] VARCHAR(20) NOT NULL,
    [BillDate] DATE NOT NULL,    
    [Amount] NUMERIC(12, 2) NOT NULL,
    [PaymentType] VARCHAR(1) NOT NULL,
	[TransType] CHAR(1) CHECK ([TransType] IN ('C','D'))  NOT NULL,
    [Remarks] VARCHAR(100) NULL,	
	[RefTranNo] INT NULL,	
    [UpdatedBy] INT NOT NULL,
    [UpdatedDate] DATETIME NOT NULL,

    FOREIGN KEY ([VendorCode]) REFERENCES [Vendor]([Code]),
	FOREIGN KEY ([PaymentType]) REFERENCES [PaymentType]([Code]),
	FOREIGN KEY ([RefTranNo]) REFERENCES [VendorBillDetails]([TranNo]),
    FOREIGN KEY ([UpdatedBy]) REFERENCES [USER]([Code])
)

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpSaveVendorPaymentDetails](@VendorCode INT, @BillNo VARCHAR(20), @BillDate DATE, 
@Amount NUMERIC(12, 2), @PaymentType VARCHAR(1), @TransType CHAR(1), @Remarks VARCHAR(100), @RefTranNo INT, @UpdatedBy INT)
AS
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SET NOCOUNT ON;

		DECLARE @TranNo INT;

		-- Generate new TranNo
		SET @TranNo = (SELECT ISNULL(MAX([TranNo]), 0) + 1 FROM [VendorPaymentDetails]);

		-- Insert into table
		INSERT INTO [VendorPaymentDetails]([TranNo], [TranDate], [VendorCode], [BillNo], [BillDate], [Amount],
		[PaymentType], [TransType], [Remarks], [RefTranNo], [UpdatedBy], [UpdatedDate])
		VALUES (@TranNo, GETDATE(), @VendorCode, @BillNo, @BillDate, @Amount,
		@PaymentType, @TransType, @Remarks, @RefTranNo, @UpdatedBy, GETDATE());

		UPDATE [VendorBillDetails] SET [AmountPaid] = [AmountPaid] + @Amount WHERE [TranNo] = @RefTranNo AND [BillNo] = @BillNo AND [BillDate] = @BillDate 
		AND [VendorCode] = @VendorCode

		COMMIT TRAN

	END TRY
	BEGIN CATCH

		ROLLBACK TRAN

	END CATCH
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpUpdateVendorPaymentDetails](@TranNo INT, @VendorCode INT, @BillNo VARCHAR(20), @BillDate DATE, 
		@Amount NUMERIC(12, 2), @PaymentType VARCHAR(1), @Remarks VARCHAR(100), @RefTranNo INT, @UpdatedBy INT)
AS
BEGIN
	BEGIN TRAN

	BEGIN TRY
		SET NOCOUNT ON;

	
		DECLARE @OldAmount NUMERIC(12, 2);
		DECLARE @AmountDiff NUMERIC(12, 2);

		-- Get old amount
		SET @OldAmount = (SELECT [Amount] FROM [VendorPaymentDetails] WHERE [TranNo] = @TranNo);
		-- Find Amount diff
		SET @AmountDiff = @Amount - @OldAmount

		UPDATE [VendorPaymentDetails] SET [Amount] = @Amount, [PaymentType] = @PaymentType, [Remarks] = @Remarks, [UpdatedBy] = @UpdatedBy, [UpdatedDate] = GETDATE()
		WHERE [TranNo] = @TranNo;

		UPDATE [VendorBillDetails] SET [AmountPaid] = [AmountPaid] + @AmountDiff WHERE [TranNo] = @RefTranNo AND [BillNo] = @BillNo AND [BillDate] = @BillDate 
		AND [VendorCode] = @VendorCode
	
		COMMIT TRAN

	END TRY
	BEGIN CATCH

		ROLLBACK TRAN

	END CATCH
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpGetVendorPaymentDetails]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT  VPD.[SNo], VPD.[TranNo], VPD.[VendorCode], V.[Name] AS VendorName,	
    VPD.[BillNo], VPD.[BillDate], VPD.[Amount] AS AmountPaid, PT.[Name] AS PaymentType, VPD.[Remarks],
	(CASE WHEN VPD.[TransType] = 'C' THEN 'Credit' WHEN VPD.[TransType] = 'D' THEN 'Debit' ELSE '' END) AS TransType,
	VPD.[RefTranNo], U.[Name] AS UpdatedBy, VPD.[UpdatedDate], VPD.[TransType] AS TransTypeCode, VPD.[PaymentType] AS PaymentTypeCode
    FROM [VendorPaymentDetails] AS VPD 
	LEFT JOIN [Vendor] AS V ON VPD.[VendorCode] = V.[Code]
	LEFT JOIN [PaymentType] AS PT ON VPD.[PaymentType] = PT.[Code]
	LEFT JOIN [User] AS U ON VPD.[UpdatedBy] = U.[Code]
    ORDER BY VPD.[SNo] DESC;
END

--------------
Go
--------------

CREATE TABLE [UndiyalCreditDebitNote](
    [SNo] INT IDENTITY(1,1),
	[TranNo] INT PRIMARY KEY NOT NULL,
	[TranDate] DATE NOT NULL,
	[TransType] CHAR(1) CHECK ([TransType] IN ('C','D'))  NOT NULL,
	[Amount] NUMERIC(12, 2) NOT NULL,
	[PaymentType] VARCHAR(1) NOT NULL,
	[Remarks] VARCHAR(100),
    [UpdatedBy] INT NOT NULL,                           
    [UpdatedDate] DATETIME NOT NULL,
	FOREIGN KEY ([PaymentType]) REFERENCES [PaymentType]([Code]),
    FOREIGN KEY ([UpdatedBy]) REFERENCES [USER]([Code])
)

--------------
Go
--------------

CREATE TABLE [UndiyalDailyTransaction](
    [SNo] INT IDENTITY(1,1),
	[TranNo] INT PRIMARY KEY NOT NULL,
	[TranDate] DATE UNIQUE NOT NULL,
	[OpeningBalance] NUMERIC(12, 2) NOT NULL,
	[Deposit] NUMERIC(12, 2) NOT NULL,
	[Withdraw] NUMERIC(12, 2) NOT NULL,
	[ClosingBalance] NUMERIC(12, 2) NOT NULL,
    [UpdatedBy] INT NOT NULL,                           
    [UpdatedDate] DATETIME NOT NULL,
    FOREIGN KEY ([UpdatedBy]) REFERENCES [USER]([Code])
)

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpSaveUndiyalCreditDebitNote](@TranDate DATE, @TransType CHAR(1), @Amount NUMERIC(12, 2), @PaymentType VARCHAR(1), @Remarks VARCHAR(100), @UpdatedBy INT)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        ----------------------------------
        -- Step 1: Insert into Credit/Debit Note
        ----------------------------------
        DECLARE @CreditDebitTranNo INT;
        SET @CreditDebitTranNo = (SELECT ISNULL(MAX(TranNo), 0) + 1 FROM [UndiyalCreditDebitNote]);

        INSERT INTO [UndiyalCreditDebitNote]([TranNo], [TranDate], [TransType], [Amount], [PaymentType], [Remarks], [UpdatedBy], [UpdatedDate])
        VALUES (@CreditDebitTranNo, @TranDate, @TransType, @Amount, @PaymentType, @Remarks, @UpdatedBy, GETDATE());

        ----------------------------------
        -- Step 2: Insert or Update Daily Cumulative Transaction
        ----------------------------------
        DECLARE @OpeningBalance NUMERIC(12,2) = 0;
        DECLARE @ClosingBalance NUMERIC(12,2);
        DECLARE @LastClosingBalance NUMERIC(12,2);
        DECLARE @ExistingTranNo INT;
        DECLARE @Deposit NUMERIC(12,2) = 0;
        DECLARE @Withdraw NUMERIC(12,2) = 0;

        -- Set deposit/withdraw based on transaction type
        IF @TransType = 'C'
            SET @Deposit = @Amount;
        ELSE IF @TransType = 'D'
            SET @Withdraw = @Amount;

        -- Check if entry already exists for the date
        SELECT @ExistingTranNo = [TranNo] 
		FROM [UndiyalDailyTransaction] 
        WHERE [TranDate] = @TranDate;

        -- Get previous day's closing balance
        SELECT TOP 1 @LastClosingBalance = [ClosingBalance] 
		FROM [UndiyalDailyTransaction]
        WHERE [TranDate] < @TranDate
        ORDER BY [TranDate] DESC;

        SET @OpeningBalance = ISNULL(@LastClosingBalance, 0);

        IF @ExistingTranNo IS NOT NULL
        BEGIN
            -- Update existing record
            UPDATE [UndiyalDailyTransaction]
            SET 
                [Deposit] = [Deposit] + @Deposit,
                [Withdraw] = [Withdraw] + @Withdraw,
                [ClosingBalance] = [OpeningBalance] + ([Deposit] + @Deposit) - ([Withdraw] + @Withdraw),
                [UpdatedBy] = @UpdatedBy,
                [UpdatedDate] = GETDATE()
            WHERE [TranNo] = @ExistingTranNo;
        END
        ELSE
        BEGIN
            -- Insert new record
            DECLARE @NewTranNo INT;
            SELECT @NewTranNo = ISNULL(MAX([TranNo]), 0) + 1 FROM [UndiyalDailyTransaction];

            SET @ClosingBalance = @OpeningBalance + @Deposit - @Withdraw;

            INSERT INTO [UndiyalDailyTransaction] (
                [TranNo], [TranDate], [OpeningBalance], [Deposit], [Withdraw], [ClosingBalance], [UpdatedBy], [UpdatedDate]
            )
            VALUES (
                @NewTranNo, @TranDate, @OpeningBalance, @Deposit, @Withdraw, @ClosingBalance, @UpdatedBy, GETDATE()
            );
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @ErrMsg NVARCHAR(4000), @ErrSeverity INT;
        SELECT @ErrMsg = ERROR_MESSAGE(), @ErrSeverity = ERROR_SEVERITY();
        RAISERROR(@ErrMsg, @ErrSeverity, 1);
    END CATCH
END


--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpUpdateUndiyalCreditDebitNote](@TranNo INT, @TransType CHAR(1), @Amount NUMERIC(12,2), 
@PaymentType VARCHAR(1), @Remarks VARCHAR(100), @UpdatedBy INT)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        --------------------------------------
        -- 1. Get the old record details
        --------------------------------------
        DECLARE 
            @OldTransType CHAR(1),
            @OldAmount NUMERIC(12,2),
            @TranDate DATE,
            @ExistingTranNo INT;

        SELECT
            @OldTransType = TransType,
            @OldAmount = Amount,
            @TranDate = TranDate
        FROM UndiyalCreditDebitNote
        WHERE TranNo = @TranNo;

        IF @TranDate IS NULL
        BEGIN
            RAISERROR('Transaction not found.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        --------------------------------------
        -- 2. Update UndiyalCreditDebitNote
        --------------------------------------
        UPDATE UndiyalCreditDebitNote
        SET
            TransType = @TransType,
            Amount = @Amount,
            PaymentType = @PaymentType,
            Remarks = @Remarks,
            UpdatedBy = @UpdatedBy,
            UpdatedDate = GETDATE()
        WHERE TranNo = @TranNo;

        --------------------------------------
        -- 3. Update UndiyalDailyTransaction
        --------------------------------------

        -- Find the daily record
        SELECT @ExistingTranNo = TranNo
        FROM UndiyalDailyTransaction
        WHERE TranDate = @TranDate;

        IF @ExistingTranNo IS NULL
        BEGIN
            RAISERROR('Daily transaction not found for this date.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Adjust Deposit and Withdraw:
        -- First, remove old amount
        IF @OldTransType = 'C'
        BEGIN
            UPDATE UndiyalDailyTransaction
            SET 
                Deposit = Deposit - @OldAmount
            WHERE TranNo = @ExistingTranNo;
        END
        ELSE IF @OldTransType = 'D'
        BEGIN
            UPDATE UndiyalDailyTransaction
            SET 
                Withdraw = Withdraw - @OldAmount
            WHERE TranNo = @ExistingTranNo;
        END

        -- Then, add new amount
        IF @TransType = 'C'
        BEGIN
            UPDATE UndiyalDailyTransaction
            SET 
                Deposit = Deposit + @Amount
            WHERE TranNo = @ExistingTranNo;
        END
        ELSE IF @TransType = 'D'
        BEGIN
            UPDATE UndiyalDailyTransaction
            SET 
                Withdraw = Withdraw + @Amount
            WHERE TranNo = @ExistingTranNo;
        END

        -- Recompute ClosingBalance
        UPDATE UndiyalDailyTransaction
        SET
            ClosingBalance = OpeningBalance + Deposit - Withdraw,
            UpdatedBy = @UpdatedBy,
            UpdatedDate = GETDATE()
        WHERE TranNo = @ExistingTranNo;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @ErrMsg NVARCHAR(4000), @ErrSeverity INT;
        SELECT @ErrMsg = ERROR_MESSAGE(), @ErrSeverity = ERROR_SEVERITY();
        RAISERROR(@ErrMsg, @ErrSeverity, 1);
    END CATCH
END

--------------
Go
--------------

CREATE PROCEDURE [dbo].[SpGetUndiyalCreditDebitNote]
AS
BEGIN
    SET NOCOUNT ON

    SELECT MT.[SNo], MT.[TranNo], MT.[TranDate], MT.[TransType] AS TransTypeCode,
        (CASE WHEN MT.[TransType] = 'C' THEN 'Deposit' WHEN MT.[TransType] = 'D' THEN 'Withdraw' ELSE 'Unknown' END) AS TransType,
		MT.[Amount], MT.[PaymentType] AS PaymentTypeCode, PT.[Name] AS PaymentType, MT.[Remarks], U.[Name] AS UpdatedBy, MT.[UpdatedDate]
		FROM [UndiyalCreditDebitNote] AS MT
		LEFT JOIN [PaymentType] AS PT ON MT.[PaymentType] = PT.[Code]
		LEFT JOIN [User] AS U ON MT.[UpdatedBy] = U.[Code]
    ORDER BY MT.[SNo] DESC
END

--------------
Go
--------------

UPDATE [PaymentDetails] SET PaymentType = 'H' WHERE PaymentType = 'CASH'
UPDATE [PaymentDetails] SET PaymentType = 'R' WHERE PaymentType = 'CARD'
UPDATE [PaymentDetails] SET PaymentType = 'I' WHERE PaymentType = 'UPI'

--------------
Go
--------------


CREATE TABLE [CashDailySummary] (
    [SNo] INT IDENTITY(1,1),
    [TranNo] INT PRIMARY KEY NOT NULL,
    [TranDate] DATE UNIQUE NOT NULL,

    -- Opening
    [OpeningBalance] NUMERIC(12, 2) NOT NULL,

    -- Inflows
    [CashSales] NUMERIC(12, 2) NOT NULL,
    [CustomerDueReceivedCash] NUMERIC(12, 2) NOT NULL,
    [UndiyalCashWithdraw] NUMERIC(12, 2) NOT NULL,

    -- Outflows
    [VendorPaymentCash] NUMERIC(12, 2) NOT NULL,
    [ExpenseCash] NUMERIC(12, 2) NOT NULL,
    [UndiyalCashDeposit] NUMERIC(12, 2) NOT NULL,

    -- Balances
    [CashOnHand] NUMERIC(12, 2) NOT NULL,
    [CoinOnHand] NUMERIC(12, 2) NOT NULL,

    [TallyAmount] NUMERIC(12, 2) NOT NULL,

    [ClosingBalance] NUMERIC(12, 2) NOT NULL,
	
    [Remarks] VARCHAR(200),

    [UpdatedBy] INT NOT NULL,
    [UpdatedDate] DATETIME NOT NULL,

    FOREIGN KEY ([UpdatedBy]) REFERENCES [USER]([Code])
)

--------------
Go
--------------

CREATE TABLE [CashDailyAllClosingDetails] (
    [SNo] INT IDENTITY(1,1),
    [TranNo] INT PRIMARY KEY NOT NULL,
    [TranDate] DATE NOT NULL,

    -- Opening
    [OpeningBalance] NUMERIC(12, 2) NOT NULL,

    -- Inflows
    [CashSales] NUMERIC(12, 2) NOT NULL,
    [CustomerDueReceivedCash] NUMERIC(12, 2) NOT NULL,
    [UndiyalCashWithdraw] NUMERIC(12, 2) NOT NULL,

    -- Outflows
    [VendorPaymentCash] NUMERIC(12, 2) NOT NULL,
    [ExpenseCash] NUMERIC(12, 2) NOT NULL,
    [UndiyalCashDeposit] NUMERIC(12, 2) NOT NULL,

    -- Balances
    [CashOnHand] NUMERIC(12, 2) NOT NULL,
    [CoinOnHand] NUMERIC(12, 2) NOT NULL,

    [TallyAmount] NUMERIC(12, 2) NOT NULL,

    [ClosingBalance] NUMERIC(12, 2) NOT NULL,
	
    [Remarks] VARCHAR(200),

    [UpdatedBy] INT NOT NULL,
    [UpdatedDate] DATETIME NOT NULL,

    FOREIGN KEY ([UpdatedBy]) REFERENCES [USER]([Code])
)

--------------
Go
--------------

CREATE PROCEDURE [SpSaveCashDailySummary]
(
    @OpeningBalance NUMERIC(12, 2),
    @CashSales NUMERIC(12, 2),
    @CustomerDueReceivedCash NUMERIC(12, 2),
    @UndiyalCashWithdraw NUMERIC(12, 2),
    @VendorPaymentCash NUMERIC(12, 2),
    @ExpenseCash NUMERIC(12, 2),
    @UndiyalCashDeposit NUMERIC(12, 2),
    @CashOnHand NUMERIC(12, 2),
    @CoinOnHand NUMERIC(12, 2),
    @TallyAmount NUMERIC(12, 2),
    @ClosingBalance NUMERIC(12, 2),
    @Remarks VARCHAR(200),
    @UpdatedBy INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @Today DATE = CAST(GETDATE() AS DATE);

        -------------------------------
        -- 1. Handle [CashDailySummary]
        -------------------------------
        IF EXISTS (
            SELECT 1 
            FROM [CashDailySummary] 
            WHERE CAST([TranDate] AS DATE) = @Today
        )
        BEGIN
            -- Update existing record for today
            UPDATE [CashDailySummary]
            SET 
                [OpeningBalance] = @OpeningBalance,
                [CashSales] = @CashSales,
                [CustomerDueReceivedCash] = @CustomerDueReceivedCash,
                [UndiyalCashWithdraw] = @UndiyalCashWithdraw,
                [VendorPaymentCash] = @VendorPaymentCash,
                [ExpenseCash] = @ExpenseCash,
                [UndiyalCashDeposit] = @UndiyalCashDeposit,
                [CashOnHand] = @CashOnHand,
                [CoinOnHand] = @CoinOnHand,
                [TallyAmount] = @TallyAmount,
                [ClosingBalance] = @ClosingBalance,
                [Remarks] = @Remarks,
                [UpdatedBy] = @UpdatedBy,
                [UpdatedDate] = GETDATE()
            WHERE CAST([TranDate] AS DATE) = @Today;
        END
        ELSE
        BEGIN
            -- Insert new record
            DECLARE @SummaryTranNo INT = ISNULL((SELECT MAX([TranNo]) FROM [CashDailySummary]), 0) + 1;

            INSERT INTO [CashDailySummary]
            (
                [TranNo], [TranDate], [OpeningBalance], [CashSales], [CustomerDueReceivedCash],
                [UndiyalCashWithdraw], [VendorPaymentCash], [ExpenseCash], [UndiyalCashDeposit],
                [CashOnHand], [CoinOnHand], [TallyAmount], [ClosingBalance],
                [Remarks], [UpdatedBy], [UpdatedDate]
            )
            VALUES
            (
                @SummaryTranNo, GETDATE(), @OpeningBalance, @CashSales, @CustomerDueReceivedCash,
                @UndiyalCashWithdraw, @VendorPaymentCash, @ExpenseCash, @UndiyalCashDeposit,
                @CashOnHand, @CoinOnHand, @TallyAmount, @ClosingBalance,
                @Remarks, @UpdatedBy, GETDATE()
            );
        END

        -------------------------------------------
        -- 2. Always Insert into [CashDailyAllClosingDetails]
        -------------------------------------------
        DECLARE @AllClosingTranNo INT = ISNULL((SELECT MAX([TranNo]) FROM [CashDailyAllClosingDetails]), 0) + 1;

        INSERT INTO [CashDailyAllClosingDetails]
        (
            [TranNo], [TranDate], [OpeningBalance], [CashSales], [CustomerDueReceivedCash],
            [UndiyalCashWithdraw], [VendorPaymentCash], [ExpenseCash], [UndiyalCashDeposit],
            [CashOnHand], [CoinOnHand], [TallyAmount], [ClosingBalance],
            [Remarks], [UpdatedBy], [UpdatedDate]
        )
        VALUES
        (
            @AllClosingTranNo, GETDATE(), @OpeningBalance, @CashSales, @CustomerDueReceivedCash,
            @UndiyalCashWithdraw, @VendorPaymentCash, @ExpenseCash, @UndiyalCashDeposit,
            @CashOnHand, @CoinOnHand, @TallyAmount, @ClosingBalance,
            @Remarks, @UpdatedBy, GETDATE()
        );

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrMsg, 16, 1);
    END CATCH
END

--------------
Go
--------------

CREATE PROCEDURE [SpInsertZeroCashDailySummary](@UpdatedBy INT)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @Today DATE = CAST(GETDATE() AS DATE);
        DECLARE @NewTranNo INT = ISNULL((SELECT MAX([TranNo]) FROM [CashDailySummary]), 0) + 1;
        DECLARE @OpeningBalance NUMERIC(12, 2) = 0.00;

        -- Prevent duplicate insert for today
        IF NOT EXISTS (SELECT 1 FROM [CashDailySummary] WHERE CAST([TranDate] AS DATE) = @Today)
        BEGIN
            -- Get last closing balance if exists
            IF EXISTS (SELECT 1 FROM [CashDailySummary])
            BEGIN
                SELECT TOP 1 @OpeningBalance = [ClosingBalance]
                FROM [CashDailySummary]
                ORDER BY [TranDate] DESC;
            END

            -- Insert new zero record
            INSERT INTO [CashDailySummary]
            (
                [TranNo], [TranDate], [OpeningBalance], [CashSales], [CustomerDueReceivedCash],
                [UndiyalCashWithdraw], [VendorPaymentCash], [ExpenseCash], [UndiyalCashDeposit],
                [CashOnHand], [CoinOnHand], [TallyAmount], [ClosingBalance],
                [Remarks], [UpdatedBy], [UpdatedDate]
            )
            VALUES
            (
                @NewTranNo, @Today, @OpeningBalance, 0.00, 0.00,
                0.00, 0.00, 0.00, 0.00,
                0.00, 0.00, 0.00, @OpeningBalance,
                N'Auto Insert - Opening Entry', @UpdatedBy, GETDATE()
            );
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrMsg, 16, 1);
    END CATCH
END

--------------
Go
--------------

CREATE PROCEDURE [SpGetCashDailySummaryByToday]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT [TranNo], [TranDate], [OpeningBalance], [CashSales], [CustomerDueReceivedCash], [UndiyalCashWithdraw],
    [VendorPaymentCash], [ExpenseCash], [UndiyalCashDeposit], [CashOnHand], [CoinOnHand], [TallyAmount],
    [ClosingBalance], [Remarks], [UpdatedBy], [UpdatedDate] 
	FROM [CashDailySummary]
    WHERE CAST([TranDate] AS DATE) = CAST(GETDATE() AS DATE)
END

--------------
Go
--------------

CREATE PROCEDURE [SpGetCashDailyAllClosingDetailsByToday]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT [TranNo], [TranDate], [OpeningBalance], [CashSales], [CustomerDueReceivedCash], [UndiyalCashWithdraw],
    [VendorPaymentCash], [ExpenseCash], [UndiyalCashDeposit], [CashOnHand], [CoinOnHand], [TallyAmount],
    [ClosingBalance], [Remarks], U.[Name] AS UpdatedBy, [UpdatedDate] 
	FROM [CashDailyAllClosingDetails] AS MT
	LEFT JOIN [User] AS U ON MT.[UpdatedBy] = U.[Code]
    WHERE CAST([TranDate] AS DATE) = CAST(GETDATE() AS DATE)
	ORDER BY [TranNo] DESC
END

--------------
Go
--------------

DROP PROCEDURE [SpSaveSale]

DROP TYPE [UDT_PaymentDetails]

CREATE TYPE [dbo].[UDT_PaymentDetails] AS TABLE(
	[PaymentType] [varchar](10) NOT NULL,
	[Amount] [numeric](12, 2) NOT NULL,
	[CustomerCode] [int] NULL,
	[BilledBy] [int] NULL
)

--------------
Go
--------------

CREATE PROC [dbo].[SpSaveSale] (@UDT_Sales UDT_Sales readonly, @UDT_Transaction UDT_Transaction readonly, @UDT_PaymentDetails UDT_PaymentDetails readonly, @BILLNO INT OUTPUT)  
As  
BEGIN TRAN  
  
BEGIN TRY  
  
	 DECLARE @CNT AS INT  
  
	 SET @CNT = (SELECT COUNT(*) AS CNT FROM [BillNoDetails] WHERE BilledDate = CAST(GETDATE() AS Date ))  
  
	 IF @CNT <= 0  
	  INSERT INTO [BillNoDetails]([BillNo], [BilledDate]) VALUES (101, CAST(GETDATE() AS Date ))  
	 ELSE  
	  UPDATE [BillNoDetails] SET [BillNo] = [BillNo] + 1 WHERE BilledDate = CAST(GETDATE() AS Date )  
  
	 SET @BILLNO = (SELECT BillNo FROM [BillNoDetails] WHERE BilledDate = CAST(GETDATE() AS Date ))  
  
  
	 INSERT INTO [Sales]([BillNo],[BilledDate],[ProductCode],[Qty],[Unit],[SellRate],[Amount],  
	 [DiscPercent],[DiscAmount],[TotAmount],[MRP],[TotDiscAmtFromMRP],[BilledBy],[BilledDateTime])  
	 SELECT @BILLNO,CAST(GETDATE() AS Date ),[ProductCode],[Qty],[Unit],[SellRate],[Amount],  
	 [DiscPercent],[DiscAmount],[TotAmount],[MRP],[TotDiscAmtFromMRP],[BilledBy],GETDATE()  
	 FROM @UDT_Sales  
   
  
	 INSERT INTO [SalesTransaction]([BillNo],[BilledDate],[TotAmount],[DiscPercent],[DiscAmount],[GrossAmount],[RoundOffAmount],[NetAmount],  
	 [BilledBy],[BilledDateTime], [PrintTotMRP], [PrintTotDiscMRP])  
	 SELECT @BILLNO, CAST(GETDATE() AS Date ), [TotAmount],[DiscPercent],[DiscAmount],[GrossAmount],[RoundOffAmount],[NetAmount],  
	 [BilledBy], GETDATE(), [PrintTotMRP], [PrintTotDiscMRP] FROM @UDT_Transaction  
  

	 INSERT INTO [PaymentDetails]([BillNo],[BilledDate],[PaymentType],[Amount],[BilledBy],[BilledDateTime])  
	 SELECT @BILLNO, CAST(GETDATE() AS Date ), [PaymentType], [Amount], [BilledBy], GETDATE() FROM @UDT_PaymentDetails  
	
	
	 DECLARE @TranNo INT;
	 -- Generate new TranNo
	 SET @TranNo = (SELECT ISNULL(MAX([TranNo]), 0) + 1 FROM [CustomerCreditDebitNote]);
	 
	 -- Insert record
	 INSERT INTO [CustomerCreditDebitNote] ([TranNo], [TranDate], [CustomerCode], [TransType], [BillNo], [BillDate], 
	 [Amount], [PaymentType], [Remarks], [UpdatedBy], [UpdatedDate])
	 SELECT @TranNo, GETDATE(), [CustomerCode], 'D' AS TransType, @BillNo, CAST(GETDATE() AS Date) AS BillDate, 
	 [Amount], [PaymentType], 'RECORD FROM POS' AS Remarks, [BilledBy], GETDATE() FROM @UDT_PaymentDetails WHERE [PaymentType] = 'T' 
  
 COMMIT TRAN  
  
END TRY  
BEGIN CATCH  
  
 ROLLBACK TRAN  
  
END CATCH

--------------
Go
--------------

ALTER PROC [dbo].[SpGetProductRate]    
AS 
BEGIN
  
	Select CAST(P.[Code] as VARCHAR) as ProductCode, P.[Name] as ProductName, P.[TamilName] as ProductTName, P.[AlternativeName] as ProductAltrName, P.[CatCode], P.[QtyTypeCode], P.[CalcBasedRateMast],    
	Q.ShortName as Qty, CAST(P.[Code] AS VARCHAR) + ' - ' + P.[Name] + ' - ' + P.[TamilName] as SearchName,   
	(Case When IsNull(P.BarCode, '') = '' Then 'B' + REPLICATE('0', 5 - LEN(RTRIM(CAST(P.[Code] as VARCHAR)))) +  RTRIM(CAST(P.[Code] as VARCHAR)) Else P.BarCode End ) as BarCode,  
	'0.00' PurRate, '0.00' MRP, R.SellRate, '0.00' SellingMarginPer, '0.00' DiscPer, '0.00' DiscRate  
	From [Product] as P    
	Inner Join [RateMaster] as R ON P.Code = R.ProductCode    
	Inner Join [Quantity] as Q ON P.QtyTypeCode = Q.Code    
	Where ISNULL(P.CalcBasedRateMast,'') = 'Y' And ISNULL(P.Active,'') = 'Y'    
   
	Union    
    
	Select CAST(P.[Code] as VARCHAR) as ProductCode, P.[Name], P.[TamilName], P.[AlternativeName], P.[CatCode], P.[QtyTypeCode], P.[CalcBasedRateMast], Q.ShortName as Qty, 
	CAST(P.[Code] as VARCHAR) + ' - ' 
	+ P.[Name] 
	--+ (Case When IsNull(P.BarCode, '') = '' Then ' - ' + P.[TamilName] Else '' End) 
	+ ' - MRP: ' + CAST(S.[MRP] as VARCHAR) as SearchName,  

	(Case When IsNull(P.BarCode, '') = '' Then 'B' + REPLICATE('0', 5 - LEN(RTRIM(CAST(P.[Code] as VARCHAR)))) +  RTRIM(CAST(P.[Code] as VARCHAR)) Else P.BarCode End ) as BarCode,  
	S.PurRate, S.MRP, S.SellRate, S.SellingMarginPer, S.DiscPer, S.DiscRate  
	From [Product] as P  
	Inner Join [Stock] as S On P.[Code] = S.ProductCode  
	Inner Join [Quantity] as Q ON P.QtyTypeCode = Q.Code    
	Where ISNULL(P.CalcBasedRateMast,'') != 'Y' And ISNULL(P.Active,'') = 'Y'  
   
	Union    
    
	Select CAST(P.[Code] as VARCHAR) as ProductCode, P.[Name], P.[TamilName], P.[AlternativeName], P.[CatCode], P.[QtyTypeCode], P.[CalcBasedRateMast],    
	Q.ShortName as Qty, CAST(P.[Code] as VARCHAR) + ' - ' + P.[Name]   
	+ (Case When IsNull(P.BarCode, '') = '' Then ' - ' + P.[TamilName] Else '' End) as SearchName,    
	(Case When IsNull(P.BarCode, '') = '' Then 'B' + REPLICATE('0', 5 - LEN(RTRIM(CAST(P.[Code] as VARCHAR)))) +  RTRIM(CAST(P.[Code] as VARCHAR)) Else P.BarCode End ) as BarCode,  
	'0.00' PurRate, '0.00' MRP, '0.00' SellRate, '0.00' SellingMarginPer, '0.00' DiscPer, '0.00' DiscRate  
	From [Product] as P  
	Inner Join [Quantity] as Q ON P.QtyTypeCode = Q.Code    
	Where ISNULL(P.CalcBasedRateMast,'') != 'Y' And ISNULL(P.Active,'') = 'Y'    
	And Not Exists ( Select S.ProductCode From [Stock] as S Where P.[Code] = S.ProductCode )  
	Order By P.[NAME]  

END




