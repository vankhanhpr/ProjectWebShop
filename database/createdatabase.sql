create database mydatabase

use mydatabase;


Create table lineproducts(
lineprid nvarchar(50) primary key not null,
linename nvarchar(100)
);
Create table products (
 prid nvarchar(50),
 prname nvarchar(100),
 total int ,
 image nvarchar(100),
 importprice double,
 price double,
 lineprid nvarchar(50) ,
 primary key (prid),
 foreign key (lineprid) references lineproducts(lineprid)
);
Create table carts(
cartid nvarchar(50) primary key,
money double,
prid nvarchar(50),
foreign key (prid) references products(prid)
);
Create table users (
uid nvarchar(50) primary key ,
username nvarchar(100),
roles int ,
avatar nvarchar(200),
wall nvarchar(200),
email nvarchar(100),
phone nvarchar(10)
);
Create table Invoice(
ivid nvarchar(50) primary key,
namecustomer nvarchar(100),
quantitum int ,
totalmoney double ,
money double ,
discount double,
note nvarchar(300),
prid nvarchar(50),
foreign key (prid) references products(prid)
);

