namespace Biblioteca
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string NomeCompleto
        {
            get
            {
                return $"{Nome} {Apelido}";
            }
        }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Apelido}";
        }

        public void GravarInfoAluno(List<Aluno> alunos)
        {//****quando chamar o coódigo colocar o try catch   //        aluno.GravarInfoAluno(Alunos);        Aluno aluno = new Aluno();

            string ficheiro = @"alunoInfo.txt";

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

        public void LerInfoAluno(List<Aluno> alunos)
        {
            string ficheiro = @"alunoInfo.txt";

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);

                string linha = "";

                while((linha = sr.ReadLine()) != null)
                {
                    string[] campos = new string[3];

                    campos = linha.Split(';');

                    foreach (Aluno aluno in alunos)
                    {
                        aluno.Id = Convert.ToInt32(campos[0]);
                        aluno.Nome = campos[1];
                        aluno.Apelido = campos[2];
                    }
                }
                sr.Close();
            }
        }
    }
}
