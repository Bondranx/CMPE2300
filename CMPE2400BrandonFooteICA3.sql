----Question 1

declare @Max as int = 1000000
declare @newrandom as int = (((@max)*rand())+1)
if(@newrandom % 2 = 0)
begin
	print @newrandom
	print 'The number is even'
end
else
begin
	print @newrandom
	print 'The number is odd'
end

--print ''

----Question 2

Declare @newMax as int = 101
Declare @NewRandom2 as decimal(4,2) = (((@newMax)*rand())-1)
Declare @LetterGrade as varchar(2)
print @NewRandom2
print case
	when @NewRandom2>=85 then 'Grade = A	GPA = 4.0	Descriptor = Excellent'
	when @NewRandom2>=80 then 'Grade = A-	GPA = 3.7	Descriptor = Excellent'	
	when @NewRandom2>=77 then 'Grade = B+	GPA	= 3.3	Descriptor = Good'
	when @NewRandom2>=73 then 'Grade = B	GPA = 3.0	Descriptor = Good'
	when @NewRandom2>=70 then 'Grade = B-	GPA = 2.7	Descriptor = Good'
	when @NewRandom2>=67 then 'Grade = C+	GPA = 2.3	Descriptor = Satisfactory'
	when @NewRandom2>=63 then 'Grade = C	GPA = 2.0	Descriptor = Satisfactory'
	when @NewRandom2>=60 then 'Grade = C-	GPA	= 1.7	Descriptor = Satisfactory'
	when @NewRandom2>=55 then 'Grade = D+	GPA = 1.3	Descriptor = Marginal'
	when @NewRandom2>=50 then 'Grade = D    GPA = 1.0   Descriptor = Marginal'
	else 'Grade = F    GPA = 0   Descriptor = Fail'
end

----Question 3

declare @CurrentDate as nvarchar(15) = datename(Weekday,getdate())
print @CurrentDate
print case @CurrentDate
	when 'Saturday' then 'is a Weekend'
	when 'Sunday' then 'is a Weekend'
	else 'is a Weekday'
end

----Question 4

Declare @RandomAmount as integer = (9999 * rand())+1
Declare @RandomNumber as integer
Declare @Count10 as integer = 0
Declare @Count20 as integer = 0
Declare @Count30 as integer = 0
Declare @Count40 as integer = 0
Declare @Count50 as integer = 0
Declare @Count as integer = 0
while @count < @RandomAmount
	begin
		set @RandomNumber = (49*rand())+1
		if @RandomNumber >= 40
			begin
				set @Count50 = @Count50 + 1
			end
		else if @RandomNumber >= 30
			begin
				set @Count40 = @Count40 + 1
			end
		else if @RandomNumber >= 20
			begin
				set @Count30 = @Count30 + 1
			end
		else if @RandomNumber >= 10 
			begin
				set @Count20 = @Count20 + 1
			end
		else if @RandomNumber >= 0
			begin
				set @Count10 = @Count10 + 1
			end
			set @Count = @Count +1
		end
Print 'The number of values between 1 and 10 is:' + cast(@Count10 as varchar(6))
Print 'The number of values between 11 and 20 is:' + cast(@Count20 as varchar(6))
Print 'The number of values between 21 and 30 is:' + cast(@Count30 as varchar(6))
Print 'The number of values between 31 and 40 is:' + cast(@Count40 as varchar(6))
Print 'The number of values between 41 and 50 is:' + cast(@Count50 as varchar(6))

--Question 5

--Alter function ParseString
--(
--	@InputString	as char(100)
--)
--returns char(100)
--as
--begin
--	declare @Counter as integer = 1
--	declare @OutputString as varchar(100) = ''
--	declare @TempString as varchar(100)
--	declare @Holder as integer
--	while (@Counter <= len(@InputString))
--	begin
--		 set @TempString = substring (@InputString, @Counter, 1)
--		 set @Holder = ascii (@TempString)
--		 if @Holder = 97 OR @Holder = 101 OR @Holder = 105 OR @Holder = 111 OR @Holder = 117
--			begin
--				set @TempString = Char(@Holder - 32)
--			end  
--		 else 
--			begin
--				set @TempString = Lower (Char (@Holder))
--			end
--		set @OutputString += @TempString
--		set @Counter = @Counter + 1
--		--print @TempString
--	end
--	return @OutputString
--end
--go

print dbo.ParseString('This IS A StRinG')

--Question 6


