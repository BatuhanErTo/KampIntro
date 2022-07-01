using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Abstracts;
using Assignment1.Entities;

namespace Assignment1.Concrete
{
    internal class CheckPersonManager : ICheckPersonService
    {
        public bool CheckIfRealPerson(Person person)
        {
            return true;
        }
    }
}
