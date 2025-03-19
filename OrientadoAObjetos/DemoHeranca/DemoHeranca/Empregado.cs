namespace DemoHeranca
{
    public abstract class Empregado
    {
        public string Id { get; set; }

        public string Nomes { get; set; }

        public string Apelido { get; set; }

        public Empregado(string id, string nomes, string apelidos)
        {
            Id = id;
            Nomes = nomes;
            Apelido = apelidos;
        }

        public override string ToString()
        {
            return $"Id: {Id} Nomes: {Nomes} Apelido: {Apelido}";
        }

        public abstract double SalarioAReceber();
    }
}
