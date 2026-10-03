
CREATE TABLE StockAdjustmentReasonMaster
(
    SNo INT IDENTITY(1,1),
    ReasonCode VARCHAR(20) NOT NULL UNIQUE,
    ReasonName VARCHAR(100) NOT NULL,
    AdjustmentType VARCHAR(10) NOT NULL,
    Active INT NOT NULL DEFAULT 1,
    CreatedBy INT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT CK_StockAdjustmentReasonMaster_AdjustmentType
        CHECK (AdjustmentType IN ('ADD', 'REDUCE'))
);
GO



INSERT INTO StockAdjustmentReasonMaster
    (ReasonCode, ReasonName, AdjustmentType, CreatedBy)
VALUES
    -- ADD
    ('OPEN_STOCK',      'Opening Stock',                    'ADD',    1),
    ('REPACK',          'Repacking',                        'ADD',    1),
    ('CUST_RET',        'Customer Returns',                 'ADD',    1),
    ('VENDOR_REPLACE',  'Vendor Replacement',               'ADD',    1),
    ('PACKED_ITEM',     'Own Packed Item',                  'ADD',    1),

    -- REDUCE
    ('DAMAGE_MAN',      'Stock Damage - Manual',             'REDUCE', 1),
    ('DAMAGE_RAT',      'Stock Damage - Rat',                'REDUCE', 1),
    ('EXP_LOSS',        'Expiry - Loss',                     'REDUCE', 1),
    ('VEN_RETURN',      'Vendor Returns (Expiry Non-Loss)',  'REDUCE', 1),
    ('STOCK_MISS',      'Stock Missing',                     'REDUCE', 1);
GO



CREATE TABLE [dbo].[StockAdjustmentDetails]
(
    [Id]                  INT IDENTITY(1,1) PRIMARY KEY,

    [ProductCode]         INT              NOT NULL,
    [MRP]                 DECIMAL(12,2)    NOT NULL,
    [SellRate]            DECIMAL(12,2)    NOT NULL,

    [CurStockQty]         DECIMAL(12,2)    NOT NULL,
    [AdjustQty]           DECIMAL(12,2)    NOT NULL,
    [StockQty]            DECIMAL(12,2)    NOT NULL,

	[AdjustmentType]      VARCHAR(20)      NOT NULL,
    [Reason]              VARCHAR(50)      NOT NULL,

    [UpdatedBy]       INT              NOT NULL,
    [UpdatedDate]     DATE             NOT NULL,
    [UpdatedDateTime] DATETIME2        NOT NULL
        CONSTRAINT [DF_StockAdjustmentDetails_LastUpdatedDateTime]
        DEFAULT GETDATE()
);
GO

ALTER TABLE [dbo].[StockAdjustmentDetails]
ADD CONSTRAINT [FK_StockAdjustmentDetails_Product]
FOREIGN KEY ([ProductCode])
REFERENCES [dbo].[Product] ([Code]);
GO


ALTER PROCEDURE [dbo].[SpUpdateStockAdjustment]
(
    @ProductCode    INT,
    @MRP            DECIMAL(12,2),
    @SellRate       DECIMAL(12,2),
    @CurStockQty    DECIMAL(12,2),
    @AdjustQty      DECIMAL(12,2),
    @StockQty       DECIMAL(12,2),
    @Reason         VARCHAR(50),
    @UpdatedBy      INT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @AdjustmentType VARCHAR(20);
    DECLARE @Id INT;

    BEGIN TRY

		UPDATE [Product] SET MaintainStock = 'Y' WHERE Code = @ProductCode AND ISNULL(MaintainStock,'') = 'N'  

        SELECT @AdjustmentType = AdjustmentType
        FROM [dbo].[StockAdjustmentReasonMaster]
        WHERE ReasonCode = @Reason;

        IF @AdjustmentType IS NULL
        BEGIN
            RAISERROR('Invalid stock adjustment reason.', 16, 1);
            RETURN;
        END;

        BEGIN TRANSACTION;

        INSERT INTO [dbo].[StockAdjustmentDetails]
        (
            [ProductCode],
            [MRP],
            [SellRate],
            [CurStockQty],
            [AdjustQty],
            [StockQty],
			[AdjustmentType],
            [Reason],
            [UpdatedBy],
            [UpdatedDate]
        )
        VALUES
        (
            @ProductCode,
            @MRP,
            @SellRate,
            @CurStockQty,
            @AdjustQty,
            @StockQty,
			@AdjustmentType,
            @Reason,
            @UpdatedBy,
            GETDATE()
        );

        SET @Id = CAST(SCOPE_IDENTITY() AS INT);

        IF @AdjustmentType = 'ADD'
        BEGIN
            UPDATE [dbo].[Stock]
            SET [StockQty] = [StockQty] + @AdjustQty
            WHERE [ProductCode] = @ProductCode
              AND [MRP] = @MRP;
        END
        ELSE IF @AdjustmentType = 'REDUCE'
        BEGIN
            UPDATE [dbo].[Stock]
            SET [StockQty] = [StockQty] - @AdjustQty
            WHERE [ProductCode] = @ProductCode
              AND [MRP] = @MRP;
        END;

        IF @@ROWCOUNT = 0
        BEGIN
            RAISERROR('Stock record not found for the given ProductCode and MRP.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;

        COMMIT TRANSACTION;

        SELECT @Id AS Id;

    END TRY
    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        THROW;

    END CATCH
END;
GO
