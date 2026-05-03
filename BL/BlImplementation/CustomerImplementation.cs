using System;
using System.Collections.Generic;
using System.Linq;
using BO;

namespace BlImplementation;
/// <summary>
/// מחלקה זו מגדירה את הפעולות שניתן לבצע על לקוחות ב-BL, היא כוללת פעולות CRUD (יצירה, קריאה, עדכון ומחיקה) ללקוחות
/// </summary>
internal class CustomerImplementation : BlApi.ICustomer
{
    private readonly DalApi.IDal _dal = DalApi.Factory.Get;
    /// <summary>
    /// הפעולה הזו מאפשרת להוסיף לקוח חדש ל-BL, היא מקבלת אובייקט של לקוח ומנסה ליצור אותו ב-DAL. אם הלקוח כבר קיים, היא תזרוק חריגה מתאימה
    /// </summary>
    /// <param name="customer"></param>
    /// <exception cref="BO.BlAlreadyExistsException"></exception>
    public void Add(BO.Customer customer)
    {
        try
        {
            _dal.customer.Create(customer.ToDO());
        }
        catch (Exception ex)
        {
            throw new BO.BLDoesNotExistException($"Customer {customer.ID} already exists", ex);
        }
    }
    /// <summary>
    /// הפעולה הזו מאפשרת למחוק לקוח קיים ב-BL, היא מקבלת את מזהה הלקוח ומנסה למחוק אותו ב-DAL. אם הלקוח לא קיים, היא תזרוק חריגה מתאימה
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="BO.BlDoesNotExistException"></exception>
    public void Delete(int id)
    {
        try { _dal.customer.Delete(id); }
        catch (Exception ex) { throw new BO.BLDoesNotExistException($"Customer {id} not found", ex); }
    }
    /// <summary>
    /// הפעולה הזו מאפשרת לקבל מידע על לקוח קיים ב-BL, היא מקבלת את מזהה הלקוח ומנסה לקרוא אותו מ-DAL. אם הלקוח לא קיים, היא תזרוק חריגה מתאימה
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="BO.BlDoesNotExistException"></exception>
    public BO.Customer Get(int id)
    {
        try
        {
            var c = _dal.customer.Read(id);
            if (c == null) throw new BO.BLDoesNotExistException($"Customer {id} not found");
            return c.ToBO();
        }
        catch (Exception ex) { throw new BO.BLDoesNotExistException("Not found", ex); }
    }
    /// <summary>
    /// הפעולה הזו מאפשרת לקבל רשימה של כל הלקוחות הקיימים ב-BL, היא קוראת את כל הלקוחות מ-DAL וממירה אותם לאובייקטים של לקוח ב-BL. אם אין לקוחות, היא תחזיר רשימה ריקה
    /// </summary>
    /// <returns></returns>
    public IEnumerable<BO.Customer> GetList()
    {
        return _dal.customer.ReadAll().Where(c => c != null).Select(c => c!.ToBO());
    }
    /// <summary>
    /// הפעולה הזו מאפשרת לעדכן מידע על לקוח קיים ב-BL, היא מקבלת אובייקט של לקוח ומנסה לעדכן אותו ב-DAL. אם הלקוח לא קיים, היא תזרוק חריגה מתאימה
    /// </summary>
    /// <param name="customer"></param>
    /// <exception cref="BO.BlDoesNotExistException"></exception>
    public void Update(BO.Customer customer)
    {
        try
        {
            _dal.customer.Update(customer.ToDO());
        }
        catch (Exception ex) { throw new BO.BLDoesNotExistException("Update failed", ex); }
    }

    /// בדיקה האם לקוח קיים במערכת
    public bool ExistingCustomer(int id)
    {
        return _dal.customer.Read(id) != null;
    }

}