using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Boy:Man
    {
        public void Jump()
        {
            Console.WriteLine("Boy is jumping");
        }
        public override void Play()
        {
            Console.WriteLine("Boy is playing");
        }
    }
}
