using System;
using System.Collections.Generic;
using System.Linq;
using BO;

namespace BlImplementation;

internal class SaleImplementation : BlApi.ISale
{
    readonly DalApi.IDal _dal = DalApi.Factory.Get;
    /// <summary>
    ///     הפעולה הזו מאפשרת להוסיף מבצע חדש ל-BL, היא מקבלת אובייקט של מבצע ומנסה ליצור אותו ב-DAL. אם המבצע כבר קיים, היא תזרוק חריגה מתאימה
    /// </summary>
    /// <param name="sale"></param>
    /// <exception cref="BO.BlAlreadyExistsException"></exception>
    public void Add(BO.Sale sale)
    {
        try
        {
            _dal.Sale.Create(sale.ToDO());
        }
        catch (Exception ex)
        {
            throw new BO.BlAlreadyExistsException($"Sale for product {sale.ProductID} already exists", ex);
        }
    }
    /// <summary>
    /// הפעולה הזו מאפשרת לעדכן מבצע קיים ב-BL, היא מקבלת אובייקט של מבצע ומנסה לעדכן אותו ב-DAL. אם המבצע לא קיים, היא תזרוק חריגה מתאימה
    /// </summary>
    /// <param name="sale"></param>
    /// <exception cref="BO.BlDoesNotExistException"></exception>
    public void Update(BO.Sale sale)
    {
        try
        {
            _dal.Sale.Update(sale.ToDO());
        }
        catch (Exception ex)
        {
            throw new BO.BlDoesNotExistException("Update failed - sale not found", ex);
        }
    }
    /// <summary>
    ///     הפעולה הזו מאפשרת לקבל מידע על מבצע קיים ב-BL, היא מקבלת את מזהה המבצע ומנסה לקרוא אותו מ-DAL. אם המבצע לא קיים, היא תזרוק חריגה מתאימה
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="BO.BlDoesNotExistException"></exception>
    public BO.Sale Get(int id)
    {
        try
        {
            var s = _dal.Sale.Read(id);
            if (s == null) throw new BO.BlDoesNotExistException($"Sale {id} not found");
            return s.ToBO();
        }
        catch (Exception ex)
        {
            throw new BO.BlDoesNotExistException("Sale not found", ex);
        }
    }
    /// <summary>
    ///    הפעולה הזו מאפשרת לקבל רשימה של כל המבצעים הקיימים ב-BL, היא קוראת את כל המבצעים מ-DAL וממירה אותם לאובייקטים של מבצע ב-BL. אם אין מבצעים, היא תחזיר רשימה ריקה
    /// </summary>
    /// <returns></returns>
    public IEnumerable<BO.Sale> GetList()
    {
        return _dal.Sale.ReadAll().Select(s => new BO.Sale
        {
            ProductID = s.idProduct,
            Count = s.count,
            PriceSale = s.pricesale,
            IsClubMember = s.clob,
            StartDate = s.start,
            EndDate = s.end
        });
    }
    /// <summary>
    ///   הפעולה הזו מאפשרת למחוק מבצע קיים ב-BL, היא מקבלת את מזהה המבצע ומנסה למחוק אותו ב-DAL. אם המבצע לא קיים, היא תזרוק חריגה מתאימה
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="BO.BlDoesNotExistException"></exception>
    public void Delete(int id)
    {
        try { _dal.Sale.Delete(id); }
        catch (Exception ex) { throw new BO.BlDoesNotExistException("Sale not found", ex); }
    }
}