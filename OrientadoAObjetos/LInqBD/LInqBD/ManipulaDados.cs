using System;
using System.Linq;

namespace LInqBD
{
    class ManipulaDados
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            //Inserir novo registro***********
            Filme f = new Filme
            {
                ID = dc.Filmes.Count() + 100,
                Titulo = "O Exterminador 3",
                Categoria = "FA",
            };

            dc.Filmes.InsertOnSubmit(f);  //inseri na tabela do linq e não na tabale da BD

            try
            {
                dc.SubmitChanges(); //adiciona na tabela da BD
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var lista = from Filme in dc.Filmes select Filme;

            foreach (Filme filme in lista)
            {
                Console.WriteLine("ID: " + filme.ID);
                Console.WriteLine("Título: " + filme.Titulo);
                Console.WriteLine("Categoria: " + filme.Categoria);
                Console.WriteLine();
            }

            Console.WriteLine("Existem {0} filmes.", lista.Count());

            Console.WriteLine("------------------------------------Alterar Registro-------------------------------------");
            //Alterar registro

            int idAlterar = 4;

            var pesquisa = from Filme in dc.Filmes
                           where Filme.ID == idAlterar
                           select Filme;

            f = pesquisa.Single();  //busca o registro
            f.Titulo = "O Titulo foi alterado";

            try
            {
                dc.SubmitChanges();
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            var lista2 = from Filme in dc.Filmes select Filme;

            foreach (Filme filme in lista2)
            {
                Console.WriteLine("ID: " + filme.ID);
                Console.WriteLine("Título: " + filme.Titulo);
                Console.WriteLine("Categoria: " + filme.Categoria);
                Console.WriteLine();
            }

            Console.WriteLine("Existem {0} filmes.", lista.Count());

            Console.WriteLine("------------------------------------Eliminar Registro-------------------------------------");
            //Eliminar registro

            Filme f2 = new Filme();

            var outraPesquisa = from Filme in dc.Filmes
                           where Filme.ID == 5
                           select Filme;

            if(outraPesquisa.Count() == 0)
            {
                Console.WriteLine("O Filme a apagar já foi apagado.");
                Console.ReadKey();
                return;
            }

            f2 = outraPesquisa.Single();  //busca o registro

            dc.Filmes.DeleteOnSubmit(f2);

            try
            {
                dc.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var listaApagada = from Filme in dc.Filmes select Filme;

            foreach (Filme filme in listaApagada)
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
