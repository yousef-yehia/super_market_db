

select top 1 * from products order by (select COUNT(Distinct customer_id) as customers from orders_products where product_id =products.id group by product_id
) desc

