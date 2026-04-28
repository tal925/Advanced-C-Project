using System;
using System.Collections.Generic;
using System.Linq;
using BO;

namespace BlImplementation;

internal class ProductImplementation : BlApi.IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public BO.Product GetProduct(int Id)
    {
        try
        {
            var doProd = _dal.Product.Read(Id);
            if (doProd == null) throw new BO.BlDoesNotExistException($"Product {Id} not found");

            var bo = doProd.ToBO();

            bo.Sales = from s in _dal.Sale.ReadAll().Where(s => s != null)
                       where s!.idProduct == Id
                       select new BO.SaleInProduct
                       {
                           SaleID = s!.idProduct,
                           AmountForSale = s.count,
                           SalePrice = s.pricesale,
                           IsForClub = s.clob
                       };

            return bo;
        }
        catch (Exception ex)
        {
            throw new BO.BlDoesNotExistException($"Product {Id} not found", ex);
        }
    }

    public IEnumerable<BO.Product> GetList()
    {
        return _dal.Product.ReadAll().Where(p => p != null).Select(p => p!.ToBO());
    }

    public void Add(BO.Product product)
    {
        try
        {
            _dal.Product.Create(product.ToDO());
        }
        catch (Exception ex)
        {
            throw new BO.BlAlreadyExistsException($"Product {product.ID} already exists", ex);
        }
    }

    public void Update(BO.Product product)
    {
        try
        {
            _dal.Product.Update(product.ToDO());
        }
        catch (Exception ex)
        {
            throw new BO.BlDoesNotExistException($"Product {product.ID} not found", ex);
        }
    }

    public void Delete(int id)
    {
        try { _dal.Product.Delete(id); }
        catch (Exception ex) { throw new BO.BlDoesNotExistException($"Delete failed for {id}", ex); }
    }

    public BO.SaleInProduct? SearchSaleForProduct(int productId)
    {
        return (from s in _dal.Sale.ReadAll()
                where s.idProduct == productId
                select new BO.SaleInProduct
                {
                    SaleID = s.idProduct,
                    AmountForSale = s.count,
                    SalePrice = s.pricesale,
                    IsForClub = s.clob
                }).FirstOrDefault();
    }
}