using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** 
             Console.WriteLine("Hello World!");
             Add();
             Add2(20);// default value of second paremeter is 30 unless you give a value
             **/

            /**
             int number1 = 20;
             int number2 = 100;
             var result2 = Add3(ref number1, number2);
             // ref keyword is used for send  the  exactly the same number into function.
             Console.WriteLine(result2);
             Console.WriteLine(number1);
            **/

            /**
            int number1 = 20;
            int number2 = 100;
            var result2 = Add4(out number1, number2);
            // out and ref has a similar aim but difference between them is you don't have to assign the value if you use out
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            **/

            /**
             Console.WriteLine(Add5(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12));
            // PARAMS keyword
            **/



        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2 = 30)
        {
            var result = number1 + number2; 
            return result;
        }
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;   
        }
        static int Add4(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add5(int number1,params int[] number)
        {
            // first integer that given in main for number1 is the very first number that are written inside of the function
            return number.Sum();
        }
    }
}