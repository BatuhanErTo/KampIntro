using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Entities;

namespace Assignment1.Abstracts
{
    internal interface IPersonService
    {
        void Save(Person person);
        void Update(Person person);
        void Delete(Person person);
    }
}
