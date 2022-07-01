using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Entities;
using Assignment1.Abstracts;

namespace Assignment1.Concrete
{
    internal class PersonManager : BasePersonService
    {
        ICheckPersonService checkPersonService;

        public PersonManager(ICheckPersonService checkPersonService)
        {
            this.checkPersonService = checkPersonService;
        }

        public override void Save(Person person)
        {
            if (checkPersonService.CheckIfRealPerson(person))
            {
                base.Save(person);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        public override void Update(Person person)
        {
            if (checkPersonService.CheckIfRealPerson(person))
            {
                base.Update(person);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
        public override void Delete(Person person)
        {
            if (checkPersonService.CheckIfRealPerson(person))
            {
                base.Delete(person);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
