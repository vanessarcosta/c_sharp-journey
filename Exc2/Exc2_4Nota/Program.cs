namespace Exc2_4Nota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota;

            Console.Write("Insira a nota: ");
            nota = Convert.ToDouble(Console.ReadLine());


            if (nota >= 0 && nota <= 20)
            {
                if (nota <= 5)
                {
                    Console.WriteLine("Fraco.");
                }
                else if (nota <= 9)
                {
                    Console.WriteLine("Insuficiente.");
                }
                else if (nota <= 14)
                {
                    Console.WriteLine("Satisfaz.");
                }
                else if (nota <= 18)
                {
                    Console.WriteLine("Bom.");
                }
                else if (nota <= 20)
                {
                    Console.WriteLine("Muito Bom.");
                }           
            }
            else
            {
                Console.WriteLine("Não é uma nota válida.");
            }
        }
    }
}
