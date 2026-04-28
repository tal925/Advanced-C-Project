using System;
using System.Collections.Generic;
using System.Linq;
using BO;

namespace BlImplementation;

internal class SaleImplementation : BlApi.ISale
{
    readonly DalApi.IDal _dal = DalApi.Factory.Get;

    public void Add(BO.Sale sale)
    {
        try
        {
            _dal.Sale.Create(sale.ToDO());
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
            _dal.Sale.Update(sale.ToDO());
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
            var s = _dal.Sale.Read(id);
            if (s == null) throw new BO.BlDoesNotExistException($"Sale {id} not found");
            return s.ToBO();
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