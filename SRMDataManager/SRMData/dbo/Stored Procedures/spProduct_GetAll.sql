﻿CREATE PROCEDURE [dbo].[SPProduct_GetAll]
AS
BEGIN
	set nocount on;

	SELECT Id, ProductName, [Description], RetailPrice, QuantityInStock, IsTaxable
	from dbo.Product
	order by ProductName
END