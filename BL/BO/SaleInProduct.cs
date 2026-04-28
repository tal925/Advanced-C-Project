using BO;

namespace BO;

public class SaleInProduct
{
    public int SaleID { get; set; }
    public int AmountForSale { get; set; }
    public double SalePrice { get; set; }
    public bool IsForClub { get; set; }

    public override string ToString() => this.ToStringProperty();
}