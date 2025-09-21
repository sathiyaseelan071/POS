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
  [BilledBy], GETDATE(), GETDATE(), (CASE WHEN PR.MaintainStock = 'Y' THEN P.[TotPurQty] + P.[StockInHand] ELSE 0 END)
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


