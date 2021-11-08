using System;


namespace ExceptionGenerationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNo = int.Parse(args[0]);
            int secondNo = int.Parse(args[1]); 
            int result = firstNo / secondNo;
            Console.WriteLine("{0} / {1} = {2} ",firstNo,secondNo,result);
            Console.WriteLine("\nEnd of main");
            Console.ReadLine();
            Main(args);
        }
    }
}
/*
Class Name: System.OverflowException
Line no: 10

Class Name: System.FormatException
Line No: 10

Class Name: System.IndexOutOfRangeException
Line No; 11

Class Name: System.DivideByZeroException
Line No: 12
 */