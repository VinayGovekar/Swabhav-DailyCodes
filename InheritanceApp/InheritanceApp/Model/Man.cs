using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Model
{
    class Man
    {
        public void Read()
        {
            Console.WriteLine("Man is reading");
        }
        public virtual void Play()
        {
            Console.WriteLine("Man is playing");
        }
        public void Walk()
        {
            Console.WriteLine("Man is walking");
        }
    }
}
