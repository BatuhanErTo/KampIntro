using System;

namespace LinQ // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB RAM",UnitPrice = 10000,UnitsInStock = 5},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB RAM",UnitPrice = 18000,UnitsInStock = 3},
                new Product{ProductId = 3, CategoryId = 1, ProductName = "HP Laptop", QuantityPerUnit = "8 GB RAM",UnitPrice = 18000,UnitsInStock = 2},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB RAM",UnitPrice = 5000,UnitsInStock = 15},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB RAM",UnitPrice = 10000,UnitsInStock = 0}
            };

            //Any(products);

            //Find(products);

            //FindAll(products);

            //AscDesc(products);

            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 8000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var productDto in result)
            {
                Console.WriteLine("{0}------{1}",productDto.ProductName,productDto.CategoryName);
            }
        }

        private static void AscDesc(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAll(List<Product> products)
        {
            var result = products.FindAll(p => p.CategoryId == 2);
            foreach (var product in result)
            {
                Console.WriteLine(product.UnitPrice);
            }
        }

        private static void Find(List<Product> products)
        {
            var result = products.Find(p => p.CategoryId == 1);
            Console.WriteLine(result.ProductName);
        }

        private static void Any(List<Product> products)
        {
            var result = products.Any(p => p.ProductId == 5);
            Console.WriteLine(result);
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int UnitPrice { get; set; }
    }
}