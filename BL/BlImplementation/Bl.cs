using System;

namespace BlImplementation;

internal class Bl : BlApi.IBl
{
    //readonly DalApi.IDal dal = DalApi.Factory.Get;

    public BlApi.ICustomer Customer => new CustomerImplementation();
    public BlApi.IProduct Product => new ProductImplementation();
    public BlApi.IOrder Order => new OrderImplementation();
    public BlApi.ISale Sale => new SaleImplementation();
}