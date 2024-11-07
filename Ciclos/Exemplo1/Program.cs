namespace Exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Ciclos ou estruturas de repetiçao
           //do...white(condição)
           //while(condição)

            int numero = 0;

            do
            {
                //corpo do ciclo
                Console.WriteLine(numero);
                numero++; //é a mesma coisa que numero = numero + 1;
            }
            while (numero <=20);

            //Quando sai do cilco anterior numero = 21

            while (numero >0)
            {
                //corpo do ciclo
                numero--;// numero = numero -1;
                Console.WriteLine(numero);
            }

        }
    }
}
