
select products.Id, Products.Name, Products.Quantity,categories.Name as Category, Products.Description, (select count(customer_id) from orders_products where product_id=products.id) as CustomersCount
from Products
left join Categories
on Categories.Id=Products.Category_Id