using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeevanBank.Exceptions
{
    /// <summary>
    /// Represents a collection of custom exceptions related to customer operations.
    /// </summary>
    /// <remarks>This class serves as a container for exceptions specific to customer-related functionality.
    /// It can be used to group and organize exceptions that are thrown during customer operations, such as validation
    /// errors or business rule violations.</remarks>
    public class CustomerException : ApplicationException
    {
        public CustomerException()
        {
        }

        /// <summary>
        /// Constructor that initializes a new instance of the <see cref="CustomerException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public CustomerException(string message) : base(message)
        {

        }

        public CustomerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
