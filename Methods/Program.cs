using System;

namespace Methods // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Açiklama = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Açiklama = "Diyarbarkır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            // type-safe
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Açiklama);
                Console.WriteLine("===================");
            }

            Console.WriteLine("-----------METHODS------------");
            //Instance
            //Encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil Armut", 12);
        }
    }
}