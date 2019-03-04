create database mydatabase

use mydatabase;


Create table lineproducts(
lineprid int primary key not null  AUTO_INCREMENT,
linename nvarchar(100)
);
create table imageproducts(
	imgid int primary key not null  AUTO_INCREMENT ,
	image nvarchar(100),
	prid int ,
	foreign key (prid) references products
);
create table products (
 prid int not null  AUTO_INCREMENT,
 prname nvarchar(100),
 total int ,
 importprice bigint,
 price bigint,
 lineprid int ,
 totalview int,
 totallike int,
 evaluate float,
 mnday date,
 expirydate date,
 primary key (prid),
 foreign key (lineprid) references lineproducts(lineprid)
);
Create table evaluates(
	evaid int not null  AUTO_INCREMENT,
	comment nvarchar(500),
	evaluate int,
	usid int,
	prid int ,
	primary key (evaid),
	foreign key (usid) references users,
	foreign key (prid) references products
);
Create table imgcomments(
icmtid int AUTO_INCREMENT primary key,
image nvarchar(max),
evaid int,
foreign key(evaid) references evaluates
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

