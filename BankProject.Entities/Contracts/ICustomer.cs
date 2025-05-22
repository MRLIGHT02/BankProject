using System;


namespace JeevanBank.Entities
{
    public interface ICustomer
    {
        Guid CustomerId { get; set; }
        long CustomerCode { get; set; }
        string CustomerName { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string Mobile { get; set; }
    }
}
