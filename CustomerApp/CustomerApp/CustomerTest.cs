using System;
using CustomerApp.Model;
using System.Collections.Generic;
namespace CustomerApp
{
    class CustomerTest
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();
            Customer c = new Customer("Vinay");
            Console.WriteLine(c);
            Console.WriteLine(c.ToString());
            Console.WriteLine("\n\t\tCustomerApp");
            int userChoice=0;
            do
            {
                Console.WriteLine("\n1. Add Customer\n2. Display All Customers\n3. Exit\nEnter choice: ");
                userChoice =int.Parse( Console.ReadLine());
                if (userChoice == 1)
                {
                    Console.Write("\nEnter name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Credits: ");
                    int credits = int.Parse(Console.ReadLine());
                    AddCustomer(customerList, name, credits);
                }
                else if (userChoice == 2) DisplayAllCustomers(customerList);
                else Console.WriteLine("Invalid Choice Try Again");

            } while (userChoice != 3);
        }

        private static void DisplayAllCustomers(List<Customer> customers)
        {
            if (customers.Count == 0) Console.WriteLine("No customers to display!");
            else
            {
                Console.WriteLine("\nCustormer Details:\n");
                foreach (Customer customer in customers)
                {
                    PrintDetails(customer);
                }
            }  
        }

        private static void AddCustomer(List<Customer> customerList,string name,int credits)
        {
            Customer demoCustomer = new Customer(name, credits);
            customerList.Add(demoCustomer);
            Console.WriteLine("\nCustomer added successfully");
        }
        private static void PrintDetails(Customer customer)
        {
            Console.WriteLine("ID: {0}",customer.ID);
            Console.WriteLine("Name:{0}",customer.Name);
            Console.WriteLine("Credits: {0}\n",customer.Credits);
        }
    }
}
