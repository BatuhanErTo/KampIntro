using System;

namespace OOP3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //Interfacelerde o interfeci implementde eden classın referans numarasını tutabilir

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService> {databaseLoggerService,new FileLoggerService() });

            List<IKrediManager> krediler= new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
