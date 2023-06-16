use super_market_db

insert into orders_products (order_id,customer_id,product_id,order_created_at) output inserted.id values (@orderId,@customerId,@productId,@orderCreatedAt)