using Coourse.Entities;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System;
using System.Globalization;
namespace Coourse
{
    class Program
    {
        static void Main(string[] args)
        {
            ////BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            ////Console.WriteLine(account.Balance);

            //protected não consigo alterar aqui, apenas na subclasse
            // account.Balance = 200.0;

            ////Account acc = new Account(1001, "Alex", 0.0);
            ////BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //////upcasting
            ////Account acc1 = bacc;
            ////Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            ////Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

            //////Downcasting
            //////implicitamente não pode    BusinessAccount acc4 = acc2;

            ////BusinessAccount acc4 = (BusinessAccount)acc2;
            ////acc4.Loan(100.0);

            ////// acc3 é SavingAccout subclasse que tipo # Business Account, não aparece o erro mas é incompativel
            ////// Severity Code    Description Project File Line    Suppression State
            //////Error(active)  MSB3021 Unable to copy file "C:\projects\c_sharp-journey\OrientadoAObjetos\Coourse\Coourse\obj\Debug\net8.0\apphost.exe" to "bin\Debug\net8.0\Coourse.exe".The process cannot access the file 'bin\Debug\net8.0\Coourse.exe' because it is being used by another process.Coourse C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets   5321
            //////            -- - ****BusinessAccount acc5 = (BusinessAccount)acc3;

            //////testar primeiro
            ////if(acc3 is BusinessAccount)
            ////{
            ////    //duas forma de casting
            ////    //BusinessAccount acc5 = (BusinessAccount)acc3;
            ////    BusinessAccount acc5 = acc3 as BusinessAccount;

            ////    acc5.Loan(200.0);
            ////    Console.WriteLine("Loan");
            ////}

            ////if (acc3 is SavingAccount)
            ////{
            ////    //duas forma de casting
            ////    //SavingAccount acc5 = (SavingAccount)acc3;
            ////    SavingAccount acc5 = acc3 as SavingAccount;
            ////    acc5.UpdateBalance();
            ////    Console.WriteLine("Update!");
            ////}****
            ///

            //////****
            ////Account acc1 = new Account(1001, "Alex", 500.0);
            ////Account acc2 = new SavingAccount(1002, "Anna", 500.0, 0.01);

            ////acc1.Withdraw(10.0);
            ////acc2.Withdraw(10.0);

            ////Console.WriteLine(acc1.Balance);
            ////Console.WriteLine(acc2.Balance);

            List<Account> list = new List<Account>();

            list.Add(new SavingAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Update balance for acccount"
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
