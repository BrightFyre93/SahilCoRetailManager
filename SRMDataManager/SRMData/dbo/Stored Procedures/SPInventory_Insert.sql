CREATE PROCEDURE [dbo].[SPInventory_Insert]
	@ProductID int,
	@Quantity int,
	@PurchasePrice money,
	@PurchaseDate datetime2
AS
BEGIN

	set nocount on;

	insert into dbo.Inventory(ProductId, Quantity, PurchasePrice, PurchaseDate)
	values(@ProductID, @Quantity, @PurchasePrice, @PurchaseDate)
END
