using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        //Naming Convention
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.Name);
        }

        public void Add2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
