if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'GetCategories'
	)
drop procedure GetCategories
go

create proc GetCategories
as
select	CategoryID as 'Category ID',
		CategoryName as 'Category Name'
from NorthwindTraders.dbo.Categories
order by CategoryName asc
go

exec GetCategories
go

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'GetProductsForCategory'
	)
drop procedure GetProductsForCategory
go

create proc GetProductsForCategory
@Category as integer = 0
as
if(@Category = 0)
begin
select	ProductID as 'Product ID',
		ProductName as 'Product Name',
		QuantityPerUnit as 'Quantity Per Unit',
		UnitPrice as 'Unit Price',
		Discontinued as 'Discontinued'
from NorthwindTraders.dbo.Products
end
else if(@Category!=0)
begin
select	ProductID as 'Product ID',
		ProductName as 'Product Name',
		QuantityPerUnit as 'Quantity Per Unit',
		UnitPrice as 'Unit Price',
		Discontinued as 'Discontinued'
from NorthwindTraders.dbo.Products as P
inner join NorthwindTraders.dbo.Categories as C
	on	C.CategoryID=P.CategoryID
where @Category=C.CategoryID
end
go

exec GetProductsForCategory 
go

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'GetSupplierForProduct'
	)
drop procedure GetSupplierForProduct
go

create Proc GetSupplierForProduct
@Product as integer
as
select	SupplierID	as 'Supplier ID',
		CompanyName as 'Company Name',
		ContactName as 'Contact Name',
		Phone		as 'Phone Number',
		Fax			as 'Fax Number',
		Address,
		City,
		Region,
		Country,
		PostalCode	as 'Postal Code'
from NorthwindTraders.dbo.Suppliers

where (select ProductID
	   from NorthwindTraders.dbo.Products
