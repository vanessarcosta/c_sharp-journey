namespace DemoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Não se instancia classes abstratas
            //Empregado empregado1 = new Empregado();

            EmpregadoAssalariado empregado1 = new EmpregadoAssalariado("100", "Rita", "Pereira", 1000);
            //Console.WriteLine(empregado1);

            EmpregadoComissao empregado2 = new EmpregadoComissao("200", "Erick", "Avellar", 1000000, 0.15);
            //Console.WriteLine(empregado2);

            EmpregadoHoras empregado3 = new EmpregadoHoras("300", "Tânia", "Alves", 25, 25);
            //Console.WriteLine(empregado3);

            EmpregadoBaseMaisComissao empregado4 = new EmpregadoBaseMaisComissao("400", "Pedro", "Domingos", 10000, 0.20, 800);
            //Console.WriteLine(empregado4);

            List<Empregado> Funcionarios = new List<Empregado>();
            Funcionarios.Add(empregado1);
            Funcionarios.Add(empregado2);
            Funcionarios.Add(empregado3);
            Funcionarios.Add(empregado4);

            //Junta todos
            foreach (var funcionario in Funcionarios)
            {
                Console.WriteLine(funcionario.GetType());
                Console.WriteLine(funcionario);
            }

            Console.WriteLine();
            
            foreach (var funcionario in Funcionarios)
            {
                Console.WriteLine(funcionario.GetType());
                Console.WriteLine(funcionario);
                //consigue buscar os específicos
                var f = funcionario as EmpregadoAssalariado;

                if(f != null)
                {
                    //Fazer qualquer coisa com o dito cujo
                    Console.WriteLine("Aqui estou eu");
                }
            }
        }
    }
}
