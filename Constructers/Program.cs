using System;

namespace Constructers // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1, FirstName = "Hakan", LastName = "Enginar", City="Bursa" };
            Customer customer1 = new Customer (2,"Kamil","Koc","Istanbul");

        }
    }

    class Customer
    {
        //default constructer
        public Customer()
        {
            Console.WriteLine("Yapıcı blok calisti.");
        }

        public Customer(int id,string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;  
            LastName = lastName;    
            City = city;    
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}