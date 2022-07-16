using System;

namespace FirstDuty // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dosya yolundaki örneği matrixe atama işlemi başlangıcı.
            string dosya_yolu = @"C:\Users\batuh\Desktop\LabirentAssignment\Lab1Yol0.txt";
            string[] xy = System.IO.File.ReadAllLines(dosya_yolu);
            char[,] elements = new char[xy.Length, 30];
            int firstIndex = 0;
            int secondIndex = 0;
            foreach (string x in xy)
            {
                foreach (char y in x)
                {

                    if (y == '0' || y == '1')
                    {
                        if (secondIndex == 30)
                        {
                            firstIndex++;
                            secondIndex = 0;
                        }
                        elements[firstIndex, secondIndex] = y;
                        secondIndex++;
                    }
                }
            }
            // Dosya yolundaki örneği matrixe atama işlemi sonu.

            //Mayın üretme örneği başlangıcı.
            Random rnd = new Random();
            int rowMine, columnMine;
            List<int> logRowMine = new List<int>();
            List<int> checkColumnMine = new List<int>();
            List<int> logColumnMine = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                rowMine = rnd.Next(30);
                logRowMine.Add(rowMine);
                do
                {
                    if (i == 0)
                    {
                        columnMine = rnd.Next(30);
                        checkColumnMine.Add(columnMine);
                    }
                    else
                    {
                        do
                        {
                            columnMine = rnd.Next(30);
                        } while (checkColumnMine.Contains(columnMine));
                        checkColumnMine.Add(columnMine);
                    }
                } while (elements[rowMine, columnMine] == '1');
                logColumnMine.Add(columnMine);
                elements[rowMine, columnMine] = '*';
            }
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {

                    Console.Write(elements[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Mayın üretme örneği sonu.
        }
    }
}