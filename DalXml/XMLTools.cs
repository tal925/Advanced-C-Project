using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;

namespace Dal;

public static class XMLTools
{
    // Determine xml directory by searching upward from the app base directory.
    private static string GetXmlDir()
    {
        // start from the application's base directory (where the exe runs)
        var dir = AppContext.BaseDirectory;
        for (int i = 0; i < 10; i++)
        {
            var candidate = Path.Combine(dir, "xml");
            if (Directory.Exists(candidate)) return candidate + Path.DirectorySeparatorChar;
            var parent = Directory.GetParent(dir);
            if (parent == null) break;
            dir = parent.FullName;
        }
        // fallback to relative path used previously
        return Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "xml")) + Path.DirectorySeparatorChar;
    }

    public static void SaveListToXMLSerializer<T>(List<T> list, string entityName) where T : class
    {
        var s_xml_dir = GetXmlDir();
        string filePath = Path.Combine(s_xml_dir, $"{entityName}s.xml");
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
        var s_xml_dir = GetXmlDir();
        string filePath = Path.Combine(s_xml_dir, $"{entityName}s.xml");
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
        var s_xml_dir = GetXmlDir();
        var fullPath = Path.Combine(s_xml_dir, $"{filePath}.xml");
        XElement root = XElement.Load(fullPath);
        int nextId = (int)root.Element(elemName)!;
        root.Element(elemName)!.SetValue(nextId + 1);
        root.Save(fullPath);
        return nextId;
    }
}