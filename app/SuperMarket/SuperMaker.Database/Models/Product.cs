using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SuperMaker.Database.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category_Id { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public  int CustomersCount { get; set; }

        public static Product CreateFromReader(SqlDataReader reader)
        {
            var prodct = new Product();
            prodct.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            prodct.Name = reader["Name"].ToString();
            prodct.Description = reader["Description"].ToString();
            prodct.Category_Id = reader.GetInt32(reader.GetOrdinal("Category_Id"));
            prodct.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
            prodct.Price = reader.GetDecimal(reader.GetOrdinal("Price"));
            try
            {
                prodct.Category = reader["Category"].ToString();
                prodct.CustomersCount = reader.GetInt32(reader.GetOrdinal("CustomersCount"));
            }
            catch
            {
            }
            return prodct;
            var product = new Product();
            product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            product.Name = reader["First_Name"].ToString();
            product.Description = reader["Last_Name"].ToString();
            product.Category = reader["Category"].ToString();
            product.Category_Id = reader.GetInt32(reader.GetOrdinal("Category_Id"));
            product.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
            product.CustomersCount = reader.GetInt32(reader.GetOrdinal("CustomersCount"));
            return product;
        }
    }
}
