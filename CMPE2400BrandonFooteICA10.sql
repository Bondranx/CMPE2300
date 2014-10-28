--Question 1

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'Question1'
	)
drop procedure Question1
go

create proc Question1
@OnlineFlag as bit
as
select	Customer.FirstName + ' ' + Customer.LastName as "Customer Name",
		SOH.SalesOrderID as "Order ID",
		SOH.Subtotal,
		SOH.TaxAmt as "Tax Amount",
		SOH.Freight,
		SOH.TotalDue as "Total Due"
from AdventureWorksLT.SalesLT.SalesOrderHeader as SOH 
	inner join AdventureWorksLT.SalesLT.Customer as Customer
	on Customer.CustomerID = SOH.CustomerID
where SOH.OnlineOrderFlag = @OnlineFlag
order by SOH.TotalDue desc
go

exec Question1 0
go

--Question 2

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'Question2'
	)
drop procedure Question2
go

create proc Question2
@Country as varchar(50)
as
	if @Country is not null
	(
	select distinct CompanyName as 'Company Name',
		A.AddressLine1,
		A.AddressLine2,
		A.City,
		A.StateProvince,
		A.CountryRegion,
		A.PostalCode
	from AdventureWorksLT.SalesLT.Customer as C
		inner join AdventureWorksLT.SalesLT.CustomerAddress as CA
	on C.CustomerID=CA.CustomerID
		inner join AdventureWorksLT.SalesLT.Address as A
	on A.AddressID=CA.AddressID
	where A.CountryRegion = @Country AND CA.AddressType= 'Main Office'
	)
	order by C.CompanyName asc
else
	(
	select distinct	CompanyName as 'Company Name',
		A.AddressLine1,
		A.AddressLine2,
		A.City,
		A.StateProvince,
		A.CountryRegion,
		A.PostalCode
	from AdventureWorksLT.SalesLT.Customer as C
		inner join AdventureWorksLT.SalesLT.CustomerAddress as CA
	on C.CustomerID=CA.CustomerID
		inner join AdventureWorksLT.SalesLT.Address as A
	on A.AddressID=CA.AddressID

	where CA.AddressType= 'Main Office'
	)
	order by C.CompanyName asc
	go

exec Question2 'Canada'
go

--Question 3

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'Question3'
	)
drop procedure Question3
go

create proc Question3
@ProductCategory as varchar(50)
as
select  P.Name as 'Product Name',
		PC.Name as 'Category Name',
		PM.Name as 'Model Name'
from AdventureWorksLT.SalesLT.ProductModel as PM
	inner join AdventureWorksLT.SalesLT.Product as P
		on P.ProductModelID=PM.ProductModelID
	inner join AdventureWorksLT.SalesLT.ProductCategory as PC
		on P.ProductCategoryID=PC.ProductCategoryID
where PC.Name like('%'+@ProductCategory+'%')
order by P.Name 
go


exec Question3 'Bikes'
go

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'Question4'
	)
drop procedure Question4
go

Create proc Question4
@DaysLate as Integer
as 
Select C.CompanyName as 'Company Name',
	   C.Phone,
	   SOH.SalesOrderNumber as 'Sales Order number',
	   (day(SOH.ShipDate)-day(SOH.DueDate)) as 'Days late'
from AdventureWorksLT.SalesLT.Customer C,
	 AdventureWorksLT.SalesLT.SalesOrderHeader SOH
where C.CustomerID=SOH.CustomerID
	and datediff(day,SOH.DueDate,SOH.ShipDate)>=@DaysLate

go

exec Question4 5
go

--Question 5

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'Question5'
	)
drop procedure Question5
go

create proc Question5
@CompanyName as varchar(50)
as
select P.Name as 'Product Name',
	   OrderQTY as 'Quantity Ordered',
	   UnitPrice as 'Unit Price'
from AdventureWorksLT.SalesLT.Customer C,
	 AdventureWorksLT.SalesLT.SalesOrderHeader SOH,
	 AdventureWorksLT.SalesLT.SalesOrderDetail SOD,
	 AdventureWorksLT.SalesLT.Product P
where C.CustomerID=SOH.CustomerID AND
	  SOH.SalesOrderID=SOD.SalesOrderID AND
	  SOD.ProductID=P.ProductID AND
	  C.CompanyName=@CompanyName
Order by P.Name asc
go

exec Question5 'Nearby Cycle Shop'
go

--Question 6

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'Question6'
	)
drop procedure Question6
go

create proc Question6
@StartDate as datetime,
@EndDate as datetime
as 
select	SOH.SalesOrderNumber 'Sales Order Number',
		SOH.AccountNumber 'Account Number',
		A.AddressLine1 'Address Line 1',
		A.AddressLine2 'Address Line 2',
		A.City,
		A.StateProvince 'State/Province',
		A.CountryRegion 'Country',
		A.PostalCode 'Postal Code'
from AdventureWorksLT.SalesLT.SalesOrderHeader SOH,
	 AdventureWorksLT.SalesLT.Address A
where SOH.BillToAddressID=A.AddressID
	AND	@StartDate < SOH.OrderDate OR @EndDate > SOH.OrderDate
go

exec Question6 '2004-01-23',2005
go