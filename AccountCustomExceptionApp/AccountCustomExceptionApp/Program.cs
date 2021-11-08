using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountCustomExceptionApp.Model;

namespace AccountCustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Vinay",101,5000);
            try
            {
                account.Withdraw(4501);
            }
            
            catch (InsufficientFundsException e)
            {
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nWill Execute no matter what");
                PrintDetails(account);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nEnd of Main");
            Console.ReadLine();
        }
        static void PrintDetails(Account account)
        {
            Console.WriteLine("Account Details:\nAccount No:{0}, Name: {1}, Balance: {2}\n", account.GetAccountNumber(), account.GetName(), account.GetBalance());
        }
    }
}
