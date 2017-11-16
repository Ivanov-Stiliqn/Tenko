using System;
using System.Collections.Generic;
using System.Linq;

namespace SomeShit
{
    class Application
    {
        private static Shop shop;

        static void Main(string[] args)
        {
            shop = new Shop()
            {
                Name = "My shop",
                Products = new Dictionary<string, Product>()
            };

            AddProducts();
            GetProductsByBarcode("1111124");
            GetProductsByManufacturer("Nqkuv");

        }

        private static void GetProductsByManufacturer(string name)
        {
            var products = shop.Products.Values.Where(p => p.Manufacturer.Name == name);

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}: ${product.Price}");
            }
        }

        private static void GetProductsByBarcode(string barcode)
        {
            var product = shop.Products[barcode].Name;
            Console.WriteLine(product);
        }

        private static void AddProducts()
        {
            AddProduct("1111123", "sirene", 15, new Manufacturer()
            {
                Name = "Nqkuv"
            });

            AddProduct("1111124", "boza", 1.5m, new Manufacturer()
            {
                Name = "Nqkuv"
            });

            AddProduct("1111125", "hlqb", 2.3m, new Manufacturer()
            {
                Name = "Yambol Hlqb"
            });
        }

        private static void AddProduct(string barcode, string name, decimal price, Manufacturer manufacturer)
        {
            shop.Products.Add(barcode ,new Product()
            {
                Name = name,
                Price = price,
                Manufacturer = manufacturer
            });
        }
    }
}
