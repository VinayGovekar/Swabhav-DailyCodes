using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringProcessApp.Model
{
    public abstract class HiringProcess
    {
        public abstract void MCQsTest();
        public void GroupDiscussion()
        {
            Console.WriteLine("GD for all students");
        }
        public abstract void TechnicalInterview();
        public void HRInterview()
        {
            Console.WriteLine("HR interview for all students");
        }
    }
}
