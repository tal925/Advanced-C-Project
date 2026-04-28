using DalApi;
using Do;
using System;
using System.Linq;
using Tools;

namespace Dal;
// מחלקה המכילה את הלוגיקה 
internal class CastemerImplementation : ICustomer
{
    /// <summary>
    /// יוצרת לקוח חדש ומוסיפה אותו לרשימת הלקוחות, אם קיים כבר לקוח עם אותו id זורקת חריגה
    /// </summary>
    public int Create(Customer item)
    {
        LogManager.WriteToLog("DalList", "Create", "Started creating a new customer");
        try
        {
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

    // Read by id - implemented as requested
    public Customer? Read(int id)
    {
        LogManager.WriteToLog("DalList", "Read(id)", $"Searching for customer id={id}");
        return DataSource.Customers.FirstOrDefault(c => c != null && c.id == id);
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.WriteToLog("DalList", "Read(filter)", "Searching for customer by filter");
        return DataSource.Customers.FirstOrDefault(c => c != null && filter(c));
    }

    public IEnumerable<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.WriteToLog("DalList", "ReadAll", "Fetching customer list");
        if (filter == null)
            return DataSource.Customers.Select(item => item);

        return DataSource.Customers.Where(filter).Select(item => item);
    }

    public void Update(Customer item)
    {
        LogManager.WriteToLog("DalList", "Update", $"Attempting to update customer ID: {item.id}");
        var existingCustomer = DataSource.Customers.FirstOrDefault(c => c != null && c.id == item.id);

        if (existingCustomer == null)
        {
            LogManager.WriteToLog("DalList", "Update", $"ERROR: Customer ID {item.id} not found for update");
            throw new Exception("This customer does not exist in the customers list");
        }

        int index = DataSource.Customers.IndexOf(existingCustomer);
        DataSource.Customers[index] = item;
        LogManager.WriteToLog("DalList", "Update", $"Successfully updated customer ID: {item.id}");
    }

    public void Delete(int id)
    {
        LogManager.WriteToLog("DalList", "Delete", $"Attempting to delete customer ID: {id}");
        var customer = DataSource.Customers.FirstOrDefault(c => c != null && c.id == id);

        if (customer == null)
        {
            LogManager.WriteToLog("DalList", "Delete", $"ERROR: Customer ID {id} not found for deletion");
            throw new Exception("The customer does not exist to delete");
        }

        DataSource.Customers.Remove(customer);
        LogManager.WriteToLog("DalList", "Delete", $"Successfully deleted customer ID: {id}");
    }
}