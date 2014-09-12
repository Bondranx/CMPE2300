--Question 1
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

print ''

--Question 2
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

--Question 3

declare @CurrentDate as nvarchar(15) = datename(Weekday,getdate())
print @CurrentDate
print case @CurrentDate
	when 'Saturday' then 'is a Weekend'
	when 'Sunday' then 'is a Weekend'
	else 'is a Weekday'
end

