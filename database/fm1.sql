create database mnwarehouse;
use mnwarehouse;

create table roles(
roleid int primary key not null IDENTITY(1,1),
rolename nvarchar(100)
)
create table users(
 usid int primary key not null IDENTITY(1,1),
 usname nvarchar(200),
 birthday Datetime ,
 phonenumber nvarchar(10),
 rolse int,
 foreign key (rolse) references roles (roleid)
)
create table products (
 prid int primary key not null IDENTITY(1,1),
 prname nvarchar(200),
 prcode nvarchar(20) not null,
 position int,
 exprday Datetime,
 importday Datetime not null,
 payday Datetime ,
 checkpay bit ,
 workerid int,
 )
