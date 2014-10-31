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

exec NewPublisher 9917,'Me','Edmonton','AB','Canada'
go

select * from bfoote1_pubs.dbo.publishers

