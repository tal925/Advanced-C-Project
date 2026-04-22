using DalApi;
using Do;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dal;

internal class SaleImplementation : ISale
{
    readonly string s_sales_xml = "sales";

    public int Create(Sale item)
    {
        List<Sale> sales = XMLTools.LoadListFromXMLSerializer<Sale>(s_sales_xml);

        Sale newItem = item with { idProduct = Config.SaleNum };

        sales.Add(newItem);
        XMLTools.SaveListToXMLSerializer(sales, s_sales_xml);

        return newItem.idProduct;
    }

    public Sale? Read(int id)
    {
        List<Sale> sales = XMLTools.LoadListFromXMLSerializer<Sale>(s_sales_xml);
        return sales.FirstOrDefault(s => s.idProduct == id);
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        List<Sale> sales = XMLTools.LoadListFromXMLSerializer<Sale>(s_sales_xml);
        return sales.FirstOrDefault(filter);
    }

    public IEnumerable<Sale?> ReadAll(Func<Sale?, bool>? filter = null)
    {
        List<Sale> sales = XMLTools.LoadListFromXMLSerializer<Sale>(s_sales_xml);
        if (filter == null) return sales;
        return sales.Where(filter);
    }

    public void Update(Sale item)
    {
        List<Sale> sales = XMLTools.LoadListFromXMLSerializer<Sale>(s_sales_xml);
        if (sales.RemoveAll(s => s.idProduct == item.idProduct) == 0)
            throw new Exception("Sale not found");

        sales.Add(item);
        XMLTools.SaveListToXMLSerializer(sales, s_sales_xml);
    }

    public void Delete(int id)
    {
        List<Sale> sales = XMLTools.LoadListFromXMLSerializer<Sale>(s_sales_xml);
        if (sales.RemoveAll(s => s.idProduct == id) == 0)
            throw new Exception("Sale not found");

        XMLTools.SaveListToXMLSerializer(sales, s_sales_xml);
    }
}