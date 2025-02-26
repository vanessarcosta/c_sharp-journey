namespace Biblioteca
{
    public class Disciplina
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Nome}";
        }
    }
}
