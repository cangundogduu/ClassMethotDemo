using System;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                CustomerId = 1,
                CustomerName = "Can",
                CustomerSurname = "Gündoğdu"
            };
            Customer customer2 = new Customer()
            {
                CustomerId = 2,
                CustomerName = "Fatma",
                CustomerSurname = "Gündoğdu"
            };
            Customer customer3 = new Customer()
            {
                CustomerId = 3,
                CustomerName = "Yiğit Mahmut",
                CustomerSurname = "Gündoğdu"
            };

            CustomerManager manager = new CustomerManager();
            Customer[] customer = new Customer[] {customer1,customer2,customer3};

            Console.WriteLine("------------------ADD----------------------");
            for (int i = 0; i < customer.Length; i++)
             {
                manager.Add(customer[i]);
             }

            Console.WriteLine("------------------DELETE----------------------");

            for (int i = 0; i < customer.Length; i++)
            {
                manager.Delete(customer[i]);
            }
            Console.WriteLine("------------------LİST----------------------");
            manager.List(customer);

            Console.ReadLine();
            

        }
    }
}
