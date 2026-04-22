using BL.BO;
using System;
using System.Collections.Generic;

namespace BO;

public class Order
{
    public int Id { get; set; }
    public DateTime? OrderDate { get; set; }
    public Customer? CustomerDetails { get; set; }
    public IEnumerable<ProductInOrder>? Items { get; set; }
    public double TotalPrice { get; set; }
    public override string ToString() => this.ToStringProperty();
}