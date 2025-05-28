using JeevanBank.BusinessLogicLayer.BALContracts;
using JeevanBank.DataAccessLayer;
using JeevanBank.DataAccessLayer.DALContracts;
using JeevanBank.Entities;
using JeevanBank.Exceptions;
using System;
using System.Collections.Generic;


namespace JeevanBank.BusinessLogicLayer
{
    /// <summary>
    /// Provides business logic operations for managing customer-related functionality.
    /// </summary>
    /// <remarks>The <see cref="CustomerBusinessLogicLayer"/> class serves as the intermediary between the
    /// presentation layer and the data access layer, encapsulating business rules and logic for customer-related
    /// operations. It interacts with an <see cref="ICustomerDataAccessLayer"/> implementation to perform data
    /// operations.</remarks>
    public class CustomerBusinessLogicLayer : ICustomerBusinessLogicLayer
    {

        #region Private Fields
        /// <summary>
        /// Provides access to customer data operations.
        /// </summary>
        /// <remarks>This field is used internally to interact with the data access layer for
        /// customer-related operations. It is intended for use within the class and should not be accessed directly by
        /// external code.</remarks>
        private ICustomerDataAccessLayer _customerDataAccessLayer;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerBusinessLogicLayer"/> class.
        /// </summary>
        /// <remarks>This constructor creates an instance of the <see cref="CustomerBusinessLogicLayer"/>
        /// class and initializes its internal dependencies, including the <see
        /// cref="CustomerDataAccessLayer"/>.</remarks>
        public CustomerBusinessLogicLayer()
        {
            _customerDataAccessLayer = new CustomerDataAccessLayer();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the data access layer for customer-related operations.
        /// </summary>
        private ICustomerDataAccessLayer CustomerDataAccessLayer
        {
            set => _customerDataAccessLayer = value;
            get => _customerDataAccessLayer;
        }


        #endregion

        #region Method
        /// <summary>
        /// Adds a new customer to the system and returns the unique identifier for the customer.
        /// </summary>
        /// <param name="customer">The customer object containing the details of the customer to be added. Cannot be null.</param>
        /// <returns>A <see cref="Guid"/> representing the unique identifier of the newly added customer.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Customer> GetCustomers()
        {
            try
            {
                //invoke DAL
                return CustomerDataAccessLayer.GetCustomers();
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
        /// Adds a new customer to the system and returns the unique identifier for the created customer.
        /// </summary>
        /// <param name="customer">The customer object containing the details of the customer to be added. Cannot be null.</param>
        /// <returns>The unique identifier (<see cref="Guid"/>) of the newly added customer.</returns>
        public Guid AddCustomer(Customer customer)
        {
            try
            {
                //get all customer 
                List<Customer> allCustomer = CustomerDataAccessLayer.GetCustomers();
                long maxCustCode = 0;
                foreach (var item in allCustomer)
                {
                    if (item.CustomerCode > maxCustCode)
                    {
                        maxCustCode = item.CustomerCode;
                    }

                }
                // generating new customer no
                if (allCustomer.Count >= 1)
                {
                    customer.CustomerCode = maxCustCode + 1;
                }
                else
                {

                    customer.CustomerCode = JeevanBank.Configuration.Settings.BaseCustomerNumber + 1;
                }
                //invoke DAL
                return CustomerDataAccessLayer.AddCustomer(customer);
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
        /// Deletes a customer record identified by the specified unique identifier.
        /// </summary>
        /// <param name="CustomerID">The unique identifier of the customer to delete. Must be a valid <see cref="Guid"/>.</param>
        /// <returns><see langword="true"/> if the customer was successfully deleted; otherwise, <see langword="false"/>.</returns>
        public bool DeleteCustomer(Guid CustomerID)
        {
            try
            {
                //invoke DAL
                return CustomerDataAccessLayer.DeleteCustomer(CustomerID);
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
        /// <param name="predicate">A delegate that defines the condition each customer must meet to be included in the result.</param>
        /// <returns>A list of <see cref="Customer"/> objects that match the specified condition.  Returns an empty list if no
        /// customers meet the condition.</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try
            {
                //invoke DAL
                return CustomerDataAccessLayer.GetCustomersByCondition(predicate);
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

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                //invoke DAL
                return CustomerDataAccessLayer.UpdateCustomer(customer);
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
