using BO;
namespace BlApi;

public interface IProduct
{
    public IEnumerable<Product> GetList();
    public Product GetProduct(int id);
    public void Add(Product product);
    public void Update(Product product);
    public void Delete(int id);
    public SaleInProduct? SearchSaleForProduct(int productId);
}