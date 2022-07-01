using System;
using Assignment1.Abstracts;
using Assignment1.Concrete;
using Assignment1.Entities;
namespace Assignment1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BasePersonService personManager = new PersonManager(new CheckPersonManager());
           personManager.Save(new Person {Id = 2,NationalIdentity = "152632",FirstName = "Kemal",LastName = "Erol" });
        }
    }
}