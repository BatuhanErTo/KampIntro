using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Abstracts;

namespace Assignment1.Entities
{
    internal class Offer : IOffer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
    }
}
