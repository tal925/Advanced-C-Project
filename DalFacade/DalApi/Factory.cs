using System;
using System.Reflection;

namespace DalApi;

// השורה הזו מחברת בין הממשק למימוש בפועל
public static class Factory
{
    public static IDal Get
    {
        get
        {
            // Load the implementation by name at runtime to avoid a compile-time dependency on the DalList assembly.
            const string implType = "DalList.DalList, DalList";
            var type = Type.GetType(implType);
            if (type == null)
            {
                throw new InvalidOperationException($"Implementation '{implType}' not found. Ensure the DalList assembly is available.");
            }

            var prop = type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static);
            if (prop == null)
            {
                throw new InvalidOperationException("Static 'Instance' property not found on DalList.DalList.");
            }

            var instance = prop.GetValue(null);
            if (instance is IDal dal) return dal;

            throw new InvalidCastException("DalList.Instance does not implement IDal.");
        }
    }
}