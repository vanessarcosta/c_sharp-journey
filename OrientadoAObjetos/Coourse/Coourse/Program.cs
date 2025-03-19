using Coourse.Entities;
namespace Coourse
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //protected não consigo alterar aqui, apenas na subclasse
            // account.Balance = 200.0;
        }
    }
}
