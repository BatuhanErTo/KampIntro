using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    internal class CustomerManager
    {
        public void Add(ICustomerDal customer)
        {
            customer.Add();
        }
    }
}
