using DalApi;
using DalTest;
using Do;
using System.Reflection;
using System.Xml.Linq;
using Dal;
using Tools;
using DalList;
//מציג תפריטים המאפשרים למשתמש (המנהל או הקופאי) לבצע פעולות על הנתונים.
internal class Program
{
   private static readonly IDal s_dal = s_dal = DalList.DalList.Instance;
    private static void Main(string[] args)
    {
        Initialization.Initialize();
        try
        {
            int select = PrintMainMenu();
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        ProdactMenu();
                        break;
                    case 2:
                        SaleMenu();
                        break;
                    case 3:
                        CustomerMenu();
                        break;
                    case 4: 
                        LogManager.CleanOldLogs();
                        Console.WriteLine("Cleanup complete. Files older than 2 months were deleted.");
                        break;
                    default:
                        Console.WriteLine("wrong select");
                        break;
                }
                select = PrintMainMenu();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static int PrintMainMenu()
    {
        Console.WriteLine("For product press 1");
        Console.WriteLine("For sale press 2");
        Console.WriteLine("For Castemer press 3");
        Console.WriteLine("For clean Log folder press 4");
        Console.WriteLine("To exit press 0");

        int select = 0;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }
    public static int PrintSubMenu(string name)
    {
        Console.WriteLine($"For add {name} press 1");
        Console.WriteLine($"For read {name} press 2");
        Console.WriteLine($"For read all {name} press 3");
        Console.WriteLine($"For update {name} press 4");
        Console.WriteLine($"For delete {name} press 5");
        Console.WriteLine("To exist press 0");
        int select = 0;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }
    private static void UpdateProduct()
    {
        try
        {
            Console.WriteLine("Enter Code");
            int code = int.Parse(Console.ReadLine());

            // הדפסת פרטי המוצר הנוכחי לפני העדכון
            Console.WriteLine(s_dal.Product.Read(p => p.id == code));
            // קבלת פרטים חדשים מהמשתמש ויצירת אובייקט מוצר מעודכן
            Product p = Askprodect(code);

            // ביצוע העדכון במסד הנתונים
            s_dal.Product.Update(p);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    private static void UpdateSale()
    {
        try
        {
            Console.WriteLine("Enter id");
            int id = int.Parse(Console.ReadLine());

            // הדפסת פרטי המוצר הנוכחי לפני העדכון
            Console.WriteLine(s_dal.Sale.Read(s => s != null && s.idProduct == id));

            // קבלת פרטים חדשים מהמשתמש ויצירת אובייקט מוצר מעודכן
            Sale s = AskSale(id);

            // ביצוע העדכון במסד הנתונים
            s_dal.Sale.Update(s);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    /// עדכון לקוח קיים
    private static void UpdateCustomer()
    {
        try
        {
            Console.WriteLine("Enter id");
            int id = int.Parse(Console.ReadLine());

            // הדפסת פרטי המוצר הנוכחי לפני העדכון
            Console.WriteLine(s_dal.customer.Read(c => c.id == id));

            // קבלת פרטים חדשים מהמשתמש ויצירת אובייקט מוצר מעודכן
            Customer c = AskCustomer(id);

            // ביצוע העדכון במסד הנתונים
            s_dal.customer.Update(c);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    private static void ProdactMenu()
    {
        int select;
        select = PrintSubMenu("product");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddProdect();
                    break;
                case 2:
                    Read(s_dal.Product);
                    break;
                case 3:
                    ReadAll(s_dal.Product);
                    break;
                case 4:
                    UpdateProduct();
                    break;
                case 5:
                    Delete(s_dal.Product);
                    break;
                default:
                    Console.WriteLine("Wrong selection. please select again.");
                    break;
            }
            select = PrintSubMenu("product");
        }


    }
    private static void CustomerMenu()
    {
        int select = PrintSubMenu("customer");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    Read(s_dal.customer);

                    break;
                case 3:
                    ReadAll<Customer>(s_dal.customer);
                    break;
                case 4:
                    Delete<Customer>(s_dal.customer);
                    break;
                case 5:
                    UpdateCustomer();
                    break;
                case 0:
                    Console.WriteLine("To go back");
                    break;
                default:
                    Console.WriteLine("worng selection! please press again!");
                    break;
            }

            select = PrintSubMenu("customer");

        }


    }
    private static void SaleMenu()
    {

        int select = PrintSubMenu("sale");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddSale();
                    break;
                case 2:
                    Read(s_dal.Sale);

                    break;
                case 3:
                    ReadAll<Sale>(s_dal.Sale);
                    break;
                case 4:
                    Delete<Sale>(s_dal.Sale);
                    break;
                case 5:
                    UpdateSale();
                    break;
                case 0:
                    Console.WriteLine("To go back");
                    break;
                default:
                    Console.WriteLine("worng selection! please press again!");
                    break;
            }

            select = PrintSubMenu("sale");

        }

    }
    private static void Read<T>(ICrud<T> crud)
    {
        try
        {
            Console.WriteLine("Enter Code");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine(s_dal.Product.Read(p => p.id == code));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    private static void ReadAll<T>(ICrud<T> crud)
    {
        foreach (var item in crud.ReadAll())
            Console.WriteLine(item);
    }
    private static void Delete<T>(ICrud<T> crud)
    {
        try
        {
            Console.WriteLine("Enter Code");
            int code = int.Parse(Console.ReadLine());
            crud.Delete(code);
            Console.WriteLine("Deleted successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    private static void AddProdect()
    {
        Product p = Askprodect();
        int code = s_dal.Product.Create(p);
        p = p with { id = code };
        Console.WriteLine("hgyjiygjdrfryghsw");
        Console.WriteLine(p);
    }
    private static void AddSale()
    {
        Sale s = AskSale();
        int code = s_dal.Sale.Create(s);
        s = s with { idProduct = code };
        Console.WriteLine("hgyjiygjdrfryghsw");
        Console.WriteLine(s);
    }
    private static void AddCustomer()
    {
        Customer c = AskCustomer();
        int code = s_dal.customer.Create(c);
        c = c with { id = code };
        Console.WriteLine("hgyjiygjdrfryghsw");
        Console.WriteLine(c);
    }
    private static Sale AskSale(int code = 0)
    {
        int idprodect;
        int count;
        double pricesale;
        bool clob;
        DateTime start;
        DateTime end;


        int select;
        //double countSale;
        Console.WriteLine("Enter product code");
        if (!int.TryParse(Console.ReadLine(), out idprodect))
            idprodect = 0;
        Console.WriteLine("Enter Price Sale");
        if (!int.TryParse(Console.ReadLine(), out count))
            count = 0;
        Console.WriteLine("For all the customers? enter 0 or 1");
        if (!int.TryParse(Console.ReadLine(), out select))
            select = 1;
        clob = select == 1;
        count = 0;
        Console.WriteLine("Enter count Sale");
        if (!double.TryParse(Console.ReadLine(), out pricesale))
            pricesale = 0;
        Console.WriteLine("Enter date start sale");
        if (!int.TryParse(Console.ReadLine(), out select))
            select = 0;
        start = DateTime.Now.AddDays(select);
        Console.WriteLine("Enter date end sale");
        if (!int.TryParse(Console.ReadLine(), out select))
            select = 0;
        end = start.AddDays(select);
        return new Sale(idprodect, count, pricesale, clob, start, end);
    }
    private static Customer AskCustomer(int identity = 0)
    {
        int id;
        string name;
        string adress;
        int phon;


        Console.WriteLine("Enter customer Id");
        if (!int.TryParse(Console.ReadLine(), out id))
            id = id;
        Console.WriteLine("Enter customer name");
        name = Console.ReadLine();

        //אם לא הקשתי האם ישים לי null?
        Console.WriteLine("Enter customer address");
        adress = Console.ReadLine();
        Console.WriteLine("Enter customer phone");
        phon = int.Parse(Console.ReadLine());
        return new Customer(id, name, adress, phon,false);

    } 
    private static Product Askprodect(int code = 0)
    {
        string name;
        category category;
        double price;
        int amount;
        Console.WriteLine("name enter");
        name = Console.ReadLine();
        Console.WriteLine("enter categorey 0-3");
        int cat;
        if (!int.TryParse(Console.ReadLine(), out cat))
            category = 0;
        else
            category = (category)cat;
        Console.WriteLine("enter price");
        if (!double.TryParse(Console.ReadLine(), out price))
            price = 10;
        Console.WriteLine("insert amount");
        if (!int.TryParse(Console.ReadLine(), out amount))
            amount = 0;
        return new Product(code, name, category, price, amount);
    } 
}
