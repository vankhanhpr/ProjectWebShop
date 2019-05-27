create database mydatabase

use mydatabase;


Create table lineproducts(
lineprid int primary key not null  AUTO_INCREMENT,
linename nvarchar(500)
);

create table products (
 prid int not null primary key  AUTO_INCREMENT,
 prname nvarchar(200),
 total int ,
 importprice bigint,
 price bigint,
 lineprid int ,
 totalview int,
 totallike int,
 evaluate float,
 image nvarchar(200),
 mnday datetime,
 expirydate datetime,
 foreign key (lineprid) references lineproducts(lineprid)
);
create table imageproducts(
	imgid int  not null  AUTO_INCREMENT ,
	image nvarchar(500),
	prid int,
    primary key (imgid),
	foreign key (prid) references products(prid)
);
Create table evaluates(
	evaid int not null  AUTO_INCREMENT,
	comment nvarchar(65535),
	evaluate int,
	usid int,
	prid int ,
	primary key (evaid),
	foreign key (usid) references users(usid),
	foreign key (prid) references products(prid)
);
create  table imgcomments(
icmtid int AUTO_INCREMENT primary key,
image nvarchar(500),
evaid int,
foreign key(evaid) references evaluates(evaid)
);
Create table carts(
cartid int AUTO_INCREMENT primary key,
money double,
prid int, 
foreign key (prid) references products(prid)
);
Create table Activity(
 actid int not null Auto_increment primary key,
 actiname nvarchar(100)
)

Create table users (
usid int AUTO_INCREMENT primary key,
fullname nvarchar(100),
password nvarchar(100),
roles int ,
avatar nvarchar(200),
wall nvarchar(200),
email nvarchar(100),
phone nvarchar(10),
address nvarchar(400),
birthday datetime,
createday datetime,
active int,
foreign key (roles) references roles(roleid),
foreign key (active) references activity(actid)
);
Create table Invoice(
ivid int AUTO_INCREMENT primary key,
namecustomer nvarchar(100),
quantitum int ,
totalmoney double ,
money double ,
discount double,
note nvarchar(300),
prid int,
foreign key (prid) references products(prid)
);

