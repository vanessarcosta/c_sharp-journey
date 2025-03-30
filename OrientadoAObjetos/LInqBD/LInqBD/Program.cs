using System;
using System.Linq;

namespace LInqBD
{
     class Program
    {
        static void Main2(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            //obter a listagem completa de filmes
            //var lista = from Filme in dc.Filmes orderby Filme.Titulo select Filme;

            //
            var lista = from Filme in dc.Filmes orderby Filme.Titulo descending, Filme.ID select Filme;

            foreach (Filme filme in lista)
            {
                Console.WriteLine("ID: " + filme.ID);
                Console.WriteLine("Título: " + filme.Titulo);
                Console.WriteLine("Categoria: " + filme.Categoria);
                Console.WriteLine();
            }

            Console.WriteLine("Existem {0} filmes.", lista.Count());
            Console.ReadKey();
        }
    }
}
