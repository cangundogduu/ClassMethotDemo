using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer ID : " + customer.CustomerId);
            Console.WriteLine("Customer Name : " + customer.CustomerName);
            Console.WriteLine("Customer Surname : " + customer.CustomerSurname);
            Console.WriteLine("Customer is Added");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer ID : " + customer.CustomerId);
            Console.WriteLine("Customer Name : " + customer.CustomerName);
            Console.WriteLine("Customer Surname : " + customer.CustomerSurname);
            Console.WriteLine("Customer is Deleted");
        }
        public void List (Customer[] customer)
        {
            

            foreach (var customers in customer)
            {
               
                Console.WriteLine("Customer ID : " + customers.CustomerId);
                Console.WriteLine("Customer Name : " + customers.CustomerName);
                Console.WriteLine("Customer Surname : " + customers.CustomerSurname);
                
            }
        }

       
    }
}
