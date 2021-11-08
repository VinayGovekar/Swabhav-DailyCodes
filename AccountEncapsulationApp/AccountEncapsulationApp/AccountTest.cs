using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountEncapsulationApp.Model;

namespace AccountEncapsulationApp
{
    class AccountTest
    {
        static void Main(string[] args)
        {
           // CaseStudy1();
            CaseStudy2();
            Console.ReadLine();
        }
        static void CaseStudy1()
        {
            Account newAccount = new Account("Vinay",1000,2000.00);
            newAccount.Deposit(220.20);
            PrintDetails(newAccount);
            newAccount.Withdraw(2000.00);
            newAccount.Withdraw(1000.00);
            PrintDetails(newAccount);
        }
        static void CaseStudy2()
        {
            Account[] manyUsers = new Account[5];
            manyUsers[0]= new Account("One", 1000, 2000.00);
            manyUsers[1] = new Account("Two", 1001, 1000.00);
            manyUsers[2] = new Account("Three", 1002, 3000.00);
            manyUsers[3] = new Account("Four", 1003, 4000.00);
            manyUsers[4] = new Account("Five",1004, 5000.00);
            Console.WriteLine("All Users are:");
            PrintDetails(manyUsers);
            Console.WriteLine("\nRichest Account:");
            PrintDetails(FindRichestUser(manyUsers));
            Console.WriteLine("\nDistributing Money amoung other users except the richest");
            DistributeMoney(FindRichestUser(manyUsers), manyUsers);
            PrintDetails(manyUsers);
        }
        static void PrintDetails(Account[] manyUsers)
        {
            foreach (Account account in manyUsers)
            {
                PrintDetails(account);
            }
        }
        static void DistributeMoney(Account richUser,Account[] userList)
        {
            double amountToDistribute = (richUser.GetBalance() - 500.0) / (userList.Length-1);
            for(int i = 0; i < userList.Length; i++)
            {
                if (userList[i] != richUser)
                {
                    userList[i].Deposit(amountToDistribute);
                }
                else
                {
                    userList[i].Withdraw(userList[i].GetBalance()-500);
                }
            }
        }
        static Account FindRichestUser(Account[] manyAccounts)
        {
            Account richestUser = manyAccounts[0];
            for (int i = 0;i<manyAccounts.Length;i++)
            {
                if (richestUser.GetBalance() < manyAccounts[i].GetBalance())
                {
                    richestUser = manyAccounts[i];
                }
            }
            return richestUser;
        }
        static void PrintDetails(Account account)
        {
            Console.WriteLine("Account Details:\nAccount No:{0}, Name: {1}, Balance: {2}\n",account.GetAccountNumber(),account.GetName(),account.GetBalance());
        }
    }
}
