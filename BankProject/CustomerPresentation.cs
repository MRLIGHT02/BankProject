using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeevanBank.Entities;
using JeevanBank.BusinessLogicLayer;
using JeevanBank.BusinessLogicLayer.BALContracts;

using JeevanBank.Exceptions;
namespace BankProject
{
    static class CustomerPresentation
    {
        internal static void AddCustomer()
        {
            try
            {
                // Create a new instance of Customer
                Customer customer = new Customer();
                // Read all Details from the user
                Console.WriteLine("\n*********ADD CUSTOMER*********");
                Console.Write("Customer Name: ");
                customer.CustomerName = Console.ReadLine();
                Console.Write("Address: ");
                customer.Address = Console.ReadLine();
                Console.Write("Landmark: ");
                customer.Landmarks = Console.ReadLine();
                Console.Write("City: ");
                customer.City = Console.ReadLine();
                Console.Write("Country: ");
                customer.Country = Console.ReadLine();
                Console.Write("Mobile: ");
                customer.Mobile = Console.ReadLine();

                // create BL Object
                ICustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
                Guid newGuid = customerBusinessLogicLayer.AddCustomer(customer);
                Console.WriteLine(newGuid);
                Console.WriteLine("Customer Added.\n");
            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}
