namespace Exc4_11Pesquisa;

class Program
{
    static void Main(string[] args)
    {
        int idade, totalHabitantes = 0, qtdMulher = 0;
        double salario, totalSalario = 0;
        char sexo, op;
        int maiorIdade = int.MinValue;
        int menorIdade = int.MaxValue;

        do
        {
            do
            {
                Console.Write("Informe a idade: ");
            }
             while (!int.TryParse(Console.ReadLine(), out idade));

            do
            {
                Console.Write("Informe o sexo (M/F): ");
                char.TryParse(Console.ReadLine().ToUpper(), out sexo);
            }
            while (!(sexo =='M') && !(sexo == 'F'));

            do
            {
                Console.Write("Informe o salário: ");
            }
            while (!double.TryParse(Console.ReadLine(), out salario));    

            if (maiorIdade < idade)
            {
                maiorIdade = idade;
            }

            if (menorIdade > idade)
            {
                menorIdade = idade;
            }

            totalHabitantes++;
            totalSalario += salario;

            if (sexo == 'F' && salario <= 500.0)
            {
                qtdMulher++;
            }        

            do
            {
                Console.Write("\n\nContinuar a inserir dados (S/N): ");
            }
            while (!char.TryParse(Console.ReadLine(), out op));

        }
        while (op == 's' || op == 'S');

        Console.WriteLine($"\n\nA média de salário do grupo: {totalSalario / totalHabitantes:N2}.");
        Console.WriteLine($"A maior idade é {maiorIdade}, e a menor idade é {menorIdade}.");
        Console.WriteLine($"Quantidade de mulheres com salário até 500 euros: {qtdMulher}.");

    }
}
