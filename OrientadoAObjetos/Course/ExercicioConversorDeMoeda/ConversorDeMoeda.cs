namespace ExercicioConversorDeMoeda
{
    class ConversorDeMoeda
    {
        public static double iof = 6.0;
        public static double ConverterMoeda( double cotacaoDolar, double quantidadeDolar)
        {
            double reais = cotacaoDolar * quantidadeDolar;
            return reais + iof * reais / 100 ;
        }
    }
}
