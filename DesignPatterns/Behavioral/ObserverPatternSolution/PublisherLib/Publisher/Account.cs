using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Publisher
{
    public class Account
    {
        private string _name;
        private string _email;
        private int _accountNumber;
        private double _balance;
        private List<INotifier> _notifiers = new List<INotifier>();

        public Account(string name, int accountNumber, double balance,string email)
        {
            _name = name;
            _accountNumber = accountNumber;
            _balance = balance;
            _email = email;
        }
        public string Email { get { return _email; } }
        public void AddNotifier(INotifier notifier)
        {
            _notifiers.Add(notifier);
        }
        public void Deposit(double amount)
        {
            _balance = _balance + amount;
            NotifySubscribers();
        }


        private void NotifySubscribers()
        {
            if (_notifiers.Count != 0)
            {
                foreach (var notifier in _notifiers) notifier.Notify(this);
            }
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
                NotifySubscribers();
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
