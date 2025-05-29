using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeevanBank.Entities;
using JeevanBank.BusinessLogicLayer;
using JeevanBank.Exceptions;
namespace BankProject
{
    static class CustomerPresentation
    {
        internal static void AddCustomer()
        {
            // Create a new instance of Customer
            Customer customer = new Customer();
            // Read all Details from the user
            Console.WriteLine("\n*********ADD CUSTOMER*********");
            Console.Write("Customer Name: ");
            customer.CustomerName = Console.ReadLine();
            Console.Write("Address: ");
            customer.Address = Console.ReadLine();
        }

    }
}
