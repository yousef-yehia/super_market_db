use super_market_db;

create table Categories (Id int unique identity not null,Name nvarchar(250) not null unique, PRIMARY KEY (Id))	;