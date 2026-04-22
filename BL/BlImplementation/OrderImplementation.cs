using BlApi;
using BO;
using System.Collections.Generic;
using System.Linq;
using System;

namespace BlImplementation;

internal class OrderImplementation : IOrder
{
    private static readonly DalApi.IDal _dal = DalApi.Factory.Get;

    // מימושים 
    public double CalcTotalPriceForProduct(int productId, int count) => 0;
    public double CalcTotalPrice(BO.Order order) => 0;
    public BO.Order AddProductToOrder(BO.Order order, int productId) => order;
    public void DoOrder(BO.Order order) { }
}