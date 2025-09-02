USE [VBOX2526_LIVE]

---------------
Go
---------------

ALTER TABLE [Product] ADD [AllowRateChange] [varchar](1) NULL
ALTER TABLE [Product] ADD [BarCode2] [varchar](50) NULL
ALTER TABLE [Product] ADD [BarCode3] [varchar](50) NULL
ALTER TABLE [Product] ADD [BarCode4] [varchar](50) NULL
ALTER TABLE [RateMaster] ADD [MRP] [numeric](12,2) NULL

ALTER TABLE Product NOCHECK CONSTRAINT FK__Product__CatCode__60A75C0F

UPDATE [dbo].[Category]
SET Code = CASE 
              WHEN Code = 9 THEN 3
              WHEN Code = 3 THEN 9
              WHEN Code = 10 THEN 5
              WHEN Code = 5 THEN 10
              ELSE Code
           END
WHERE Code IN (3, 5, 9, 10);

UPDATE [dbo].[Product]
SET CatCode = CASE 
                 WHEN CatCode = 9 THEN 3
                 WHEN CatCode = 3 THEN 9
                 WHEN CatCode = 10 THEN 5
                 WHEN CatCode = 5 THEN 10
                 ELSE CatCode
              END
WHERE CatCode IN (3, 5, 9, 10);

ALTER TABLE Product CHECK CONSTRAINT FK__Product__CatCode__60A75C0F

---------------
Go
---------------

ALTER TABLE [dbo].[Purchase] ADD [VendorBillRefNo] INT NULL;
ALTER TABLE [dbo].[PurchaseTransaction] ADD [VendorBillRefNo] INT NULL;

ALTER TABLE [dbo].[Purchase] ADD CONSTRAINT FK_Purchase_VendorBillDetails
FOREIGN KEY ([VendorBillRefNo]) REFERENCES [dbo].[VendorBillDetails]([TranNo]);

ALTER TABLE [dbo].[PurchaseTransaction] ADD CONSTRAINT FK_PurchaseTran_VendorBillDetails
FOREIGN KEY ([VendorBillRefNo]) REFERENCES [dbo].[VendorBillDetails]([TranNo]);

EXEC SP_RENAME 'dbo.Purchase.BillNo', 'TranNo', 'COLUMN'
EXEC SP_RENAME 'dbo.Purchase.BillDate', 'TranDate', 'COLUMN'
EXEC SP_RENAME 'dbo.Purchase.BilledBy', 'EnteredBy', 'COLUMN'
EXEC SP_RENAME 'dbo.Purchase.BilledDateTime', 'EnteredDateTime', 'COLUMN'

EXEC SP_RENAME 'dbo.PurchaseTransaction.BillNo', 'TranNo', 'COLUMN'
EXEC SP_RENAME 'dbo.PurchaseTransaction.BilledDate', 'TranDate', 'COLUMN'
EXEC SP_RENAME 'dbo.PurchaseTransaction.BilledBy', 'EnteredBy', 'COLUMN'
EXEC SP_RENAME 'dbo.PurchaseTransaction.BilledDateTime', 'EnteredDateTime', 'COLUMN'

EXEC SP_RENAME 'dbo.Stock.TotPurQty', 'LastPurQty', 'COLUMN'
ALTER TABLE [Stock] ADD [StockQty] NUMERIC(12,2)
ALTER TABLE [Stock] Drop column TotSellQty

ALTER TABLE [Stock] ALTER COLUMN LastUpdatedDate DATE 

ALTER TABLE dbo.Stock DROP CONSTRAINT UQ__Stock__2F4E024FC399C07A

ALTER TABLE dbo.Stock ADD CONSTRAINT UQ_Stock_ProductCode_MRP UNIQUE (ProductCode, MRP)

EXEC SP_RENAME 'dbo.Sales.CancelledBy', 'UpdatedBy', 'COLUMN'
EXEC SP_RENAME 'dbo.Sales.CancelledDateTime', 'UpdatedDateTime', 'COLUMN'

EXEC SP_RENAME 'dbo.SalesTransaction.CancelledBy', 'UpdatedBy', 'COLUMN'
EXEC SP_RENAME 'dbo.SalesTransaction.CancelledDateTime', 'UpdatedDateTime', 'COLUMN'

EXEC SP_RENAME 'dbo.PaymentDetails.CancelledBy', 'UpdatedBy', 'COLUMN'
EXEC SP_RENAME 'dbo.PaymentDetails.CancelledDateTime', 'UpdatedDateTime', 'COLUMN'

---------------
Go
---------------

DROP PROCEDURE SpSavePurchase
DROP TYPE UDT_Purchase

CREATE TYPE [dbo].[UDT_Purchase] AS TABLE(
	[ProductCode] [int] NOT NULL,
	[TotPurQty] [numeric](12, 2) NOT NULL,
	[Unit] [varchar](5) NOT NULL,
	[TotPurAmount] [numeric](12, 2) NOT NULL,
	[PurRatePerQty] [numeric](12, 2) NOT NULL,
	[SellRatePerQty] [numeric](12, 2) NOT NULL,
	[MRP] [numeric](12, 2) NULL,
	[SellingMarginPer] [numeric](12, 2) NULL,
	[DiscPer] [numeric](12, 2) NULL,
	[DiscRate] [numeric](12, 2) NULL,
	[BilledBy] [int] NULL
)

---------------
Go
---------------

CREATE TABLE [VendorProductLink](
    [LinkID] INT IDENTITY(1,1) ,           
    
    [VendorCode] INT NULL,
	[ProductCode] INT NULL,
    
    [Active] CHAR(1) DEFAULT 'Y',
	[CreatedBy] INT NOT NULL,
    [CreatedDate] DATETIME,
	FOREIGN KEY ([VendorCode]) REFERENCES [Vendor]([Code]),
	FOREIGN KEY ([ProductCode]) REFERENCES [Product]([Code]),
    FOREIGN KEY ([CreatedBy]) REFERENCES [USER]([Code])
)

---------------
Go
---------------

CREATE PROC [dbo].[SpSavePurchase] (@UDT_Purchase UDT_Purchase READONLY, @TotPurAmount AS NUMERIC(12,2), @VendorBillRefNo INT, 
@VendorCode INT, @OldTranNo INT, @TranNo INT OUTPUT)  
AS  
  
BEGIN TRAN  

SET NOCOUNT ON;

BEGIN TRY  
  
	IF(@OldTranNo <= 0)
		SET @TranNo = (SELECT ISNULL(MAX([TranNo]), 0) + 1 AS BillNo FROM [Purchase])  
	ELSE
		SET @TranNo = @OldTranNo
  
	 INSERT INTO [Purchase]([TranNo], [TranDate], [ProductCode], [TotPurQty], [Unit], [TotPurAmount], [PurRatePerQty], [SellRatePerQty],  
	 [MRP], [SellingMarginPer], [DiscPer], [DiscRate], [EnteredBy], [EnteredDateTime], [VendorBillRefNo])  
	 SELECT @TranNo, CAST(GETDATE() AS DATE), [ProductCode], [TotPurQty], [Unit], [TotPurAmount], [PurRatePerQty], [SellRatePerQty],  
	 [MRP], [SellingMarginPer], [DiscPer], [DiscRate], [BilledBy], GETDATE(), @VendorBillRefNo
	 FROM @UDT_Purchase  
 
	 IF EXISTS(SELECT 1 FROM [PurchaseTransaction] WHERE [TranNo] =  @OldTranNo)
		DELETE FROM [PurchaseTransaction] WHERE [TranNo] = @OldTranNo
 
	 INSERT INTO [PurchaseTransaction]([TranNo], [TranDate], [TotPurAmount], [EnteredBy], [EnteredDateTime], [VendorBillRefNo])  
	 SELECT TOP 1 @TranNo, CAST(GETDATE() AS DATE), @TotPurAmount, [BilledBy], GETDATE(), @VendorBillRefNo 
	 FROM @UDT_Purchase  
  
	 UPDATE S SET S.LastPurQty = P.TotPurQty,   
	 S.[PurRate] = P.[PurRatePerQty],   
	 S.[MRP] = P.[MRP],   
	 S.[SellRate] = P.[SellRatePerQty],   
	 S.[SellingMarginPer] = P.[SellingMarginPer],   
	 S.[DiscPer] = P.[DiscPer],   
	 S.[DiscRate] = P.[DiscRate],   
	 S.[LastUpdatedBy] = P.[BilledBy],   
	 S.[LastUpdatedDate] = GETDATE(),   
	 S.[LastUpdatedDateTime] = GETDATE(),
	 S.[StockQty] = ISNULL(S.[StockQty], 0) + P.[TotPurQty]
	 FROM [Stock] AS S  
	 INNER JOIN @UDT_Purchase AS P ON S.ProductCode = P.ProductCode AND S.MRP = P.MRP
  
	 INSERT INTO [Stock](ProductCode, LastPurQty, PurRate, MRP, SellRate, SellingMarginPer, DiscPer, DiscRate,
	 LastUpdatedBy, LastUpdatedDate, LastUpdatedDateTime, [StockQty])
	 SELECT [ProductCode], [TotPurQty], [PurRatePerQty], [MRP], [SellRatePerQty], [SellingMarginPer], [DiscPer], [DiscRate],   
	 [BilledBy], GETDATE(), GETDATE(), [TotPurQty] 
	 FROM @UDT_Purchase AS P  
	 INNER JOIN [Product] AS PR ON P.[ProductCode] = PR.CODE  
	 WHERE 1=1 
	 AND ISNULL(PR.CalcBasedRateMast,'') != 'Y' 
	 AND NOT EXISTS (SELECT ProductCode FROM [Stock] AS S WHERE S.ProductCode = P.ProductCode And S.MRP = P.MRP)  
  
	 UPDATE R SET   
	 R.[BuyRate] = P.[PurRatePerQty],   
	 R.[SellMarginPercentage] = P.[SellingMarginPer],   
	 R.[SellRate] = P.[SellRatePerQty],   
	 R.[CreatedBy] = P.[BilledBy],   
	 R.[CreatedDateTime] = GETDATE(),
	 R.[MRP] = P.[MRP]
	 FROM [RateMaster] AS R  
	 INNER JOIN @UDT_Purchase AS P ON P.ProductCode = R.ProductCode  
  
	 INSERT INTO [RateMaster](ProductCode, BuyRate, SellMarginPercentage, SellRate, CreatedBy, CreatedDateTime, MRP)  
	 SELECT ProductCode, P.[PurRatePerQty], P.[SellingMarginPer], P.[SellRatePerQty], P.[BilledBy], GETDATE(), MRP 
	 FROM @UDT_Purchase AS P  
	 INNER JOIN [Product] AS PR ON P.[ProductCode] = PR.CODE  
	 WHERE ISNULL(PR.CalcBasedRateMast,'') = 'Y' AND NOT EXISTS (SELECT ProductCode FROM RateMaster AS R2 WHERE P.ProductCode = R2.ProductCode)  
 
	 INSERT INTO [VendorProductLink]([VendorCode], [ProductCode], [Active], [CreatedBy], [CreatedDate])
	 SELECT DISTINCT @VendorCode, [ProductCode], 'Y', [BilledBy], GETDATE() FROM @UDT_Purchase AS P WHERE
	 NOT EXISTS (SELECT 1 FROM [VendorProductLink] AS V WHERE V.[VendorCode] = @VendorCode AND P.[ProductCode] = V.[ProductCode])

	 UPDATE [VendorBillDetails] SET [PurchaseEntryStatus] = 'P' WHERE [TranNo] = @VendorBillRefNo AND [PurchaseEntryStatus] != 'P' --InProgress

 COMMIT TRAN  
  
END TRY  
BEGIN CATCH  
  
	IF @@TRANCOUNT > 0
		ROLLBACK TRAN;  -- Rollback only if an open transaction exists

	-- Rethrow the original error
	THROW;

END CATCH  

---------------

Go
---------------

UPDATE [Product] SET [AllowRateChange] = 'N'

UPDATE [RateMaster] SET [BuyRate] = ROUND([SellRate] - ([SellRate] * 10/100.00), 2), [MRP] = ROUND(SellRate + (SellRate * 10/100.00),0)

---------------
Go
---------------

ALTER PROC [dbo].[SpSaveProduct] (@Name VARCHAR(50), @TamilName NVARCHAR(50), @AlternativeName VARCHAR(50),   
@CatCode INT, @QtyTypeCode INT, @CalcBasedRateMast VARCHAR(1), @Active VARCHAR(50), @CreatedBy INT, @LastUpdatedBy INT, @BarCode VARCHAR(50),
@AllowRateChange VARCHAR(50), @BarCode2 VARCHAR(50), @BarCode3 VARCHAR(50), @BarCode4 VARCHAR(50))  
AS  
BEGIN
    SET NOCOUNT ON;
  
	DECLARE @Code INT  
	SET @Code = (SELECT ISNULL(MAX([Code]), 0) + 1 FROM [PRODUCT])  
  
	INSERT INTO PRODUCT([Code],[Name],[TamilName],[AlternativeName],[CatCode],[QtyTypeCode],[CalcBasedRateMast],  
	[Active],[CreatedBy],[CreatedDateTime],[LastUpdatedBy],[LastUpdatedDateTime],[BarCode],[AllowRateChange],[BarCode2],[BarCode3],[BarCode4])
	VALUES (@Code, @Name, @TamilName, @AlternativeName, @CatCode, @QtyTypeCode, @CalcBasedRateMast, 
	@Active, @CreatedBy, GETDATE(), @LastUpdatedBy, GETDATE(), @BarCode, @AllowRateChange, @BarCode2, @BarCode3, @BarCode4)  

END

---------------
Go
---------------

ALTER PROC [dbo].[SpUpdateProduct] (@Code INT, @Name VARCHAR(50), @TamilName NVARCHAR(50), @AlternativeName VARCHAR(50),   
@CatCode INT, @QtyTypeCode INT, @CalcBasedRateMast VARCHAR(1), @Active VARCHAR(50), @LastUpdatedBy INT, @BarCode VARCHAR(50),
@AllowRateChange VARCHAR(50), @BarCode2 VARCHAR(50), @BarCode3 VARCHAR(50), @BarCode4 VARCHAR(50))  
AS  
BEGIN
    SET NOCOUNT ON;
  
	UPDATE [Product] SET [Name]=@Name, [TamilName]=@TamilName, [AlternativeName]=@AlternativeName, [CatCode]=@CatCode, [QtyTypeCode]=@QtyTypeCode,  
	[CalcBasedRateMast]=@CalcBasedRateMast, [Active]=@Active, [LastUpdatedBy]=@LastUpdatedBy, [LastUpdatedDateTime]=GETDATE(), [BarCode]=@BarCode,
	[AllowRateChange]=@AllowRateChange, [BarCode2]=@BarCode2, [BarCode3]=@BarCode3, [BarCode4]=@BarCode4
	WHERE [Code] = @Code  

END

---------------
Go
---------------

ALTER PROC [dbo].[SpGetProduct]  
AS
BEGIN
    SET NOCOUNT ON; 

	SELECT P.SNo, P.Code, P.[Name], TamilName, AlternativeName, CatCode, C.[NAME] AS CatName, QtyTypeCode, Q.[NAME] AS QtyTypeName,   
	P.CalcBasedRateMast AS CalcBORMCode, (CASE WHEN P.[CalcBasedRateMast] = 'Y' THEN 'Yes' ELSE 'No' END) AS CalcBORM, 
	P.[AllowRateChange] AS AllowRateChangeCode, (CASE WHEN P.[AllowRateChange] = 'Y' THEN 'Yes' ELSE 'No' END) AS AllowRateChange, 
	P.Active AS ActiveStatusCode, (CASE WHEN P.Active = 'Y' THEN 'Yes' ELSE 'No' END) AS ActiveStatus,  P.CreatedBy, P.CreatedDateTime, 
	P.LastUpdatedBy, P.LastUpdatedDateTime, CAST(P.Code AS VARCHAR) AS PCodeString, P.[BarCode], P.[BarCode2], P.[BarCode3], P.[BarCode4]
	FROM [Product] AS P  
	LEFT JOIN [Category] AS C ON P.CatCode = C.Code  
	LEFT JOIN [Quantity] AS Q ON P.QtyTypeCode = Q.Code  
	LEFT JOIN [User] AS CU ON P.CreatedBy = CU.Code  
	LEFT JOIN [User] AS UU ON P.LastUpdatedBy = UU.Code  
	ORDER BY P.SNo ASC

END
---------------
Go
---------------

ALTER PROC [SpGetProductRate]      
AS
BEGIN
    SET NOCOUNT ON;
    
	SELECT CAST(P.[Code] AS VARCHAR) AS ProductCode, P.[Name] AS ProductName, P.[TamilName] AS ProductTName, P.[AlternativeName] AS ProductAltrName, P.[CatCode], P.[QtyTypeCode], P.[CalcBasedRateMast],      
	Q.ShortName AS Qty, CAST(P.[Code] AS VARCHAR) + ' - ' + P.[Name] + ' - ' + P.[TamilName] AS SearchName,     
	(CASE WHEN ISNULL(P.BarCode, '') = '' THEN 'B' + REPLICATE('0', 5 - LEN(RTRIM(CAST(P.[Code] AS VARCHAR)))) +  RTRIM(CAST(P.[Code] AS VARCHAR)) ELSE P.BarCode END ) AS BarCode,  
	
	R.[BuyRate] AS PurRate, R.[MRP], R.[SellRate], '0.00' SellingMarginPer, '0.00' DiscPer, '0.00' DiscRate, 

	CAST(ROUND((R.[SellRate] -  R.[BuyRate]), 2) AS NUMERIC(12,2)) AS ProfitAmt,
	CAST(ROUND((R.[SellRate] - R.[BuyRate]) * 0.50, 2) AS NUMERIC(12,2)) AS EmpProfitAmt,
	CAST(ROUND(R.[BuyRate] + ((R.[SellRate] - R.[BuyRate]) * 0.50), 2) AS NUMERIC(12,2)) AS EmpSellRate,
	CAST(ROUND((R.[SellRate] - R.[BuyRate]) * 0.75, 2) AS NUMERIC(12,2)) AS CustProfitAmt,
	CAST(ROUND(R.[BuyRate] + ((R.[SellRate] - R.[BuyRate]) * 0.75), 2) AS NUMERIC(12,2)) AS CustSellRate, 

	P.[AllowRateChange], ISNULL(P.[BarCode2], '') AS BarCode2, ISNULL(P.[BarCode3], '') AS BarCode3, ISNULL(P.[BarCode4], '') AS BarCode4
	FROM [Product] AS P      
	INNER JOIN [RateMaster] AS R ON P.Code = R.ProductCode      
	INNER JOIN [Quantity] AS Q ON P.QtyTypeCode = Q.Code      
	WHERE ISNULL(P.CalcBasedRateMast,'') = 'Y' And ISNULL(P.Active,'') = 'Y'      
     
	UNION      
      
	SELECT CAST(P.[Code] AS VARCHAR) AS ProductCode, P.[Name], P.[TamilName], P.[AlternativeName], P.[CatCode], P.[QtyTypeCode], P.[CalcBasedRateMast], Q.ShortName AS Qty,   
	CAST(P.[Code] AS VARCHAR) + ' - '   
	+ P.[Name]   
	--+ (CASE WHEN IsNull(P.BarCode, '') = '' THEN ' - ' + P.[TamilName] ELSE '' END)   
	+ ' - MRP: ' + CAST(S.[MRP] AS VARCHAR) AS SearchName,  
	(CASE WHEN ISNULL(P.BarCode, '') = '' THEN 'B' + REPLICATE('0', 5 - LEN(RTRIM(CAST(P.[Code] AS VARCHAR)))) +  RTRIM(CAST(P.[Code] AS VARCHAR)) ELSE P.BarCode END ) AS BarCode,    
	S.PurRate, S.MRP, S.SellRate, S.SellingMarginPer, S.DiscPer, S.DiscRate, 
	CAST(ROUND((S.SellRate -  S.PurRate), 2) AS NUMERIC(12,2)) AS ProfitAmt,
	CAST(ROUND((S.SellRate - S.PurRate) * 0.50, 2) AS NUMERIC(12,2)) AS EmpProfitAmt,
	CAST(ROUND(S.PurRate + ((S.SellRate - S.PurRate) * 0.50), 2) AS NUMERIC(12,2)) AS EmpSellRate,
	CAST(ROUND((S.SellRate - S.PurRate) * 0.75, 2) AS NUMERIC(12,2)) AS CustProfitAmt,
	CAST(ROUND(S.PurRate + ((S.SellRate - S.PurRate) * 0.75), 2) AS NUMERIC(12,2)) AS CustSellRate, 
	P.[AllowRateChange], ISNULL(P.[BarCode2], '') AS BarCode2, ISNULL(P.[BarCode3], '') AS BarCode3, ISNULL(P.[BarCode4], '') AS BarCode4
	FROM [Product] AS P    
	INNER JOIN [Stock] AS S On P.[Code] = S.ProductCode    
	INNER JOIN [Quantity] AS Q ON P.QtyTypeCode = Q.Code      
	WHERE ISNULL(P.CalcBasedRateMast,'') != 'Y' And ISNULL(P.Active,'') = 'Y'    
     
	UNION      
      
	SELECT CAST(P.[Code] AS VARCHAR) AS ProductCode, P.[Name], P.[TamilName], P.[AlternativeName], P.[CatCode], P.[QtyTypeCode], P.[CalcBasedRateMast],      
	Q.ShortName AS Qty, CAST(P.[Code] AS VARCHAR) + ' - ' + P.[Name]     
	+ (CASE WHEN ISNULL(P.BarCode, '') = '' THEN ' - ' + P.[TamilName] ELSE '' END) AS SearchName,      
	(CASE WHEN ISNULL(P.BarCode, '') = '' THEN 'B' + REPLICATE('0', 5 - LEN(RTRIM(CAST(P.[Code] AS VARCHAR)))) +  RTRIM(CAST(P.[Code] AS VARCHAR)) ELSE P.BarCode END ) AS BarCode,    
	'0.00' PurRate, '0.00' MRP, '0.00' SellRate, '0.00' SellingMarginPer, '0.00' DiscPer, '0.00' DiscRate, '0.00' AS ProfitAmt,
	'0.00' AS EmpProfitAmt, '0.00' AS EmpSellRate, '0.00' AS CustProfitAmt, '0.00' AS  CustSellRate, 
	P.[AllowRateChange], ISNULL(P.[BarCode2], '') AS BarCode2, ISNULL(P.[BarCode3], '') AS BarCode3, ISNULL(P.[BarCode4], '') AS BarCode4
	FROM [Product] AS P    
	INNER JOIN [Quantity] AS Q ON P.QtyTypeCode = Q.Code      
	WHERE ISNULL(P.CalcBasedRateMast,'') != 'Y' And ISNULL(P.Active,'') = 'Y'      
	And Not Exists ( SELECT S.ProductCode FROM [Stock] AS S WHERE P.[Code] = S.ProductCode )    
	ORDER BY P.[NAME]    
  
END  

---------------
Go
---------------

DROP PROC [SpSaveSale]
DROP TYPE [UDT_Sales]
DROP TYPE [UDT_Transaction]

CREATE TYPE [dbo].[UDT_Sales] AS TABLE(
	[ProductCode] [int] NOT NULL,
	[Qty] [numeric](12, 2) NOT NULL,
	[Unit] [varchar](5) NOT NULL,
	[SellRate] [numeric](12, 2) NOT NULL,
	[Amount] [numeric](12, 2) NOT NULL,
	[DiscPercent] [numeric](12, 2) NOT NULL,
	[DiscAmount] [numeric](12, 2) NOT NULL,
	[TotAmount] [numeric](12, 2) NOT NULL,
	[MRP] [numeric](12, 2) NULL,
	[TotDiscAmtFromMRP] [numeric](12, 2) NULL,
	[BilledBy] [int] NULL,
	[PurAmount] [numeric](12, 2) NULL,
	[ProfitAmount] [numeric](12, 2) NULL,
	[DiscCustCode] [int] NULL,
	[DiscEmpCode] [int] NULL,
	[IsDefective] [varchar](1) NULL,
	[BillStatus] [varchar](1) NULL
)

CREATE TYPE [dbo].[UDT_Transaction] AS TABLE(
	[TotAmount] [numeric](12, 2) NOT NULL,
	[DiscPercent] [numeric](12, 2) NOT NULL,
	[DiscAmount] [numeric](12, 2) NOT NULL,
	[GrossAmount] [numeric](12, 2) NOT NULL,
	[RoundOffAmount] [numeric](12, 2) NOT NULL,
	[NetAmount] [numeric](12, 2) NOT NULL,
	[PrintTotMRP] [numeric](12, 2) NULL,
	[PrintTotDiscMRP] [numeric](12, 2) NULL,
	[BilledBy] [int] NULL,
	[TotProfitAmount] [numeric](12, 2) NULL
)

ALTER TABLE [Sales] ADD [PurAmount] [numeric](12, 2) NULL
ALTER TABLE [Sales] ADD [ProfitAmount] [numeric](12, 2) NULL
ALTER TABLE [Sales] ADD [DiscCustCode] [int] NULL
ALTER TABLE [Sales] ADD [DiscEmpCode] [int] NULL
ALTER TABLE [Sales] ADD [IsDefective] [varchar](1) NULL

ALTER TABLE [SalesTransaction] ADD [TotProfitAmount] [numeric](12, 2) NULL

---------------
Go
---------------

CREATE PROC [dbo].[SpSaveSale] (@UDT_Sales UDT_Sales READONLY, @UDT_Transaction UDT_Transaction READONLY, 
					@UDT_PaymentDetails UDT_PaymentDetails READONLY, @BILLNO INT OUTPUT)    
AS    
BEGIN TRAN 

SET NOCOUNT ON;

BEGIN TRY    
    
  DECLARE @CNT AS INT    
    
  SET @CNT = (SELECT COUNT(*) AS CNT FROM [BillNoDetails] WHERE BilledDate = CAST(GETDATE() AS DATE))    
    
  IF @CNT <= 0    
   INSERT INTO [BillNoDetails]([BillNo], [BilledDate]) VALUES (101, CAST(GETDATE() AS DATE))    
  ELSE    
   UPDATE [BillNoDetails] SET [BillNo] = [BillNo] + 1 WHERE BilledDate = CAST(GETDATE() AS DATE)    
    
  SET @BILLNO = (SELECT BillNo FROM [BillNoDetails] WHERE BilledDate = CAST(GETDATE() AS DATE))    
    
  INSERT INTO [Sales]([BillNo],[BilledDate],[ProductCode],[Qty],[Unit],[SellRate],[Amount],    
  [DiscPercent],[DiscAmount],[TotAmount],[MRP],[TotDiscAmtFROMMRP],[BilledBy],[BilledDateTime],
  [PurAmount],[ProfitAmount],[DiscCustCode],[DiscEmpCode],[IsDefective])    
  SELECT @BILLNO,CAST(GETDATE() AS DATE),[ProductCode],[Qty],[Unit],[SellRate],[Amount],    
  [DiscPercent],[DiscAmount],[TotAmount],[MRP],[TotDiscAmtFROMMRP],[BilledBy],GETDATE(),
  [PurAmount],[ProfitAmount],[DiscCustCode],[DiscEmpCode],[IsDefective]
  FROM @UDT_Sales    
    
  INSERT INTO [SalesTransaction]([BillNo],[BilledDate],[TotAmount],[DiscPercent],[DiscAmount],[GrossAmount],[RoundOffAmount],[NetAmount],    
  [BilledBy],[BilledDateTime], [PrintTotMRP], [PrintTotDiscMRP], [TotProfitAmount])    
  SELECT @BILLNO, CAST(GETDATE() AS DATE), [TotAmount],[DiscPercent],[DiscAmount],[GrossAmount],[RoundOffAmount],[NetAmount],    
  [BilledBy], GETDATE(), [PrintTotMRP], [PrintTotDiscMRP], [TotProfitAmount] FROM @UDT_Transaction    
  
  INSERT INTO [PaymentDetails]([BillNo],[BilledDate],[PaymentType],[Amount],[BilledBy],[BilledDateTime])    
  SELECT @BILLNO, CAST(GETDATE() AS DATE), [PaymentType], [Amount], [BilledBy], GETDATE() FROM @UDT_PaymentDetails    
   
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
  
	IF @@TRANCOUNT > 0
		ROLLBACK TRAN;  -- Rollback only if an open transaction exists

	-- Rethrow the original error
	THROW;

END CATCH  

--------------  
GO
--------------  

ALTER PROCEDURE [dbo].[SpSaveRateMaster] (@UDT_RateMaster UDT_RateMaster READONLY)  
As  
BEGIN TRAN  
  
BEGIN TRY  
  
	 INSERT INTO RateMaster(ProductCode, BuyRate, SellMarginPercentage, SellRate, CreatedBy, CreatedDateTime, MRP)
	 SELECT ProductCode, BuyRate, SellMarginPercentage, SellRate, CreatedBy, GETDATE(), SellRate + 5 FROM @UDT_RateMaster AS R1  
	 WHERE NOT EXISTS (SELECT ProductCode FROM RateMaster AS R2 WHERE R1.ProductCode = R2.ProductCode)  
  
	 UPDATE R SET   
	 R.BuyRate = U.BuyRate,   
	 R.SellMarginPercentage = U.SellMarginPercentage,   
	 R.SellRate = U.SellRate,   
	 R.CreatedBy = U.CreatedBy,   
	 R.CreatedDateTime = GETDATE(),
	 R.MRP = U.SellRate + 5
	 FROM RateMaster AS R   
	 INNER JOIN @UDT_RateMaster AS U ON R.ProductCode = U.ProductCode  
  
COMMIT TRAN  
  
END TRY  
BEGIN CATCH

	ROLLBACK TRAN  
  
	-- Optional: Return error details
	THROW;
END CATCH  

--------------  
GO
--------------  

ALTER PROCEDURE SpGetRateMaster  
AS
BEGIN
    SET NOCOUNT ON;

	SELECT ProductCode, ProductName, ProductTamilName, CatCode, CatName, QtyTypeCode, QtyTypeName, Qty, BuyRate, SellMarginPercentage, MRP, SellRate,   
	ROW_NUMBER() OVER(ORDER BY CatCode, ProductCode) AS RateCode, CAST(ProductCode AS Varchar) AS PCodeString  
	FROM ( 
		SELECT P.[Code] AS ProductCode, P.[Name] AS ProductName, P.[TamilName] AS ProductTamilName, P.[CatCode],   
		C.[Name] AS CatName, P.[QtyTypeCode], Q.[Name] AS QtyTypeName, '1 ' + Q.[ShortName] AS Qty,   
		R.[BuyRate], R.[SellMarginPercentage], R.[MRP], R.[SellRate]  
		FROM [RateMaster] AS R   
		INNER JOIN [Product] AS P On R.[ProductCode] = P.[Code]  
		LEFT JOIN [Category] AS C On P.[CatCode] = C.[Code]  
		LEFT JOIN [Quantity] AS Q On Q.[Code] = P.[QtyTypeCode]  
		WHERE ISNULL(P.[CalcBasedRateMast], '') = 'Y' AND ISNULL(P.[Active], '') = 'Y'  
  
		UNION ALL  
  
		SELECT P.[Code] AS ProductCode, P.[Name] AS ProductName, P.[TamilName] AS ProductTamilName, P.[CatCode],   
		C.[Name] AS CatName, P.[QtyTypeCode], Q.[Name] AS QtyTypeName, '1 ' + Q.[ShortName] AS Qty,   
		CAST(0.00 AS NUMERIC(12, 2)) AS BuyRate, CAST(0.00 AS NUMERIC(12, 2)) AS SellMarginPercentage, CAST(0.00 AS NUMERIC(12, 2)) AS MRP,
		CAST(0.00 AS NUMERIC(12, 2)) AS SellRate  
		From [Product] AS P  
		LEFT JOIN [Category] AS C On P.[CatCode] = C.[Code]  
		LEFT JOIN [Quantity] AS Q On Q.[Code] = P.[QtyTypeCode]  
		WHERE ISNULL(P.[CalcBasedRateMast], '') = 'Y' AND ISNULL(P.[Active], '') = 'Y'  
		AND NOT EXISTS (SELECT [ProductCode] FROM [RateMaster] AS R WHERE R.[ProductCode] = P.[Code])
	) AS RateMasterData
END

--------------  
GO
--------------  

CREATE PROCEDURE SpGetTodayBillsWithPayments
AS
BEGIN
    SET NOCOUNT ON;

	SELECT P.[BillNo], 
	STRING_AGG(CASE WHEN PT.[Name] = 'ON CREDIT' THEN 'Credit' WHEN PT.[Name] = 'GPay/Phone Pay' THEN 'GPay' ELSE PT.[Name] END
	+ ' = ' + CAST(CAST(P.[Amount] AS DECIMAL(12,2)) AS VARCHAR(20)), ', ') AS Payments
	FROM [dbo].[PaymentDetails] AS P
	INNER JOIN [dbo].[PaymentType] AS PT 
	ON P.[PaymentType] = PT.[Code]
	WHERE P.[BilledDate] = CAST(GETDATE() AS DATE) AND ISNULL(P.[BillStatus], '') != 'C'
	GROUP BY P.[BillNo]
	ORDER BY P.[BillNo] DESC
END

--------------  
GO
--------------  

CREATE PROCEDURE SpGetBillInfo(@BillNo INT)
AS
BEGIN
    SET NOCOUNT ON;

	SELECT CAST(ROW_NUMBER() OVER (ORDER BY S.[SNo] ASC) AS INT) AS SNo, [ProductCode] AS PCode, P.[TamilName] AS [Product-TamilName], S.[MRP], 
	--S.[Qty], 
	CASE 
        WHEN S.[Unit] = 'Pcs' 
            THEN FORMAT(S.[Qty], '0')        -- no decimals
        ELSE 
            FORMAT(S.[Qty], '0.00')         -- 2 decimals
    END AS Qty,
	S.[Unit], S.[SellRate] AS Rate, S.[Amount] Amt, '0.00' AS DiscPerFromSellRate,
	S.[DiscAmount] AS DiscAmount, S.[TotDiscAmtFromMRP], S.[TotAmount] AS TotalAmount, 
	(CASE WHEN ISNULL(P.[CalcBasedRateMast], 'N') = 'N' THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END) AS CalBORM, 
	CAST((S.[Qty] * S.[MRP]) AS NUMERIC(12,2)) AS TotMRP, 
	S.[PurAmount] AS PurAmt, S.[ProfitAmount] AS ProfitAmt, S.[DiscEmpCode], S.[DiscCustCode], S.[IsDefective], 
	(CASE WHEN ISNULL(P.[AllowRateChange], 'N') = 'N' THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END) AS AllowRateChange, 
	CAST(0 AS BIT) AS SellingRateZero, P.[CatCode] AS CatCode, 'F' AS BillStatus --F -> Fetch
	FROM [dbo].[Sales] AS S
	LEFT JOIN  [dbo].[PRODUCT] AS P ON P.[CODE] = S.[ProductCode]
	WHERE 1=1 AND S.[BillNo] = @BillNo AND S.[BilledDate] = CAST(GETDATE() AS DATE) AND ISNULL(S.[BillStatus], '') NOT IN ('D', 'C')
	ORDER BY S.[SNo] ASC

END

--------------  
GO
--------------  

CREATE TABLE [dbo].[Sales_Log](
	[SNo] [int] IDENTITY(1,1) NOT NULL,
	[BillNo] [int] NULL,
	[BilledDate] [date] NULL,
	[ProductCode] [int] NOT NULL,
	[Qty] [numeric](12, 2) NOT NULL,
	[Unit] [varchar](5) NOT NULL,
	[SellRate] [numeric](12, 2) NOT NULL,
	[Amount] [numeric](12, 2) NOT NULL,
	[DiscPercent] [numeric](12, 2) NOT NULL,
	[DiscAmount] [numeric](12, 2) NOT NULL,
	[TotAmount] [numeric](12, 2) NOT NULL,
	[BilledBy] [int] NULL,
	[BilledDateTime] [datetime] NULL,
	[BillStatus] [varchar](1) NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL,
	[MRP] [numeric](12, 2) NULL,
	[TotDiscAmtFromMRP] [numeric](12, 2) NULL,
	[PurAmount] [numeric](12, 2) NULL,
	[ProfitAmount] [numeric](12, 2) NULL,
	[DiscCustCode] [int] NULL,
	[DiscEmpCode] [int] NULL,
	[IsDefective] [varchar](1) NULL
)


CREATE TABLE [dbo].[SalesTransaction_Log](
	[SNo] [int] IDENTITY(1,1) NOT NULL,
	[BillNo] [int] NULL,
	[BilledDate] [date] NULL,
	[TotAmount] [numeric](12, 2) NOT NULL,
	[DiscPercent] [numeric](12, 2) NOT NULL,
	[DiscAmount] [numeric](12, 2) NOT NULL,
	[GrossAmount] [numeric](12, 2) NOT NULL,
	[RoundOffAmount] [numeric](12, 2) NOT NULL,
	[NetAmount] [numeric](12, 2) NOT NULL,
	[BilledBy] [int] NULL,
	[BilledDateTime] [datetime] NULL,
	[BillStatus] [varchar](1) NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL,
	[PrintTotMRP] [numeric](12, 2) NULL,
	[PrintTotDiscMRP] [numeric](12, 2) NULL,
	[TotProfitAmount] [numeric](12, 2) NULL
)

CREATE TABLE [dbo].[PaymentDetails_Log](
	[SNo] [int] IDENTITY(1,1) NOT NULL,
	[BillNo] [int] NULL,
	[BilledDate] [date] NULL,
	[PaymentType] [varchar](10) NULL,
	[Amount] [numeric](12, 2) NOT NULL,
	[BilledBy] [int] NULL,
	[BilledDateTime] [datetime] NULL,
	[BillStatus] [varchar](1) NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL
)

CREATE TABLE [dbo].[CustomerCreditDebitNote_Log](
	[SNo] [int] IDENTITY(1,1) NOT NULL,
	[TranNo] [int] NOT NULL,
	[TranDate] [date] NOT NULL,
	[CustomerCode] [int] NOT NULL,
	[TransType] [char](1) NOT NULL,
	[BillNo] [int] NULL,
	[BillDate] [date] NOT NULL,
	[Amount] [numeric](12, 2) NOT NULL,
	[PaymentType] [varchar](1) NOT NULL,
	[Remarks] [varchar](100) NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL
) 

--------------  
GO
--------------  

CREATE TRIGGER [dbo].[TRG_CustomerCreditDebitNote_Delete]
ON [dbo].[CustomerCreditDebitNote]
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO [dbo].[CustomerCreditDebitNote_Log]([TranNo], [TranDate], [CustomerCode], [TransType],
    [BillNo], [BillDate], [Amount], [PaymentType], [Remarks], [UpdatedBy], [UpdatedDate])
    SELECT D.[TranNo], D.[TranDate], D.[CustomerCode], D.[TransType], 
	D.[BillNo], D.[BillDate], D.[Amount], D.[PaymentType], D.[Remarks], D.[UpdatedBy], D.[UpdatedDate]
	FROM DELETED D;

END

--------------  
GO
--------------  

CREATE PROC [dbo].[SpUpdateSale] (@UDT_Sales UDT_Sales READONLY, @UDT_Transaction UDT_Transaction READONLY, 
	@UDT_PaymentDetails UDT_PaymentDetails READONLY, @BILLNO INT)
AS    
BEGIN TRAN    
    
BEGIN TRY    

	--LOG START

	INSERT INTO [dbo].[Sales_Log]([BillNo], [BilledDate], [ProductCode], [Qty], [Unit], [SellRate], [Amount],
	[DiscPercent], [DiscAmount], [TotAmount], [BilledBy], [BilledDateTime], [BillStatus], [UpdatedBy],
	[UpdatedDateTime], [MRP], [TotDiscAmtFromMRP], [PurAmount], [ProfitAmount], [DiscCustCode],[DiscEmpCode], [IsDefective])
	SELECT [BillNo], [BilledDate], S.[ProductCode], S.[Qty], S.[Unit], S.[SellRate], S.[Amount],
	S.[DiscPercent], S.[DiscAmount], S.[TotAmount], S.[BilledBy], S.[BilledDateTime], S.[BillStatus], S.[UpdatedBy],
	S.[UpdatedDateTime], S.[MRP], S.[TotDiscAmtFromMRP], S.[PurAmount], S.[ProfitAmount], S.[DiscCustCode], S.[DiscEmpCode], S.[IsDefective]
	FROM [Sales] AS S
	INNER JOIN @UDT_Sales U ON S.[BillNo] = @BillNo AND S.[BilledDate] = CAST(GETDATE() AS DATE) 
	AND S.[ProductCode] = U.[ProductCode] AND S.[MRP] = U.[MRP]
	WHERE ISNULL(U.BillStatus, '') != 'F'

	INSERT INTO [dbo].[SalesTransaction_Log]([BillNo], [BilledDate], [TotAmount], [DiscPercent], [DiscAmount], [GrossAmount], 
	[RoundOffAmount], [NetAmount], 	[BilledBy], [BilledDateTime], [BillStatus], [UpdatedBy], [UpdatedDateTime], 
	[PrintTotMRP], [PrintTotDiscMRP], [TotProfitAmount])
	SELECT S.[BillNo], S.[BilledDate], S.[TotAmount], S.[DiscPercent], S.[DiscAmount], S.[GrossAmount], 
	S.[RoundOffAmount], S.[NetAmount], S.[BilledBy], S.[BilledDateTime], S.[BillStatus], S.[UpdatedBy], S.[UpdatedDateTime], 
	S.[PrintTotMRP], S.[PrintTotDiscMRP], S.[TotProfitAmount]
	FROM [SalesTransaction] S
	INNER JOIN @UDT_Transaction U ON S.[BillNo] = @BillNo AND S.[BilledDate] = CAST(GETDATE() AS DATE)

	INSERT INTO [dbo].[PaymentDetails_Log]([BillNo], [BilledDate], [PaymentType], [Amount], [BilledBy], [BilledDateTime], 
	[BillStatus], [UpdatedBy], [UpdatedDateTime])
	SELECT P.[BillNo], P.[BilledDate], P.[PaymentType], P.[Amount], P.[BilledBy], P.[BilledDateTime], 
	P.[BillStatus], P.[UpdatedBy], P.[UpdatedDateTime]
	FROM [PaymentDetails] P
	INNER JOIN @UDT_PaymentDetails U ON P.[BillNo] = @BillNo
	AND P.[BilledDate]  = CAST(GETDATE() AS DATE)

	--LOG END

	DECLARE @UpdatedBy INT
	SET @UpdatedBy = (SELECT TOP 1 [BilledBy] FROM @UDT_Sales)

	INSERT INTO [Sales]([BillNo], [BilledDate], [ProductCode], [Qty], [Unit], [SellRate], [Amount],    
	[DiscPercent], [DiscAmount], [TotAmount], [MRP], [TotDiscAmtFROMMRP], [BilledBy], [BilledDateTime],
	[PurAmount], [ProfitAmount], [DiscCustCode], [DiscEmpCode], [IsDefective])
	SELECT @BILLNO, CAST(GETDATE() AS DATE), [ProductCode], [Qty], [Unit], [SellRate], [Amount],    
	[DiscPercent], [DiscAmount], [TotAmount], [MRP], [TotDiscAmtFROMMRP], [BilledBy], GETDATE(),
	[PurAmount], [ProfitAmount], [DiscCustCode], [DiscEmpCode], [IsDefective]
	FROM @UDT_Sales AS U 
	WHERE ISNULL(U.BillStatus, '') != 'F' AND NOT EXISTS (SELECT 1 FROM [Sales] AS S WHERE [BillNo] = @BILLNO 
	AND S.[BilledDate] = CAST(GETDATE() AS DATE) AND S.[ProductCode] = U.[ProductCode] AND S.[MRP] = U.[MRP])

	UPDATE S SET S.[Qty] = U.[Qty], S.[Unit] = U.[Unit], S.[SellRate] = U.[SellRate], S.[Amount] = U.[Amount], S.[DiscPercent] = U.[DiscPercent],
	S.[DiscAmount] = U.[DiscAmount], S.[TotAmount] = U.[TotAmount], S.[MRP] = U.[MRP], S.[TotDiscAmtFROMMRP] = U.[TotDiscAmtFROMMRP],
	S.[PurAmount] = U.[PurAmount], S.[ProfitAmount] = U.[ProfitAmount],
	S.[DiscCustCode] = U.[DiscCustCode], S.[DiscEmpCode] = U.[DiscEmpCode], S.[IsDefective] = U.[IsDefective], 
	S.[BillStatus] = U.[BillStatus], S.[UpdatedBy] = U.[BilledBy], S.[UpdatedDateTime] = GETDATE() 
	FROM [Sales] S
	INNER JOIN @UDT_Sales U ON S.[BillNo] = @BillNo AND S.[BilledDate] = CAST(GETDATE() AS DATE) 
	AND S.[ProductCode] = U.[ProductCode] AND S.[MRP] = U.[MRP]
	WHERE ISNULL(U.BillStatus, '') != 'F'

	UPDATE S SET S.[BillStatus] = 'D', S.[UpdatedBy] = @UpdatedBy,  S.[UpdatedDateTime] = GETDATE()
	FROM [Sales] S
	WHERE S.[BillNo] = @BillNo
	AND S.[BilledDate] = CAST(GETDATE() AS DATE)
	AND NOT EXISTS (SELECT 1 FROM @UDT_Sales U WHERE U.[ProductCode] = S.[ProductCode] AND S.[MRP] = U.[MRP])

	UPDATE S SET S.[TotAmount] = U.[TotAmount], S.[DiscPercent] = U.[DiscPercent], S.[DiscAmount] = U.[DiscAmount], S.[GrossAmount] = U.[GrossAmount],
    S.[RoundOffAmount] = U.[RoundOffAmount], S.[NetAmount] = U.[NetAmount],
    S.[PrintTotMRP] = U.[PrintTotMRP], S.[PrintTotDiscMRP] = U.[PrintTotDiscMRP], S.[TotProfitAmount] = U.[TotProfitAmount],
	S.[UpdatedBy] = U.[BilledBy], S.[UpdatedDateTime] = GETDATE()
	FROM [SalesTransaction] S
	INNER JOIN @UDT_Transaction U ON S.[BillNo] = @BillNo AND S.[BilledDate] = CAST(GETDATE() AS DATE)
 
	DELETE T FROM [PaymentDetails] T 
	WHERE T.[BillNo] = @BillNo AND T.[BilledDate] = CAST(GETDATE() AS DATE) 
	AND NOT EXISTS (SELECT 1 FROM @UDT_PaymentDetails U WHERE U.[PaymentType] = T.[PaymentType])
	
	UPDATE P SET P.[Amount] = U.[Amount], P.[UpdatedBy] = U.[BilledBy], P.[UpdatedDateTime] = GETDATE() 
	FROM [PaymentDetails] P
	INNER JOIN @UDT_PaymentDetails U ON P.[BillNo] = @BillNo
	AND P.[BilledDate]  = CAST(GETDATE() AS DATE)
	AND P.[PaymentType] = U.[PaymentType]

	INSERT INTO [PaymentDetails]([BillNo], [BilledDate], [PaymentType], [Amount], [BilledBy], [BilledDateTime])
	SELECT @BillNo, CAST(GETDATE() AS DATE), U.[PaymentType], U.[Amount], U.[BilledBy], GETDATE() FROM @UDT_PaymentDetails U
	WHERE NOT EXISTS ( SELECT 1 FROM [PaymentDetails] P WHERE P.[BillNo] = @BillNo AND P.[BilledDate] = CAST(GETDATE() AS DATE) 
	AND P.[PaymentType] = U.[PaymentType])
	
	-- Check if old Credit record exists for this Bill
	DECLARE @OldTranNo INT;
	SELECT @OldTranNo = TranNo
	FROM [CustomerCreditDebitNote] WHERE [BillNo] = @BillNo	AND [BillDate] = CAST(GETDATE() AS DATE)
	AND TransType = 'D' AND Remarks = 'RECORD FROM POS'

	-- CASE 1: Update existing Credit record if still present in UDT
	IF EXISTS (SELECT 1 FROM @UDT_PaymentDetails WHERE [PaymentType] = 'T')
	BEGIN
		IF @OldTranNo IS NOT NULL
		BEGIN
			-- UPDATE and keep old TranNo
			UPDATE [CustomerCreditDebitNote]
			SET [CustomerCode] = U.[CustomerCode], [Amount] = U.[Amount], [PaymentType] = U.[PaymentType],
			[UpdatedBy] = U.[BilledBy], [UpdatedDate] = GETDATE() 
			FROM [CustomerCreditDebitNote] C
			INNER JOIN @UDT_PaymentDetails U ON U.[PaymentType] = 'T'
			WHERE C.TranNo = @OldTranNo
		END
		ELSE
		BEGIN
			-- INSERT new if not exists
			DECLARE @NewTranNo INT = (SELECT ISNULL(MAX([TranNo]),0)+1 FROM [CustomerCreditDebitNote]);

			INSERT INTO [CustomerCreditDebitNote] 
				   ([TranNo], [TranDate], [CustomerCode], [TransType], [BillNo], [BillDate], 
					[Amount], [PaymentType], [Remarks], [UpdatedBy], [UpdatedDate])  
			SELECT @NewTranNo, GETDATE(), [CustomerCode], 'D', @BillNo, CAST(GETDATE() AS DATE),
				   [Amount], [PaymentType], 'RECORD FROM POS', [BilledBy], GETDATE()
			FROM @UDT_PaymentDetails 
			WHERE [PaymentType] = 'T'
		END
	END
	ELSE
	BEGIN
		-- CASE 2: Delete old Credit entry if UDT has no T
		IF @OldTranNo IS NOT NULL
		BEGIN
			DELETE FROM [CustomerCreditDebitNote] WHERE TranNo = @OldTranNo;
		END
	END

 COMMIT TRAN    
    
END TRY    
BEGIN CATCH    
    
 ROLLBACK TRAN
 	-- Optional: Return error details
	THROW;
END CATCH

--------------  
GO
--------------  

ALTER PROC [dbo].[SpGetPrintData](@BillNo INT, @BilledDate DATE)
AS
BEGIN
    SELECT 
        CAST(ROW_NUMBER() OVER (ORDER BY S.[SNo]) AS VARCHAR) AS [SNo],
        CAST(S.[BillNo] AS VARCHAR) AS BillNo,
        FORMAT(S.[BilledDateTime], 'dd-MMM-yyyy hh:mm tt') AS [BilledDateTime],

        CASE 
            WHEN ISNULL(P.TamilName, '') <> '' THEN P.TamilName 
            ELSE P.[Name] 
        END AS Item,

        CAST([Qty] AS VARCHAR) + Unit AS [Qty],
        CAST([SellRate] AS VARCHAR) AS SellRate,
        CAST(S.[TotAmount] AS VARCHAR) AS [Amount],
        CAST(T.[TotAmount] AS VARCHAR) AS [TotAmount],
        CAST(T.[DiscPercent] AS VARCHAR) AS [DiscPercent],
        CAST(T.[DiscAmount] AS VARCHAR) AS [DiscAmount],
        CAST(T.[GrossAmount] AS VARCHAR) AS [GrossAmount],
        CAST(T.[RoundOffAmount] AS VARCHAR) AS [RoundOffAmount],
        CAST(T.[NetAmount] AS VARCHAR) AS [NetAmount],
        CAST(S.[MRP] AS VARCHAR) AS [MRP],
        CAST(S.[TotDiscAmtFromMRP] AS VARCHAR) AS [TotDiscAmtFromMRP],
        CAST(T.[PrintTotMRP] AS VARCHAR) AS [PrintTotMRP],
        CAST(T.[PrintTotDiscMRP] AS VARCHAR) AS [PrintTotDiscMRP]
    FROM [Sales] AS S
    LEFT JOIN [Product] AS P ON P.Code = S.ProductCode
    INNER JOIN [SalesTransaction] AS T ON T.BillNo = S.BillNo AND T.BilledDate = S.BilledDate
    WHERE S.BillNo = @BillNo  
      AND S.BilledDate = @BilledDate  
      AND ISNULL(S.BillStatus, '') NOT IN ('C', 'D')
      AND ISNULL(T.BillStatus, '') != 'C';
END

--------------  
GO
--------------  

CREATE PROC [dbo].[SpSalesBillCancel] (@BillNo INT, @BilledDate DATE)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRAN;

        -- Cancel Sales
        UPDATE [Sales] SET [BillStatus] = 'C' WHERE [BillNo] = @BillNo AND [BilledDate] = @BilledDate;

        -- Cancel Sales Transaction
        UPDATE [SalesTransaction] SET [BillStatus] = 'C' WHERE [BillNo] = @BillNo AND [BilledDate] = @BilledDate;

        -- Cancel Payments
        UPDATE [PaymentDetails] SET [BillStatus] = 'C' WHERE [BillNo] = @BillNo AND [BilledDate] = @BilledDate;

        -- Delete Credit/Debit Notes
        DELETE FROM [CustomerCreditDebitNote]  WHERE [BillNo] = @BillNo AND [BillDate] = @BilledDate AND [Remarks] = 'RECORD FROM POS';

        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN;

        -- Re-throw error
        THROW;
    END CATCH
END

--------------  
GO
--------------  

CREATE TABLE [dbo].[POS](
	[SNo] [int] IDENTITY(1,1) NOT NULL,
	[BillNo] [int] NULL,
	[BilledDate] [date] NULL,
	[ProductCode] [int] NOT NULL,
	[Qty] [numeric](12, 2) NOT NULL,
	[Unit] [varchar](5) NOT NULL,
	[SellRate] [numeric](12, 2) NOT NULL,
	[Amount] [numeric](12, 2) NOT NULL,
	[DiscPercent] [numeric](12, 2) NOT NULL,
	[DiscAmount] [numeric](12, 2) NOT NULL,
	[TotAmount] [numeric](12, 2) NOT NULL,
	[BilledBy] [int] NULL,
	[BilledDateTime] [datetime] NULL,
	[BillStatus] [varchar](1) NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL,
	[MRP] [numeric](12, 2) NULL,
	[TotDiscAmtFromMRP] [numeric](12, 2) NULL,
	[PurAmount] [numeric](12, 2) NULL,
	[ProfitAmount] [numeric](12, 2) NULL,
	[DiscCustCode] [int] NULL,
	[DiscEmpCode] [int] NULL,
	[IsDefective] [varchar](1) NULL,
	[PosId] [varchar](4) NULL
)

CREATE TABLE [dbo].[POSNetAmount](
	[SNo] [int] IDENTITY(1,1) NOT NULL,
	[BillNo] [int] NULL,
	[BilledDate] [date] NULL,
	[NetAmount] [numeric](12, 2) NOT NULL,	
	[PosId] [varchar](4) NULL
)

--------------  
GO
--------------  

CREATE PROC [dbo].[SpSavePos] (@UDT_Sales UDT_Sales READONLY, @PosId VARCHAR(4))      
AS      
BEGIN TRAN   
  
SET NOCOUNT ON;  
  
BEGIN TRY      
  
  DELETE FROM [POS] WHERE [BilledDate] = CAST(GETDATE() AS DATE) AND [PosId] = @PosId

  INSERT INTO [POS]([BillNo],[BilledDate],[ProductCode],[Qty],[Unit],[SellRate],[Amount],      
  [DiscPercent],[DiscAmount],[TotAmount],[MRP],[TotDiscAmtFROMMRP],[BilledBy],[BilledDateTime],  
  [PurAmount],[ProfitAmount],[DiscCustCode],[DiscEmpCode],[IsDefective],[BillStatus],[PosId])
  SELECT RIGHT(@POSID, 1),CAST(GETDATE() AS DATE),[ProductCode],[Qty],[Unit],[SellRate],[Amount],      
  [DiscPercent],[DiscAmount],[TotAmount],[MRP],[TotDiscAmtFROMMRP],[BilledBy],GETDATE(),  
  [PurAmount],[ProfitAmount],[DiscCustCode],[DiscEmpCode],[IsDefective],[BillStatus], @PosId
  FROM @UDT_Sales      

 COMMIT TRAN      
      
END TRY      
BEGIN CATCH      
    
 IF @@TRANCOUNT > 0  
  ROLLBACK TRAN;  -- Rollback only if an open transaction exists  

 -- Rethrow the original error  
 THROW;  
  
END CATCH 

--------------  
GO
--------------  

CREATE PROCEDURE SpGetPos(@PosId VARCHAR(4))
AS
BEGIN
    SET NOCOUNT ON;

	SELECT CAST(ROW_NUMBER() OVER (ORDER BY S.[SNo] ASC) AS INT) AS SNo, [ProductCode] AS PCode, P.[TamilName] AS [Product-TamilName], S.[MRP], 
	--S.[Qty], 
	CASE 
        WHEN S.[Unit] = 'Pcs' 
            THEN FORMAT(S.[Qty], '0')        -- no decimals
        ELSE 
            FORMAT(S.[Qty], '0.00')         -- 2 decimals
    END AS Qty,
	S.[Unit], S.[SellRate] AS Rate, S.[Amount] Amt, '0.00' AS DiscPerFromSellRate,
	S.[DiscAmount] AS DiscAmount, S.[TotDiscAmtFromMRP], S.[TotAmount] AS TotalAmount, 
	(CASE WHEN ISNULL(P.[CalcBasedRateMast], 'N') = 'N' THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END) AS CalBORM, 
	CAST((S.[Qty] * S.[MRP]) AS NUMERIC(12,2)) AS TotMRP, 
	S.[PurAmount] AS PurAmt, S.[ProfitAmount] AS ProfitAmt, S.[DiscEmpCode], S.[DiscCustCode], S.[IsDefective], 
	(CASE WHEN ISNULL(P.[AllowRateChange], 'N') = 'N' THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END) AS AllowRateChange, 
	CAST(0 AS BIT) AS SellingRateZero, P.[CatCode] AS CatCode, [BillStatus]
	FROM [dbo].[POS] AS S
	LEFT JOIN  [dbo].[PRODUCT] AS P ON P.[CODE] = S.[ProductCode]
	WHERE 1=1 
	AND S.[BilledDate] = CAST(GETDATE() AS DATE) 
	AND S.[PosId] = @PosId
	ORDER BY S.[SNo] ASC

END

--------------  
GO
--------------  

CREATE PROCEDURE SpGetPosAmount
AS
BEGIN
    SET NOCOUNT ON;

	SELECT PosId, ROUND(SUM(TotAmount), 0) AS NetAmount 
	FROM POS
	WHERE 1=1 
	AND [BilledDate] = CAST(GETDATE() AS DATE) 
	GROUP BY PosId
	ORDER BY PosId
END

--------------  
GO
--------------  

WITH CTE AS (
    SELECT 
        SNo,
        TamilName,
        BarCode,
        ROW_NUMBER() OVER (PARTITION BY TamilName ORDER BY SNo) AS rn
    FROM dbo.Product
    WHERE CalcBasedRateMast = 'N'
)
UPDATE p
SET p.BarCode2 = c2.BarCode,
    p.BarCode3 = c3.BarCode,
    p.BarCode4 = c4.BarCode
FROM dbo.Product p
JOIN CTE c1 ON p.SNo = c1.SNo AND c1.rn = 1
LEFT JOIN CTE c2 ON c2.TamilName = c1.TamilName AND c2.rn = 2
LEFT JOIN CTE c3 ON c3.TamilName = c1.TamilName AND c3.rn = 3
LEFT JOIN CTE c4 ON c4.TamilName = c1.TamilName AND c4.rn = 4;

--------------  
GO
--------------  

WITH CTE AS (
    SELECT 
        SNo,
        ROW_NUMBER() OVER (PARTITION BY TamilName ORDER BY SNo) AS rn
    FROM dbo.Product
    WHERE CalcBasedRateMast = 'N'
)
UPDATE p
SET p.Active = 'N'
FROM dbo.Product p
JOIN CTE c ON p.SNo = c.SNo
WHERE c.rn > 1