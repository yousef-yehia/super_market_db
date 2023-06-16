use super_market_db 

select * from customers where  id in (select customer_id from orders where customer_id=customers.id and DATEDIFF(year,created_at, GETDATE())>=1)
