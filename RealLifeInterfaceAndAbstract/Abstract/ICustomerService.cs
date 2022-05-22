using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealLifeInterfaceAndAbstract.Entities;

namespace RealLifeInterfaceAndAbstract.Abstract
{
    internal interface ICustomerService
    {
        void Save(Customer customer);
    }
}
