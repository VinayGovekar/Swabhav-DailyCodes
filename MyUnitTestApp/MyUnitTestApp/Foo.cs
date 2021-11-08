using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnitTestApp
{   [MyUnitTestClass]
    class Foo
    {
        [MyUnitTestMethod]
        public bool F1()
        {
            return true;
        }
        public bool F2()
        {
            return false;
        }
        [MyUnitTestMethod]
        public bool F3()
        {
            return true;
        }
    }
}
