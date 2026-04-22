using System.Reflection;
using System.Collections;
using System.Linq;
using BO;
namespace BL.BO;

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
                    result += $"   {item}\n"; // כניסה לעומק התכונות
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

    // פונקציות המרה כמתודות הרחבה כפי שנדרש בסעיף 4

    // --- Product ---
    public static Product ToBO(this Product doObj)
    {
        var boObj = new Product();
        CopyProperties(doObj, boObj);
        return boObj;
    }

    public static Product ToDO(this Product boObj)
    {
        var doObj = new Product();
        CopyProperties(boObj, doObj);
        return doObj;
    }

    // --- Customer ---
    public static Customer ToBO(this Customer doObj)
    {
        var boObj = new Customer();
        CopyProperties(doObj, boObj);
        return boObj;
    }

    public static Customer ToDO(this Customer boObj)
    {
        var doObj = new Customer();
        CopyProperties(boObj, doObj);
        return doObj;
    }

    // --- Sale ---
    public static Sale ToBO(this Sale doObj)
    {
        var boObj = new Sale();
        CopyProperties(doObj, boObj);
        return boObj;
    }

    public static Sale ToDO(this Sale boObj)
    {
        var doObj = new Sale();
        CopyProperties(boObj, doObj);
        return doObj;
    }
    
}