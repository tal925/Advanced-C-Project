using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;

namespace Dal;

public static class XMLTools
{

    public static void SaveListToXMLSerializer<T>(List<T> list, string entityName) where T : class
    {
        string filePath =$"{entityName}s.xml";
        try
        {
            using FileStream file = new(filePath, FileMode.Create, FileAccess.Write);
            new XmlSerializer(typeof(List<T>), new XmlRootAttribute($"ArrayOf{entityName}")).Serialize(file, list);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to create {filePath} file", ex);
        }
    }

    public static List<T> LoadListFromXMLSerializer<T>(string entityName) where T : class
    {
        string filePath = $@"..\xml\{entityName}s.xml";
        try
        {
            if (!File.Exists(filePath)) return new List<T>();
            using FileStream file = new(filePath, FileMode.Open, FileAccess.Read);
            XmlSerializer x = new(typeof(List<T>), new XmlRootAttribute($"ArrayOf{entityName}"));
            return (List<T>)x.Deserialize(file)!;
        }
        catch (Exception)
        {
            return new List<T>();
        }
    }

    public static int GetAndIncrementNextId(string filePath, string elemName)
    {
        var fullPath = $"{filePath}.xml";
        XElement root = XElement.Load(fullPath);
        int nextId = (int)root.Element(elemName)!;
        root.Element(elemName)!.SetValue(nextId + 1);
        root.Save(fullPath);
        return nextId;
    }
}