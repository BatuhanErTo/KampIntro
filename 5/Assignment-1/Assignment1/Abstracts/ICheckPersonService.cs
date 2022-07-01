using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Entities;

namespace Assignment1.Abstracts
{
    internal interface ICheckPersonService
    {
        bool CheckIfRealPerson(Person person);
    }
}
