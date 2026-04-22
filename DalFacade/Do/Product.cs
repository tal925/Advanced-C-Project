using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do;
//מייצג מוצר בחנות
public record Product(int id, string name, category category,double price,int amount)
{
 //בנאי התחלתי
    public Product() : this(123, "aaa", category.Coffy, 102.5,45) { }
}
