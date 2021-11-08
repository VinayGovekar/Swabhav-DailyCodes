using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp2.Model
{
    class Parent
    {
        private int _foo;
        public Parent(int num)
        {
            _foo = num;
        }
        public int Foo
        {
            get
            {
                return _foo;
            }
        }
    }
}
