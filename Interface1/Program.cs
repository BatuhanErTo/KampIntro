using System;
using System.Collections.Generic;

namespace Interface1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            List<ICustomerDal> customerDals = new List<ICustomerDal>() {new OracleCustomeDal(), new SqlServerCustomerDal()};
            foreach (var customerDal in customerDals)
            {
                customerManager.Add(customerDal);
            }
        }
    }
}