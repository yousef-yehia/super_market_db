use super_market_db 

declare @firstName nvarchar(100)='',
		@lastName nvarchar(100)='',
		@email nvarchar(100)='',
		@phone nvarchar(100)='',
		@password nvarchar(100)=''

insert into Customers(First_Name,Last_Name,Email,Phone,Password) OUTPUT INSERTED.ID values(@firstName,@lastName,@email,@phone,@password);