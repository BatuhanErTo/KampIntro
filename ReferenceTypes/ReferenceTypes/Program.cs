using System;

namespace ReferenceTypes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Batu";
            person2 = person1;
            person1.FirstName = "Deniz";

            Customer customer = new Customer();
            customer.FirstName = "Irem";
            customer.CreditCardNumber = "155340";
            Employee employee = new Employee();
            employee.FirstName = "Ismail";
            
            Person person3 = customer;
            //Console.WriteLine(person3.FirstName);

            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager manager = new PersonManager();    
            manager.Add(customer);
            manager.Add(employee);
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}