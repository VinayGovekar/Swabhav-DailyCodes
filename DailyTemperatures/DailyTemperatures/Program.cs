using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTemperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = { 73, 74, 75, 71, 69, 72, 76, 73 };
            foreach (var tem in DailyTemperatures(temp)) Console.WriteLine(tem);
            Console.ReadKey();
        }
        public static int[] DailyTemperatures(int[] temperatures)
        {
            List<int> result = new List<int>();
            for(int i = 0; i < temperatures.Length; i++)
            {
                int count = 0;
                int j = i;
                while(j<temperatures.Length && temperatures[i] >= temperatures[j])
                {
                    count++;
                    if (j == temperatures.Length - 1) count = 0;
                    j++;
                }
                result.Add(count);
            }
            return result.ToArray();
        }
    }
}
