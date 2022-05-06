using System;

namespace Encapsulation1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Batuhan";
            customer.LastName = "Erol";
            customer.Id = 10;
            Console.WriteLine(customer.FirstName);
        }
    }
}