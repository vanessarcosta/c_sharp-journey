using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            ///list.Sort();    //ordenar a lista, so funciona se o tipo da lista (neste caso o Product) se ele implementa a interface IComparable

            /*  list.Sort(CompareProducts);  */ ///não passo produtos como argumento simplesmente coloco o nome da função (referencia para função **DELEGATE**
                                    //**referència simples de método como parâmetro

            //PODEMOS tbm criar uma várivel  
            //Comparison<Product> comp = CompareProducts;

            //usando lambida   ***expressão lambida atribuída a uma variável tipo delegate
            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            //list.Sort(comp);

            //colocando lambida diretamente no Sort   **expressão lambda inline
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
        }

        //**substituido por expressao lambida
        ////static int CompareProducts(Product p1, Product p2)
        ////{
        ////    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        ////}
    }
}
