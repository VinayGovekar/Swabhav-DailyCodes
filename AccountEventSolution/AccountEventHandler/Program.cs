using System;
using AccountEventLib;

namespace AccountEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Vinay", 101, 10000);
            acc1.OnBalanceChanged += PrintDetails;
            //acc1.OnBalanceChanged(); The event can only occur on left side of += except when used in Account class itself;
            acc1.Deposit(1000);
            acc1.Withdraw(500);
            Console.ReadKey();
        }
        public static void PrintDetails(Account account)
        {
            Console.WriteLine("\nAccount Details: ");
            Console.WriteLine("Name: {0}\nId: {1}\nBalance: {2}",account.GetName(),account.GetAccountNumber(),account.GetBalance());
        }
    }
}
