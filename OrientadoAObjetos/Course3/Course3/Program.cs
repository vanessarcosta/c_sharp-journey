using Course3.Entities;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Linq;
using System;

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

            Console.WriteLine("-------------Action-----------");
            ////////Fazer um programa que, a partir de uma lista de produtos, aumente o
            ////////preço dos produtos em 10 %

            //list.ForEach(UpdatePrice);  

            //Action<Product> act = UpdatePrice;
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };

            //list.ForEach(act);
            list.ForEach(p => { p.Price += p.Price * 0.1; });   //lambda inline

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("-------------Func-----------");
            //////////Fazer um programa que, a partir de uma lista de produtos, gere uma
            //////////nova lista contendo os nomes dos produtos em caixa alta.

            //sem delegate
            //List<string> result = list.Select(NameUpper).ToList();

            //delegate
            //Func<Product, string> func =NameUpper;

            //sem referencia de método com lambda
            //Func<Product, string> func = p => p.Name.ToUpper();   // qdo o lamba retorna alguma coisa pode apagar as chaves e o return - p => { return p.Name.ToUpper(); };
            //List<string> result = list.Select(func).ToList();

            //lambda em inline
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
        //Func
        //////static string NameUpper(Product p)
        //////{
        //////    return p.Name.ToUpper();
        //////}
     

        //Action
        ////static void UpdatePrice(Product p)
        ////{
        ////    p.Price += p.Price * 0.1;
        ////}
        
        //Predicate
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
