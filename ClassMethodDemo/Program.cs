using ClassMethodDemo;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();    

            Customer customer1 = new Customer();
            customer1.Name = "Batuhan";
            customer1.Surname = "Erol";
            customer1.Id = 1;
            customer1.budget = 150;

            Customer customer2 = new Customer();
            customer2.Name = "Mehmet";
            customer2.Surname = "Erol";
            customer2.Id = 2;
            customer2.budget = 150;

            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);

            customerManager.DeleteCustomer(customer1);

            Customer[] listOfCustomers = new Customer[] { customer1, customer2 };

            customerManager.ListCustomers(listOfCustomers);
        }
    }
}
