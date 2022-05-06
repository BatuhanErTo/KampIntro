using System;

namespace Inheritance // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> persons = new List<Person>() { new Customer() {Id = 1, FirstName = "Ali", Adress = "sadfdfh" },new Employee() {FirstName = "Mehmet" ,Salary = 123} };
            foreach (Person item in persons)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
    // Inheritance da interface gibi bir sınıfa birden çok şey implemente edemezsin.
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string Adress { get; set; }
    }

    class Employee : Person
    {
        public int Salary { get; set; }
    }
}