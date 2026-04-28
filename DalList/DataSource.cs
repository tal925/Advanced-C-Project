using Do;

namespace Dal
{
    //שמירת האוביקטים בזמן שהתוכנית רצה
    internal static class DataSource
    {
        internal static List<Product?> Prodacts = new();
        internal static List<Sale?> Sales = new();
        internal static List<Customer?> Customers = new();

        internal static class Config
        {
            // Customer id (existing)
            internal const int id = 100065;
            private static int num = id;
            public static int GetId { get { return num++; } }

            // Product id (new counter)
            private static int productNum = 100000;
            public static int GetProductId { get { return productNum++; } }

            // Sale id (new counter)
            private static int saleNum = 200000;
            public static int GetSaleId { get { return saleNum++; } }
        }
    }
}