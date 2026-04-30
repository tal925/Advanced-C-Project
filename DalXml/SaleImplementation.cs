using System;
using System.Linq;
using Do;
using Tools;
using DalApi;

namespace Dal;

// מחלקה המכילה את הלוגיקה
internal class SaleImplementation : ISale
{
    /// <summary>
    /// יצירת מכירה חדשה ברשימת המכירות
    /// </summary>
    public int Create(Sale item)
    {
        int newId = DataSource.Config.GetId;

        // בדיקה אם קיימת מכירה עם אותו מזהה (idProduct)
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

    /// <summary>
    /// מחזירה מכירה לפי תנאי מסוים, אם לא נמצא מחזירה null
    /// </summary>
    public Sale? Read(Func<Sale, bool> filter)
    {
        return DataSource.Sales.FirstOrDefault(s => s != null && filter(s));
    }

    /// <summary>
    /// מחזירה מכירה לפי מזהה
    /// </summary>
    public Sale? Read(int id)
    {
        LogManager.WriteToLog("DalList", "Read(id)", $"Searching for sale idProduct={id}");
        return DataSource.Sales.FirstOrDefault(s => s != null && s.idProduct == id);
    }

    /// <summary>
    /// מחזירה את כל המכירות העומדות בתנאי מסוים, אם לא נשלח תנאי מחזירה את כל המכירות
    /// </summary>
    public IEnumerable<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        if (filter == null)
            return DataSource.Sales.Select(item => item);

        // תיקון: התאמת הפילטר לאובייקטים לא null
        return DataSource.Sales.Where(s => s != null && filter(s)).Select(item => item);
    }

    /// <summary>
    /// עדכון מכירה קיימת ברשימת המכירות
    /// </summary>
    public void Update(Sale item)
    {
        var existingSale = DataSource.Sales.FirstOrDefault(s => s != null && s.idProduct == item.idProduct);

        if (existingSale == null)
            throw new Exception("Sale with this id not exists");

        int index = DataSource.Sales.IndexOf(existingSale);
        DataSource.Sales[index] = item;
        LogManager.WriteToLog("DalList", "Update", $"Updated sale product-id: {item.idProduct}");
    }

    /// <summary>
    /// מחיקת מכירה לפי id המוצר, אם לא נמצא זורקת חריגה
    /// </summary>
    public void Delete(int id)
    {
        var sale = DataSource.Sales.FirstOrDefault(s => s != null && s.idProduct == id);

        if (sale == null)
            throw new Exception("Sale with this id not exists");

        DataSource.Sales.Remove(sale);
        LogManager.WriteToLog("DalList", "Delete", $"Deleted sale product-id: {id}");
    }

    // מימוש ממשק ISale
    public IEnumerable<Sale> GetList()
    {
        // מחזיר את כל המכירות שאינן null
        return DataSource.Sales.Where(s => s != null).Cast<Sale>();
    }

    public Sale Get(int id)
    {
        var sale = DataSource.Sales.FirstOrDefault(s => s != null && s.idProduct == id);
        if (sale == null)
            throw new Exception("Sale with this id not exists");
        return sale;
    }

    public void Add(Sale sale)
    {
        Create(sale);
    }
}
public static class DataSource
{
    public static class Config
    {
        private static int _saleId = 1;
        public static int GetId => _saleId++;
    }

    public static List<Sale> Sales { get; } = new();
}
