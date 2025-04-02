using Course3.Entities;
using System.Net;
using System.Runtime.Intrinsics.X86;
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


        }
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
