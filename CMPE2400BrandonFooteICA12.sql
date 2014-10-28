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
@UserColor as VarChar(50) = null
as
if(@UserColor is not null)
(
	Select	Count(P.ListPrice) as 'Number of Products',
			Round(avg(P.ListPrice),2) as 'Average Price',
			Round(max(P.ListPrice),2) as 'Highest Price',
			Round(min(P.ListPrice),2) as 'Lowest Price'
	from AdventureWorksLT.SalesLT.Product as P
	where P.Color=@UserColor
)
else if(@UserColor is null)
(
	Select  Count(P.ListPrice) as 'Number of Products',
			Round(avg(P.ListPrice),2) as 'Average Price',
			Round(max(P.ListPrice),2) as 'Highest Price',
			Round(min(P.ListPrice),2) as 'Lowest Price'
	from AdventureWorksLT.SalesLT.Product as P
)
go

exec Question1
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

Create proc Question2
@UserCompany as varchar(50)
as
select  sum(OrderQTY) as 'Number of Products',
		Round(avg(SOD.UnitPrice),2) as 'Average Unit Price',
		avg(SOD.UnitPriceDiscount)*100 as 'Average Discount',
		sum(SOD.LineTotal) as 'Total Paid'	
from AdventureWorksLT.SalesLT.SalesOrderHeader as SOH
inner join AdventureWorksLT.SalesLT.Customer as C
	on C.CustomerID = SOH.CustomerID
inner join AdventureWorksLT.SalesLT.SalesOrderDetail as SOD
	on SOH.SalesOrderID = SOD.SalesOrderID
where @UserCompany = C.CompanyName
go
exec Question2 'Nearby Cycle Shop'
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

Create proc Question3
@UserMaxDate as Int,
@UserMinDate as Int
as 
Select  Count(SalesOrderID) as 'Number of Orders',
		avg(TotalDue) as 'Average of all orders',
		max(DateDiff(day,OrderDate,ShipDate)) as 'Number of Days'
from AdventureWorksLT.SalesLT.SalesOrderHeader
go

exec Question3 2010, 2000
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
as
Select  distinct CompanyName as 'Company Name',
		sum(OrderQTY) as 'Number of Products Ordered'
from AdventureWorksLT.SalesLT.SalesOrderHeader as SOH
inner join AdventureWorksLT.SalesLT.Customer as C
	on C.CustomerID = SOH.CustomerID
inner join AdventureWorksLT.SalesLT.SalesOrderDetail as SOD
	on SOH.SalesOrderID = SOD.SalesOrderID
	Group by CompanyName
	Order by sum(OrderQTY)desc
go
exec Question4
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

Create proc Question5
as
Select distinct PC.Name as 'Product Category Name',
	   avg(P.ListPrice) as 'Average Product Price',
	   Max(P.ListPrice) as 'Highest Product Price',
	   Min(P.ListPrice) as 'Lowest Product Price',
	   Count(P.ListPrice) as 'Number of Products'
from AdventureWorksLT.SalesLT.Product as P
inner join AdventureWorksLT.SalesLT.ProductCategory as PC
on P.ProductCategoryID = PC.ProductCategoryID
where PC.ParentProductCategoryID is not null
Group by PC.Name
Order by Count(P.ListPrice) desc
go

exec Question5
go
