using System;

namespace CompositePatternFolderApp
{
    public class File:IStorageItem
    {
        private string _name;
        private string _size;
        private static string _indentation = "\t";
        public File(string name,string size)
        {
            _name = name;
            _size = size;
        }
        public void Display()
        {
            Console.WriteLine(_indentation+"{0} : Size - {1}",_name,_size);
            _indentation += "\t";
        }
    }
}
