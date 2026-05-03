using DalApi;
using Do;
using System.Xml.Linq;
using System.IO;

namespace Dal;

    internal class CustomerImplementation : ICustomer
    {
        // Resolve xml path relative to the running executable, searching upward for an 'xml' folder
        private static string GetXmlDir()
        {
            var dir = AppContext.BaseDirectory;
            for (int i = 0; i < 10; i++)
            {
                var candidate = Path.Combine(dir, "xml");
                if (Directory.Exists(candidate)) return candidate;
                var parent = Directory.GetParent(dir);
                if (parent == null) break;
                dir = parent.FullName;
            }
            return Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "xml"));
        }

        readonly string s_customers_xml = Path.Combine(GetXmlDir(), "customers.xml");

    static Customer CreateFromElement(XElement s)
    {
        int id = (int?)s.Element("id") ?? 0;
        string name = (string?)s.Element("name") ?? string.Empty;
        string adress = (string?)s.Element("adress") ?? string.Empty;
        int phon = 0;
        if (s.Element("phon") != null) int.TryParse(s.Element("phon")!.Value, out phon);
        bool isclob = false;
        if (s.Element("isclob") != null) bool.TryParse(s.Element("isclob")!.Value, out isclob);
        return new Customer(id, name, adress, phon, isclob);
    }

    public int Create(Customer item)
    {
        XElement root = XElement.Load(s_customers_xml);
        root.Add(new XElement("Customer",
            new XElement("id", item.id),
            new XElement("name", item.name),
            new XElement("adress", item.adress),
            new XElement("phon", item.phon),
            new XElement("isclob", item.isclob)
        ));
        root.Save(s_customers_xml);
        return item.id;
    }

    public Customer? Read(int id)
    {
        XElement root = XElement.Load(s_customers_xml);
        return (from s in root.Elements()
                where (int)s.Element("id")! == id
                select CreateFromElement(s)).FirstOrDefault();
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        XElement root = XElement.Load(s_customers_xml);
        return root.Elements().Select(s => CreateFromElement(s)).FirstOrDefault(filter);
    }

    public IEnumerable<Customer?> ReadAll(Func<Customer?, bool>? filter = null)
    {
        XElement root = XElement.Load(s_customers_xml);
        var list = root.Elements().Select(s => (Customer?)CreateFromElement(s));
        return filter == null ? list : list.Where(filter);
    }

    public void Update(Customer item)
    {
        XElement root = XElement.Load(s_customers_xml);
        XElement? elem = root.Elements().FirstOrDefault(s => (int)s.Element("id")! == item.id);

        if (elem == null) throw new Exception("Customer not found");

        elem.Element("name")!.SetValue(item.name);
        elem.Element("adress")!.SetValue(item.adress);
        elem.Element("phon")!.SetValue(item.phon);

        root.Save(s_customers_xml);
    }

    public void Delete(int id)
    {
        XElement root = XElement.Load(s_customers_xml);
        XElement? elem = root.Elements().FirstOrDefault(s => (int)s.Element("id")! == id);

        if (elem == null) throw new Exception("Customer not found");

        elem.Remove();
        root.Save(s_customers_xml);
    }
}