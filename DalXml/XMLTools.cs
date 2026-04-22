using System.Xml.Serialization;
using System.Xml.Linq;

namespace Dal;

public static class XMLTools
{
    const string s_xml_dir = @"..\xml\";

    public static void SaveListToXMLSerializer<T>(List<T> list, string entityName) where T : class
    {
        string filePath = $"{s_xml_dir}{entityName}s.xml";
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
        string filePath = $"{s_xml_dir}{entityName}s.xml";
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
        XElement root = XElement.Load($@"{s_xml_dir}{filePath}.xml");
        int nextId = (int)root.Element(elemName)!;
        root.Element(elemName)!.SetValue(nextId + 1);
        root.Save($@"{s_xml_dir}{filePath}.xml");
        return nextId;
    }
}