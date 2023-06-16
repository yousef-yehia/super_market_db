use super_market_db;

create table Orders (Id int not null PRIMARY KEY identity, Customer_Id int Foreign Key REFERENCES Customers(Id) on delete set null, Created_At datetime not null,total decimal(10,3) not null default 0);