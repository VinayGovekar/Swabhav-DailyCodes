using System;


namespace AccountEqualityApp.Model
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
            const double MINAMOUNT = 500.00;
            if (_balance - amount < MINAMOUNT)
            {
                Console.WriteLine("Not enough funds available!!!");
            }
            else
            {
                _balance = _balance - amount;
            }
        }
        public override bool Equals(object obj)
        {
            Account tempObj = (Account)obj;
            if(this._accountNumber == tempObj._accountNumber && this._name == tempObj._name && this._balance == tempObj._balance)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string retString = "\nChild:--> Name: " + this._name + ", Acc No: " + Convert.ToString(this._accountNumber) + ", Balance: " + Convert.ToString(_balance);
            
            return retString +"\nParent:--> "+ base.ToString();
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
