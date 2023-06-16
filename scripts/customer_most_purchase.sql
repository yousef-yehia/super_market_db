use super_market_db 


//HIGHEST ORDER TOTAL

select top 1  customers.*, orders.total as total
from customers
inner join orders
on customers.id=orders.customer_id
order by total desc


//TOTAL PAID AMOUNT
select  top 1 * from customers order by (select SUM(total) as total from orders where customer_id =customers.id group by customer_Id ) desc



