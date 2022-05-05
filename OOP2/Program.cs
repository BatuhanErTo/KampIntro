using System;

namespace OOP2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekCustomer customer1 = new GercekCustomer();
            customer1.MusteriNo = "1234";
            customer1.Name = "Batu";
            customer1.Surname = "Erol";
            customer1.TcNo = "1453454";

            TuzelCustomer customer2 = new TuzelCustomer();
            customer2.Id = 2;
            customer2.CompanyName = "Kodlama.io";
            customer2.MusteriNo = "54321";
            customer2.VergiNo = "123456";

            Customer customer3 = new GercekCustomer();
            Customer customer4 = new TuzelCustomer();    
            // Customer sinifi hem Gercek hem de Tuzel kisinin referansını tutar
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer4);
        }
    }
}