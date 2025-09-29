------------------------------
-------STOCK IMPLEMENT--------
------------------------------

ALTER TABLE [Product] 
ADD [MaintainStock] CHAR(1) NOT NULL 
    CONSTRAINT DF_Product_MaintainStock DEFAULT 'N',
    CONSTRAINT CK_Product_MaintainStock CHECK ([MaintainStock] IN ('Y','N'));

ALTER TABLE [Product] 
ADD [MinStock] INT NOT NULL 
    CONSTRAINT DF_Product_MinStock DEFAULT 0;

ALTER TABLE [Product] 
ADD [MaxStock] INT NOT NULL 
    CONSTRAINT DF_Product_MaxStock DEFAULT 0;

UPDATE Stock SET StockQty = 0;

---------------
GO
---------------

ALTER PROC [dbo].[SpSaveProduct] (@Name VARCHAR(50), @TamilName NVARCHAR(50), @AlternativeName VARCHAR(50),     
@CatCode INT, @QtyTypeCode INT, @CalcBasedRateMast VARCHAR(1), @Active VARCHAR(50), @CreatedBy INT, @LastUpdatedBy INT, @BarCode VARCHAR(50),  
@AllowRateChange VARCHAR(1), @BarCode2 VARCHAR(50), @BarCode3 VARCHAR(50), @BarCode4 VARCHAR(50), 
@MaintainStock CHAR(1), @MinStock INT, @MaxStock INT)
AS    
BEGIN  
    SET NOCOUNT ON;  
    
 DECLARE @Code INT    
 SET @Code = (SELECT ISNULL(MAX([Code]), 0) + 1 FROM [PRODUCT])    
    
 INSERT INTO PRODUCT([Code], [Name], [TamilName], [AlternativeName], [CatCode], [QtyTypeCode], [CalcBasedRateMast],    
 [Active], [CreatedBy], [CreatedDateTime], [LastUpdatedBy], [LastUpdatedDateTime], [BarCode], [AllowRateChange], 
 [BarCode2], [BarCode3], [BarCode4], [MaintainStock], [MinStock], [MaxStock])
 VALUES (@Code, @Name, @TamilName, @AlternativeName, @CatCode, @QtyTypeCode, @CalcBasedRateMast,
 @Active, @CreatedBy, GETDATE(), @LastUpdatedBy, GETDATE(), @BarCode, @AllowRateChange, 
 @BarCode2, @BarCode3, @BarCode4, @MaintainStock, @MinStock, @MaxStock)
  
END

---------------
GO
---------------

ALTER PROC [dbo].[SpUpdateProduct] (@Code INT, @Name VARCHAR(50), @TamilName NVARCHAR(50), @AlternativeName VARCHAR(50),     
@CatCode INT, @QtyTypeCode INT, @CalcBasedRateMast VARCHAR(1), @Active VARCHAR(50), @LastUpdatedBy INT, @BarCode VARCHAR(50),  
@AllowRateChange VARCHAR(50), @BarCode2 VARCHAR(50), @BarCode3 VARCHAR(50), @BarCode4 VARCHAR(50), 
@MaintainStock CHAR(1), @MinStock INT, @MaxStock INT)    
AS    
BEGIN  
    SET NOCOUNT ON;  
    
 UPDATE [Product] SET [Name]=@Name, [TamilName]=@TamilName, [AlternativeName]=@AlternativeName, [CatCode]=@CatCode, [QtyTypeCode]=@QtyTypeCode,    
 [CalcBasedRateMast]=@CalcBasedRateMast, [Active]=@Active, [LastUpdatedBy]=@LastUpdatedBy, [LastUpdatedDateTime]=GETDATE(), [BarCode]=@BarCode,  
 [AllowRateChange]=@AllowRateChange, [BarCode2]=@BarCode2, [BarCode3]=@BarCode3, [BarCode4]=@BarCode4, 
 [MaintainStock] = @MaintainStock, [MinStock] = @MinStock, [MaxStock] = @MaxStock
 WHERE [Code] = @Code    
  
END

---------------
GO
---------------

ALTER PROC [dbo].[SpGetProduct]    
AS  
BEGIN  
    SET NOCOUNT ON;   
  
 SELECT P.[SNo], P.[Code], P.[Name], P.[TamilName], P.[AlternativeName], P.[CatCode], C.[NAME] AS CatName, P.[QtyTypeCode], Q.[NAME] AS QtyTypeName,     
 P.[CalcBasedRateMast] AS CalcBORMCode, (CASE WHEN P.[CalcBasedRateMast] = 'Y' THEN 'Yes' ELSE 'No' END) AS CalcBORM,   
 P.[AllowRateChange] AS AllowRateChangeCode, (CASE WHEN P.[AllowRateChange] = 'Y' THEN 'Yes' ELSE 'No' END) AS AllowRateChange,   
 P.[Active] AS ActiveStatusCode, (CASE WHEN P.[Active] = 'Y' THEN 'Yes' ELSE 'No' END) AS ActiveStatus,  P.[CreatedBy], P.[CreatedDateTime],
 P.[LastUpdatedBy], P.[LastUpdatedDateTime], CAST(P.[Code] AS VARCHAR) AS PCodeString, P.[BarCode], P.[BarCode2], P.[BarCode3], P.[BarCode4], 
 P.[MaintainStock] AS MaintainStockCode, (CASE WHEN P.[MaintainStock] = 'Y' THEN 'Yes' ELSE 'No' END) AS MaintainStock, P.[MinStock], P.[MaxStock]
 FROM [Product] AS P
 LEFT JOIN [Category] AS C ON P.[CatCode] = C.[Code]
 LEFT JOIN [Quantity] AS Q ON P.[QtyTypeCode] = Q.[Code]    
 LEFT JOIN [User] AS CU ON P.[CreatedBy] = CU.[Code]
 LEFT JOIN [User] AS UU ON P.[LastUpdatedBy] = UU.[Code]
 ORDER BY P.[SNo] ASC  
  
END

---------------
GO
---------------

DROP PROCEDURE [SpSavePurchase]

DROP TYPE [UDT_Purchase]

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
	[BilledBy] [int] NULL,
	[MaintainStock] [varchar](1) NULL,
	[MinimumStock] [int] NULL,
	[MaximumStock] [int] NULL,
	[StockInHand] [int] NULL
)

---------------
GO
---------------
--DROP PROC [SpSavePurchase]
CREATE PROC [dbo].[SpSavePurchase] (@UDT_Purchase UDT_Purchase READONLY, @TotPurAmount AS NUMERIC(12,2), @VendorBillRefNo INT,   
@VendorCode INT, @OldTranNo INT, @TranNo INT OUTPUT)    
AS    
    
BEGIN TRAN    
  
SET NOCOUNT ON;  
  
BEGIN TRY    

 UPDATE P SET P.[MaintainStock] = U.[MaintainStock], P.[MinStock] = U.[MinimumStock], P.[MaxStock] = U.[MaximumStock] 
 FROM [Product] AS P
 INNER JOIN @UDT_Purchase AS U ON U.[ProductCode] = P.[Code]
 WHERE 1=1 AND U.[MaintainStock] = 'Y';
    
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
  S.[StockQty] = (CASE WHEN PR.MaintainStock = 'Y' THEN ISNULL(S.[StockQty], 0) + ISNULL(P.[TotPurQty], 0) + ISNULL(P.[StockInHand], 0) ELSE S.[StockQty] END)
  FROM [Stock] AS S
  INNER JOIN @UDT_Purchase AS P ON S.ProductCode = P.ProductCode AND S.MRP = P.MRP  
  INNER JOIN [Product] AS PR ON P.[ProductCode] = PR.CODE
    
  INSERT INTO [Stock](ProductCode, LastPurQty, PurRate, MRP, SellRate, SellingMarginPer, DiscPer, DiscRate,  
  LastUpdatedBy, LastUpdatedDate, LastUpdatedDateTime, [StockQty])
  SELECT [ProductCode], [TotPurQty], [PurRatePerQty], [MRP], [SellRatePerQty], [SellingMarginPer], [DiscPer], [DiscRate],     
  [BilledBy], GETDATE(), GETDATE(), (CASE WHEN PR.MaintainStock = 'Y' THEN ISNULL(P.[TotPurQty], 0) + ISNULL(P.[StockInHand], 0) ELSE 0 END)
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
GO
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
  
 P.[AllowRateChange], ISNULL(P.[BarCode2], '') AS BarCode2, ISNULL(P.[BarCode3], '') AS BarCode3, ISNULL(P.[BarCode4], '') AS BarCode4,
 P.[MaintainStock], 0 AS StockQty
 FROM [Product] AS P        
 INNER JOIN [RateMaster] AS R ON P.Code = R.ProductCode        
 INNER JOIN [Quantity] AS Q ON P.QtyTypeCode = Q.Code        
 WHERE 1=1 
 AND ISNULL(P.CalcBasedRateMast,'') = 'Y' 
 AND ISNULL(P.Active,'') = 'Y'        
       
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
 P.[AllowRateChange], ISNULL(P.[BarCode2], '') AS BarCode2, ISNULL(P.[BarCode3], '') AS BarCode3, ISNULL(P.[BarCode4], '') AS BarCode4, 
 P.[MaintainStock], S.[StockQty]
 FROM [Product] AS P      
 INNER JOIN [Stock] AS S On P.[Code] = S.ProductCode      
 INNER JOIN [Quantity] AS Q ON P.QtyTypeCode = Q.Code        
 WHERE 1=1 
 AND ISNULL(P.CalcBasedRateMast,'') != 'Y' 
 AND ISNULL(P.Active,'') = 'Y'

 UNION        
        
 SELECT CAST(P.[Code] AS VARCHAR) AS ProductCode, P.[Name], P.[TamilName], P.[AlternativeName], P.[CatCode], P.[QtyTypeCode], P.[CalcBasedRateMast],        
 Q.ShortName AS Qty, CAST(P.[Code] AS VARCHAR) + ' - ' + P.[Name]       
 + (CASE WHEN ISNULL(P.BarCode, '') = '' THEN ' - ' + P.[TamilName] ELSE '' END) AS SearchName,        
 (CASE WHEN ISNULL(P.BarCode, '') = '' THEN 'B' + REPLICATE('0', 5 - LEN(RTRIM(CAST(P.[Code] AS VARCHAR)))) +  RTRIM(CAST(P.[Code] AS VARCHAR)) ELSE P.BarCode END ) AS BarCode,      
 '0.00' PurRate, '0.00' MRP, '0.00' SellRate, '0.00' SellingMarginPer, '0.00' DiscPer, '0.00' DiscRate, '0.00' AS ProfitAmt,  
 '0.00' AS EmpProfitAmt, '0.00' AS EmpSellRate, '0.00' AS CustProfitAmt, '0.00' AS  CustSellRate,   
 P.[AllowRateChange], ISNULL(P.[BarCode2], '') AS BarCode2, ISNULL(P.[BarCode3], '') AS BarCode3, ISNULL(P.[BarCode4], '') AS BarCode4,
 P.[MaintainStock], 0 AS [StockQty]
 FROM [Product] AS P      
 INNER JOIN [Quantity] AS Q ON P.QtyTypeCode = Q.Code        
 WHERE 1=1 
 AND ISNULL(P.CalcBasedRateMast,'') != 'Y' 
 AND ISNULL(P.Active,'') = 'Y'
 AND NOT EXISTS ( SELECT S.ProductCode FROM [Stock] AS S WHERE P.[Code] = S.ProductCode )      
 ORDER BY P.[NAME]      
    
END

---------------
GO
---------------

ALTER PROC [dbo].[SpSaveSale] (@UDT_Sales UDT_Sales READONLY, @UDT_Transaction UDT_Transaction READONLY,   
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

  UPDATE S SET S.[StockQty] = ISNULL(S.[StockQty], 0) - ISNULL(U.[Qty], 0) 
  FROM [Stock] AS S
  INNER JOIN @UDT_Sales AS U ON S.[ProductCode] = U.[ProductCode] AND S.[MRP] = U.[MRP]
  INNER JOIN [Product] AS P ON P.[Code] = S.[ProductCode]
  WHERE ISNULL(P.MaintainStock, '') = 'Y'

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

---------------
GO
---------------

ALTER PROC [dbo].[SpUpdateSale] (@UDT_Sales UDT_Sales READONLY, @UDT_Transaction UDT_Transaction READONLY,   
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
 [RoundOffAmount], [NetAmount],  [BilledBy], [BilledDateTime], [BillStatus], [UpdatedBy], [UpdatedDateTime],   
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
 
 --- STOCK HANDEL START ---

 UPDATE S SET S.[StockQty] = ISNULL(S.[StockQty], 0) - ISNULL(U.[Qty], 0) 
 FROM [Stock] AS S
 INNER JOIN @UDT_Sales AS U ON S.[ProductCode] = U.[ProductCode] AND S.[MRP] = U.[MRP]
 INNER JOIN [Product] AS P ON P.[Code] = S.[ProductCode]
 WHERE ISNULL(U.BillStatus, '') = 'F' 
 AND ISNULL(P.MaintainStock, '') = 'Y'
 AND NOT EXISTS (SELECT 1 FROM [Sales] AS S WHERE [BillNo] = @BILLNO   
 AND S.[BilledDate] = CAST(GETDATE() AS DATE) AND S.[ProductCode] = U.[ProductCode] AND S.[MRP] = U.[MRP])  

  --- STOCK HANDEL END ---

 UPDATE S SET S.[StockQty] = ISNULL(S.[StockQty], 0) + ISNULL(Old.Qty, 0) - ISNULL(U.[Qty], 0)
 FROM [Stock] AS S
 INNER JOIN @UDT_Sales AS U ON S.[ProductCode] = U.[ProductCode] AND S.[MRP] = U.[MRP]
 INNER JOIN [Product] AS P ON P.[Code] = S.[ProductCode]
 LEFT JOIN [Sales] AS Old ON Old.[BillNo] = @BillNo
 AND Old.[BilledDate] = CAST(GETDATE() AS DATE)
 AND Old.[ProductCode] = U.[ProductCode]
 AND Old.[MRP] = U.[MRP]
 WHERE ISNULL(U.BillStatus, '') != 'F'
 AND ISNULL(P.MaintainStock, '') = 'Y'
 
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
 
 UPDATE S SET S.[StockQty] = ISNULL(S.[StockQty], 0) + ISNULL(SL.[Qty], 0)
 FROM [Stock] AS S
 INNER JOIN [Sales] AS SL ON SL.[ProductCode] = S.[ProductCode] AND SL.[MRP] = S.[MRP]
 INNER JOIN [Product] AS P ON P.[Code] = S.[ProductCode] 
 WHERE 1=1 AND ISNULL(P.MaintainStock, '') = 'Y' AND SL.[BillNo] = @BillNo AND SL.[BilledDate] = CAST(GETDATE() AS DATE)  
 AND NOT EXISTS (SELECT 1 FROM @UDT_Sales U WHERE U.[ProductCode] = SL.[ProductCode] AND U.[MRP] = SL.[MRP])
 
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
 FROM [CustomerCreditDebitNote] WHERE [BillNo] = @BillNo AND [BillDate] = CAST(GETDATE() AS DATE)  
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

---------------
GO
---------------

ALTER PROC [dbo].[SpSalesBillCancel] (@BillNo INT, @BilledDate DATE)  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    BEGIN TRY  
        BEGIN TRAN;  
  
		-- Reverse Stock for each product in the canceled bill
        UPDATE PS 
		SET PS.[StockQty] = PS.[StockQty] + S.[Qty]
        FROM [Stock] PS
        INNER JOIN [Sales] S ON PS.[ProductCode] = S.[ProductCode] AND PS.[MRP] = S.[MRP]
        WHERE S.[BillNo] = @BillNo AND S.[BilledDate] = @BilledDate AND ISNULL(S.[BillStatus], '') != 'D'

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

---------------
GO
---------------


