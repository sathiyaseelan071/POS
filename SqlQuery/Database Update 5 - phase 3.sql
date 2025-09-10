
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


