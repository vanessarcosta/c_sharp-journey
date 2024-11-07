using System;

namespace Exc3_1Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double precoTotal=0;

            Console.WriteLine("Especificação                Código           Preço");
            Console.WriteLine("Cachorro Quente                100             2.50");
            Console.WriteLine("Hambúrguer Simples             101             3.50");
            Console.WriteLine("Hambúrguer Especial            102             4.50");
            Console.WriteLine("Bifana Simples                 103             2.70");
            Console.WriteLine("Bifana com queijo e bacon      104             3.55");
            Console.WriteLine("Refrigerante                   105             1.75");

            do
            {
                Console.Write("\nInsira o código: ");
                codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insira o quantidade: ");
                quantidade = Convert.ToInt32(Console.ReadLine());

                switch (codigo)
                {
                    case 100:
                        precoTotal += quantidade * 2.50;
                        continue;
                    case 101:
                        precoTotal += quantidade * 3.50;
                        continue;
                    case 102:
                        precoTotal += quantidade * 4.50;
                        continue;
                    case 103:
                        precoTotal += quantidade * 2.70;
                        continue;
                    case 104:
                        precoTotal += quantidade * 3.55;
                        continue;
                    case 105:
                        precoTotal += quantidade * 1.75;
                        continue;                         
                }
            }
            while (codigo != 0);        

            Console.WriteLine($"O valor da conta é {precoTotal} euros");
        }
    }
}
