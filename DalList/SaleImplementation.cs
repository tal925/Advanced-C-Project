using DalApi;
using Do;
namespace Dal;
using Tools;
//מחלקה המכילה את הלוגיקה
internal class SaleImplementation : ISale
{
    /// <summary>
    /// יצירת מכירה חדשה ברשימת המכירות, אם קיים מוצר עם אותו id המוצר זורקת חריגה
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public int Create(Sale item)
    {
        int newId = DataSource.Config.GetId;

        // בדיקה אם קיים מוצר במכירה עם ה-ID החדש (לפי הלוגיקה שלך)
        if (DataSource.Sales.Any(s => s != null && s.idProduct == newId))
        {
            throw new Exception("Sale with this id already exists");
        }

        Sale newSale = item with { idProduct = newId };
        DataSource.Sales.Add(newSale);
        return newId;
    }

    /// <summary>
    /// מחזירה מכירה לפי תנאי מסוים, אם לא נמצא מחזירה null
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public Sale? Read(Func<Sale, bool> filter)
    {
        return DataSource.Sales.FirstOrDefault(s => s != null && filter(s));
    }

    /// <summary>
    /// מחזירה את כל המכירות העומדות בתנאי מסוים, אם לא נשלח תנאי מחזירה את כל המכירות
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public IEnumerable<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        if (filter == null)
            return DataSource.Sales.Select(item => item);

        return DataSource.Sales.Where(filter).Select(item => item);
    }

    /// <summary>
    /// עדכון מכירה קיימת ברשימת המכירות, אם לא נמצא מכירה עם אותו id המוצר זורקת חריגה
    /// </summary>
    /// <param name="item"></param>
    /// <exception cref="Exception"></exception>
    public void Update(Sale item)
    {
        var existingSale = DataSource.Sales.FirstOrDefault(s => s != null && s.idProduct == item.idProduct);

        if (existingSale == null)
            throw new Exception("Sale with this id not exists");

        int index = DataSource.Sales.IndexOf(existingSale);
        DataSource.Sales[index] = item;
    }

    /// <summary>
    /// מחיקת מכירה לפי id המוצר, אם לא נמצא זורקת חריגה
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="Exception"></exception>
    public void Delete(int id)
    {
        var sale = DataSource.Sales.FirstOrDefault(s => s != null && s.idProduct == id);

        if (sale == null)
            throw new Exception("Sale with this id not exists"); // תיקנתי את הודעת השגיאה מ-"exists" ל-"not exists"

        DataSource.Sales.Remove(sale);
    }





}

