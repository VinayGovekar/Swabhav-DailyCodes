using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class SavingsAccount:Account
    {
        public SavingsAccount(int accNum,string name,double balance):base(accNum,name,balance) { 
        }

        public override void Withdraw(double amount)
        {
            const double MIN_CREDITS = 500.0;
            if ((this._balance - amount) <= MIN_CREDITS) Console.WriteLine("\nInsufficient Funds");
            else this._balance -= amount;
        }
    }
}
