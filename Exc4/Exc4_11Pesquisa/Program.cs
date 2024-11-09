namespace Exc4_11Pesquisa;

class Program
{
    static void Main(string[] args)
    {
        int idade;
        double salario;
        char sexo;

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

    }
}
