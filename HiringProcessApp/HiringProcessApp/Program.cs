using System;
using HiringProcessApp.Model;

namespace HiringProcessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessSteps(new CSEHiringProcess());
            Console.ReadKey();
        }
        public static void ProcessSteps(HiringProcess process)
        {
            process.MCQsTest();
            process.GroupDiscussion();
            process.TechnicalInterview();
            process.HRInterview();
        }
    }
}
