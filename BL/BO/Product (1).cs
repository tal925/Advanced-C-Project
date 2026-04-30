using BO;
namespace BO;

public class Product
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public Category Category { get; set; }
    public double Price { get; set; }
    public int Amount { get; set; }
    public IEnumerable<SaleInProduct>? Sales { get; set; } 
    public override string ToString() => this.ToStringProperty();
}