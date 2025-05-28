using JeevanBank.BusinessLogicLayer.BALContracts;
using JeevanBank.DataAccessLayer;
using JeevanBank.DataAccessLayer.DALContracts;
using JeevanBank.Entities;
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
        #endregion


    }
}
