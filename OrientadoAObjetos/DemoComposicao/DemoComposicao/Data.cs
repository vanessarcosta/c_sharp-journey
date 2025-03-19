namespace DemoComposicao
{
    public class Data
    {
        private int _mes;

        private int _dia;

        public int Ano { get; set; }

        public int Mes
        {
            get
            {
                return _mes;
            }
            set
            {
                if(value >= 1 && value <= 12)
                {
                    _mes = value;
                }
                else
                {
                    _mes = 1;
                }
            }
        }

        public int Dia
        {
            get
            {
                return _dia;
            }
            set
            {
                int[] diasDoMes = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if(Mes == 2 && value == 29 && (Ano % 400 == 0 || Ano % 4 == 0 && Ano % 100 != 0))
                {
                    _dia = value;
                    return;
                }

                if(value >= -1 && value <= diasDoMes[_mes])
                {
                    _dia = value;
                    return;
                }

                _dia = 1;
            }
        }

        public Data(int ano, int mes, int dia)
        {
            Ano = ano;
            Mes = mes;
            Dia = dia;
        }

        public override string ToString()
        {
            return $"{Ano}/{Mes}/{Dia}";
        }
    }
}
