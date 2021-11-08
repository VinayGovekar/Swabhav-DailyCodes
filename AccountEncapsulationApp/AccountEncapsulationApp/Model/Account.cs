using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEncapsulationApp.Model
{
    class Account
    {
        private string _name;
        private int _accountNumber;
        private double _balance;

        public Account(string name, int accountNumber, double balance)
        {
            _name = name;
            _accountNumber = accountNumber;
            _balance = balance;
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }
        public void Withdraw(double amount)
        {
            const double MINAMOUNT=500.00;
            if (_balance - amount < MINAMOUNT)
            {
                Console.WriteLine("Not enough funds available!!!");
            }
            else
            {
                _balance = _balance - amount;
            }
        }
        public int GetAccountNumber()
        {
            return _accountNumber;
        }
        public string GetName()
        {
            return _name;
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
