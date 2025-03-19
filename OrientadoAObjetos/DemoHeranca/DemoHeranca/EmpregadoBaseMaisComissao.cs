namespace DemoHeranca
{
    public class EmpregadoBaseMaisComissao : EmpregadoComissao
    {
        private double _salarioBase;

        public EmpregadoBaseMaisComissao(string id, string nomes, string apelido, double vendasBrutas, double taxaComissao, double salarioBase)
            : base(id, nomes, apelido, vendasBrutas, taxaComissao)
        {
            _salarioBase = salarioBase;
        }

        //public override double SalarioAReceber()
        //{
        //    return base.SalarioAReceber() + _salarioBase;  
        //}

        public double TotalSalarioReceber()
        { 
            return base.SalarioAReceber() + _salarioBase;
        }

        public override string ToString()
        {
            return $"Com Salario Base -> {base.ToString()} Base = {_salarioBase} Total = {TotalSalarioReceber():C0}";
        }
    }
}
