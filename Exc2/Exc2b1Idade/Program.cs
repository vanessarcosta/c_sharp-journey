namespace Exc2b1Idade
{
    internal class Program              
    {
        static void Main(string[] args)
        {
            int categoria;

            Console.Write("Insira a idade do nadador: ");
             categoria = Convert.ToInt32(Console.ReadLine());

            if (categoria >= 18)
            {
                Console.WriteLine("Categoria adulto.");
            }
            else if (categoria >= 14)
            {
                Console.WriteLine("Categoria juvenil B");
            }
            else if (categoria >= 11)
            {
                Console.WriteLine("Categoria juvenil A");
            }
            else if (categoria >= 8)
            {
                Console.WriteLine("Categoria infantil B.");
            }
            else if (categoria >= 5)
            {
                Console.WriteLine("Categoria infantil A.");
            }
            else
            {
                Console.WriteLine("Sem categoria.");
            }
        }
    }
}
