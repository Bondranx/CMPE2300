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
order by ProductName asc
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
order by ProductName asc
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
		CompanyName as 'Supplier Name',
		ContactName as 'Contact Name',
		Phone		as 'Phone Number',
		Fax			as 'Fax Number',
		Address,
		City,
		Region,
		Country,
		PostalCode	as 'Postal Code'
from NorthwindTraders.dbo.Suppliers
where @Product in (select ProductID
	   from NorthwindTraders.dbo.Products
	   where ProductID=@Product and Products.SupplierID=Suppliers.SupplierID)
go

exec GetSupplierForProduct 4
go

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'GetCustomers'
	)
drop procedure GetCustomers
go

create proc GetCustomers
as
select	CustomerID as 'Customer ID',
		CompanyName as 'Customer Name'
from NorthwindTraders.dbo.Customers
order by CompanyName asc
go

exec GetCustomers
go

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'GetCustomerInfo'
	)
drop procedure GetCustomerInfo
go

create proc GetCustomerInfo
@Customer as nchar(5) = null
as
if(@Customer is not null)
begin
select	CompanyName as 'Customer Name',
		ContactName as 'Customer Contact',
		ContactTitle as 'Contact Title',
		Phone as 'Phone Number',
		Fax as 'Fax Number',
		Address as 'Customer Address',
		City as 'City',
		Region as 'Region',
		Country as 'Country',
		PostalCode as 'Postal Code'
from NorthwindTraders.dbo.Customers
where @Customer=CustomerID
end
else
return 1
go

exec GetCustomerInfo 'ALFKI'
go

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'GetCustomerOrders'
	)
drop procedure GetCustomerOrders
go

create proc GetCustomerOrders
@Customer as nchar(5) = null
as
if(@Customer is not null)
begin
select	OrderID as 'Order ID',
		OrderDate as 'Order Date',
		RequiredDate as 'Required Date',
		ShippedDate as 'Shipped Date',
		E.FirstName + ' ' + E.LastName as 'Processing Employee',
		O.EmployeeID as 'Employee ID',
		S.CompanyName as "Shipper's Name",
		DATEDIFF(day,RequiredDate,ShippedDate) as 'Days Overdue'
from NorthwindTraders.dbo.Orders as O
inner join NorthwindTraders.dbo.Employees as E
on E.EmployeeID=O.EmployeeID
inner join NorthwindTraders.dbo.Shippers as S
on S.ShipperID=O.ShipVia
where @Customer=CustomerID
end
else
return 1
go

exec GetCustomerOrders 'ALFKI'
go

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'GetOrderDetails'
	)
drop procedure GetOrderDetails
go

create proc GetOrderDetails
@OrderID as integer
as
select	P.ProductName as 'Product Name',
		OD.UnitPrice as 'Unit Price',
		OD.Quantity as 'Quantity',
		OD.Discount as 'Discount',
		Convert(Decimal(10,2),Round((OD.UnitPrice*OD.Quantity*(1-OD.Discount)),2)) as 'Item Total'
from NorthwindTraders.dbo.[Order Details] as OD
inner join NorthwindTraders.dbo.Products as P
	on OD.ProductID=P.ProductID
	where OrderID=@OrderID
go

exec GetOrderDetails 11011
go