
declare @month int =5;

select  * from products where not exists (select id from orders_products where product_id =products.id and MONTH(order_created_at)=@month)

