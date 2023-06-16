use super_market_db;

create table Customers (Id int unique not null identity, First_Name nvarchar(100) not null, Last_Name nvarchar(100) not null, Email nvarchar(180),Phone nvarchar(50) not null unique,password nvarchar(500) not null, PRIMARY KEY (Id))	;