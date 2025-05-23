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
        private List<Customer> _Customers;
        #endregion

        #region Constructor
        public CustomerDataAccessLayer()
        {

        }
        #endregion
    }
}
