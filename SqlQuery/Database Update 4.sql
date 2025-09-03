

ALTER PROC [SpGetProductRate]        
AS  
BEGIN  
    SET NOCOUNT ON;  
      
 SELECT CAST(P.[Code] AS VARCHAR) AS ProductCode, P.[Name] AS ProductName, P.[TamilName] AS ProductTName, P.[AlternativeName] AS ProductAltrName, P.[CatCode], P.[QtyTypeCode], P.[CalcBasedRateMast],        
 Q.ShortName AS Qty, 
 CAST(P.[Code] AS VARCHAR) + ' - ' + P.[Name] + ' - ' + P.[TamilName]  + ' - SRATE: ' + CAST(R.[SellRate] AS VARCHAR) AS SearchName,    

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
  
