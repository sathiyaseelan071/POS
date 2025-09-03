

EXEC [SpGetTodayBillsWithPayments]

SELECT   
    P.BillNo,  
    STUFF((  
        SELECT ', ' +   
            CASE   
                WHEN PT2.Name = 'ON CREDIT' THEN 'Credit'   
                WHEN PT2.Name = 'GPay/Phone Pay' THEN 'GPay'   
                ELSE PT2.Name   
            END  
            + ' = ' + CAST(CAST(P2.Amount AS DECIMAL(12,2)) AS VARCHAR(20))  
        FROM dbo.PaymentDetails P2  
        INNER JOIN dbo.PaymentType PT2 ON P2.PaymentType = PT2.Code  
        WHERE P2.BillNo = P.BillNo   
            AND P2.BilledDate = CAST(GETDATE() AS DATE)  
            AND ISNULL(P2.BillStatus, '') != 'C'  
			AND P2.PaymentType = 'I'
        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)')  
    , 1, 2, '') AS Payments  
FROM dbo.PaymentDetails P  
WHERE P.BilledDate = CAST(GETDATE() AS DATE)  
    AND ISNULL(P.BillStatus, '') != 'C'
	AND P.PaymentType = 'I'
GROUP BY P.BillNo  
ORDER BY P.BillNo DESC



SELECT V.[Name] AS VendorName, M.BillNo, m.BillDate, TranNo, TranDate, BillAmount, TotalPaid 
FROM [dbo].[VendorBillDetails] AS M
INNER JOIN 
(
SELECT RefTranNo, Sum(Amount) TotalPaid 
From [dbo].[VendorPaymentDetails]
Group By RefTranNo
) AS U on M.TranNo = U.RefTranNo
LEFT JOIN Vendor AS V ON V.Code = M.VendorCode
Where TotalPaid > BillAmount
ORDER BY 1 DESC



SELECT V.[Name] AS VENDOR_NAME, P.[Name] AS PRODUCT_NAME  FROM [dbo].[VendorProductLink] AS VP
LEFT JOIN [dbo].[Vendor] AS V ON V.Code = VP.VendorCode
LEFT JOIN [dbo].[Product] AS P ON P.Code = VP.ProductCode
ORDER BY 1, 2



SELECT * FROM [dbo].[SalesTransaction] WHERE BillNo = 345 AND BilledDate = '2025-09-03'

SELECT * FROM [dbo].[Sales] WHERE BillNo = 345 AND BilledDate = '2025-09-03'

SELECT * FROM [dbo].[Sales] WHERE BilledDate = '2025-09-03' AND ProfitAmount = '0.00'

