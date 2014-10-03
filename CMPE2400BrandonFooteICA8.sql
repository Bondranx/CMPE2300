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
												 where DATEDIFF(day,OrderDate,SellStartDate) >= 8 and 
												 Customer.CustomerID=SalesOrderHeader.CustomerID and 
												 SalesOrderHeader.SalesOrderID=SalesOrderDetail.SalesOrderID and
												 SalesOrderDetail.ProductID=Product.ProductID)))
go
exec CustomerList
go
