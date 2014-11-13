--Question 1

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'NewPublisher'
	)
	drop proc NewPublisher
	go


create proc NewPublisher
@newID as Char(4),
@newName as varchar(40),
@newCity as varchar(20),
@newState as char(2),
@newCountry as varchar(30)
as
if @newID is not null 
begin
	Insert into bfoote1_pubs.dbo.publishers
		(pub_id,pub_name,city,state,country)
		values
		(@newID,@newName,@newCity,@newState,@newCountry)

end
go

--exec NewPublisher 9917,'Me','Edmonton','AB','Canada'
--go

--Question 2

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'NewAuthor'
	)
	drop proc NewAuthor
	go

create proc NewAuthor
@AuthorID as varchar(11),
@AuthorFName as varchar(40),
@AuthorLName as varchar(20),
@AuthorPhone as char(12),
@AuthorAddress as varchar(40),
@AuthorCity as varchar(20),
@AuthorState as char(2),
@AuthorZip as char(5),
@AuthorContract as bit
as
if @AuthorID is not null --and @AuthorID like'[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]'
begin
insert into bfoote1_pubs.dbo.authors
	(au_id,au_lname,au_fname,phone,address,city,state,zip,contract)
	values
	(@AuthorID,@AuthorLName,@AuthorFName,@AuthorPhone,@AuthorAddress,@AuthorCity,@AuthorState,@AuthorZip,@AuthorContract)
end
go

--exec NewAuthor '165-85-1289','FO','BR','123-123-1234','559','Edm','AB','13245',1
--go

--Question 3

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'NewHire'
	)
	drop proc NewHire
	go

create proc NewHire
@EmpID as char(9),
@EmpFName as varchar(20),
@EmpMinit as char(1),
@EmpLName as varchar(30),
@EmpJobID as smallint,
@EmpJobLvl as tinyint,
@EmpPubID as char(4),
@EmpHireDate as datetime,
@Error as varChar(50) output
as
if(@EmpID is not null)
begin
insert into bfoote1_pubs.dbo.employee
	(emp_id,fname,minit,lname,job_id,job_lvl,pub_id,hire_date)
values
	(@EmpID,@EmpFName,@EmpMinit,@EmpLName,@EmpJobID,@EmpJobLvl,@EmpPubID,@EmpHireDate)
end
go

exec NewHire 'AMB12345M','BR','J','FO',2,123,'1234','1991-08-27','Error'

select * from bfoote1_pubs.dbo.employee
go