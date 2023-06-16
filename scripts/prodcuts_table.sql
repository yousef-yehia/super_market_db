use super_market_db;

create table Products (Id int unique not null identity,Name nvarchar(250) not null, Price decimal(10,3) not null,Quantity int not null, Category_Id int null Foreign Key References Categories(Id) ON DELETE SET NULL, Description nvarchar(500) , PRIMARY KEY (Id))	;