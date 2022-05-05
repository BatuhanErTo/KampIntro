using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager
    {
        //we use interfaces  for operational methods
        //Eğer birisi bu interfaci kullanırsa o arkadasım bunun icersindeki metotu kullanmak zorunda.
        void Hesapla();
        void BiseyYap();

    }
}
 