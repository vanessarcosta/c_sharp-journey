namespace Exc4_11Pesquisa;

class Program
{
    static void Main(string[] args)
    {
        int idade;
        double salario;
        char sexo, op;

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

            do
            {
                Console.WriteLine("Continuar a inserir dados (S/N)");
            }
            while (!char.TryParse(Console.ReadLine(), out op));
        }
        while (op == 's' || op == 'S');

    }
}
