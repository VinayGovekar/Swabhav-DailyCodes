
using System;

namespace CmdLineApp
{
    class Program
    {
        public static void PassByValue(int number)
        {
            number = number * 10;
            Console.WriteLine("Inside PassByValue Function Value: {0}", number);
        } 
        public static void PassByRef(ref int MainValue)
        {
            MainValue = MainValue * 100;
            Console.WriteLine("Inside Function Value: {0}", MainValue);
        }
        public static void Main(string[] args)
        {
            int MainValue = 10;
            Console.WriteLine("Main Value: {0}", MainValue);
            PassByValue(MainValue);
            Console.WriteLine("Outside PassByValue Function Value: {0}", MainValue);
            PassByRef(ref MainValue);
            Console.WriteLine("Outside PassByRef Function Value: {0}", MainValue);
            Console.ReadLine();

        }
    }
}
