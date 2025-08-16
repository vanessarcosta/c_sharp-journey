namespace PlayingTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double startTime, endTime, duration;

            Console.Write("Hora inicial: ");
            startTime = double.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            endTime = double.Parse(Console.ReadLine());

            if (endTime > startTime)
            {
                duration = endTime - startTime;                
            }
            else
            {
                duration = 24 - startTime + endTime;            
            }
            Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
        }
    }
}
