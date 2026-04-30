using BO;
namespace BlApi;

public interface ICustomer
{/// <summary>
/// מחלקה זו מגדירה את הפעולות שניתן לבצע על לקוחות ב-BL, היא כוללת פעולות CRUD (יצירה, קריאה, עדכון ומחיקה) ללקוחות
/// </summary>
/// <returns></returns>
    public IEnumerable<Customer> GetList();
    public Customer Get(int id);
    public void Add(Customer customer);
    public void Update(Customer customer);
    public void Delete(int id);
}