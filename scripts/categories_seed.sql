use super_market_db
if not exists (select * from categories)
begin
insert into categories(name)values('electrical appliances'),('food')
end