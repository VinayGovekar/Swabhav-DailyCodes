using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateApp
{
    delegate void DPrintMessage(string name);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate:");
            DPrintMessage f1;
            f1 = PrintHello;
            f1("Vinay");

            f1 = PrintGoodbye;
            f1("Max");

            //f1 = PrintFoo; No overload for DPrintMessage 

            Console.WriteLine("\nCallBack using delegate:");
            MessageWizard(f1);
            MessageWizard(PrintHello);
            MessageWizard(PrintGoodbye);

            DPrintMessage f2;
            Console.WriteLine("\nMultiple Functions using delegates:");
            f2 = PrintHello;
            f2 += PrintGoodbye;
            f2 += PrintHello;
            f2 += PrintGoodbye;

            f2("Swabhav Tech");
            
            Console.ReadKey();
        }
        public static void PrintHello(string name)
        {
            Console.WriteLine("Hello says {0}",name);
        }
        public static void PrintGoodbye(string name)
        {
            Console.WriteLine("GoodBye says {0}",name);
        }
        public static void PrintFoo()
        {

        }
        public static void MessageWizard(DPrintMessage funct)
        {
            Console.WriteLine("Inside MessageWizard");
            funct("CHAMP");
        }
    }
}
