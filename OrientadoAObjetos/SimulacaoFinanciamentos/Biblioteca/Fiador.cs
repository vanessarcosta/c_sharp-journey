namespace Biblioteca
{
    public class Fiador
    {
        public string NomeFiador { get; set; }
        public string MoradaFiador { get; set; }
        public int TelefoneFiador { get; set; }
        public int NifFiador { get; set; }
        public double RendimentoFiador { get; set; }

        public Fiador() { }
        public override string ToString()
        {
            return  $"\nFiador: {NomeFiador},Morada: {MoradaFiador}, NIF: {NifFiador}, Rendimento: {RendimentoFiador:F2}";
        }
    }
}
