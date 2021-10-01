using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNo = "123456";
            customer1.FirsName = "Alper";
            customer1.Surname = "Bayram";
            customer1.TcNo = "123456789";

            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNo = "1234567897";
            customer2.Company = "Atak Ticaret";
            customer2.TaxNumber = "987456";

            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
   




        }
    }
}
