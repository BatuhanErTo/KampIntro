using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    // Coorporate
    //inheritance - tuzel musteri de bir customerdir
    internal class TuzelCustomer:Customer
    {
        public string CompanyName { get; set; }

        public string VergiNo { get; set; }
    }
}
