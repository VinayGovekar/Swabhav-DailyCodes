using System;
using AccountCustomExceptionApp.Model;

namespace AccountCustomExceptionApp
{
    class InsufficientFundsException:Exception
    {
        private string _message;
        public InsufficientFundsException(Account account)
        {
            _message = "\nTransaction Declined for Account number:"+Convert.ToString(account.GetAccountNumber())+
                        " to maintain minimum balance\nAccount balance of"+ account.GetName() + " : "+account.GetBalance()+
                        "\nWithdrawal Amount was : "+Convert.ToString(account.WithdrawAmount);
        }
        public override string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
