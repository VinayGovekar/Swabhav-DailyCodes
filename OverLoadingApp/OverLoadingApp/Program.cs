using System;


namespace OverLoadingApp
{
    class Program
    {   
        private static void PrintDetails(int content)
        {
            Console.WriteLine("Overload #1: {0}", content);
        }
        public static void PrintDetails(string content)
        {
            Console.WriteLine("Overload #2: {0}", content);
        }
        static void PrintDetails(double content)
        {
            Console.WriteLine("Overload #3: {0}", content);
        }
        static void PrintDetails(float content)
        {
            Console.WriteLine("Overload #4: {0}", content);
        }
        static void PrintDetails(bool content)
        {
            Console.WriteLine("Overload #5: {0}", content);
        }
        static void PrintDetails(char content)
        {
            Console.WriteLine("Overload #6: {0}", content);
        }
        public static void Main(string[] args)
        {
            PrintDetails(100);
            PrintDetails("Hundred");
            PrintDetails(10.10);
            PrintDetails(10.100f);
            PrintDetails(true);
            PrintDetails('#');
            Console.ReadLine();

        }
    }
}
