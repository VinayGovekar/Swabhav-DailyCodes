using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesSyntaxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo fooObj1 = new Foo();
            fooObj1.Bar = 100;
            Console.WriteLine("Bar: {0}",fooObj1.Bar);
            Console.WriteLine("Baz: {0}",fooObj1.Baz);
            Console.WriteLine("Baz Again: {0}", fooObj1.Baz);
            Console.ReadLine();
        }
    }
}
