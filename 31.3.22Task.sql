use trial
go
create table tbl_registration
(
sno int,
firstname varchar(20),
gender varchar(10),
department varchar(50),
mobilenumber varchar(12),
address varchar(100),
UGpassoutyear int,
HSCMark int,
SSLCMark int,
numberofarrears int,
technicalskills varchar(50),
constraint reg check (UGpassoutyear>=2020),
constraint arg check (numberofarrears=0)
)

select * from tbl_registration

alter table tbl_registration
add lastname varchar(20) not null

alter table tbl_registration
drop lastname 

insert tbl_registration 
values(1,'venkat','m','CSE','978897969','olumpia at chennai','2022',950,433,0,'c++')

insert tbl_registration
values(2,'venkat','g','CSE','978897969','olumpia at chennai','2022',950,433,2,'c++')



