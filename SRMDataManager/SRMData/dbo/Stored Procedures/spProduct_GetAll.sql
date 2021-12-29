CREATE PROCEDURE [dbo].[SPProduct_GetAll]
AS
BEGIN
	set nocount on;

	SELECT Id, ProductName, [Description], RetailPrice, QuantityInStock
	from dbo.Product
	order by ProductName
END