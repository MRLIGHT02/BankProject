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


        public CustomerException(string message) : base(message)
        {

        }
        /// <summary>
        /// Constructor that represents an exception that occurs specifically in customer-related operations.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that caused the current exception, or <see langword="null"/> if no inner exception is
        /// specified.</param>

        public CustomerException(string message, Exception innerException) : base(message, innerException)
        {
        }
        #endregion
    }
}
