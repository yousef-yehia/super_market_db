using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SuperMaker.Database.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        // Not Db
        public string FullName { get; set; }
        public static User CreateFromReader(SqlDataReader reader)
        {
            var user=new User();
            user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            user.FirstName = reader["First_Name"].ToString();
            user.LastName = reader["Last_Name"].ToString();
            user.Email = reader["Email"].ToString();
            user.Phone = reader["Phone"].ToString();
            user.FullName = $"{user.FirstName} {user.LastName}";
            return user;
        }
    }
}
