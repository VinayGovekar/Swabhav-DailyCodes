using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToIntegerApp
{
    class Program
    {
        public static int RomanToInt(string s)
        {
            int result = 0;
            s = s + 'Z';
            try
            {
                for (int i = 0; i < s.Length-1; i++)
                {
                    if (s[i] == 'I' && s[i + 1] == 'V')
                    {
                        result = result + 4;
                        i += 1;
                    }
                    else if (s[i] == 'I' && s[i + 1] == 'X')
                    {
                        result = result + 9;
                        i += 1;
                    }
                    else if (s[i] == 'X' && s[i + 1] == 'L')
                    {
                        result = result + 40;
                        i += 1;
                    }
                    else if (s[i] == 'X' && s[i + 1] == 'C')
                    {
                        result = result + 90;
                        i += 1;
                    }
                    else if (s[i] == 'C' && s[i + 1] == 'D')
                    {
                        result = result + 400;
                        i += 1;
                    }
                    else if (s[i] == 'C' && s[i + 1] == 'M')
                    {
                        result = result + 900;
                        i += 1;
                    }
                    else
                    {
                        result = result + ExactValue(s[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }
        public static int ExactValue(char c)
        {
            if (c == 'I')
            {
                return 1;
            }
            else if (c == 'V')
            {
                return 5;
            }
            else if (c == 'X')
            {
                return 10;
            }
            else if (c == 'L')
            {
                return 50;
            }
            else if (c == 'C')
            {
                return 100;
            }
            else if (c == 'D')
            {
                return 500;
            }
            else if (c == 'M')
            {
                return 1000;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("IV"));
            Console.ReadLine();
        }
    }
}
