using DalApi;
using Do;
namespace Dal;
using Tools;
//מחלקה המכילה את הלוגיקה
internal class ProdactImplementation : IProduct
{
    /// <summary>
    /// הוספת מוצר לרשימת המוצרים, אם קיים מוצר עם אותו id זורקת חריגה
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public int Create(Product item)
    {
        LogManager.WriteToLog("DalList", "Create", "Started creating a new customer");
        if (DataSource.Prodacts.Any(p => p != null && p.id == item.id))
        {
            throw new Exception("The product exists in the list");
        }

        // יצירת מזהה חדש והוספה לרשימה
        int newId = DataSource.Config.GetId;
        Product newProduct = item with { id = newId };
        DataSource.Prodacts.Add(newProduct);

        return newId;

    }
    /// <summary>
    /// מחזירה מוצר לפי תנאי מסוים, אם לא נמצא מחזירה null
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public Product? Read(Func<Product, bool> filter)
    {
        return DataSource.Prodacts.FirstOrDefault(p => p != null && filter(p));
    }
    /// <summary>
    /// מחזירה את כל המוצרים העומדים בתנאי מסוים, אם לא נשלח תנאי מחזירה את כל המוצרים
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public IEnumerable<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        if (filter == null)
            return DataSource.Prodacts.Select(item => item);

        return DataSource.Prodacts.Where(filter).Select(item => item);
    }
    /// <summary>
    /// מעדכנת מוצר קיים ברשימת המוצרים, אם לא נמצא מוצר עם אותו id זורקת חריגה
    /// </summary>
    /// <param name="item"></param>
    /// <exception cref="Exception"></exception>
    public void Update(Product item)
    {
        var existingProduct = DataSource.Prodacts.FirstOrDefault(p => p != null && p.id == item.id);

        if (existingProduct == null)
            throw new Exception("The product isn't found to update");

        int index = DataSource.Prodacts.IndexOf(existingProduct);
        DataSource.Prodacts[index] = item;
    }
    /// <summary>
    /// מחיקה של מוצר מהרשימה לפי id, אם לא נמצא מוצר עם אותו id זורקת חריגה
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="Exception"></exception>
    public void Delete(int id)
    {
        // חיפוש המוצר ברשימה בעזרת LINQ
        var item = DataSource.Prodacts.FirstOrDefault(p => p != null && p.id == id);

        // בדיקה האם המוצר נמצא
        if (item == null)
            throw new Exception("The product isn't found to delete");

        // מחיקת האובייקט שמצאנו מהרשימה
        DataSource.Prodacts.Remove(item);
    }
}