using Assignment1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Abstracts
{
    internal abstract class BasePersonService : IPersonService
    {
        public virtual void Save(Person person)
        {
            Console.WriteLine("New user has been added to db. " + person.FirstName);
        }

        public virtual void Update(Person person)
        {
            Console.WriteLine("The user's information has been updated to db. " + person.FirstName);
        }

        public virtual void Delete(Person person)
        {
            Console.WriteLine("The user is deleted from db. " + person.FirstName);
        }
    }
}
