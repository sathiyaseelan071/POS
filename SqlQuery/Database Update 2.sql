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

-- Update Category
UPDATE [dbo].[Category]
SET Code = CASE 
              WHEN Code = 9 THEN 3
              WHEN Code = 3 THEN 9
              WHEN Code = 10 THEN 5
              WHEN Code = 5 THEN 10
              ELSE Code
           END
WHERE Code IN (3, 5, 9, 10);

-- Update Product (CatCode column)
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
	 SELECT @TranNo, CAST(GETDATE() AS DATE ), [ProductCode], [TotPurQty], [Unit], [TotPurAmount], [PurRatePerQty], [SellRatePerQty],  
	 [MRP], [SellingMarginPer], [DiscPer], [DiscRate], [BilledBy], GETDATE(), @VendorBillRefNo
	 FROM @UDT_Purchase  
 
	 IF EXISTS(SELECT 1 FROM [PurchaseTransaction] WHERE [TranNo] =  @OldTranNo)
		DELETE FROM [PurchaseTransaction] WHERE [TranNo] = @OldTranNo
 
	 INSERT INTO [PurchaseTransaction]([TranNo], [TranDate], [TotPurAmount], [EnteredBy], [EnteredDateTime], [VendorBillRefNo])  
	 SELECT TOP 1 @TranNo, CAST(GETDATE() AS DATE ), @TotPurAmount, [BilledBy], GETDATE(), @VendorBillRefNo 
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
	 R.BuyRate = P.[PurRatePerQty],   
	 R.SellMarginPercentage = P.[SellingMarginPer],   
	 R.SellRate = P.[SellRatePerQty],   
	 R.CreatedBy = P.[BilledBy],   
	 R.CreatedDateTime = GETDATE(),
	 R.MRP = P.MRP
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
  
DECLARE @Code INT  
SET @Code = (SELECT ISNULL(MAX([Code]), 0) + 1 FROM [PRODUCT])  
  
INSERT INTO PRODUCT([Code],[Name],[TamilName],[AlternativeName],[CatCode],[QtyTypeCode],[CalcBasedRateMast],  
[Active],[CreatedBy],[CreatedDateTime],[LastUpdatedBy],[LastUpdatedDateTime],[BarCode],[AllowRateChange],[BarCode2],[BarCode3],[BarCode4])
VALUES (@Code, @Name, @TamilName, @AlternativeName, @CatCode, @QtyTypeCode, @CalcBasedRateMast, 
@Active, @CreatedBy, GETDATE(), @LastUpdatedBy, GETDATE(), @BarCode, @AllowRateChange, @BarCode2, @BarCode3, @BarCode4)  

---------------
Go
---------------

ALTER PROC [dbo].[SpUpdateProduct] (@Code INT, @Name VARCHAR(50), @TamilName NVARCHAR(50), @AlternativeName VARCHAR(50),   
@CatCode INT, @QtyTypeCode INT, @CalcBasedRateMast VARCHAR(1), @Active VARCHAR(50), @LastUpdatedBy INT, @BarCode VARCHAR(50),
@AllowRateChange VARCHAR(50), @BarCode2 VARCHAR(50), @BarCode3 VARCHAR(50), @BarCode4 VARCHAR(50))  
AS  
UPDATE [Product] SET [Name]=@Name, [TamilName]=@TamilName, [AlternativeName]=@AlternativeName, [CatCode]=@CatCode, [QtyTypeCode]=@QtyTypeCode,  
[CalcBasedRateMast]=@CalcBasedRateMast, [Active]=@Active, [LastUpdatedBy]=@LastUpdatedBy, [LastUpdatedDateTime]=GETDATE(), [BarCode]=@BarCode,
[AllowRateChange]=@AllowRateChange, [BarCode2]=@BarCode2, [BarCode3]=@BarCode3, [BarCode4]=@BarCode4
WHERE [Code] = @Code  

---------------
Go
---------------

ALTER PROC [dbo].[SpGetProduct]  
AS  
SELECT P.SNo, P.Code, P.[Name], TamilName, AlternativeName, CatCode, C.[NAME] AS CatName, QtyTypeCode, Q.[NAME] AS QtyTypeName,   
P.CalcBasedRateMast AS CalcBORMCode, (CASE WHEN P.[CalcBasedRateMast] = 'Y' THEN 'Yes' ELSE 'No' END) AS CalcBORM, 
P.[AllowRateChange] AS AllowRateChangeCode, (CASE WHEN P.[AllowRateChange] = 'Y' THEN 'Yes' ELSE 'No' END) AS AllowRateChange, 
P.Active AS ActiveStatusCode, (CASE WHEN P.Active = 'Y' THEN 'Yes' ELSE 'No' END) AS ActiveStatus,  P.CreatedBy, P.CreatedDateTime, 
P.LastUpdatedBy, P.LastUpdatedDateTime, CAST(P.Code AS VARCHAR) AS PCodeString, P.[BarCode], P.[BarCode2], P.[BarCode3], P.[BarCode4]
FROM [Product] AS P  
Left Join [Category] AS C ON P.CatCode = C.Code  
Left Join [Quantity] AS Q ON P.QtyTypeCode = Q.Code  
Left Join [User] AS CU ON P.CreatedBy = CU.Code  
Left Join [User] AS UU ON P.LastUpdatedBy = UU.Code  
ORDER BY P.SNo ASC

---------------
Go
---------------

Alter PROC [SpGetProductRate]      
AS   
BEGIN  
    
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
	[IsDefective] [varchar](1) NULL
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

CREATE PROC [dbo].[SpSaveSale] (@UDT_Sales UDT_Sales readonly, @UDT_Transaction UDT_Transaction readonly, @UDT_PaymentDetails UDT_PaymentDetails readonly, @BILLNO INT OUTPUT)    
As    
BEGIN TRAN 

SET NOCOUNT ON;

BEGIN TRY    
    
  DECLARE @CNT AS INT    
    
  SET @CNT = (SELECT COUNT(*) AS CNT FROM [BillNoDetails] WHERE BilledDate = CAST(GETDATE() AS Date ))    
    
  IF @CNT <= 0    
   INSERT INTO [BillNoDetails]([BillNo], [BilledDate]) VALUES (101, CAST(GETDATE() AS Date ))    
  ELSE    
   UPDATE [BillNoDetails] SET [BillNo] = [BillNo] + 1 WHERE BilledDate = CAST(GETDATE() AS Date )    
    
  SET @BILLNO = (SELECT BillNo FROM [BillNoDetails] WHERE BilledDate = CAST(GETDATE() AS Date ))    
    
    
  INSERT INTO [Sales]([BillNo],[BilledDate],[ProductCode],[Qty],[Unit],[SellRate],[Amount],    
  [DiscPercent],[DiscAmount],[TotAmount],[MRP],[TotDiscAmtFROMMRP],[BilledBy],[BilledDateTime],
  [PurAmount],[ProfitAmount],[DiscCustCode],[DiscEmpCode],[IsDefective])    
  SELECT @BILLNO,CAST(GETDATE() AS Date ),[ProductCode],[Qty],[Unit],[SellRate],[Amount],    
  [DiscPercent],[DiscAmount],[TotAmount],[MRP],[TotDiscAmtFROMMRP],[BilledBy],GETDATE(),
  [PurAmount],[ProfitAmount],[DiscCustCode],[DiscEmpCode],[IsDefective]
  FROM @UDT_Sales    
     
    
  INSERT INTO [SalesTransaction]([BillNo],[BilledDate],[TotAmount],[DiscPercent],[DiscAmount],[GrossAmount],[RoundOffAmount],[NetAmount],    
  [BilledBy],[BilledDateTime], [PrintTotMRP], [PrintTotDiscMRP], [TotProfitAmount])    
  SELECT @BILLNO, CAST(GETDATE() AS Date ), [TotAmount],[DiscPercent],[DiscAmount],[GrossAmount],[RoundOffAmount],[NetAmount],    
  [BilledBy], GETDATE(), [PrintTotMRP], [PrintTotDiscMRP], [TotProfitAmount] FROM @UDT_Transaction    
    
  
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
  
	IF @@TRANCOUNT > 0
		ROLLBACK TRAN;  -- Rollback only if an open transaction exists

	-- Rethrow the original error
	THROW;

END CATCH  

--------------  
GO
--------------  

ALTER PROCEDURE [dbo].[SpSaveRateMaster] (@UDT_RateMaster UDT_RateMaster readonly)  
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
SELECT ProductCode, ProductName, ProductTamilName, CatCode, CatName, QtyTypeCode, QtyTypeName, Qty, BuyRate, SellMarginPercentage, MRP, SellRate,   
ROW_NUMBER() OVER(ORDER BY CatCode, ProductCode) AS RateCode, CAST(ProductCode AS Varchar) AS PCodeString  
FROM (  
  
SELECT P.Code AS ProductCode, P.[Name] AS ProductName, P.TamilName AS ProductTamilName, P.CatCode,   
C.[Name] AS CatName, P.QtyTypeCode, Q.[Name] AS QtyTypeName, '1 ' + Q.ShortName AS Qty,   
R.BuyRate, R.SellMarginPercentage, R.MRP, R.SellRate  
FROM [RateMaster] AS R   
INNER JOIN [Product] AS P On R.ProductCode = P.Code  
LEFT JOIN [Category] AS C On P.CatCode = C.Code  
LEFT JOIN [Quantity] AS Q On Q.Code = P.QtyTypeCode  
WHERE ISNULL(P.CalcBasedRateMast,'') = 'Y' AND ISNULL(P.Active,'') = 'Y'  
  
UNION ALL  
  
SELECT P.Code AS ProductCode, P.[Name] AS ProductName, P.TamilName AS ProductTamilName, P.CatCode,   
C.[Name] AS CatName, P.QtyTypeCode, Q.[Name] AS QtyTypeName, '1 ' + Q.ShortName AS Qty,   
CAST(0.00 AS NUMERIC(12, 2)) AS BuyRate, CAST(0.00 AS NUMERIC(12, 2)) AS SellMarginPercentage, CAST(0.00 AS NUMERIC(12, 2)) AS MRP,
CAST(0.00 AS NUMERIC(12, 2)) AS SellRate  
From [Product] AS P  
LEFT JOIN [Category] AS C On P.CatCode = C.Code  
LEFT JOIN [Quantity] AS Q On Q.Code = P.QtyTypeCode  
WHERE ISNULL(P.CalcBasedRateMast,'') = 'Y' AND ISNULL(P.Active,'') = 'Y'  
AND NOT EXISTS (SELECT ProductCode FROM RateMaster AS R WHERE R.ProductCode = P.Code)  
  
) AS RateMasterData

--------------  
GO
--------------  

