using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp
{
    public class Invoice
    {
        private int _id;
        private string _description;
        private double _amount;
        private float _tax;
        private float _discount;

        public Invoice(int id, string description, double amount, float tax, float discount)
        {
            _id = id;
            _description = description;
            _amount = amount;
            _tax = tax;
            _discount = discount;
        }
        public double CalculateDiscount()
        {
            return ((_amount+CalculateTax()) * _discount) / 100;
        }
        public double CalculateTax()
        {
            return (_amount * _tax) / 100;
        }
        public double CalculateFinalAmount() {
            return _amount + CalculateTax() - CalculateDiscount();
        }
        public int ID { get { return _id; } }
        public string Description { get { return _description; } }
        public double Amount { get { return _amount; } }
        public float Tax { get { return _tax; } }
        public float Discount { get { return _discount; } }
    }
}