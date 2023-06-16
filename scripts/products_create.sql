use super_market_db

declare @name nvarchar(250)='',
@price decimal(10,3)=0,
@quantity int =0,
@category_id int=0,
@description nvarchar(500)=''

insert into Products (Name,Price,Category_Id,Quantity,Description)Values(@name,@price,@category_id,@quantity,@description)