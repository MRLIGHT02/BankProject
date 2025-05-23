using System;
using System.Collections.Generic;
using System.Linq;
using JeevanBank.Entities;
using JeevanBank.Exceptions;
using JeevanBank.DataAccessLayer.DALContracts;

namespace JeevanBank.DataAccessLayer
{
    /// <summary>
    /// Provides methods for accessing and managing customer data in the underlying data store.
    /// </summary>
    /// <remarks>This class serves as a data access layer (DAL) for customer-related operations.  It is
    /// responsible for interacting with the data source to retrieve, update, and manage customer information.</remarks>
    public class CustomerDataAccessLayer : ICustomerDataAccessLayer
    {
        public Guid AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(Guid CustomerID)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
