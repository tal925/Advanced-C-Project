
namespace DalApi
{
    public interface IDal
    { 
        ICustomer customer { get; }
        IProduct Product { get; } 
        ISale Sale { get; }
    }
}
