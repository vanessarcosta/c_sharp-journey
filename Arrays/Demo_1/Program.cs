namespace Demo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar arrays

            int[] numeros = new int[5];

            double[] contas = new double[10];

            //Declrar e inicializar os arrays

            int[] numeros2 = { 1, 60, 27, 126, 1432 };

            int[] numeros3 = new int[5] { 99, 98, 23, 34, 33 };

            numeros[0] = 1;
            numeros[1] = 60;
            numeros[2] = 27;
            numeros[3] = 126;
            numeros[4] = 1434;
            //numero[5] = 1000; fora dos limites do array

            //copiar array
            int[] n = numeros;

            Console.WriteLine($"{numeros[4]}");

            //Insirir dados no array (INPUT)

            for (int i = 0; i < numeros.Length; i++)
            {
                do
                {
                    Console.Write($"Insira o número {i + 1}: ");
                }
                while (!int.TryParse(Console.ReadLine(), out numeros[i]));

            }

            //Mostrar dados no array (OUTPUT)
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Número que está dentro da célula {i + 1} -> {numeros[i]}");
            }

            int quantidade;

            Console.WriteLine("Quantos nomes: ?");
            quantidade = Convert.ToInt32(Console.ReadLine());

            string[] turma = new string[quantidade];

            for (int i = 0; i < turma.Length; i++)
            {
                Console.Write($"Insira {i + 1}: ");
                turma[i] = Console.ReadLine();
            }
            
            Console.Clear();

            for (int j = 0; j < turma.Length; j++)
            {
                Console.WriteLine(turma[j]);
            }

        }
    }
}
