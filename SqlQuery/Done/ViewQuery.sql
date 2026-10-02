SELECT VE.[Name], P.[Code], P.[Name] 
FROM [dbo].[VendorProductLink] AS V
INNER JOIN [dbo].[Vendor] AS VE ON V.VendorCode = VE.Code
INNER JOIN [dbo].[Product] AS P ON V.ProductCode = P.Code
ORDER BY VE.[Name], P.[Code]



SELECT S.[ProductCode], P.[Name], S.[MRP], S.[SellRate], S.[StockQty], p.*
FROM [dbo].[Stock] AS S
INNER JOIN [dbo].[Product] AS P ON P.[Code] = S.[ProductCode]
WHERE 1=1 
--AND S.[ProductCode] = 1494 
--AND S.[MRP] = 72.00
AND P.CatCode IN (1, 2)
ORDER BY S.[ProductCode], P.[Name]

