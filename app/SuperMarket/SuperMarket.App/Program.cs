using System.Configuration;
using SuperMaker.Database.Database;

namespace SuperMarket.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            SuperMarketDB.SetConnectionString("Data Source=.;Initial Catalog=super_market_db;Trusted_Connection=True;Encrypt=False;");
            SuperMarketDB.seed();
            Application.Run(new LogIn());
        }
    }
}