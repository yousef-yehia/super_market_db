using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMaker.Database.Commands
{
    public static class CustomersCommands
    {
        public static string CustomersListCommand = @"select * from customers";
        public static string CustomerWithNoPurchaceThisYearCommand = @"select * from customers where  id in (select customer_id from orders where customer_id=customers.id and DATEDIFF(year,created_at, GETDATE())>=1)";
        public static string CustomerMostFrequentCommand = @"select * from customers where (select COUNT(id) from orders where customer_id=customers.id group by customer_id ) > @minOrdersCount";
        public static string CustomerCreate = @"insert into Customers(First_Name,Last_Name,Email,Phone,Password) OUTPUT INSERTED.ID values(@firstName,@lastName,@email,@phone,@password);";
        public static string CustomerUpdate = @"Update customers set First_Name=@firstName,Last_Name=@lastName,Email=@email,Phone=@phone,Password=@Password where id = @Id";
        public static string CustomerDelete = @"delete from customers where id =@Id";
    }

    public static class CustomersCommandsParams
    {
        public static string Id = @"@Id";
        public static string FirstName = @"@firstName";
        public static string LastName = @"@lastName";
        public static string Email = @"@email";
        public static string Phone = @"@phone";
        public static string Password = @"@Password";

    }
}
