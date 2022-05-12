using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { CustomerId = 1, CustomerFirstName = "Taha", CustomerLastName = "Bezci", NationalId = 1238568 };
            Customer customer2 = new Customer { CustomerId = 2, CustomerFirstName = "Hamza", CustomerLastName = "Uçar", NationalId = 1244568 };
            Customer customer3 = new Customer { CustomerId = 2, CustomerFirstName = "Furkan", CustomerLastName = "Eriç", NationalId = 1244568 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            Console.WriteLine(customerManager);

            customerManager.Delete(customer2);
            Console.WriteLine(customerManager);

            Console.WriteLine("Müşteriler Listelendi:");
            CustomerList<string> customerList = new CustomerList<string>();
            customerList.Add(customer1.CustomerFirstName);
            customerList.Add(customer2.CustomerFirstName);
            customerList.Add(customer3.CustomerFirstName);
            Console.WriteLine(customerList);

        }
    }
}