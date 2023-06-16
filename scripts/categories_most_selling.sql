select top 1 count(orders_products.order_id) as orders, categories.name
from products
inner join categories
on products.category_id=categories.id
inner join orders_products
on products.id=orders_products.product_id
group by categories.name
