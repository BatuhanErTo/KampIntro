using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] sayilar = new int[] {10,20,30};
            int[] sayilar2 = new int[] {100,200,300};
            sayilar = sayilar2;
            sayilar2[0] = 999;
        }
    }
}