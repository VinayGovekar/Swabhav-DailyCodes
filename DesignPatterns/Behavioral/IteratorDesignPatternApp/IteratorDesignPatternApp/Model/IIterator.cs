using System;
using System.Collections;

namespace IteratorDesignPatternApp.Model
{
    public interface IIterator:IEnumerable
    {
        bool MoveNext();
        object Current();
        int Count();
    }
}
