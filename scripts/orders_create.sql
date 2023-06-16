use super_market_db

declare @customerId int=1,
@created_at datetime=SYSDATETIME()
@total decimal(10,3) =123312.32

insert into orders (customer_id,created_at,total) output inserted.id values(@customerId,@created_at,@total);