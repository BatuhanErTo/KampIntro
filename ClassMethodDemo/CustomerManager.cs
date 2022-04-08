using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("{0} is added to system",customer.Name);
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("{0} is deleted from the system",customer.Id);
        }
        public void ListCustomers(Customer[] customer)
        {
            foreach (Customer item in customer)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
        }


    }
}
