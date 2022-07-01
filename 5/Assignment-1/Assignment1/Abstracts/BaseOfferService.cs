using Assignment1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Abstracts
{
    internal abstract class BaseOfferService : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine("New offer : " + offer.Discount + " discount.");
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine("Offer is deleted. Identity number of the deleted offer : "+ offer.Id);
        }

        public void Update(Offer offer)
        {
            Console.WriteLine("Offer is updated. Identity number of the offer : " + offer.Id);
        }
    }
}
