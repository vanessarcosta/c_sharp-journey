namespace DemoInterfaces
{
    public abstract class Empregado : IPorPagar
    {
        public string Id { get; set; }

        public string Nomes { get; set; }

        public string Apelido { get; set; }

        public Empregado(string id, string nomes, string apelido)
        {
            Id = id;
            Nomes = nomes;
            Apelido = apelido;
        }

        public override string ToString()
        {
            return $"Id: {Id}  Nomes: {Nomes} Apelido: {Apelido}";
        }
        public abstract double ValorAPagar();
    }
}
