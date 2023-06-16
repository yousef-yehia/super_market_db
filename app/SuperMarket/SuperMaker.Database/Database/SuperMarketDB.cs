using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace SuperMaker.Database.Database
{
    public class SuperMarketDB
    {
        private static string ConnectionString;

        private SqlConnection connection;
        public SuperMarketDB()
        {
            connection = new SqlConnection(ConnectionString);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public SqlCommand Command(string cmd)
        {
            return new SqlCommand(cmd,this.connection);
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public static void SetConnectionString(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public static void seed()
        {
            var db = new SuperMarketDB();
            db.OpenConnection();
            var command=db.Command(@"declare @firstName nvarchar(100)='Super',
            @lastName nvarchar(100) = 'Admin',
            @email nvarchar(100) = 'superadmin@gmail.co',
            @phone nvarchar(100) = '01094046206',
            @password nvarchar(100) = 'Pass1234.'
            If NOT EXISTS(SELECT * FROM Admins
            WHERE First_Name = @firstName
            AND Last_Name = @lastName
            And email = @email
            and phone = @phone
            and password = @password)
            BEGIN
                insert into Admins(First_Name, Last_Name, Email, Phone, Password)
            OUTPUT INSERTED.ID
            values(@firstName, @lastName, @email, @phone, @password);
            END");
            command.ExecuteNonQuery();
            command = db.Command(@"if not exists (select * from categories)
begin
insert into categories(name)values('electrical appliances'),('food')
end");
            command.ExecuteNonQuery();
            db.connection.Close();
        }
        ~SuperMarketDB()
        {
            connection.Close();
        }
    }
}
