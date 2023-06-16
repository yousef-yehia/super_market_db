use super_market_db 

declare @firstName nvarchar(100)='',
		@lastName nvarchar(100)='',
		@email nvarchar(100)='',
		@phone nvarchar(100)='',
		@password nvarchar(100)='',
		@Id int =0

Update customers set First_Name=@firstName,Last_Name=@lastName,Email=@email,Phone=@phone,Password=@Password where id = @Id