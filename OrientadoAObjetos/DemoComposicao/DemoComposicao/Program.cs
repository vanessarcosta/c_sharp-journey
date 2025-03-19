namespace DemoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Data dataNascimento = new Data(1974, 13, 45);
            Data dataContrato = new Data(2013, 2, 6);

            //Empregado empregado = new Empregado("Paula", "Gomes", new Data(1974, 13, 45), null);

            Empregado empregado = new Empregado("Paula", "Gomes", dataNascimento, null);

            empregado.DataContratacao = new Data(1996, 9, 18);

            //empregado.Moradas =

            Console.WriteLine(empregado);

        }
    }
}
