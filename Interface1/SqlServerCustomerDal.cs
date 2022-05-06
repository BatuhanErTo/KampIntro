using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    internal class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL added");
        }

        public void Delete()
        {
            Console.WriteLine("SQL deleted");
        }

        public void Update()
        {
            Console.WriteLine("SQL updated");
        }
    }
}
