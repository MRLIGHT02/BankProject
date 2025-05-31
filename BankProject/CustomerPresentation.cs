using System;
using System.Collections.Generic;

using JeevanBank.Entities;
using JeevanBank.BusinessLogicLayer;
using JeevanBank.BusinessLogicLayer.BALContracts;

using JeevanBank.Exceptions;
namespace BankProject
{
    /// <summary>
    /// Provides methods for managing customer-related operations in the system.
    /// </summary>
    /// <remarks>This static class serves as a presentation layer for customer management. It includes methods
    /// for adding new customers and viewing existing customer details. The methods interact with the business logic
    /// layer to perform operations such as validation, data retrieval, and storage. All interactions with the user,
    /// such as input collection and output display, are handled within this class.</remarks>
    static class CustomerPresentation
    {
        /// <summary>
        /// Adds a new customer by collecting details from the user and saving them to the system.
        /// </summary>
        /// <remarks>This method prompts the user to input customer details such as name, address, city,
        /// and mobile number. The details are then passed to the business logic layer for validation and storage. If
        /// the customer is successfully added, the method displays the new customer code. Otherwise, it notifies the
        /// user that the customer was not added.</remarks>
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
        /// <summary>
        /// Displays a list of all customers and their details in the console.
        /// </summary>
        /// <remarks>This method retrieves all customer records using the business logic layer and outputs
        /// their details          to the console. If an error occurs during the operation, the exception message and
        /// type are displayed.</remarks>
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

        /// <summary>
        /// Displays a list of customers, allows the user to select a customer by index, and deletes the selected customer.
        /// </summary>
        /// <remarks>This method retrieves all customers from the business logic layer and displays their IDs and names in
        /// a numbered list. The user is prompted to select a customer by entering the index of the customer in the list. The
        /// selected customer is then deleted. If no customers are available, a message is displayed indicating that there are
        /// no customers to delete.</remarks>
        internal static void GetList()
        {
            try
            {
                List<Guid> guids = new List<Guid>();
                ICustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();

                List<Customer> allCustomer = customerBusinessLogicLayer.GetCustomers();
                if (allCustomer.Count >= 1)
                {
                    Console.WriteLine("************Customer Id List**********");
                    int id = 0;
                    // read all customer
                    foreach (Customer item in allCustomer)
                    {
                        Console.WriteLine(id + 1 + ". " + "Customer Name is " + item.CustomerName);
                        guids.Add(item.CustomerID);

                    }
                    Console.Write("Select Customer Id to Delete by index 0 to range");
                    int index = Int32.Parse(Console.ReadLine());
                    if (index == 1)
                    {
                        index = 0;
                    }
                    else
                    {
                        index--;
                    }
                    Guid toDeleteCustomer = guids[index];



                    bool customerDeleted = customerBusinessLogicLayer.DeleteCustomer(toDeleteCustomer);
                    if (customerDeleted)
                    {
                        Console.WriteLine("Customer Deleted Successfully");
                        ViewCustomer();

                    }
                    else
                    {
                        Console.WriteLine("Customer not Deleted ");
                    }

                }
                else
                {
                    Console.WriteLine("There is no Customer to Delete");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());

            }





        }
        /// <summary>
        /// Deletes a customer from the system.
        /// </summary>
        /// <remarks>This method retrieves the list of customers and prompts the user to enter the ID of
        /// the customer to delete.  If the deletion is successful, a confirmation message is displayed, and the updated
        /// customer list is shown.  Otherwise, an error message is displayed.</remarks>
        internal static void DeleteCustomer()
        {
            GetList();
            //ICustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
            //Console.Write("Enter Customer Id: ");
            //Guid customerid = Guid.Parse(Console.ReadLine().Trim());
            //bool customerDeleted = customerBusinessLogicLayer.DeleteCustomer(customerid);
            //if (customerDeleted)
            //{
            //    Console.WriteLine("Customer Deleted Successfully");
            //    ViewCustomer();

            //}
            //else
            //{
            //    Console.WriteLine("Customer not Deleted ");
            //}
        }

        internal static void UpdateCustomer()
        {
            ICustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
            List<Customer> AllCustomer = customerBusinessLogicLayer.GetCustomers();
            int index = 0;
            Customer customer = new Customer();

            bool updateCustomer = customerBusinessLogicLayer.UpdateCustomer(AllCustomer[index]);
        }
    }
}
