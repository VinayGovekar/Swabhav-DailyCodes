using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringProcessApp.Model
{
    public class CSEHiringProcess : HiringProcess
    {
        public override void MCQsTest()
        {
            Console.WriteLine("MCQ Test for cse students");
        }

        public override void TechnicalInterview()
        {
            Console.WriteLine("Technical interview for cse students");
        }
    }
}
