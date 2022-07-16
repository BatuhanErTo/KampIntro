using EntityFramewokDemo;
using System;

namespace EntityFrameworkDemo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GetAll();
            GetAllByIndex(1);
        }

        static void GetAll()
        {
            NorthwindContext context = new NorthwindContext();
            foreach (var product in context.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void GetAllByIndex(int Id)
        {
            NorthwindContext context = new NorthwindContext();
            var result = context.Products.Where(p => p.CategoryId == Id);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
;       }
    }
}