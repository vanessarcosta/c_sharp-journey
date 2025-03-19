namespace DemoHeranca
{
    public class EmpregadoAssalariado : Empregado
    {
        private double _salarioMensal;

        public EmpregadoAssalariado(string id, string nomes, string apelido, double salarioMensal)
            :base(id, nomes, apelido)  ///chama o construtor da base
        {
            _salarioMensal = salarioMensal;
        }

        public override double SalarioAReceber()
        {
            return _salarioMensal;
        }

        public override string ToString()
        {
            return $"Empregado Assalariado -> {base.ToString()}, Salario = {SalarioAReceber():C0}";
        }
    }
}
