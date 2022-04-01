use AdventureWorks2019
go
--TASK 1--
select FirstName,LastName
from Person.Person 
where Title IS NOT NULL

--TASK 2--
select FirstName,LastName
from Person.Person
where FirstName LIKE '%a%' and  LastName LIKE '%a%'

--TASK 3--
select sal.Name as CurrencyCode,Name
from Sales.Currency sc
join Sales.CountryRegionCurrency scr
on sc.CurrencyCode=scr.CurrencyCode
create view vw_tbl
as
select [CurrencyCode],[Name]
from [Sales].[Currency]
go
select * from vw_tbl
--or-
select dis.[CurrencyCode],Name
from [Sales].[Currency],[Sales].[CountryRegionCurrency] dis
--or--
--TASK 4--

--TASK 5--

create table task5
(
Sno int identity(1,1),
Firstname varchar(50),
lastname varchar(50),
Gender char,
age varchar,
phonenumber varchar
)
select * from task5
insert into task5(Firstname,lastname,gender,age,phonenumber) 
values('venkat','R','M')
insert into task5(Firstname,LastName,Gender,age,phonenumber) 
values('JAGA','A','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('anand','B','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('john','C','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('ABDUL','D','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('kumar','E','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('giri','F','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('shivram','G','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('shiva','H','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('girish','I','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('vishal','J','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('Ramesh','K','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('manish','L','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('dhoni','M','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('ruturaj','N','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('rayudu','O','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('mahesh','P','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('KUMAR','Q','M')
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('venkatesh','R','M',25,976433337)
insert into task5(Firstname,lastname,Gender,age,phonenumber) 
values('MUTHU','Gp','M',25,978756576)

--TASK 6--
select dept.Name as BusinessEntityID,AddressTypeID
from HumanResources.Department dept
join HumanResources.EmployeeDepartmentHistory edp
on dept.DepartmentID=edp.DepartmentID
join Person.BusinessEntityAddress pb
on pb.BusinessEntityID=edp.BusinessEntityID

--TASK 7--
select distinct [GroupName]
from [HumanResources].[Department]

--TASK 8--
select a.standardcost,sum(listprice) sum1,sum(a.standardcost) Sum2
from Production.Product a
join Production.ProductCostHistory b
on a.ProductID = b.ProductID
group by a.StandardCost

--TASK 9--
select DATEDIFF (YY,StartDate,EndDate) as YearsOnAge
from HumanResources.EmployeeDepartmentHistory

--TASK 10--
select sum(SalesQuota)
 from Sales.SalesPersonQuotaHistory
 where SalesQuota>5000 and salesquota<100000
 group by SalesQuota


--TASK 11--
select max(TaxRate) MAX_taxrate
from Sales.SalesTaxRate

--TASK 12--
select hdh.BusinessEntityID,dept.DepartmentID,ShiftID
from HumanResources.Employee He
join HumanResources.EmployeeDepartmentHistory hdh
on he.BusinessEntityID=hdh.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=hdh.DepartmentID
Select BirthDate,getdate() as CurrentDate, datediff(YY,BirthDate,getdate()) as age 
from HumanResources.Employee

--TASK 13--
create view nameage
as
Select BirthDate,getdate() as CurrentDate, datediff(YY,BirthDate,getdate()) as age 
from HumanResources.Employee
go
select * from nameage

--TASK 14--
SELECT count(*) numberofrows
FROM [HumanResources].[Department],[HumanResources].[Employee],[HumanResources].[EmployeeDepartmentHistory],[HumanResources].[EmployeePayHistory],[HumanResources].[Shift]

--TASK 15--
select max(rate) as MaxSalary,Name
from HumanResources.EmployeePayHistory pay
join HumanResources.EmployeeDepartmentHistory dhis
on pay.BusinessEntityID = dhis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID = dhis.DepartmentID
GRoup By name

--TASK 16--
select FirstName,MiddleName,Title,dhis.BusinessEntityID
from Person.BusinessEntityAddress dhis
left outer join Person.Person pp
on pp.BusinessEntityID=dhis.BusinessEntityID
where title is not null

--TASK 17--
select ProductID,LocationID,Shelf 
from Production.ProductInventory
where ProductID>300 and ProductID<=350 and locationID=50
--TASK 18--
select pl.LocationID,Shelf,Name
from Production.ProductInventory pp
join Production.Location pl
on pp.LocationID=pl.LocationID

--TASK 19--
select AddressID,AddressLine1,AddressLine2, pad.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince ps
join Person.Address pad
on ps.StateProvinceID=pad.StateProvinceID

--TASK 20--
select sum(SubTotal),sum(TaxAmt)
from Sales.CountryRegionCurrency crc
join Sales.SalesTerritory sst
on crc.CountryRegionCode=sst.CountryRegionCode
join Sales.SalesOrderHeader so
on sst.TerritoryID=so.TerritoryID
group by sst.TerritoryID