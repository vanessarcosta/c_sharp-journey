namespace Biblioteca
{
    public static class GestaoDeArquivos
    {
        public static void GravarInfoDosAlunos(List<Aluno> alunos, string caminhoAlunos, List<Disciplina> disciplinasInscritas)
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
                if (aluno.DisciplinasInscritas.Count > 0)
                {
                    string idDisciplinaInscrita = "";
                    foreach (Disciplina disciplina in aluno.DisciplinasInscritas)
                    {
                        if (idDisciplinaInscrita == "")
                        {
                            idDisciplinaInscrita = disciplina.Id.ToString();
                        }
                        else
                        {
                            idDisciplinaInscrita += ";" + disciplina.Id;
                        }
                    }
                    linha = $"{aluno.Id};{aluno.Nome};{aluno.Apelido},{idDisciplinaInscrita}";
                    sw.WriteLine(linha);
                }
                else
                {
                    linha = $"{aluno.Id};{aluno.Nome};{aluno.Apelido}";
                    sw.WriteLine(linha);
                }
            }
            sw.Close();
        }
        public static List<Aluno> LerInfoDosAlunos(string caminhoAlunos, string caminhoDisciplina)
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            List<Disciplina> disciplinasDisponiveis = LerInfoDasDisciplinas(caminhoDisciplina);
            string ficheiro = $@"{caminhoAlunos}";
            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);
                string linha = "";
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(',');
                    string[] camposAluno = campos[0].Split(";");
                    Aluno aluno = new Aluno
                    {
                        Id = Convert.ToInt32(camposAluno[0]),
                        Nome = camposAluno[1],
                        Apelido = camposAluno[2],
                        DisciplinasInscritas = new List<Disciplina>(),
                    };
                    if (campos.Length > 1)
                    {
                        string[] idsDisciplinas = campos[1].Split(";");

                        foreach (string id in idsDisciplinas)
                        {
                            int idDisciplina = Convert.ToInt32(id);
                            foreach (Disciplina disciplina in disciplinasDisponiveis)
                            {
                                if (idDisciplina == disciplina.Id)
                                    aluno.DisciplinasInscritas.Add(disciplina);
                            }
                        }
                    }
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

            foreach (Disciplina disciplina in disciplinas)
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
