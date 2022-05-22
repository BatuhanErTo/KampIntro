using RealLifeInterfaceAndAbstract.Abstract;
using RealLifeInterfaceAndAbstract.Concrete;
using System;

namespace RealLifeInterfaceAndAbstract // Note: actual namespace depends on the project name.
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Entities.Customer {DateOfBirth = 2002, Name = "Batuhan", LastName = "Erol",NationalityId ="16607360256"});

        }
    }
}