using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCallStackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                M1();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(e.StackTrace);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("End of Main");
            Console.ReadLine();
        }
        public static void M1()
        {
            Console.WriteLine("Inside M1");
            M2();
        }
        public static void M2()
        {
            Console.WriteLine("Inside M2");
            M3();
        }
        public static void M3()
        {
            Console.WriteLine("Inside M3");
            throw new Exception("Something wrong in M3");
        }
    }
}
