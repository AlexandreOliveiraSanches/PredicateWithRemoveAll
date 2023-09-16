using System;
using PredicateWithRemoveAll.Entities;
using System.Collections.Generic;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> p = new List<Product>();
            p.Add(new Product("Tv", 950));
            p.Add(new Product("Mouse", 80.50));
            p.Add(new Product("Tablet", 380));
            p.Add(new Product("Teclado", 92.70));

            p.RemoveAll(ProductTest);

            foreach(Product product in p)
            {
                Console.WriteLine(product);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100;
        }
    }
}