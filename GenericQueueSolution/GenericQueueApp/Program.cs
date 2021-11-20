using System;
using System.Collections.Generic;

namespace GenericQueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> numbers = new MyQueue<int>();
            numbers.Enque(100);
            numbers.Enque(200);
            numbers.Enque(300);
            
            //Part-1
            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Dequeue());
            Console.WriteLine(numbers.Count());

            //Part-2
            PrintUsingForEach(numbers);
            PrintWithoutForEach(numbers);

            Console.ReadKey();
        }
        private static void PrintUsingForEach(IQueue<int> queue)
        {
            Console.WriteLine("\nUsing ForEach:");
            foreach (var item in queue) Console.WriteLine(item);
        }

        private static void PrintWithoutForEach(IQueue<int> queue)
        {
            Console.WriteLine("\nNot Using ForEach:");
            IEnumerator<int> iterator = queue.GetEnumerator();
            Console.WriteLine(iterator.GetType());
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }
    }
}
