using System;

namespace OOP2
{

    class Program
    {

        static void Main (string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Taha";
            customer1.LastName = "Bezci";
            customer1.InternationalId = "12345678910";

            CorporateCustomer customer2= new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "12457";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "123457869";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();



        }
    }
}