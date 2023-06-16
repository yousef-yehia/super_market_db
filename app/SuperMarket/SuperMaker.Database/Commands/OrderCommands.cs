using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMaker.Database.Commands
{
    public static class OrderCommands
    {
        public static string OrderCreate =
            @"insert into orders (customer_id,created_at,total) output inserted.id values(@customerId,@created_at,@total);";
        public static string OrderProductCreate =
            @"insert into orders_products (order_id,customer_id,product_id,order_created_at) output inserted.id values (@orderId,@customerId,@productId,@orderCreatedAt);";
    }

    public static class OrderCommandsParams
    {
        public static string CustomerId = "@customerId";
        public static string CreatedAt = "@created_at";
        public static string OrderCreatedAt = "@orderCreatedAt";
        public static string Total = "@total";
        public static string OrderId = "@orderId";
        public static string ProductId = "@productId";

    }
}
