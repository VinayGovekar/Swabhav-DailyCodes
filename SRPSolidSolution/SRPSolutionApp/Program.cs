using System;

namespace SRPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoicePrinter = new InvoiceConsolePrinter();
            invoicePrinter.PrintInvoice(new Invoice(101, "Company Invoice", 100000, 10f, 5f));
            Console.ReadKey();
        }
    }
}
