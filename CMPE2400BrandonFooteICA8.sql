--Question 1

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'NumberID'
	)
	drop procedure NumberID
	go

create proc NumberID
as
select SalesOrderNumber as 'Sales Order Number',
	   CustomerID as 'Customer ID'
from AdventureWorksLT.SalesLT.SalesOrderHeader
where exists (select CustomerID
			  from AdventureWorksLT.SalesLT.Customer
			  where Phone not like '[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]' and Customer.CustomerID=SalesOrderHeader.CustomerID) 
			  go 
			
exec NumberID
go

--Question 2

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'OrderTotal'
	)
	drop procedure OrderTotal
	go

create proc OrderTotal
as
select FirstName + ' ' + LastName as 'CustomerName'
from AdventureWorksLT.SalesLT.Customer
where exists (select CustomerID
			  from AdventureWorksLT.SalesLT.SalesOrderHeader
			  where TotalDue < 10000 and SalesOrderHeader.CustomerID=Customer.CustomerID)
go

exec OrderTotal
go

--Question 3

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'CustomerList'
	)
	drop procedure CustomerList
	go

create proc CustomerList
as
select FirstName + ' ' + LastName as CustomerName
from AdventureWorksLT.SalesLT.Customer
where exists (select CustomerID
					 from AdventureWorksLT.SalesLT.SalesOrderHeader
					 where exists (select SalesOrderID 
								   from AdventureWorksLT.SalesLT.SalesOrderDetail
								   where exists (select ProductID
												 from AdventureWorksLT.SalesLT.Product
												 where DATEDIFF(year,SellStartDate,GetDate()) >= 8 and OrderDate is not null and SellStartDate is not null and 
												 Customer.CustomerID=SalesOrderHeader.CustomerID and 
												 SalesOrderHeader.SalesOrderID=SalesOrderDetail.SalesOrderID and
												 SalesOrderDetail.ProductID=Product.ProductID)))
go
exec CustomerList
go

--Question 4

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'CustomerCategory'
	)
	drop procedure CustomerCategory
	go

create proc CustomerCategory
@UserCategory as varchar(50)
as
select Name,StandardCost,Color
from AdventureWorksLT.SalesLT.Product
where exists ( select ProductCategoryID
			   from AdventureWorksLT.SalesLT.ProductCategory
			   where Name = @UserCategory and ProductCategory.ProductCategoryID = Product.ProductCategoryID)
go

exec CustomerCategory ''
go

--Question 5

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'CompanyNumByCountryAndCity'
	)
	drop procedure CompanyNumByCountryAndCity
	go

create proc CompanyNumByCountryAndCity
@UserCountry as varchar(50),
@UserCity as varchar(30)
as
select CompanyName, Phone
from AdventureWorksLT.SalesLT.Customer
where exists (select CustomerID
			  from AdventureWorksLT.SalesLT.CustomerAddress
			  where exists (select AddressID
							from AdventureWorksLT.SalesLT.Address
							where CountryRegion = @UserCountry and City = @UserCity and Address.AddressID=CustomerAddress.AddressID 
							and Customer.CustomerID=CustomerAddress.CustomerID))
go

exec CompanyNumByCountryAndCity 'Canada', 'Edmonton'
go

--Question 6

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'OrderInfo'
	)
	drop procedure OrderInfo
	go

create proc OrderInfo
@UserColor as varchar(15),
@Lower as int,
@higher as int
as
select Name as 'Product Name',
	   Size as 'Product Size',
	   Weight as 'Product Weight'
from AdventureWorksLT.SalesLT.Product
where exists (select ProductID
			  from AdventureWorksLT.SalesLT.SalesOrderDetail
			  where exists (select SalesOrderID
							from AdventureWorksLT.SalesLT.SalesOrderHeader
							where Color = @UserColor and SubTotal >= @Lower and SubTotal <= @Higher and Product.ProductID=SalesOrderDetail.ProductID 
							and SalesOrderHeader.SalesOrderID = SalesOrderDetail.SalesOrderID))
go
exec OrderInfo 'blue', 50, 500