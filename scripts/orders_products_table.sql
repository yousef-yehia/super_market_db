use super_market_db;

create table Orders_Products (Id int not null identity PRIMARY KEY,Order_ID int not null Foreign Key REFERENCES Orders(Id) on delete cascade, Customer_Id int null Foreign Key REFERENCES Customers(Id) on delete set null,Product_Id int null Foreign Key REFERENCES Products(Id)  on delete set null, Order_Created_At datetime not null)	;