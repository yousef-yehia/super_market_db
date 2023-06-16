use super_market_db

update Products set Name=@name,Price=@price,Quantity=@quantity,Category_Id=@category_id,Description=@description  where Id=@Id