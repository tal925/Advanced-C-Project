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
            internal const int id = 100065;
            private static int num = id;
            public static int GetId { get { return num++; } }
        }
    }
}