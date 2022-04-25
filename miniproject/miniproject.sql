create table product_table
(
ProductId int identity(1,1),
ProductName varchar(20),
Price money,
DOM date default Getdate(),
Expirydate date default getdate()
)
 insert product_table values('dairymilk',250,Getdate(),dateadd(m,9,getdate()))

  


 ---customertable----
 create table customertable
(
CustID int identity(1001,1),
Name varchar(20),
Gender char(1),
Dateofbirth date,
Contactnumber char(10),
EmailId varchar (50),
City varchar(15)
)
insert customertable values('haris','M','1998-06-08','9987654312','harris@gmail.com','kokata')
select * from customertable

-----purchasetable---
create table Purchasetable
(
BillNo  int identity(1,1) ,
CustID int ,
Totalamount int,
purchaseDate int,

)
select * from Purchasetable
 drop table Purchasetable