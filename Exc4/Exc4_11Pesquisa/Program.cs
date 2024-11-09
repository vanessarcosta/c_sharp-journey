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
                Console.WriteLine("Informe a idade: ");
            }
             while (!int.TryParse(Console.ReadLine(), out idade));

            do
            {
                Console.WriteLine("Informe o sexo (M/F)");
            }
            while (!char.TryParse(Console.ReadLine(), out sexo));

            do
            {
                Console.WriteLine("Informe o salário: ");
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

            if (sexo == 'F' || sexo == 'f' && salario <= 500.0)
            {
                qtdMulher++;
            }        

            do
            {
                Console.WriteLine("Continuar a inserir dados (S/N)");
            }
            while (!char.TryParse(Console.ReadLine(), out op));

        }
        while (op == 's' || op == 'S');

        Console.WriteLine($"A média de salário do grupo: {totalSalario / totalHabitantes}.");
        Console.WriteLine($"A maior idade é {maiorIdade}, e a menor idade é {menorIdade}.");
        Console.WriteLine($"Quantidade de mulheres com salário até 500 euros: {qtdMulher}.");

    }
}
