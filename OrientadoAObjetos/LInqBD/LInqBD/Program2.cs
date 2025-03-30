using System;
using System.Linq;

namespace LInqBD
{
    class Program2
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            //lista de filmes só dramáticos
            //var lista = from Filme in dc.Filmes where Filme.Categoria == "FD" select Filme;

            //Filmes começados "E"
            //var lista = from Filme in dc.Filmes where Filme.Titulo.StartsWith("O") select Filme;

            //Filmes com determinados conjunto de caracteres no título
            var lista = from Filme in dc.Filmes where Filme.Titulo.Contains("ext") select Filme;

            foreach (Filme filme in lista)
            {
                Console.WriteLine("ID: " + filme.ID);
                Console.WriteLine("Título: " + filme.Titulo);
                Console.WriteLine("Categoria: " + filme.Categoria);
                Console.WriteLine();
            }

            Console.WriteLine("Existem {0} filmes.", lista.Count());

            Console.WriteLine("------------------------------------------------------------------------------");

            //Agrupar informação - Contar filmes por categoria
            var novaLista = from Filme in dc.Filmes
                            group Filme by Filme.Categoria  //agrupar filmes por categoria
                            into c    //criar objeto generico
                            select new
                            {
                                Categoria = c.Key,  //a propriedade categoria será a chave do objeto c
                                Contagem = c.Count()  // propriedade Contagem conta todos filmes que tem a mesma chave
                            };

            foreach (var c in novaLista)
            {
                Console.WriteLine(c.Categoria + " (" + c.Contagem + ")");
            }

            Console.WriteLine("-----------------Junção entre tabelas-------------------------");

            var outraLista = from Filme in dc.Filmes
                             join Categoria in dc.Categorias
                             on Filme.Categoria equals Categoria.Sigla
                             select new
                             {
                                 Filme.ID,
                                 Filme.Titulo,
                                 Categoria.Categoria1,  //campos a serem incluidos no obj novo
                             };

            foreach (var c in outraLista)
            {
                Console.WriteLine("ID: " + c.ID);
                Console.WriteLine("Título: " + c.Titulo);
                Console.WriteLine("Categoria: " + c.Categoria1);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
