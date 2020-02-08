create database Kindergarten;


use Kindergarten;

create table Student(St_Id int,St_Name varchar(30),St_Address varchar(34),St_DOB date);
insert into Student Values(1001,'Roman','US','03/04/1989');

select * from Student;
insert into Student Values(1002,'John','UK','08/09/1990');
select * from Student;
insert into Student Values(1003,'Batista','England','05/03/1994');
select * from Student;
create table Teachers(Tec_Name varchar(44),St_Id int,Tec_Depart varchar(33),Tec_Contcatnum int);
insert into Teachers Values('Sanket',1003,'Computer',967854);
insert into Teachers Values('Kiran',1003,'Electrical',967854);
insert into Teachers Values('Kiran',1003,'Electrical',785321);
insert into Teachers Values('Sama',1002,'E&TC',654321);
insert into Teachers Values('Kalpesh',1002,'Computer1',324321);
select * from Teachers;
create table Toys(toy_Name varchar(40),St_Id int,toy_cost int,toy_type varchar(55));
insert into Toys Values('Hourse Bike',1001,2300,'Plastic');
insert into Toys Values('Car',1002,300,'Iron');
insert into Toys Values('Bike',1002,450,'Wood');

select * from Toys;
delete from Toys where toy_Name='Bike';
select * from Toys;

create table tools()