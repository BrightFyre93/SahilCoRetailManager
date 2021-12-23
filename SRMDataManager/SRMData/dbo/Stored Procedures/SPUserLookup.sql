CREATE PROCEDURE [dbo].[SPUserLookup]
	@id nvarchar(128)
AS
BEGIN
	set nocount on;
	
	SELECT Id,FirstName, LastName, EmailAddress, CreatedDate
	from dbo.[User]
	where Id = @id
END
