using System;
using System.Collections.Generic;
using System.Linq;

namespace BlImplementation;

internal class ProductImplementation : BlApi.IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public BO.Product GetProduct(int Id)
    {
        try
        {
            Do.Product doProd = _dal.Product.Read(p => p.id == Id);

            return new BO.Product
            {
                ID = doProd.id,
                Name = doProd.name,
                Price = doProd.price,
                Amount = doProd.amount,
                Category = (BO.Category)doProd.category,

                Sales = from s in _dal.Sale.ReadAll()
                        where s.idProduct == Id
                        select new BO.SaleInProduct
                        {
                            SaleID = s.idProduct,
                            AmountForSale = s.count,
                            SalePrice = s.pricesale,
                            IsForClub = s.clob
                        }
            };
        }
        catch (Exception ex)
        {
            throw new BO.BlDoesNotExistException($"Product {Id} not found", ex);
        }
    }

    public IEnumerable<BO.Product> GetList()
    {
        return _dal.Product.ReadAll().Select(p => new BO.Product
        {
            ID = p.id,
            Name = p.name,
            Price = p.price,
            Amount = p.amount,
            Category = (BO.Category)p.category
        });
    }

    public void Add(BO.Product product)
    {
        try
        {
            _dal.Product.Create(new Do.Product(product.ID, product.Name, (Do.category)product.Category, product.Price, product.Amount));
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
            _dal.Product.Update(new Do.Product(product.ID, product.Name, (Do.category)product.Category, product.Price, product.Amount));
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