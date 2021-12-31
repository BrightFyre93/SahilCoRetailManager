CREATE PROCEDURE [dbo].[SPProduct_GetById]
	@Id int = 0
AS
BEGIN
	Set nocount on;

	SELECT Id, ProductName, [Description], RetailPrice, QuantityInStock, IsTaxable
	from dbo.Product
	where Id = @Id
END
