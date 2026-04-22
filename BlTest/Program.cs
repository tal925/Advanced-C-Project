using System;
using BlApi;
using BO;

namespace BlTest;

class Program
{
    // השדה הראשי שדרכו ניגשים לכל הלוגיקה - לפי דרישות המטלה
    static readonly IBl s_bl = Factory.Get();

    static void Main(string[] args)
    {
        Console.WriteLine("--- Welcome to the Business Logic Test Program ---");

        // אם תרצי לאתחל נתונים אוטומטית מקובץ ה-XML/רשימות ב-DAL:
        // DalTest.Program.Initialization(); 

        int choice;
        do
        {
            Console.WriteLine("\nSelect an entity to test:");
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Product");
            Console.WriteLine("3. Order");
            Console.WriteLine("4. Sale");
            Console.WriteLine("0. Exit");
            Console.Write("Your choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1: CustomerMenu(); break;
                    case 2: ProductMenu(); break;
                    case 3: OrderMenu(); break;
                    case 4: SaleMenu(); break;
                    case 0: Console.WriteLine("Exiting... Goodbye!"); break;
                    default: Console.WriteLine("Invalid choice, try again."); break;
                }
            }
        } while (choice != 0);
    }

    #region Customer Menu
    static void CustomerMenu()
    {
        Console.WriteLine("\nCustomer Options: a. Add, b. Get, c. GetList, d. Update, e. Delete");
        string choice = Console.ReadLine()!;
        try
        {
            switch (choice)
            {
                case "a": // Add
                    Customer newCust = new();
                    Console.Write("Enter ID: "); newCust.ID = int.Parse(Console.ReadLine()!);
                    Console.Write("Enter Name: "); newCust.Name = Console.ReadLine();
                    Console.Write("Enter Address: "); newCust.Address = Console.ReadLine();
                    Console.Write("Enter Phone: "); newCust.Phone = Console.ReadLine();
                    s_bl.Customer.Add(newCust);
                    Console.WriteLine("Customer added successfully!");
                    break;

                case "b": // Get
                    Console.Write("Enter Customer ID: ");
                    int id = int.Parse(Console.ReadLine()!);
                    Console.WriteLine(s_bl.Customer.Get(id));
                    break;

                case "c": // GetList
                    foreach (var item in s_bl.Customer.GetList()) Console.WriteLine(item);
                    break;

                case "d": // Update
                    Customer upCust = new();
                    Console.Write("Enter ID to update: "); upCust.ID = int.Parse(Console.ReadLine()!);
                    Console.Write("Enter New Name: "); upCust.Name = Console.ReadLine();
                    s_bl.Customer.Update(upCust);
                    Console.WriteLine("Customer updated!");
                    break;

                case "e": // Delete
                    Console.Write("Enter ID to delete: ");
                    int delId = int.Parse(Console.ReadLine()!);
                    s_bl.Customer.Delete(delId);
                    Console.WriteLine("Customer deleted!");
                    break;
            }
        }
        catch (Exception ex) { PrintError(ex); }
    }
    #endregion

    #region Product Menu
    static void ProductMenu()
    {
        Console.WriteLine("\nProduct Options: a. Add, b. Get, c. GetList, d. Update, e. Delete, f. Search Sale");
        string choice = Console.ReadLine()!;
        try
        {
            switch (choice)
            {
                case "b":
                    Console.Write("Enter Product ID: ");
                    int id = int.Parse(Console.ReadLine()!);
                    Console.WriteLine(s_bl.Product.GetProduct(id));
                    break;
                case "c":
                    foreach (var item in s_bl.Product.GetList()) Console.WriteLine(item);
                    break;
                case "f": // פונקציה ייחודית של השכבה הלוגית
                    Console.Write("Enter Product ID to find its sale: ");
                    int pId = int.Parse(Console.ReadLine()!);
                    Console.WriteLine(s_bl.Product.SearchSaleForProduct(pId));
                    break;
                    // ניתן להוסיף כאן a, d, e באותו מבנה
            }
        }
        catch (Exception ex) { PrintError(ex); }
    }
    #endregion

    #region Order & Sale Menus
    static void OrderMenu()
    {
        Console.WriteLine("\nOrder Options: b. Get, c. GetList, d. Update");
        //ביצוע הזמנה: הכנסת מספר לקוח, בדיקה האם לקוח מועדון (שמור ברשימת הלקוחות) או לא
        //בכל שלב - אפשרות להוספת מוצר להזמנה או סיום ההסמנה.
        //בהוספת מוצר מוסיף קוד מוצר וכמות ומעדכן את הסכום לתשלום אחרי חישוב המבצעים
        //בסיום ההזמנה מציג את המחיר הסופי לתשלום ומציע לבצע הזמנה חדשהד
        //string choice = Console.ReadLine()!;
        //try
        //{
        //    switch (choice)
        //    {
        //        case "b":
        //            Console.Write("Enter Order ID: ");
        //            int id = int.Parse(Console.ReadLine()!);
        //            //Console.WriteLine(s_bl.Order.Get(id));
        //            break;
        //        case "c":
        //            foreach (var item in s_bl.Order.GetList()) Console.WriteLine(item);
        //            break;
        //    }
        //}
        //catch (Exception ex) { PrintError(ex); }
    }

    static void SaleMenu()
    {
        Console.WriteLine("\nSale Options: a. Add, b. Get, c. GetList");
        string choice = Console.ReadLine()!;
        try
        {
            switch (choice)
            {
                case "c":
                    foreach (var item in s_bl.Sale.GetList()) Console.WriteLine(item);
                    break;
            }
        }
        catch (Exception ex) { PrintError(ex); }
    }
    #endregion

    // פונקציית עזר להדפסת שגיאות כולל החריגה הפנימית (InnerException) מה-DAL
    static void PrintError(Exception ex)
    {
        Console.WriteLine($"\n--- ERROR: {ex.Message} ---");
        if (ex.InnerException != null)
        {
            Console.WriteLine($"--- Inner Dal Error: {ex.InnerException.Message} ---");
        }
    }
}