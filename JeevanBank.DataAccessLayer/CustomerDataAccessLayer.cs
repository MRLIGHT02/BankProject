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
        #region Fields
        private List<Customer> _customers;
        #endregion

        #region Constructor
        public CustomerDataAccessLayer()
        {
            _customers = new List<Customer>();
        }
        #endregion
        #region Properties
        private List<Customer> Customers
        {
            set => _customers = value;
            get => _customers;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Retrieves a list of customers as a new collection of cloned objects.
        /// </summary>
        /// <remarks>Each customer in the returned list is a deep copy of the corresponding customer in
        /// the original collection, ensuring that modifications to the returned list or its elements do not affect the
        /// original data.</remarks>
        /// <returns>A <see cref="List{T}"/> of <see cref="Customer"/> objects, where each object is a clone of a customer from
        /// the original collection. The list will be empty if there are no customers in the original collection.</returns>
        public List<Customer> GetCustomers()
        {
            // create a new customer list
            List<Customer> customerslist = new List<Customer>();
            // Copy all customer from the source collection into newCustomer list
            Customers.ForEach(item => customerslist.Add((Customer)item.Clone()));
            return customerslist;
        }
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            // create a new customer list
            List<Customer> customerslist = new List<Customer>();
            // filter the condition
            List<Customer> filteredCustomers = customerslist.FindAll(predicate);
            // copy all customer from the source collection into the new customer list;
            Customers.ForEach(item => customerslist.Add(item.Clone() as Customer));
            return customerslist;
        }
        public Guid AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(Guid CustomerID)
        {
            throw new NotImplementedException();
        }



        public bool UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
