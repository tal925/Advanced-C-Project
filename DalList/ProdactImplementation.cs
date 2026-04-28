using DalApi;
using Do;
using System;
using System.Linq;
using Tools;

namespace Dal;
// מחלקה המכילה את הלוגיקה      
internal class ProdactImplementation : IProduct
{
    /// <summary>
    /// הוספת מוצר לרשימת המוצרים, אם קיים מוצר עם אותו id זורקת חריגה
    /// </summary>
    public int Create(Product item)
    {
        LogManager.WriteToLog("DalList", "Create", "Started creating a new product");
        if (DataSource.Prodacts.Any(p => p != null && p.id == item.id))
        {
            LogManager.WriteToLog("DalList", "Create", $"ERROR: Product with ID {item.id} already exists");
            throw new Exception("The product exists in the list");
        }

        // יצירת מזהה חדש והוספה לרשימה (now uses product counter)
        int newId = DataSource.Config.GetProductId;
        Product newProduct = item with { id = newId };
        DataSource.Prodacts.Add(newProduct);

        LogManager.WriteToLog("DalList", "Create", $"Finished. Created product ID: {newId}");
        return newId;
    }

    // Read by id
    public Product? Read(int id)
    {
        LogManager.WriteToLog("DalList", "Read(id)", $"Searching for product id={id}");
        return DataSource.Prodacts.FirstOrDefault(p => p != null && p.id == id);
    }

    public Product? Read(Func<Product, bool> filter)
    {
        return DataSource.Prodacts.FirstOrDefault(p => p != null && filter(p));
    }

    public IEnumerable<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        if (filter == null)
            return DataSource.Prodacts.Select(item => item);

        return DataSource.Prodacts.Where(filter).Select(item => item);
    }

    public void Update(Product item)
    {
        var existingProduct = DataSource.Prodacts.FirstOrDefault(p => p != null && p.id == item.id);

        if (existingProduct == null)
            throw new Exception("The product isn't found to update");

        int index = DataSource.Prodacts.IndexOf(existingProduct);
        DataSource.Prodacts[index] = item;
        LogManager.WriteToLog("DalList", "Update", $"Updated product ID: {item.id}");
    }

    public void Delete(int id)
    {
        var item = DataSource.Prodacts.FirstOrDefault(p => p != null && p.id == id);

        if (item == null)
            throw new Exception("The product isn't found to delete");

        DataSource.Prodacts.Remove(item);
        LogManager.WriteToLog("DalList", "Delete", $"Deleted product ID: {id}");
    }
}