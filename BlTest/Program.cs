using System;
using BlApi;
using BO;
using DalApi;

namespace BlTest;

class Program
{
    // השדה הראשי שדרכו ניגשים לכל הלוגיקה - לפי דרישות המטלה
    static readonly IBl s_bl = BlApi.Factory.Get();
        
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
        Console.WriteLine("\nOrder Options: a. Place Order, 0. Back");
        string choice = Console.ReadLine()!;
        try
        {
            switch (choice)
            {
                case "a":
                    Console.Write("Enter Customer ID (or 0 for guest): ");
                    int custId = int.Parse(Console.ReadLine()!);
                    bool isFavorite = false;
                    if (custId != 0)
                    {
                        // check if customer exists in BL (treat as club member if exists)
                        isFavorite = s_bl.Customer.ExistingCustomer(custId);
                        if (!isFavorite) Console.WriteLine("Customer not found - continuing as guest.");
                    }

                    var order = new BO.Order { ifFavorite = isFavorite, Items = new List<BO.ProductInOrder>() };

                    while (true)
                    {
                        Console.Write("Enter product ID to add (or 'done' to finish): ");
                        var prodInput = Console.ReadLine()!;
                        if (prodInput.Trim().ToLower() == "done") break;

                        if (!int.TryParse(prodInput, out int prodId))
                        {
                            Console.WriteLine("Invalid product id, try again.");
                            continue;
                        }

                        Console.Write("Enter amount: ");
                        if (!int.TryParse(Console.ReadLine()!, out int amount) || amount <= 0)
                        {
                            Console.WriteLine("Invalid amount, try again.");
                            continue;
                        }

                        // Call BL method that adds the product(s) and returns applied sales.
                        // The BL implementation updates `order` in-place; the method returns List<BO.SaleInProduct>.
                        try
                        {
                            var appliedSales = ((dynamic)s_bl.Order).AddProductToOrder(order, prodId, amount);
                            if (appliedSales is System.Collections.Generic.List<BO.SaleInProduct> sales && sales.Count > 0)
                            {
                                Console.WriteLine("Applied sales for this product:");
                                foreach (var sale in sales) Console.WriteLine(sale);
                            }
                        }
                        catch
                        {
                            var appliedSales = s_bl.Order.AddProductToOrder(order, prodId, amount);
                            if (appliedSales != null && appliedSales.Count > 0)
                            {
                                Console.WriteLine("Applied sales for this product:");
                                foreach (var sale in appliedSales) Console.WriteLine(sale);
                            }
                        }

                        Console.WriteLine($"Current total: {order.TotalPrice}");
                    }

                    Console.WriteLine($"Final total: {order.TotalPrice}");
                    Console.Write("Complete order and update stock? (y/n): ");
                    var confirm = Console.ReadLine()!;
                    if (confirm.Trim().ToLower() == "y")
                    {
                        s_bl.Order.DoOrder(order);
                        Console.WriteLine("Order completed and stock updated.");
                    }
                    else Console.WriteLine("Order canceled.");
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        catch (Exception ex) { PrintError(ex); }
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