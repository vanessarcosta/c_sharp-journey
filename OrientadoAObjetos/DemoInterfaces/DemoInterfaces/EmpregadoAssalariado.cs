namespace DemoInterfaces
{
    public class EmpregadoAssalariado : Empregado
    {
        private readonly double _salarioMensal;

        public EmpregadoAssalariado(string id, string nomes, string apelido, double salarioMensal)
            : base(id, nomes, apelido)
        {
            _salarioMensal = salarioMensal;
        }

        public override double ValorAPagar()
        {
            return _salarioMensal;
        }

        public override string ToString()
        {
            return $"Empregado Assalariado -> {base.ToString()}, Salário = {ValorAPagar():c0}";
        }
    }
}
