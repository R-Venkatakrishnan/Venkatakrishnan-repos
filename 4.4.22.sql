use AdventureWorks2019
go

--Query3

create table tbl_student1
(
Sno int,
StuName varchar(20),
StuAge int
)

alter table tbl_student1
add Gender char(1)

select * from tbl_student1

alter table tbl_student1
add MobileNO varchar(20)

insert into tbl_student1 values(1,'Sidd',22,'M','7530077775')
select * from tbl_student1


go
create view task31
as
select Sno,StuName,StuAge
from tbl_student1
go
select * from task31
insert into tbl_student1 values(2,'swe',22,'F',8830077615)

----task5----

select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))

---task6-----

select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
GRoup By [ProductModelID]


---task7----
select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name

-----task2----

create function fn_RupeesC(@amount as Nvarchar(50))
returns Nvarchar(50)
as 
begin
return (N'?'+@amount)
end
select BusinessEntityID,fn_RupeesC(rate) as Dollar 
from HumanResources.EmployeePayHistory

----task1-----

select  COUNT(+[StandardCost]) TNR
from [Production].[ProductCostHistory]
--USING SUM()
select SUM([StandardCost]) SumCost
from [Production].[ProductCostHistory]
--USING DATEDIFF()
select DATEDIFF(YY,StartDate,EndDate) datedifference
from [Production].[ProductCostHistory]
--USING ADDDATE()
SELECT DATEADD(year, 3, '2006/12/24') AS DateAdd
--USING CONVERT()
SELECT CONVERT(int,59.66);
--USING LEFT()
SELECT LEFT('sidhu', 3) AS ExtractString;
--USING LEN()
select LEN('venki')
--USING REVERSE()
select REVERSE('anand')

----TASK4----
use trial
go
select * from trail.tbl_just

create proc taskIns_sp
@name varchar(50),
@gender char(1)
as
insert into tbl_just(name,gender)
values(@name,@gender)

taskIns_sp 'sid','M'
create proc taskup_sp
@sno int,
@age int,
@name varchar(50)
as
update tbl_just set sno=@sno,age=@age where name = @name

task1_sp 1,19,'sid'
create proc taskDel_sp
@sno int
as
delete from tbl_just where sno = @sno

taskDel_sp 1