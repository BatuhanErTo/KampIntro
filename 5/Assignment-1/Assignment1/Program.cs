using System;
using Assignment1.Abstracts;
using Assignment1.Concrete;
using Assignment1.Entities;
namespace Assignment1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game {Id = 1, Name = "RDR2", Price = 142 };

            Offer offer = new Offer {Id = 1, Name = "Summer Discount", Discount = 142 };

            Person person = new Person { Id = 1, FirstName = "Batu", LastName = "Erol", NationalIdentity = "2143243"};
            
            BasePersonService personService = new PersonManager(new CheckPersonManager());
            personService.Save(person);

            BaseOfferService offerService = new OfferManager();
            offerService.Add(offer);

            BasePurchaseService purchaseService = new PurchaseManager();
            if (offer.Discount > 0)
            {
                purchaseService.PurchaseWithOffer(game,person,offer);
            }
            else
            {
                purchaseService.PurchaseWithoutOffer(game,person);
            }

        }
    }
}