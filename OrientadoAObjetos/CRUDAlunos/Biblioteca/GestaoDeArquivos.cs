namespace Biblioteca
{
    public class GestaoDeArquivos
    {
        public static void GravarInfoDosAlunos(List<Aluno> alunos, string caminhoAlunos)
        {

            string ficheiro = $@"{caminhoAlunos}";

            string linha;

            StreamWriter sw = new StreamWriter(ficheiro, false);

            if (!File.Exists(ficheiro))
            {
                sw = File.CreateText(ficheiro);
            }

            foreach (Aluno aluno in alunos)
            {
                linha = $"{aluno.Id};{aluno.Nome};{aluno.Apelido}";
                sw.WriteLine(linha);
            }
            sw.Close();
        }

        public static List<Aluno> LerInfoDosAlunos(string caminhoAlunos)
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            string ficheiro = $@"{caminhoAlunos}";
            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);
                string linha = "";
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = new string[3];
                    campos = linha.Split(';');

                    Aluno aluno = new Aluno
                    {
                        Id = Convert.ToInt32(campos[0]),
                        Nome = campos[1],
                        Apelido = campos[2]
                    };
                    listaAlunos.Add(aluno);
                }
                sr.Close();
            }
            return listaAlunos;
        }
        public static void GravarInfoDasDisciplinas(List<Disciplina> disciplinas, string caminhoDisciplina)
        {

            string ficheiro = $@"{caminhoDisciplina}";

            string linha;

            StreamWriter sw = new StreamWriter(ficheiro, false);

            if (!File.Exists(ficheiro))
            {
                sw = File.CreateText(ficheiro);
            }

            foreach (Disciplina disciplina  in disciplinas)
            {
                linha = $"{disciplina.Id};{disciplina.Nome}";
                sw.WriteLine(linha);
            }
            sw.Close();
        }

        public static List<Disciplina> LerInfoDasDisciplinas(string caminhoDisciplinas)
        {
            List<Disciplina> listaDisciplinas = new List<Disciplina>();
            string ficheiro = $@"{caminhoDisciplinas}";
            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);
                string linha = "";

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = new string[2];

                    campos = linha.Split(';');

                    Disciplina disciplina = new Disciplina()
                    {
                        Id = Convert.ToInt32(campos[0]),
                        Nome = campos[1],
                    };
                    listaDisciplinas.Add(disciplina);
                }
                sr.Close();
            }
            return listaDisciplinas;
        }
    }
}
