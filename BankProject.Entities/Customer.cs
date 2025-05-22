using System;
using JeevanBank.Entities.Contracts;

namespace JeevanBank.Entities
{
    public class Customer : ICustomer
    {
        private Guid _customerID;
        private long _customerCode;
        private string _customerName;
        private string _address;
        private string _landmarks;
        private string _city;
        private string _country;
        private string _mobile;

        public Guid CustomerID { get => _customerID; set => _customerID = value; }
        public long CustomerCode { get => _customerCode; set => _customerCode = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public string Address { get => _address; set => _address = value; }
        public string Landmarks { get => _landmarks; set => _landmarks = value; }
        public string City { get => _city; set => _city = value; }
        public string Country { get => _country; set => _country = value; }
        public string Mobile { get => _mobile; set => _mobile = value; }
    }
}
