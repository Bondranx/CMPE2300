
if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'CustName'
	)
	drop procedure CustName
	go

create proc CustName
as
	select FirstName + ' ' + LastName as 'Customer Name'
	from AdventureWorksLT.SalesLT.Customer
	where CustomerID in (select CustomerID
						from AdventureWorksLT.SalesLT.CustomerAddress
						where AddressType='Shipping')
						go

exec CustName
go

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'CustNameID'
	)
	drop procedure CustNameID
go

create proc CustNameID
as
	select	FirstName + ' ' + LastName as 'Customer Name',
			CustomerID as 'ID'
	from AdventureWorksLT.SalesLT.Customer
	where SalesPerson = 'adventure-works\Pamela0' and CustomerID in (select CustomerID
													from AdventureWorksLT.SalesLT.CustomerAddress
													where AddressType = 'Main Office')
													go

exec CustNameID

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'CustNameIDbyCountry'
	)
	drop procedure CustNameIDbyCountry
go

create proc CustNameIDbyCountry
as
	select	FirstName + ' ' + LastName as 'Customer Name',
			CustomerID as 'ID'
	from AdventureWorksLT.SalesLT.Customer
	where SalesPerson = 'adventure-works\Garrett1' and CustomerID in (select CustomerID
													from AdventureWorksLT.SalesLT.CustomerAddress
													where AddressType = 'Main Office' and AddressID in (select AddressID
																										from AdventureWorksLT.SalesLT.Address
																										where CountryRegion = 'Canada'))
																										go

exec CustNameIDbyCountry
go

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'ProductList'
	)
	drop procedure ProductList
go

create proc ProductList
@ProductName varchar(50) output,
@Profitmargin int output
as
	select Name, ProductNumber as 'Product Number', ProductID as 'ID'
	from AdventureWorksLT.SalesLT.Product
	where Name = @ProductName AND @ProfitMargin >= (ListPrice-StandardCost) 
	go

exec ProductList 'Chain', 1000
go

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'ProductListParameters'
	)
	drop procedure ProductListParameters
go

create proc ProductListParameters
@UserCountry varchar(50) output,
@UserProductQty int output,
@UserListPrice int output
as
	select ProductNumber as 'Product Number'
	from AdventureWorksLT.SalesLT.Product
	where ListPrice >= @UserListPrice AND ProductID in (select ProductID
				from AdventureWorksLT.SalesLT.SalesOrderDetail
				where OrderQty >= @UserProductQty AND SalesOrderID in (Select SalesOrderID
						from AdventureWorksLT.SalesLT.SalesOrderHeader
						where CustomerID in (select CustomerID
								from AdventureWorksLT.SalesLT.Customer
								where CustomerID in (Select CustomerID
										from AdventureWorksLT.SalesLT.Customer
										where CustomerID in (select CustomerID
												from AdventureWorksLT.SalesLT.CustomerAddress
												where AddressID in (select AddressID
														from AdventureWorksLT.SalesLT.Address
														where CountryRegion = @UserCountry))))))
	go

exec ProductListParameters 'Canada', 1, 1
go
