using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id=1,FirstName="Alper",LastName="Bayram",City="Denizli" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ömer";

            Customer customer2 = new Customer(2, "Kerem", "Kaya", "Düzce");

            Console.WriteLine(customer2.FirstName);

        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int ıd,string firstname,string lastname,string city)
        {
            Id = ıd;
            FirstName = firstname;
            LastName = lastname;
            City = city;

            
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }  
    }
}
