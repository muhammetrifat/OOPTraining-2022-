using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //muhammed
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = 12345;
            customer1.Name = "Muhammed";
            customer1.LastName = "Türkmen";
            customer1.TcNumber = "12345678901";


            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = 12354;
            customer2.CompanyName = "BilgiBirikim";
            customer2.TaxNumber = "1234567890";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();

        }
    }
}
