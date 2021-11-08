using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    abstract class Account
    {
        private int _accountNumber;
        private string _name;
        protected double _balance;

        public Account(int accNum, string name, double balance)
        {
            _accountNumber = accNum;
            _name = name;
            _balance = balance;
        }
        public void Deposit(double amount)
        {
            _balance += amount; 
        }

        public abstract void Withdraw(double amount);

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
    }
}
