using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServicea)//Method Injection
        {   /**
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            Üst tarafda yazılan kod ile sen tüm kredi işlemlerini konuta kredisine fixledin
            **/
            krediManager.Hesapla();// buraya gönderidiğim kredinin referansını kullanacak
            foreach (var loggerService in loggerServicea)
            {
                loggerService.Log();
            } 
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
