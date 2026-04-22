using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do;
//מייצג מבצע
public record Sale(int idProduct, int count,double pricesale,bool clob,DateTime start,DateTime end)
{
    public Sale() : this(5, 2, 100.5, true, DateTime.Now, DateTime.Today) { }
}
