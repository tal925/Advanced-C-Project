using BlApi;

namespace BlImplementation;

internal class OrderImplementation : IOrder
{
    
    private static readonly DalApi.IDal _dal = DalApi.Factory.Get;

    //public double GetTotalCartPrice(int orderId)
    //{
    //    // שימוש ב-LINQ כדי לבצע את כל החישוב בשורה אחת קצרה
    //    return _dal.OrderItem.ReadAll(item => item.OrderId == orderId)
    //               .Sum(item => _dal.Product.Read(p => p.id == item.ProductId)?.price * item.Quantity ?? 0);
    //}

    public double CalcTotalPriceForProduct(int productId, int count) => 0;
    public double CalcTotalPrice(BO.Order order) => 0;
    public BO.Order AddProductToOrder(BO.Order order, int productId) => order;
    public void DoOrder(BO.Order order) { }
}