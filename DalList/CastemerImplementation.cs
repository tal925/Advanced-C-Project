using DalApi;
using Do;
using Tools;

namespace Dal;
//מחלקה המכילה את הלוגיקה 
internal class CastemerImplementation : ICustomer
{
    /// <summary>
    /// יוצרת לקוח חדש ומוסיפה אותו לרשימת הלקוחות, אם קיים כבר לקוח עם אותו id זורקת חריגה
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public int Create(Customer item)
    {
        LogManager.WriteToLog("DalList", "Create", "Started creating a new customer");
        try { 
        if (DataSource.Customers.Any(c => c != null && c.id == item.id))
        {
            LogManager.WriteToLog("DalList", "Create", $"ERROR: Customer with ID {item.id} already exists");
            throw new Exception("This customer exists in the customers list");
        }

        int newId = DataSource.Config.GetId;
        Customer newCustomer = item with { id = newId };
        DataSource.Customers.Add(newCustomer);
        
        LogManager.WriteToLog("DalList", "Create", $"Finished. Created customer ID: {newId}");
        return newId;
        }
        catch (Exception ex)
        {
            // סעיף 10: רישום כל שגיאה בלתי צפויה שעלולה לקרות
            LogManager.WriteToLog("DalList", "Create", $"CRITICAL ERROR: {ex.Message}");
            throw;
        }
    }
    /// <summary>
    /// מחזירה לקוח לפי תנאי מסוים, אם לא נמצא מחזירה null
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.WriteToLog("DalList", "Read", "Searching for customer by filter");
        return DataSource.Customers.FirstOrDefault(c => c != null && filter(c));
    }

    /// <summary>
    /// מחזירה את כל הלקוחות העומדים בתנאי מסוים, אם לא נשלח תנאי מחזירה את כל הלקוחות
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public IEnumerable<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.WriteToLog("DalList", "ReadAll", "Fetching customer list");
        if (filter == null)
            return DataSource.Customers.Select(item => item);

        return DataSource.Customers.Where(filter).Select(item => item);
    }
    /// <summary>
    /// מעדכנת לקוח קיים ברשימת הלקוחות, אם לא נמצא לקוח עם אותו id זורקת חריגה
    /// </summary>
    /// <param name="item"></param>
    /// <exception cref="Exception"></exception>
    public void Update(Customer item)
    {
        LogManager.WriteToLog("DalList", "Update", $"Attempting to update customer ID: {item.id}");
        var existingCustomer = DataSource.Customers.FirstOrDefault(c => c != null && c.id == item.id);

        // אם לא נמצא לקוח (FirstOrDefault מחזיר null), נזרוק שגיאה
        if (existingCustomer == null) 
        { 
            LogManager.WriteToLog("DalList", "Update", $"ERROR: Customer ID {item.id} not found for update");
        throw new Exception("This customer does not exist in the customers list");
        }
        // מציאת המיקום (אינדקס) של הלקוח הישן והחלפתו בחדש
        int index = DataSource.Customers.IndexOf(existingCustomer);
        DataSource.Customers[index] = item;
        LogManager.WriteToLog("DalList", "Update", $"Successfully updated customer ID: {item.id}");
    }
    /// <summary>
    /// מוחקת לקוח מהרשימה לפי id, אם לא נמצא לקוח עם אותו id זורקת חריגה
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="Exception"></exception>
    public void Delete(int id)
    {
        LogManager.WriteToLog("DalList", "Delete", $"Attempting to delete customer ID: {id}");
        var customer = DataSource.Customers.FirstOrDefault(c => c != null && c.id == id);

        // אם לא נמצא לקוח כזה, נזרוק שגיאה
        if (customer == null)
        {
            LogManager.WriteToLog("DalList", "Delete", $"ERROR: Customer ID {id} not found for deletion");
            throw new Exception("The customer does not exist to delete");
        }
            

        // הסרה ישירה של האובייקט מהרשימה
        DataSource.Customers.Remove(customer);
        LogManager.WriteToLog("DalList", "Delete", $"Successfully deleted customer ID: {id}");
    }
}
