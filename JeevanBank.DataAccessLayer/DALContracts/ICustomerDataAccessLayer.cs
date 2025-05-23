using JeevanBank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeevanBank.DataAccessLayer.DALContracts
{
    /// <summary>
    /// Defines methods for accessing and managing customer data in a data store.
    /// </summary>
    /// <remarks>This interface provides an abstraction for customer data operations, allowing implementations
    /// to interact with various data storage mechanisms (e.g., databases, in-memory collections).</remarks>
    internal interface ICustomerDataAccessLayer
    {
        /// <summary>
        /// Retrieves a list of all customers.
        /// </summary>
        /// <returns>A list of <see cref="Customer"/> objects representing all customers.  Returns an empty list if no customers
        /// are found.</returns>
        List<Customer> GetCustomers();
        /// <summary>
        /// Retrieves a list of customers that satisfy a specific condition.
        /// </summary>
        /// <returns>A list of <see cref="Customer"/> objects that meet the specified condition.  Returns an empty list if no
        /// customers match the condition.</returns>
        List<Customer> GetCustomersByCondition(Predicate<Customer> predicate);
        /// <summary>
        /// Adds a new customer to the system and returns the unique identifier for the customer.
        /// </summary>
        /// <param name="customer">The customer to add. Must not be null and must contain valid data.</param>
        /// <returns>The unique identifier (<see cref="Guid"/>) assigned to the newly added customer.</returns>
        Guid AddCustomer(Customer customer);

        bool UpdateCustomer(Customer customer);

        bool DeleteCustomer(Guid CustomerID);

    }
}
