﻿using Course3.Entities;
namespace Course3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Fazer um programa que, a partir de uma lista de produtos, remova da
            ////lista somente aqueles cujo preço mínimo seja 100.

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            ////list.RemoveAll(p => p.Price >= 100.00   // lambda

            list.RemoveAll(ProductTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
