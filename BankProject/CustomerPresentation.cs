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
                List<Customer> matchingCustomer = customerBusinessLogicLayer.GetCustomersByCondition(item => item.CustomerID == newGuid);
                if (matchingCustomer.Count >= 1)
                {
                    Console.WriteLine("New Customer Code: " + matchingCustomer[0].CustomerCode);
                    Console.WriteLine("Customer Added.\n");
                }
                else
                {
                    Console.WriteLine("Customer Not Added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }



        }

        internal static void ViewCustomer()
        {
            try
            {
                ICustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();

                List<Customer> allCustomer = customerBusinessLogicLayer.GetCustomers();
                Console.WriteLine("************ALL CUSTOMER**********");
                // read all customer
                foreach (var item in allCustomer)
                {
                    Console.WriteLine("Customer Code: " + item.CustomerCode);
                    Console.WriteLine("Customer Name: " + item.CustomerName);
                    Console.WriteLine("Customer Address: " + item.Address);
                    Console.WriteLine("Customer Landmark: " + item.Landmarks);
                    Console.WriteLine("Customer City: " + item.City);
                    Console.WriteLine("Customer Country: " + item.Country);
                    Console.WriteLine("Customer Mobile: " + item.Mobile);
                    Console.WriteLine();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }

    }
}
