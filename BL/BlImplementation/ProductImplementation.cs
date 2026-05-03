using System;
using System.Collections.Generic;
using System.Linq;
using BO;

namespace BlImplementation;

internal class ProductImplementation : BlApi.IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    /// <summary>
    /// הפעולה הזו מאפשרת לקבל מידע על מוצר קיים ב-BL, היא מקבלת את מזהה המוצר ומנסה לקרוא אותו מ-DAL. אם המוצר לא קיים, היא תזרוק חריגה מתאימה
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    /// <exception cref="BO.BlDoesNotExistException"></exception>
    public BO.Product GetProduct(int Id)
    {
        try
        {
            var doProd = _dal.Product.Read(Id);
            if (doProd == null) throw new BO.BLDoesNotExistException($"Product {Id} not found");

            var bo = doProd.ToBO();

            bo.Sales = from s in _dal.Sale.ReadAll().Where(s => s != null)
                       where s!.idProduct == Id
                       select new BO.SaleInProduct
                       {
                           SaleID = s!.idProduct,
                           AmountForSale = s.count,
                           SalePrice = s.pricesale,
                           IsForClub = s.clob
                       };

            return bo;
        }
        catch (Exception ex)
        {
            throw new BO.BLDoesNotExistException($"Product {Id} not found", ex);
        }
    }
    /// <summary>
    /// הפעולה הזו מאפשרת לקבל רשימה של כל המוצרים הקיימים ב-BL, היא קוראת את כל המוצרים מ-DAL וממירה אותם לאובייקטים של מוצר ב-BL. אם אין מוצרים, היא תחזיר רשימה ריקה
    /// </summary>
    /// <returns></returns>
    public IEnumerable<BO.Product> GetList()
    {
        return _dal.Product.ReadAll().Where(p => p != null).Select(p => p!.ToBO());
    }
    /// <summary>
    /// הפעולה הזו מאפשרת להוסיף מוצר חדש ל-BL, היא מקבלת אובייקט של מוצר ומנסה ליצור אותו ב-DAL. אם המוצר כבר קיים, היא תזרוק חריגה מתאימה
    /// </summary>
    /// <param name="product"></param>
    /// <exception cref="BO.BlAlreadyExistsException"></exception>
    public void Add(BO.Product product)
    {
        try
        {
            _dal.Product.Create(product.ToDO());
        }
        catch (Exception ex)
        {
            throw new BO.BLDoesNotExistException($"Product {product.ID} already exists", ex);
        }
    }
    /// <summary>
    /// הפעולה הזו מאפשרת לעדכן מידע על מוצר קיים ב-BL, היא מקבלת אובייקט של מוצר ומנסה לעדכן אותו ב-DAL. אם המוצר לא קיים, היא תזרוק חריגה מתאימה
    /// </summary>
    /// <param name="product"></param>
    /// <exception cref="BO.BlDoesNotExistException"></exception>
    public void Update(BO.Product product)
    {
        try
        {
            _dal.Product.Update(product.ToDO());
        }
        catch (Exception ex)
        {
            throw new BO.BLDoesNotExistException($"Product {product.ID} not found", ex);
        }
    }

    public void Delete(int id)
    {
        try { _dal.Product.Delete(id); }
        catch (Exception ex) { throw new BO.BLDoesNotExistException($"Delete failed for {id}", ex); }
    }
    /// <summary>
    ///     הפעולה הזו מאפשרת לחפש אם יש מכירה קיימת עבור מוצר מסוים, היא מקבלת את מזהה המוצר ומנסה לקרוא את המכירה מ-DAL. אם אין מכירה עבור המוצר, היא תחזיר null
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    public BO.SaleInProduct? SearchSaleForProduct(int productId)
    {
        return (from s in _dal.Sale.ReadAll()
                where s.idProduct == productId
                select new BO.SaleInProduct
                {
                    SaleID = s.idProduct,
                    AmountForSale = s.count,
                    SalePrice = s.pricesale,
                    IsForClub = s.clob
                }).FirstOrDefault();
    }
}