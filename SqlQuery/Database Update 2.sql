USE [VBOX2526_LIVE]

---------------
Go
---------------
  
Alter PROC [SpGetProductRate]      
AS   
BEGIN  
    
	SELECT CAST(P.[Code] AS VARCHAR) AS ProductCode, P.[Name] AS ProductName, P.[TamilName] AS ProductTName, P.[AlternativeName] AS ProductAltrName, P.[CatCode], P.[QtyTypeCode], P.[CalcBasedRateMast],      
	Q.ShortName AS Qty, CAST(P.[Code] AS VARCHAR) + ' - ' + P.[Name] + ' - ' + P.[TamilName] AS SearchName,     
	(CASE WHEN IsNull(P.BarCode, '') = '' THEN 'B' + REPLICATE('0', 5 - LEN(RTRIM(CAST(P.[Code] AS VARCHAR)))) +  RTRIM(CAST(P.[Code] AS VARCHAR)) ELSE P.BarCode END ) AS BarCode,    
	'0.00' PurRate, '0.00' MRP, R.SellRate, '0.00' SellingMarginPer, '0.00' DiscPer, '0.00' DiscRate, '0.00' AS ProfitAmt,
	'0.00' AS EmpProfitAmt, R.SellRate AS EmpSellRate, '0.00' AS CustProfitAmt, R.SellRate AS  CustSellRate
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
	(CASE WHEN IsNull(P.BarCode, '') = '' THEN 'B' + REPLICATE('0', 5 - LEN(RTRIM(CAST(P.[Code] AS VARCHAR)))) +  RTRIM(CAST(P.[Code] AS VARCHAR)) ELSE P.BarCode END ) AS BarCode,    
	S.PurRate, S.MRP, S.SellRate, S.SellingMarginPer, S.DiscPer, S.DiscRate, 
	CAST(ROUND((S.SellRate -  S.PurRate), 2) AS NUMERIC(12,2)) AS ProfitAmt,
	CAST(ROUND((S.SellRate - S.PurRate) * 0.50, 2) AS NUMERIC(12,2)) AS EmpProfitAmt,
	CAST(ROUND(S.PurRate + ((S.SellRate - S.PurRate) * 0.50), 2) AS NUMERIC(12,2)) AS EmpSellRate,
	CAST(ROUND((S.SellRate - S.PurRate) * 0.75, 2) AS NUMERIC(12,2)) AS CustProfitAmt,
	CAST(ROUND(S.PurRate + ((S.SellRate - S.PurRate) * 0.75), 2) AS NUMERIC(12,2)) AS CustSellRate
	FROM [Product] AS P    
	INNER JOIN [Stock] AS S On P.[Code] = S.ProductCode    
	INNER JOIN [Quantity] AS Q ON P.QtyTypeCode = Q.Code      
	WHERE ISNULL(P.CalcBasedRateMast,'') != 'Y' And ISNULL(P.Active,'') = 'Y'    
     
	UNION      
      
	SELECT CAST(P.[Code] AS VARCHAR) AS ProductCode, P.[Name], P.[TamilName], P.[AlternativeName], P.[CatCode], P.[QtyTypeCode], P.[CalcBasedRateMast],      
	Q.ShortName AS Qty, CAST(P.[Code] AS VARCHAR) + ' - ' + P.[Name]     
	+ (CASE WHEN IsNull(P.BarCode, '') = '' THEN ' - ' + P.[TamilName] ELSE '' END) AS SearchName,      
	(CASE WHEN IsNull(P.BarCode, '') = '' THEN 'B' + REPLICATE('0', 5 - LEN(RTRIM(CAST(P.[Code] AS VARCHAR)))) +  RTRIM(CAST(P.[Code] AS VARCHAR)) ELSE P.BarCode END ) AS BarCode,    
	'0.00' PurRate, '0.00' MRP, '0.00' SellRate, '0.00' SellingMarginPer, '0.00' DiscPer, '0.00' DiscRate, '0.00' AS ProfitAmt,
	'0.00' AS EmpProfitAmt, '0.00' AS EmpSellRate, '0.00' AS CustProfitAmt, '0.00' AS  CustSellRate
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
	[DiscEmpCode] [int] NULL
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

ALTER TABLE [SalesTransaction] ADD [TotProfitAmount] [numeric](12, 2) NULL

---------------
Go
---------------

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
  [DiscPercent],[DiscAmount],[TotAmount],[MRP],[TotDiscAmtFROMMRP],[BilledBy],[BilledDateTime],
  [PurAmount],[ProfitAmount],[DiscCustCode],[DiscEmpCode])    
  SELECT @BILLNO,CAST(GETDATE() AS Date ),[ProductCode],[Qty],[Unit],[SellRate],[Amount],    
  [DiscPercent],[DiscAmount],[TotAmount],[MRP],[TotDiscAmtFROMMRP],[BilledBy],GETDATE(),
  [PurAmount],[ProfitAmount],[DiscCustCode],[DiscEmpCode]
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
    
 ROLLBACK TRAN    
    
END CATCH  
  
--------------  