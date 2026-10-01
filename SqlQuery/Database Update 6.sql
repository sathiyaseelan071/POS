CREATE TABLE [dbo].[Stock_Log](
	[SNo] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [int] NOT NULL,
	[LastPurQty] [numeric](12, 2) NOT NULL,
	[PurRate] [numeric](12, 2) NOT NULL,
	[MRP] [numeric](12, 2) NOT NULL,
	[SellRate] [numeric](12, 2) NOT NULL,
	[SellingMarginPer] [numeric](12, 2) NOT NULL,
	[DiscPer] [numeric](12, 2) NOT NULL,
	[DiscRate] [numeric](12, 2) NOT NULL,
	[LastUpdatedBy] [int] NULL,
	[LastUpdatedDate] [date] NULL,
	[LastUpdatedDateTime] [datetime] NULL,
	[StockQty] [numeric](12, 2) NULL
)

------------------
GO
------------------

CREATE PROCEDURE [dbo].[SpStockLogAndDelete]
    @ProductCode VARCHAR(50),
    @MRP DECIMAL(18, 2),
	@DeletedBy INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert current stock details into Stock_Log
    INSERT INTO [dbo].[Stock_Log]
    (
        [ProductCode],
        [LastPurQty],
        [PurRate],
        [MRP],
        [SellRate],
        [SellingMarginPer],
        [DiscPer],
        [DiscRate],
        [LastUpdatedBy],
        [LastUpdatedDate],
        [LastUpdatedDateTime],
        [StockQty]
    )
    SELECT
        [ProductCode],
        [LastPurQty],
        [PurRate],
        [MRP],
        [SellRate],
        [SellingMarginPer],
        [DiscPer],
        [DiscRate],
        @DeletedBy,
        GETDATE(),
        GETDATE(),
        [StockQty]
    FROM [dbo].[Stock]
    WHERE [ProductCode] = @ProductCode
      AND [MRP] = @MRP;

    -- Delete stock entries where quantity is zero
    DELETE FROM [dbo].[Stock]
    WHERE [ProductCode] = @ProductCode
      AND [MRP] = @MRP
      AND [StockQty] = 0.00;
END;

------------------
GO
------------------

