using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
    internal class Customer
    {
        public int Id { get; set; }

        private string _firstName;
        public string FirstName { 
            get
            {
                return "Mrs/Mrs." + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName { get; set; }
    }
}
