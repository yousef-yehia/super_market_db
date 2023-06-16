using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMaker.Database.Commands
{
    public static class ProductsCommands
    {
        public static string ProductListCommand = @"select products.Id, Products.Name, Products.Quantity,categories.Name as Category, Products.Description, (select count(customer_id) from orders_products where product_id=products.id) as CustomersCount from Products left join Categories on Categories.Id=Products.Category_Id";
        public static string ProductNoCustomersCommand = @"select  * from products where not exists (select id from orders_products where product_id =products.id and MONTH(order_created_at)=@month)";
        public static string ProductMostCustomers =
            @"select top 1 * from products order by (select COUNT(Distinct customer_id) as customers from orders_products where product_id =products.id group by product_id) desc";
        public static string ProductByIdCommand = @"select * from products where Id=@Id";
        public static string ProductToRestock = @"select * from products where quantity <= 10";
        public static string ProductToRestock = @"select * from products where quantity <= @quantity";
        public static string ProductToCreate= @"insert into Products (Name,Price,Category_Id,Quantity,Description)Values(@name,@price,@category_id,@quantity,@description)";
        public static string ProductToUpdate= @"update Products set Name=@name,Price=@price,Quantity=@quantity,Category_Id=@category_id,Description=@description where Id=@Id";
        public static string ProductDelete = @"delete from products where id =@Id";
    }

    public static class ProductsCommandsParams
    {
        public static string Id = @"@Id";
        public static string Name = @"@name";
        public static string Price = @"@price";
        public static string Category_Id = @"@category_id";
        public static string Description = @"@description";
        public static string Month = @"@month";
        public static string Quantity = @"@quantity";

    }
}
