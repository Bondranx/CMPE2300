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
if @newID is not null or @newID='1756' OR @newID='1622' OR @newID='0877' OR @newID='0736' OR @newID='1389' OR @newID like '99[0-9][0-9]' 
begin
	Insert into bfoote1_pubs.dbo.publishers
		(pub_id,pub_name,city,state,country)
		values
		(@newID,@newName,@newCity,@newState,@newCountry)

end
go

--exec NewPublisher null,'Brandon','Edmonton','AB','Canada'
--go

--select * from bfoote1_pubs.dbo.publishers
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
if @AuthorID is not null and @AuthorID like'[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]' and @AuthorLName is not null
	and @AuthorFName is not null and @AuthorPhone is not null and @AuthorContract is not null
begin
insert into bfoote1_pubs.dbo.authors
	(au_id,au_lname,au_fname,phone,address,city,state,zip,contract)
	values
	(@AuthorID,@AuthorLName,@AuthorFName,@AuthorPhone,@AuthorAddress,@AuthorCity,@AuthorState,@AuthorZip,@AuthorContract)
end
go

--exec NewAuthor '175-85-1289','FO','BR','123-123-1234','559','Edm','AB','13245',1
--go

--select * from bfoote1_pubs.dbo.authors

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
@Error as varChar(50)
as
	begin transaction
		insert into bfoote1_pubs.dbo.employee
			(emp_id,fname,minit,lname,job_id,job_lvl,pub_id,hire_date)
		values
			(@EmpID,@EmpFName,@EmpMinit,@EmpLName,@EmpJobID,@EmpJobLvl,@EmpPubID,@EmpHireDate)

		if @@ERROR <> 0
		begin
			rollback transaction
			print @Error
			return 1
		end
	commit transaction
go

exec NewHire 'AMB14345M','BR','J','FO',2,201,'9999','1991-08-27','Error'

select * from bfoote1_pubs.dbo.employee
go

--Question 4

if exists
	(
		select 	[name]
		from 	sysobjects
		where 	[name] = 'newTitle'
	)
	drop proc NewTitle
	go

create proc newTitle
@TitleID as varchar(6),
@Title as varchar(80),
@TitleType as char(12),
@TitlePubID as char(4),
@TitlePrice as money,
@TitleAdvance as money,
@TitleRoyalty as integer,
@TitleYTDSales as integer,
@TitleNotes as varchar(200),
@TitlePubDate as datetime,
@TitleAuID as varchar(11),
@TitleAuOrd as tinyint,
@TitleAuthorRoyaltyPer as integer
as
	begin transaction
		insert into bfoote1_pubs.dbo.titles
			(title_id,title,type,pub_id,price,advance,royalty,ytd_sales,notes,pubdate)
		values
			(@TitleID,@Title,@TitleType,@TitlePubID,@TitlePrice,@TitleAdvance,@TitleRoyalty,@TitleYTDSales,@TitleNotes,@TitlePubDate)
		
		if @@ERROR <> 0
		begin
			rollback transaction
			print 'First Insert Failed'
			return 1
		end
		insert into bfoote1_pubs.dbo.titleauthor	
			(au_id,title_id,au_ord,royaltyper)
		values
			(@TitleAuID,@TitleID,@TitleAuOrd,@TitleAuthorRoyaltyPer)
		if @@ERROR <> 0
		begin
			rollback transaction
			return 2
			print 'Second Failed'
		end
	commit transaction
go

exec newTitle  '123456','Annoying Course','business','1389',19.99,5000.00,10,123,'I hate this class','1991-08-27','175-85-1289',12,12
go
