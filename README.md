# restaurantapp
 
Database of this app: 

use restaurant



create table master.customers(
	
	customerid int identity (1,1) primary key,
	customername varchar(50),

)

create table master.item(
	
	itemid int identity(1,1) primary key, 
	itemname varchar(50),
	itemprice decimal(18,2), 

)


create table master.paymentType(
	
	paymenttypeid int identity(1,1) primary key, 
	paymenttypename varchar(50),

) 

insert into master.customers(customername) values('customer B'),('customer C'),('customer D'),('customer E');

select * from master.item

insert into master.item(itemname,itemprice) values('biryani',250),('Burger',450),('Pizza',1000),('chicken karhai',550);

insert into master.paymentType(paymenttypename) values ('cash'),('credit');


