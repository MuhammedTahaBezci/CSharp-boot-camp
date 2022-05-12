using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        private IEnumerable<Customer> customers;

        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi: " + customer.CustomerFirstName);

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi: " + customer.CustomerFirstName);
        }

        public void CustomerList(Customer customer)
        {
            foreach (var item in customers)
            {
                Console.WriteLine(customer.CustomerFirstName);
                item.CustomerFirstName = customer.CustomerFirstName;
                Console.WriteLine(item.CustomerFirstName);
            }
        }


    }
}