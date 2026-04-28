using System;
using System.Reflection;
using System.Collections;
using System.Linq;
using Do;
using BO;

namespace BO;

internal static class Tools
{
    /// <summary>
    /// מתודת הרחבה שחוקרת אובייקט בזמן ריצה ומחזירה מחרוזת של כל תכונותיו.
    /// מטפלת גם בתכונות שהן אוסף (IEnumerable) כפי שנדרש.
    /// </summary>
    public static string ToStringProperty<T>(this T obj)
    {
        if (obj == null) return "";

        string result = "";
        // מעבר על כל התכונות של האובייקט בעזרת Reflection
        foreach (PropertyInfo prop in obj.GetType().GetProperties())
        {
            var value = prop.GetValue(obj, null);

            // בדיקה האם התכונה היא אוסף (ואינה מחרוזת)
            if (value is IEnumerable list && !(value is string))
            {
                result += $"{prop.Name}: \n";
                foreach (var item in list)
                {
                    result += $"   {item}\n";
                }
            }
            else
            {
                result += $"{prop.Name}: {value}\n";
            }
        }
        return result;
    }

    /// <summary>
    /// מתודת עזר להעתקת מאפיינים בעלי שם זהה בין אובייקטים משכבות שונות
    /// (נשמרת כעוד אופציה - לא כל המיפויים מסתמכים עליה בגלל שמות מאפיינים שונים)
    /// </summary>
    private static void CopyProperties(object source, object target)
    {
        var targetProps = target.GetType().GetProperties();
        foreach (var sp in source.GetType().GetProperties())
        {
            var tp = targetProps.FirstOrDefault(p => p.Name == sp.Name && p.CanWrite);
            if (tp != null)
            {
                var value = sp.GetValue(source);
                // טיפול בהמרת Enum במידה והטיפוסים שונים אך השמות זהים
                if (tp.PropertyType.IsEnum && value != null)
                    tp.SetValue(target, Enum.ToObject(tp.PropertyType, value));
                else
                    tp.SetValue(target, value);
            }
        }
    }

    // --- Product conversions ---
    public static Product ToBO(this Do.Product doObj)
    {
        if (doObj == null) return null!;
        return new Product
        {
            ID = doObj.id,
            Name = doObj.name,
            Price = doObj.price,
            Amount = doObj.amount,
            Category = (Category)doObj.category
        };
    }

    public static Do.Product ToDO(this Product boObj)
    {
        if (boObj == null) throw new ArgumentNullException(nameof(boObj));
        return new Do.Product(boObj.ID, boObj.Name ?? "", (Do.category)boObj.Category, boObj.Price, boObj.Amount);
    }

    // --- Customer conversions ---
    public static Customer ToBO(this Do.Customer customer)
    {
        if (customer == null) return null!;
        return new Customer
        {
            ID = customer.id,
            Name = customer.name,
            Address = customer.adress,
            Phone = customer.phon.ToString(),
            IsClubMember = customer.isclob
        };
    }

    public static Do.Customer ToDO(this Customer customer)
    {
        if (customer == null) throw new ArgumentNullException(nameof(customer));
        int phone = 0;
        if (!string.IsNullOrWhiteSpace(customer.Phone))
            int.TryParse(customer.Phone, out phone);

        return new Do.Customer(customer.ID, customer.Name ?? "", customer.Address ?? "", phone, customer.IsClubMember);
    }

    // --- Sale conversions ---
    public static Sale ToBO(this Do.Sale doObj)
    {
        if (doObj == null) return null!;
        return new Sale
        {
            ProductID = doObj.idProduct,
            Count = doObj.count,
            PriceSale = doObj.pricesale,
            IsClubMember = doObj.clob,
            StartDate = doObj.start,
            EndDate = doObj.end
        };
    }

    public static Do.Sale ToDO(this Sale boObj)
    {
        if (boObj == null) throw new ArgumentNullException(nameof(boObj));
        return new Do.Sale(boObj.ProductID, boObj.Count, boObj.PriceSale, boObj.IsClubMember, boObj.StartDate, boObj.EndDate);
    }
}