using LivrariaLinq;

namespace LinqConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //como é static não precisa instanciar essa classe 
            List<Aluno> Alunos = ListaDeAlunos.LoadAlunos();


            //Ordenar por apelido
            Alunos = Alunos.OrderBy(x => x.Apelido).ToList();

            //Alunos = Alunos.OrderByDescending(x => x.Apelido).ToList();

            Alunos = Alunos.OrderByDescending(x => x.Apelido).ThenByDescending(x => x.DisciplinasFeitas).ToList();

            //Pesquisa
            //Alunos = Alunos.Where(x => x.DisciplinasFeitas > 10 && x.DataNascimento.Month == 3).ToList();

            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"{aluno.PrimeiroNome} " +
                                  $"{aluno.Apelido} " +
                                  $"{aluno.DataNascimento.ToShortDateString()} " +
                                  $"Disciplinas feitas: {aluno.DisciplinasFeitas}");
            }
            //sum soma
            int totalDisciplinasFeitas = Alunos.Sum(x => x.DisciplinasFeitas);
            //
            double mediaDisciplinasFeitas = Alunos.Average(x => x.DisciplinasFeitas);

            Console.WriteLine($"Total de disciplinas feitas: {totalDisciplinasFeitas}");
            Console.WriteLine($"Média de disciplinas feitas: {mediaDisciplinasFeitas:N2}");

            totalDisciplinasFeitas = Alunos.Where(x => x.DataNascimento.Month == 2).Sum(x => x.DisciplinasFeitas);
            mediaDisciplinasFeitas = Alunos.Where(x => x.DataNascimento.Month == 2).Average(x => x.DisciplinasFeitas);

            Console.WriteLine($"Total de disciplinas feitas em fevereiro: {totalDisciplinasFeitas}");
            Console.WriteLine($"Média de disciplinas feitas em fevereiro: {mediaDisciplinasFeitas}");

            Console.ReadKey();
        }
    }
}
