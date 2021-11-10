using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(101, "A new invoice", 100000, 10f, 5f);
            invoice.Print();
            Console.ReadKey();
        }
    }
}
