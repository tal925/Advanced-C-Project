using BO;
namespace BlApi;

public interface IOrder
{
    // Add product to order with amount, returns list of applied sales for the added product
    public List<BO.SaleInProduct> AddProductToOrder(Order order, int productId, int amount);

    // search and apply sales for a product in an order
    public void SearchSaleForProduct(ProductInOrder productInOrder, bool ifFavorite);

    // calculate final price for a product in order
    public void CalcTotalPriceForProduct(ProductInOrder productInOrder);

    // calculate total price for the order
    public void CalcTotalPrice(Order order);

    // finalize order and update stock
    public void DoOrder(Order order);

}
