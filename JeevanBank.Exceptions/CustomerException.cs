using System;


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
        #region Constructors
        /// <summary>
        /// Constructor that represents an exception specific to customer-related operations.
        /// </summary>
        /// <remarks>This exception can be used to indicate errors or issues that occur during
        /// customer-related processes.</remarks>
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
        #endregion
    }
}
