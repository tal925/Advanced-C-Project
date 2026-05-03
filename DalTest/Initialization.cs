namespace DalTest;
using Do;
using DalApi;
using Tools;

public static class Initialization
{
    private static IDal s_dal;
    private static List<int> productCodes = new List<int>(); // תיקון איות מ-prodact

    // יצירת רשימת לקוחות - ללא כפילויות במזהים
    private static void CreateCustomer()
    {
        s_dal.customer.Create(new Customer(142, "aagg", "shagat arye", 1256789, false));
        s_dal.customer.Create(new Customer(141, "gddg", "shagat arye", 1237777789, true));
        s_dal.customer.Create(new Customer(112, "ghhg", "shagat arye", 123789, true));
        s_dal.customer.Create(new Customer(172, "ggddd", "shagat arye", 1234789, true));
        // הוסרו השורות הכפולות שהיו כאן וגרמו לשגיאות
    }

    // יצירת רשימת מוצרים - כולל המזהה 123 לבדיקה
    private static void CreateProduct()
    {
        // מוצר עם מזהה 123 כדי שהחיפוש ב-UI יצליח
        productCodes.Add(s_dal.Product.Create(new Product(123, "Coffee", category.Coffy, 10.5, 50)));
        productCodes.Add(s_dal.Product.Create(new Product(100001, "cola", category.Frozen_yogurt, 102.5, 45)));
        productCodes.Add(s_dal.Product.Create(new Product(107303, "Espresso", category.Coffy, 12.0, 40)));
        productCodes.Add(s_dal.Product.Create(new Product(100021, "Chocolate Cake", category.Cake, 15.5, 67)));
        productCodes.Add(s_dal.Product.Create(new Product(100011, "Fruit Shake", category.Shake, 18.0, 678)));
    }

    // יצירת רשימת הנחות - מתבססת על המוצרים שנוצרו
    private static void CreateSale()
    {
        if (productCodes.Count >= 4) // בדיקת בטיחות שהרשימה מלאה
        {
            s_dal.Sale.Create(new Sale(3, productCodes[0], 100.5, true, DateTime.Now, DateTime.Now.AddDays(7)));
            s_dal.Sale.Create(new Sale(5, productCodes[1], 103.5, true, DateTime.Now, DateTime.Now.AddDays(3)));
            s_dal.Sale.Create(new Sale(6, productCodes[2], 160.5, true, DateTime.Now, DateTime.Now.AddDays(7)));
            s_dal.Sale.Create(new Sale(3, productCodes[3], 144.5, true, DateTime.Now, DateTime.Now.AddDays(2)));
        }
    }

    public static void Initialize()
    {
        // קבלת המופע היחיד (Instance) של הנתונים
        s_dal = DalList.DalList.Instance;
        CreateCustomer();
        CreateProduct(); // חשוב: קודם ליצור מוצרים ורק אז הנחות
        CreateSale();
    }
}