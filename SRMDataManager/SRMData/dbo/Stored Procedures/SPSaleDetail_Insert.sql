CREATE PROCEDURE [dbo].[SPSaleDetail_Insert]
	@SaleId int,
	@ProductId int,
	@Quantity int,
	@PurchasePrice money,
	@Tax money
AS
BEGIN
set nocount on;

insert into dbo.SaleDetail(SaleId, ProductId, Quantity , PurchasePrice, Tax)
values(@SaleId, @ProductId, @Quantity , @PurchasePrice, @Tax)
END
