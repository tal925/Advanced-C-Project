using BO;
namespace BlApi;

public interface IOrder
{
    public double CalcTotalPriceForProduct(int productId, int count);
    public double CalcTotalPrice(Order order);
    public Order AddProductToOrder(Order order, int productId);
    public void DoOrder(Order order);
    //double GetTotalCartPrice(int orderId); 
}