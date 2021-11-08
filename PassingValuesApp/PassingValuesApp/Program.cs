using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingValuesApp
{
    class Program
    {
        public static void UpdateScoreToZero(int pscore)
        {
            pscore = 0;
        }
        static void UpdateManyScoreToZero(int[] pscores) {
            for (int i=0;i<pscores.Length;i++)
            {
                pscores[i] = 0;
            }
        }
        static void Main(string[] args)
        {
            int score = 100;
            UpdateScoreToZero(score);
            Console.WriteLine(score);

            int[] manyScores = { 10, 20, 30, 40 };
            UpdateManyScoreToZero(manyScores);
            foreach (int s in manyScores) {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
