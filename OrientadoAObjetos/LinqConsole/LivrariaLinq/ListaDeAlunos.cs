using System.Collections.Generic;

namespace LivrariaLinq
{
    public class ListaDeAlunos
    {

        public static List<Aluno> LoadAlunos()
        {
            List<Aluno> output = new List<Aluno>();

            output.Add(new Aluno { PrimeiroNome = "Torres", Apelido = "Carlos", DataNascimento = Convert.ToDateTime("2/25/1970"), DisciplinasFeitas = 20});
            output.Add(new Aluno { PrimeiroNome = "Jesuita", Apelido = "Susana", DataNascimento = Convert.ToDateTime("3/31/1970"), DisciplinasFeitas = 12 });
            output.Add(new Aluno { PrimeiroNome = "Susana", Apelido = "Sousa", DataNascimento = Convert.ToDateTime("1/3/1970"), DisciplinasFeitas = 1 });
            output.Add(new Aluno { PrimeiroNome = "Sara", Apelido = "Jesuita", DataNascimento = Convert.ToDateTime("3/6/1970"), DisciplinasFeitas = 8 });
            output.Add(new Aluno { PrimeiroNome = "Janota", Apelido = "Duarte", DataNascimento = Convert.ToDateTime("2/18/1970"), DisciplinasFeitas = 7 });
            output.Add(new Aluno { PrimeiroNome = "Maria", Apelido = "Susana", DataNascimento = Convert.ToDateTime("1/23/1970"), DisciplinasFeitas = 16 });

            return output;
        }
    }
}
