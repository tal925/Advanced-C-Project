using System;
using System.Collections.Generic;
using System.Linq;

namespace BlImplementation;

internal class SaleImplementation : BlApi.ISale
{
    readonly DalApi.IDal _dal = DalApi.Factory.Get;

    public void Add(BO.Sale sale)
    {
        try
        {
            _dal.Sale.Create(new Do.Sale(
                sale.ProductID,
                sale.Count,
                sale.PriceSale,
                sale.IsClubMember,
                sale.StartDate, 
                sale.EndDate    
            ));
        }
        catch (Exception ex)
        {
            throw new BO.BlAlreadyExistsException($"Sale for product {sale.ProductID} already exists", ex);
        }
    }

    public void Update(BO.Sale sale)
    {
        try
        {
            _dal.Sale.Update(new Do.Sale(
                sale.ProductID,
                sale.Count,
                sale.PriceSale,
                sale.IsClubMember,
                sale.StartDate,
                sale.EndDate
            ));
        }
        catch (Exception ex)
        {
            throw new BO.BlDoesNotExistException("Update failed - sale not found", ex);
        }
    }

    public BO.Sale Get(int id)
    {
        try
        {
            Do.Sale s = _dal.Sale.Read(sale => sale.idProduct == id);

            return new BO.Sale
            {
                ProductID = s.idProduct,
                Count = s.count,
                PriceSale = s.pricesale,
                IsClubMember = s.clob,
                StartDate = s.start, 
                EndDate = s.end      
            };
        }
        catch (Exception ex)
        {
            throw new BO.BlDoesNotExistException("Sale not found", ex);
        }
    }

    public IEnumerable<BO.Sale> GetList()
    {
        return _dal.Sale.ReadAll().Select(s => new BO.Sale
        {
            ProductID = s.idProduct,
            Count = s.count,
            PriceSale = s.pricesale,
            IsClubMember = s.clob,
            StartDate = s.start,
            EndDate = s.end
        });
    }

    public void Delete(int id)
    {
        try { _dal.Sale.Delete(id); }
        catch (Exception ex) { throw new BO.BlDoesNotExistException("Sale not found", ex); }
    }
}