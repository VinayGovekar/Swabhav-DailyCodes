using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesSyntaxApp
{
    class Foo
    {
        private int _bar;//read-write
        private readonly int _baz;//read-only
        public Foo()
        {
            Random randomNumber = new Random();
            _baz = randomNumber.Next(0, 1);
        }
        public int Baz
        {
            get
            {
                return _baz;
            }
        }
        public int Bar
        {
            get
            {
                return _bar;
            }
            set
            {
                if (value > 0)
                {
                    _bar = value;
                }
            }
        }
    }
}
