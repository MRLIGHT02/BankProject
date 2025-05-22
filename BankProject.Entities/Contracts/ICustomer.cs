using System;


namespace JeevanBank.Entities.Contracts
{
    /// <summary>
    /// Represents a customer with identifying information, contact details, and location data.
    /// </summary>
    /// <remarks>This interface defines the properties required to uniquely identify a customer and store
    /// their  associated details, such as name, address, and contact information. It is intended to be implemented  by
    /// classes that manage customer data in applications.</remarks>
    public interface ICustomer
    {
        Guid CustomerID { get; set; }
        long CustomerCode { get; set; }
        string CustomerName { get; set; }
        string Address { get; set; }
        string Landmarks { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string Mobile { get; set; }
    }
}
