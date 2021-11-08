using System;

namespace SerializationAndDeserializationApp
{
    [Serializable]
    class Account
    {
        private float _balance;
        public Account()
        {
            _balance = 1000f;
        }
        public float Balance { 
            get
            {
                return _balance;
            } 
        }
        public void Deposit(float amount)
        {
            _balance = _balance + amount;
        }
        public void Withdraw(float amount)
        {
            if ((_balance - amount) > 0) {
                _balance = _balance - amount;
            }
            else
            {
                Console.WriteLine("Not enough funds!!!");
            }
        }
    }
}
