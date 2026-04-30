using DalApi;
using Do;
using System;
using System.Linq;
using Tools;

namespace Dal;
// מחלקה המכילה את הלוגיקה
internal class SaleImplementation : ISale
{
    /// <summary>
    /// יצירת מכירה חדשה ברשימת המכירות
    /// </summary>
    public int Create(Sale item)
    {
        int newId = DataSource.Config.GetSaleId;

        // בדיקה אם קיימת מכירה עם אותו מזהה (idProduct) — לפי ההנחה idProduct הוא המפתח
        if (DataSource.Sales.Any(s => s != null && s.idProduct == newId))
        {
            LogManager.WriteToLog("DalList", "Create", $"ERROR: Sale with product-id {newId} already exists");
            throw new Exception("Sale with this id already exists");
        }

        Sale newSale = item with { idProduct = newId };
        DataSource.Sales.Add(newSale);
        LogManager.WriteToLog("DalList", "Create", $"Finished. Created sale product-id: {newId}");
        return newId;
    }

    // Read by id
    public Sale? Read(int id)
    {
        LogManager.WriteToLog("DalList", "Read(id)", $"Searching for sale idProduct={id}");
        return DataSource.Sales.FirstOrDefault(s => s != null && s.idProduct == id);
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        return DataSource.Sales.FirstOrDefault(s => s != null && filter(s));
    }

    public IEnumerable<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        if (filter == null)
            return DataSource.Sales.Select(item => item);

        // Adapt the filter to handle nullable Sale
        return DataSource.Sales.Where(s => s != null && filter(s)).Select(item => item);
    }

    public void Update(Sale item)
    {
        var existingSale = DataSource.Sales.FirstOrDefault(s => s != null && s.idProduct == item.idProduct);

        if (existingSale == null)
            throw new Exception("Sale with this id not exists");

        int index = DataSource.Sales.IndexOf(existingSale);
        DataSource.Sales[index] = item;
        LogManager.WriteToLog("DalList", "Update", $"Updated sale product-id: {item.idProduct}");
    }

    public void Delete(int id)
    {
        var sale = DataSource.Sales.FirstOrDefault(s => s != null && s.idProduct == id);

        if (sale == null)
            throw new Exception("Sale with this id not exists");

        DataSource.Sales.Remove(sale);
        LogManager.WriteToLog("DalList", "Delete", $"Deleted sale product-id: {id}");
    }
}