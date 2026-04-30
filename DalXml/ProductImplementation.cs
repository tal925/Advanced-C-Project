using DalApi;
using Do;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dal;

internal class ProductImplementation : IProduct
{
    readonly string s_products_xml = "products";

    public int Create(Product item)
    {
        List<Product> products = XMLTools.LoadListFromXMLSerializer<Product>(s_products_xml);

        Product newItem = item with { id = Config.ProductNum };

        products.Add(newItem);
        XMLTools.SaveListToXMLSerializer(products, s_products_xml);

        return newItem.id;
    }

    public Product? Read(int id)
    {
        List<Product> products = XMLTools.LoadListFromXMLSerializer<Product>(s_products_xml);
        return products.FirstOrDefault(p => p.id == id);
    }

    public Product? Read(Func<Product, bool> filter)
    {
        List<Product> products = XMLTools.LoadListFromXMLSerializer<Product>(s_products_xml);
        return products.FirstOrDefault(filter);
    }

    public IEnumerable<Product?> ReadAll(Func<Product?, bool>? filter = null)
    {
        List<Product> products = XMLTools.LoadListFromXMLSerializer<Product>(s_products_xml);
        if (filter == null) return products;
        return products.Where(filter);
    }

    public void Update(Product item)
    {
        List<Product> products = XMLTools.LoadListFromXMLSerializer<Product>(s_products_xml);

        if (products.RemoveAll(p => p.id == item.id) == 0)
            throw new Exception("Product not found");

        products.Add(item);
        XMLTools.SaveListToXMLSerializer(products, s_products_xml);
    }

    public void Delete(int id)
    {
        List<Product> products = XMLTools.LoadListFromXMLSerializer<Product>(s_products_xml);

        if (products.RemoveAll(p => p.id == id) == 0)
            throw new Exception("Product not found");

        XMLTools.SaveListToXMLSerializer(products, s_products_xml);
    }
}public static class Config
{
    private static int _productNum = 1;
    public static int ProductNum => _productNum++;
}
