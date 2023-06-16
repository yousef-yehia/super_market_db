using SuperMaker.Database.Models;

namespace SuperMarket.App
{
    public static class ShoppingCart
    {
        
        public static List<SuperMaker.Database.Models.Product> Products;
        public static int Total;

        public static void Reset()
        {
            Products=new List<SuperMaker.Database.Models.Product>();
            Total=0;
        }

    }
}
