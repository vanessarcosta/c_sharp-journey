namespace DemoHeranca
{
    public class EmpregadoHoras : Empregado
    {
        private double _valorHora;

        private double _numeroHoras;

        public EmpregadoHoras(string id, string nomes, string apelido, double valorHora, double numeroHoras)
            : base(id, nomes, apelido)
        {
            _valorHora = valorHora;
            _numeroHoras = numeroHoras;
        }

        public override double SalarioAReceber()
        {
            return _valorHora * _numeroHoras;
        }

        public override string ToString()
        {
            return $"Empregado Horas -> {base.ToString()}, Horas = {_numeroHoras}, " +
                $"Valor Hora = {_valorHora}, Salário = {SalarioAReceber():C0}";

        }
    }
}
