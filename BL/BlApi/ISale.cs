using BO;
namespace BlApi;

public interface ISale
{
    public IEnumerable<Sale> GetList();
    public Sale Get(int id);
    public void Add(Sale sale);
    public void Update(Sale sale);
    public void Delete(int id);
}