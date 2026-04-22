using BL.BO;
using System;
using System.Collections.Generic;

namespace BO;

public class Sale
{
    public int ProductID { get; set; }
    public int Count { get; set; }
    public double PriceSale { get; set; }
    public bool IsClubMember { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public IEnumerable<SaleInProduct>? Sales { get; set; }

    public override string ToString() => this.ToStringProperty();
}