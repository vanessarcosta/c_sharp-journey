namespace Exc2b4Comercio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double valorPagar = 0.0;

            Console.WriteLine("Código               Preço unitario");
            Console.WriteLine("1001                           5.32");
            Console.WriteLine("1324                           6.45");
            Console.WriteLine("6548                           2.37");
            Console.WriteLine("0987                           5.32");
            Console.WriteLine("7623                           6.45");

            Console.WriteLine("Código:");
            codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1001:              
                        valorPagar = quantidade * 5.32;
                    break;
                case 1324:
                        valorPagar = quantidade * 6.45;              
                    break;
                case 6548:
                        valorPagar = quantidade * 2.37;
                break;
                case 0987:
                        valorPagar = quantidade * 5.32;
                break;
                case 7623:
                        valorPagar = quantidade * 6.45;
                break;
                default:
                    Console.WriteLine("Código inválido!");
                    break;
            }        
                Console.WriteLine($"\nValor a pagar = {valorPagar} euros");            
        }
    }
}
