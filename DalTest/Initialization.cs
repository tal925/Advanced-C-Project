namespace DalTest;
using Do;
using DalApi;
using Tools;
//מחלקה שתפקידה למלא את ה-DataSource בנתונים ראשוניים

public static class Initialization
{
    private static IDal s_dal;
    private static List<int> prodactCodes = new List<int>();

    //יצירת רשימת מוצרים
    private static void CreateProdect()
    {
        prodactCodes.Add(s_dal.Product.Create(new Product(100001, "cola", category.Frozen_yogurt, 102.5, 45)));
        prodactCodes.Add(s_dal.Product.Create(new Product(107303, "ddgfdfg", category.Coffy, 102.5, 40)));
        prodactCodes.Add(s_dal.Product.Create(new Product(100021, "aagdfgda", category.Cake, 102.5, 67)));
        prodactCodes.Add(s_dal.Product.Create(new Product(100011, "aatrtrga", category.Shake, 102.5, 678)));
        prodactCodes.Add(s_dal.Product.Create(new Product(103061, "gfg", category.Ice_cream, 102.5, 80)));
     }

    //יצירת רשימת הנחות
    private static void CreateSale()
    {
        s_dal.Sale.Create(new Sale(3, prodactCodes[0], 100.5, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(5, prodactCodes[1], 103.5, true, DateTime.Now, DateTime.Now.AddDays(3)));
        s_dal.Sale.Create(new Sale(3, prodactCodes[3], 144.5, true, DateTime.Now, DateTime.Now.AddDays(2)));
        s_dal.Sale.Create(new Sale(6, prodactCodes[2], 160.5, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_dal.Sale.Create(new Sale(9, prodactCodes[0], 190.5, true, DateTime.Now, DateTime.Now.AddDays(1)));
    
    }

    //יצירת רשימת לקוחות
    private static void CreateCustomer()
    {
        s_dal.customer.Create(new Customer(142, "aagg", "shagat arye", 1256789,false));
        s_dal.customer.Create(new Customer(141, "gddg", "shagat arye", 1237777789,true));
        s_dal.customer.Create(new Customer(112, "ghhg", "shagat arye", 123789, true));
        s_dal.customer.Create(new Customer(172, "ggddd", "shagat arye", 1234789, true));
        s_dal.customer.Create(new Customer(142, "aagg", "shagat arye", 1256789, false));
        s_dal.customer.Create(new Customer(141, "gddg", "shagat arye", 1237777789, false));  
    }

    public static void Initialize()
    {
        s_dal = DalList.DalList.Instance;
        CreateCustomer();
        CreateProdect();
        CreateSale();
    }
}
