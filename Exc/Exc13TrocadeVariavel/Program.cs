namespace Exc13TrocadeVariavel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trocar de variável

            int A, B, C;
            
            Console.Write("Digite o valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());

            C = A;
            A = B;
            B = C;

            Console.WriteLine($"\nValor A = {A} e B = {B}");
        }
    }
}
