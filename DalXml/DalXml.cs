using DalApi;
namespace Dal;

sealed internal class DalXml : IDal
{
    private static readonly DalXml instance = new DalXml();

    public static DalXml Instance => instance;

    private DalXml() { }

    public IProduct Product => new ProductImplementation();
    public ICustomer customer => new CustomerImplementation();
    public ISale Sale => new SaleImplementation();
}