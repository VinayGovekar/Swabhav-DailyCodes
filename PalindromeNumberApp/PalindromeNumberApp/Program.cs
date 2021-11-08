using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumberApp
{
    class Program
    {
        public static bool IsPalindrome(int x)
        {
            bool result = true;
            string number = x.ToString();
            int j = number.Length-1;
            for (int i = 0;i<(number.Length/2);i++)
            {
                if (number[i] != number[j])
                {
                    result = false;
                    break;
                }
                j -= 1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(-121));
            Console.ReadLine();
        }
    }
}
