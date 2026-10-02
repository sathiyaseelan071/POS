
----
GO
----

BEGIN TRAN

Update M Set AmountPaid = TotalPaid FROM
[dbo].[VendorBillDetails] AS M
INNER JOIN 
(SELECT RefTranNo, Sum(Amount) TotalPaid 
From [dbo].[VendorPaymentDetails]
Group By RefTranNo
) AS U on M.TranNo = U.RefTranNo
Where AmountPaid = 0 and TotalPaid > 0 and BillAmount >= TotalPaid

--COMMIT TRAN
--ROLLBACK TRAN



SELECT TranNo, BillAmount, AmountPaid FROM [dbo].[VendorBillDetails] WHERE TranNo = 63
SELECT * FROM [VendorPaymentDetails] WHERE RefTranNo = 63


SELECT TranNo, BillAmount, AmountPaid FROM [dbo].[VendorBillDetails] WHERE TranNo = 173
SELECT * FROM [VendorPaymentDetails] WHERE RefTranNo = 173


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