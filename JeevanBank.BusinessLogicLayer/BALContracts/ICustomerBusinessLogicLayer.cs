using JeevanBank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeevanBank.BusinessLogicLayer.BALContracts
{
    public interface ICustomerBusinessLogicLayer
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
        /// <summary>
        /// Updates the details of an existing customer in the system.
        /// </summary>
        /// <param name="customer">The customer object containing updated information. The <see cref="Customer.Id"/> property must match an
        /// existing customer.</param>
        /// <returns><see langword="true"/> if the customer was successfully updated; otherwise, <see langword="false"/>.</returns>
        bool UpdateCustomer(Customer customer);
        /// <summary>
        /// Deletes the customer with the specified unique identifier.
        /// </summary>
        /// <remarks>Use this method to remove a customer from the system. Ensure that the provided
        /// <paramref name="CustomerID"/> corresponds to an existing customer. If the customer does not exist, the
        /// method will return <see langword="false"/>.</remarks>
        /// <param name="CustomerID">The unique identifier of the customer to delete.</param>
        /// <returns><see langword="true"/> if the customer was successfully deleted; otherwise, <see langword="false"/>.</returns>
        bool DeleteCustomer(Guid CustomerID);
    }
}
