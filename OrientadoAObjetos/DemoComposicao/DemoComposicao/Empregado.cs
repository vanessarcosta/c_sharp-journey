using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComposicao
{
    public class Empregado
    {
        public string Nomes {  get; set; }

        public string Apelido { get; set; }

        public Data DataNascimento { get; set; }

        public Data DataContratacao { get; set; }

        public List<Morada> Moradas { get; set; }

        public Empregado(string nome, string apelido, Data dataNascimento, Data dataContratacao)
        {
            Nomes = nome;
            Apelido = apelido;
            DataNascimento = dataNascimento;
            DataContratacao = dataContratacao;
            Moradas = new List<Morada>();
        }

        public override string ToString()
        {
            return $"Nomes: {Nomes}, Apelido: {Apelido}, Contratado em: {DataContratacao}, Nascido em: {DataNascimento}";
        }
    }
}
