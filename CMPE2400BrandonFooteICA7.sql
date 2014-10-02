
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