using System;
using AccountPolymorphismApp.Model;
using System.Linq;

namespace AccountPolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount acc1 = new SavingsAccount(101, "Vinay", 5000);
            PrintDetails(acc1);
            CurrentAccount acc2 = new CurrentAccount(102,"Vinay",5000);
            PrintDetails(acc2);

            Console.WriteLine("\nWithdraw Test: ");
            acc1.Withdraw(4501);
            PrintDetails(acc1);
            acc2.Withdraw(10000);
            PrintDetails(acc2);

            Console.ReadLine();
        }

        public static void PrintDetails(Account account)
        {
            Console.WriteLine("\nAccount Details:");
            Console.WriteLine("Account Type: {0}",account.GetType().ToString().Split('.').Last());
            Console.WriteLine("Name: {0}",account.Name);
            Console.WriteLine("Account Number: {0}",account.AccountNumber);
            Console.WriteLine("Balance: {0}", account.Balance);
        }
    }
}
