namespace DemoRef
{
    class Calculator
    {
        //solução que não funciona
        ////public static void Triple(int x)
        ////{
        ////    x = x * 3;

        ////    //Essa solução não funciona pq quando a função for chamada se cria um scope provisório e executa 10*3= 30 
        ////    // o 30 fica salvo em x e quando terminar e voltar pro Main a váriavel "a" não terá sido alterada 
        ///     //para resolver deve-ser acrescentar ref na função e na chamada
        ////}
        ///

        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Quadruple(int origin, out int result)
        {
            result = origin * 4;
        }
    }
}
