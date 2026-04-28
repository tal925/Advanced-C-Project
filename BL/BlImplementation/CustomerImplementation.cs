using System;
using System.Collections.Generic;
using System.Linq;
using BO;

namespace BlImplementation;

internal class CustomerImplementation : BlApi.ICustomer
{
    readonly DalApi.IDal _dal = DalApi.Factory.Get;

    public void Add(BO.Customer customer)
    {
        try
        {
            _dal.customer.Create(customer.ToDO());
        }
        catch (Exception ex)
        {
            throw new BO.BlAlreadyExistsException($"Customer {customer.ID} already exists", ex);
        }
    }

    public void Delete(int id)
    {
        try { _dal.customer.Delete(id); }
        catch (Exception ex) { throw new BO.BlDoesNotExistException($"Customer {id} not found", ex); }
    }

    public BO.Customer Get(int id)
    {
        try
        {
            var c = _dal.customer.Read(id);
            if (c == null) throw new BO.BlDoesNotExistException($"Customer {id} not found");
            return c.ToBO();
        }
        catch (Exception ex) { throw new BO.BlDoesNotExistException("Not found", ex); }
    }

    public IEnumerable<BO.Customer> GetList()
    {
        return _dal.customer.ReadAll().Where(c => c != null).Select(c => c!.ToBO());
    }

    public void Update(BO.Customer customer)
    {
        try
        {
            _dal.customer.Update(customer.ToDO());
        }
        catch (Exception ex) { throw new BO.BlDoesNotExistException("Update failed", ex); }
    }

}