using System;
using JeevanBank.Entities.Contracts;
using JeevanBank.Exceptions;
using System.Text.RegularExpressions;
using System.Security.Policy;

namespace JeevanBank.Entities
{
    /// <summary>
    /// Represents a customer with associated details such as name, address, and contact information.
    /// </summary>
    /// <remarks>This class provides properties to store and retrieve customer information, including unique
    /// identifiers, contact details, and location data. 
    /// platforms.</remarks>

    public class Customer : ICustomer
    {
        #region Private Fields
        private Guid _customerID;
        private long _customerCode;
        private string _customerName;
        private string _address;
        private string _landmarks;
        private string _city;
        private string _country;
        private string _mobile;
        #endregion


        #region Public Properties
        /// <summary>
        /// GUID Gets or sets the unique identifier for the customer.
        /// </summary>
        public Guid CustomerID
        {
            get => _customerID;
            set => _customerID = value;
        }
        /// <summary>
        /// Auto Generated code Number of the Customer
        /// </summary>
        public long CustomerCode
        {
            get => _customerCode;
            set
            {
                // Adding validation logic
                if (value > 0)
                {
                    _customerCode = value;
                }
                else
                {
                    throw new CustomerException("Customer Code must be postive integer.");
                }
            }
        }
        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        public string CustomerName
        {
            get => _customerName; set
            {
                if (value.Length <= 40 && string.IsNullOrEmpty(value) == false)
                {
                    _customerName = value;
                }
            }

        }


        /// <summary>
        /// Gets or sets the address associated with the entity.
        /// </summary>
        public string Address { get => _address; set => _address = value; }
        /// <summary>
        /// Gets or sets the landmarks associated with the object.
        /// </summary>
        public string Landmarks { get => _landmarks; set => _landmarks = value; }
        /// <summary>
        /// Gets or sets the name of the city.
        /// </summary>
        public string City { get => _city; set => _city = value; }
        /// <summary>
        /// Gets or sets the country associated with the current entity.
        /// </summary>
        public string Country { get => _country; set => _country = value; }
        /// <summary>
        /// Gets or sets the mobile phone number associated with the entity. Number Must be 10-digits.
        /// </summary>
        public string Mobile { get => _mobile; set => _mobile = value; }
        #endregion
    }
}
