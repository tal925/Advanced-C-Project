using DalApi;
using DalXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Globalization;
using Do;

namespace Dal
{
    internal class SaleImplementation : ISale
    {
        string path = @"..\xml\sales.xml";
        public int Create(Sale item)
        {
            XElement SaleRoot = XElement.Load(path);
            int id = Config.ProductNum;
            XElement s = new XElement("Sale",
                         new XElement("SaleId", id),
                         new XElement("ProductID", item.idProduct),
                         new XElement("MinProductSale", item.pricesale),
                         new XElement("SumPriceSale", item.count),
                         new XElement("IfEveryOne", item.clob),
                         new XElement("StartrSale", item.start.ToString("dd/MM/yyyy HH:mm:ss")),
                         new XElement("EndSale", item.end.ToString("dd/MM/yyyy HH:mm:ss")));
            SaleRoot.Add(s);
            SaleRoot.Save(path);
            return id;
        }

        public Sale? Read(int id)
        {
            XElement root = XElement.Load(path);
            XElement? s = root.Elements("Sale").FirstOrDefault(x => (int?)x.Element("SaleId") == id);
            if (s == null)
                return null;
            return new Sale
            {
                idProduct = (int)s.Element("SaleId")!,
                //id = (int)s.Element("ProductID")!,
                pricesale = (int)s.Element("MinProductSale")!,
                count = (int)s.Element("SumPriceSale")!,
                clob = (bool)s.Element("IfEveryOne")!,
                start = (DateTime)s.Element("StartrSale")!,
                end = (DateTime)s.Element("EndSale")!
            };
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            return ReadAll().FirstOrDefault(filter);
        }

        public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
        {
            XElement root = XElement.Load(path);
            var list = root.Elements("Sale").Select(s => new Sale
            {
                idProduct = (int)s.Element("SaleId")!,
                //ProductID = (int)s.Element("ProductID")!,
                pricesale = (int)s.Element("MinProductSale")!,
                count = (int)s.Element("SumPriceSale")!,
                clob = (bool)s.Element("IfEveryOne")!,
                start = DateTime.ParseExact(s.Element("StartrSale")!.Value, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                end = DateTime.ParseExact(s.Element("EndSale")!.Value, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
            });

            if (filter == null) return list.ToList();
            return list.Where(filter).ToList();
        }

        public void Update(Sale item)
        {
            XElement root = XElement.Load(path);
            XElement? s = root.Elements("Sale").FirstOrDefault(x => (int?)x.Element("SaleId") == item.idProduct);

            if (s == null) return;

            s.Element("ProductID")!.Value = item.idProduct.ToString();
            s.Element("MinProductSale")!.Value = item.pricesale.ToString();
            s.Element("SumPriceSale")!.Value = item.count.ToString();
            s.Element("IfEveryOne")!.Value = item.clob.ToString().ToLower();
            s.Element("StartrSale")!.Value = item.start.ToString("dd/MM/yyyy HH:mm:ss");
            s.Element("EndSale")!.Value = item.end.ToString("dd/MM/yyyy HH:mm:ss"); root.Save(path);
        }
        public void Delete(int id)
        {
            XElement root = XElement.Load(path);
            XElement? s = root.Elements("Sale").FirstOrDefault(x => (int?)x.Element("SaleId") == id);
            if (s != null)
            {
                s.Remove();
                root.Save(path);
            }
        }

        IEnumerable<Sale?> ICrud<Sale>.ReadAll(Func<Sale, bool>? filter)
        {
            throw new NotImplementedException();
        }
    }
}
