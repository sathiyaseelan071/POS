

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
            AND P2.BilledDate = '2025-09-05' --CAST(GETDATE() AS DATE)  
            AND ISNULL(P2.BillStatus, '') != 'C'  
			AND P2.PaymentType = 'I'
        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)')  
    , 1, 2, '') AS Payments  
FROM dbo.PaymentDetails P  
WHERE P.BilledDate = '2025-09-05' --CAST(GETDATE() AS DATE)
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



SELECT * FROM [dbo].[CustomerCreditDebitNote] WHERE TranDate = '2025-09-05'
AND TransType = 'C'


SP_HELPTEXT [SpGetTodayBillsWithPayments]

Text
CREATE PROCEDURE SpGetTodayBillsWithPayments  
AS  
BEGIN  
    SET NOCOUNT ON;  
  

    SELECT   
        P.BillNo,  P.UpdatedDateTime,
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
              AND P2.BilledDate = CAST(GETDATE() - 1 AS DATE)  
              AND ISNULL(P2.BillStatus, '') != 'C'  
            FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)')  
        , 1, 2, '') AS Payments  
    FROM dbo.PaymentDetails P  
    WHERE P.BilledDate = CAST(GETDATE() - 1 AS DATE)  
      AND ISNULL(P.BillStatus, '') != 'C'  
    GROUP BY P.BillNo,  P.UpdatedDateTime  
    ORDER BY P.BillNo DESC;  



END  



=------------------



SELECT   
    ROW_NUMBER() OVER (ORDER BY P.BillNo DESC) AS SNo,
    P.BillNo,  
	FORMAT(ISNULL(MAX(P.UpdatedDateTime), MAX(P.BilledDateTime)), 'hh:mm tt') AS UpdatedTime,
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
          AND P2.BilledDate = CAST(GETDATE() - 1 AS DATE)  
          AND ISNULL(P2.BillStatus, '') != 'C'  
        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)')  
    , 1, 2, '') AS Payments  
FROM dbo.PaymentDetails P  
WHERE P.BilledDate = CAST(GETDATE() - 1 AS DATE)  
  AND ISNULL(P.BillStatus, '') != 'C'  
GROUP BY P.BillNo
ORDER BY P.BillNo DESC;


SELECT FORMAT(UpdatedDate, 'hh:mm tt') AS UpdatedTime, * FROM [dbo].[CustomerCreditDebitNote] WHERE TranDate = '2025-09-05'
AND TransType = 'C'


