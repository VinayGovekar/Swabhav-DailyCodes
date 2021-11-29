using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegateApp
{
    delegate void DMathOperations(int first, int second);
    class Program
    {
        static void Main(string[] args)
        {
            DMathOperations mathFunctions;
            mathFunctions = Add;
            mathFunctions += Subtract;
            mathFunctions += Multiply;
            mathFunctions += Division;
            mathFunctions += Modulus;

            int first = 10;
            int second = 2;
            Console.WriteLine("Integer are: {0} , {1}\n",first,second);
            mathFunctions(first,second);

            Console.ReadKey();
        }
        static void Add(int first,int second)
        {
            Console.WriteLine("Addition: {0}",first+second);
        }
        static void Subtract(int first, int second)
        {
            Console.WriteLine("Subtraction: {0}", first - second);
        }
        static void Multiply(int first, int second)
        {
            Console.WriteLine("Multiplication:  {0}", first * second);
        }
        static void Division(int first, int second)
        {
            Console.WriteLine("Division: {0}", first / second);
        }
        static void Modulus(int first, int second)
        {
            Console.WriteLine("Modulus: {0}", first % second);
        }
    }

}
