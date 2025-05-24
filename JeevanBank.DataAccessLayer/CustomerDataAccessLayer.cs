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
            try
            {
                // create a new customer list
                List<Customer> customerslist = new List<Customer>();
                // Copy all customer from the source collection into newCustomer list
                Customers.ForEach(item => customerslist.Add((Customer)item.Clone()));
                return customerslist;
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Retrieves a list of customers that satisfy the specified condition.
        /// </summary>
        /// <param name="predicate">A predicate that defines the condition each customer must satisfy to be included in the result.</param>
        /// <returns>A list of customers that match the specified condition. If no customers match, an empty list is returned.</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try
            {

                // create a new customer list
                List<Customer> customerslist = new List<Customer>();
                // filter the condition
                List<Customer> filteredCustomers = customerslist.FindAll(predicate);
                // copy all customer from the source collection into the new customer list;
                Customers.ForEach(item => customerslist.Add(item.Clone() as Customer));
                return customerslist;
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Guid AddCustomer(Customer customer)
        {
            try
            {
                // generate new guid 
                customer.CustomerID = Guid.NewGuid();

                Customers.Add(customer);
                return customer.CustomerID;
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Deletes a customer with the specified unique identifier.
        /// </summary>
        /// <remarks>This method searches for a customer by their unique identifier and removes them from
        /// the collection.  If no customer with the specified identifier exists, the method returns <see
        /// langword="false"/>.</remarks>
        /// <param name="CustomerID">The unique identifier of the customer to delete.</param>
        /// <returns><see langword="true"/> if a customer with the specified identifier was successfully deleted;  otherwise,
        /// <see langword="false"/>.</returns>

        public bool DeleteCustomer(Guid CustomerID)
        {
            try
            {

                // deleting the customer
                if (Customers.RemoveAll(item => item.CustomerID == CustomerID) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Updates the details of an existing customer in the system.
        /// </summary>
        /// <param name="customer">The customer object containing updated information. The <see cref="Customer.Id"/> property must be set to
        /// identify the customer to update.</param>
        /// <returns><see langword="true"/> if the customer was successfully updated; otherwise, <see langword="false"/>.</returns>
        public bool UpdateCustomer(Customer customer)
        {

            try
            {

                // finding is customr exists 
                Customer existingCustomer = Customers.Find(item => item.CustomerID == customer.CustomerID);
                // updating the customer
                if (existingCustomer != null)
                {
                    existingCustomer.CustomerCode = customer.CustomerCode;
                    existingCustomer.CustomerID = customer.CustomerID;
                    existingCustomer.CustomerName = customer.CustomerName;
                    existingCustomer.City = customer.City;
                    existingCustomer.Country = customer.Country;
                    existingCustomer.Address = customer.Address;
                    existingCustomer.Landmarks = customer.Landmarks;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion

    }
}
