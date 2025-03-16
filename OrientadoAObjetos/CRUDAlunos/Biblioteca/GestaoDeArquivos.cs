using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class GestaoDeArquivos
    {
        public static void GravarInfoAluno(List<Aluno> alunos, string caminho)
        {//****quando chamar o coódigo colocar o try catch   //        aluno.GravarInfoAluno(Alunos);        Aluno aluno = new Aluno();

            string ficheiro = $@"{caminho}";

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

        public static List<Aluno> LerInfoDoAluno (string caminho)
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            string ficheiro = $@"{caminho}";

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
    }
}
