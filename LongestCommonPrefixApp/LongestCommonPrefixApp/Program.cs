using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefixApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(inputs));
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            for(int i = 0; i < strs[0].Length; i++)
            {
                result = result + strs[0][i];
                for(int j = 0; j < strs.Length; j++)
                {
                    if
                }
            }
            return result;
        }
    }
}
