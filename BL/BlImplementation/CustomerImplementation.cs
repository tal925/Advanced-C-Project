using System;
using System.Collections.Generic;
using System.Linq;

namespace BlImplementation;

internal class CustomerImplementation : BlApi.ICustomer
{
    readonly DalApi.IDal _dal = DalApi.Factory.Get;

    public void Add(BO.Customer customer)
    {
        try
        {
            _dal.customer.Create(new Do.Customer(
                customer.ID,
                customer.Name ?? "",
                customer.Address ?? "",
                customer.Phone != null ? int.Parse(customer.Phone) : 0, 
                customer.IsClubMember
            ));
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
            var c = _dal.customer.Read(cust => cust.id == id);
            return new BO.Customer
            {
                ID = c.id,
                Name = c.name,
                Address = c.adress, 
                Phone = c.phon.ToString(), 
                IsClubMember = c.isclob 
            };
        }
        catch (Exception ex) { throw new BO.BlDoesNotExistException("Not found", ex); }
    }

    public IEnumerable<BO.Customer> GetList()
    {
        return _dal.customer.ReadAll().Select(c => new BO.Customer
        {
            ID = c.id,
            Name = c.name,
            Address = c.adress,
            Phone = c.phon.ToString(),
            IsClubMember = c.isclob
        });
    }

    public void Update(BO.Customer customer)
    {
        try
        {
            _dal.customer.Update(new Do.Customer(
                customer.ID,
                customer.Name ?? "",
                customer.Address ?? "",
                customer.Phone != null ? int.Parse(customer.Phone) : 0,
                customer.IsClubMember
            ));
        }
        catch (Exception ex) { throw new BO.BlDoesNotExistException("Update failed", ex); }
    }
}