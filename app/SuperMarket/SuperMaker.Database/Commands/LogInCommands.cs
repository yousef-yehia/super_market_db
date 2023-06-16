using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMaker.Database.Commands
{
    public static class LogInCommands
    {
        public static string AdminLogin = "select * from Admins where phone=@identifier or email =@identifier and password =@password";
        public static string CustomerLogin = "select * from Customers where phone=@identifier or email =@identifier and password =@password";
    }
    public static class LogInCommandParameters
    {
        public static string Identifier = "@identifier";
        public static string Password = "@password";
    }
}
