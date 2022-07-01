using Assignment1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Abstracts
{
    internal abstract class BasePurchaseService : IPurchaseService
    {
        public void PurchaseWithOffer(Game game, Person person, Offer offer)
        {
            Console.WriteLine(person.FirstName + " buy the game : " + game.Name + " with the price of " + (game.Price - offer.Discount));
        }

        public void PurchaseWithoutOffer(Game game, Person person)
        {
            Console.WriteLine(person.FirstName + " buy the game : " + game.Name);
        }
    }
}
