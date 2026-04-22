using DalApi;
using Do;
using System.Xml.Linq;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    readonly string s_customers_xml = @"..\xml\customers.xml";

    static Customer CreateFromElement(XElement s) => new Customer(
    (int)s.Element("id")!,
    (string)s.Element("name")!,
    (string)s.Element("adress")!,
    (int)s.Element("phon")!,
    (bool)s.Element("isclob")!
);

    public int Create(Customer item)
    {
        XElement root = XElement.Load(s_customers_xml);
        root.Add(new XElement("Customer",
            new XElement("id", item.id),
            new XElement("name", item.name),
            new XElement("adress", item.adress),
            new XElement("phon", item.phon)
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