using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Entities;

namespace Assignment1.Abstracts
{
    internal interface IOfferService
    {
        void Add(Offer offer);

        void Delete(Offer offer);

        void Update(Offer offer);
    }
}
