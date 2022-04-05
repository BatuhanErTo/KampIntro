using System;

namespace ClassIntro // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Batuhan";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "İbrahim";
            kurs2.IzlenmeOranı = 78;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Ruby";
            kurs3.Egitmen = "Işıl";
            kurs3.IzlenmeOranı = 88;

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOranı { get; set; }
    }
}