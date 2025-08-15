namespace Duration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int duration, hours, remainder, minutes, seconds;

            Console.Write("Digite a duração em segundos: ");
            duration = int.Parse(Console.ReadLine());

            hours = duration / 3600;
            remainder = duration % 3600;

            minutes = remainder / 60;
            seconds = remainder % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
