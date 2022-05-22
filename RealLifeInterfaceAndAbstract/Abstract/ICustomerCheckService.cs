using RealLifeInterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealLifeInterfaceAndAbstract.Abstract
{
    internal interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
