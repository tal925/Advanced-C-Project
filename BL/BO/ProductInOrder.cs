using BO;

namespace BO;

public class ProductInOrder
{
    public int ProductID { get; set; }
    public string? Name { get; set; }
    public double BasePrice { get; set; }
    public int Amount { get; set; }
    public double FinalPrice { get; set; }
    public List<BO.SaleInProduct> listOperation { get; set; }
    public override string ToString() => this.ToStringProperty();
}