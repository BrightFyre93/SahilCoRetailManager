CREATE PROCEDURE [dbo].[SPSale_Lookup]
	@CashierId nvarchar(128),
	@SaleDate datetime2
AS
BEGIN
set nocount on;
select id from dbo.Sale where CashierId = @CashierId and SaleDate = @SaleDate
END
