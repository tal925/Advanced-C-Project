using Dal;
using DalApi;

namespace DalList; 

public class DalList : IDal
{
 
    public static IDal Instance { get; } = new DalList();
    public ICustomer customer => new CastemerImplementation();
    public IProduct Product => new ProdactImplementation();
    public ISale Sale => new SaleImplementation();
    private DalList() { }
}