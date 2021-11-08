using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class CurrentAccount:Account
    {
        public CurrentAccount(int accNum, string name, double balance) : base(accNum,name,balance)
        {
        }

        public override void Withdraw(double amount)
        {
            const double MIN_BAL = -5000.0;
            if ((this._balance - amount) <= MIN_BAL) Console.WriteLine("\nOut of Credits");
            else this._balance -= amount;
        }
    }
}
