namespace BlApi;

public interface IBl
{
    /// <summary>
    /// המחלקה הזו היא מחלקת הפקטורי של ה-BL, היא מחזירה מופעים של כל המחלקות ב-BL
    /// </summary>
    public ICustomer Customer { get; }
    public IProduct Product { get; }
    public ISale Sale { get; }
    public IOrder Order { get; }
}