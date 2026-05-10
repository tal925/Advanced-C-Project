using BlApi;

namespace BlImplementation;

internal class OrderImplementation : IOrder
{
    
    private static readonly DalApi.IDal _dal = DalApi.Factory.Get;

    ///  הוספת מוצר להזמנה
    ///  מקבלת ID של מוצר
    ///  כמות של מוצר
    ///  ואת ההזמנה שאליה להוסיף את המוצר
    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int id, int amount)
    {
        // 1. שליפת המוצר מה-DAL 
        Do.Product? doProduct;
        try
        {
            doProduct = _dal.Product.Read(id);
            if (doProduct == null)
                throw new BO.BLDoesNotExistException($"מוצר עם ברקוד {id} לא נמצא במערכת.");
        }
        catch (Exception ex)
        {
            throw new BO.BLDoesNotExistException($"שגיאה בגישה לנתוני מוצר {id}", ex);
        }

        // 2. טיפול ברשימת הפריטים בהזמנה
        //יצירת רשימה של הזמנות עם הפריט החדש
        if (order.Items == null) order.Items = new List<BO.ProductInOrder>();

        //שליפת המוצר מהרשימה
        var productInOrder = order.Items.FirstOrDefault(p => p.ProductID == id);

        // אם המוצר לא נמצא ברשימה
        if (productInOrder == null)
        {
            // הוספת מוצר חדש לסל
            productInOrder = new BO.ProductInOrder
            {
                ProductID = id,
                Name = doProduct.name,
                BasePrice = doProduct.price,
                Amount = amount,
                listOperation = new List<BO.SaleInProduct>()
            };
            order.Items.Add(productInOrder);
        }
        else
        {
            // עדכון כמות למוצר קיים
            productInOrder.Amount += amount;

            // אם הכמות התאפסה או הפכה לשלילית - הסרה מהסל
            if (productInOrder.Amount <= 0)
            {
                order.Items.Remove(productInOrder);
                CalcTotalPrice(order);
                //החזרת רשימת מבצעים ריקה
                return new List<BO.SaleInProduct>();
            }
        }

        //  חישוב מבצעים ועדכון מחירים    
        SearchSaleForProduct(productInOrder, order.ifFavorite);
        CalcTotalPriceForProduct(productInOrder);

        // עדכון סה"כ לתשלום של כל ההזמנה
        CalcTotalPrice(order);

        return productInOrder.listOperation;
    }

    public void SearchSaleForProduct(BO.ProductInOrder productInOrder, bool ifFavorite)
    {
        // אתחול רשימת המבצעים שמומשו
        productInOrder.listOperation = new List<BO.SaleInProduct>();

        //שליפת כל המבצעים הקשורים למוצר זה
        var relevantSales = _dal.Sale.ReadAll(s => s.idProduct == productInOrder.ProductID);

        //מעבר על רשימת המבצעים
        foreach (var sale in relevantSales)
        {
            // בדיקה אם המבצע בתוקף
            if (DateTime.Now >= sale.start && DateTime.Now <= sale.end)
            {
                // בדיקה אם המבצע מוגבל לחברי מועדון והאם הלקוח כזה
                if (!sale.clob || ifFavorite)
                {
                    // בדיקה אם יש מספיק כמות למימוש המבצע
                    if (productInOrder.Amount >= sale.count)
                    {
                        //כמות הפעמים שלהקוח יקבל את הנחת המבצע
                        int timesToApply = productInOrder.Amount / sale.count;

                        // יצירת אובייקט המייצג מימוש של מבצע והוספתו לרשימת המבצעים הפעילים על המוצר
                        productInOrder.listOperation.Add(new BO.SaleInProduct
                        {
                            SaleID = sale.idProduct,
                            AmountForSale = timesToApply,
                            SalePrice = sale.pricesale,
                            IsForClub = sale.clob
                        });
                    }
                }
            }
        }
    }
   
    /// <param name="productInOrder"></param>
    public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
    {
        int remainingAmount = productInOrder.Amount;
        double total = 0;

        // חישוב המבצעים
        foreach (var appliedSale in productInOrder.listOperation)
        {
            // שליפת נתוני המבצע המקורי כדי לדעת כמה יחידות הוא "אוכל"
            var originalSale = _dal.Sale.Read(appliedSale.SaleID);
            if (originalSale != null)
            {
                //חישוב הסכום הטוטאלי של ההנחה- כמות הפעמים שהיתה ההנחה כפול מחיר ההנחה
                total += appliedSale.AmountForSale * appliedSale.SalePrice;
                // עדכון המוצרים שעדיין לא שילמו עליהם הם נמצאים ב-remainingAmount 
                remainingAmount -= (appliedSale.AmountForSale * originalSale.count);
            }
        }

        // הוספת השארית במחיר מלא
        total += remainingAmount * productInOrder.BasePrice;
        //עדכון המחיר הסופי
        productInOrder.FinalPrice = total;
    }

    public void CalcTotalPrice(BO.Order order)
    {
        order.TotalPrice = order.Items?.Sum(i => i.FinalPrice) ?? 0;
    }

    //עדכון המלאי בחנות לאחר ביצוע הזמנה
    public void DoOrder(BO.Order order)
    {
        if (order.Items == null) return;

        foreach (var item in order.Items)
        {
            var doProduct = _dal.Product.Read(item.ProductID);
            if (doProduct != null)
            {
                // עדכון מלאי ב-DAL 
                var updatedProduct = doProduct with { amount = doProduct.amount - item.Amount };
                _dal.Product.Update(updatedProduct);
            }
        }
    }  
}