using DalApi;
using DalXml;
using Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Dal;

internal class ProductImplementation : IProduct
{
    // נתיב לקובץ ה-XML כפי שהגדרת
    string s_products_xml = @"..\xml\products.xml";

    public int Create(Product item)
    {
        XElement productRoot = XElement.Load(s_products_xml);

        // שימוש ב-Config לקבלת מזהה חדש
        int newId = Config.ProductNum;

        XElement p = new XElement("Product",
            new XElement("id", newId),
            new XElement("name", item.name),
            new XElement("category", item.category),
            new XElement("price", item.price),
            new XElement("amount", item.amount));

        productRoot.Add(p);
        productRoot.Save(s_products_xml);
        return newId;
    }

    public Product? Read(int id)
    {
        XElement root = XElement.Load(s_products_xml);
        XElement? p = root.Elements("Product").FirstOrDefault(x => (int?)x.Element("id") == id);

        if (p == null) return null;

        return new Product(
            (int)p.Element("id")!,
            (string)p.Element("name")!,
            (category)Enum.Parse(typeof(category), (string)p.Element("category")!),
            (double)p.Element("price")!,
            (int)p.Element("amount")!
        );
    }

    public Product? Read(Func<Product, bool> filter)
    {
        return ReadAll().FirstOrDefault(filter!);
    }

    public IEnumerable<Product?> ReadAll(Func<Product?, bool>? filter = null)
    {
        XElement root = XElement.Load(s_products_xml);

        var list = root.Elements("Product").Select(p => new Product(
            (int)p.Element("id")!,
            (string)p.Element("name")!,
            (category)Enum.Parse(typeof(category), (string)p.Element("category")!),
            (double)p.Element("price")!,
            (int)p.Element("amount")!
        ));

        if (filter == null) return list;
        return list.Where(filter);
    }

    public void Update(Product item)
    {
        XElement root = XElement.Load(s_products_xml);
        XElement? p = root.Elements("Product").FirstOrDefault(x => (int?)x.Element("id") == item.id);

        if (p == null) throw new Exception("Product not found");

        p.Element("name")!.Value = item.name;
        p.Element("category")!.Value = item.category.ToString();
        p.Element("price")!.Value = item.price.ToString();
        p.Element("amount")!.Value = item.amount.ToString();

        root.Save(s_products_xml);
    }

    public void Delete(int id)
    {
        XElement root = XElement.Load(s_products_xml);
        XElement? p = root.Elements("Product").FirstOrDefault(x => (int?)x.Element("id") == id);

        if (p == null) throw new Exception("Product not found");

        p.Remove();
        root.Save(s_products_xml);
    }
}