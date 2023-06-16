declare @minOrdersCount int =4

select * from customers where (select COUNT(id) from orders where customer_id=customers.id group by customer_id ) > @minOrdersCount
