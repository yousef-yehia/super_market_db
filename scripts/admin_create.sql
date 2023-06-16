declare @firstName nvarchar(100)='Super',
		@lastName nvarchar(100)='Admin',
		@email nvarchar(100)='superadmin@gmail.co',
		@phone nvarchar(100)='01094046206',
		@password nvarchar(100)='Pass1234.'



If NOT EXISTS ( SELECT * FROM Admins 
                   WHERE First_Name = @firstName
                   AND Last_Name = @lastName
				   And email=@email 
				   and phone=@phone
				   and password=@password)
BEGIN

insert into Admins(First_Name,Last_Name,Email,Phone,Password) 
OUTPUT INSERTED.ID 
values(@firstName,@lastName,@email,@phone,@password);
END